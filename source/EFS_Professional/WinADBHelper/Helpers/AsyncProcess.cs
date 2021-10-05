namespace EFS_Professional.WinADBHelper.Helpers
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class AsyncProcess
    {
        public event OnAsyncProcessHasExitedEventHandler OnAsyncProcessHasExited;

        public event OnOutputDataReceivedEventHandler OnOutputDataReceived;

        internal void AsyncProcessHasExited(object sender, EventArgs e)
        {
            OnAsyncProcessHasExitedEventHandler onAsyncProcessHasExitedEvent = this.OnAsyncProcessHasExitedEvent;
            if (onAsyncProcessHasExitedEvent != null)
            {
                onAsyncProcessHasExitedEvent(RuntimeHelpers.GetObjectValue(sender), e);
            }
        }

        internal void OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                OnOutputDataReceivedEventHandler onOutputDataReceivedEvent = this.OnOutputDataReceivedEvent;
                if (onOutputDataReceivedEvent != null)
                {
                    onOutputDataReceivedEvent(RuntimeHelpers.GetObjectValue(sender), e);
                }
            }
        }

        internal void RunProcessASync(string executable, string arguments, bool waitForExit = true)
        {
            Process process = new Process {
                StartInfo = { 
                    FileName = executable,
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                },
                EnableRaisingEvents = true
            };
            process.OutputDataReceived += new DataReceivedEventHandler(this.OutputDataReceived);
            process.Exited += new EventHandler(this.AsyncProcessHasExited);
            process.Start();
            process.BeginOutputReadLine();
            if (waitForExit)
            {
                process.WaitForExit();
            }
        }

        public delegate void OnAsyncProcessHasExitedEventHandler(object sender, EventArgs e);

        public delegate void OnOutputDataReceivedEventHandler(object sender, DataReceivedEventArgs e);
    }
}


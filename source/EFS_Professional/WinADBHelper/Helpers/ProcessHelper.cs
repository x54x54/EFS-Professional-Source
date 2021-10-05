namespace EFS_Professional.WinADBHelper.Helpers
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using System.Threading;

    internal class ProcessHelper
    {
        private static bool ContainsAnyCase(string s, string str) => 
            s.ToLower().Contains(str.ToLower());

        private static string ExactCaseMatch(string s)
        {
            string str2 = "";
            int num2 = s.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                if ((i == 0) && char.IsLetter(s[i]))
                {
                    str2 = str2 + Conversions.ToString(char.ToUpper(s[i]));
                }
                else if (char.IsWhiteSpace(s[i - 1]) || (char.IsControl(s[i - 1]) && char.IsLetter(s[i])))
                {
                    str2 = str2 + Conversions.ToString(char.ToUpper(s[i]));
                }
                else
                {
                    str2 = str2 + Conversions.ToString(char.ToLower(s[i]));
                }
            }
            return str2;
        }

        public static bool IsProcessRunning(string processName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLower() == processName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static void KillProcess(string processName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.ToLower().Contains(processName.ToLower()))
                {
                    process.Kill();
                    break;
                }
            }
        }

        public static IntPtr RunProcessDeviceADBShell(string executable)
        {
            Process process = new Process {
                StartInfo = { 
                    FileName = executable,
                    Arguments = "shell",
                    WindowStyle = ProcessWindowStyle.Normal,
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    RedirectStandardError = false,
                    RedirectStandardOutput = false
                }
            };
            process.Start();
            Thread.Sleep(200);
            if (!process.HasExited)
            {
                return process.MainWindowHandle;
            }
            return IntPtr.Zero;
        }

        public static void RunProcessNoOutput(string executable, string arguments, bool waitForExit = true)
        {
            Process process = new Process {
                StartInfo = { 
                    FileName = executable,
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };
            process.Start();
            if (waitForExit)
            {
                process.WaitForExit();
            }
        }

        public static bool RunProcessOutputContains(string executable, string arguments, string containsString, bool ignoreCase = false)
        {
            string str;
            Process process = new Process {
                StartInfo = { 
                    FileName = executable,
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };
            process.Start();
            string str2 = process.StandardOutput.ReadToEnd();
            string str3 = process.StandardError.ReadToEnd();
            if (str3.Trim() == "")
            {
                str = str2;
            }
            else
            {
                str = str3;
            }
            if (ignoreCase)
            {
                return ContainsAnyCase(str, containsString);
            }
            return str.Contains(containsString);
        }

        public static string RunProcessShowOutput(string executable, string arguments)
        {
            Process process = new Process {
                StartInfo = { 
                    FileName = executable,
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardOutput = true
                }
            };
            process.Start();
            string str = process.StandardOutput.ReadToEnd();
            string str3 = process.StandardError.ReadToEnd();
            if (str3.Trim() == "")
            {
                return str.TrimEnd(new char[0]);
            }
            return str3.TrimEnd(new char[0]);
        }

        public static string RunProcessShowOutput(string executable, string arguments, bool forceRegular)
        {
            Process process = new Process {
                StartInfo = { 
                    FileName = executable,
                    Arguments = arguments,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                }
            };
            process.Start();
            string str = process.StandardOutput.ReadToEnd();
            string str3 = process.StandardError.ReadToEnd();
            if ((str3.Trim() == "") | forceRegular)
            {
                return str.TrimEnd(new char[0]);
            }
            return str3.TrimEnd(new char[0]);
        }
    }
}


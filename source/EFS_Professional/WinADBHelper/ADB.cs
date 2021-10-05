namespace EFS_Professional.WinADBHelper
{
    using EFS_Professional.WinADBHelper.Helpers;
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class ADB
    {
        private static string ADB_Path = (Application.StartupPath.ToString() + @"\ADB\adb.exe");
        private static char[] Invalids = new char[] { '\0', '\n', '\r', ' ' };

        public static ADBCommand CreateADBCmd(string command, params string[] args)
        {
            string cmd = (args.Length > 0) ? (command + " ") : command;
            int num2 = args.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                cmd = cmd + args[i] + " ";
            }
            return new ADBCommand(cmd);
        }

        public static ADBCommand CreateADBCmd(DeviceIO device, string command, params string[] args) => 
            CreateADBCmd("-s " + device.SerialNumber + " " + command, args);

        public static ADBCommand CreateADBShellCmd(DeviceIO device, bool rootShell, string binary, params string[] args)
        {
            string str = $"-s {device.SerialNumber} shell ";
            if (rootShell)
            {
                str = str + "su -c \"" + binary;
            }
            else
            {
                str = str + "\"" + binary;
            }
            int num2 = args.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                str = str + " " + args[i];
            }
            return new ADBCommand(str + "\" ; echo 'exitcode='$?");
        }

        public static string Devices() => 
            IssueADBCmd(CreateADBCmd("devices", new string[0]));

        public static string IssueADBCmd(ADBCommand cmd) => 
            ProcessHelper.RunProcessShowOutput(ADB_Path, cmd.Command).Trim(Invalids);

        private static void IssueADBCmd(AsyncProcess procInstance, ADBCommand cmd)
        {
            procInstance.RunProcessASync(ADB_Path, cmd.Command, true);
        }

        public static void IssueADBCmdASync(AsyncProcess procInstance, ADBCommand cmd)
        {
            _Closure$__14 e$__ = new _Closure$__14 {
                $VB$Local_procInstance = procInstance,
                $VB$Local_cmd = cmd
            };
            new Thread(new ThreadStart(e$__._Lambda$__93)).Start();
        }

        public static void IssueADBCmdNoOutput(ADBCommand cmd)
        {
            ProcessHelper.RunProcessNoOutput(ADB_Path, cmd.Command, true);
        }

        public static void KillServer()
        {
            IssueADBCmdNoOutput(CreateADBCmd("kill-server", new string[0]));
        }

        private static void Reboot()
        {
            IssueADBCmdNoOutput(CreateADBCmd("reboot", new string[0]));
        }

        public static void Reboot(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(ADB.Reboot)).Start();
            }
            else
            {
                Reboot();
            }
        }

        private static void RebootBootLoader()
        {
            IssueADBCmdNoOutput(CreateADBCmd("reboot", new string[] { "bootloader" }));
        }

        public static void RebootBootLoader(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(ADB.RebootBootLoader)).Start();
            }
            else
            {
                RebootBootLoader();
            }
        }

        private static void RebootDownload()
        {
            IssueADBCmdNoOutput(CreateADBCmd("reboot", new string[] { "download" }));
        }

        public static void RebootDownload(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(ADB.RebootDownload)).Start();
            }
            else
            {
                RebootDownload();
            }
        }

        private static void RebootRecovery()
        {
            IssueADBCmdNoOutput(CreateADBCmd("reboot", new string[] { "recovery" }));
        }

        public static void RebootRecovery(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(ADB.RebootRecovery)).Start();
            }
            else
            {
                RebootRecovery();
            }
        }

        public static IntPtr StartDeviceADBShell()
        {
            IntPtr ptr = ProcessHelper.RunProcessDeviceADBShell(ADB_Path);
            if (ptr != IntPtr.Zero)
            {
                return ptr;
            }
            return IntPtr.Zero;
        }

        public static void StartServer()
        {
            IssueADBCmdNoOutput(CreateADBCmd("start-server", new string[0]));
        }

        public static bool IsADBServerRunning =>
            ProcessHelper.IsProcessRunning("adb");

        [CompilerGenerated]
        internal class _Closure$__14
        {
            public ADBCommand $VB$Local_cmd;
            public AsyncProcess $VB$Local_procInstance;

            [CompilerGenerated]
            public void _Lambda$__93()
            {
                ADB.IssueADBCmd(this.$VB$Local_procInstance, this.$VB$Local_cmd);
            }
        }
    }
}


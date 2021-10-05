namespace EFS_Professional.WinADBHelper
{
    using EFS_Professional.WinADBHelper.Helpers;
    using System;
    using System.Threading;

    public class Fastboot
    {
        private static string Fastboot_Path = (Application.StartupPath.ToString() + @"\ADB\fastboot.exe");

        private Fastboot()
        {
        }

        public static FastbootCommand CreateFastbootCmd(string command, params string[] args)
        {
            string cmd = (args.Length > 0) ? (command + " ") : command;
            int num2 = args.Length - 1;
            for (int i = 0; i <= num2; i++)
            {
                cmd = cmd + args[i] + " ";
            }
            return new FastbootCommand(cmd);
        }

        public static FastbootCommand CreateFastbootCmd(DeviceIO device, string command, params string[] args) => 
            CreateFastbootCmd("-s " + device.SerialNumber + " " + command, args);

        public static string Devices() => 
            IssueFastbootCmd(CreateFastbootCmd("devices", new string[0]));

        public static string IssueFastbootCmd(FastbootCommand cmd) => 
            ProcessHelper.RunProcessShowOutput(Fastboot_Path, cmd.Command);

        public static void IssueFastbootCmdNoOutput(FastbootCommand cmd)
        {
            ProcessHelper.RunProcessNoOutput(Fastboot_Path, cmd.Command, true);
        }

        private static void PowerDown()
        {
            IssueFastbootCmdNoOutput(CreateFastbootCmd("oem", new string[] { "powerdown" }));
        }

        public static void PowerDown(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(Fastboot.PowerDown)).Start();
            }
            else
            {
                PowerDown();
            }
        }

        private static void Reboot()
        {
            IssueFastbootCmdNoOutput(CreateFastbootCmd("reboot", new string[0]));
        }

        public static void Reboot(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(Fastboot.Reboot)).Start();
            }
            else
            {
                Reboot();
            }
        }

        private static void RebootBootLoader()
        {
            IssueFastbootCmdNoOutput(CreateFastbootCmd("reboot-bootloader", new string[0]));
        }

        public static void RebootBootLoader(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(Fastboot.RebootBootLoader)).Start();
            }
            else
            {
                RebootBootLoader();
            }
        }
    }
}


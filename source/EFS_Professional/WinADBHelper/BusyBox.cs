namespace EFS_Professional.WinADBHelper
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class BusyBox
    {
        private static List<string> _commands;
        private static DeviceIO _device;
        private static bool _isInstalled;
        private static string _version;

        public BusyBox(DeviceIO device)
        {
            _device = device;
            _commands = new List<string>();
            Update();
        }

        public static void Update()
        {
            _commands.Clear();
            using (StringReader reader = new StringReader(ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "busybox", new string[0]))))
            {
                string str = reader.ReadLine();
                if (str.ToLower().Contains($"{"busybox"}: not found") || str.ToLower().Contains("permission denied"))
                {
                    _isInstalled = false;
                    _version = string.Empty;
                }
                else
                {
                    _isInstalled = true;
                    _version = str.Split(new char[] { ' ' })[1].Substring(1);
                    while (reader.ReadLine() != "Currently defined functions:")
                    {
                    }
                    foreach (string str2 in reader.ReadToEnd().Replace(" ", "").Replace("\r\r\n\t", "").Trim(new char[] { '\t', '\r', '\n' }).Split(new char[] { ',' }))
                    {
                        _commands.Add(str2);
                    }
                }
            }
        }

        public static List<string> Commands =>
            _commands;

        public static bool IsInstalled =>
            _isInstalled;

        public static string Version =>
            _version;
    }
}


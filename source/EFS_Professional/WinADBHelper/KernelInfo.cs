namespace EFS_Professional.WinADBHelper
{
    using Microsoft.VisualBasic;
    using System;

    public class KernelInfo
    {
        private static DeviceIO _device;
        private static string _release;
        private static string _version;

        public KernelInfo(DeviceIO device)
        {
            _device = device;
            GetKernelVersion();
        }

        public static void GetKernelVersion()
        {
            string str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "cat", new string[] { "/proc/sys/kernel/osrelease", ";", "cat", "/proc/sys/kernel/version" }));
            if (!string.IsNullOrEmpty(str.TrimEnd(new char[0])))
            {
                string[] strArray = Strings.Split(str.TrimEnd(new char[0]), "\r\n", -1, CompareMethod.Binary);
                _release = strArray[0].TrimEnd(new char[0]);
                _version = strArray[1].TrimEnd(new char[0]);
            }
            else
            {
                _release = string.Empty;
                _version = string.Empty;
            }
        }

        public override string ToString()
        {
            bool flag = true;
            if ((flag != (_release == string.Empty)) && (flag != (_version == string.Empty)))
            {
                return (_release + " " + _version);
            }
            return string.Empty;
        }

        public static string Release =>
            _release;

        public static string Version =>
            _version;
    }
}


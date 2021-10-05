namespace EFS_Professional.WinADBHelper
{
    using System;
    using System.IO;

    public class SU_Binary
    {
        private static DeviceIO _device;
        private static bool _isPresent;
        private static string _version;

        public SU_Binary(DeviceIO device)
        {
            _device = device;
            GetSUInfo();
        }

        private static void GetSUInfo()
        {
            using (StringReader reader = new StringReader(ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "su", new string[] { "-v" }))))
            {
                string str = reader.ReadLine();
                if (str.ToLower().Contains("not found") | str.ToLower().Contains("permission denied"))
                {
                    _version = string.Empty;
                    _isPresent = false;
                }
                else
                {
                    _version = str;
                    _isPresent = true;
                }
            }
        }

        public static bool IsPresent =>
            _isPresent;

        public string Version =>
            _version;
    }
}


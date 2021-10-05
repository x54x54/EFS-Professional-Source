namespace EFS_Professional.WinADBHelper
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;

    public class DeviceIO
    {
        private EFS_Professional.WinADBHelper.BuildPropertyParser _buildPropertyParser;
        private EFS_Professional.WinADBHelper.BusyBox _busyBox;
        private EFS_Professional.WinADBHelper.FileSystem _fileSystem;
        private EFS_Professional.WinADBHelper.KernelInfo _kernelInfo;
        private string _serialNumber;
        private DeviceState _state;
        private SU_Binary _suBinary;
        private char[] Invalids = new char[] { '\n', '\r', ' ' };

        public DeviceIO(string deviceSerial)
        {
            this._serialNumber = deviceSerial;
            this.Update();
        }

        public bool InstallAPK(string location) => 
            Conversions.ToBoolean(ADB.IssueADBCmd(ADB.CreateADBCmd(this, "install", new string[] { "\"" + location + "\"" })));

        public RootAccessType IsRooted()
        {
            string str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this, false, "su", new string[] { "-c", "id" }));
            bool flag = true;
            if (flag == (str.ToLower().Contains("uid=0") & !str.ToLower().Contains("su: not found")))
            {
                return RootAccessType.PermRooted;
            }
            if (flag == (str.ToLower().Contains("uid=0") & str.ToLower().Contains("su: not found")))
            {
                return RootAccessType.TempRooted;
            }
            return RootAccessType.NotRooted;
        }

        public bool IsSecureDevice() => 
            ADB.IssueADBCmd(ADB.CreateADBShellCmd(this, false, "cat", new string[] { "/default.prop" })).ToLower().Contains("ro.secure=1");

        public string PullDirectory(string location, string destination) => 
            ADB.IssueADBCmd(ADB.CreateADBCmd(this, "pull", new string[] { "\"" + (location.EndsWith("/") ? location : (location + "/")) + "\"", "\"" + destination + "\"" }));

        public string PullFile(string remotePath, string localPath) => 
            ADB.IssueADBCmd(ADB.CreateADBCmd(this, "pull", new string[] { "\"" + remotePath + "\"", "\"" + localPath + "\"" }));

        public string PushFile(string localPath, string remotePath) => 
            ADB.IssueADBCmd(ADB.CreateADBCmd(this, "push", new string[] { "\"" + localPath + "\"", "\"" + remotePath + "\"" }));

        public void RefreshState()
        {
            this._state = this.SetState();
        }

        private DeviceState SetState()
        {
            string str = null;
            using (StringReader reader = new StringReader(ADB.Devices()))
            {
                while (reader.Peek() != -1)
                {
                    string str2 = reader.ReadLine();
                    if (str2.Contains(this._serialNumber))
                    {
                        str = str2.Substring(str2.IndexOf('\t') + 1);
                    }
                }
            }
            if (str == null)
            {
                using (StringReader reader2 = new StringReader(Fastboot.Devices()))
                {
                    while (reader2.Peek() != -1)
                    {
                        string str3 = reader2.ReadLine();
                        if (str3.Contains(this._serialNumber))
                        {
                            str = str3.Substring(str3.IndexOf('\t') + 1);
                        }
                    }
                }
            }
            switch (str)
            {
                case "device":
                    return DeviceState.ONLINE;

                case "offline":
                    return DeviceState.OFFLINE;

                case "recovery":
                    return DeviceState.RECOVERY;

                case "fastboot":
                    return DeviceState.FASTBOOT;
            }
            return DeviceState.UNKNOWN;
        }

        public void Update()
        {
            this._state = this.SetState();
            if (this._state == DeviceState.ONLINE)
            {
                this._suBinary = new SU_Binary(this);
                this._busyBox = new EFS_Professional.WinADBHelper.BusyBox(this);
                this._buildPropertyParser = new EFS_Professional.WinADBHelper.BuildPropertyParser(this);
                this._fileSystem = new EFS_Professional.WinADBHelper.FileSystem(this);
                this._kernelInfo = new EFS_Professional.WinADBHelper.KernelInfo(this);
            }
        }

        public EFS_Professional.WinADBHelper.BuildPropertyParser BuildPropertyParser =>
            this._buildPropertyParser;

        public EFS_Professional.WinADBHelper.BusyBox BusyBox =>
            this._busyBox;

        public EFS_Professional.WinADBHelper.FileSystem FileSystem =>
            this._fileSystem;

        public DeviceState GetState =>
            this._state;

        public EFS_Professional.WinADBHelper.KernelInfo KernelInfo =>
            this._kernelInfo;

        public string SerialNumber =>
            this._serialNumber;

        public SU_Binary SUBinary =>
            this._suBinary;

        public enum DeviceState
        {
            ONLINE,
            OFFLINE,
            RECOVERY,
            FASTBOOT,
            UNKNOWN
        }

        public enum RootAccessType
        {
            NotRooted,
            PermRooted,
            TempRooted
        }
    }
}


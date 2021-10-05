namespace EFS_Professional.WinADBHelper
{
    using EFS_Professional;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    public class AndroidControl
    {
        private List<string> _connectedDevices = new List<string>();
        private bool _disableFastboot = false;
        private static AndroidControl _initADB;

        public AndroidControl()
        {
            if (ADB.IsADBServerRunning)
            {
                ADB.KillServer();
                Thread.Sleep(0x3e8);
            }
        }

        public void Dispose()
        {
            if (ADB.IsADBServerRunning)
            {
                ADB.KillServer();
                Thread.Sleep(0x3e8);
            }
        }

        public DeviceIO GetConnectedDevice()
        {
            this.RefreshDevices();
            if (this.HasConnectedDevices)
            {
                return new DeviceIO(this._connectedDevices[0]);
            }
            return null;
        }

        public DeviceIO GetConnectedDevice(string deviceSerial)
        {
            this.RefreshDevices();
            if (this._connectedDevices.Contains(deviceSerial))
            {
                return new DeviceIO(deviceSerial);
            }
            return null;
        }

        public bool IsDeviceConnected(DeviceIO device)
        {
            this.RefreshDevices();
            foreach (string str in this.ConnectedDevices)
            {
                if (str == device.SerialNumber)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsDeviceConnected(string deviceSerial)
        {
            this.RefreshDevices();
            foreach (string str in this.ConnectedDevices)
            {
                if (str.ToLower() == deviceSerial.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public void RefreshDevices()
        {
            string s = null;
            this._connectedDevices.Clear();
            s = ADB.Devices();
            if (s.Length > 0x1d)
            {
                using (StringReader reader = new StringReader(s))
                {
                    while (reader.Peek() != -1)
                    {
                        string item = reader.ReadLine();
                        if ((!item.StartsWith("List") && !item.StartsWith("\r\n")) && ((item.Trim() != "") && (item.IndexOf('\t') != -1)))
                        {
                            item = item.Substring(0, item.IndexOf('\t'));
                            if (!item.ToLower().Contains("emulator"))
                            {
                                this._connectedDevices.Add(item);
                            }
                        }
                    }
                }
            }
            if (!this._disableFastboot)
            {
                s = Fastboot.Devices();
                if (s.Length > 0)
                {
                    using (StringReader reader2 = new StringReader(s))
                    {
                        while (reader2.Peek() != -1)
                        {
                            string str3 = reader2.ReadLine();
                            if ((!str3.StartsWith("List") && !str3.StartsWith("\r\n")) && ((str3.Trim() != "") && (str3.IndexOf('\t') != -1)))
                            {
                                str3 = str3.Substring(0, str3.IndexOf('\t'));
                                if (!str3.ToLower().Contains("emulator"))
                                {
                                    this._connectedDevices.Add(str3);
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool ShowWaitDeviceDialog(ref DeviceIO newDevice, string deviceSerial = null, string message = null, bool cancelBtn = true)
        {
            frmWaitDeviceDialog dialog = new frmWaitDeviceDialog(deviceSerial, message, cancelBtn);
            dialog.ShowDialog();
            if (dialog.DialogResult == DialogResult.OK)
            {
                newDevice = dialog.Device;
                dialog.Dispose();
                return true;
            }
            newDevice = null;
            dialog.Dispose();
            return false;
        }

        public void WaitForDevice()
        {
            while (!this.HasConnectedDevices)
            {
            }
        }

        public void WaitForDevice(bool createNewThread)
        {
            if (createNewThread)
            {
                new Thread(new ThreadStart(this.WaitForDevice)).Start();
            }
            else
            {
                this.WaitForDevice();
            }
        }

        public List<string> ConnectedDevices
        {
            get
            {
                this.RefreshDevices();
                return this._connectedDevices;
            }
        }

        public bool DisableFastboot
        {
            get => 
                this._disableFastboot;
            set
            {
                this._disableFastboot = value;
            }
        }

        public bool HasConnectedDevices
        {
            get
            {
                this.RefreshDevices();
                if (this._connectedDevices.Count <= 0)
                {
                    return false;
                }
                return true;
            }
        }

        public static AndroidControl Init
        {
            get
            {
                if (_initADB == null)
                {
                    _initADB = new AndroidControl();
                    ADB.StartServer();
                }
                return _initADB;
            }
        }
    }
}


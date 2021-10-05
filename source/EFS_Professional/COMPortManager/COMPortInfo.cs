namespace EFS_Professional.COMPortManager
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.Management;

    public class COMPortInfo
    {
        private string _comPort;
        private string _deviceName;

        public COMPortInfo()
        {
        }

        public COMPortInfo(string deviceName, string comPort)
        {
            this._deviceName = deviceName;
            this._comPort = comPort;
        }

        public List<COMPortInfo> GetCOMPortsInfo()
        {
            List<COMPortInfo> list2;
            List<COMPortInfo> list = new List<COMPortInfo>();
            ConnectionOptions options = ProcessConnection.ProcessConnectionOptions();
            ManagementScope scope = ProcessConnection.ConnectionScope(Environment.MachineName, options, @"\root\CIMV2");
            ObjectQuery query2 = new ObjectQuery("Select * from Win32_PnPEntity WHERE ConfigManagerErrorCode = 0");
            ObjectQuery query = new ObjectQuery("Select * from Win32_POTSModem WHERE ConfigManagerErrorCode = 0");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query2);
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher(scope, query);
            try
            {
                using (searcher)
                {
                    ManagementObjectCollection.ManagementObjectEnumerator enumerator;
                    try
                    {
                        enumerator = searcher.Get().GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            ManagementObject current = (ManagementObject) enumerator.Current;
                            if (current != null)
                            {
                                string str = Conversions.ToString(current["Name"]);
                                string comPort = string.Empty;
                                if (!string.IsNullOrEmpty(str) && str.Contains("(COM"))
                                {
                                    comPort = str.Substring(str.LastIndexOf("(COM")).Replace("(", "").Replace(")", "");
                                    list.Add(new COMPortInfo(str, comPort));
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator != null)
                        {
                            enumerator.Dispose();
                        }
                    }
                }
                using (searcher2)
                {
                    ManagementObjectCollection.ManagementObjectEnumerator enumerator2;
                    try
                    {
                        enumerator2 = searcher2.Get().GetEnumerator();
                        while (enumerator2.MoveNext())
                        {
                            ManagementObject obj3 = (ManagementObject) enumerator2.Current;
                            if (obj3 != null)
                            {
                                string str3 = Conversions.ToString(obj3["Name"]);
                                string str4 = Conversions.ToString(obj3["AttachedTo"]);
                                if (!string.IsNullOrEmpty(str3) && !string.IsNullOrEmpty(str4))
                                {
                                    list.Add(new COMPortInfo(str3 + " (" + str4 + ")", str4));
                                }
                            }
                        }
                    }
                    finally
                    {
                        if (enumerator2 != null)
                        {
                            enumerator2.Dispose();
                        }
                    }
                }
                list2 = list;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Unable to enumerate COM ports!", MsgBoxStyle.Critical, null);
                list2 = null;
                ProjectData.ClearProjectError();
            }
            return list2;
        }

        public string COMPort =>
            this._comPort;

        public string DeviceName =>
            this._deviceName;
    }
}


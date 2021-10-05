namespace EFS_Professional.WinADBHelper
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class BuildPropertyParser
    {
        private static DeviceIO _device;
        private static Dictionary<string, string> _prop = new Dictionary<string, string>();

        public BuildPropertyParser(DeviceIO device)
        {
            _device = device;
            Update();
        }

        public static string GetProperty(string buildProperty)
        {
            string str2 = null;
            _prop.TryGetValue(buildProperty, out str2);
            if (string.IsNullOrEmpty(str2))
            {
                return string.Empty;
            }
            return str2;
        }

        public static string GetPropList()
        {
            string str2 = "";
            foreach (KeyValuePair<string, string> pair in _prop)
            {
                str2 = str2 + string.Format("[{0}]: [{1}]" + Environment.NewLine, pair.Key, pair.Value);
            }
            return str2.TrimEnd(new char[0]);
        }

        public static bool SetProperty(string buildProperty, string newValue)
        {
            string str2 = null;
            if (!_prop.TryGetValue(buildProperty, out str2))
            {
                return false;
            }
            if (_device.IsRooted() != DeviceIO.RootAccessType.PermRooted)
            {
                return false;
            }
            ADB.IssueADBCmdNoOutput(ADB.CreateADBShellCmd(_device, true, "setprop", new string[] { buildProperty, newValue }));
            Update();
            string str = null;
            if (!_prop.TryGetValue(buildProperty, out str))
            {
                return false;
            }
            return (newValue == str);
        }

        private static void Update()
        {
            _prop.Clear();
            using (StringReader reader = new StringReader(ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "getprop", new string[0]))))
            {
                while (reader.Peek() != -1)
                {
                    string str2 = reader.ReadLine();
                    if (str2.StartsWith("["))
                    {
                        string[] strArray = str2.Split(new char[] { ':' });
                        if (strArray.Length > 2)
                        {
                            int num3 = strArray.Length - 1;
                            for (int i = 2; i <= num3; i++)
                            {
                                string[] strArray2 = strArray;
                                int num4 = 1;
                                strArray2[num4] = strArray2[num4] + ":" + strArray[i];
                            }
                        }
                        int index = 0;
                        do
                        {
                            if (index == 0)
                            {
                                strArray[index] = strArray[index].Replace("[", string.Empty).Trim();
                            }
                            else
                            {
                                strArray[index] = strArray[index].Replace(" [", string.Empty).Trim();
                            }
                            strArray[index] = strArray[index].Replace("]", string.Empty).Trim();
                            index++;
                        }
                        while (index <= 1);
                        if (string.IsNullOrEmpty(strArray[1].TrimEnd(new char[0])))
                        {
                            _prop.Add(strArray[0].TrimEnd(new char[0]), string.Empty);
                        }
                        else
                        {
                            _prop.Add(strArray[0].TrimEnd(new char[0]), strArray[1].TrimEnd(new char[0]));
                        }
                    }
                }
            }
        }

        public static List<string> GetProperties
        {
            get
            {
                List<string> list2 = new List<string>();
                foreach (string str in _prop.Keys)
                {
                    list2.Add(str);
                }
                return list2;
            }
        }

        public static List<string> GetPropertyValues
        {
            get
            {
                List<string> list2 = new List<string>();
                foreach (string str in _prop.Values)
                {
                    list2.Add(str);
                }
                return list2;
            }
        }
    }
}


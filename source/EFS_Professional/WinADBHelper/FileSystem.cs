namespace EFS_Professional.WinADBHelper
{
    using EFS_Professional;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class FileSystem
    {
        private static DeviceIO _device;
        private static string AppPath = Application.StartupPath.ToString();
        public static char[] Invalids = new char[] { '\0', '\n', '\r', ' ' };

        internal FileSystem(DeviceIO device)
        {
            _device = device;
        }

        public static bool CheckMMCBlk0Exists() => 
            ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "busybox ls", new string[] { "/dev/block/mmcblk0" })).ToLower().Contains("/dev/block/mmcblk0");

        public static bool DirectoryExists(string pathToDir, bool createIfNotExist)
        {
            if (createIfNotExist)
            {
                string str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "if [ ! -d \"" + pathToDir + "\" ] ;", new string[] { "then mkdir " + pathToDir + " ;", "else", "echo 'Directory exists!' ;", "fi" }));
                return true;
            }
            return ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "if [ ! -d \"" + pathToDir + "\" ] ;", new string[] { "then echo 'Directory not exist!' ;", "else", "echo 'Directory exists!' ;", "fi" })).ToLower().Contains("directory exists!");
        }

        public static string EnableHiddenMenu(bool enable)
        {
            string str = "/system/build.prop";
            string mountPoint = GetMountPoint("/system");
            if (!mountPoint.ToLower().StartsWith("/dev/block"))
            {
                throw new Exception("Unable to detect '/system' mount point!");
            }
            if (!FileExists("/efs/carrier/HiddenMenu"))
            {
                throw new Exception("HiddenMenu flag not found! This is not intended for your device variant!");
            }
            if (enable)
            {
                return ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "mount -o rw,remount " + mountPoint + " /system ;", new string[] { "if busybox grep -qe \"sys.hiddenmenu.enable=0\" " + str + " ;", "then busybox sed -n 's/^sys.hiddenmenu.enable=0$/sys.hiddenmenu.enable=1/'", str, "; echo -n ON > /efs/carrier/HiddenMenu ; echo 'HiddenMenu has been enabled!' ; elif ! grep -qe \"sys.hiddenmenu.enable\"", str, ";", @"then sed -i '$ a\sys.hiddenmenu.enable=1' " + str + " ;", "echo -n ON > /efs/carrier/HiddenMenu ; echo 'HiddenMenu has been enabled!' ; else", "echo 'HiddenMenu already enabled!' ;", "fi ; mount -o ro,remount " + mountPoint + " /system" }));
            }
            return ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "mount -o rw,remount " + mountPoint + " /system ;", new string[] { "if busybox grep -qe \"sys.hiddenmenu.enable\" " + str + " ;", "then busybox sed -i '/sys.hiddenmenu.enable/d' " + str + " ; echo -n OFF > /efs/carrier/HiddenMenu ; echo 'HiddenMenu has been disabled!' ; else", "echo 'HiddenMenu already disabled!' ;", "fi ; mount -o ro,remount " + mountPoint + " /system" }));
        }

        public static bool FileExists(string pathToFile) => 
            ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "if [ ! -f \"" + pathToFile + "\" ];", new string[] { "then echo 'File not exist!';", "else", "echo 'File exists!';", "fi" })).ToLower().Contains("file exists!");

        public static bool GetDevicePIT(string outputPath, ref string pitFileName, string devStorageLoc, int bufferSize)
        {
            string property = BuildPropertyParser.GetProperty("ro.product.model");
            if (ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "busybox dd", new string[] { "if=/dev/block/mmcblk0", "of=" + devStorageLoc + "/" + property + ".pit", "bs=1024", "count=" + Conversions.ToString(bufferSize) })).ToLower().Contains("exitcode=0"))
            {
                pitFileName = property + ".pit";
                _device.PullFile(devStorageLoc + "/" + pitFileName, outputPath);
                ADB.IssueADBCmdNoOutput(ADB.CreateADBShellCmd(_device, false, "busybox rm", new string[] { devStorageLoc + "/" + pitFileName }));
                return true;
            }
            return false;
        }

        public static string GetMountPoint(string folder)
        {
            string str2 = ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "busybox", new string[] { "mountpoint", "-n", folder }));
            if (string.IsNullOrEmpty(str2))
            {
                return "Unknown";
            }
            if ((str2.ToLower().Contains("no such file or directory") | str2.ToLower().Contains("unknown")) | str2.ToLower().Contains("not a directory"))
            {
                return "Failed!";
            }
            int startIndex = str2.LastIndexOf(' ');
            return str2.Remove(startIndex);
        }

        public static List<PartitionInfo> GetPartitions()
        {
            List<PartitionInfo> list2 = new List<PartitionInfo>();
            string[] strArray = Strings.Split(ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "Partition=$(busybox", new string[] { 
                "find", "/dev/block/platform", "-type", "d", "-iname", "'by-name'", "-exec", "busybox", "find", "{}", "-maxdepth 1", "-type", "l", @"\;", "|", "busybox",
                "tac", ")", ";", "for", "Blocks", "in", "$Partition", ";", "do", "busybox", "basename", "$Blocks", "|", "busybox", "tr", @"'\n'",
                "' '", ";", "busybox", "busybox", "readlink", "$Blocks", ";", "done"
            })), "\r\n", -1, CompareMethod.Binary);
            if (strArray.Length <= 1)
            {
                throw new Exception("Unable to enumerate partitions!");
            }
            foreach (string str5 in strArray)
            {
                string str3 = str5.Remove(str5.IndexOf(' ') + 1);
                string str2 = str5.Remove(0, str5.IndexOf(' ') + 1);
                string str = str5.Remove(0, str5.LastIndexOf("/") + 1);
                list2.Add(new PartitionInfo(str3.Trim(Invalids).ToLower(), str3.Trim(Invalids).ToLower() + ".epb", str2.Trim(Invalids), str.Trim(Invalids)));
            }
            return list2;
        }

        public static List<PartitionInfo> GetSamsungPartitions(string pitFile)
        {
            List<PartitionInfo> list2 = new List<PartitionInfo>();
            using (FileStream stream = new FileStream(pitFile, FileMode.Open, FileAccess.Read))
            {
                PitInputStream inputStream = new PitInputStream(stream);
                PitData data = new PitData();
                if (!data.ReadPITFile(inputStream))
                {
                    return list2;
                }
                string[] strArray = Strings.Split(ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, false, "busybox", new string[] { "find", "/dev/block", "-maxdepth 1", "-iname", "'mmcblk0p*'", "|", "busybox", "tac" })), "\r\n", -1, CompareMethod.Binary);
                if (strArray.Length <= 1)
                {
                    stream.Close();
                    throw new Exception("Unable to enumerate partitions!");
                }
                foreach (string str5 in strArray)
                {
                    int num;
                    if (int.TryParse(str5.Substring(str5.LastIndexOf("p") + 1), out num))
                    {
                        foreach (PitEntry entry in data.Entries)
                        {
                            if (entry.PartitionID == num)
                            {
                                string partitionName = entry.PartitionName;
                                string str2 = str5;
                                string str = str5.Remove(0, str5.LastIndexOf("/") + 1);
                                if (!string.IsNullOrEmpty(entry.FlashFileName.Trim(Invalids)) & (entry.FlashFileName.Trim(Invalids) != "-"))
                                {
                                    list2.Add(new PartitionInfo(partitionName.Trim(Invalids).ToLower(), entry.FlashFileName.Trim(Invalids).ToLower(), str2.Trim(Invalids), str.Trim(Invalids)));
                                }
                                else
                                {
                                    list2.Add(new PartitionInfo(partitionName.Trim(Invalids).ToLower(), partitionName.Trim(Invalids).ToLower() + ".epb", str2.Trim(Invalids), str.Trim(Invalids)));
                                }
                                break;
                            }
                        }
                    }
                }
            }
            return list2;
        }

        public static ListingType IsFileOrDirectory(string location)
        {
            if (!BusyBox.IsInstalled)
            {
                return ListingType.BBOX_ERROR;
            }
            ADBCommand cmd = ADB.CreateADBShellCmd(_device, false, $"if [ -f {location} ]; then echo "1"; else echo "0"; fi", new string[0]);
            ADBCommand command = ADB.CreateADBShellCmd(_device, false, $"if [ -d {location} ]; then echo "1"; else echo "0"; fi", new string[0]);
            if (ADB.IssueADBCmd(cmd).Contains("1"))
            {
                return ListingType.FILE;
            }
            if (ADB.IssueADBCmd(command).Contains("1"))
            {
                return ListingType.DIRECTORY;
            }
            return ListingType.NONE;
        }

        public static string MD5Sum(string str)
        {
            if (!BusyBox.IsInstalled)
            {
                return "BusyBox Not Installed!";
            }
            foreach (string str3 in BusyBox.Commands)
            {
                if (str3 == "md5sum")
                {
                    return ADB.IssueADBCmd(ADB.CreateADBShellCmd(_device, true, "busybox", new string[] { "md5sum", "\"" + str + "\"" })).Remove(0x20);
                }
            }
            return "md5sum applet Not Found!";
        }

        public static PitData ParsePIT(string fileName)
        {
            PitData data2;
            if (!File.Exists(fileName))
            {
                throw new Exception("The specified PIT file does not exist!");
            }
            using (FileStream stream4 = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                byte[] array = new byte[((int) (stream4.Length - 1L)) + 1];
                byte[] buffer2 = new byte[0x1400];
                byte[] pattern = new byte[] { 0x76, 0x98, 0x34, 0x12 };
                byte[] buffer4 = new byte[0x100];
                long num = 0L;
                stream4.Read(array, 0, array.Length);
                num = HelperUtils.FindByteOffset(array, pattern, 0);
                buffer2 = HelperUtils.GetByteArray(array, ((int) num) - pattern.Length, buffer2.Length + 1);
                stream4.Position = 0L;
                stream4.SetLength((long) buffer2.Length);
                stream4.Write(buffer2, 0, buffer2.Length);
                stream4.Position = 0L;
                PitInputStream inputStream = new PitInputStream(stream4);
                data2 = new PitData();
                if (!data2.ReadPITFile(inputStream))
                {
                    throw new Exception("The specified PIT file contains corrupt or invalid data!");
                }
                MemoryStream byteStream = new MemoryStream();
                PitOutputStream outputStream = new PitOutputStream(byteStream);
                data2.WritePITFile(outputStream);
                stream4.Position = 0L;
                stream4.SetLength(byteStream.Length + buffer4.Length);
                stream4.Write(byteStream.ToArray(), 0, (int) byteStream.Length);
            }
            return data2;
        }

        public enum ListingType
        {
            FILE,
            DIRECTORY,
            NONE,
            BBOX_ERROR
        }
    }
}


namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public class PitData
    {
        private string _apVendor = string.Empty;
        private List<PitEntry> _entries = new List<PitEntry>();
        private int _entryCount;
        private string _projectName = string.Empty;
        private int _reserved = 0;
        public const int APVendorStrLength = 8;
        public const int HeaderMagic = 0x12349876;
        public const int HeaderSize = 0x1c;
        public const int ProjectNameStrLength = 8;
        public const int StrMaxLength = 0x20;

        public void AddEntry(PitEntry entry)
        {
            entry.Index = this._entryCount;
            this._entries.Add(entry);
            this._entryCount++;
        }

        public void Clear()
        {
            this._entryCount = 0;
            this._apVendor = string.Empty;
            this._projectName = string.Empty;
            this._reserved = 0;
            this._entries.Clear();
        }

        public static PitData Clone(PitData pData)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, pData);
                stream.Position = 0L;
                return (PitData) formatter.Deserialize(stream);
            }
        }

        private bool CompareByteArray(byte[] byteArray1, byte[] byteArray2)
        {
            if (byteArray1 != byteArray2)
            {
                if ((byteArray1 == null) || (byteArray2 == null))
                {
                    return false;
                }
                if (byteArray1.Length != byteArray2.Length)
                {
                    return false;
                }
                int num2 = byteArray1.Length - 1;
                for (int i = 0; i <= num2; i++)
                {
                    if (byteArray1[i] != byteArray2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public PitEntry FindEntry(string partitionName)
        {
            int num = 0;
            while (num < this._entries.Count)
            {
                PitEntry entry2 = this._entries[num];
                if (string.Compare(partitionName, entry2.PartitionName) == 0)
                {
                    return entry2;
                }
            }
            return null;
        }

        public PitEntry GetEntry(int index) => 
            this._entries[index];

        public bool Matches(PitData otherPitData)
        {
            if (!((((this._entryCount == otherPitData._entryCount) & (string.Compare(this._apVendor, otherPitData._apVendor) == 0)) & (string.Compare(this._projectName, otherPitData._projectName) == 0)) & (this._reserved == otherPitData._reserved)))
            {
                return false;
            }
            for (int i = 0; i < this._entryCount; i++)
            {
                PitEntry entry = this._entries[i];
                PitEntry otherPitEntry = otherPitData._entries[i];
                if (Conversions.ToBoolean(Operators.NotObject(entry.Matches(otherPitEntry))))
                {
                    return false;
                }
            }
            return true;
        }

        public bool ReadPITFile(PitInputStream inputStream)
        {
            int num2 = 0;
            byte[] buffer = new byte[8];
            byte[] buffer2 = new byte[8];
            byte[] buffer3 = new byte[0x20];
            if (inputStream.ReadInt() != 0x12349876)
            {
                return false;
            }
            this._entries.Clear();
            this._entryCount = inputStream.ReadInt();
            this._entries.Capacity = this._entryCount;
            this._apVendor = inputStream.ReadString(buffer, 8);
            this._projectName = inputStream.ReadString(buffer2, 8);
            num2 = inputStream.ReadInt();
            this._reserved = num2;
            for (int i = 0; i < this._entryCount; i++)
            {
                PitEntry item = new PitEntry {
                    Index = i
                };
                item.SetEntryMemAddr(inputStream.GetMemoryAddress());
                num2 = inputStream.ReadInt();
                item.ImageType = (PitEntry.EntryImageType) num2;
                num2 = inputStream.ReadInt();
                item.DeviceType = (PitEntry.EntryDeviceType) num2;
                num2 = inputStream.ReadInt();
                item.PartitionID = num2;
                num2 = inputStream.ReadInt();
                item.PartitionType = (PitEntry.EntryPartitionType) num2;
                num2 = inputStream.ReadInt();
                item.FileSystemType = (PitEntry.EntryFileSystemType) num2;
                num2 = inputStream.ReadInt();
                item.BlockCount = num2;
                num2 = inputStream.ReadInt();
                item.BlockSize = num2;
                num2 = inputStream.ReadInt();
                item.FileOffset = num2;
                num2 = inputStream.ReadInt();
                item.FileSize = num2;
                item.PartitionName = inputStream.ReadString(buffer3, 0x20);
                item.FlashFileName = inputStream.ReadString(buffer3, 0x20);
                item.FOTAFileName = inputStream.ReadString(buffer3, 0x20);
                this._entries.Add(item);
            }
            return true;
        }

        public void RemoveEntry(int index)
        {
            List<PitEntry>.Enumerator enumerator;
            this._entries.RemoveAt(index);
            this._entryCount--;
            int num = 0;
            try
            {
                enumerator = this._entries.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    PitEntry current = enumerator.Current;
                    current.Index = num;
                    num++;
                }
            }
            finally
            {
                enumerator.Dispose();
            }
        }

        public void SetEntry(int index, PitEntry newPitEntry)
        {
            this._entries.RemoveAt(index);
            this._entries.Insert(index, newPitEntry);
        }

        public void WritePITFile(PitOutputStream outputStream)
        {
            outputStream.WriteInt(0x12349876);
            outputStream.WriteInt(this._entryCount);
            outputStream.WriteString(this._apVendor, 8);
            outputStream.WriteString(this._projectName, 8);
            outputStream.WriteInt(this._reserved);
            for (int i = 0; i < this._entryCount; i++)
            {
                PitEntry entry = this._entries[i];
                outputStream.WriteInt((int) entry.ImageType);
                outputStream.WriteInt((int) entry.DeviceType);
                outputStream.WriteInt(entry.PartitionID);
                outputStream.WriteInt((int) entry.PartitionType);
                outputStream.WriteInt((int) entry.FileSystemType);
                outputStream.WriteInt(entry.BlockCount);
                outputStream.WriteInt(entry.BlockSize);
                outputStream.WriteInt(entry.FileOffset);
                outputStream.WriteInt(entry.FileSize);
                outputStream.WriteString(entry.PartitionName, 0x20);
                outputStream.WriteString(entry.FlashFileName, 0x20);
                outputStream.WriteString(entry.FOTAFileName, 0x20);
            }
        }

        public string APVendor
        {
            get => 
                this._apVendor;
            set
            {
                this._apVendor = value;
            }
        }

        public PitEntry[] Entries =>
            this._entries.ToArray();

        public int EntryCount =>
            this._entryCount;

        public string ProjectName
        {
            get => 
                this._projectName;
            set
            {
                this._projectName = value;
            }
        }

        public int Reserved
        {
            get => 
                this._reserved;
            set
            {
                this._reserved = value;
            }
        }
    }
}


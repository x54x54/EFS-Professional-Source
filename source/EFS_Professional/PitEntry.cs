namespace EFS_Professional
{
    using System;
    using System.IO;
    using System.Runtime.Serialization.Formatters.Binary;

    [Serializable]
    public class PitEntry
    {
        private int _blockCount = 0;
        private int _blockSize = 0;
        private EntryDeviceType _deviceType = EntryDeviceType.Nand;
        private string _entryMemAddr = string.Empty;
        private int _fileOffset = 0;
        private int _fileSize = 0;
        private EntryFileSystemType _fileSystemType = EntryFileSystemType.Basic;
        private string _flashFileName = string.Empty;
        private string _fotaFileName = string.Empty;
        private EntryImageType _imageType = EntryImageType.AP;
        private int _index = 0;
        private int _partitionID = 0;
        private string _partitionName = string.Empty;
        private EntryPartitionType _partitionType = EntryPartitionType.BCT;

        public static PitEntry Clone(PitEntry pEntry)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, pEntry);
                stream.Position = 0L;
                return (PitEntry) formatter.Deserialize(stream);
            }
        }

        public object Matches(PitEntry otherPitEntry) => 
            ((((((((((((this._imageType == otherPitEntry._imageType) & (this._deviceType == otherPitEntry._deviceType)) & (this._partitionID == otherPitEntry._partitionID)) & (this._partitionType == otherPitEntry._partitionType)) & (this._fileSystemType == otherPitEntry._fileSystemType)) & (this._blockCount == otherPitEntry._blockCount)) & (this._blockSize == otherPitEntry._blockSize)) & (this._fileOffset == otherPitEntry._fileOffset)) & (this._fileSize == otherPitEntry._fileSize)) & (string.Compare(this._partitionName, otherPitEntry._partitionName) == 0)) & (string.Compare(this._flashFileName, otherPitEntry._flashFileName) == 0)) & (string.Compare(this._fotaFileName, otherPitEntry._fotaFileName) == 0));

        public void SetEntryMemAddr(string value)
        {
            this._entryMemAddr = value;
        }

        public int BlockCount
        {
            get => 
                this._blockCount;
            set
            {
                this._blockCount = value;
            }
        }

        public int BlockSize
        {
            get => 
                this._blockSize;
            set
            {
                this._blockSize = value;
            }
        }

        public EntryDeviceType DeviceType
        {
            get => 
                this._deviceType;
            set
            {
                this._deviceType = value;
            }
        }

        public string EntryMemAddr =>
            this._entryMemAddr;

        public int FileOffset
        {
            get => 
                this._fileOffset;
            set
            {
                this._fileOffset = value;
            }
        }

        public int FileSize
        {
            get => 
                this._fileSize;
            set
            {
                this._fileSize = value;
            }
        }

        public EntryFileSystemType FileSystemType
        {
            get => 
                this._fileSystemType;
            set
            {
                this._fileSystemType = value;
            }
        }

        public string FlashFileName
        {
            get => 
                this._flashFileName;
            set
            {
                if (value.Length < 0x20)
                {
                    this._flashFileName = value;
                }
                else
                {
                    this._flashFileName = value.Substring(0, 0x20);
                }
            }
        }

        public string FOTAFileName
        {
            get => 
                this._fotaFileName;
            set
            {
                if (value.Length < 0x20)
                {
                    this._fotaFileName = value;
                }
                else
                {
                    this._fotaFileName = value.Substring(0, 0x20);
                }
            }
        }

        public EntryImageType ImageType
        {
            get => 
                this._imageType;
            set
            {
                this._imageType = value;
            }
        }

        public int Index
        {
            get => 
                this._index;
            set
            {
                this._index = value;
            }
        }

        public int PartitionID
        {
            get => 
                this._partitionID;
            set
            {
                this._partitionID = value;
            }
        }

        public string PartitionName
        {
            get => 
                this._partitionName;
            set
            {
                if (value.Length < 0x20)
                {
                    this._partitionName = value;
                }
                else
                {
                    this._partitionName = value.Substring(0, 0x20);
                }
            }
        }

        public EntryPartitionType PartitionType
        {
            get => 
                this._partitionType;
            set
            {
                this._partitionType = value;
            }
        }

        public enum EntryData
        {
            DataSize = 0x84,
            FlashFileNameMaxLength = 0x20,
            FOTAFileNameMaxLength = 0x20,
            PartitionNameMaxLength = 0x20
        }

        public enum EntryDeviceType
        {
            All,
            Nand,
            eMMC,
            SPI,
            IDE,
            Nand_X16
        }

        public enum EntryFileSystemType
        {
            Generic,
            Basic,
            Enhanced,
            EXT2,
            YAFFS2,
            EXT4
        }

        public enum EntryImageType
        {
            AP,
            CP
        }

        public enum EntryPartitionType
        {
            Generic,
            BCT,
            BootLoader,
            PartitionTable,
            NVData,
            Data,
            MBR,
            EBR,
            GP1,
            GPT
        }
    }
}


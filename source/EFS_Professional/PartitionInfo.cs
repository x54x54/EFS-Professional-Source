namespace EFS_Professional
{
    using System;

    public class PartitionInfo
    {
        private string _blockName;
        private string _blockPath;
        private string _flashFileName;
        private string _partitionName;

        internal PartitionInfo(string partitionName, string flashFileName, string blockPath, string blockName)
        {
            this._flashFileName = flashFileName;
            this._partitionName = partitionName;
            this._blockPath = blockPath;
            this._blockName = blockName;
        }

        public override string ToString() => 
            this._partitionName;

        public string BlockName =>
            this._blockName;

        public string BlockPath =>
            this._blockPath;

        public string FlashFileName =>
            this._flashFileName;

        public string PartitionName =>
            this._partitionName;
    }
}


namespace EFS_Professional
{
    using System;

    public class NVItemsStatusEventArgs : EventArgs
    {
        private long _badParamNVItems = 0L;
        private long _badSecNVItems = 0L;
        private long _inactiveNVItems = 0L;
        private long _okayNVItems = 0L;
        private long _position = 0L;
        private long _progressPercentage = 0L;
        private long _totalLength = 0L;

        public NVItemsStatusEventArgs(long position, long badParamNVItems, long badSecNVItems, long inactiveNVItems, long okayNVItems, long totalLength, long progressPercentage)
        {
            this._position = position;
            this._badParamNVItems = badParamNVItems;
            this._badSecNVItems = badSecNVItems;
            this._inactiveNVItems = inactiveNVItems;
            this._okayNVItems = okayNVItems;
            this._totalLength = totalLength;
            this._progressPercentage = progressPercentage;
        }

        public long BadParameterNVItems =>
            this._badParamNVItems;

        public long BadSecurityNVItems =>
            this._badSecNVItems;

        public long InactiveNVItems =>
            this._inactiveNVItems;

        public long OkayNVItems =>
            this._okayNVItems;

        public long Position =>
            this._position;

        public long ProgressPercentage =>
            this._progressPercentage;

        public long TotalLength =>
            this._totalLength;
    }
}


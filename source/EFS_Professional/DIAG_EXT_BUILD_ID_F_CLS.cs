namespace EFS_Professional
{
    using System;

    public class DIAG_EXT_BUILD_ID_F_CLS
    {
        private string _mobModelID;
        private string _mobSWRev;
        private string _msmHWRev;

        public DIAG_EXT_BUILD_ID_F_CLS(string msmHWRev, string mobModelID, string mobSWRev)
        {
            this._msmHWRev = msmHWRev;
            this._mobModelID = mobModelID;
            this._mobSWRev = mobSWRev;
        }

        public string MobileModelID =>
            this._mobModelID;

        public string MobileSoftwareRevision =>
            this._mobSWRev;

        public string MSMHardwareRevision =>
            this._msmHWRev;
    }
}


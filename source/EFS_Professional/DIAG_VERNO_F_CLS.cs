namespace EFS_Professional
{
    using System;

    public class DIAG_VERNO_F_CLS
    {
        private string _compileDate;
        private string _compileTime;
        private string _mobCAIRev;
        private string _mobFWRev;
        private string _mobModel;
        private string _msmRev;
        private string _releaseDate;
        private string _releaseTime;
        private string _slotCycleIndex;
        private string _stationClassMark;
        private string _verDir;

        public DIAG_VERNO_F_CLS(string compileDate, string compileTime, string releaseDate, string releaseTime, string verDir, string stationClassMark, string mobCAIRev, string mobModel, string mobFWRev, string slotCycleIndex, string msmRev)
        {
            this._compileDate = compileDate;
            this._compileTime = compileTime;
            this._releaseDate = releaseDate;
            this._releaseTime = releaseTime;
            this._verDir = verDir;
            this._stationClassMark = stationClassMark;
            this._mobCAIRev = mobCAIRev;
            this._mobModel = mobModel;
            this._mobFWRev = mobFWRev;
            this._slotCycleIndex = slotCycleIndex;
            this._msmRev = msmRev;
        }

        public string CompileDate =>
            this._compileDate;

        public string CompileTime =>
            this._compileTime;

        public string MobileCAIRevision =>
            this._mobCAIRev;

        public string MobileFWRevision =>
            this._mobFWRev;

        public string MobileModel =>
            this._mobModel;

        public string MSMRevision =>
            this._msmRev;

        public string ReleaseDate =>
            this._releaseDate;

        public string ReleaseTime =>
            this._releaseTime;

        public string SlotCycleIndex =>
            this._slotCycleIndex;

        public string StationClassMark =>
            this._stationClassMark;

        public string VersionDir =>
            this._verDir;
    }
}


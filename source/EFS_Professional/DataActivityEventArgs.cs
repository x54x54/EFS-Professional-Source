namespace EFS_Professional
{
    using System;

    public class DataActivityEventArgs : EventArgs
    {
        private bool _dataActivity = false;

        public DataActivityEventArgs(bool dataActivity)
        {
            this._dataActivity = dataActivity;
        }

        public bool DataActivity =>
            this._dataActivity;
    }
}


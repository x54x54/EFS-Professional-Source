namespace EFS_Professional
{
    using System;
    using System.ComponentModel;

    public class OperationCompletedEventArgs : AsyncCompletedEventArgs
    {
        private OperationType _opType;

        public OperationCompletedEventArgs(Exception e, OperationType opType) : base(e, false, null)
        {
            this._opType = OperationType.Backup;
            this._opType = opType;
        }

        public OperationType Operation
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return this._opType;
            }
        }
    }
}


namespace EFS_Professional
{
    using System;
    using System.ComponentModel;

    public class RunCompletedEventArgs : AsyncCompletedEventArgs
    {
        public RunCompletedEventArgs(Exception exc, bool canceled, object state) : base(exc, canceled, RuntimeHelpers.GetObjectValue(state))
        {
        }
    }
}


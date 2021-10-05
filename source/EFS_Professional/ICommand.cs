namespace EFS_Professional
{
    using System;
    using System.ComponentModel;

    public abstract class ICommand
    {
        protected ICommand()
        {
        }

        public abstract bool TransmitTX(QualcommDeviceInstance instance, AsyncOperation asyncOp);
    }
}


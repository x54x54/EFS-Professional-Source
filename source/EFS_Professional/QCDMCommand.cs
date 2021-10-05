namespace EFS_Professional
{
    using System;

    public class QCDMCommand : Command
    {
        public QCDMCommand(Qcdm.Cmd qcCmd) : base(qcCmd, qcCmd.ToString())
        {
        }
    }
}


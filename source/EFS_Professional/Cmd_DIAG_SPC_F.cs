namespace EFS_Professional
{
    using System;

    public class Cmd_DIAG_SPC_F : Command
    {
        public Cmd_DIAG_SPC_F(Qcdm.Cmd QCDMCmd, byte[] data, string strConsoleOut) : base(QCDMCmd, data, strConsoleOut)
        {
        }

        public override object Decode()
        {
            if (this.BytesRX[1] == 1)
            {
                return "1";
            }
            if (this.BytesRX[1] == 0)
            {
                return "0";
            }
            return "-1";
        }

        public enum Response
        {
            Incorrect,
            Correct
        }
    }
}


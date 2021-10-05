namespace EFS_Professional
{
    using System;

    public class Cmd_DIAG_PASSWORD_F : Command
    {
        public Cmd_DIAG_PASSWORD_F(Qcdm.Cmd QCDMCmd, byte[] data, string strConsoleOut) : base(QCDMCmd, data, strConsoleOut)
        {
        }

        public override object Decode()
        {
            if (this.BytesRX[1] != 1)
            {
                return "0";
            }
            if ((this.BytesRX[1] == 1) & (this.BytesRX[0] == 70))
            {
                return "1";
            }
            return "-1";
        }
    }
}


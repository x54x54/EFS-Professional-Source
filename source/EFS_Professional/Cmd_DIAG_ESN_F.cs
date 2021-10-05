namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    public class Cmd_DIAG_ESN_F : Command
    {
        public Cmd_DIAG_ESN_F(Qcdm.Cmd QCDMCmd, string strConsoleOut) : base(QCDMCmd, strConsoleOut)
        {
        }

        public override object Decode()
        {
            object obj2;
            try
            {
                string str = ConversionUtils.BytesToHexString(this.BytesRX);
                string str2 = "";
                obj2 = str2 + Conversions.ToString(str[8]) + Conversions.ToString(str[9]) + Conversions.ToString(str[6]) + Conversions.ToString(str[7]) + Conversions.ToString(str[4]) + Conversions.ToString(str[5]) + Conversions.ToString(str[2]) + Conversions.ToString(str[3]);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                obj2 = "-1";
                ProjectData.ClearProjectError();
            }
            return obj2;
        }
    }
}


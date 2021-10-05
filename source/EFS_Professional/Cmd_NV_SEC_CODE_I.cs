namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    public class Cmd_NV_SEC_CODE_I : Command
    {
        public Cmd_NV_SEC_CODE_I(Qcdm.Cmd QCDMCmd, NVItemList NVItem, byte[] data, string strConsoleOut) : base(QCDMCmd, NVItem, data, strConsoleOut)
        {
        }

        public override object Decode()
        {
            object obj2;
            try
            {
                if (this.BytesRX[0] == 0x42)
                {
                    Interaction.MsgBox("Error! SPC Not Found!", MsgBoxStyle.Critical, null);
                    return "-1";
                }
                string str = ConversionUtils.BytesToHexString(this.BytesRX);
                string str2 = "";
                obj2 = str2 + Conversions.ToString(str[7]) + Conversions.ToString(str[9]) + Conversions.ToString(str[11]) + Conversions.ToString(str[13]) + Conversions.ToString(str[15]) + Conversions.ToString(str[0x11]);
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


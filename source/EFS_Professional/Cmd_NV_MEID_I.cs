namespace EFS_Professional
{
    using System;

    public class Cmd_NV_MEID_I : Command
    {
        public Cmd_NV_MEID_I(Qcdm.Cmd QCDMCmd, NVItemList NVItem, byte[] data, string strConsoleOut) : base(QCDMCmd, NVItem, data, strConsoleOut)
        {
        }

        public override object Decode()
        {
            if (this.CurrentQCDMCommand == Qcdm.Cmd.DIAG_NV_READ_F)
            {
                return ConversionUtils.BytesToHexString(HelperUtils.GetByteArray(this.BytesRX, 3, 7));
            }
            if (this.CurrentQCDMCommand == Qcdm.Cmd.DIAG_NV_WRITE_F)
            {
                return ConversionUtils.BytesToHexString(this.BytesRX);
            }
            return "-1";
        }
    }
}


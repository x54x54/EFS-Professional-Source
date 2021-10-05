namespace EFS_Professional
{
    using System;

    public class CommandFactory
    {
        public static ICommand GetCommand(NVItemList nv) => 
            GetCommand(nv, false, new byte[0]);

        public static ICommand GetCommand(Qcdm.Cmd qc)
        {
            switch (qc)
            {
                case Qcdm.Cmd.DIAG_ESN_F:
                    return new Cmd_DIAG_ESN_F(qc, qc.ToString());

                case Qcdm.Cmd.DIAG_VERNO_F:
                    return new Cmd_DIAG_VERNO_F(qc, qc.ToString());

                case Qcdm.Cmd.DIAG_EXT_BUILD_ID_F:
                    return new Cmd_DIAG_EXT_BUILD_ID_F(qc, qc.ToString());
            }
            return new QCDMCommand(qc);
        }

        public static ICommand GetCommand(Qcdm.Cmd qc, byte[] data)
        {
            switch (qc)
            {
                case Qcdm.Cmd.DIAG_SPC_F:
                    return new Cmd_DIAG_SPC_F(qc, data, qc.ToString());

                case Qcdm.Cmd.DIAG_PASSWORD_F:
                    return new Cmd_DIAG_PASSWORD_F(qc, data, qc.ToString());
            }
            return new Command(qc, data, qc.ToString());
        }

        public static ICommand GetCommand(NVItemList nv, bool write, byte[] data)
        {
            Qcdm.Cmd qCDMCmd = Qcdm.Cmd.DIAG_NV_READ_F;
            if (write)
            {
                qCDMCmd = Qcdm.Cmd.DIAG_NV_WRITE_F;
            }
            switch (nv)
            {
                case NVItemList.NV_ESN_I:
                    return new Cmd_NV_ESN_I(qCDMCmd, nv, data, qCDMCmd.ToString() + ", " + nv.ToString());

                case NVItemList.NV_MEID_I:
                    return new Cmd_NV_MEID_I(qCDMCmd, nv, data, qCDMCmd.ToString() + ", " + nv.ToString());

                case NVItemList.NV_UE_IMEI_I:
                    return new Cmd_NV_UE_IMEI_I(qCDMCmd, nv, data, qCDMCmd.ToString() + ", " + nv.ToString());

                case NVItemList.NV_LOCK_CODE_I:
                    return new Cmd_NV_LOCK_CODE_I(qCDMCmd, nv, data, qCDMCmd.ToString() + ", " + nv.ToString());

                case NVItemList.NV_SEC_CODE_I:
                    return new Cmd_NV_SEC_CODE_I(qCDMCmd, nv, data, qCDMCmd.ToString() + ", " + nv.ToString());
            }
            return new Cmd_NV(qCDMCmd, nv, data, qCDMCmd.ToString() + ", " + nv.ToString());
        }
    }
}


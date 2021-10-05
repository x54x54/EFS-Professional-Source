namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;

    public class Cmd_NV : Command
    {
        public Cmd_NV(Command cmd) : base(cmd.CurrentQCDMCommand, cmd.CurrentNVItem, new byte[0], cmd.ConsoleOutput)
        {
        }

        public Cmd_NV(Qcdm.Cmd QCDMCmd, NVItemList NVItem, byte[] data, string strConsoleOut) : base(QCDMCmd, NVItem, data, strConsoleOut)
        {
        }

        public override object Decode()
        {
            object itemData;
            try
            {
                itemData = new NVItem(this).GetItemData();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                itemData = "-1";
                ProjectData.ClearProjectError();
            }
            return itemData;
        }
    }
}


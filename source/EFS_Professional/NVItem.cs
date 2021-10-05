namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Globalization;

    public class NVItem
    {
        private string _itemData;
        private long _itemNumber;
        private NVStatus _itemStatus;

        public NVItem(Command cmd)
        {
            try
            {
                string str2;
                string str3;
                if (cmd.ErrorResponse == Qcdm.NV_Response.NV_ERR_BAD_SECURITY_MODE)
                {
                    str2 = ConversionUtils.BytesToHexString(cmd.BytesTX).Substring(4, 2);
                    str3 = ConversionUtils.BytesToHexString(cmd.BytesTX).Substring(2, 2);
                }
                else
                {
                    str2 = ConversionUtils.BytesToHexString(cmd.BytesRX).Substring(4, 2);
                    str3 = ConversionUtils.BytesToHexString(cmd.BytesRX).Substring(2, 2);
                }
                long num = long.Parse(str2 + str3, NumberStyles.HexNumber);
                this._itemNumber = num;
                if (cmd.ErrorResponse == Qcdm.NV_Response.NV_ERR_BAD_PARAM)
                {
                    this._itemStatus = NVStatus.BadParameter;
                    this._itemData = "";
                }
                else if (cmd.ErrorResponse == Qcdm.NV_Response.NV_ERR_BAD_SECURITY_MODE)
                {
                    this._itemStatus = NVStatus.AccessDenied;
                    this._itemData = "";
                }
                else if (cmd.ErrorResponse == Qcdm.NV_Response.NV_ERR_INACTIVE_NV_ITEM)
                {
                    this._itemStatus = NVStatus.InactiveItem;
                    this._itemData = "";
                }
                else
                {
                    this._itemStatus = NVStatus.Okay;
                }
                if (this._itemStatus == NVStatus.Okay)
                {
                    this._itemData = ConversionUtils.BytesToHexString(cmd.BytesRX).Substring(6, 0x100);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Error Parsing NV Item!", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        public string GetItemData() => 
            this._itemData;

        public string GetItemName() => 
            Enum.GetName(typeof(NVItemList), this._itemNumber);

        public long GetItemNumber() => 
            this._itemNumber;

        public string GetItemStatus() => 
            this._itemStatus.ToString();

        public enum NVStatus
        {
            Okay,
            BadParameter,
            AccessDenied,
            InactiveItem
        }
    }
}


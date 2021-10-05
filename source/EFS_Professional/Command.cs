namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;

    public class Command : ICommand
    {
        private string _consoleOut;
        private NVItemList _currNVItem;
        private Qcdm.Cmd _currQCDMCmd;
        private Qcdm.NV_Response _errResponse;
        private byte[] _rxBytes;
        private byte[] _txBytes;

        public Command(byte[] bytes, string strConsoleOut)
        {
            this._currQCDMCmd = Qcdm.Cmd.NOT_A_COMMAND;
            this._currNVItem = NVItemList.NOT_AN_NV_ITEM;
            this._txBytes = bytes;
            if (!string.IsNullOrEmpty(strConsoleOut))
            {
                this._consoleOut = "Raw Bytes(): " + strConsoleOut;
            }
            else
            {
                this._consoleOut = string.Empty;
            }
        }

        public Command(Qcdm.Cmd QCDMCmd, string strConsoleOut)
        {
            this._currQCDMCmd = Qcdm.Cmd.NOT_A_COMMAND;
            this._currNVItem = NVItemList.NOT_AN_NV_ITEM;
            this._currQCDMCmd = QCDMCmd;
            byte[] bs = new byte[] { byte.Parse(Conversions.ToString((int) QCDMCmd)) };
            this._txBytes = CRC.GetBufferWithCRC(bs);
            if (!string.IsNullOrEmpty(strConsoleOut))
            {
                this._consoleOut = strConsoleOut + " (CRC+7E)";
            }
            else
            {
                this._consoleOut = string.Empty;
            }
        }

        public Command(Qcdm.Cmd QCDMCmd, byte[] data, string strConsoleOut)
        {
            this._currQCDMCmd = Qcdm.Cmd.NOT_A_COMMAND;
            this._currNVItem = NVItemList.NOT_AN_NV_ITEM;
            this._currQCDMCmd = QCDMCmd;
            List<byte> list = new List<byte> {
                byte.Parse(Conversions.ToString((int) QCDMCmd))
            };
            foreach (byte num in data)
            {
                list.Add(num);
            }
            this._txBytes = CRC.GetBufferWithCRC(list.ToArray());
            if (!string.IsNullOrEmpty(strConsoleOut))
            {
                this._consoleOut = strConsoleOut + " (CRC+7E)";
            }
            else
            {
                this._consoleOut = string.Empty;
            }
        }

        public Command(Qcdm.Cmd QCDMCmd, NVItemList NVItem, byte[] NVItemData, string strConsoleOut)
        {
            this._currQCDMCmd = Qcdm.Cmd.NOT_A_COMMAND;
            this._currNVItem = NVItemList.NOT_AN_NV_ITEM;
            this._currQCDMCmd = QCDMCmd;
            this._currNVItem = NVItem;
            string str = long.Parse(Conversions.ToString((long) NVItem)).ToString("X");
            while (str.Length < 4)
            {
                str = "0" + str;
            }
            List<byte> list = new List<byte> {
                byte.Parse(Conversions.ToString((int) QCDMCmd)),
                Convert.ToByte(Conversions.ToString(str[2]) + Conversions.ToString(str[3]), 0x10),
                Convert.ToByte(Conversions.ToString(str[0]) + Conversions.ToString(str[1]), 0x10)
            };
            foreach (byte num in NVItemData)
            {
                list.Add(num);
            }
            while (list.Count < 0x85)
            {
                list.Add(0);
            }
            this._txBytes = CRC.GetBufferWithCRC(list.ToArray());
            if (!string.IsNullOrEmpty(strConsoleOut))
            {
                this._consoleOut = strConsoleOut + " (CRC+7E)";
            }
            else
            {
                this._consoleOut = string.Empty;
            }
        }

        public Command(Qcdm.Cmd QCDMCmd, long NVItem, byte[] NVItemData, string strConsoleOut)
        {
            this._currQCDMCmd = Qcdm.Cmd.NOT_A_COMMAND;
            this._currNVItem = NVItemList.NOT_AN_NV_ITEM;
            this._currQCDMCmd = QCDMCmd;
            this._currNVItem = (NVItemList) NVItem;
            string str = long.Parse(Conversions.ToString(NVItem)).ToString("X");
            while (str.Length < 4)
            {
                str = "0" + str;
            }
            List<byte> list = new List<byte> {
                byte.Parse(Conversions.ToString((int) QCDMCmd)),
                Convert.ToByte(Conversions.ToString(str[2]) + Conversions.ToString(str[3]), 0x10),
                Convert.ToByte(Conversions.ToString(str[0]) + Conversions.ToString(str[1]), 0x10)
            };
            foreach (byte num in NVItemData)
            {
                list.Add(num);
            }
            while (list.Count < 0x85)
            {
                list.Add(0);
            }
            this._txBytes = CRC.GetBufferWithCRC(list.ToArray());
            if (!string.IsNullOrEmpty(strConsoleOut))
            {
                this._consoleOut = strConsoleOut + " (CRC+7E)";
            }
            else
            {
                this._consoleOut = string.Empty;
            }
        }

        public virtual object Decode() => 
            this._rxBytes;

        public override bool TransmitTX(QualcommDeviceInstance instance, AsyncOperation asyncOp)
        {
            if (instance.CommandQueueInstance.TransmitData(this._txBytes, asyncOp))
            {
                this._rxBytes = instance.CommandQueueInstance.ReceiveData(this._txBytes, asyncOp);
                this._rxBytes = instance.CommandQueueInstance.ProcessReturnBytes(this._rxBytes);
            }
            return (this._rxBytes.Count<byte>() > 0);
        }

        public byte[] BytesRX =>
            this._rxBytes;

        public byte[] BytesTX =>
            this._txBytes;

        public string ConsoleOutput =>
            this._consoleOut;

        public NVItemList CurrentNVItem =>
            this._currNVItem;

        public Qcdm.Cmd CurrentQCDMCommand =>
            this._currQCDMCmd;

        public Qcdm.NV_Response ErrorResponse
        {
            get => 
                this._errResponse;
            set
            {
                this._errResponse = value;
            }
        }
    }
}


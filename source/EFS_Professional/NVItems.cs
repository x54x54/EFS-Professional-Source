namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;

    public class NVItems
    {
        private string ProcessNVItem(int itemNumber, int length)
        {
            string str2 = Convert.ToString(itemNumber, 0x10);
            if ((str2.Length == 1) & (length == 6))
            {
                str2 = "00000" + str2;
            }
            else if ((str2.Length == 2) & (length == 6))
            {
                str2 = "0000" + str2;
            }
            else if ((str2.Length == 3) | ((length == 4) & (str2.Length == 1)))
            {
                str2 = "000" + str2;
            }
            else if ((str2.Length == 4) | ((length == 4) & (str2.Length == 2)))
            {
                str2 = "00" + str2;
            }
            else if ((str2.Length == 5) | ((length == 4) & (str2.Length == 3)))
            {
                str2 = "0" + str2;
            }
            string str3 = "";
            if (length == 6)
            {
                str3 = str3 + Conversions.ToString(str2[4]) + Conversions.ToString(str2[5]);
            }
            return ((str3 + Conversions.ToString(str2[2]) + Conversions.ToString(str2[3])) + Conversions.ToString(str2[0]) + Conversions.ToString(str2[1]));
        }

        public Command ReadNVItem(int item)
        {
            string strConsoleOut = "DIAG_NV_WRITE - Item: " + item.ToString();
            byte[] buffer3 = new byte[3];
            byte[] buffer2 = ConversionUtils.HexStringToBytes("26" + this.ProcessNVItem(item, 6));
            List<byte> list = new List<byte>();
            foreach (byte num in buffer2)
            {
                list.Add(num);
            }
            while (list.Count < 0x85)
            {
                list.Add(0);
            }
            byte[] cRCAsByteFromByte = CRC.GetCRCAsByteFromByte(list.ToArray());
            list.Add(cRCAsByteFromByte[0]);
            list.Add(cRCAsByteFromByte[1]);
            list.Add(0x7e);
            return new Command(list.ToArray(), strConsoleOut);
        }

        public bool ReadNVItem(int item, CommandQueue queue, bool threaded)
        {
            string strConsoleOut = "DIAG_NV_READ - Item: " + item.ToString();
            Command inCommand = new Command(Qcdm.Cmd.DIAG_NV_READ_F, strConsoleOut);
            queue.Add(ref inCommand);
            return queue.Run(threaded);
        }

        public Command WriteNVItem(int item, string value)
        {
            string strConsoleOut = "DIAG_NV_WRITE - Item: " + item.ToString();
            byte[] commandPrefixArray = ConversionUtils.HexStringToBytes("27" + this.ProcessNVItem(item, 4) + value);
            return new Command(HelperUtils.BuildTermCommand(CommandByteArrays.nullCmd_133_length, commandPrefixArray, HelperUtils.BuildDataArray("0")), strConsoleOut);
        }

        public bool WriteNVItem(int item, byte[] data, CommandQueue queue, bool threaded)
        {
            string strConsoleOut = "DIAG_NV_WRITE - Item: " + item.ToString();
            Command inCommand = new Command(Qcdm.Cmd.DIAG_NV_WRITE_F, data, strConsoleOut);
            queue.Add(ref inCommand);
            return queue.Run(threaded);
        }
    }
}


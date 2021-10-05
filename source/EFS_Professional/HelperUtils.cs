namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Text;

    public class HelperUtils
    {
        private static byte[] AttachCRC(byte[] command)
        {
            byte[] array = new byte[] { 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0
            };
            byte[] cRCAsByteFromByte = CRC.GetCRCAsByteFromByte(command);
            CommandByteArrays.nullCmd_136_length.CopyTo(array, 0);
            command.CopyTo(array, 0);
            array[0x85] = cRCAsByteFromByte[0];
            array[0x86] = cRCAsByteFromByte[1];
            array[0x87] = 0x7e;
            return array;
        }

        public static byte[] BuildDataArray(string incomingASCII)
        {
            ASCIIEncoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(incomingASCII);
        }

        public static byte[] BuildTermCommand(byte[] nullCmdArray, byte[] commandPrefixArray, byte[] dataArray)
        {
            byte[] array = new byte[] { 
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0
            };
            nullCmdArray.CopyTo(array, 0);
            int num3 = commandPrefixArray.Length - 1;
            for (int i = 0; i <= num3; i++)
            {
                array[i] = commandPrefixArray[i];
            }
            int num4 = ((commandPrefixArray.Length - 1) + dataArray.Length) - 1;
            for (int j = commandPrefixArray.Length; j <= num4; j++)
            {
                array[j] = dataArray[j - (commandPrefixArray.Length - 1)];
            }
            return AttachCRC(array);
        }

        public static int FindByteOffset(byte[] array, byte[] pattern, int offset)
        {
            int index = 0;
            int num4 = array.Length - 1;
            for (int i = offset; i <= num4; i++)
            {
                if (array[i] == pattern[index])
                {
                    index++;
                }
                else
                {
                    index = 0;
                }
                if (pattern.Length == index)
                {
                    return (i + 1);
                }
            }
            return -1;
        }

        public static byte[] GenerateNSizeArray(int n)
        {
            string strInput = "";
            int num2 = n;
            for (int i = 0; i <= num2; i++)
            {
                strInput = strInput + "00";
            }
            return ConversionUtils.HexStringToBytes(strInput);
        }

        public static byte[] GetByteArray(byte[] bytesIn, int index, int length)
        {
            byte[] destinationArray = new byte[(length - 1) + 1];
            if (bytesIn.Length < length)
            {
                Array.Resize<byte>(ref bytesIn, length);
            }
            Array.Copy(bytesIn, index, destinationArray, 0, length);
            return destinationArray;
        }

        public static string GetEnumValue(object value, string filename, EnumFileParser.ParseType format)
        {
            int num;
            EnumFileParser parser = new EnumFileParser();
            if (format == EnumFileParser.ParseType.Hex)
            {
                num = Convert.ToInt32(value.ToString(), 0x10);
            }
            else if (format == EnumFileParser.ParseType.Dec)
            {
                num = Conversions.ToInteger(value);
            }
            foreach (EnumFileParser parser2 in parser.ParseFile(filename, format))
            {
                if (num == parser2.EnumValue)
                {
                    return parser2.EnumDescriptor;
                }
            }
            if (format == EnumFileParser.ParseType.Hex)
            {
                return ("0x" + value.ToString());
            }
            if (format == EnumFileParser.ParseType.Dec)
            {
                return value.ToString();
            }
            return "-1";
        }

        public static bool ModifyFileBytes(string FileName, long StartOffset, long Length, byte[] Data)
        {
            bool flag;
            try
            {
                Data = (byte[]) Utils.CopyArray((Array) Data, new byte[((int) (Length - 1L)) + 1]);
                FileStream stream = new FileStream(FileName, FileMode.Open, FileAccess.Write) {
                    Position = StartOffset
                };
                stream.Write(Data, 0, Data.Length);
                stream.Close();
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public static byte[] ReadFileBytes(string FileName, long Offset, int Length)
        {
            FileStream input = new FileStream(FileName, FileMode.Open);
            BinaryReader reader = new BinaryReader(input);
            int length = (int) input.Length;
            reader.BaseStream.Seek(Offset, SeekOrigin.Begin);
            byte[] buffer = reader.ReadBytes(Length);
            reader.Close();
            input.Close();
            return buffer;
        }

        public static string TrimResponse(string hexInput)
        {
            string str;
            try
            {
                string str2 = hexInput.Remove(0, 6);
                str = str2.Remove(str2.Length - 6, 6);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                str = "-1";
                ProjectData.ClearProjectError();
            }
            return str;
        }
    }
}


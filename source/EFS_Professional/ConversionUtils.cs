namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Linq;
    using System.Text;

    public class ConversionUtils
    {
        public static string BytesToHexString(byte[] byteInput)
        {
            string str = "";
            string str3 = "";
            try
            {
                foreach (byte num in byteInput)
                {
                    str = str + Conversions.ToString(Microsoft.VisualBasic.Strings.Chr(num));
                    str3 = str3 + Conversion.Hex(num).PadLeft(2, '0');
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            return str3;
        }

        public static string FormatHexStr(string hexStr)
        {
            StringBuilder builder = new StringBuilder();
            try
            {
                int num2 = hexStr.Length - 1;
                for (int i = 0; i <= num2; i += 2)
                {
                    builder.Append(hexStr.Substring(i, 2) + " ");
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                string str = builder.ToString().TrimEnd(new char[0]);
                ProjectData.ClearProjectError();
                return str;
            }
            return builder.ToString().TrimEnd(new char[0]);
        }

        public static string FormatTermASCII(string strInput)
        {
            string str2 = string.Empty;
            strInput = strInput.Replace(" ", "");
            int num2 = strInput.Length - 1;
            for (int i = 0; i <= num2; i += 2)
            {
                string str3 = strInput.Substring(i, 2);
                if (str3 == "00")
                {
                    str2 = str2 + ".";
                }
                else if (str3 == "09")
                {
                    str2 = str2 + "□";
                }
                else if (str3 == "0C")
                {
                    str2 = str2 + "□";
                }
                else if (str3 == "0D")
                {
                    str2 = str2 + "□";
                }
                else
                {
                    str2 = str2 + Convert.ToChar(Convert.ToUInt32(str3, 0x10)).ToString();
                }
            }
            return str2;
        }

        public static string FormatTermOutput(string strInput, int intMaxLineLength)
        {
            string str4 = string.Empty;
            string str3 = string.Empty;
            string str = string.Empty;
            for (int i = 1; i <= Microsoft.VisualBasic.Strings.Len(strInput); i += intMaxLineLength * 2)
            {
                if (Microsoft.VisualBasic.Strings.Len(Microsoft.VisualBasic.Strings.Mid(strInput, i)) > (intMaxLineLength * 2))
                {
                    str3 = FormatHexStr(Microsoft.VisualBasic.Strings.Mid(strInput, i, intMaxLineLength * 2));
                    str = "    |    " + FormatTermASCII(str3);
                    str4 = str4 + str3.PadRight((intMaxLineLength * 2) + 0x10).Substring(0, (intMaxLineLength * 2) + 0x10) + str + "\r\n";
                }
                else
                {
                    str3 = FormatHexStr(Microsoft.VisualBasic.Strings.Mid(strInput, i));
                    str = "    |    " + FormatTermASCII(str3);
                    str4 = str4 + str3.PadRight((intMaxLineLength * 2) + 0x10).Substring(0, (intMaxLineLength * 2) + 0x10) + str + "\r\n";
                }
            }
            return str4;
        }

        public static string GetASCIIString(byte[] bytes)
        {
            string str2;
            string str = BytesToHexString(bytes);
            try
            {
                string str3 = "";
                int num2 = str.Length - 1;
                for (int i = 0; i <= num2; i++)
                {
                    if (str.Substring(i, 2) == "00")
                    {
                        i++;
                    }
                    else
                    {
                        str3 = str3 + str.Substring(i, 2);
                        i++;
                    }
                }
                string str4 = "";
                while (str3.Length > 0)
                {
                    str4 = str4 + Convert.ToChar(Convert.ToUInt64(str3.Substring(0, 2), 0x10)).ToString();
                    str3 = str3.Substring(2, str3.Length - 2);
                }
                str2 = str4;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                str2 = "-1";
                ProjectData.ClearProjectError();
            }
            return str2;
        }

        public static string GetASCIIString(byte[] bytes, int offset, int count) => 
            GetASCIIString(bytes).Substring(offset, count);

        public static byte[] HexStringToBytes(string strInput)
        {
            byte[] buffer;
            try
            {
                int startIndex = 0;
                int index = 0;
                byte[] buffer2 = new byte[((int) Math.Round((double) ((((double) strInput.Length) / 2.0) - 1.0))) + 1];
                while (strInput.Length > (startIndex + 1))
                {
                    long num3 = Convert.ToInt64(strInput.Substring(startIndex, 2), 0x10);
                    buffer2[index] = Convert.ToByte(num3);
                    startIndex += 2;
                    index++;
                }
                buffer = buffer2;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Hex String To Byte Array Conversion Error!", MsgBoxStyle.Critical, null);
                buffer = null;
                ProjectData.ClearProjectError();
            }
            return buffer;
        }

        public static string IMEIToReverseHex(string imei)
        {
            string str2 = imei;
            if (string.IsNullOrEmpty(str2))
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder();
            int num2 = str2.Length - 2;
            for (int i = 1; i <= num2; i += 2)
            {
                builder.Append(new string(str2.Substring(i, 2).Reverse<char>().ToArray<char>()));
            }
            return FormatHexStr($"08{str2[0]}A{builder.ToString()}");
        }

        public static string ReverseHex(string value)
        {
            string str = value;
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder();
            int num2 = str.Length - 2;
            for (int i = 0; i <= num2; i += 2)
            {
                builder.Append(new string(str.Substring(i, 2).Reverse<char>().ToArray<char>()));
            }
            return FormatHexStr(Microsoft.VisualBasic.Strings.StrReverse(builder.ToString()));
        }

        public static string ReverseHexToIMEI(string hexInput)
        {
            string str = hexInput;
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            str = hexInput.Remove(0, 1);
            StringBuilder builder = new StringBuilder();
            int num2 = str.Length - 2;
            for (int i = 1; i <= num2; i += 2)
            {
                builder.Append(new string(str.Substring(i, 2).Reverse<char>().ToArray<char>()));
            }
            return builder.ToString().TrimStart(new char[] { 'A' });
        }

        public static string TrimFrontAndEndASCII(string inputStr)
        {
            string str = inputStr;
            return str.Substring(4, inputStr.Length - 7);
        }

        public static string TrimFrontAndEndASCII(string inputStr, int start, int lengthMinus)
        {
            string str = inputStr;
            return str.Substring(start, inputStr.Length - lengthMinus);
        }
    }
}


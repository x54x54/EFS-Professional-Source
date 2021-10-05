namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class EnumFileParser
    {
        private string _enumDescriptor;
        private List<EnumFileParser> _enumList;
        private int _enumValue;

        public EnumFileParser()
        {
            this._enumList = new List<EnumFileParser>();
        }

        public EnumFileParser(int enumValue, string enumDescriptor)
        {
            this._enumList = new List<EnumFileParser>();
            this._enumValue = enumValue;
            this._enumDescriptor = enumDescriptor;
        }

        public List<EnumFileParser> ParseFile(string filename, ParseType format)
        {
            List<EnumFileParser> list;
            try
            {
                this._enumList.Clear();
                if (!File.Exists(filename))
                {
                    throw new Exception("Requested file does not exist!");
                }
                StreamReader reader = new StreamReader(filename);
                string str = string.Empty;
                while (reader.Peek() != -1)
                {
                    str = reader.ReadLine();
                    if (!(str.StartsWith(";") | (str.Length <= 1)))
                    {
                        string[] strArray = str.Split(new char[] { '^' });
                        if (format == ParseType.Hex)
                        {
                            this._enumList.Add(new EnumFileParser(Convert.ToInt32(strArray[0].Replace("0x", string.Empty), 0x10), strArray[1].Replace("\"", string.Empty)));
                        }
                        else if (format == ParseType.Dec)
                        {
                            this._enumList.Add(new EnumFileParser(int.Parse(strArray[0]), strArray[1].Replace("\"", string.Empty)));
                        }
                    }
                }
                reader.Close();
                list = this._enumList;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, null);
                list = null;
                ProjectData.ClearProjectError();
            }
            return list;
        }

        public string EnumDescriptor =>
            this._enumDescriptor;

        public int EnumValue =>
            this._enumValue;

        public enum ParseType
        {
            Hex,
            Dec
        }
    }
}


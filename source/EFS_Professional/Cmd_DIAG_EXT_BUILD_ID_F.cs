namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class Cmd_DIAG_EXT_BUILD_ID_F : EFS_Professional.Command
    {
        private string AppPath;
        private string fileMobModelID;
        private string fileMSMHWRev;
        private string mobModelID;
        private string mobSWRev;
        private string msmHWRev;
        private string reserved;

        public Cmd_DIAG_EXT_BUILD_ID_F(Qcdm.Cmd QCDMCmd, string strConsoleOut) : base(QCDMCmd, strConsoleOut)
        {
            this.AppPath = Application.StartupPath.ToString();
            this.fileMSMHWRev = this.AppPath + @"\QCDM\ENUMS\MSMHWRev.txt";
            this.fileMobModelID = this.AppPath + @"\QCDM\ENUMS\MobModel.txt";
        }

        public override object Decode()
        {
            using (MemoryStream stream = new MemoryStream(this.BytesRX))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    if (stream.Length <= 3L)
                    {
                        return new DIAG_EXT_BUILD_ID_F_CLS("-1", "-1", "-1");
                    }
                    reader.BaseStream.Position = 1L;
                    byte[] byteInput = reader.ReadBytes(3).Reverse<byte>().ToArray<byte>();
                    this.reserved = "0x00" + ConversionUtils.BytesToHexString(byteInput);
                    byteInput = BitConverter.GetBytes(reader.ReadInt32()).Reverse<byte>().ToArray<byte>();
                    if (File.Exists(this.fileMSMHWRev))
                    {
                        this.msmHWRev = HelperUtils.GetEnumValue(ConversionUtils.BytesToHexString(byteInput), this.fileMSMHWRev, EnumFileParser.ParseType.Hex);
                    }
                    else
                    {
                        this.msmHWRev = "0x" + ConversionUtils.BytesToHexString(byteInput);
                    }
                    if (File.Exists(this.fileMobModelID))
                    {
                        this.mobModelID = HelperUtils.GetEnumValue(reader.ReadInt32(), this.fileMobModelID, EnumFileParser.ParseType.Dec);
                    }
                    else
                    {
                        this.mobModelID = Conversions.ToString(reader.ReadInt32());
                    }
                    List<byte> list = new List<byte>();
                    while (reader.BaseStream.Position < (reader.BaseStream.Length - 1L))
                    {
                        byte num = reader.ReadByte();
                        if (Convert.ToChar(num) == '\0')
                        {
                            break;
                        }
                        list.Add(num);
                    }
                    this.mobSWRev = ConversionUtils.GetASCIIString(list.ToArray());
                    return new DIAG_EXT_BUILD_ID_F_CLS(this.msmHWRev, this.mobModelID, this.mobSWRev);
                }
            }
        }
    }
}


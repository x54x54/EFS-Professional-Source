namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public class Cmd_DIAG_VERNO_F : EFS_Professional.Command
    {
        private string AppPath;
        private string compileDate;
        private string compileTime;
        private const int DATE_STRLEN = 11;
        private string fileMobCAIRev;
        private string fileMobModel;
        private string fileMSMRev;
        private string mobCAIRev;
        private string mobFWRev;
        private string mobModel;
        private string msmRev;
        private string releaseDate;
        private string releaseTime;
        private string slotCycleIndex;
        private string stationClassMark;
        private const int TIME_STRLEN = 8;
        private string verDir;
        private const int VERSION_DIR_STRLEN = 8;

        public Cmd_DIAG_VERNO_F(Qcdm.Cmd QCDMCmd, string strConsoleOut) : base(QCDMCmd, strConsoleOut)
        {
            this.AppPath = Application.StartupPath.ToString();
            this.fileMobModel = this.AppPath + @"\QCDM\ENUMS\MobModel.txt";
            this.fileMobCAIRev = this.AppPath + @"\QCDM\ENUMS\MobCAIRev.txt";
            this.fileMSMRev = this.AppPath + @"\QCDM\ENUMS\MSMRev.txt";
        }

        public override object Decode()
        {
            using (MemoryStream stream = new MemoryStream(this.BytesRX))
            {
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    if (stream.Length <= 3L)
                    {
                        return new DIAG_VERNO_F_CLS("-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1", "-1");
                    }
                    reader.BaseStream.Position = 1L;
                    this.compileDate = ConversionUtils.GetASCIIString(reader.ReadBytes(11));
                    this.compileTime = ConversionUtils.GetASCIIString(reader.ReadBytes(8));
                    this.releaseDate = ConversionUtils.GetASCIIString(reader.ReadBytes(11));
                    this.releaseTime = ConversionUtils.GetASCIIString(reader.ReadBytes(8));
                    this.verDir = ConversionUtils.GetASCIIString(reader.ReadBytes(8));
                    this.stationClassMark = Conversions.ToString(reader.ReadByte());
                    if (File.Exists(this.fileMobCAIRev))
                    {
                        this.mobCAIRev = HelperUtils.GetEnumValue(reader.ReadByte(), this.fileMobCAIRev, EnumFileParser.ParseType.Dec);
                    }
                    else
                    {
                        this.mobCAIRev = Conversions.ToString(reader.ReadByte());
                    }
                    if (File.Exists(this.fileMobModel))
                    {
                        this.mobModel = HelperUtils.GetEnumValue(reader.ReadByte(), this.fileMobModel, EnumFileParser.ParseType.Dec);
                    }
                    else
                    {
                        this.mobModel = Conversions.ToString(reader.ReadByte());
                    }
                    this.mobFWRev = Conversions.ToString((int) reader.ReadInt16());
                    this.slotCycleIndex = reader.ReadByte().ToString();
                    if (File.Exists(this.fileMSMRev))
                    {
                        this.msmRev = HelperUtils.GetEnumValue(ConversionUtils.BytesToHexString(reader.ReadBytes(2).Reverse<byte>().ToArray<byte>()), this.fileMSMRev, EnumFileParser.ParseType.Hex);
                    }
                    else
                    {
                        this.msmRev = "0x" + ConversionUtils.BytesToHexString(reader.ReadBytes(2).Reverse<byte>().ToArray<byte>());
                    }
                    return new DIAG_VERNO_F_CLS(this.compileDate, this.compileTime, this.releaseDate, this.releaseTime, this.verDir, this.stationClassMark, this.mobCAIRev, this.mobModel, this.mobFWRev, this.slotCycleIndex, this.msmRev);
                }
            }
        }
    }
}


namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Text;

    public class DeviceFilterClass : IDisposable
    {
        private string _description;
        private string _displayName;
        private string _fileName;
        public const int _header = 0x17042013;
        private string _partToDisp;
        public const int _signature = 0x30091989;
        private static BinaryReader binReader;
        private static BinaryWriter binWriter;
        private bool disposedValue;

        public DeviceFilterClass(string fileName, string displayName, string partToDisp, string description)
        {
            this._fileName = fileName;
            this._displayName = displayName;
            this._partToDisp = partToDisp;
            this._description = description;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposedValue)
            {
                if (disposing)
                {
                    if (binReader != null)
                    {
                        binReader.Dispose();
                    }
                    if (binWriter != null)
                    {
                        binWriter.Dispose();
                    }
                }
                binReader = null;
                binWriter = null;
            }
            this.disposedValue = true;
        }

        public static bool ReadBIN(string fileName, ref DeviceFilterClass devFilter)
        {
            bool flag;
            try
            {
                string str;
                string str2;
                string str3;
                using (FileStream stream = File.OpenRead(fileName))
                {
                    binReader = new BinaryReader(stream);
                    if (binReader.ReadInt32() != 0x17042013)
                    {
                        Interaction.MsgBox("Device Filter contains an invalid header!", MsgBoxStyle.Critical, null);
                        return false;
                    }
                    str2 = Encoding.UTF8.GetString(ConversionUtils.HexStringToBytes(binReader.ReadString()));
                    str3 = Encoding.UTF8.GetString(ConversionUtils.HexStringToBytes(binReader.ReadString()));
                    str = Encoding.UTF8.GetString(ConversionUtils.HexStringToBytes(binReader.ReadString()));
                    binReader.BaseStream.Position = binReader.BaseStream.Length - 4L;
                    if (binReader.ReadInt32() != 0x30091989)
                    {
                        Interaction.MsgBox("Device Filter contains an invalid signature!", MsgBoxStyle.Critical, null);
                        return false;
                    }
                    binReader.Close();
                }
                devFilter = new DeviceFilterClass(fileName, str2, str3, str);
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Error reading binary file!", MsgBoxStyle.Critical, null);
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public override string ToString() => 
            this._displayName;

        public static bool WriteBIN(DeviceFilterClass devFilter, string fileName)
        {
            bool flag;
            try
            {
                using (FileStream stream = File.Create(fileName))
                {
                    binWriter = new BinaryWriter(stream);
                    binWriter.Write(0x17042013);
                    binWriter.Write(ConversionUtils.BytesToHexString(Encoding.UTF8.GetBytes(devFilter._displayName)));
                    binWriter.Write(ConversionUtils.BytesToHexString(Encoding.UTF8.GetBytes(devFilter._partToDisp)));
                    binWriter.Write(ConversionUtils.BytesToHexString(Encoding.UTF8.GetBytes(devFilter._description)));
                    binWriter.Write(0x30091989);
                    binWriter.Close();
                }
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Error writing binary file!", MsgBoxStyle.Critical, null);
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public string Description =>
            this._description;

        public string DisplayName =>
            this._displayName;

        public string FileName =>
            this._fileName;

        public string PartitionsToDisplay =>
            this._partToDisp;
    }
}


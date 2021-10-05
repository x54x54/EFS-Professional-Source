namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;

    public class AppConfigClass : IDisposable
    {
        private string _devStorageLocation;
        private short _enableAppDebug;
        private string _fileName;
        public const int _header = 0x31024071;
        private int _pitBufferSize;
        public const int _signature = -1735290877;
        private static BinaryReader binReader;
        private static BinaryWriter binWriter;
        private bool disposedValue;

        public AppConfigClass(short enableAppDebug, string devStorageLocation, int pitBufferSize)
        {
            this._enableAppDebug = enableAppDebug;
            this._devStorageLocation = devStorageLocation;
            this._pitBufferSize = pitBufferSize;
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

        public static bool ReadConfigBIN(string fileName, ref AppConfigClass appConfig)
        {
            bool flag;
            try
            {
                string str;
                short num;
                int num2;
                using (FileStream stream = File.OpenRead(fileName))
                {
                    binReader = new BinaryReader(stream);
                    if (binReader.ReadInt32() != 0x31024071)
                    {
                        Interaction.MsgBox("App. Config file contains an invalid header!", MsgBoxStyle.Critical, null);
                        return false;
                    }
                    num = binReader.ReadInt16();
                    str = binReader.ReadString();
                    num2 = binReader.ReadInt32();
                    binReader.BaseStream.Position = binReader.BaseStream.Length - 4L;
                    if (binReader.ReadInt32() != -1735290877)
                    {
                        Interaction.MsgBox("App. Config file contains an invalid signature!", MsgBoxStyle.Critical, null);
                        return false;
                    }
                    binReader.Close();
                }
                appConfig = new AppConfigClass(num, str, num2);
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Error reading App. Config file!", MsgBoxStyle.Critical, null);
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public override string ToString() => 
            this._devStorageLocation;

        public static bool WriteConfigBIN(AppConfigClass appConfig, string fileName)
        {
            bool flag;
            try
            {
                using (FileStream stream = File.Create(fileName))
                {
                    binWriter = new BinaryWriter(stream);
                    binWriter.Write(0x31024071);
                    binWriter.Write(appConfig.EnableAppDebug);
                    binWriter.Write(appConfig.DeviceStorageLocation);
                    binWriter.Write(appConfig.PITFileBufferSize);
                    binWriter.Write(-1735290877);
                    binWriter.Close();
                }
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Error writing App. Config file!", MsgBoxStyle.Critical, null);
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public string DeviceStorageLocation =>
            this._devStorageLocation;

        public short EnableAppDebug =>
            this._enableAppDebug;

        public int PITFileBufferSize =>
            this._pitBufferSize;
    }
}


namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.IO;
    using System.Text;

    public class PitInputStream : IDisposable
    {
        private BinaryReader _inputStream;
        private bool disposedValue;

        public PitInputStream(Stream byteStream)
        {
            this._inputStream = new BinaryReader(byteStream, Encoding.UTF8);
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
                if (disposing && (this._inputStream != null))
                {
                    this._inputStream.Dispose();
                }
                this._inputStream = null;
            }
            this.disposedValue = true;
        }

        public string GetMemoryAddress() => 
            $"0x{this._inputStream.BaseStream.Position.ToString("X8")}";

        public int Read(byte[] buffer, int offset, int length) => 
            this._inputStream.Read(buffer, offset, length);

        public byte[] ReadBytes(int byteCount) => 
            this._inputStream.ReadBytes(byteCount);

        public int ReadInt() => 
            this._inputStream.ReadInt32();

        public string ReadRemainingBytes()
        {
            int count = (int) (this._inputStream.BaseStream.Length - this._inputStream.BaseStream.Position);
            byte[] buffer = new byte[0];
            buffer = this._inputStream.ReadBytes(count);
            StringBuilder builder = new StringBuilder(buffer.Length * 2);
            foreach (byte num2 in buffer)
            {
                builder.AppendFormat("{0:X2}", num2);
            }
            return builder.ToString();
        }

        public short ReadShort() => 
            this._inputStream.ReadInt16();

        public string ReadString(byte[] buffer, int strMaxLength)
        {
            char[] chArray = new char[(strMaxLength - 1) + 1];
            StringBuilder builder = new StringBuilder(strMaxLength);
            if (this._inputStream.Read(buffer, 0, strMaxLength) != strMaxLength)
            {
                return Conversions.ToString(-1);
            }
            int num3 = strMaxLength - 1;
            for (int i = 0; i <= num3; i++)
            {
                chArray[i] = Convert.ToChar(buffer[i]);
            }
            return new string(chArray, 0, strMaxLength);
        }
    }
}


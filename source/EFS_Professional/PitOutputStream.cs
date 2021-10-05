namespace EFS_Professional
{
    using System;
    using System.IO;
    using System.Text;

    public class PitOutputStream : IDisposable
    {
        private BinaryWriter _outputStream;
        private bool disposedValue;

        public PitOutputStream(Stream byteStream)
        {
            this._outputStream = new BinaryWriter(byteStream, Encoding.UTF8);
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
                if (disposing && (this._outputStream != null))
                {
                    this._outputStream.Dispose();
                }
                this._outputStream = null;
            }
            this.disposedValue = true;
        }

        public void Write(byte[] buffer, int offset, int length)
        {
            this._outputStream.Write(buffer, offset, length);
        }

        public void WriteBytes(byte[] buffer)
        {
            this._outputStream.Write(buffer);
        }

        public void WriteInt(int value)
        {
            byte[] buffer = new byte[] { (byte) (value & 0xff), (byte) ((value & 0xff00) >> 8), (byte) ((value & 0xff0000) >> 0x10), (byte) ((value & 0xff000000L) >> 0x18) };
            this._outputStream.Write(buffer);
        }

        public void WriteRemainingBytes(string hexString)
        {
            int length = hexString.Length;
            byte[] buffer = new byte[((length / 2) - 1) + 1];
            int num3 = length - 1;
            for (int i = 0; i <= num3; i += 2)
            {
                buffer[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 0x10);
            }
            this._outputStream.Write(buffer);
        }

        public void WriteShort(short value)
        {
            byte[] buffer = new byte[] { (byte) (value & 0xff), (byte) ((value & 0xff00) >> 8) };
            this._outputStream.Write(buffer);
        }

        public void WriteString(string str, int strMaxLength)
        {
            char[] chArray = str.ToCharArray();
            byte[] buffer = new byte[(strMaxLength - 1) + 1];
            for (int i = 0; i < strMaxLength; i++)
            {
                if (i < chArray.Length)
                {
                    buffer[i] = Convert.ToByte(chArray[i]);
                }
                else
                {
                    buffer[i] = Convert.ToByte(0);
                }
            }
            this._outputStream.Write(buffer, 0, buffer.Length);
        }
    }
}


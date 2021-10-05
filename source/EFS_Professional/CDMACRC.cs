namespace EFS_Professional
{
    using System;

    public class CDMACRC
    {
        private ushort initialValue = 0;
        private const ushort poly = 0x1021;
        private ushort[] table = new ushort[0x100];

        public CDMACRC(InitialCrcValue initialValue)
        {
            this.initialValue = (ushort) initialValue;
            int num5 = this.table.Length - 1;
            for (int i = 0; i <= num5; i++)
            {
                ushort num2 = 0;
                ushort num = (ushort) (i << 8);
                int num4 = 0;
                do
                {
                    if (((num2 ^ num) & 0x8000) != 0)
                    {
                        num2 = (ushort) (((ushort) (num2 << 1)) ^ 0x1021);
                    }
                    else
                    {
                        num2 = (ushort) (num2 << 1);
                    }
                    num = (ushort) (num << 1);
                    num4++;
                }
                while (num4 <= 7);
                this.table[i] = num2;
            }
        }

        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort initialValue = this.initialValue;
            int num4 = bytes.Length - 1;
            for (int i = 0; i <= num4; i++)
            {
                initialValue = (ushort) (((ushort) (initialValue << 8)) ^ this.table[((ushort) (initialValue >> 8)) ^ (0xff & bytes[i])]);
            }
            return initialValue;
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort num = this.ComputeChecksum(bytes);
            return new byte[] { ((byte) ((ushort) (num >> 8))), ((byte) (num & 0xff)) };
        }

        public enum InitialCrcValue
        {
            NonZero1 = 0xffff,
            NonZero2 = 0x1d0f,
            Zeros = 0
        }
    }
}


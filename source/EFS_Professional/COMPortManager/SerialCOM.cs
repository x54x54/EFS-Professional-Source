namespace EFS_Professional.COMPortManager
{
    using System;
    using System.IO;
    using System.IO.Ports;
    using System.Text;
    using System.Threading;

    public class SerialCOM
    {
        private readonly int baudRate;
        private readonly byte byteSize;
        private IntPtr handle;
        private readonly Parity parity;
        private string portName;
        private readonly StopBits stopBits;

        public SerialCOM(string portName, int baudRate, StopBits stopBits, Parity parity) : this(portName, baudRate, stopBits, parity, 8)
        {
        }

        public SerialCOM(string portName, int baudRate, StopBits stopBits__1, Parity parity, byte byteSize)
        {
            this.handle = IntPtr.Zero;
            if (stopBits__1 == StopBits.None)
            {
                throw new ArgumentException("stopBits cannot be StopBits.None", "stopBits");
            }
            if ((byteSize < 5) || (byteSize > 8))
            {
                throw new ArgumentOutOfRangeException("The number of data bits must be 5 to 8 bits.", "byteSize");
            }
            if ((baudRate < 110) || (baudRate > 0x3e800))
            {
                throw new ArgumentOutOfRangeException("Invalid baud rate specified.", "baudRate");
            }
            if (((byteSize == 5) && (stopBits__1 == StopBits.Two)) || ((stopBits__1 == StopBits.OnePointFive) && (byteSize > 5)))
            {
                throw new ArgumentException("The use of 5 data bits with 2 stop bits is an invalid combination, as is 6, 7, or 8 data bits with 1.5 stop bits.");
            }
            this.portName = portName;
            this.baudRate = baudRate;
            this.byteSize = byteSize;
            this.stopBits = stopBits__1;
            this.parity = parity;
        }

        private bool ConfigureSerialPort()
        {
            NativeMethods.DCB lpDCB = new NativeMethods.DCB();
            if (!NativeMethods.GetCommState(this.handle, ref lpDCB))
            {
                return false;
            }
            lpDCB.BaudRate = (uint) this.baudRate;
            lpDCB.ByteSize = this.byteSize;
            lpDCB.fBinary = 1;
            lpDCB.fDtrControl = 1;
            lpDCB.fAbortOnError = 0;
            lpDCB.fTXContinueOnXoff = 0;
            lpDCB.fParity = 1;
            switch (this.parity)
            {
                case Parity.None:
                    lpDCB.Parity = 0;
                    break;

                case Parity.Odd:
                    lpDCB.Parity = 1;
                    break;

                case Parity.Even:
                    lpDCB.Parity = 2;
                    break;

                case Parity.Mark:
                    lpDCB.Parity = 3;
                    break;

                case Parity.Space:
                    lpDCB.Parity = 4;
                    break;
            }
            switch (this.stopBits)
            {
                case StopBits.None:
                    throw new ArgumentException("stopBits cannot be StopBits.None");

                case StopBits.One:
                    lpDCB.StopBits = 0;
                    break;

                case StopBits.Two:
                    lpDCB.StopBits = 2;
                    break;

                case StopBits.OnePointFive:
                    lpDCB.StopBits = 1;
                    break;
            }
            if (!NativeMethods.SetCommState(this.handle, ref lpDCB))
            {
                return false;
            }
            NativeMethods.COMMTIMEOUTS lpCommTimeouts = new NativeMethods.COMMTIMEOUTS {
                ReadIntervalTimeout = 20,
                ReadTotalTimeoutMultiplier = 10,
                ReadTotalTimeoutConstant = 100,
                WriteTotalTimeoutMultiplier = 10,
                WriteTotalTimeoutConstant = 100
            };
            return NativeMethods.SetCommTimeouts(this.handle, ref lpCommTimeouts);
        }

        public void Dispose()
        {
            if (this.handle != IntPtr.Zero)
            {
                NativeMethods.CloseHandle(this.handle);
                this.handle = IntPtr.Zero;
            }
        }

        private void FailIfNotConnected()
        {
            if (this.handle == IntPtr.Zero)
            {
                throw new InvalidOperationException("You must be connected to the serial port before performing this operation.");
            }
        }

        public bool Flush()
        {
            this.FailIfNotConnected();
            return NativeMethods.PurgeComm(this.handle, 12);
        }

        public bool IsOpen()
        {
            if (this.handle == IntPtr.Zero)
            {
                return false;
            }
            return true;
        }

        public bool Open()
        {
            this.handle = NativeMethods.CreateFile(this.portName, FileAccess.ReadWrite, FileShare.None, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);
            if (this.handle != IntPtr.Zero)
            {
                if (this.ConfigureSerialPort())
                {
                    return true;
                }
                this.Dispose();
            }
            return false;
        }

        public int Read(byte[] data)
        {
            int num;
            NativeOverlapped overlapped;
            this.FailIfNotConnected();
            if (data == null)
            {
                return 0;
            }
            NativeOverlapped lpOverlapped = overlapped;
            if (NativeMethods.ReadFile(this.handle, data, data.Length, ref num, ref lpOverlapped))
            {
                return num;
            }
            return -1;
        }

        public string ReadString(int maxBytesToRead)
        {
            if (maxBytesToRead < 1)
            {
                throw new ArgumentOutOfRangeException("maxBytesToRead");
            }
            byte[] data = new byte[(maxBytesToRead - 1) + 1];
            int count = this.Read(data);
            return Encoding.ASCII.GetString(data, 0, count);
        }

        public void SetPort(string portNameIn)
        {
            this.portName = portNameIn;
        }

        public int Write(byte[] data)
        {
            int num;
            NativeOverlapped overlapped;
            this.FailIfNotConnected();
            if (data == null)
            {
                return 0;
            }
            NativeOverlapped lpOverlapped = overlapped;
            if (NativeMethods.WriteFile(this.handle, data, data.Length, ref num, ref lpOverlapped))
            {
                return num;
            }
            return -1;
        }

        public int Write(string data)
        {
            byte[] bytes;
            this.FailIfNotConnected();
            if (data == null)
            {
                bytes = null;
            }
            else
            {
                bytes = Encoding.ASCII.GetBytes(data);
            }
            return this.Write(bytes);
        }

        public int WriteLine(string data)
        {
            if ((data != null) && !data.EndsWith("\r\n"))
            {
                data = data + "\r\n";
            }
            return this.Write(data);
        }
    }
}


namespace EFS_Professional.COMPortManager
{
    using System;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Threading;

    public class NativeMethods
    {
        [DllImport("kernel32.dll", SetLastError=true)]
        internal static extern bool CloseHandle(IntPtr hObject);
        [DllImport("kernel32.dll", CharSet=CharSet.Unicode, SetLastError=true)]
        internal static extern IntPtr CreateFile(string fileName, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess, [MarshalAs(UnmanagedType.U4)] FileShare fileShare, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, int flags, IntPtr template);
        [DllImport("kernel32.dll")]
        internal static extern bool GetCommState(IntPtr hFile, ref DCB lpDCB);
        [DllImport("kernel32.dll", SetLastError=true)]
        internal static extern bool PurgeComm(IntPtr hFile, int dwFlags);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll")]
        internal static extern bool ReadFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToRead, ref int lpNumberOfBytesRead, ref NativeOverlapped lpOverlapped);
        [DllImport("kernel32.dll")]
        internal static extern bool SetCommState(IntPtr hFile, [In] ref DCB lpDCB);
        [DllImport("kernel32.dll", SetLastError=true)]
        internal static extern bool SetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError=true)]
        internal static extern bool WaitCommEvent(IntPtr hFile, IntPtr lpEvtMask, ref NativeOverlapped lpOverlapped);
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", SetLastError=true)]
        internal static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, int nNumberOfBytesToWrite, ref int lpNumberOfBytesWritten, ref NativeOverlapped lpOverlapped);

        [StructLayout(LayoutKind.Sequential)]
        internal struct COMMTIMEOUTS
        {
            public uint ReadIntervalTimeout;
            public uint ReadTotalTimeoutMultiplier;
            public uint ReadTotalTimeoutConstant;
            public uint WriteTotalTimeoutMultiplier;
            public uint WriteTotalTimeoutConstant;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct DCB
        {
            public int DCBlength;
            public uint BaudRate;
            public uint Flags;
            public ushort wReserved;
            public ushort XonLim;
            public ushort XoffLim;
            public byte ByteSize;
            public byte Parity;
            public byte StopBits;
            public sbyte XonChar;
            public sbyte XoffChar;
            public sbyte ErrorChar;
            public sbyte EofChar;
            public sbyte EvtChar;
            public ushort wReserved1;
            public uint fBinary;
            public uint fParity;
            public uint fOutxCtsFlow;
            public uint fOutxDsrFlow;
            public uint fDtrControl;
            public uint fDsrSensitivity;
            public uint fTXContinueOnXoff;
            public uint fOutX;
            public uint fInX;
            public uint fErrorChar;
            public uint fNull;
            public uint fRtsControl;
            public uint fAbortOnError;
        }
    }
}


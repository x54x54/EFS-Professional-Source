namespace EFS_Professional
{
    using EFS_Professional.COMPortManager;
    using System;
    using System.Collections.Generic;
    using System.IO.Ports;
    using System.Runtime.CompilerServices;

    public class QualcommDeviceInstance : IDisposable
    {
        [AccessedThroughProperty("_commandQueue")]
        private CommandQueue __commandQueue;
        [AccessedThroughProperty("_NVMemoryManager")]
        private NVMemoryManager __NVMemoryManager;
        private static QualcommDeviceInstance _initQCDevInstance;
        private SerialCOM _serialPort;
        private bool disposedValue;

        public QualcommDeviceInstance()
        {
            this._commandQueue = new CommandQueue(this);
            this._NVMemoryManager = new NVMemoryManager(this);
        }

        internal bool Connect(string comPort)
        {
            if (this._serialPort != null)
            {
                return false;
            }
            this._serialPort = new SerialCOM(@"\\.\" + comPort, 0x1c200, StopBits.One, Parity.None, 8);
            return this._serialPort.Open();
        }

        internal void Disconnect()
        {
            if (this._serialPort != null)
            {
                this._serialPort.Flush();
                this._serialPort.Dispose();
                this._serialPort = null;
            }
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
                    this.Disconnect();
                    if (this._commandQueue != null)
                    {
                        this._commandQueue.Dispose();
                        this._commandQueue = null;
                    }
                    if (this._NVMemoryManager != null)
                    {
                        this._NVMemoryManager.Dispose();
                        this._NVMemoryManager = null;
                    }
                    _initQCDevInstance = null;
                }
            }
            this.disposedValue = true;
        }

        internal List<COMPortInfo> GetCOMPortList()
        {
            COMPortInfo info = new COMPortInfo();
            return info.GetCOMPortsInfo();
        }

        internal bool IsConnected() => 
            this._serialPort?.IsOpen();

        internal void ResetCOMPort()
        {
            if (this._serialPort != null)
            {
                this._serialPort.Dispose();
                this._serialPort = null;
            }
        }

        private CommandQueue _commandQueue
        {
            get => 
                this.__commandQueue;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.__commandQueue = value;
            }
        }

        private NVMemoryManager _NVMemoryManager
        {
            get => 
                this.__NVMemoryManager;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.__NVMemoryManager = value;
            }
        }

        internal CommandQueue CommandQueueInstance =>
            this._commandQueue;

        internal static QualcommDeviceInstance Init
        {
            get
            {
                if (_initQCDevInstance == null)
                {
                    _initQCDevInstance = new QualcommDeviceInstance();
                }
                return _initQCDevInstance;
            }
        }

        internal NVMemoryManager NVMemMgrInstance =>
            this._NVMemoryManager;

        internal SerialCOM SerialPortInstance =>
            this._serialPort;
    }
}


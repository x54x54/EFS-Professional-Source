namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.ComponentModel;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class CommandQueue : Component
    {
        private bool _chkNVItems;
        private ArrayList _commandOutput;
        private bool _disableLogging;
        private List<Qcdm.NV_Response> _errorResponse;
        private string _fileName;
        private QualcommDeviceInstance _instance;
        private bool _isBusy;
        private List<NVItemList> _nvCmd;
        private OperationModes _opMode;
        private List<Qcdm.Cmd> _qcdmCmd;
        private AutoResetEvent _waitEvent;
        private int cBufferSize;
        private Queue cmdNVQueue;
        private Queue cmdQueue;
        private System.ComponentModel.Container components;
        private bool enableFastBuffer;
        private Queue myNVQueue;
        private Queue myQueue;
        private SendOrPostCallback onCompletedDelegate;
        private SendOrPostCallback onDataActivityRXDelegate;
        private SendOrPostCallback onDataActivityTXDelegate;
        private SendOrPostCallback onNVItemsStatusDelegate;
        private SendOrPostCallback onProgressReportDelegate;
        private string taskIdentifier;
        private HybridDictionary userStateToLifetime;

        public event DataActivityEventHandler DataActivityRX;

        public event DataActivityEventHandler DataActivityTX;

        public event NVItemsStatusEventHandler NVItemsStatusChanged;

        public event EFS_Professional.ProgressChangedEventHandler ProgressChanged;

        public event RunCompletedEventHandler RunCompleted;

        public CommandQueue(QualcommDeviceInstance instance)
        {
            this.enableFastBuffer = false;
            this.cBufferSize = 0x100;
            this._opMode = OperationModes.Normal;
            this._disableLogging = false;
            this._chkNVItems = false;
            this._fileName = string.Empty;
            this._qcdmCmd = new List<Qcdm.Cmd>();
            this._nvCmd = new List<NVItemList>();
            this._commandOutput = null;
            this._errorResponse = new List<Qcdm.NV_Response>();
            this.myQueue = new Queue();
            this.cmdQueue = Queue.Synchronized(this.myQueue);
            this.myNVQueue = new Queue();
            this.cmdNVQueue = Queue.Synchronized(this.myNVQueue);
            this.taskIdentifier = "CommandQueue";
            this.userStateToLifetime = new HybridDictionary();
            this.components = null;
            this.InitializeComponent();
            this.InitializeDelegates();
            this.SetCmdQueueDefaults(instance);
        }

        public CommandQueue(QualcommDeviceInstance instance, IContainer container)
        {
            this.enableFastBuffer = false;
            this.cBufferSize = 0x100;
            this._opMode = OperationModes.Normal;
            this._disableLogging = false;
            this._chkNVItems = false;
            this._fileName = string.Empty;
            this._qcdmCmd = new List<Qcdm.Cmd>();
            this._nvCmd = new List<NVItemList>();
            this._commandOutput = null;
            this._errorResponse = new List<Qcdm.NV_Response>();
            this.myQueue = new Queue();
            this.cmdQueue = Queue.Synchronized(this.myQueue);
            this.myNVQueue = new Queue();
            this.cmdNVQueue = Queue.Synchronized(this.myNVQueue);
            this.taskIdentifier = "CommandQueue";
            this.userStateToLifetime = new HybridDictionary();
            this.components = null;
            container.Add(this);
            this.InitializeComponent();
            this.InitializeDelegates();
            this.SetCmdQueueDefaults(instance);
        }

        public void Add(ref Command inCommand)
        {
            this.cmdQueue.Enqueue(inCommand);
            this.cmdNVQueue.Enqueue(inCommand);
        }

        public void CancelAsync()
        {
            if (RuntimeHelpers.GetObjectValue(this.userStateToLifetime[this.taskIdentifier]) != null)
            {
                object syncRoot = this.userStateToLifetime.SyncRoot;
                ObjectFlowControl.CheckForSyncLockOnValueType(syncRoot);
                lock (syncRoot)
                {
                    this.userStateToLifetime.Remove(this.taskIdentifier);
                }
            }
        }

        internal bool Cancelled() => 
            (this.userStateToLifetime[this.taskIdentifier] == null);

        public void Clear()
        {
            this._opMode = OperationModes.Normal;
            this._disableLogging = false;
            this._isBusy = false;
            this._chkNVItems = false;
            this._fileName = string.Empty;
            this._qcdmCmd.Clear();
            this._nvCmd.Clear();
            this._commandOutput = null;
            this._errorResponse.Clear();
            this.cmdQueue.Clear();
            this.cmdNVQueue.Clear();
        }

        private void Completed(object operationState)
        {
            RunCompletedEventArgs e = (RunCompletedEventArgs) operationState;
            this.OnRunCompleted(this, e);
        }

        private void CompletionMethod(Exception exc, bool canceled, AsyncOperation asyncOp)
        {
            if (!canceled)
            {
                object syncRoot = this.userStateToLifetime.SyncRoot;
                ObjectFlowControl.CheckForSyncLockOnValueType(syncRoot);
                lock (syncRoot)
                {
                    this.userStateToLifetime.Remove(RuntimeHelpers.GetObjectValue(asyncOp.UserSuppliedState));
                }
            }
            RunCompletedEventArgs arg = new RunCompletedEventArgs(exc, canceled, RuntimeHelpers.GetObjectValue(asyncOp.UserSuppliedState));
            this._isBusy = false;
            asyncOp.PostOperationCompleted(this.onCompletedDelegate, arg);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.components != null)
                {
                    this.components.Dispose();
                }
                if (this._waitEvent != null)
                {
                    this._waitEvent.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private int Get_cBufferSize() => 
            this.cBufferSize;

        public int GetCount() => 
            this.cmdQueue.Count;

        private void InitializeComponent()
        {
        }

        protected virtual void InitializeDelegates()
        {
            this.onDataActivityTXDelegate = new SendOrPostCallback(this.ReportDataActivityTX);
            this.onDataActivityRXDelegate = new SendOrPostCallback(this.ReportDataActivityRX);
            this.onProgressReportDelegate = new SendOrPostCallback(this.ReportProgress);
            this.onNVItemsStatusDelegate = new SendOrPostCallback(this.NVItemsReportStatus);
            this.onCompletedDelegate = new SendOrPostCallback(this.Completed);
        }

        private void NVItemsReportStatus(object status)
        {
            NVItemsStatusEventArgs e = (NVItemsStatusEventArgs) status;
            this.OnNVItemsStatusChanged(e);
        }

        protected void OnDataActivityRX(DataActivityEventArgs e)
        {
            DataActivityEventHandler dataActivityRXEvent = this.DataActivityRXEvent;
            if (dataActivityRXEvent != null)
            {
                dataActivityRXEvent(e);
            }
        }

        protected void OnDataActivityTX(DataActivityEventArgs e)
        {
            DataActivityEventHandler dataActivityTXEvent = this.DataActivityTXEvent;
            if (dataActivityTXEvent != null)
            {
                dataActivityTXEvent(e);
            }
        }

        protected void OnNVItemsStatusChanged(NVItemsStatusEventArgs e)
        {
            NVItemsStatusEventHandler nVItemsStatusChangedEvent = this.NVItemsStatusChangedEvent;
            if (nVItemsStatusChangedEvent != null)
            {
                nVItemsStatusChangedEvent(e);
            }
        }

        protected void OnProgressChanged(ProgressChangedEventArgs e)
        {
            EFS_Professional.ProgressChangedEventHandler progressChangedEvent = this.ProgressChangedEvent;
            if (progressChangedEvent != null)
            {
                progressChangedEvent(e);
            }
        }

        protected void OnRunCompleted(object sender, RunCompletedEventArgs e)
        {
            RunCompletedEventHandler runCompletedEvent = this.RunCompletedEvent;
            if (runCompletedEvent != null)
            {
                runCompletedEvent(this, e);
            }
        }

        private void ProcessCommandQueue(AsyncOperation asyncOp)
        {
            this._isBusy = true;
            this._commandOutput = new ArrayList();
            long count = this.GetCount();
            long num2 = 0L;
            long position = 0L;
            string consoleTX = string.Empty;
            string consoleRX = string.Empty;
            string consoleRXASCII = string.Empty;
            Exception exc = null;
            try
            {
                object syncRoot = this.cmdQueue.SyncRoot;
                ObjectFlowControl.CheckForSyncLockOnValueType(syncRoot);
                lock (syncRoot)
                {
                    while (this.cmdQueue.Count != 0)
                    {
                        if (this.Cancelled())
                        {
                            this.CompletionMethod(null, true, asyncOp);
                            return;
                        }
                        Command command = (Command) this.cmdQueue.Dequeue();
                        this._qcdmCmd.Add(command.CurrentQCDMCommand);
                        this._nvCmd.Add(command.CurrentNVItem);
                        if (!command.TransmitTX(this._instance, asyncOp))
                        {
                            throw new Exception("Phone connection has been lost!");
                        }
                        object objectValue = RuntimeHelpers.GetObjectValue(command.Decode());
                        if (command.BytesRX.Length == 0x88)
                        {
                            this._errorResponse.Add((Qcdm.NV_Response) command.BytesRX[0x83]);
                        }
                        else if (command.BytesRX.Length == 0x89)
                        {
                            this._errorResponse.Add((Qcdm.NV_Response) command.BytesRX[0x84]);
                        }
                        else if (command.BytesRX.Length < 0x88)
                        {
                            this._errorResponse.Add((Qcdm.NV_Response) command.BytesRX[0]);
                        }
                        if (objectValue == null)
                        {
                            throw new Exception("Error decoding command output!");
                        }
                        this._commandOutput.Add(RuntimeHelpers.GetObjectValue(objectValue));
                        if (!this._disableLogging && !string.IsNullOrEmpty(command.ConsoleOutput))
                        {
                            consoleTX = ConversionUtils.FormatHexStr(ConversionUtils.BytesToHexString(command.BytesTX));
                            consoleRX = ConversionUtils.FormatHexStr(ConversionUtils.BytesToHexString(command.BytesRX));
                            consoleRXASCII = ConversionUtils.GetASCIIString(command.BytesRX);
                        }
                        position += 1L;
                        CommandQueueProgressChangedEventArgs arg = new CommandQueueProgressChangedEventArgs(command.ConsoleOutput, consoleTX, consoleRX, consoleRXASCII, (int) command.CurrentNVItem, (int) position, (int) count, (int) Math.Round((double) ((((float) position) / ((float) count)) * 100f)), RuntimeHelpers.GetObjectValue(asyncOp.UserSuppliedState));
                        asyncOp.Post(this.onProgressReportDelegate, arg);
                    }
                }
                if (this._chkNVItems)
                {
                    position = 0L;
                    long badParamNVItems = 0L;
                    long badSecNVItems = 0L;
                    long inactiveNVItems = 0L;
                    long okayNVItems = 0L;
                    object expression = this.cmdNVQueue.SyncRoot;
                    ObjectFlowControl.CheckForSyncLockOnValueType(expression);
                    lock (expression)
                    {
                        IEnumerator enumerator;
                        try
                        {
                            enumerator = this.cmdNVQueue.GetEnumerator();
                            while (enumerator.MoveNext())
                            {
                                byte num6;
                                Command current = (Command) enumerator.Current;
                                if (this.Cancelled())
                                {
                                    this.CompletionMethod(null, true, asyncOp);
                                    return;
                                }
                                if (current.BytesRX.Length == 0x88)
                                {
                                    num6 = current.BytesRX[0x83];
                                }
                                else if (current.BytesRX.Length == 0x89)
                                {
                                    num6 = current.BytesRX[0x84];
                                }
                                else if (current.BytesRX.Length < 0x88)
                                {
                                    num6 = current.BytesRX[0];
                                }
                                if (((num6 == 20) | (num6 == 5)) | (num6 == 6))
                                {
                                    current.ErrorResponse = (Qcdm.NV_Response) num6;
                                    num2 += 1L;
                                }
                            }
                        }
                        finally
                        {
                            if (enumerator is IDisposable)
                            {
                                (enumerator as IDisposable).Dispose();
                            }
                        }
                    }
                    object obj5 = this.cmdNVQueue.SyncRoot;
                    ObjectFlowControl.CheckForSyncLockOnValueType(obj5);
                    lock (obj5)
                    {
                        IEnumerator enumerator2;
                        if (string.IsNullOrEmpty(this._fileName))
                        {
                            throw new FileNotFoundException();
                        }
                        StreamWriter writer = new StreamWriter(this.FileName, false);
                        writer.Write("[NV items]\r\n");
                        writer.Write(("[Complete items - " + ((count - num2)).ToString() + ", Items size - 128]") + "\r\n\r\n");
                        try
                        {
                            enumerator2 = this.cmdNVQueue.GetEnumerator();
                            while (enumerator2.MoveNext())
                            {
                                string str6;
                                Command command3 = (Command) enumerator2.Current;
                                List<string> list = new List<string>();
                                if (command3.BytesRX[0] == 20)
                                {
                                    str6 = ConversionUtils.BytesToHexString(command3.BytesTX).Substring(2, 4);
                                }
                                else
                                {
                                    str6 = ConversionUtils.BytesToHexString(command3.BytesRX).Substring(2, 4);
                                }
                                string s = ConversionUtils.ReverseHex(str6).Replace(" ", "");
                                long num9 = long.Parse(s, NumberStyles.HexNumber);
                                if (command3.ErrorResponse == Qcdm.NV_Response.NV_ERR_BAD_PARAM)
                                {
                                    writer.Write((num9.ToString("d5") + " (0x" + s + ")   -   Parameter bad") + "\r\n\r\n");
                                    badParamNVItems += 1L;
                                }
                                else if (command3.ErrorResponse == Qcdm.NV_Response.NV_ERR_BAD_SECURITY_MODE)
                                {
                                    writer.Write((num9.ToString("d5") + " (0x" + s + ")   -   Access denied") + "\r\n\r\n");
                                    badSecNVItems += 1L;
                                }
                                else if (command3.ErrorResponse == Qcdm.NV_Response.NV_ERR_INACTIVE_NV_ITEM)
                                {
                                    writer.Write((num9.ToString("d5") + " (0x" + s + ")   -   Inactive item") + "\r\n\r\n");
                                    inactiveNVItems += 1L;
                                }
                                else
                                {
                                    string str11 = ConversionUtils.BytesToHexString(command3.BytesRX).Substring(6, 0x100);
                                    writer.Write((num9.ToString("d5") + " (0x" + s + ")   -   OK") + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0x20, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0x40, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0x60, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0x40, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(80, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0x60, 0x20)) + "\r\n");
                                    writer.Write(ConversionUtils.FormatHexStr(str11.Substring(0x80, 0x20)) + "\r\n\r\n");
                                    okayNVItems += 1L;
                                }
                                position += 1L;
                                NVItemsStatusEventArgs args2 = new NVItemsStatusEventArgs(position, badParamNVItems, badSecNVItems, inactiveNVItems, okayNVItems, count, (long) Math.Round((double) ((((float) position) / ((float) count)) * 100f)));
                                asyncOp.Post(this.onNVItemsStatusDelegate, args2);
                            }
                        }
                        finally
                        {
                            if (enumerator2 is IDisposable)
                            {
                                (enumerator2 as IDisposable).Dispose();
                            }
                        }
                        writer.Close();
                    }
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.CompletionMethod(exc, this.Cancelled(), asyncOp);
        }

        public byte[] ProcessReturnBytes(byte[] bytes)
        {
            List<byte> list = new List<byte>();
            int num = bytes.Count<byte>();
            try
            {
                int num3 = num - 1;
                for (int i = 0; i <= num3; i++)
                {
                    if ((i + 1) < (num - 1))
                    {
                        if ((bytes[i] == 0x7d) & (bytes[i + 1] == 0x5d))
                        {
                            list.Add(0x7d);
                            i++;
                        }
                        else if (((i < (num - 2)) && (bytes[i] == 0x7d)) & (bytes[i + 1] == 0x5e))
                        {
                            list.Add(0x7e);
                            i++;
                        }
                        else
                        {
                            list.Add(bytes[i]);
                        }
                    }
                    else
                    {
                        list.Add(bytes[i]);
                    }
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            return list.ToArray();
        }

        public byte[] ReceiveData(byte[] data, AsyncOperation asyncOp)
        {
            int length = data.Length;
            List<byte> list = new List<byte>();
            int num2 = 0;
            if (this.enableFastBuffer)
            {
                int num3 = this.Get_cBufferSize();
                if (length > num3)
                {
                    this.Set_cBufferSize(length);
                }
            }
            byte[] buffer = new byte[this.Get_cBufferSize() + 1];
            try
            {
                num2 = this._instance.SerialPortInstance.Read(buffer);
                DataActivityEventArgs arg = new DataActivityEventArgs(true);
                asyncOp.Post(this.onDataActivityRXDelegate, arg);
                if (num2 == 0)
                {
                    Thread.Sleep(150);
                    num2 = this._instance.SerialPortInstance.Read(buffer);
                    arg = new DataActivityEventArgs(true);
                    asyncOp.Post(this.onDataActivityRXDelegate, arg);
                }
                else
                {
                    int num5 = num2 - 1;
                    for (int i = 0; i <= num5; i++)
                    {
                        list.Add(buffer[i]);
                    }
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            return list.ToArray();
        }

        private void ReportDataActivityRX(object activityState)
        {
            DataActivityEventArgs e = (DataActivityEventArgs) activityState;
            this.OnDataActivityRX(e);
        }

        private void ReportDataActivityTX(object activityState)
        {
            DataActivityEventArgs e = (DataActivityEventArgs) activityState;
            this.OnDataActivityTX(e);
        }

        private void ReportProgress(object state)
        {
            ProgressChangedEventArgs e = (ProgressChangedEventArgs) state;
            this.OnProgressChanged(e);
        }

        public virtual bool Run(bool threaded)
        {
            AsyncOperation asyncOp = AsyncOperationManager.CreateOperation(this.taskIdentifier);
            this._waitEvent = new AutoResetEvent(false);
            object syncRoot = this.userStateToLifetime.SyncRoot;
            ObjectFlowControl.CheckForSyncLockOnValueType(syncRoot);
            lock (syncRoot)
            {
                if (this.userStateToLifetime.Contains(this.taskIdentifier))
                {
                    Interaction.MsgBox("There is an operation still pending.\r\n\r\nPlease disconnect then reconnect your phone and then try again.", MsgBoxStyle.Exclamation, null);
                    return false;
                }
                this.userStateToLifetime[this.taskIdentifier] = asyncOp;
            }
            if (threaded)
            {
                new WorkerEventHandler(this.ProcessCommandQueue).BeginInvoke(asyncOp, null, null);
            }
            else
            {
                this.ProcessCommandQueue(asyncOp);
            }
            return true;
        }

        private void Set_cBufferSize(int size)
        {
            this.cBufferSize = size;
        }

        protected virtual void SetCmdQueueDefaults(QualcommDeviceInstance instance)
        {
            this._instance = instance;
            this._opMode = OperationModes.Normal;
            this._disableLogging = false;
            this._chkNVItems = false;
            this._fileName = string.Empty;
        }

        public bool TransmitData(byte[] data, AsyncOperation asyncOp)
        {
            if (this.enableFastBuffer)
            {
                if (data.Length < 0x88)
                {
                    this.Set_cBufferSize((data.Length * 2) - 1);
                }
                else
                {
                    this.Set_cBufferSize(data.Length);
                }
            }
            try
            {
                this._instance.SerialPortInstance.Write(data);
                DataActivityEventArgs arg = new DataActivityEventArgs(true);
                asyncOp.Post(this.onDataActivityTXDelegate, arg);
                return true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                ProjectData.ClearProjectError();
            }
            return false;
        }

        public void WaitEventSet()
        {
            this._waitEvent.Set();
        }

        public void WaitForEvents()
        {
            this._waitEvent.WaitOne();
        }

        public bool CheckNVItems
        {
            get => 
                this._chkNVItems;
            set
            {
                this._chkNVItems = value;
            }
        }

        public ArrayList CommandOutput =>
            this._commandOutput;

        public bool DisableLogging
        {
            get => 
                this._disableLogging;
            set
            {
                this._disableLogging = value;
            }
        }

        public string FileName
        {
            get => 
                this._fileName;
            set
            {
                this._fileName = value;
            }
        }

        public bool IsBusy =>
            this._isBusy;

        public List<NVItemList> NVCommand =>
            this._nvCmd;

        public List<Qcdm.NV_Response> NVErrorResponse =>
            this._errorResponse;

        public OperationModes OperationMode
        {
            get => 
                this._opMode;
            set
            {
                this._opMode = value;
            }
        }

        public List<Qcdm.Cmd> QCDMCommand =>
            this._qcdmCmd;

        private delegate void WorkerEventHandler(AsyncOperation asyncOp);
    }
}


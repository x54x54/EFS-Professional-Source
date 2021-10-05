namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    internal class NVMemoryManager : IDisposable
    {
        [AccessedThroughProperty("_myQueue")]
        private CommandQueue __myQueue;
        private AsyncOperation _asyncOp;
        private List<long> _customNVItemList;
        private bool _enableNVISkip;
        private List<NVItemSkipClass> _nvItemSkipList;
        private SaveFileDialog _readNVItems;
        private List<string> _skipNVItems;
        private Thread _workerThread;
        private OpenFileDialog _writeNVItems;
        private string AppPath;
        private bool disposedValue;
        private SendOrPostCallback onNVItemsStatusDelegate;
        private SendOrPostCallback onPrepareForRestoreCompleted;

        public event NVItemsStatusEventHandler NVItemsStatusChanged;

        public event EventHandler PrepareForRestoreCompleted;

        internal NVMemoryManager(QualcommDeviceInstance instance)
        {
            this.PrepareForRestoreCompleted += new EventHandler(this.PrepForRestoreCompleted_Internal);
            this.AppPath = Application.StartupPath.ToString();
            this._customNVItemList = new List<long>();
            this._enableNVISkip = false;
            this._skipNVItems = new List<string>();
            this._nvItemSkipList = new List<NVItemSkipClass>();
            this._myQueue = instance.CommandQueueInstance;
            this.InitializeDelegates();
        }

        public void AddToNVItemSkipList(string nvItemHex)
        {
            this._skipNVItems.Add(nvItemHex);
        }

        public void BackupNVItems(List<string> nvList, long skipItemIndex = 0L)
        {
            this._myQueue.Clear();
            this._readNVItems = new SaveFileDialog();
            SaveFileDialog dialog = this._readNVItems;
            dialog.Filter = "CDMA Workshop Files|*.txt";
            dialog.FileName = "*.txt";
            dialog = null;
            if (this._readNVItems.ShowDialog() == DialogResult.Cancel)
            {
                this._readNVItems.Dispose();
            }
            else
            {
                this._myQueue.OperationMode = OperationModes.Backup;
                this._myQueue.DisableLogging = true;
                this._myQueue.CheckNVItems = true;
                this._myQueue.FileName = this._readNVItems.FileName;
                this._readNVItems.Dispose();
                foreach (string str in nvList)
                {
                    long num = Conversions.ToLong(Enum.Parse(typeof(NVItemList), str));
                    string strConsoleOut = "DIAG_NV_READ_F, BackupNVItems - " + str + " (" + Conversions.ToString(num) + ")";
                    if (this._enableNVISkip)
                    {
                        _Closure$__19 e$__ = new _Closure$__19 {
                            $VB$Local_currNV = Conversions.ToString(num)
                        };
                        if (Array.Find<string>(this._nvItemSkipList[(int) skipItemIndex].NVItems.ToArray(), new Predicate<string>(e$__._Lambda$__123)) != e$__.$VB$Local_currNV)
                        {
                            EFS_Professional.Command inCommand = new EFS_Professional.Command(Qcdm.Cmd.DIAG_NV_READ_F, num, new byte[0], strConsoleOut);
                            this._myQueue.Add(ref inCommand);
                        }
                    }
                    else
                    {
                        EFS_Professional.Command command2 = new EFS_Professional.Command(Qcdm.Cmd.DIAG_NV_READ_F, num, new byte[0], strConsoleOut);
                        this._myQueue.Add(ref command2);
                    }
                }
                this._myQueue.Run(true);
            }
        }

        public void BackupNVItems(long fromRange, long toRange, long skipItemIndex = 0L)
        {
            this._myQueue.Clear();
            this._readNVItems = new SaveFileDialog();
            SaveFileDialog dialog = this._readNVItems;
            dialog.Filter = "CDMA Workshop Files|*.txt";
            dialog.FileName = "*.txt";
            dialog = null;
            if (this._readNVItems.ShowDialog() == DialogResult.Cancel)
            {
                this._readNVItems.Dispose();
            }
            else
            {
                this._myQueue.OperationMode = OperationModes.Backup;
                this._myQueue.DisableLogging = true;
                this._myQueue.CheckNVItems = true;
                this._myQueue.FileName = this._readNVItems.FileName;
                this._readNVItems.Dispose();
                long num = toRange - fromRange;
                long num3 = num + fromRange;
                for (long i = fromRange; i <= num3; i += 1L)
                {
                    string strConsoleOut = "DIAG_NV_READ_F, BackupNVItems - " + i.ToString() + " (" + Conversions.ToString(i) + ")";
                    if (this._enableNVISkip)
                    {
                        _Closure$__18 e$__ = new _Closure$__18 {
                            $VB$Local_currNV = i.ToString()
                        };
                        if (Array.Find<string>(this._nvItemSkipList[(int) skipItemIndex].NVItems.ToArray(), new Predicate<string>(e$__._Lambda$__122)) != e$__.$VB$Local_currNV)
                        {
                            EFS_Professional.Command inCommand = new EFS_Professional.Command(Qcdm.Cmd.DIAG_NV_READ_F, i, new byte[0], strConsoleOut);
                            this._myQueue.Add(ref inCommand);
                        }
                    }
                    else
                    {
                        EFS_Professional.Command command2 = new EFS_Professional.Command(Qcdm.Cmd.DIAG_NV_READ_F, i, new byte[0], strConsoleOut);
                        this._myQueue.Add(ref command2);
                    }
                }
                this._myQueue.Run(true);
            }
        }

        public void CancelOperation()
        {
            if (this._myQueue.IsBusy)
            {
                this._myQueue.CancelAsync();
            }
            else
            {
                Interaction.MsgBox("There are no pending operations to cancel!", MsgBoxStyle.Information, null);
            }
        }

        public void ClearNVItemSkipList()
        {
            this._skipNVItems.Clear();
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
                    if (this._readNVItems != null)
                    {
                        this._readNVItems.Dispose();
                    }
                    if (this._writeNVItems != null)
                    {
                        this._writeNVItems.Dispose();
                    }
                    if (this._myQueue != null)
                    {
                        this._myQueue.Dispose();
                    }
                }
                this._readNVItems = null;
                this._writeNVItems = null;
                this._myQueue = null;
            }
            this.disposedValue = true;
        }

        public void DoRestoreNVItems()
        {
            long position = 0L;
            long totalLength = 0L;
            int num = 0;
            int num2 = 0;
            int num4 = 0;
            int num5 = 0;
            StreamReader reader = new StreamReader(this._writeNVItems.FileName);
            ArrayList list = new ArrayList();
            totalLength = reader.BaseStream.Length;
            while (reader.Peek() != -1)
            {
                string str = reader.ReadLine();
                if (str.Contains("Parameter bad"))
                {
                    num++;
                }
                else if (str.Contains("Access denied"))
                {
                    num2++;
                }
                else if (str.Contains("Inactive item"))
                {
                    num4++;
                }
                else if (str.Contains("OK"))
                {
                    num5++;
                }
                list.Add(str);
                position = reader.BaseStream.Position;
                NVItemsStatusEventArgs arg = new NVItemsStatusEventArgs(position, (long) num, (long) num2, (long) num4, (long) num5, totalLength, (long) Math.Round((double) ((((float) position) / ((float) totalLength)) * 100f)));
                this._asyncOp.Post(this.onNVItemsStatusDelegate, arg);
            }
            reader.Close();
            this._writeNVItems.Dispose();
            if (Operators.ConditionalCompareObjectEqual(list[0], "[NV items]", false))
            {
                int num9 = list.Count - 1;
                for (int i = 3; i <= num9; i++)
                {
                    string left = "";
                    string strInput = "";
                    string str2 = "";
                    int num10 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(list[i], null, "IndexOf", new object[] { "(" }, null, null, null), 1));
                    for (int j = 0; j <= num10; j++)
                    {
                        left = Conversions.ToString(Operators.AddObject(left, NewLateBinding.LateIndexGet(list[i], new object[] { j }, null)));
                    }
                    if (list[i].ToString().Contains("OK"))
                    {
                        if (list[i + 1].ToString().Contains("|"))
                        {
                            str2 = list[i + 1].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 2].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 3].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 4].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 5].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 6].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 7].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                            str2 = list[i + 8].ToString();
                            strInput = strInput + str2.Remove(str2.IndexOf("|")).TrimEnd(new char[0]);
                        }
                        else
                        {
                            strInput = (((strInput + list[i + 1].ToString() + list[i + 2].ToString()) + list[i + 3].ToString() + list[i + 4].ToString()) + list[i + 5].ToString() + list[i + 6].ToString()) + list[i + 7].ToString() + list[i + 8].ToString();
                        }
                        strInput = strInput.Replace(" ", "");
                        string strConsoleOut = "DIAG_NV_READ_F, RestoreNVItems - " + left.ToString();
                        EFS_Professional.Command inCommand = new EFS_Professional.Command(Qcdm.Cmd.DIAG_NV_WRITE_F, ConversionUtils.HexStringToBytes(strInput), strConsoleOut);
                        this._myQueue.Add(ref inCommand);
                    }
                    i++;
                }
            }
            else
            {
                Interaction.MsgBox("Invalid NV Items file!", MsgBoxStyle.Critical, "Error!");
                return;
            }
            this._asyncOp.Post(this.onPrepareForRestoreCompleted, new EventArgs());
            this._asyncOp.OperationCompleted();
        }

        protected virtual void InitializeDelegates()
        {
            this.onNVItemsStatusDelegate = new SendOrPostCallback(this.NVItemsReportStatus);
            this.onPrepareForRestoreCompleted = new SendOrPostCallback(this.PrepForRestoreCompleted);
        }

        public bool LoadCustomNVItemList()
        {
            bool flag;
            try
            {
                string path = this.AppPath + @"\QCDM\QCNVT\CustomNVItemList.txt";
                this._customNVItemList.Clear();
                if (!File.Exists(path))
                {
                    return false;
                }
                StreamReader reader = new StreamReader(path);
                string str2 = string.Empty;
                while (reader.Peek() != -1)
                {
                    str2 = reader.ReadLine();
                    if (!(str2.StartsWith(";") | (str2.Length <= 1)))
                    {
                        foreach (string str3 in str2.Split(new char[] { ',' }))
                        {
                            if (str3.Contains("-"))
                            {
                                string[] strArray2 = str3.Split(new char[] { '-' });
                                long num2 = long.Parse(strArray2[0]);
                                int num = (int) (long.Parse(strArray2[1]) - num2);
                                long num6 = num + num2;
                                for (long i = num2; i <= num6; i += 1L)
                                {
                                    this._customNVItemList.Add(i);
                                }
                            }
                            else
                            {
                                this._customNVItemList.Add(long.Parse(str3));
                            }
                        }
                    }
                }
                reader.Close();
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        public bool LoadNVItemSkipList()
        {
            bool flag;
            try
            {
                string path = this.AppPath + @"\QCDM\QCNVT\NVItemSkipList.txt";
                this._nvItemSkipList.Clear();
                if (!File.Exists(path))
                {
                    return false;
                }
                StreamReader reader = new StreamReader(path);
                string str2 = string.Empty;
                while (reader.Peek() != -1)
                {
                    str2 = reader.ReadLine();
                    this._skipNVItems.Clear();
                    if (!(str2.StartsWith(";") | (str2.Length <= 1)))
                    {
                        string[] strArray2 = str2.Split(new char[] { ':' });
                        foreach (string str3 in strArray2[1].Split(new char[] { ',' }))
                        {
                            if (str3.Contains("-"))
                            {
                                string[] strArray3 = str3.Split(new char[] { '-' });
                                int num2 = Convert.ToInt32(strArray3[0].TrimEnd(new char[0]), 0x10);
                                int num = Convert.ToInt32(strArray3[1].TrimEnd(new char[0]), 0x10) - num2;
                                int num7 = num + num2;
                                for (int i = num2; i <= num7; i++)
                                {
                                    this._skipNVItems.Add(Conversions.ToString(i));
                                }
                            }
                            else
                            {
                                int num5 = Convert.ToInt32(str3.TrimEnd(new char[0]), 0x10);
                                this._skipNVItems.Add(Conversions.ToString(num5));
                            }
                        }
                        this._nvItemSkipList.Add(new NVItemSkipClass(strArray2[0].TrimEnd(new char[0]), this._skipNVItems));
                    }
                }
                reader.Close();
                flag = true;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                flag = false;
                ProjectData.ClearProjectError();
            }
            return flag;
        }

        private void NVItemsReportStatus(object status)
        {
            NVItemsStatusEventArgs e = (NVItemsStatusEventArgs) status;
            this.OnNVItemsStatusChanged(e);
        }

        protected void OnNVItemsStatusChanged(NVItemsStatusEventArgs e)
        {
            NVItemsStatusEventHandler nVItemsStatusChangedEvent = this.NVItemsStatusChangedEvent;
            if (nVItemsStatusChangedEvent != null)
            {
                nVItemsStatusChangedEvent(e);
            }
        }

        protected void OnPrepForRestoreCompleted(EventArgs e)
        {
            EventHandler prepareForRestoreCompletedEvent = this.PrepareForRestoreCompletedEvent;
            if (prepareForRestoreCompletedEvent != null)
            {
                prepareForRestoreCompletedEvent(this, e);
            }
        }

        private void PrepForRestoreCompleted(object state)
        {
            EventArgs e = (EventArgs) state;
            this.OnPrepForRestoreCompleted(e);
        }

        private void PrepForRestoreCompleted_Internal(object sender, EventArgs e)
        {
            this._myQueue.Run(true);
        }

        public void RestoreNVItems()
        {
            this._myQueue.Clear();
            this._writeNVItems = new OpenFileDialog();
            OpenFileDialog dialog = this._writeNVItems;
            dialog.Filter = "CDMA Workshop Files|*.txt";
            dialog.FileName = "*.txt";
            dialog = null;
            if (this._writeNVItems.ShowDialog() == DialogResult.Cancel)
            {
                this._writeNVItems.Dispose();
            }
            else
            {
                this._myQueue.OperationMode = OperationModes.Restore;
                this._myQueue.DisableLogging = true;
                this._asyncOp = AsyncOperationManager.CreateOperation(null);
                this._workerThread = new Thread(new ThreadStart(this.DoRestoreNVItems));
                this._workerThread.Start();
            }
        }

        internal virtual CommandQueue _myQueue
        {
            get => 
                this.__myQueue;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.__myQueue = value;
            }
        }

        public List<long> CustomNVItemList
        {
            get
            {
                if (this._customNVItemList.Count == 0)
                {
                    this.LoadCustomNVItemList();
                }
                return this._customNVItemList;
            }
        }

        public bool EnableNVItemSkipping
        {
            get => 
                this._enableNVISkip;
            set
            {
                this._enableNVISkip = value;
            }
        }

        public List<NVItemSkipClass> NVItemSkipList
        {
            get
            {
                if (this._nvItemSkipList.Count == 0)
                {
                    this.LoadNVItemSkipList();
                }
                return this._nvItemSkipList;
            }
        }

        [CompilerGenerated]
        internal class _Closure$__18
        {
            public string $VB$Local_currNV;

            [CompilerGenerated]
            public bool _Lambda$__122(string strNV) => 
                (strNV == this.$VB$Local_currNV);
        }

        [CompilerGenerated]
        internal class _Closure$__19
        {
            public string $VB$Local_currNV;

            [CompilerGenerated]
            public bool _Lambda$__123(string strNV) => 
                (strNV == this.$VB$Local_currNV);
        }
    }
}


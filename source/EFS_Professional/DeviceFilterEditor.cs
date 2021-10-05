namespace EFS_Professional
{
    using EFS_Professional.WinADBHelper;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class DeviceFilterEditor : Form
    {
        private AndroidControl _androidInstance;
        [AccessedThroughProperty("btnAdd")]
        private Button _btnAdd;
        [AccessedThroughProperty("btnAddManually")]
        private Button _btnAddManually;
        [AccessedThroughProperty("btnCancel")]
        private Button _btnCancel;
        [AccessedThroughProperty("btnClearAll")]
        private Button _btnClearAll;
        [AccessedThroughProperty("btnReadDevice")]
        private Button _btnReadDevice;
        [AccessedThroughProperty("btnReadPIT")]
        private Button _btnReadPIT;
        [AccessedThroughProperty("btnRemove")]
        private Button _btnRemove;
        [AccessedThroughProperty("btnSave")]
        private Button _btnSave;
        private DeviceIO _deviceInstance;
        private string _devStorageLoc;
        [AccessedThroughProperty("lblDescription")]
        private Label _lblDescription;
        [AccessedThroughProperty("lblDisplayName")]
        private Label _lblDisplayName;
        [AccessedThroughProperty("lblFileName")]
        private Label _lblFileName;
        [AccessedThroughProperty("lblPartName")]
        private Label _lblPartName;
        [AccessedThroughProperty("lblPartOnDevice")]
        private Label _lblPartOnDevice;
        [AccessedThroughProperty("lblPartToDisp")]
        private Label _lblPartToDisp;
        [AccessedThroughProperty("lblPartToDispInfo")]
        private Label _lblPartToDispInfo;
        [AccessedThroughProperty("lblQueryDevice")]
        private Label _lblQueryDevice;
        [AccessedThroughProperty("lbPartOnDevice")]
        private ListBox _lbPartOnDevice;
        [AccessedThroughProperty("lbPartToDisp")]
        private ListBox _lbPartToDisp;
        [AccessedThroughProperty("pDevFilterEditMain")]
        private Panel _pDevFilterEditMain;
        private int _pitBufferSize;
        private bool _samsungMode;
        [AccessedThroughProperty("txtDescription")]
        private TextBox _txtDescription;
        [AccessedThroughProperty("txtDisplayName")]
        private TextBox _txtDisplayName;
        [AccessedThroughProperty("txtFileName")]
        private TextBox _txtFileName;
        [AccessedThroughProperty("txtPartName")]
        private TextBox _txtPartName;
        private string AppPath;
        private IContainer components;

        public DeviceFilterEditor(DeviceIO devInst, AndroidControl andInst, string devStorageLoc, int pitBufferSize, bool samsungMode)
        {
            base.Load += new EventHandler(this.DeviceFilterEditor_Load);
            this.AppPath = Application.StartupPath.ToString();
            this.InitializeComponent();
            this._deviceInstance = devInst;
            this._androidInstance = andInst;
            this._devStorageLoc = devStorageLoc;
            this._pitBufferSize = pitBufferSize;
            this._samsungMode = samsungMode;
        }

        public DeviceFilterEditor(string fileName, DeviceIO devInst, AndroidControl andInst, string devStorageLoc, int pitBufferSize, bool samsungMode)
        {
            base.Load += new EventHandler(this.DeviceFilterEditor_Load);
            this.AppPath = Application.StartupPath.ToString();
            this.InitializeComponent();
            this._deviceInstance = devInst;
            this._androidInstance = andInst;
            this._devStorageLoc = devStorageLoc;
            this._pitBufferSize = pitBufferSize;
            this._samsungMode = samsungMode;
            if (!string.IsNullOrEmpty(fileName))
            {
                this.txtFileName.Text = Path.GetFileName(fileName);
                this.LoadFile(fileName);
            }
            else
            {
                this.Close();
            }
        }

        [CompilerGenerated]
        private bool _Lambda$__1() => 
            this._androidInstance.ShowWaitDeviceDialog(ref this._deviceInstance, null, "Plug in the USB cable to continue or press Cancel...", true);

        [CompilerGenerated]
        private void _Lambda$__10()
        {
            this.lblQueryDevice.Visible = true;
        }

        [CompilerGenerated]
        private void _Lambda$__11()
        {
            this.lbPartOnDevice.Items.Clear();
        }

        [CompilerGenerated]
        private static void _Lambda$__13()
        {
            Interaction.MsgBox("An error occurred while getting partition list!", MsgBoxStyle.Critical, null);
        }

        [CompilerGenerated]
        private void _Lambda$__14()
        {
            this.lblQueryDevice.Visible = false;
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__15(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__16)();
        }

        [CompilerGenerated]
        private void _Lambda$__16()
        {
            this.ReadFromPIT();
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__17(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__18)();
        }

        [CompilerGenerated]
        private void _Lambda$__18()
        {
            this.ReadFromDevice(this._samsungMode);
        }

        [CompilerGenerated]
        private static void _Lambda$__2()
        {
            Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
        }

        [CompilerGenerated]
        private void _Lambda$__3()
        {
            this.lblQueryDevice.Visible = true;
        }

        [CompilerGenerated]
        private void _Lambda$__4()
        {
            this.lbPartOnDevice.Items.Clear();
        }

        [CompilerGenerated]
        private static void _Lambda$__7()
        {
            Interaction.MsgBox("Unable to extract PIT from device!", MsgBoxStyle.Critical, null);
        }

        [CompilerGenerated]
        private void _Lambda$__9()
        {
            this.lblQueryDevice.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.lbPartOnDevice.SelectedIndex != -1)
            {
                this.lbPartToDisp.Items.Add(this.lbPartOnDevice.SelectedItem.ToString());
            }
        }

        private void btnAddManually_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtPartName.Text))
            {
                this.lbPartToDisp.Items.Add(this.txtPartName.Text);
                this.txtPartName.Text = string.Empty;
                this.txtPartName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.lbPartToDisp.Items.Clear();
            this.lbPartOnDevice.Items.Clear();
        }

        private void btnReadDevice_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__17));
        }

        private void btnReadPIT_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__15));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.lbPartToDisp.SelectedIndex != -1)
            {
                this.lbPartToDisp.Items.RemoveAt(this.lbPartToDisp.SelectedIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            string partToDisp = string.Empty;
            if (!Directory.Exists(this.AppPath + @"\DF"))
            {
                Directory.CreateDirectory(this.AppPath + @"\DF");
            }
            if (string.IsNullOrEmpty(this.txtFileName.Text))
            {
                Interaction.MsgBox("Please enter a valid file name!", MsgBoxStyle.Exclamation, null);
            }
            else if (string.IsNullOrEmpty(this.txtDisplayName.Text))
            {
                Interaction.MsgBox("Please enter a valid display name!", MsgBoxStyle.Exclamation, null);
            }
            else if (string.IsNullOrEmpty(this.txtDescription.Text))
            {
                Interaction.MsgBox("Please enter a brief description of the Device Filter!", MsgBoxStyle.Exclamation, null);
            }
            else
            {
                if (this.txtFileName.Text.ToLower().EndsWith(".bin"))
                {
                    text = this.txtFileName.Text;
                }
                else
                {
                    text = this.txtFileName.Text + ".bin";
                }
                int num2 = this.lbPartToDisp.Items.Count - 1;
                for (int i = 0; i <= num2; i++)
                {
                    partToDisp = partToDisp + this.lbPartToDisp.Items[i].ToString() + "|";
                }
                partToDisp = partToDisp.TrimEnd(new char[] { '|' });
                DeviceFilterClass devFilter = new DeviceFilterClass(this.AppPath + @"\DF\" + text, this.txtDisplayName.Text, partToDisp, this.txtDescription.Text);
                try
                {
                    if (DeviceFilterClass.WriteBIN(devFilter, this.AppPath + @"\DF\" + text))
                    {
                        Interaction.MsgBox("Device Filter was written successfully!", MsgBoxStyle.Information, null);
                        this.Close();
                    }
                    else
                    {
                        Interaction.MsgBox("An error occurred while writing the file.", MsgBoxStyle.Critical, null);
                        this.Close();
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void CheckConnection()
        {
            if (!this._androidInstance.HasConnectedDevices && Conversions.ToBoolean(Operators.NotObject(this.Invoke(new VB$AnonymousDelegate_0<bool>(this._Lambda$__1)))))
            {
                this.Invoke(new VB$AnonymousDelegate_1(DeviceFilterEditor._Lambda$__2));
            }
        }

        private void DeviceFilterEditor_Load(object sender, EventArgs e)
        {
            if (!this._samsungMode)
            {
                this.btnReadPIT.Enabled = false;
            }
        }

        private void DisableControls()
        {
            this.pDevFilterEditMain.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void DisableControls_MultiThread()
        {
            DisableControls_Delegate method = new DisableControls_Delegate(this.DisableControls);
            this.Invoke(method);
        }

        [DebuggerNonUserCode]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (this.components != null))
                {
                    this.components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void EnableControls()
        {
            this.pDevFilterEditMain.Enabled = true;
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
        }

        private void EnableControls_MultiThread()
        {
            EnableControls_Delegate method = new EnableControls_Delegate(this.EnableControls);
            this.Invoke(method);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(DeviceFilterEditor));
            this.pDevFilterEditMain = new Panel();
            this.lblPartName = new Label();
            this.btnAddManually = new Button();
            this.txtPartName = new TextBox();
            this.btnReadDevice = new Button();
            this.btnReadPIT = new Button();
            this.btnClearAll = new Button();
            this.btnRemove = new Button();
            this.btnAdd = new Button();
            this.lbPartOnDevice = new ListBox();
            this.lblPartOnDevice = new Label();
            this.txtFileName = new TextBox();
            this.lbPartToDisp = new ListBox();
            this.txtDescription = new TextBox();
            this.lblPartToDispInfo = new Label();
            this.lblDescription = new Label();
            this.lblPartToDisp = new Label();
            this.txtDisplayName = new TextBox();
            this.lblDisplayName = new Label();
            this.lblFileName = new Label();
            this.lblQueryDevice = new Label();
            this.btnCancel = new Button();
            this.btnSave = new Button();
            this.pDevFilterEditMain.SuspendLayout();
            this.SuspendLayout();
            this.pDevFilterEditMain.BorderStyle = BorderStyle.FixedSingle;
            this.pDevFilterEditMain.Controls.Add(this.lblPartName);
            this.pDevFilterEditMain.Controls.Add(this.btnAddManually);
            this.pDevFilterEditMain.Controls.Add(this.txtPartName);
            this.pDevFilterEditMain.Controls.Add(this.btnReadDevice);
            this.pDevFilterEditMain.Controls.Add(this.btnReadPIT);
            this.pDevFilterEditMain.Controls.Add(this.btnClearAll);
            this.pDevFilterEditMain.Controls.Add(this.btnRemove);
            this.pDevFilterEditMain.Controls.Add(this.btnAdd);
            this.pDevFilterEditMain.Controls.Add(this.lbPartOnDevice);
            this.pDevFilterEditMain.Controls.Add(this.lblPartOnDevice);
            this.pDevFilterEditMain.Controls.Add(this.txtFileName);
            this.pDevFilterEditMain.Controls.Add(this.lbPartToDisp);
            this.pDevFilterEditMain.Controls.Add(this.txtDescription);
            this.pDevFilterEditMain.Controls.Add(this.lblPartToDispInfo);
            this.pDevFilterEditMain.Controls.Add(this.lblDescription);
            this.pDevFilterEditMain.Controls.Add(this.lblPartToDisp);
            this.pDevFilterEditMain.Controls.Add(this.txtDisplayName);
            this.pDevFilterEditMain.Controls.Add(this.lblDisplayName);
            this.pDevFilterEditMain.Controls.Add(this.lblFileName);
            Point point2 = new Point(12, 11);
            this.pDevFilterEditMain.Location = point2;
            this.pDevFilterEditMain.Name = "pDevFilterEditMain";
            Size size2 = new Size(510, 0x152);
            this.pDevFilterEditMain.Size = size2;
            this.pDevFilterEditMain.TabIndex = 0x20;
            this.lblPartName.AutoSize = true;
            point2 = new Point(0xbf, 0x36);
            this.lblPartName.Location = point2;
            this.lblPartName.Name = "lblPartName";
            size2 = new Size(0x4f, 13);
            this.lblPartName.Size = size2;
            this.lblPartName.TabIndex = 0x2d;
            this.lblPartName.Text = "Partition Name:";
            point2 = new Point(0xc2, 0x5f);
            this.btnAddManually.Location = point2;
            this.btnAddManually.Name = "btnAddManually";
            size2 = new Size(0x79, 0x17);
            this.btnAddManually.Size = size2;
            this.btnAddManually.TabIndex = 0x2c;
            this.btnAddManually.Text = "Add Manually";
            this.btnAddManually.UseVisualStyleBackColor = true;
            this.txtPartName.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0xc2, 70);
            this.txtPartName.Location = point2;
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.ShortcutsEnabled = false;
            size2 = new Size(0x79, 0x13);
            this.txtPartName.Size = size2;
            this.txtPartName.TabIndex = 0x2b;
            point2 = new Point(0x19c, 0xd4);
            this.btnReadDevice.Location = point2;
            this.btnReadDevice.Name = "btnReadDevice";
            size2 = new Size(0x55, 0x17);
            this.btnReadDevice.Size = size2;
            this.btnReadDevice.TabIndex = 0x2a;
            this.btnReadDevice.Text = "Read Device";
            this.btnReadDevice.UseVisualStyleBackColor = true;
            point2 = new Point(0x141, 0xd4);
            this.btnReadPIT.Location = point2;
            this.btnReadPIT.Name = "btnReadPIT";
            size2 = new Size(0x55, 0x17);
            this.btnReadPIT.Size = size2;
            this.btnReadPIT.TabIndex = 0x29;
            this.btnReadPIT.Text = "Read PIT";
            this.btnReadPIT.UseVisualStyleBackColor = true;
            point2 = new Point(0xc2, 0xb6);
            this.btnClearAll.Location = point2;
            this.btnClearAll.Name = "btnClearAll";
            size2 = new Size(0x79, 0x17);
            this.btnClearAll.Size = size2;
            this.btnClearAll.TabIndex = 40;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            point2 = new Point(0xc2, 0x99);
            this.btnRemove.Location = point2;
            this.btnRemove.Name = "btnRemove";
            size2 = new Size(0x79, 0x17);
            this.btnRemove.Size = size2;
            this.btnRemove.TabIndex = 0x27;
            this.btnRemove.Text = "Remove --->";
            this.btnRemove.UseVisualStyleBackColor = true;
            point2 = new Point(0xc2, 0x7c);
            this.btnAdd.Location = point2;
            this.btnAdd.Name = "btnAdd";
            size2 = new Size(0x79, 0x17);
            this.btnAdd.Size = size2;
            this.btnAdd.TabIndex = 0x26;
            this.btnAdd.Text = "<--- Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.lbPartOnDevice.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbPartOnDevice.FormattingEnabled = true;
            this.lbPartOnDevice.ItemHeight = 11;
            point2 = new Point(0x141, 70);
            this.lbPartOnDevice.Location = point2;
            this.lbPartOnDevice.Name = "lbPartOnDevice";
            size2 = new Size(0xb0, 0x88);
            this.lbPartOnDevice.Size = size2;
            this.lbPartOnDevice.TabIndex = 0x25;
            this.lblPartOnDevice.AutoSize = true;
            point2 = new Point(0x13e, 0x36);
            this.lblPartOnDevice.Location = point2;
            this.lblPartOnDevice.Name = "lblPartOnDevice";
            size2 = new Size(0x67, 13);
            this.lblPartOnDevice.Size = size2;
            this.lblPartOnDevice.TabIndex = 0x24;
            this.lblPartOnDevice.Text = "Partitions on device:";
            this.txtFileName.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(70, 0x10);
            this.txtFileName.Location = point2;
            this.txtFileName.Name = "txtFileName";
            size2 = new Size(0x9c, 0x13);
            this.txtFileName.Size = size2;
            this.txtFileName.TabIndex = 0x23;
            this.lbPartToDisp.Font = new Font("Lucida Console", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lbPartToDisp.FormattingEnabled = true;
            this.lbPartToDisp.ItemHeight = 11;
            point2 = new Point(12, 70);
            this.lbPartToDisp.Location = point2;
            this.lbPartToDisp.Name = "lbPartToDisp";
            size2 = new Size(0xb0, 0x88);
            this.lbPartToDisp.Size = size2;
            this.lbPartToDisp.TabIndex = 0x22;
            this.txtDescription.AcceptsReturn = true;
            this.txtDescription.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x10d);
            this.txtDescription.Location = point2;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = ScrollBars.Vertical;
            size2 = new Size(0x1e5, 0x36);
            this.txtDescription.Size = size2;
            this.txtDescription.TabIndex = 0x1d;
            this.lblPartToDispInfo.AutoSize = true;
            point2 = new Point(9, 0xd4);
            this.lblPartToDispInfo.Location = point2;
            this.lblPartToDispInfo.Name = "lblPartToDispInfo";
            size2 = new Size(0xae, 13);
            this.lblPartToDispInfo.Size = size2;
            this.lblPartToDispInfo.TabIndex = 0x21;
            this.lblPartToDispInfo.Text = "Leave blank to display all partitions.";
            this.lblDescription.AutoSize = true;
            point2 = new Point(9, 0xfd);
            this.lblDescription.Location = point2;
            this.lblDescription.Name = "lblDescription";
            size2 = new Size(0x3f, 13);
            this.lblDescription.Size = size2;
            this.lblDescription.TabIndex = 0x20;
            this.lblDescription.Text = "Description:";
            this.lblPartToDisp.AutoSize = true;
            point2 = new Point(9, 0x36);
            this.lblPartToDisp.Location = point2;
            this.lblPartToDisp.Name = "lblPartToDisp";
            size2 = new Size(100, 13);
            this.lblPartToDisp.Size = size2;
            this.lblPartToDisp.TabIndex = 0x1f;
            this.lblPartToDisp.Text = "Partitions to display:";
            this.txtDisplayName.Font = new Font("Lucida Console", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0x155, 0x10);
            this.txtDisplayName.Location = point2;
            this.txtDisplayName.Name = "txtDisplayName";
            size2 = new Size(0x9c, 0x13);
            this.txtDisplayName.Size = size2;
            this.txtDisplayName.TabIndex = 0x1c;
            this.lblDisplayName.AutoSize = true;
            point2 = new Point(0x106, 0x11);
            this.lblDisplayName.Location = point2;
            this.lblDisplayName.Name = "lblDisplayName";
            size2 = new Size(0x4b, 13);
            this.lblDisplayName.Size = size2;
            this.lblDisplayName.TabIndex = 30;
            this.lblDisplayName.Text = "Display Name:";
            this.lblFileName.AutoSize = true;
            point2 = new Point(9, 0x11);
            this.lblFileName.Location = point2;
            this.lblFileName.Name = "lblFileName";
            size2 = new Size(0x39, 13);
            this.lblFileName.Size = size2;
            this.lblFileName.TabIndex = 0x1b;
            this.lblFileName.Text = "File Name:";
            this.lblQueryDevice.AutoSize = true;
            this.lblQueryDevice.Font = new Font("Lucida Console", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblQueryDevice.ForeColor = Color.Red;
            point2 = new Point(12, 0x16d);
            this.lblQueryDevice.Location = point2;
            this.lblQueryDevice.Name = "lblQueryDevice";
            size2 = new Size(0x11e, 13);
            this.lblQueryDevice.Size = size2;
            this.lblQueryDevice.TabIndex = 0x1f;
            this.lblQueryDevice.Text = "Querying device, please wait...";
            this.lblQueryDevice.Visible = false;
            this.btnCancel.DialogResult = DialogResult.Cancel;
            point2 = new Point(0x1c0, 0x167);
            this.btnCancel.Location = point2;
            this.btnCancel.Name = "btnCancel";
            size2 = new Size(0x4b, 0x17);
            this.btnCancel.Size = size2;
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            point2 = new Point(0x16f, 0x167);
            this.btnSave.Location = point2;
            this.btnSave.Name = "btnSave";
            size2 = new Size(0x4b, 0x17);
            this.btnSave.Size = size2;
            this.btnSave.TabIndex = 0x1d;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            size2 = new Size(0x216, 0x189);
            this.ClientSize = size2;
            this.ControlBox = false;
            this.Controls.Add(this.pDevFilterEditMain);
            this.Controls.Add(this.lblQueryDevice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.Name = "DeviceFilterEditor";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Device Filter Editor";
            this.pDevFilterEditMain.ResumeLayout(false);
            this.pDevFilterEditMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void lbPartOnDevice_DoubleClick(object sender, EventArgs e)
        {
            if (this.lbPartOnDevice.SelectedIndex != -1)
            {
                this.lbPartToDisp.Items.Add(this.lbPartOnDevice.SelectedItem.ToString());
            }
        }

        private void lbPartToDisp_DoubleClick(object sender, EventArgs e)
        {
            if (this.lbPartToDisp.SelectedIndex != -1)
            {
                this.lbPartToDisp.Items.RemoveAt(this.lbPartToDisp.SelectedIndex);
            }
        }

        private void LoadFile(string fileName)
        {
            DeviceFilterClass devFilter = null;
            string[] strArray = new string[0];
            if (DeviceFilterClass.ReadBIN(fileName, ref devFilter))
            {
                this.txtDisplayName.Text = devFilter.DisplayName;
                this.lbPartToDisp.Items.Clear();
                foreach (string str in Strings.Split(devFilter.PartitionsToDisplay, "|", -1, CompareMethod.Binary))
                {
                    if (!string.IsNullOrEmpty(str))
                    {
                        this.lbPartToDisp.Items.Add(str);
                    }
                }
                this.txtDescription.Text = devFilter.Description;
            }
            else
            {
                Interaction.MsgBox("Unable to read Device Filter!", MsgBoxStyle.Critical, null);
                this.Close();
            }
        }

        private void ReadFromDevice(bool samsungMode)
        {
            try
            {
                List<PartitionInfo> samsungPartitions;
                this.DisableControls_MultiThread();
                this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__10));
                this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__11));
                this.CheckConnection();
                string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
                string pitFile = this.AppPath + @"\PIT\" + str + ".pit";
                if (samsungMode)
                {
                    samsungPartitions = EFS_Professional.WinADBHelper.FileSystem.GetSamsungPartitions(pitFile);
                }
                else
                {
                    samsungPartitions = EFS_Professional.WinADBHelper.FileSystem.GetPartitions();
                }
                using (List<PartitionInfo>.Enumerator enumerator = samsungPartitions.GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        _Closure$__4 e$__;
                        e$__ = new _Closure$__4(e$__) {
                            $VB$Local_partItem = enumerator.Current,
                            $VB$Me = this
                        };
                        if (e$__.$VB$Local_partItem.ToString() != "-1")
                        {
                            this.Invoke(new VB$AnonymousDelegate_1(e$__._Lambda$__12));
                        }
                        else
                        {
                            this.Invoke(new VB$AnonymousDelegate_1(DeviceFilterEditor._Lambda$__13));
                        }
                    }
                }
                this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__14));
                this.EnableControls_MultiThread();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error!");
                this.EnableControls_MultiThread();
                ProjectData.ClearProjectError();
            }
        }

        private void ReadFromPIT()
        {
            this.DisableControls_MultiThread();
            this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__3));
            this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__4));
            string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
            string path = this.AppPath + @"\PIT\" + str + ".pit";
            try
            {
                PitData data;
                if (File.Exists(path))
                {
                    data = EFS_Professional.WinADBHelper.FileSystem.ParsePIT(path);
                    if (data != null)
                    {
                        PitEntry[] entries = data.Entries;
                        for (int i = 0; i < entries.Length; i++)
                        {
                            _Closure$__1 e$__;
                            e$__ = new _Closure$__1(e$__) {
                                $VB$Local_entry = entries[i],
                                $VB$Me = this
                            };
                            this.Invoke(new VB$AnonymousDelegate_1(e$__._Lambda$__5));
                        }
                    }
                }
                else
                {
                    this.CheckConnection();
                    if (!Directory.Exists(this.AppPath + @"\PIT"))
                    {
                        Directory.CreateDirectory(this.AppPath + @"\PIT");
                    }
                    if (EFS_Professional.WinADBHelper.FileSystem.GetDevicePIT(this.AppPath + @"\PIT", ref path, this._devStorageLoc, this._pitBufferSize))
                    {
                        data = EFS_Professional.WinADBHelper.FileSystem.ParsePIT(this.AppPath + @"\PIT\" + path.Insert(0, this.AppPath + @"\PIT\"));
                        if (data != null)
                        {
                            PitEntry[] entryArray2 = data.Entries;
                            for (int j = 0; j < entryArray2.Length; j++)
                            {
                                _Closure$__2 e$__2;
                                e$__2 = new _Closure$__2(e$__2) {
                                    $VB$Local_entry = entryArray2[j],
                                    $VB$Me = this
                                };
                                this.Invoke(new VB$AnonymousDelegate_1(e$__2._Lambda$__6));
                            }
                        }
                    }
                    else
                    {
                        this.Invoke(new VB$AnonymousDelegate_1(DeviceFilterEditor._Lambda$__7));
                    }
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                _Closure$__3 e$__3 = new _Closure$__3 {
                    $VB$Local_ex = exception
                };
                this.Invoke(new VB$AnonymousDelegate_1(e$__3._Lambda$__8));
                ProjectData.ClearProjectError();
            }
            this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__9));
            this.EnableControls_MultiThread();
        }

        private void txtPartName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Conversions.ToString(e.KeyChar) == "|")
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '\r') && !string.IsNullOrEmpty(this.txtPartName.Text))
            {
                this.lbPartToDisp.Items.Add(this.txtPartName.Text);
                this.txtPartName.Text = string.Empty;
                this.txtPartName.Focus();
            }
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPartName.Text.Contains("|"))
            {
                this.txtPartName.Text.Replace("|", string.Empty);
            }
        }

        internal virtual Button btnAdd
        {
            get => 
                this._btnAdd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnAdd_Click);
                if (this._btnAdd != null)
                {
                    this._btnAdd.Click -= handler;
                }
                this._btnAdd = value;
                if (this._btnAdd != null)
                {
                    this._btnAdd.Click += handler;
                }
            }
        }

        internal virtual Button btnAddManually
        {
            get => 
                this._btnAddManually;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnAddManually_Click);
                if (this._btnAddManually != null)
                {
                    this._btnAddManually.Click -= handler;
                }
                this._btnAddManually = value;
                if (this._btnAddManually != null)
                {
                    this._btnAddManually.Click += handler;
                }
            }
        }

        internal virtual Button btnCancel
        {
            get => 
                this._btnCancel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnCancel_Click);
                if (this._btnCancel != null)
                {
                    this._btnCancel.Click -= handler;
                }
                this._btnCancel = value;
                if (this._btnCancel != null)
                {
                    this._btnCancel.Click += handler;
                }
            }
        }

        internal virtual Button btnClearAll
        {
            get => 
                this._btnClearAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnClearAll_Click);
                if (this._btnClearAll != null)
                {
                    this._btnClearAll.Click -= handler;
                }
                this._btnClearAll = value;
                if (this._btnClearAll != null)
                {
                    this._btnClearAll.Click += handler;
                }
            }
        }

        internal virtual Button btnReadDevice
        {
            get => 
                this._btnReadDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnReadDevice_Click);
                if (this._btnReadDevice != null)
                {
                    this._btnReadDevice.Click -= handler;
                }
                this._btnReadDevice = value;
                if (this._btnReadDevice != null)
                {
                    this._btnReadDevice.Click += handler;
                }
            }
        }

        internal virtual Button btnReadPIT
        {
            get => 
                this._btnReadPIT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnReadPIT_Click);
                if (this._btnReadPIT != null)
                {
                    this._btnReadPIT.Click -= handler;
                }
                this._btnReadPIT = value;
                if (this._btnReadPIT != null)
                {
                    this._btnReadPIT.Click += handler;
                }
            }
        }

        internal virtual Button btnRemove
        {
            get => 
                this._btnRemove;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRemove_Click);
                if (this._btnRemove != null)
                {
                    this._btnRemove.Click -= handler;
                }
                this._btnRemove = value;
                if (this._btnRemove != null)
                {
                    this._btnRemove.Click += handler;
                }
            }
        }

        internal virtual Button btnSave
        {
            get => 
                this._btnSave;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSave_Click);
                if (this._btnSave != null)
                {
                    this._btnSave.Click -= handler;
                }
                this._btnSave = value;
                if (this._btnSave != null)
                {
                    this._btnSave.Click += handler;
                }
            }
        }

        internal virtual Label lblDescription
        {
            get => 
                this._lblDescription;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDescription = value;
            }
        }

        internal virtual Label lblDisplayName
        {
            get => 
                this._lblDisplayName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDisplayName = value;
            }
        }

        internal virtual Label lblFileName
        {
            get => 
                this._lblFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFileName = value;
            }
        }

        internal virtual Label lblPartName
        {
            get => 
                this._lblPartName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPartName = value;
            }
        }

        internal virtual Label lblPartOnDevice
        {
            get => 
                this._lblPartOnDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPartOnDevice = value;
            }
        }

        internal virtual Label lblPartToDisp
        {
            get => 
                this._lblPartToDisp;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPartToDisp = value;
            }
        }

        internal virtual Label lblPartToDispInfo
        {
            get => 
                this._lblPartToDispInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPartToDispInfo = value;
            }
        }

        internal virtual Label lblQueryDevice
        {
            get => 
                this._lblQueryDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblQueryDevice = value;
            }
        }

        internal virtual ListBox lbPartOnDevice
        {
            get => 
                this._lbPartOnDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.lbPartOnDevice_DoubleClick);
                if (this._lbPartOnDevice != null)
                {
                    this._lbPartOnDevice.DoubleClick -= handler;
                }
                this._lbPartOnDevice = value;
                if (this._lbPartOnDevice != null)
                {
                    this._lbPartOnDevice.DoubleClick += handler;
                }
            }
        }

        internal virtual ListBox lbPartToDisp
        {
            get => 
                this._lbPartToDisp;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.lbPartToDisp_DoubleClick);
                if (this._lbPartToDisp != null)
                {
                    this._lbPartToDisp.DoubleClick -= handler;
                }
                this._lbPartToDisp = value;
                if (this._lbPartToDisp != null)
                {
                    this._lbPartToDisp.DoubleClick += handler;
                }
            }
        }

        internal virtual Panel pDevFilterEditMain
        {
            get => 
                this._pDevFilterEditMain;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pDevFilterEditMain = value;
            }
        }

        internal virtual TextBox txtDescription
        {
            get => 
                this._txtDescription;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtDescription = value;
            }
        }

        internal virtual TextBox txtDisplayName
        {
            get => 
                this._txtDisplayName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtDisplayName = value;
            }
        }

        internal virtual TextBox txtFileName
        {
            get => 
                this._txtFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtFileName = value;
            }
        }

        internal virtual TextBox txtPartName
        {
            get => 
                this._txtPartName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtPartName_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtPartName_KeyPress);
                if (this._txtPartName != null)
                {
                    this._txtPartName.TextChanged -= handler;
                    this._txtPartName.KeyPress -= handler2;
                }
                this._txtPartName = value;
                if (this._txtPartName != null)
                {
                    this._txtPartName.TextChanged += handler;
                    this._txtPartName.KeyPress += handler2;
                }
            }
        }

        [CompilerGenerated]
        internal class _Closure$__1
        {
            public PitEntry $VB$Local_entry;
            public DeviceFilterEditor $VB$Me;

            public _Closure$__1(DeviceFilterEditor._Closure$__1 other)
            {
                if (other != null)
                {
                    this.$VB$Me = other.$VB$Me;
                    this.$VB$Local_entry = other.$VB$Local_entry;
                }
            }

            [CompilerGenerated]
            public void _Lambda$__5()
            {
                this.$VB$Me.lbPartOnDevice.Items.Add(this.$VB$Local_entry.PartitionName);
            }
        }

        [CompilerGenerated]
        internal class _Closure$__2
        {
            public PitEntry $VB$Local_entry;
            public DeviceFilterEditor $VB$Me;

            public _Closure$__2(DeviceFilterEditor._Closure$__2 other)
            {
                if (other != null)
                {
                    this.$VB$Local_entry = other.$VB$Local_entry;
                    this.$VB$Me = other.$VB$Me;
                }
            }

            [CompilerGenerated]
            public void _Lambda$__6()
            {
                this.$VB$Me.lbPartOnDevice.Items.Add(this.$VB$Local_entry.PartitionName);
            }
        }

        [CompilerGenerated]
        internal class _Closure$__3
        {
            public Exception $VB$Local_ex;

            [CompilerGenerated]
            public void _Lambda$__8()
            {
                Interaction.MsgBox(this.$VB$Local_ex.Message, MsgBoxStyle.Critical, null);
            }
        }

        [CompilerGenerated]
        internal class _Closure$__4
        {
            public PartitionInfo $VB$Local_partItem;
            public DeviceFilterEditor $VB$Me;

            public _Closure$__4(DeviceFilterEditor._Closure$__4 other)
            {
                if (other != null)
                {
                    this.$VB$Local_partItem = other.$VB$Local_partItem;
                    this.$VB$Me = other.$VB$Me;
                }
            }

            [CompilerGenerated]
            public void _Lambda$__12()
            {
                this.$VB$Me.lbPartOnDevice.Items.Add(this.$VB$Local_partItem.PartitionName);
            }
        }

        public delegate void DisableControls_Delegate();

        public delegate void EnableControls_Delegate();
    }
}


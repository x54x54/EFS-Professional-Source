namespace EFS_Professional
{
    using EFS_Professional.WinADBHelper;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class frmWaitDeviceDialog : Form
    {
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        private string _deviceSerial;
        [AccessedThroughProperty("gbMessage")]
        private GroupBox _gbMessage;
        [AccessedThroughProperty("lblConnStatus")]
        private Label _lblConnStatus;
        [AccessedThroughProperty("lblMessage")]
        private Label _lblMessage;
        [AccessedThroughProperty("lblStatus")]
        private Label _lblStatus;
        [AccessedThroughProperty("pbAndroid")]
        private PictureBox _pbAndroid;
        private Thread _waitThread;
        private IContainer components;
        public Size DialogDefaultSize;
        public Size MessageDefaultSize;
        private AndroidControl myAndroid;
        private DeviceIO myDevice;
        private int timeOut;

        public void $VB$ClosureStub_Close_MyBase()
        {
            base.Close();
        }

        public void $VB$ClosureStub_set_DialogResult_MyBase(DialogResult p0)
        {
            base.DialogResult = p0;
        }

        public frmWaitDeviceDialog()
        {
            base.Load += new EventHandler(this.WaitDeviceDialog_Load);
            this.timeOut = 500;
            this._waitThread = new Thread(new ThreadStart(this.WaitThread));
            this.DialogDefaultSize = new Size(0x185, 0x7b);
            this.MessageDefaultSize = new Size(0x167, 0x29);
            this.InitializeComponent();
            this.gbMessage.Size = this.MessageDefaultSize;
            this.Size = this.DialogDefaultSize;
            this._deviceSerial = null;
        }

        public frmWaitDeviceDialog(string deviceSerial, string message = null, bool cancelBtn = true)
        {
            base.Load += new EventHandler(this.WaitDeviceDialog_Load);
            this.timeOut = 500;
            this._waitThread = new Thread(new ThreadStart(this.WaitThread));
            this.DialogDefaultSize = new Size(0x185, 0x7b);
            this.MessageDefaultSize = new Size(0x167, 0x29);
            this.InitializeComponent();
            this.lblMessage.Text = message;
            if (!string.IsNullOrEmpty(this.lblMessage.Text))
            {
                this.gbMessage.Height = (this.MessageDefaultSize.Height + this.lblMessage.Height) - 14;
                this.Height = (this.DialogDefaultSize.Height + this.lblMessage.Height) + 0x2b;
            }
            else
            {
                this.Size = this.DialogDefaultSize;
            }
            this._deviceSerial = deviceSerial;
            this.Cancel_Button.Enabled = cancelBtn;
        }

        [CompilerGenerated]
        private void _Lambda$__85()
        {
            Interaction.MsgBox("Connected device is currently " + this.myAndroid.GetConnectedDevice().GetState.ToString() + ".\r\n\r\nPlease ensure the ADB server has been authorised by the connected device by confirming your PC's RSA Fingerprint then press 'OK' to continue.", MsgBoxStyle.Information, null);
        }

        [CompilerGenerated]
        private void _Lambda$__86()
        {
            this.lblConnStatus.ForeColor = Color.Red;
            this.lblConnStatus.Text = "Device Not Connected!";
        }

        [CompilerGenerated]
        private void _Lambda$__87()
        {
            this.lblConnStatus.ForeColor = Color.Green;
            this.lblConnStatus.Text = "Device Connected!";
        }

        [CompilerGenerated]
        private void _Lambda$__88()
        {
            if (this._waitThread.IsAlive)
            {
                try
                {
                    this._waitThread.Abort();
                }
                catch (ThreadAbortException exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    ThreadAbortException exception = exception1;
                    Thread.ResetAbort();
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    this._waitThread = null;
                }
            }
            this.$VB$ClosureStub_set_DialogResult_MyBase(DialogResult.OK);
            this.$VB$ClosureStub_Close_MyBase();
        }

        [CompilerGenerated]
        private void _Lambda$__89()
        {
            this.lblConnStatus.ForeColor = Color.Green;
            this.lblConnStatus.Text = "Device Connected!";
        }

        [CompilerGenerated]
        private void _Lambda$__90()
        {
            if (this._waitThread.IsAlive)
            {
                try
                {
                    this._waitThread.Abort();
                }
                catch (ThreadAbortException exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    ThreadAbortException exception = exception1;
                    Thread.ResetAbort();
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    this._waitThread = null;
                }
            }
            this.$VB$ClosureStub_set_DialogResult_MyBase(DialogResult.OK);
            this.$VB$ClosureStub_Close_MyBase();
        }

        [CompilerGenerated]
        private void _Lambda$__91()
        {
            this.lblConnStatus.ForeColor = Color.Orange;
            this.lblConnStatus.Text = "Wrong Device Connected!";
        }

        [CompilerGenerated]
        private void _Lambda$__92()
        {
            if (this._waitThread.IsAlive)
            {
                try
                {
                    this._waitThread.Abort();
                }
                catch (ThreadAbortException exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    ThreadAbortException exception = exception1;
                    Thread.ResetAbort();
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    this._waitThread = null;
                }
            }
            this.$VB$ClosureStub_set_DialogResult_MyBase(DialogResult.Cancel);
            this.$VB$ClosureStub_Close_MyBase();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            if (this._waitThread.IsAlive)
            {
                try
                {
                    this._waitThread.Abort();
                }
                catch (ThreadAbortException exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    ThreadAbortException exception = exception1;
                    Thread.ResetAbort();
                    ProjectData.ClearProjectError();
                }
                finally
                {
                    this._waitThread = null;
                }
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CheckADBAuthorisation(AndroidControl instance)
        {
            if (this.myAndroid.HasConnectedDevices)
            {
                while ((this.myAndroid.GetConnectedDevice().GetState != DeviceIO.DeviceState.ONLINE) | (this.myAndroid.GetConnectedDevice().GetState == DeviceIO.DeviceState.RECOVERY))
                {
                    this.Invoke(new Action(this._Lambda$__85));
                }
            }
        }

        private void CheckForDevice()
        {
            Thread.Sleep(this.timeOut);
            if (!this.myAndroid.HasConnectedDevices)
            {
                this.Invoke(new Action(this._Lambda$__86));
                this.myAndroid.RefreshDevices();
            }
            else if (this._deviceSerial == null)
            {
                this.CheckADBAuthorisation(this.myAndroid);
                this.myDevice = this.myAndroid.GetConnectedDevice(this.myAndroid.ConnectedDevices[0]);
                this.Invoke(new Action(this._Lambda$__87));
                Thread.Sleep(this.timeOut);
                this.Invoke(new Action(this._Lambda$__88));
            }
            else
            {
                this.CheckADBAuthorisation(this.myAndroid);
                this.myDevice = this.myAndroid.GetConnectedDevice(this.myAndroid.ConnectedDevices[0]);
                if (this.myDevice.SerialNumber == this._deviceSerial)
                {
                    this.Invoke(new Action(this._Lambda$__89));
                    Thread.Sleep(this.timeOut);
                    this.Invoke(new Action(this._Lambda$__90));
                }
                else
                {
                    this.Invoke(new Action(this._Lambda$__91));
                    Thread.Sleep(this.timeOut);
                    this.Invoke(new Action(this._Lambda$__92));
                }
            }
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

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmWaitDeviceDialog));
            this.Cancel_Button = new Button();
            this.lblStatus = new Label();
            this.pbAndroid = new PictureBox();
            this.lblConnStatus = new Label();
            this.lblMessage = new Label();
            this.gbMessage = new GroupBox();
            ((ISupportInitialize) this.pbAndroid).BeginInit();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            this.Cancel_Button.DialogResult = DialogResult.Cancel;
            Point point2 = new Point(0x130, 0x3d);
            this.Cancel_Button.Location = point2;
            this.Cancel_Button.Name = "Cancel_Button";
            Size size2 = new Size(0x43, 0x17);
            this.Cancel_Button.Size = size2;
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseWaitCursor = true;
            this.lblStatus.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(90, 12);
            this.lblStatus.Location = point2;
            this.lblStatus.Name = "lblStatus";
            size2 = new Size(0x119, 0x26);
            this.lblStatus.Size = size2;
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Please wait while your device connects with the ADB Server...";
            this.lblStatus.UseWaitCursor = true;
            this.pbAndroid.Image = (Image) manager.GetObject("pbAndroid.Image");
            point2 = new Point(12, 12);
            this.pbAndroid.Location = point2;
            this.pbAndroid.Name = "pbAndroid";
            size2 = new Size(0x48, 0x48);
            this.pbAndroid.Size = size2;
            this.pbAndroid.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pbAndroid.TabIndex = 3;
            this.pbAndroid.TabStop = false;
            this.pbAndroid.UseWaitCursor = true;
            this.lblConnStatus.BorderStyle = BorderStyle.Fixed3D;
            this.lblConnStatus.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblConnStatus.ForeColor = Color.Red;
            point2 = new Point(0x5d, 0x3f);
            this.lblConnStatus.Location = point2;
            this.lblConnStatus.Name = "lblConnStatus";
            size2 = new Size(0xc4, 0x13);
            this.lblConnStatus.Size = size2;
            this.lblConnStatus.TabIndex = 4;
            this.lblConnStatus.Text = "Device Not Connected!";
            this.lblConnStatus.TextAlign = ContentAlignment.MiddleCenter;
            this.lblConnStatus.UseWaitCursor = true;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblMessage.ForeColor = Color.Blue;
            point2 = new Point(6, 0x10);
            this.lblMessage.Location = point2;
            size2 = new Size(200, 0);
            this.lblMessage.MaximumSize = size2;
            size2 = new Size(0x15b, 0);
            this.lblMessage.MinimumSize = size2;
            this.lblMessage.Name = "lblMessage";
            size2 = new Size(0x15b, 15);
            this.lblMessage.Size = size2;
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = ContentAlignment.MiddleLeft;
            this.lblMessage.UseWaitCursor = true;
            this.gbMessage.Controls.Add(this.lblMessage);
            this.gbMessage.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x63);
            this.gbMessage.Location = point2;
            this.gbMessage.Name = "gbMessage";
            size2 = new Size(0x167, 0x29);
            this.gbMessage.Size = size2;
            this.gbMessage.TabIndex = 6;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message:";
            this.gbMessage.UseWaitCursor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            size2 = new Size(0x17f, 0x99);
            this.ClientSize = size2;
            this.ControlBox = false;
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.pbAndroid);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.Cancel_Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitDeviceDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Waiting For Device...";
            this.UseWaitCursor = true;
            ((ISupportInitialize) this.pbAndroid).EndInit();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void WaitDeviceDialog_Load(object sender, EventArgs e)
        {
            this.myAndroid = AndroidControl.Init;
            this.myAndroid.RefreshDevices();
            this._waitThread.Start();
        }

        private void WaitThread()
        {
            while (!this.myAndroid.HasConnectedDevices)
            {
                this.CheckForDevice();
            }
            this.CheckForDevice();
        }

        internal virtual Button Cancel_Button
        {
            get => 
                this._Cancel_Button;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.Cancel_Button_Click);
                if (this._Cancel_Button != null)
                {
                    this._Cancel_Button.Click -= handler;
                }
                this._Cancel_Button = value;
                if (this._Cancel_Button != null)
                {
                    this._Cancel_Button.Click += handler;
                }
            }
        }

        public DeviceIO Device =>
            this.myDevice;

        public bool EnableCancel
        {
            get => 
                this.Cancel_Button.Enabled;
            set
            {
                this.Cancel_Button.Enabled = value;
            }
        }

        internal virtual GroupBox gbMessage
        {
            get => 
                this._gbMessage;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbMessage = value;
            }
        }

        internal virtual Label lblConnStatus
        {
            get => 
                this._lblConnStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblConnStatus = value;
            }
        }

        internal virtual Label lblMessage
        {
            get => 
                this._lblMessage;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMessage = value;
            }
        }

        internal virtual Label lblStatus
        {
            get => 
                this._lblStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblStatus = value;
            }
        }

        internal virtual PictureBox pbAndroid
        {
            get => 
                this._pbAndroid;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._pbAndroid = value;
            }
        }
    }
}


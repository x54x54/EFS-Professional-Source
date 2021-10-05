namespace EFS_Professional
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class frmWaitDialog : Form
    {
        [AccessedThroughProperty("lblWaitInfo")]
        private Label _lblWaitInfo;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("tmrCountDwn")]
        private Timer _tmrCountDwn;
        private IContainer components;
        private int seconds;

        public frmWaitDialog()
        {
            base.Load += new EventHandler(this.WaitDialog_Load);
            this.seconds = 10;
            this.InitializeComponent();
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
            this.components = new System.ComponentModel.Container();
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.OK_Button = new Button();
            this.lblWaitInfo = new Label();
            this.tmrCountDwn = new Timer(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            Point point2 = new Point(0x8f, 0x45);
            this.TableLayoutPanel1.Location = point2;
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            Size size2 = new Size(0x62, 0x1d);
            this.TableLayoutPanel1.Size = size2;
            this.TableLayoutPanel1.TabIndex = 0;
            this.OK_Button.Anchor = AnchorStyles.None;
            this.OK_Button.Enabled = false;
            point2 = new Point(15, 3);
            this.OK_Button.Location = point2;
            this.OK_Button.Name = "OK_Button";
            size2 = new Size(0x43, 0x17);
            this.OK_Button.Size = size2;
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.lblWaitInfo.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(12, 9);
            this.lblWaitInfo.Location = point2;
            this.lblWaitInfo.Name = "lblWaitInfo";
            size2 = new Size(360, 0x36);
            this.lblWaitInfo.Size = size2;
            this.lblWaitInfo.TabIndex = 1;
            this.lblWaitInfo.Text = "You must wait for at least 10 seconds after sending an invalid SPC before trying to issue further QCDM commands to your device...";
            this.tmrCountDwn.Interval = 0x3e8;
            this.AcceptButton = this.OK_Button;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x180, 110);
            this.ClientSize = size2;
            this.ControlBox = false;
            this.Controls.Add(this.lblWaitInfo);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaitDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Please Wait...";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tmrCountDwn_Tick(object sender, EventArgs e)
        {
            if (this.seconds == 1)
            {
                this.tmrCountDwn.Enabled = false;
                this.OK_Button.Text = "OK";
                this.OK_Button.Enabled = true;
            }
            else
            {
                this.seconds--;
                this.OK_Button.Text = Conversions.ToString(this.seconds);
            }
        }

        private void WaitDialog_Load(object sender, EventArgs e)
        {
            this.OK_Button.Text = Conversions.ToString(this.seconds);
            this.tmrCountDwn.Enabled = true;
        }

        internal virtual Label lblWaitInfo
        {
            get => 
                this._lblWaitInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblWaitInfo = value;
            }
        }

        internal virtual Button OK_Button
        {
            get => 
                this._OK_Button;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.OK_Button_Click);
                if (this._OK_Button != null)
                {
                    this._OK_Button.Click -= handler;
                }
                this._OK_Button = value;
                if (this._OK_Button != null)
                {
                    this._OK_Button.Click += handler;
                }
            }
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            get => 
                this._TableLayoutPanel1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TableLayoutPanel1 = value;
            }
        }

        internal virtual Timer tmrCountDwn
        {
            get => 
                this._tmrCountDwn;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tmrCountDwn_Tick);
                if (this._tmrCountDwn != null)
                {
                    this._tmrCountDwn.Tick -= handler;
                }
                this._tmrCountDwn = value;
                if (this._tmrCountDwn != null)
                {
                    this._tmrCountDwn.Tick += handler;
                }
            }
        }
    }
}


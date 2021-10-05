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
    public class frmChangeLog : Form
    {
        [AccessedThroughProperty("btnChangeLog")]
        private Button _btnChangeLog;
        [AccessedThroughProperty("lblChangeLog")]
        private Label _lblChangeLog;
        [AccessedThroughProperty("txtChangeLog")]
        private TextBox _txtChangeLog;
        private IContainer components;

        public frmChangeLog(string inputText)
        {
            this.InitializeComponent();
            if (!string.IsNullOrEmpty(inputText))
            {
                this.txtChangeLog.Text = inputText;
                this.txtChangeLog.DeselectAll();
            }
            else
            {
                this.Close();
            }
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.lblChangeLog = new Label();
            this.txtChangeLog = new TextBox();
            this.btnChangeLog = new Button();
            this.SuspendLayout();
            this.lblChangeLog.AutoSize = true;
            this.lblChangeLog.Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblChangeLog.ForeColor = Color.Blue;
            Point point2 = new Point(7, 14);
            this.lblChangeLog.Location = point2;
            this.lblChangeLog.Name = "lblChangeLog";
            Size size2 = new Size(0x1e3, 0x19);
            this.lblChangeLog.Size = size2;
            this.lblChangeLog.TabIndex = 2;
            this.lblChangeLog.Text = "EFS Professional - Changes / Improvements:";
            this.txtChangeLog.Font = new Font("Consolas", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x38);
            this.txtChangeLog.Location = point2;
            this.txtChangeLog.Multiline = true;
            this.txtChangeLog.Name = "txtChangeLog";
            this.txtChangeLog.ReadOnly = true;
            this.txtChangeLog.ScrollBars = ScrollBars.Both;
            size2 = new Size(0x31d, 0x162);
            this.txtChangeLog.Size = size2;
            this.txtChangeLog.TabIndex = 1;
            point2 = new Point(0x2de, 0x1a0);
            this.btnChangeLog.Location = point2;
            this.btnChangeLog.Name = "btnChangeLog";
            size2 = new Size(0x4b, 0x17);
            this.btnChangeLog.Size = size2;
            this.btnChangeLog.TabIndex = 0;
            this.btnChangeLog.Text = "Close";
            this.btnChangeLog.UseVisualStyleBackColor = true;
            this.AcceptButton = this.btnChangeLog;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x335, 0x1be);
            this.ClientSize = size2;
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeLog);
            this.Controls.Add(this.txtChangeLog);
            this.Controls.Add(this.lblChangeLog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangeLog";
            this.Opacity = 0.85;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Welcome....";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual Button btnChangeLog
        {
            get => 
                this._btnChangeLog;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnChangeLog_Click);
                if (this._btnChangeLog != null)
                {
                    this._btnChangeLog.Click -= handler;
                }
                this._btnChangeLog = value;
                if (this._btnChangeLog != null)
                {
                    this._btnChangeLog.Click += handler;
                }
            }
        }

        internal virtual Label lblChangeLog
        {
            get => 
                this._lblChangeLog;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblChangeLog = value;
            }
        }

        internal virtual TextBox txtChangeLog
        {
            get => 
                this._txtChangeLog;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtChangeLog = value;
            }
        }
    }
}


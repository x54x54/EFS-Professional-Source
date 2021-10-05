namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Net;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class frmLauncher : Form
    {
        [AccessedThroughProperty("btnEFSPro")]
        private Button _btnEFSPro;
        [AccessedThroughProperty("btnExitToWin")]
        private Button _btnExitToWin;
        [AccessedThroughProperty("btnPITMagic")]
        private Button _btnPITMagic;
        [AccessedThroughProperty("btnQCNVTools")]
        private Button _btnQCNVTools;
        [AccessedThroughProperty("lblLInfoEFSPro")]
        private Label _lblLInfoEFSPro;
        [AccessedThroughProperty("lblLInfoExitToWin")]
        private Label _lblLInfoExitToWin;
        [AccessedThroughProperty("lblLInfoPITMagic")]
        private Label _lblLInfoPITMagic;
        [AccessedThroughProperty("lblLInfoQCNVTools")]
        private Label _lblLInfoQCNVTools;
        [AccessedThroughProperty("ssLaunchMode")]
        private StatusStrip _ssLaunchMode;
        [AccessedThroughProperty("tslAppVerInfo")]
        private ToolStripStatusLabel _tslAppVerInfo;
        [AccessedThroughProperty("tslAppVerNum")]
        private ToolStripStatusLabel _tslAppVerNum;
        [AccessedThroughProperty("tslCopyrightInfo")]
        private ToolStripStatusLabel _tslCopyrightInfo;
        private IContainer components;

        public frmLauncher()
        {
            base.Load += new EventHandler(this.LaunchMode_Load);
            this.InitializeComponent();
        }

        private void btnEFSPro_Click(object sender, EventArgs e)
        {
            this.ShowNotice();
            this.Hide();
            frmEFSProMain main = new frmEFSProMain();
            main.ShowDialog();
            main.Dispose();
            Application.Restart();
        }

        private void btnExitToWin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPITMagic_Click(object sender, EventArgs e)
        {
            this.ShowNotice();
            this.Hide();
            frmPIT_Magic_Main main = new frmPIT_Magic_Main();
            main.ShowDialog();
            main.Dispose();
            Application.Restart();
        }

        private void btnQCNVTools_Click(object sender, EventArgs e)
        {
            this.ShowNotice();
            this.Hide();
            frmQualcommNVTools tools = new frmQualcommNVTools();
            tools.ShowDialog();
            tools.Dispose();
            Application.Restart();
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
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmLauncher));
            this.btnEFSPro = new Button();
            this.btnQCNVTools = new Button();
            this.lblLInfoEFSPro = new Label();
            this.lblLInfoQCNVTools = new Label();
            this.btnExitToWin = new Button();
            this.lblLInfoExitToWin = new Label();
            this.ssLaunchMode = new StatusStrip();
            this.tslAppVerInfo = new ToolStripStatusLabel();
            this.tslAppVerNum = new ToolStripStatusLabel();
            this.tslCopyrightInfo = new ToolStripStatusLabel();
            this.lblLInfoPITMagic = new Label();
            this.btnPITMagic = new Button();
            this.ssLaunchMode.SuspendLayout();
            this.SuspendLayout();
            Point point2 = new Point(12, 12);
            this.btnEFSPro.Location = point2;
            this.btnEFSPro.Name = "btnEFSPro";
            Size size2 = new Size(0x8a, 0x21);
            this.btnEFSPro.Size = size2;
            this.btnEFSPro.TabIndex = 0;
            this.btnEFSPro.Text = "EFS Professional";
            this.btnEFSPro.UseVisualStyleBackColor = true;
            point2 = new Point(12, 0x33);
            this.btnQCNVTools.Location = point2;
            this.btnQCNVTools.Name = "btnQCNVTools";
            size2 = new Size(0x8a, 0x21);
            this.btnQCNVTools.Size = size2;
            this.btnQCNVTools.TabIndex = 1;
            this.btnQCNVTools.Text = "Qualcomm NV Tools";
            this.btnQCNVTools.UseVisualStyleBackColor = true;
            this.lblLInfoEFSPro.AutoSize = true;
            this.lblLInfoEFSPro.ForeColor = SystemColors.ControlText;
            point2 = new Point(0xab, 0x16);
            this.lblLInfoEFSPro.Location = point2;
            this.lblLInfoEFSPro.Name = "lblLInfoEFSPro";
            size2 = new Size(140, 13);
            this.lblLInfoEFSPro.Size = size2;
            this.lblLInfoEFSPro.TabIndex = 2;
            this.lblLInfoEFSPro.Text = "Launches EFS Professional.";
            this.lblLInfoQCNVTools.AutoSize = true;
            this.lblLInfoQCNVTools.ForeColor = SystemColors.ControlText;
            point2 = new Point(0xab, 0x3d);
            this.lblLInfoQCNVTools.Location = point2;
            this.lblLInfoQCNVTools.Name = "lblLInfoQCNVTools";
            size2 = new Size(0x9d, 13);
            this.lblLInfoQCNVTools.Size = size2;
            this.lblLInfoQCNVTools.TabIndex = 3;
            this.lblLInfoQCNVTools.Text = "Launches Qualcomm NV Tools.";
            point2 = new Point(12, 0x81);
            this.btnExitToWin.Location = point2;
            this.btnExitToWin.Name = "btnExitToWin";
            size2 = new Size(0x8a, 0x21);
            this.btnExitToWin.Size = size2;
            this.btnExitToWin.TabIndex = 4;
            this.btnExitToWin.Text = "Exit to Windows";
            this.btnExitToWin.UseVisualStyleBackColor = true;
            this.lblLInfoExitToWin.AutoSize = true;
            this.lblLInfoExitToWin.ForeColor = SystemColors.ControlText;
            point2 = new Point(0xab, 0x8b);
            this.lblLInfoExitToWin.Location = point2;
            this.lblLInfoExitToWin.Name = "lblLInfoExitToWin";
            size2 = new Size(0xdb, 13);
            this.lblLInfoExitToWin.Size = size2;
            this.lblLInfoExitToWin.TabIndex = 5;
            this.lblLInfoExitToWin.Text = "Exits the application and returns to Windows.";
            this.ssLaunchMode.Items.AddRange(new ToolStripItem[] { this.tslAppVerInfo, this.tslAppVerNum, this.tslCopyrightInfo });
            point2 = new Point(0, 0xad);
            this.ssLaunchMode.Location = point2;
            this.ssLaunchMode.Name = "ssLaunchMode";
            size2 = new Size(0x192, 0x16);
            this.ssLaunchMode.Size = size2;
            this.ssLaunchMode.TabIndex = 6;
            this.ssLaunchMode.Text = "StatusStrip1";
            this.tslAppVerInfo.Name = "tslAppVerInfo";
            size2 = new Size(0x71, 0x11);
            this.tslAppVerInfo.Size = size2;
            this.tslAppVerInfo.Text = "Application Version:";
            this.tslAppVerNum.Name = "tslAppVerNum";
            size2 = new Size(0x1f, 0x11);
            this.tslAppVerNum.Size = size2;
            this.tslAppVerNum.Text = "2.0.0";
            this.tslCopyrightInfo.Name = "tslCopyrightInfo";
            size2 = new Size(0x83, 0x11);
            this.tslCopyrightInfo.Size = size2;
            this.tslCopyrightInfo.Text = "Copyright \x00a9 Gaz - 2014";
            this.lblLInfoPITMagic.AutoSize = true;
            this.lblLInfoPITMagic.ForeColor = SystemColors.ControlText;
            point2 = new Point(0xab, 100);
            this.lblLInfoPITMagic.Location = point2;
            this.lblLInfoPITMagic.Name = "lblLInfoPITMagic";
            size2 = new Size(0xb8, 13);
            this.lblLInfoPITMagic.Size = size2;
            this.lblLInfoPITMagic.TabIndex = 8;
            this.lblLInfoPITMagic.Text = "Launches PIT Magic (PIT File Editor).";
            point2 = new Point(12, 90);
            this.btnPITMagic.Location = point2;
            this.btnPITMagic.Name = "btnPITMagic";
            size2 = new Size(0x8a, 0x21);
            this.btnPITMagic.Size = size2;
            this.btnPITMagic.TabIndex = 7;
            this.btnPITMagic.Text = "PIT Magic";
            this.btnPITMagic.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x192, 0xc3);
            this.ClientSize = size2;
            this.Controls.Add(this.lblLInfoPITMagic);
            this.Controls.Add(this.btnPITMagic);
            this.Controls.Add(this.ssLaunchMode);
            this.Controls.Add(this.lblLInfoExitToWin);
            this.Controls.Add(this.btnExitToWin);
            this.Controls.Add(this.lblLInfoQCNVTools);
            this.Controls.Add(this.lblLInfoEFSPro);
            this.Controls.Add(this.btnQCNVTools);
            this.Controls.Add(this.btnEFSPro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLauncher";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "EFS Professional Suite";
            this.ssLaunchMode.ResumeLayout(false);
            this.ssLaunchMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void LaunchMode_Load(object sender, EventArgs e)
        {
            this.tslAppVerNum.Text = VersionInfo.GetAppVersion();
        }

        private bool ShowChangelog()
        {
            bool flag;
            try
            {
                string address = "http://www.homeserver.dyndns-remote.com/public/myapps/efs_professional/release/changelog.txt";
                WebClient client = new WebClient();
                StreamReader reader = new StreamReader(client.OpenRead(address));
                frmChangeLog log = new frmChangeLog(reader.ReadToEnd());
                log.ShowDialog();
                log.Dispose();
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

        private void ShowNotice()
        {
            Interaction.MsgBox("EFS Professional is free for personal use only.\r\n\r\nIf you intend using this application for commercial or other purposes please PM me (lyriquidperfection) in the XDA-Developers forum to discuss licencing options.", MsgBoxStyle.Information, null);
        }

        internal virtual Button btnEFSPro
        {
            get => 
                this._btnEFSPro;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnEFSPro_Click);
                if (this._btnEFSPro != null)
                {
                    this._btnEFSPro.Click -= handler;
                }
                this._btnEFSPro = value;
                if (this._btnEFSPro != null)
                {
                    this._btnEFSPro.Click += handler;
                }
            }
        }

        internal virtual Button btnExitToWin
        {
            get => 
                this._btnExitToWin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnExitToWin_Click);
                if (this._btnExitToWin != null)
                {
                    this._btnExitToWin.Click -= handler;
                }
                this._btnExitToWin = value;
                if (this._btnExitToWin != null)
                {
                    this._btnExitToWin.Click += handler;
                }
            }
        }

        internal virtual Button btnPITMagic
        {
            get => 
                this._btnPITMagic;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnPITMagic_Click);
                if (this._btnPITMagic != null)
                {
                    this._btnPITMagic.Click -= handler;
                }
                this._btnPITMagic = value;
                if (this._btnPITMagic != null)
                {
                    this._btnPITMagic.Click += handler;
                }
            }
        }

        internal virtual Button btnQCNVTools
        {
            get => 
                this._btnQCNVTools;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnQCNVTools_Click);
                if (this._btnQCNVTools != null)
                {
                    this._btnQCNVTools.Click -= handler;
                }
                this._btnQCNVTools = value;
                if (this._btnQCNVTools != null)
                {
                    this._btnQCNVTools.Click += handler;
                }
            }
        }

        internal virtual Label lblLInfoEFSPro
        {
            get => 
                this._lblLInfoEFSPro;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblLInfoEFSPro = value;
            }
        }

        internal virtual Label lblLInfoExitToWin
        {
            get => 
                this._lblLInfoExitToWin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblLInfoExitToWin = value;
            }
        }

        internal virtual Label lblLInfoPITMagic
        {
            get => 
                this._lblLInfoPITMagic;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblLInfoPITMagic = value;
            }
        }

        internal virtual Label lblLInfoQCNVTools
        {
            get => 
                this._lblLInfoQCNVTools;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblLInfoQCNVTools = value;
            }
        }

        internal virtual StatusStrip ssLaunchMode
        {
            get => 
                this._ssLaunchMode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ssLaunchMode = value;
            }
        }

        internal virtual ToolStripStatusLabel tslAppVerInfo
        {
            get => 
                this._tslAppVerInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tslAppVerInfo = value;
            }
        }

        internal virtual ToolStripStatusLabel tslAppVerNum
        {
            get => 
                this._tslAppVerNum;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tslAppVerNum = value;
            }
        }

        internal virtual ToolStripStatusLabel tslCopyrightInfo
        {
            get => 
                this._tslCopyrightInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tslCopyrightInfo = value;
            }
        }
    }
}


namespace EFS_Professional
{
    using EFS_Professional.COMPortManager;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class frmQualcommNVTools : Form
    {
        [AccessedThroughProperty("_myCmdQueue")]
        private CommandQueue __myCmdQueue;
        [AccessedThroughProperty("_myNVMemManager")]
        private NVMemoryManager __myNVMemManager;
        [AccessedThroughProperty("_qcDevInstance")]
        private QualcommDeviceInstance __qcDevInstance;
        [AccessedThroughProperty("btnAddNVI")]
        private Button _btnAddNVI;
        [AccessedThroughProperty("btnBackupNVItems")]
        private Button _btnBackupNVItems;
        [AccessedThroughProperty("btnCancel")]
        private Button _btnCancel;
        [AccessedThroughProperty("btnChangeMode")]
        private Button _btnChangeMode;
        [AccessedThroughProperty("btnClear")]
        private Button _btnClear;
        [AccessedThroughProperty("btnClearNVI")]
        private Button _btnClearNVI;
        [AccessedThroughProperty("btnClearTerm")]
        private Button _btnClearTerm;
        [AccessedThroughProperty("btnConnect")]
        private Button _btnConnect;
        [AccessedThroughProperty("btnDisconnect")]
        private Button _btnDisconnect;
        [AccessedThroughProperty("btnDonate")]
        private Button _btnDonate;
        [AccessedThroughProperty("btnReadEMI")]
        private Button _btnReadEMI;
        [AccessedThroughProperty("btnReadLockCode")]
        private Button _btnReadLockCode;
        [AccessedThroughProperty("btnReadPhoneInfo")]
        private Button _btnReadPhoneInfo;
        [AccessedThroughProperty("btnReadSPC")]
        private Button _btnReadSPC;
        [AccessedThroughProperty("btnRefresh")]
        private Button _btnRefresh;
        [AccessedThroughProperty("btnRefreshNVISkipList")]
        private Button _btnRefreshNVISkipList;
        [AccessedThroughProperty("btnRemoveNVI")]
        private Button _btnRemoveNVI;
        [AccessedThroughProperty("btnRestoreNVItems")]
        private Button _btnRestoreNVItems;
        [AccessedThroughProperty("btnSendAT")]
        private Button _btnSendAT;
        [AccessedThroughProperty("btnSendDiagPasswd")]
        private Button _btnSendDiagPasswd;
        [AccessedThroughProperty("btnSendQCDM")]
        private Button _btnSendQCDM;
        [AccessedThroughProperty("btnSendSPC")]
        private Button _btnSendSPC;
        [AccessedThroughProperty("btnViewNVSkipProfile")]
        private Button _btnViewNVSkipProfile;
        [AccessedThroughProperty("btnWriteEMI")]
        private Button _btnWriteEMI;
        [AccessedThroughProperty("btnWriteLockCode")]
        private Button _btnWriteLockCode;
        [AccessedThroughProperty("btnWriteSPC")]
        private Button _btnWriteSPC;
        [AccessedThroughProperty("cbATCmds")]
        private ComboBox _cbATCmds;
        [AccessedThroughProperty("cbCOMPorts")]
        private ComboBox _cbCOMPorts;
        [AccessedThroughProperty("cbConnMode")]
        private ComboBox _cbConnMode;
        [AccessedThroughProperty("cbCustomNVIList")]
        private ComboBox _cbCustomNVIList;
        [AccessedThroughProperty("cbDiagCmds")]
        private ComboBox _cbDiagCmds;
        [AccessedThroughProperty("cbNVItems")]
        private ComboBox _cbNVItems;
        [AccessedThroughProperty("cbNVItemSkipList")]
        private ComboBox _cbNVItemSkipList;
        [AccessedThroughProperty("cbSource")]
        private ComboBox _cbSource;
        [AccessedThroughProperty("cbTarget")]
        private ComboBox _cbTarget;
        [AccessedThroughProperty("chkCRC7E")]
        private CheckBox _chkCRC7E;
        [AccessedThroughProperty("chkEnableCstNVIRange")]
        private CheckBox _chkEnableCstNVIRange;
        [AccessedThroughProperty("chkEnableNVISkip")]
        private CheckBox _chkEnableNVISkip;
        [AccessedThroughProperty("chkESN")]
        private CheckBox _chkESN;
        [AccessedThroughProperty("chkIMEI")]
        private CheckBox _chkIMEI;
        [AccessedThroughProperty("chkMEID")]
        private CheckBox _chkMEID;
        [AccessedThroughProperty("chkReadPhone")]
        private CheckBox _chkReadPhone;
        [AccessedThroughProperty("chkSendSPC")]
        private CheckBox _chkSendSPC;
        private bool _errorOccurred;
        [AccessedThroughProperty("gbATCmdTerm")]
        private GroupBox _gbATCmdTerm;
        [AccessedThroughProperty("gbCheckNVStatus")]
        private GroupBox _gbCheckNVStatus;
        [AccessedThroughProperty("gbConnSettings")]
        private GroupBox _gbConnSettings;
        [AccessedThroughProperty("gbCustomRange")]
        private GroupBox _gbCustomRange;
        [AccessedThroughProperty("gbDiagPasswd")]
        private GroupBox _gbDiagPasswd;
        [AccessedThroughProperty("gbDiagVerInfo")]
        private GroupBox _gbDiagVerInfo;
        [AccessedThroughProperty("gbESNMEID")]
        private GroupBox _gbESNMEID;
        [AccessedThroughProperty("gbNVIOptions")]
        private GroupBox _gbNVIOptions;
        [AccessedThroughProperty("gbNVIRange")]
        private GroupBox _gbNVIRange;
        [AccessedThroughProperty("gbNVItems")]
        private GroupBox _gbNVItems;
        [AccessedThroughProperty("gbPhoneMode")]
        private GroupBox _gbPhoneMode;
        [AccessedThroughProperty("gbPhoneVerInfo")]
        private GroupBox _gbPhoneVerInfo;
        [AccessedThroughProperty("gbQCDMCmdTerm")]
        private GroupBox _gbQCDMCmdTerm;
        [AccessedThroughProperty("gbRangeDec")]
        private GroupBox _gbRangeDec;
        [AccessedThroughProperty("gbRangeHex")]
        private GroupBox _gbRangeHex;
        [AccessedThroughProperty("gbSkipNVItems")]
        private GroupBox _gbSkipNVItems;
        [AccessedThroughProperty("gbSource")]
        private GroupBox _gbSource;
        [AccessedThroughProperty("gbSPCLock")]
        private GroupBox _gbSPCLock;
        [AccessedThroughProperty("gbTarget")]
        private GroupBox _gbTarget;
        [AccessedThroughProperty("gbTermResponse")]
        private GroupBox _gbTermResponse;
        [AccessedThroughProperty("lbl7E")]
        private Label _lbl7E;
        [AccessedThroughProperty("lblATCmds")]
        private Label _lblATCmds;
        [AccessedThroughProperty("lblATFormat")]
        private Label _lblATFormat;
        [AccessedThroughProperty("lblAvailCOMPorts")]
        private Label _lblAvailCOMPorts;
        [AccessedThroughProperty("lblBadParamNV")]
        private Label _lblBadParamNV;
        [AccessedThroughProperty("lblBadSecNV")]
        private Label _lblBadSecNV;
        [AccessedThroughProperty("lblCompiled")]
        private Label _lblCompiled;
        [AccessedThroughProperty("lblCompleteNV")]
        private Label _lblCompleteNV;
        [AccessedThroughProperty("lblCRC")]
        private Label _lblCRC;
        [AccessedThroughProperty("lblCurrProfile")]
        private Label _lblCurrProfile;
        [AccessedThroughProperty("lblCustomNVIList")]
        private Label _lblCustomNVIList;
        [AccessedThroughProperty("lblDiagCmds")]
        private Label _lblDiagCmds;
        [AccessedThroughProperty("lblDiagPasswd")]
        private Label _lblDiagPasswd;
        [AccessedThroughProperty("lblDiagPasswdInfo")]
        private Label _lblDiagPasswdInfo;
        [AccessedThroughProperty("lblErrResponse")]
        private Label _lblErrResponse;
        [AccessedThroughProperty("lblESNFlipped")]
        private Label _lblESNFlipped;
        [AccessedThroughProperty("lblESNhex")]
        private Label _lblESNhex;
        [AccessedThroughProperty("lblFromDec")]
        private Label _lblFromDec;
        [AccessedThroughProperty("lblFromHex")]
        private Label _lblFromHex;
        [AccessedThroughProperty("lblIMEIdec")]
        private Label _lblIMEIdec;
        [AccessedThroughProperty("lblIMEIFlipped")]
        private Label _lblIMEIFlipped;
        [AccessedThroughProperty("lblInactiveNV")]
        private Label _lblInactiveNV;
        [AccessedThroughProperty("lblMEIDFlipped")]
        private Label _lblMEIDFlipped;
        [AccessedThroughProperty("lblMEIDhex")]
        private Label _lblMEIDhex;
        [AccessedThroughProperty("lblMobCAIRev")]
        private Label _lblMobCAIRev;
        [AccessedThroughProperty("lblMobFWRev")]
        private Label _lblMobFWRev;
        [AccessedThroughProperty("lblMobModel")]
        private Label _lblMobModel;
        [AccessedThroughProperty("lblMobModelID")]
        private Label _lblMobModelID;
        [AccessedThroughProperty("lblMobSWRev")]
        private Label _lblMobSWRev;
        [AccessedThroughProperty("lblMSMHWRev")]
        private Label _lblMSMHWRev;
        [AccessedThroughProperty("lblMSMRev")]
        private Label _lblMSMRev;
        [AccessedThroughProperty("lblNVI")]
        private Label _lblNVI;
        [AccessedThroughProperty("lblNVItems")]
        private Label _lblNVItems;
        [AccessedThroughProperty("lblPlus")]
        private Label _lblPlus;
        [AccessedThroughProperty("lblQCDMFormat")]
        private Label _lblQCDMFormat;
        [AccessedThroughProperty("lblReleased")]
        private Label _lblReleased;
        [AccessedThroughProperty("lblResponseLEN")]
        private Label _lblResponseLEN;
        [AccessedThroughProperty("lblSlotCycleIndex")]
        private Label _lblSlotCycleIndex;
        [AccessedThroughProperty("lblStationClassMark")]
        private Label _lblStationClassMark;
        [AccessedThroughProperty("lblToDec")]
        private Label _lblToDec;
        [AccessedThroughProperty("lblToHex")]
        private Label _lblToHex;
        [AccessedThroughProperty("lblVersionDir")]
        private Label _lblVersionDir;
        [AccessedThroughProperty("lblVersionInfo")]
        private Label _lblVersionInfo;
        private int _QCNByteOffsetESN;
        private int _QCNByteOffsetIMEI;
        private int _QCNByteOffsetMEID;
        [AccessedThroughProperty("rtConsole")]
        private RichTextBox _rtConsole;
        [AccessedThroughProperty("ssQCStatus")]
        private StatusStrip _ssQCStatus;
        [AccessedThroughProperty("tabConsole")]
        private TabPage _tabConsole;
        [AccessedThroughProperty("tabDiagnosticTools")]
        private TabPage _tabDiagnosticTools;
        [AccessedThroughProperty("tabNVBackupRestore")]
        private TabPage _tabNVBackupRestore;
        [AccessedThroughProperty("tabSecureOps")]
        private TabPage _tabSecureOps;
        [AccessedThroughProperty("tabTerminal")]
        private TabPage _tabTerminal;
        [AccessedThroughProperty("tcQCDMOptions")]
        private TabControl _tcQCDMOptions;
        [AccessedThroughProperty("TimerIn")]
        private System.Windows.Forms.Timer _TimerIn;
        [AccessedThroughProperty("TimerOut")]
        private System.Windows.Forms.Timer _TimerOut;
        [AccessedThroughProperty("tmrActivityRX")]
        private System.Windows.Forms.Timer _tmrActivityRX;
        [AccessedThroughProperty("tmrActivityTX")]
        private System.Windows.Forms.Timer _tmrActivityTX;
        [AccessedThroughProperty("tsActivityRX")]
        private ToolStripStatusLabel _tsActivityRX;
        [AccessedThroughProperty("tsActivityTX")]
        private ToolStripStatusLabel _tsActivityTX;
        [AccessedThroughProperty("tsProgress")]
        private ToolStripProgressBar _tsProgress;
        [AccessedThroughProperty("tsStatus")]
        private ToolStripStatusLabel _tsStatus;
        [AccessedThroughProperty("txtATCmd")]
        private TextBox _txtATCmd;
        [AccessedThroughProperty("txtBadParamNV")]
        private TextBox _txtBadParamNV;
        [AccessedThroughProperty("txtBadSecNV")]
        private TextBox _txtBadSecNV;
        [AccessedThroughProperty("txtCompiled")]
        private TextBox _txtCompiled;
        [AccessedThroughProperty("txtCompleteNV")]
        private TextBox _txtCompleteNV;
        [AccessedThroughProperty("txtDiagPasswd")]
        private TextBox _txtDiagPasswd;
        [AccessedThroughProperty("txtErrResponse")]
        private TextBox _txtErrResponse;
        [AccessedThroughProperty("txtESNFlipped")]
        private TextBox _txtESNFlipped;
        [AccessedThroughProperty("txtESNhex")]
        private TextBox _txtESNhex;
        [AccessedThroughProperty("txtFromDec")]
        private TextBox _txtFromDec;
        [AccessedThroughProperty("txtFromHex")]
        private TextBox _txtFromHex;
        [AccessedThroughProperty("txtIMEIdec")]
        private TextBox _txtIMEIdec;
        [AccessedThroughProperty("txtIMEIFlipped")]
        private TextBox _txtIMEIFlipped;
        [AccessedThroughProperty("txtInactiveNV")]
        private TextBox _txtInactiveNV;
        [AccessedThroughProperty("txtLockCode")]
        private TextBox _txtLockCode;
        [AccessedThroughProperty("txtMEIDFlipped")]
        private TextBox _txtMEIDFlipped;
        [AccessedThroughProperty("txtMEIDhex")]
        private TextBox _txtMEIDhex;
        [AccessedThroughProperty("txtMobCAIRev")]
        private TextBox _txtMobCAIRev;
        [AccessedThroughProperty("txtMobFWRev")]
        private TextBox _txtMobFWRev;
        [AccessedThroughProperty("txtMobModel")]
        private TextBox _txtMobModel;
        [AccessedThroughProperty("txtMobModelID")]
        private TextBox _txtMobModelID;
        [AccessedThroughProperty("txtMSMHWVer")]
        private TextBox _txtMSMHWVer;
        [AccessedThroughProperty("txtMSMRev")]
        private TextBox _txtMSMRev;
        [AccessedThroughProperty("txtNVI")]
        private TextBox _txtNVI;
        [AccessedThroughProperty("txtQCDMCmd")]
        private TextBox _txtQCDMCmd;
        [AccessedThroughProperty("txtReleased")]
        private TextBox _txtReleased;
        [AccessedThroughProperty("txtResponseLEN")]
        private TextBox _txtResponseLEN;
        [AccessedThroughProperty("txtSendSPC")]
        private TextBox _txtSendSPC;
        [AccessedThroughProperty("txtSlotCycleIndex")]
        private TextBox _txtSlotCycleIndex;
        [AccessedThroughProperty("txtSPC")]
        private TextBox _txtSPC;
        [AccessedThroughProperty("txtStationClassMark")]
        private TextBox _txtStationClassMark;
        [AccessedThroughProperty("txtTermResponse")]
        private TextBox _txtTermResponse;
        [AccessedThroughProperty("txtToDec")]
        private TextBox _txtToDec;
        [AccessedThroughProperty("txtToHex")]
        private TextBox _txtToHex;
        [AccessedThroughProperty("txtVersionDir")]
        private TextBox _txtVersionDir;
        [AccessedThroughProperty("txtVersionString")]
        private TextBox _txtVersionString;
        private IContainer components;
        private int WM_COMMNOTIFY;
        private int WM_DEVICECHANGE;

        public frmQualcommNVTools()
        {
            base.Load += new EventHandler(this.QualcommNVTools_Load);
            this._qcDevInstance = null;
            this._myCmdQueue = null;
            this._myNVMemManager = null;
            this._QCNByteOffsetESN = 0;
            this._QCNByteOffsetMEID = 0;
            this._QCNByteOffsetIMEI = 0;
            this._errorOccurred = false;
            this.WM_DEVICECHANGE = 0x219;
            this.WM_COMMNOTIFY = 0x44;
            this.InitializeComponent();
            this.lblVersionInfo.Text = "Qualcomm NV Tools v" + VersionInfo.GetAppVersion() + " \x00a9 Gaz 2014.";
            this._qcDevInstance = QualcommDeviceInstance.Init;
            this._myCmdQueue = this._qcDevInstance.CommandQueueInstance;
            this._myNVMemManager = this._qcDevInstance.NVMemMgrInstance;
            this.cbConnMode.SelectedIndex = 4;
            this.cbSource.SelectedIndex = 0;
            this.cbTarget.SelectedIndex = 0;
            this.cbDiagCmds.DataSource = Enum.GetNames(typeof(Qcdm.Cmd));
            this.cbDiagCmds.SelectedIndex = 0x20;
            this.cbNVItems.DataSource = Enum.GetNames(typeof(NVItemList));
            this.cbNVItems.SelectedIndex = 0x217;
            AT_Cmd cmd = new AT_Cmd();
            foreach (AT_Cmd cmd2 in cmd.GetCommands())
            {
                this.cbATCmds.Items.Add(cmd2.CommandName);
            }
            this.cbATCmds.SelectedIndex = 0;
        }

        [CompilerGenerated]
        private void _Lambda$__100()
        {
            if (this.cbCOMPorts.Items.Count >= 1)
            {
                this.cbCOMPorts.SelectedIndex = 0;
            }
            this.gbConnSettings.Enabled = true;
            this.tcQCDMOptions.Enabled = true;
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__101(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__102)();
        }

        [CompilerGenerated]
        private void _Lambda$__102()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__103));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__103()
        {
            while (this._qcDevInstance.CommandQueueInstance.GetCount() > 0)
            {
                Thread.Sleep(150);
            }
            if (this.cbConnMode.SelectedIndex == 2)
            {
                this.DisconnectCOMPort();
                Interaction.MsgBox("Phone has been Reset and the COM Port has been disconnected.", MsgBoxStyle.Information, null);
            }
            else if (this.cbConnMode.SelectedIndex == 7)
            {
                this.DisconnectCOMPort();
                Interaction.MsgBox("Phone has booted into Download Mode and the COM Port has been disconnected.", MsgBoxStyle.Information, null);
            }
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__104(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__105)();
        }

        [CompilerGenerated]
        private void _Lambda$__105()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__106));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__106()
        {
            DIAG_VERNO_F_CLS diag_verno_f_cls = (DIAG_VERNO_F_CLS) this._qcDevInstance.CommandQueueInstance.CommandOutput[0];
            if (diag_verno_f_cls != null)
            {
                this.txtCompiled.Text = diag_verno_f_cls.CompileDate + " - " + diag_verno_f_cls.CompileTime;
                this.txtReleased.Text = diag_verno_f_cls.ReleaseDate + " - " + diag_verno_f_cls.ReleaseTime;
                this.txtVersionDir.Text = diag_verno_f_cls.VersionDir;
                this.txtStationClassMark.Text = diag_verno_f_cls.StationClassMark;
                this.txtMobCAIRev.Text = diag_verno_f_cls.MobileCAIRevision;
                this.txtMobModel.Text = diag_verno_f_cls.MobileModel;
                this.txtMobFWRev.Text = diag_verno_f_cls.MobileFWRevision;
                this.txtSlotCycleIndex.Text = diag_verno_f_cls.SlotCycleIndex;
                this.txtMSMRev.Text = diag_verno_f_cls.MSMRevision;
            }
            DIAG_EXT_BUILD_ID_F_CLS diag_ext_build_id_f_cls = (DIAG_EXT_BUILD_ID_F_CLS) this._qcDevInstance.CommandQueueInstance.CommandOutput[1];
            this.txtMSMHWVer.Text = diag_ext_build_id_f_cls.MSMHardwareRevision;
            this.txtMobModelID.Text = diag_ext_build_id_f_cls.MobileModelID;
            this.txtVersionString.Text = diag_ext_build_id_f_cls.MobileSoftwareRevision;
            this.txtSPC.Text = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[2]);
            this.txtLockCode.Text = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[3]);
            string str = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[4]);
            this.txtESNhex.Text = ConversionUtils.ReverseHex(str).Replace(" ", "");
            this.txtESNFlipped.Text = ConversionUtils.FormatHexStr(str);
            string str3 = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[5]);
            this.txtMEIDhex.Text = ConversionUtils.ReverseHex(str3).Replace(" ", "");
            this.txtMEIDFlipped.Text = ConversionUtils.FormatHexStr(str3);
            string hexInput = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[6]);
            this.txtIMEIdec.Text = ConversionUtils.ReverseHexToIMEI(hexInput);
            this.txtIMEIFlipped.Text = ConversionUtils.FormatHexStr(hexInput);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__107(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__108)();
        }

        [CompilerGenerated]
        private void _Lambda$__108()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__109));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__109()
        {
            this.txtSPC.Text = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__110(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__111)();
        }

        [CompilerGenerated]
        private void _Lambda$__111()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__112));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__112()
        {
            this.txtLockCode.Text = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__113(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__114)();
        }

        [CompilerGenerated]
        private void _Lambda$__114()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__115));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__115()
        {
            string str = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]);
            this.txtESNhex.Text = ConversionUtils.ReverseHex(str).Replace(" ", "");
            this.txtESNFlipped.Text = ConversionUtils.FormatHexStr(str);
            string str3 = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[1]);
            this.txtMEIDhex.Text = ConversionUtils.ReverseHex(str3).Replace(" ", "");
            this.txtMEIDFlipped.Text = ConversionUtils.FormatHexStr(str3);
            string hexInput = Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[2]);
            this.txtIMEIdec.Text = ConversionUtils.ReverseHexToIMEI(hexInput);
            this.txtIMEIFlipped.Text = ConversionUtils.FormatHexStr(hexInput);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__116(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__117)();
        }

        [CompilerGenerated]
        private void _Lambda$__117()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__118));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__118()
        {
            string aSCIIString = ConversionUtils.GetASCIIString((byte[]) this._qcDevInstance.CommandQueueInstance.CommandOutput[0]);
            this.txtTermResponse.Text = aSCIIString;
            this.txtResponseLEN.Text = Conversions.ToString((double) (((double) aSCIIString.Length) / 2.0));
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__119(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__120)();
        }

        [CompilerGenerated]
        private void _Lambda$__120()
        {
            this._myCmdQueue.WaitForEvents();
            if (this._qcDevInstance.CommandQueueInstance.CommandOutput != null)
            {
                this.Invoke(new Action(this._Lambda$__121));
            }
        }

        [CompilerGenerated]
        private void _Lambda$__121()
        {
            string strInput = ConversionUtils.BytesToHexString((byte[]) this._qcDevInstance.CommandQueueInstance.CommandOutput[0]);
            this.txtTermResponse.Text = ConversionUtils.FormatTermOutput(strInput, 0x11);
            this.txtResponseLEN.Text = Conversions.ToString((double) (((double) strInput.Length) / 2.0)) + " bytes";
            this.txtErrResponse.Text = this._qcDevInstance.CommandQueueInstance.NVErrorResponse[0].ToString();
            if (((Qcdm.NV_Response) this._qcDevInstance.CommandQueueInstance.NVErrorResponse[0]) != Qcdm.NV_Response.NV_ERR_SUCCESS)
            {
                Interaction.MsgBox("Error: " + this._qcDevInstance.CommandQueueInstance.NVErrorResponse[0].ToString(), MsgBoxStyle.Critical, null);
            }
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__94(ProgressChangedEventArgs a0)
        {
            this.ProgressChanged_myCmdQueue((CommandQueueProgressChangedEventArgs) a0);
        }

        [CompilerGenerated]
        private void _Lambda$__98()
        {
            this.cbCOMPorts.Items.Clear();
        }

        private void ActivityRX_myCmdQueue(DataActivityEventArgs e)
        {
            if (e.DataActivity)
            {
                this.tsActivityRX.BackColor = Color.Green;
                this.tmrActivityRX.Enabled = true;
            }
        }

        private void ActivityTX_mycmdQueue(DataActivityEventArgs e)
        {
            if (e.DataActivity)
            {
                this.tsActivityTX.BackColor = Color.Orange;
                this.tmrActivityTX.Enabled = true;
            }
        }

        private void btnAddNVI_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(this.txtNVI.Text))
                {
                    string name;
                    if (!this.txtNVI.Text.Contains("-"))
                    {
                        if (Enum.IsDefined(typeof(NVItemList), Conversions.ToLong(this.txtNVI.Text)))
                        {
                            name = Enum.GetName(typeof(NVItemList), Conversions.ToLong(this.txtNVI.Text));
                            if (!this.cbCustomNVIList.Items.Contains(name))
                            {
                                this.cbCustomNVIList.Items.Add(Enum.GetName(typeof(NVItemList), Conversions.ToLong(this.txtNVI.Text)));
                                goto Label_0278;
                            }
                            Interaction.MsgBox("NV Item already exists in the list!", MsgBoxStyle.Information, null);
                            this.txtNVI.Focus();
                        }
                        else
                        {
                            if (!this.cbCustomNVIList.Items.Contains(Conversions.ToLong(this.txtNVI.Text)))
                            {
                                this.cbCustomNVIList.Items.Add(Conversions.ToLong(this.txtNVI.Text));
                                goto Label_0278;
                            }
                            Interaction.MsgBox("NV Item already exists in the list!", MsgBoxStyle.Information, null);
                            this.txtNVI.Focus();
                        }
                        return;
                    }
                    string[] strArray = this.txtNVI.Text.Split(new char[] { '-' });
                    long num2 = long.Parse(strArray[0]);
                    int num = (int) (long.Parse(strArray[1]) - num2);
                    if (num > 0x3e8)
                    {
                        Interaction.MsgBox("Too many NV items in specified range! Maximum allowed is 1000!", MsgBoxStyle.Exclamation, null);
                        return;
                    }
                    long num5 = num + num2;
                    for (long i = num2; i <= num5; i += 1L)
                    {
                        if (Enum.IsDefined(typeof(NVItemList), i))
                        {
                            name = Enum.GetName(typeof(NVItemList), i);
                            if (!this.cbCustomNVIList.Items.Contains(name))
                            {
                                this.cbCustomNVIList.Items.Add(Enum.GetName(typeof(NVItemList), i));
                            }
                        }
                        else if (!this.cbCustomNVIList.Items.Contains(i))
                        {
                            this.cbCustomNVIList.Items.Add(i);
                        }
                    }
                }
                else
                {
                    Interaction.MsgBox("Please enter an NV item number!", MsgBoxStyle.Information, null);
                }
            Label_0278:
                this.cbCustomNVIList.SelectedIndex = this.cbCustomNVIList.Items.Count - 1;
                this.txtNVI.Clear();
                this.txtNVI.Focus();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error!");
                ProjectData.ClearProjectError();
            }
        }

        private void btnBackupNVItems_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                IEnumerator enumerator;
                this.ResetNVItemsStatus();
                if (this.chkEnableNVISkip.Checked)
                {
                    if (this.cbNVItemSkipList.SelectedIndex == -1)
                    {
                        Interaction.MsgBox("Please select a device from the Current Profile list!", MsgBoxStyle.Exclamation, null);
                        return;
                    }
                    this._myNVMemManager.EnableNVItemSkipping = true;
                }
                else
                {
                    this._myNVMemManager.EnableNVItemSkipping = false;
                }
                List<string> nvList = new List<string>();
                try
                {
                    enumerator = this.cbCustomNVIList.Items.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        nvList.Add(RuntimeHelpers.GetObjectValue(enumerator.Current).ToString());
                    }
                }
                finally
                {
                    if (enumerator is IDisposable)
                    {
                        (enumerator as IDisposable).Dispose();
                    }
                }
                if (this.chkEnableCstNVIRange.Checked)
                {
                    if (this.cbCustomNVIList.Items.Count == 0)
                    {
                        Interaction.MsgBox("Please define one or more custom NV items!", MsgBoxStyle.Exclamation, null);
                    }
                    else
                    {
                        this._myNVMemManager.BackupNVItems(nvList, (long) this.cbNVItemSkipList.SelectedIndex);
                    }
                }
                else
                {
                    this._myNVMemManager.BackupNVItems((long) Conversions.ToInteger(this.txtFromDec.Text), (long) Conversions.ToInteger(this.txtToDec.Text), (long) this.cbNVItemSkipList.SelectedIndex);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this._myNVMemManager.CancelOperation();
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                this._qcDevInstance.CommandQueueInstance.Clear();
                if (this.cbConnMode.SelectedIndex == 0)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.OfflineAnalog, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 1)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.OfflineDigital, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 2)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.Reset, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 3)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.FactoryTestMode, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 4)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.Online, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 5)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.LowPower, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 6)
                {
                    ConnectionUtils.SetConnectionMode(ConnectionUtils.ConnectionMode.Power, this._qcDevInstance.CommandQueueInstance);
                }
                else if (this.cbConnMode.SelectedIndex == 7)
                {
                    EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(Qcdm.Cmd.DIAG_DLOAD_F);
                    this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                }
                this._qcDevInstance.CommandQueueInstance.Run(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__101));
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.rtConsole.Clear();
            this.rtConsole.Refresh();
        }

        private void btnClearNVI_Click(object sender, EventArgs e)
        {
            this.cbCustomNVIList.Items.Clear();
            this.txtNVI.Clear();
            this.txtNVI.Focus();
        }

        private void btnClearTerm_Click(object sender, EventArgs e)
        {
            this.txtTermResponse.Clear();
            this.txtResponseLEN.Clear();
            this.txtErrResponse.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (this.chkSendSPC.Checked)
            {
                if (this.txtSendSPC.Text.Length != 6)
                {
                    Interaction.MsgBox("SPC MUST be 6 digits!", MsgBoxStyle.Exclamation, "Warning!");
                    return;
                }
                if (!this.ConnectToCOMPort())
                {
                    return;
                }
                string str = this.SendSPC(this.txtSendSPC.Text);
                if (str == "0")
                {
                    Interaction.MsgBox("SPC was rejected by the phone!", MsgBoxStyle.Critical, null);
                    frmWaitDialog dialog = new frmWaitDialog();
                    dialog.ShowDialog();
                    dialog.Dispose();
                    this.DisconnectCOMPort();
                    return;
                }
                if (str != "1")
                {
                    Interaction.MsgBox("Unable to send SPC to the phone!", MsgBoxStyle.Critical, null);
                    this.DisconnectCOMPort();
                    return;
                }
                Interaction.MsgBox("SPC was accepted by the phone!", MsgBoxStyle.Information, null);
            }
            else if (!this.ConnectToCOMPort())
            {
                return;
            }
            if (this.chkReadPhone.Checked && !this.ReadPhoneInfo())
            {
                Interaction.MsgBox("Error reading phone information!", MsgBoxStyle.Exclamation, null);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            this.DisconnectCOMPort();
            this.ClearFields();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            this.ShowDonateDialog();
        }

        private void btnReadEMI_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbSource.SelectedIndex == -1)
                {
                    Interaction.MsgBox("Please select a source to read from!", MsgBoxStyle.Critical, null);
                }
                else if (this.cbSource.SelectedIndex == 0)
                {
                    if (this.CheckDeviceState())
                    {
                        this._qcDevInstance.CommandQueueInstance.Clear();
                        EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_ESN_I);
                        this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                        inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_MEID_I);
                        this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                        inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_UE_IMEI_I);
                        this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                        this._qcDevInstance.CommandQueueInstance.Run(false);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__113));
                    }
                }
                else if ((this.cbSource.SelectedIndex == 1) && (this.OpenReadQCN() == "-1"))
                {
                    Interaction.MsgBox("Unable to read byte data from specified QCN Backup!", MsgBoxStyle.Critical, null);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("Unable to read byte data to specified source!", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void btnReadLockCode_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                this._qcDevInstance.CommandQueueInstance.Clear();
                EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_LOCK_CODE_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                this._qcDevInstance.CommandQueueInstance.Run(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__110));
            }
        }

        private void btnReadPhoneInfo_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState() && !this.ReadPhoneInfo())
            {
                Interaction.MsgBox("Error reading phone information!", MsgBoxStyle.Exclamation, null);
            }
        }

        private void btnReadSPC_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                this._qcDevInstance.CommandQueueInstance.Clear();
                EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_SEC_CODE_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                this._qcDevInstance.CommandQueueInstance.Run(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__107));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshCOMPortList();
        }

        private void btnRefreshNVISkipList_Click(object sender, EventArgs e)
        {
            if (!this.RefreshNVISkipList())
            {
                Interaction.MsgBox("An error occurred while loading the NV Item Skip List!", MsgBoxStyle.Critical, null);
            }
        }

        private void btnRemoveNVI_Click(object sender, EventArgs e)
        {
            if (this.cbCustomNVIList.Items.Count != 0)
            {
                int selectedIndex = this.cbCustomNVIList.SelectedIndex;
                if (selectedIndex != -1)
                {
                    this.cbCustomNVIList.Items.RemoveAt(selectedIndex);
                    if (this.cbCustomNVIList.Items.Count != 0)
                    {
                        if (selectedIndex == 0)
                        {
                            this.cbCustomNVIList.SelectedIndex = selectedIndex;
                        }
                        else
                        {
                            this.cbCustomNVIList.SelectedIndex = selectedIndex - 1;
                        }
                    }
                }
            }
            this.txtNVI.Clear();
            this.txtNVI.Focus();
        }

        private void btnRestoreNVItems_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                this.ResetNVItemsStatus();
                this._myNVMemManager.RestoreNVItems();
            }
        }

        private void btnSendAT_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                List<byte> list = new List<byte>();
                string text = this.txtATCmd.Text;
                int num = 0;
                int length = text.Length;
                while (num < length)
                {
                    char ch = text[num];
                    list.Add((byte) Convert.ToUInt32(ch));
                    num++;
                }
                list.Add(13);
                list.Add(10);
                this._qcDevInstance.CommandQueueInstance.Clear();
                EFS_Professional.Command inCommand = new EFS_Professional.Command(list.ToArray(), "AT Terminal Command");
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                this._qcDevInstance.CommandQueueInstance.Run(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__116));
            }
        }

        private void btnSendDiagPwd_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                if (this.txtDiagPasswd.Text.Length != 0x10)
                {
                    Interaction.MsgBox("Diagnostics Password MUST be 16 digits!", MsgBoxStyle.Exclamation, "Warning!");
                }
                else if (this.SendDiagPassword(this.txtDiagPasswd.Text) == "1")
                {
                    Interaction.MsgBox("Password corrrect, device unlocked!", MsgBoxStyle.Information, null);
                }
                else
                {
                    Interaction.MsgBox("Password incorrrect! Restart device!", MsgBoxStyle.Information, null);
                }
            }
        }

        private void btnSendQCDM_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                string text;
                if (this.chkCRC7E.Checked)
                {
                    text = this.txtQCDMCmd.Text + this.lblCRC.Text + this.lbl7E.Text;
                }
                else
                {
                    text = this.txtQCDMCmd.Text;
                }
                this._qcDevInstance.CommandQueueInstance.Clear();
                EFS_Professional.Command inCommand = new EFS_Professional.Command(ConversionUtils.HexStringToBytes(text), "QCDM Terminal Command");
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                this._qcDevInstance.CommandQueueInstance.Run(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__119));
            }
        }

        private void btnSendSPC_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                if (this.txtSPC.Text.Length != 6)
                {
                    Interaction.MsgBox("SPC MUST be 6 digits!", MsgBoxStyle.Exclamation, "Warning!");
                }
                else
                {
                    string str = this.SendSPC(this.txtSPC.Text);
                    if (str == "0")
                    {
                        Interaction.MsgBox("SPC was rejected by the phone!", MsgBoxStyle.Critical, "Rejected!");
                        frmWaitDialog dialog = new frmWaitDialog();
                        dialog.ShowDialog();
                        dialog.Dispose();
                    }
                    else if (str == "1")
                    {
                        Interaction.MsgBox("SPC was accepted by the phone!", MsgBoxStyle.Information, "Accepted!");
                    }
                    else
                    {
                        Interaction.MsgBox("Unable to send SPC to the phone!", MsgBoxStyle.Critical, "Error!");
                    }
                }
            }
        }

        private void btnViewNVSkipProfile_Click(object sender, EventArgs e)
        {
            if (this.cbNVItemSkipList.SelectedIndex != -1)
            {
                string str2 = string.Empty;
                int selectedIndex = 0;
                selectedIndex = this.cbNVItemSkipList.SelectedIndex;
                foreach (string str3 in this._qcDevInstance.NVMemMgrInstance.NVItemSkipList[selectedIndex].NVItems)
                {
                    str2 = str2 + str3 + ", ";
                }
                Interaction.MsgBox("The following NV Item(s) will be skipped during backup:\r\n\r\n" + str2.TrimEnd(new char[] { ',', ' ' }), MsgBoxStyle.Information, "Viewing Current Profile: " + this._qcDevInstance.NVMemMgrInstance.NVItemSkipList[selectedIndex].DeviceName);
            }
        }

        private void btnWriteEMI_Click(object sender, EventArgs e)
        {
            this._errorOccurred = false;
            if (this.cbTarget.SelectedIndex == -1)
            {
                Interaction.MsgBox("Please select a target to write to!", MsgBoxStyle.Critical, null);
            }
            else if ((!this.chkESN.Checked && !this.chkMEID.Checked) && !this.chkIMEI.Checked)
            {
                Interaction.MsgBox("No ESN / MEID / IMEI has been selected!", MsgBoxStyle.Critical, null);
            }
            else if (this.chkESN.Checked && (this.txtESNhex.Text.Length != 8))
            {
                Interaction.MsgBox("ESN length MUST be 8 digits!", MsgBoxStyle.Exclamation, "Warning!");
            }
            else if (this.chkMEID.Checked && (this.txtMEIDhex.Text.Length != 14))
            {
                Interaction.MsgBox("MEID length MUST be 14 digits!", MsgBoxStyle.Exclamation, "Warning!");
            }
            else if (this.chkIMEI.Checked && (this.txtIMEIdec.Text.Length != 15))
            {
                Interaction.MsgBox("IMEI length MUST be 15 digits!", MsgBoxStyle.Exclamation, "Warning!");
            }
            else
            {
                try
                {
                    if (this.cbTarget.SelectedIndex == 0)
                    {
                        if (this.CheckDeviceState())
                        {
                            byte[] buffer;
                            EFS_Professional.Command command;
                            this._qcDevInstance.CommandQueueInstance.Clear();
                            if (this.chkESN.Checked)
                            {
                                buffer = ConversionUtils.HexStringToBytes(this.txtESNFlipped.Text.Replace(" ", string.Empty));
                                command = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_ESN_I, true, buffer);
                                this._qcDevInstance.CommandQueueInstance.Add(ref command);
                            }
                            if (this.chkMEID.Checked)
                            {
                                buffer = ConversionUtils.HexStringToBytes(this.txtMEIDFlipped.Text.Replace(" ", string.Empty));
                                command = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_MEID_I, true, buffer);
                                this._qcDevInstance.CommandQueueInstance.Add(ref command);
                            }
                            if (this.chkIMEI.Checked)
                            {
                                buffer = ConversionUtils.HexStringToBytes(this.txtIMEIFlipped.Text.Replace(" ", string.Empty));
                                command = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_UE_IMEI_I, true, buffer);
                                this._qcDevInstance.CommandQueueInstance.Add(ref command);
                            }
                            this._qcDevInstance.CommandQueueInstance.Run(false);
                            int num4 = this._qcDevInstance.CommandQueueInstance.CommandOutput.Count - 1;
                            for (int i = 0; i <= num4; i++)
                            {
                                if (((Qcdm.NV_Response) this._qcDevInstance.CommandQueueInstance.NVErrorResponse[i]) != Qcdm.NV_Response.NV_ERR_SUCCESS)
                                {
                                    Interaction.MsgBox("Cannot Write: " + this._qcDevInstance.CommandQueueInstance.NVCommand[i].ToString() + "\r\n\r\nError: " + this._qcDevInstance.CommandQueueInstance.NVErrorResponse[i].ToString(), MsgBoxStyle.Exclamation, null);
                                }
                                else
                                {
                                    if (this._qcDevInstance.CommandQueueInstance.CommandOutput[i].ToString() == "-1")
                                    {
                                        throw new Exception("An unknown error occurred while writing to NV Item: " + this._qcDevInstance.CommandQueueInstance.NVCommand[i].ToString());
                                    }
                                    if (!this._errorOccurred)
                                    {
                                        Interaction.MsgBox("NV Item: " + this._qcDevInstance.CommandQueueInstance.NVCommand[i].ToString() + " was written successfully!", MsgBoxStyle.Information, null);
                                    }
                                }
                            }
                        }
                    }
                    else if (this.cbTarget.SelectedIndex == 1)
                    {
                        switch (this.OpenWriteQCN())
                        {
                            case "0":
                                Interaction.MsgBox("Selected byte data was written to QCN Backup successfully!", MsgBoxStyle.Information, null);
                                break;

                            case "-1":
                                Interaction.MsgBox("Unable to write selected byte data to QCN Backup!", MsgBoxStyle.Critical, null);
                                break;
                        }
                    }
                    else if (this.cbTarget.SelectedIndex == 2)
                    {
                        SaveFileDialog dialog = new SaveFileDialog();
                        SaveFileDialog dialog2 = dialog;
                        dialog2.Filter = "CDMA Workshop Patch (*.txt)|*.txt";
                        dialog2.FileName = "*.txt";
                        dialog2 = null;
                        if (dialog.ShowDialog() == DialogResult.Cancel)
                        {
                            dialog.Dispose();
                        }
                        else
                        {
                            dialog.Dispose();
                            List<int> list = new List<int>();
                            if (this.chkESN.Checked)
                            {
                                list.Add(0);
                            }
                            if (this.chkIMEI.Checked)
                            {
                                list.Add(550);
                            }
                            if (this.chkMEID.Checked)
                            {
                                list.Add(0x797);
                            }
                            StreamWriter writer = new StreamWriter(dialog.FileName, false);
                            writer.Write("[NV items]\r\n");
                            writer.Write(("[Complete items - " + list.Count.ToString() + ", Items size - 128]") + "\r\n\r\n");
                            foreach (int num3 in list)
                            {
                                string s = num3.ToString("X");
                                long num2 = long.Parse(s, NumberStyles.HexNumber);
                                string str6 = string.Empty;
                                switch (num3)
                                {
                                    case 0:
                                        str6 = this.txtESNFlipped.Text.Replace(" ", string.Empty);
                                        break;

                                    case 550:
                                        str6 = this.txtIMEIFlipped.Text.Replace(" ", string.Empty);
                                        break;

                                    case 0x797:
                                        str6 = this.txtMEIDFlipped.Text.Replace(" ", string.Empty);
                                        break;
                                }
                                while (str6.Length < 0x100)
                                {
                                    str6 = str6 + "0";
                                }
                                writer.Write((num2.ToString("d5") + " (0x" + s + ")   -   OK") + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0x20, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0x40, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0x60, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0x40, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(80, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0x60, 0x20)) + "\r\n");
                                writer.Write(ConversionUtils.FormatHexStr(str6.Substring(0x80, 0x20)) + "\r\n\r\n");
                            }
                            writer.Close();
                            Interaction.MsgBox("Selected byte data was written to CDMA Workshop Patch successfully!", MsgBoxStyle.Information, null);
                        }
                    }
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox("Unable to write selected byte data to specified target!", MsgBoxStyle.Critical, null);
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void btnWriteLockCode_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                this._qcDevInstance.CommandQueueInstance.Clear();
                EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_LOCK_CODE_I, true, Encoding.ASCII.GetBytes(this.txtLockCode.Text));
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                this._qcDevInstance.CommandQueueInstance.Run(false);
            }
        }

        private void btnWriteSPC_Click(object sender, EventArgs e)
        {
            if (this.CheckDeviceState())
            {
                if (this.txtSPC.Text.Length != 6)
                {
                    Interaction.MsgBox("SPC MUST be 6 digits!", MsgBoxStyle.Exclamation, "Warning!");
                }
                else
                {
                    this._qcDevInstance.CommandQueueInstance.Clear();
                    EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_SEC_CODE_I, true, Encoding.ASCII.GetBytes(this.txtSPC.Text));
                    this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                    this._qcDevInstance.CommandQueueInstance.Run(false);
                }
            }
        }

        private void cbATCmds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbDiagCmds.SelectedIndex != -1)
            {
                AT_Cmd cmd = new AT_Cmd();
                foreach (AT_Cmd cmd2 in cmd.GetCommands())
                {
                    if (this.cbATCmds.SelectedItem.ToString() == cmd2.CommandName)
                    {
                        this.txtATCmd.Text = cmd2.CommandValue;
                    }
                }
            }
        }

        private void cbCustomNVIList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtNVI.Text = Conversions.ToString(Enum.Parse(typeof(NVItemList), Conversions.ToString(this.cbCustomNVIList.SelectedItem)));
        }

        private void cbDiagCmds_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbDiagCmds.SelectedIndex != -1)
            {
                string str = Conversions.ToInteger(NewLateBinding.LateIndexGet(Enum.GetValues(typeof(Qcdm.Cmd)), new object[] { this.cbDiagCmds.SelectedIndex }, null)).ToString("X2");
                this.txtQCDMCmd.Text = str;
            }
        }

        private void cbNVItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbNVItems.SelectedIndex != -1)
            {
                string str = ConversionUtils.ReverseHex(Conversions.ToInteger(NewLateBinding.LateIndexGet(Enum.GetValues(typeof(NVItemList)), new object[] { this.cbNVItems.SelectedIndex }, null)).ToString("X4")).Replace(" ", "");
                if (this.txtQCDMCmd.Text.Length >= 2)
                {
                    this.txtQCDMCmd.Text = this.txtQCDMCmd.Text.Substring(0, 2) + str;
                }
                else
                {
                    this.txtQCDMCmd.Text = str;
                }
            }
        }

        private bool CheckDeviceState()
        {
            if (this._qcDevInstance.SerialPortInstance != null)
            {
                if (!this._qcDevInstance.IsConnected())
                {
                    Interaction.MsgBox("Phone is NOT connected!", MsgBoxStyle.Critical, "Error!");
                    return false;
                }
                if (this._qcDevInstance.CommandQueueInstance.IsBusy)
                {
                    Interaction.MsgBox("An operation is currently pending.\r\nCancel the operation first or wait for it to finish.", MsgBoxStyle.Exclamation, "Operation Pending!");
                    return false;
                }
                return true;
            }
            Interaction.MsgBox("Phone is NOT connected!", MsgBoxStyle.Critical, "Error!");
            return false;
        }

        private void chkEnableCstNVIRange_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEnableCstNVIRange.Checked)
            {
                this.gbRangeDec.Enabled = false;
                this.gbRangeHex.Enabled = false;
                this.gbCustomRange.Enabled = true;
            }
            else
            {
                this.gbRangeDec.Enabled = true;
                this.gbRangeHex.Enabled = true;
                this.gbCustomRange.Enabled = false;
            }
        }

        private void chkEnableNVISkip_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkEnableNVISkip.Checked)
            {
                this.gbSkipNVItems.Enabled = true;
            }
            else
            {
                this.gbSkipNVItems.Enabled = false;
            }
        }

        private void chkIncludeCRC7E_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkCRC7E.Checked)
            {
                this.lblCRC.Visible = true;
                this.lblPlus.Visible = true;
                this.lbl7E.Visible = true;
            }
            else
            {
                this.lblCRC.Visible = false;
                this.lblPlus.Visible = false;
                this.lbl7E.Visible = false;
            }
        }

        private void ClearFields()
        {
            this.txtCompiled.Text = string.Empty;
            this.txtReleased.Text = string.Empty;
            this.txtVersionDir.Text = string.Empty;
            this.txtStationClassMark.Text = string.Empty;
            this.txtMobCAIRev.Text = string.Empty;
            this.txtMobModel.Text = string.Empty;
            this.txtMobFWRev.Text = string.Empty;
            this.txtSlotCycleIndex.Text = string.Empty;
            this.txtMSMRev.Text = string.Empty;
            this.txtMSMHWVer.Text = string.Empty;
            this.txtMobModelID.Text = string.Empty;
            this.txtVersionString.Text = string.Empty;
            this.txtSPC.Text = string.Empty;
            this.txtLockCode.Text = string.Empty;
            this.txtESNhex.Text = string.Empty;
            this.txtESNFlipped.Text = string.Empty;
            this.txtMEIDhex.Text = string.Empty;
            this.txtMEIDFlipped.Text = string.Empty;
            this.txtIMEIdec.Text = string.Empty;
            this.txtIMEIFlipped.Text = string.Empty;
            this.txtBadParamNV.Text = "0";
            this.txtBadSecNV.Text = "0";
            this.txtInactiveNV.Text = "0";
            this.txtCompleteNV.Text = "0";
        }

        public bool ConnectToCOMPort()
        {
            string str2 = this.cbCOMPorts.SelectedItem.ToString();
            string comPort = string.Empty;
            foreach (COMPortInfo info in this._qcDevInstance.GetCOMPortList())
            {
                if (info.DeviceName == str2)
                {
                    comPort = info.COMPort;
                    break;
                }
            }
            if (this.cbCOMPorts.Items.Count > 0)
            {
                if (this._qcDevInstance.Connect(comPort))
                {
                    this.tsStatus.Text = "Connected to phone successfully on: " + comPort;
                }
                else
                {
                    this.tsStatus.Text = "Error: unable to connect to phone!";
                    Interaction.MsgBox("Unable to connect to phone!", MsgBoxStyle.Critical, "Error!");
                    this._qcDevInstance.ResetCOMPort();
                    return false;
                }
                this.cbCOMPorts.Enabled = false;
                this.btnRefresh.Enabled = false;
                this.btnConnect.Enabled = false;
                this.btnDisconnect.Enabled = true;
                this.gbPhoneMode.Enabled = true;
                return true;
            }
            Interaction.MsgBox("No COM port selected!", MsgBoxStyle.Critical, "Error!");
            return false;
        }

        private void DisconnectCOMPort()
        {
            this._qcDevInstance.Disconnect();
            this.tsStatus.Text = "Disconnected!";
            this.cbCOMPorts.Enabled = true;
            this.btnRefresh.Enabled = true;
            this.btnConnect.Enabled = true;
            this.btnDisconnect.Enabled = false;
            this.gbPhoneMode.Enabled = false;
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

        private void FormatText(string text, int fontSize, FontStyle style, Color colour)
        {
            using (Font font = new Font("Consolas", this.rtConsole.Font.Size + fontSize, style))
            {
                int textLength = this.rtConsole.TextLength;
                this.rtConsole.AppendText(text);
                int num = this.rtConsole.TextLength;
                this.rtConsole.Select(textLength, num - textLength);
                this.rtConsole.SelectionColor = colour;
                this.rtConsole.SelectionFont = font;
                this.rtConsole.ScrollToCaret();
            }
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmQualcommNVTools));
            this.gbConnSettings = new GroupBox();
            this.chkSendSPC = new CheckBox();
            this.chkReadPhone = new CheckBox();
            this.txtSendSPC = new TextBox();
            this.gbPhoneMode = new GroupBox();
            this.btnChangeMode = new Button();
            this.cbConnMode = new ComboBox();
            this.lblAvailCOMPorts = new Label();
            this.cbCOMPorts = new ComboBox();
            this.btnRefresh = new Button();
            this.btnConnect = new Button();
            this.btnDisconnect = new Button();
            this.tabDiagnosticTools = new TabPage();
            this.gbDiagVerInfo = new GroupBox();
            this.lblSlotCycleIndex = new Label();
            this.txtSlotCycleIndex = new TextBox();
            this.lblMobFWRev = new Label();
            this.txtMobFWRev = new TextBox();
            this.lblMobModel = new Label();
            this.txtMobModel = new TextBox();
            this.lblMobCAIRev = new Label();
            this.txtMobCAIRev = new TextBox();
            this.lblMSMRev = new Label();
            this.txtMSMRev = new TextBox();
            this.txtCompiled = new TextBox();
            this.txtVersionDir = new TextBox();
            this.lblVersionDir = new Label();
            this.lblCompiled = new Label();
            this.lblStationClassMark = new Label();
            this.txtReleased = new TextBox();
            this.txtStationClassMark = new TextBox();
            this.lblReleased = new Label();
            this.btnReadPhoneInfo = new Button();
            this.gbPhoneVerInfo = new GroupBox();
            this.lblMobModelID = new Label();
            this.txtMobModelID = new TextBox();
            this.lblMSMHWRev = new Label();
            this.txtMSMHWVer = new TextBox();
            this.lblMobSWRev = new Label();
            this.txtVersionString = new TextBox();
            this.tcQCDMOptions = new TabControl();
            this.tabSecureOps = new TabPage();
            this.gbSPCLock = new GroupBox();
            this.btnWriteLockCode = new Button();
            this.btnReadSPC = new Button();
            this.txtSPC = new TextBox();
            this.btnSendSPC = new Button();
            this.txtLockCode = new TextBox();
            this.btnReadLockCode = new Button();
            this.btnWriteSPC = new Button();
            this.gbESNMEID = new GroupBox();
            this.chkIMEI = new CheckBox();
            this.gbTarget = new GroupBox();
            this.cbTarget = new ComboBox();
            this.btnWriteEMI = new Button();
            this.chkMEID = new CheckBox();
            this.gbSource = new GroupBox();
            this.cbSource = new ComboBox();
            this.btnReadEMI = new Button();
            this.chkESN = new CheckBox();
            this.txtIMEIFlipped = new TextBox();
            this.lblIMEIFlipped = new Label();
            this.lblMEIDhex = new Label();
            this.txtIMEIdec = new TextBox();
            this.txtMEIDFlipped = new TextBox();
            this.lblIMEIdec = new Label();
            this.txtMEIDhex = new TextBox();
            this.lblESNhex = new Label();
            this.txtESNhex = new TextBox();
            this.lblMEIDFlipped = new Label();
            this.txtESNFlipped = new TextBox();
            this.lblESNFlipped = new Label();
            this.gbDiagPasswd = new GroupBox();
            this.lblDiagPasswdInfo = new Label();
            this.btnSendDiagPasswd = new Button();
            this.txtDiagPasswd = new TextBox();
            this.lblDiagPasswd = new Label();
            this.tabNVBackupRestore = new TabPage();
            this.gbNVItems = new GroupBox();
            this.gbNVIOptions = new GroupBox();
            this.chkEnableCstNVIRange = new CheckBox();
            this.chkEnableNVISkip = new CheckBox();
            this.gbNVIRange = new GroupBox();
            this.gbCustomRange = new GroupBox();
            this.txtNVI = new TextBox();
            this.lblNVI = new Label();
            this.lblCustomNVIList = new Label();
            this.cbCustomNVIList = new ComboBox();
            this.btnClearNVI = new Button();
            this.btnRemoveNVI = new Button();
            this.btnAddNVI = new Button();
            this.gbRangeHex = new GroupBox();
            this.txtToHex = new TextBox();
            this.txtFromHex = new TextBox();
            this.lblToHex = new Label();
            this.lblFromHex = new Label();
            this.gbRangeDec = new GroupBox();
            this.txtToDec = new TextBox();
            this.txtFromDec = new TextBox();
            this.lblToDec = new Label();
            this.lblFromDec = new Label();
            this.gbSkipNVItems = new GroupBox();
            this.btnViewNVSkipProfile = new Button();
            this.btnRefreshNVISkipList = new Button();
            this.lblCurrProfile = new Label();
            this.cbNVItemSkipList = new ComboBox();
            this.btnRestoreNVItems = new Button();
            this.btnBackupNVItems = new Button();
            this.btnCancel = new Button();
            this.gbCheckNVStatus = new GroupBox();
            this.txtCompleteNV = new TextBox();
            this.txtInactiveNV = new TextBox();
            this.lblCompleteNV = new Label();
            this.lblInactiveNV = new Label();
            this.txtBadSecNV = new TextBox();
            this.txtBadParamNV = new TextBox();
            this.lblBadSecNV = new Label();
            this.lblBadParamNV = new Label();
            this.tabTerminal = new TabPage();
            this.gbQCDMCmdTerm = new GroupBox();
            this.chkCRC7E = new CheckBox();
            this.cbDiagCmds = new ComboBox();
            this.btnSendQCDM = new Button();
            this.lblDiagCmds = new Label();
            this.lblNVItems = new Label();
            this.cbNVItems = new ComboBox();
            this.lblQCDMFormat = new Label();
            this.lbl7E = new Label();
            this.lblPlus = new Label();
            this.lblCRC = new Label();
            this.txtQCDMCmd = new TextBox();
            this.gbATCmdTerm = new GroupBox();
            this.cbATCmds = new ComboBox();
            this.lblATCmds = new Label();
            this.lblATFormat = new Label();
            this.btnSendAT = new Button();
            this.txtATCmd = new TextBox();
            this.gbTermResponse = new GroupBox();
            this.lblErrResponse = new Label();
            this.txtErrResponse = new TextBox();
            this.btnClearTerm = new Button();
            this.lblResponseLEN = new Label();
            this.txtResponseLEN = new TextBox();
            this.txtTermResponse = new TextBox();
            this.tabConsole = new TabPage();
            this.btnClear = new Button();
            this.rtConsole = new RichTextBox();
            this.tsActivityRX = new ToolStripStatusLabel();
            this.tsActivityTX = new ToolStripStatusLabel();
            this.tsStatus = new ToolStripStatusLabel();
            this.ssQCStatus = new StatusStrip();
            this.tsProgress = new ToolStripProgressBar();
            this.btnDonate = new Button();
            this.tmrActivityTX = new System.Windows.Forms.Timer(this.components);
            this.tmrActivityRX = new System.Windows.Forms.Timer(this.components);
            this.TimerIn = new System.Windows.Forms.Timer(this.components);
            this.TimerOut = new System.Windows.Forms.Timer(this.components);
            this.lblVersionInfo = new Label();
            this.gbConnSettings.SuspendLayout();
            this.gbPhoneMode.SuspendLayout();
            this.tabDiagnosticTools.SuspendLayout();
            this.gbDiagVerInfo.SuspendLayout();
            this.gbPhoneVerInfo.SuspendLayout();
            this.tcQCDMOptions.SuspendLayout();
            this.tabSecureOps.SuspendLayout();
            this.gbSPCLock.SuspendLayout();
            this.gbESNMEID.SuspendLayout();
            this.gbTarget.SuspendLayout();
            this.gbSource.SuspendLayout();
            this.gbDiagPasswd.SuspendLayout();
            this.tabNVBackupRestore.SuspendLayout();
            this.gbNVItems.SuspendLayout();
            this.gbNVIOptions.SuspendLayout();
            this.gbNVIRange.SuspendLayout();
            this.gbCustomRange.SuspendLayout();
            this.gbRangeHex.SuspendLayout();
            this.gbRangeDec.SuspendLayout();
            this.gbSkipNVItems.SuspendLayout();
            this.gbCheckNVStatus.SuspendLayout();
            this.tabTerminal.SuspendLayout();
            this.gbQCDMCmdTerm.SuspendLayout();
            this.gbATCmdTerm.SuspendLayout();
            this.gbTermResponse.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.ssQCStatus.SuspendLayout();
            this.SuspendLayout();
            this.gbConnSettings.Controls.Add(this.chkSendSPC);
            this.gbConnSettings.Controls.Add(this.chkReadPhone);
            this.gbConnSettings.Controls.Add(this.txtSendSPC);
            this.gbConnSettings.Controls.Add(this.gbPhoneMode);
            this.gbConnSettings.Controls.Add(this.lblAvailCOMPorts);
            this.gbConnSettings.Controls.Add(this.cbCOMPorts);
            this.gbConnSettings.Controls.Add(this.btnRefresh);
            this.gbConnSettings.Controls.Add(this.btnConnect);
            this.gbConnSettings.Controls.Add(this.btnDisconnect);
            Point point2 = new Point(13, 4);
            this.gbConnSettings.Location = point2;
            this.gbConnSettings.Name = "gbConnSettings";
            Size size2 = new Size(0x1fc, 0x6c);
            this.gbConnSettings.Size = size2;
            this.gbConnSettings.TabIndex = 0x74;
            this.gbConnSettings.TabStop = false;
            this.gbConnSettings.Text = "Connection Settings:";
            this.chkSendSPC.AutoSize = true;
            this.chkSendSPC.Checked = true;
            this.chkSendSPC.CheckState = CheckState.Checked;
            point2 = new Point(0x145, 0x54);
            this.chkSendSPC.Location = point2;
            this.chkSendSPC.Name = "chkSendSPC";
            size2 = new Size(0x4b, 0x11);
            this.chkSendSPC.Size = size2;
            this.chkSendSPC.TabIndex = 0x33;
            this.chkSendSPC.Text = "Send SPC";
            this.chkSendSPC.UseVisualStyleBackColor = true;
            this.chkReadPhone.AutoSize = true;
            this.chkReadPhone.Checked = true;
            this.chkReadPhone.CheckState = CheckState.Checked;
            point2 = new Point(0x1a0, 0x54);
            this.chkReadPhone.Location = point2;
            this.chkReadPhone.Name = "chkReadPhone";
            size2 = new Size(0x56, 0x11);
            this.chkReadPhone.Size = size2;
            this.chkReadPhone.TabIndex = 0x70;
            this.chkReadPhone.Text = "Read Phone";
            this.chkReadPhone.UseVisualStyleBackColor = true;
            point2 = new Point(0x107, 0x52);
            this.txtSendSPC.Location = point2;
            this.txtSendSPC.MaxLength = 6;
            this.txtSendSPC.Name = "txtSendSPC";
            size2 = new Size(0x38, 20);
            this.txtSendSPC.Size = size2;
            this.txtSendSPC.TabIndex = 50;
            this.txtSendSPC.Text = "000000";
            this.txtSendSPC.TextAlign = HorizontalAlignment.Center;
            this.gbPhoneMode.Controls.Add(this.btnChangeMode);
            this.gbPhoneMode.Controls.Add(this.cbConnMode);
            this.gbPhoneMode.Enabled = false;
            point2 = new Point(6, 0x33);
            this.gbPhoneMode.Location = point2;
            this.gbPhoneMode.Name = "gbPhoneMode";
            size2 = new Size(0xfb, 0x33);
            this.gbPhoneMode.Size = size2;
            this.gbPhoneMode.TabIndex = 0x6f;
            this.gbPhoneMode.TabStop = false;
            this.gbPhoneMode.Text = "Phone Mode:";
            point2 = new Point(0x9b, 0x11);
            this.btnChangeMode.Location = point2;
            this.btnChangeMode.Name = "btnChangeMode";
            size2 = new Size(90, 0x17);
            this.btnChangeMode.Size = size2;
            this.btnChangeMode.TabIndex = 0x29;
            this.btnChangeMode.Text = "Change Mode";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.cbConnMode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbConnMode.FormattingEnabled = true;
            this.cbConnMode.Items.AddRange(new object[] { "Offline Analog Mode", "Offline Digital Mode", "Reset", "Offline Factory Test Mode", "Online Mode", "Low Power Mode", "Power Off Mode", "Download Mode" });
            point2 = new Point(6, 0x12);
            this.cbConnMode.Location = point2;
            this.cbConnMode.Name = "cbConnMode";
            size2 = new Size(0x8f, 0x15);
            this.cbConnMode.Size = size2;
            this.cbConnMode.TabIndex = 0x66;
            this.lblAvailCOMPorts.AutoSize = true;
            point2 = new Point(6, 0x1b);
            this.lblAvailCOMPorts.Location = point2;
            this.lblAvailCOMPorts.Name = "lblAvailCOMPorts";
            size2 = new Size(0x6b, 13);
            this.lblAvailCOMPorts.Size = size2;
            this.lblAvailCOMPorts.TabIndex = 0x3a;
            this.lblAvailCOMPorts.Text = "Available COM Ports:";
            this.cbCOMPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCOMPorts.FormattingEnabled = true;
            point2 = new Point(0x77, 0x18);
            this.cbCOMPorts.Location = point2;
            this.cbCOMPorts.Name = "cbCOMPorts";
            size2 = new Size(0x134, 0x15);
            this.cbCOMPorts.Size = size2;
            this.cbCOMPorts.TabIndex = 3;
            point2 = new Point(0x1b1, 0x17);
            this.btnRefresh.Location = point2;
            this.btnRefresh.Name = "btnRefresh";
            size2 = new Size(0x45, 0x17);
            this.btnRefresh.Size = size2;
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            point2 = new Point(0x107, 0x38);
            this.btnConnect.Location = point2;
            this.btnConnect.Name = "btnConnect";
            size2 = new Size(0x72, 0x17);
            this.btnConnect.Size = size2;
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Enabled = false;
            point2 = new Point(0x184, 0x38);
            this.btnDisconnect.Location = point2;
            this.btnDisconnect.Name = "btnDisconnect";
            size2 = new Size(0x72, 0x17);
            this.btnDisconnect.Size = size2;
            this.btnDisconnect.TabIndex = 0x39;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.tabDiagnosticTools.Controls.Add(this.gbDiagVerInfo);
            this.tabDiagnosticTools.Controls.Add(this.btnReadPhoneInfo);
            this.tabDiagnosticTools.Controls.Add(this.gbPhoneVerInfo);
            point2 = new Point(4, 0x16);
            this.tabDiagnosticTools.Location = point2;
            this.tabDiagnosticTools.Name = "tabDiagnosticTools";
            Padding padding2 = new Padding(3);
            this.tabDiagnosticTools.Padding = padding2;
            size2 = new Size(0x20f, 0x1a8);
            this.tabDiagnosticTools.Size = size2;
            this.tabDiagnosticTools.TabIndex = 0;
            this.tabDiagnosticTools.Text = "Diagnostic Tools";
            this.tabDiagnosticTools.UseVisualStyleBackColor = true;
            this.gbDiagVerInfo.Controls.Add(this.lblSlotCycleIndex);
            this.gbDiagVerInfo.Controls.Add(this.txtSlotCycleIndex);
            this.gbDiagVerInfo.Controls.Add(this.lblMobFWRev);
            this.gbDiagVerInfo.Controls.Add(this.txtMobFWRev);
            this.gbDiagVerInfo.Controls.Add(this.lblMobModel);
            this.gbDiagVerInfo.Controls.Add(this.txtMobModel);
            this.gbDiagVerInfo.Controls.Add(this.lblMobCAIRev);
            this.gbDiagVerInfo.Controls.Add(this.txtMobCAIRev);
            this.gbDiagVerInfo.Controls.Add(this.lblMSMRev);
            this.gbDiagVerInfo.Controls.Add(this.txtMSMRev);
            this.gbDiagVerInfo.Controls.Add(this.txtCompiled);
            this.gbDiagVerInfo.Controls.Add(this.txtVersionDir);
            this.gbDiagVerInfo.Controls.Add(this.lblVersionDir);
            this.gbDiagVerInfo.Controls.Add(this.lblCompiled);
            this.gbDiagVerInfo.Controls.Add(this.lblStationClassMark);
            this.gbDiagVerInfo.Controls.Add(this.txtReleased);
            this.gbDiagVerInfo.Controls.Add(this.txtStationClassMark);
            this.gbDiagVerInfo.Controls.Add(this.lblReleased);
            point2 = new Point(9, 6);
            this.gbDiagVerInfo.Location = point2;
            this.gbDiagVerInfo.Name = "gbDiagVerInfo";
            size2 = new Size(0x1fc, 260);
            this.gbDiagVerInfo.Size = size2;
            this.gbDiagVerInfo.TabIndex = 0x74;
            this.gbDiagVerInfo.TabStop = false;
            this.gbDiagVerInfo.Text = "Diagnostic Version Info:";
            this.lblSlotCycleIndex.AutoSize = true;
            point2 = new Point(0x79, 0xcc);
            this.lblSlotCycleIndex.Location = point2;
            this.lblSlotCycleIndex.Name = "lblSlotCycleIndex";
            size2 = new Size(0x70, 13);
            this.lblSlotCycleIndex.Size = size2;
            this.lblSlotCycleIndex.TabIndex = 0x19;
            this.lblSlotCycleIndex.Text = "Slot Cycle Index (SCI):";
            point2 = new Point(0xef, 0xc9);
            this.txtSlotCycleIndex.Location = point2;
            this.txtSlotCycleIndex.Name = "txtSlotCycleIndex";
            this.txtSlotCycleIndex.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtSlotCycleIndex.Size = size2;
            this.txtSlotCycleIndex.TabIndex = 0x18;
            this.lblMobFWRev.AutoSize = true;
            point2 = new Point(0x67, 0xb2);
            this.lblMobFWRev.Location = point2;
            this.lblMobFWRev.Name = "lblMobFWRev";
            size2 = new Size(130, 13);
            this.lblMobFWRev.Size = size2;
            this.lblMobFWRev.TabIndex = 0x17;
            this.lblMobFWRev.Text = "Mobile Firmware Revision:";
            point2 = new Point(0xef, 0xaf);
            this.txtMobFWRev.Location = point2;
            this.txtMobFWRev.Name = "txtMobFWRev";
            this.txtMobFWRev.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtMobFWRev.Size = size2;
            this.txtMobFWRev.TabIndex = 0x16;
            this.lblMobModel.AutoSize = true;
            point2 = new Point(160, 0x98);
            this.lblMobModel.Location = point2;
            this.lblMobModel.Name = "lblMobModel";
            size2 = new Size(0x49, 13);
            this.lblMobModel.Size = size2;
            this.lblMobModel.TabIndex = 0x15;
            this.lblMobModel.Text = "Mobile Model:";
            point2 = new Point(0xef, 0x95);
            this.txtMobModel.Location = point2;
            this.txtMobModel.Name = "txtMobModel";
            this.txtMobModel.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtMobModel.Size = size2;
            this.txtMobModel.TabIndex = 20;
            this.lblMobCAIRev.AutoSize = true;
            point2 = new Point(0x80, 0x7e);
            this.lblMobCAIRev.Location = point2;
            this.lblMobCAIRev.Name = "lblMobCAIRev";
            size2 = new Size(0x69, 13);
            this.lblMobCAIRev.Size = size2;
            this.lblMobCAIRev.TabIndex = 0x13;
            this.lblMobCAIRev.Text = "Mobile CAI Revision:";
            point2 = new Point(0xef, 0x7b);
            this.txtMobCAIRev.Location = point2;
            this.txtMobCAIRev.Name = "txtMobCAIRev";
            this.txtMobCAIRev.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtMobCAIRev.Size = size2;
            this.txtMobCAIRev.TabIndex = 0x12;
            this.lblMSMRev.AutoSize = true;
            point2 = new Point(0x9a, 230);
            this.lblMSMRev.Location = point2;
            this.lblMSMRev.Name = "lblMSMRev";
            size2 = new Size(0x4f, 13);
            this.lblMSMRev.Size = size2;
            this.lblMSMRev.TabIndex = 0x11;
            this.lblMSMRev.Text = "MSM Revision:";
            point2 = new Point(0xef, 0xe3);
            this.txtMSMRev.Location = point2;
            this.txtMSMRev.Name = "txtMSMRev";
            this.txtMSMRev.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtMSMRev.Size = size2;
            this.txtMSMRev.TabIndex = 0x10;
            point2 = new Point(0xef, 0x13);
            this.txtCompiled.Location = point2;
            this.txtCompiled.Name = "txtCompiled";
            this.txtCompiled.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtCompiled.Size = size2;
            this.txtCompiled.TabIndex = 10;
            point2 = new Point(0xef, 0x47);
            this.txtVersionDir.Location = point2;
            this.txtVersionDir.Name = "txtVersionDir";
            this.txtVersionDir.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtVersionDir.Size = size2;
            this.txtVersionDir.TabIndex = 8;
            this.lblVersionDir.AutoSize = true;
            point2 = new Point(0x8f, 0x4a);
            this.lblVersionDir.Location = point2;
            this.lblVersionDir.Name = "lblVersionDir";
            size2 = new Size(90, 13);
            this.lblVersionDir.Size = size2;
            this.lblVersionDir.TabIndex = 9;
            this.lblVersionDir.Text = "Version Directory:";
            this.lblCompiled.AutoSize = true;
            point2 = new Point(180, 0x16);
            this.lblCompiled.Location = point2;
            this.lblCompiled.Name = "lblCompiled";
            size2 = new Size(0x35, 13);
            this.lblCompiled.Size = size2;
            this.lblCompiled.TabIndex = 11;
            this.lblCompiled.Text = "Compiled:";
            this.lblStationClassMark.AutoSize = true;
            point2 = new Point(0x67, 100);
            this.lblStationClassMark.Location = point2;
            this.lblStationClassMark.Name = "lblStationClassMark";
            size2 = new Size(130, 13);
            this.lblStationClassMark.Size = size2;
            this.lblStationClassMark.TabIndex = 15;
            this.lblStationClassMark.Text = "Station Class Mark (SCM):";
            point2 = new Point(0xef, 0x2d);
            this.txtReleased.Location = point2;
            this.txtReleased.Name = "txtReleased";
            this.txtReleased.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtReleased.Size = size2;
            this.txtReleased.TabIndex = 12;
            point2 = new Point(0xef, 0x61);
            this.txtStationClassMark.Location = point2;
            this.txtStationClassMark.Name = "txtStationClassMark";
            this.txtStationClassMark.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtStationClassMark.Size = size2;
            this.txtStationClassMark.TabIndex = 14;
            this.lblReleased.AutoSize = true;
            point2 = new Point(0xb2, 0x30);
            this.lblReleased.Location = point2;
            this.lblReleased.Name = "lblReleased";
            size2 = new Size(0x37, 13);
            this.lblReleased.Size = size2;
            this.lblReleased.TabIndex = 13;
            this.lblReleased.Text = "Released:";
            point2 = new Point(0xb1, 390);
            this.btnReadPhoneInfo.Location = point2;
            this.btnReadPhoneInfo.Name = "btnReadPhoneInfo";
            size2 = new Size(0xac, 0x17);
            this.btnReadPhoneInfo.Size = size2;
            this.btnReadPhoneInfo.TabIndex = 0x73;
            this.btnReadPhoneInfo.Text = "Read Phone Info";
            this.btnReadPhoneInfo.UseVisualStyleBackColor = true;
            this.gbPhoneVerInfo.Controls.Add(this.lblMobModelID);
            this.gbPhoneVerInfo.Controls.Add(this.txtMobModelID);
            this.gbPhoneVerInfo.Controls.Add(this.lblMSMHWRev);
            this.gbPhoneVerInfo.Controls.Add(this.txtMSMHWVer);
            this.gbPhoneVerInfo.Controls.Add(this.lblMobSWRev);
            this.gbPhoneVerInfo.Controls.Add(this.txtVersionString);
            point2 = new Point(9, 0x110);
            this.gbPhoneVerInfo.Location = point2;
            this.gbPhoneVerInfo.Name = "gbPhoneVerInfo";
            size2 = new Size(0x1fc, 0x69);
            this.gbPhoneVerInfo.Size = size2;
            this.gbPhoneVerInfo.TabIndex = 0x71;
            this.gbPhoneVerInfo.TabStop = false;
            this.gbPhoneVerInfo.Text = "Extended Build Info:";
            this.lblMobModelID.AutoSize = true;
            point2 = new Point(0x92, 0x30);
            this.lblMobModelID.Location = point2;
            this.lblMobModelID.Name = "lblMobModelID";
            size2 = new Size(0x57, 13);
            this.lblMobModelID.Size = size2;
            this.lblMobModelID.TabIndex = 0x13;
            this.lblMobModelID.Text = "Mobile Model ID:";
            point2 = new Point(0xef, 0x2d);
            this.txtMobModelID.Location = point2;
            this.txtMobModelID.Name = "txtMobModelID";
            this.txtMobModelID.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtMobModelID.Size = size2;
            this.txtMobModelID.TabIndex = 0x12;
            this.lblMSMHWRev.AutoSize = true;
            point2 = new Point(0x69, 0x16);
            this.lblMSMHWRev.Location = point2;
            this.lblMSMHWRev.Name = "lblMSMHWRev";
            size2 = new Size(0x80, 13);
            this.lblMSMHWRev.Size = size2;
            this.lblMSMHWRev.TabIndex = 0x11;
            this.lblMSMHWRev.Text = "MSM Hardware Revision:";
            point2 = new Point(0xef, 0x13);
            this.txtMSMHWVer.Location = point2;
            this.txtMSMHWVer.Name = "txtMSMHWVer";
            this.txtMSMHWVer.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtMSMHWVer.Size = size2;
            this.txtMSMHWVer.TabIndex = 0x10;
            this.lblMobSWRev.AutoSize = true;
            point2 = new Point(0x67, 0x4a);
            this.lblMobSWRev.Location = point2;
            this.lblMobSWRev.Name = "lblMobSWRev";
            size2 = new Size(130, 13);
            this.lblMobSWRev.Size = size2;
            this.lblMobSWRev.TabIndex = 3;
            this.lblMobSWRev.Text = "Mobile Software Revision:";
            point2 = new Point(0xef, 0x47);
            this.txtVersionString.Location = point2;
            this.txtVersionString.Name = "txtVersionString";
            this.txtVersionString.ReadOnly = true;
            size2 = new Size(0xac, 20);
            this.txtVersionString.Size = size2;
            this.txtVersionString.TabIndex = 2;
            this.tcQCDMOptions.Controls.Add(this.tabDiagnosticTools);
            this.tcQCDMOptions.Controls.Add(this.tabSecureOps);
            this.tcQCDMOptions.Controls.Add(this.tabNVBackupRestore);
            this.tcQCDMOptions.Controls.Add(this.tabTerminal);
            this.tcQCDMOptions.Controls.Add(this.tabConsole);
            point2 = new Point(0, 0x76);
            this.tcQCDMOptions.Location = point2;
            this.tcQCDMOptions.Name = "tcQCDMOptions";
            this.tcQCDMOptions.SelectedIndex = 0;
            size2 = new Size(0x217, 450);
            this.tcQCDMOptions.Size = size2;
            this.tcQCDMOptions.TabIndex = 0x76;
            this.tabSecureOps.Controls.Add(this.gbSPCLock);
            this.tabSecureOps.Controls.Add(this.gbESNMEID);
            this.tabSecureOps.Controls.Add(this.gbDiagPasswd);
            point2 = new Point(4, 0x16);
            this.tabSecureOps.Location = point2;
            this.tabSecureOps.Name = "tabSecureOps";
            padding2 = new Padding(3);
            this.tabSecureOps.Padding = padding2;
            size2 = new Size(0x20f, 0x1a8);
            this.tabSecureOps.Size = size2;
            this.tabSecureOps.TabIndex = 3;
            this.tabSecureOps.Text = "Secure Ops.";
            this.tabSecureOps.UseVisualStyleBackColor = true;
            this.gbSPCLock.Controls.Add(this.btnWriteLockCode);
            this.gbSPCLock.Controls.Add(this.btnReadSPC);
            this.gbSPCLock.Controls.Add(this.txtSPC);
            this.gbSPCLock.Controls.Add(this.btnSendSPC);
            this.gbSPCLock.Controls.Add(this.txtLockCode);
            this.gbSPCLock.Controls.Add(this.btnReadLockCode);
            this.gbSPCLock.Controls.Add(this.btnWriteSPC);
            point2 = new Point(9, 0x48);
            this.gbSPCLock.Location = point2;
            this.gbSPCLock.Name = "gbSPCLock";
            size2 = new Size(0x1fc, 0x55);
            this.gbSPCLock.Size = size2;
            this.gbSPCLock.TabIndex = 0x76;
            this.gbSPCLock.TabStop = false;
            this.gbSPCLock.Text = "Service Programming Code (SPC) / Lock Code:";
            point2 = new Point(0xee, 0x30);
            this.btnWriteLockCode.Location = point2;
            this.btnWriteLockCode.Name = "btnWriteLockCode";
            size2 = new Size(0x72, 0x17);
            this.btnWriteLockCode.Size = size2;
            this.btnWriteLockCode.TabIndex = 100;
            this.btnWriteLockCode.Text = "Write Lock Code";
            this.btnWriteLockCode.UseVisualStyleBackColor = true;
            point2 = new Point(0x76, 0x13);
            this.btnReadSPC.Location = point2;
            this.btnReadSPC.Name = "btnReadSPC";
            size2 = new Size(0x72, 0x17);
            this.btnReadSPC.Size = size2;
            this.btnReadSPC.TabIndex = 0x30;
            this.btnReadSPC.Text = "Read SPC";
            this.btnReadSPC.UseVisualStyleBackColor = true;
            point2 = new Point(0x25, 0x15);
            this.txtSPC.Location = point2;
            this.txtSPC.MaxLength = 6;
            this.txtSPC.Name = "txtSPC";
            size2 = new Size(0x4b, 20);
            this.txtSPC.Size = size2;
            this.txtSPC.TabIndex = 0x31;
            this.txtSPC.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0x166, 0x13);
            this.btnSendSPC.Location = point2;
            this.btnSendSPC.Name = "btnSendSPC";
            size2 = new Size(0x72, 0x17);
            this.btnSendSPC.Size = size2;
            this.btnSendSPC.TabIndex = 0x62;
            this.btnSendSPC.Text = "Send SPC";
            this.btnSendSPC.UseVisualStyleBackColor = true;
            point2 = new Point(0x25, 50);
            this.txtLockCode.Location = point2;
            this.txtLockCode.MaxLength = 4;
            this.txtLockCode.Name = "txtLockCode";
            size2 = new Size(0x4b, 20);
            this.txtLockCode.Size = size2;
            this.txtLockCode.TabIndex = 0x43;
            this.txtLockCode.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0x76, 0x30);
            this.btnReadLockCode.Location = point2;
            this.btnReadLockCode.Name = "btnReadLockCode";
            size2 = new Size(0x72, 0x17);
            this.btnReadLockCode.Size = size2;
            this.btnReadLockCode.TabIndex = 0x42;
            this.btnReadLockCode.Text = "Read Lock Code";
            this.btnReadLockCode.UseVisualStyleBackColor = true;
            point2 = new Point(0xee, 0x13);
            this.btnWriteSPC.Location = point2;
            this.btnWriteSPC.Name = "btnWriteSPC";
            size2 = new Size(0x72, 0x17);
            this.btnWriteSPC.Size = size2;
            this.btnWriteSPC.TabIndex = 0x63;
            this.btnWriteSPC.Text = "Write SPC";
            this.btnWriteSPC.UseVisualStyleBackColor = true;
            this.gbESNMEID.Controls.Add(this.chkIMEI);
            this.gbESNMEID.Controls.Add(this.gbTarget);
            this.gbESNMEID.Controls.Add(this.chkMEID);
            this.gbESNMEID.Controls.Add(this.gbSource);
            this.gbESNMEID.Controls.Add(this.chkESN);
            this.gbESNMEID.Controls.Add(this.txtIMEIFlipped);
            this.gbESNMEID.Controls.Add(this.lblIMEIFlipped);
            this.gbESNMEID.Controls.Add(this.lblMEIDhex);
            this.gbESNMEID.Controls.Add(this.txtIMEIdec);
            this.gbESNMEID.Controls.Add(this.txtMEIDFlipped);
            this.gbESNMEID.Controls.Add(this.lblIMEIdec);
            this.gbESNMEID.Controls.Add(this.txtMEIDhex);
            this.gbESNMEID.Controls.Add(this.lblESNhex);
            this.gbESNMEID.Controls.Add(this.txtESNhex);
            this.gbESNMEID.Controls.Add(this.lblMEIDFlipped);
            this.gbESNMEID.Controls.Add(this.txtESNFlipped);
            this.gbESNMEID.Controls.Add(this.lblESNFlipped);
            point2 = new Point(9, 0xa3);
            this.gbESNMEID.Location = point2;
            this.gbESNMEID.Name = "gbESNMEID";
            size2 = new Size(0x1fc, 0xae);
            this.gbESNMEID.Size = size2;
            this.gbESNMEID.TabIndex = 0x75;
            this.gbESNMEID.TabStop = false;
            this.gbESNMEID.Text = "ESN / MEID / IMEI Repair:";
            this.chkIMEI.AutoSize = true;
            point2 = new Point(15, 0x4a);
            this.chkIMEI.Location = point2;
            this.chkIMEI.Name = "chkIMEI";
            size2 = new Size(15, 14);
            this.chkIMEI.Size = size2;
            this.chkIMEI.TabIndex = 60;
            this.chkIMEI.UseVisualStyleBackColor = true;
            this.gbTarget.Controls.Add(this.cbTarget);
            this.gbTarget.Controls.Add(this.btnWriteEMI);
            point2 = new Point(0x112, 0x66);
            this.gbTarget.Location = point2;
            this.gbTarget.Name = "gbTarget";
            size2 = new Size(220, 0x3a);
            this.gbTarget.Size = size2;
            this.gbTarget.TabIndex = 0x36;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target:";
            this.cbTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbTarget.FormattingEnabled = true;
            this.cbTarget.Items.AddRange(new object[] { "Phone", "QPST - QCN Backup", "CDMA Workshop Patch" });
            point2 = new Point(6, 0x15);
            this.cbTarget.Location = point2;
            this.cbTarget.Name = "cbTarget";
            size2 = new Size(0x93, 0x15);
            this.cbTarget.Size = size2;
            this.cbTarget.TabIndex = 0x74;
            point2 = new Point(0x9f, 20);
            this.btnWriteEMI.Location = point2;
            this.btnWriteEMI.Name = "btnWriteEMI";
            size2 = new Size(0x37, 0x17);
            this.btnWriteEMI.Size = size2;
            this.btnWriteEMI.TabIndex = 0x34;
            this.btnWriteEMI.Text = "Write";
            this.btnWriteEMI.UseVisualStyleBackColor = true;
            this.chkMEID.AutoSize = true;
            point2 = new Point(15, 0x30);
            this.chkMEID.Location = point2;
            this.chkMEID.Name = "chkMEID";
            size2 = new Size(15, 14);
            this.chkMEID.Size = size2;
            this.chkMEID.TabIndex = 0x3b;
            this.chkMEID.UseVisualStyleBackColor = true;
            this.gbSource.Controls.Add(this.cbSource);
            this.gbSource.Controls.Add(this.btnReadEMI);
            point2 = new Point(15, 0x66);
            this.gbSource.Location = point2;
            this.gbSource.Name = "gbSource";
            size2 = new Size(220, 0x3a);
            this.gbSource.Size = size2;
            this.gbSource.TabIndex = 0x35;
            this.gbSource.TabStop = false;
            this.gbSource.Text = "Source:";
            this.cbSource.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] { "Phone", "QPST - QCN Backup" });
            point2 = new Point(6, 0x15);
            this.cbSource.Location = point2;
            this.cbSource.Name = "cbSource";
            size2 = new Size(0x92, 0x15);
            this.cbSource.Size = size2;
            this.cbSource.TabIndex = 0x73;
            point2 = new Point(0x9e, 20);
            this.btnReadEMI.Location = point2;
            this.btnReadEMI.Name = "btnReadEMI";
            size2 = new Size(0x38, 0x17);
            this.btnReadEMI.Size = size2;
            this.btnReadEMI.TabIndex = 0x31;
            this.btnReadEMI.Text = "Read IMEI";
            this.btnReadEMI.UseVisualStyleBackColor = true;
            this.chkESN.AutoSize = true;
            point2 = new Point(15, 0x16);
            this.chkESN.Location = point2;
            this.chkESN.Name = "chkESN";
            size2 = new Size(15, 14);
            this.chkESN.Size = size2;
            this.chkESN.TabIndex = 0x3a;
            this.chkESN.UseVisualStyleBackColor = true;
            point2 = new Point(0x15f, 0x47);
            this.txtIMEIFlipped.Location = point2;
            this.txtIMEIFlipped.Name = "txtIMEIFlipped";
            this.txtIMEIFlipped.ReadOnly = true;
            size2 = new Size(0x8f, 20);
            this.txtIMEIFlipped.Size = size2;
            this.txtIMEIFlipped.TabIndex = 0x33;
            this.txtIMEIFlipped.TextAlign = HorizontalAlignment.Center;
            this.lblIMEIFlipped.AutoSize = true;
            point2 = new Point(0x109, 0x4a);
            this.lblIMEIFlipped.Location = point2;
            this.lblIMEIFlipped.Name = "lblIMEIFlipped";
            size2 = new Size(0x4b, 13);
            this.lblIMEIFlipped.Size = size2;
            this.lblIMEIFlipped.TabIndex = 50;
            this.lblIMEIFlipped.Text = "IMEI (Flipped):";
            this.lblMEIDhex.AutoSize = true;
            point2 = new Point(40, 0x30);
            this.lblMEIDhex.Location = point2;
            this.lblMEIDhex.Name = "lblMEIDhex";
            size2 = new Size(0x41, 13);
            this.lblMEIDhex.Size = size2;
            this.lblMEIDhex.TabIndex = 4;
            this.lblMEIDhex.Text = "MEID (Hex):";
            point2 = new Point(0x70, 0x47);
            this.txtIMEIdec.Location = point2;
            this.txtIMEIdec.MaxLength = 15;
            this.txtIMEIdec.Name = "txtIMEIdec";
            size2 = new Size(0x8f, 20);
            this.txtIMEIdec.Size = size2;
            this.txtIMEIdec.TabIndex = 1;
            this.txtIMEIdec.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0x15f, 0x2d);
            this.txtMEIDFlipped.Location = point2;
            this.txtMEIDFlipped.MaxLength = 15;
            this.txtMEIDFlipped.Name = "txtMEIDFlipped";
            this.txtMEIDFlipped.ReadOnly = true;
            size2 = new Size(0x8f, 20);
            this.txtMEIDFlipped.Size = size2;
            this.txtMEIDFlipped.TabIndex = 0x37;
            this.txtMEIDFlipped.TextAlign = HorizontalAlignment.Center;
            this.lblIMEIdec.AutoSize = true;
            point2 = new Point(40, 0x4a);
            this.lblIMEIdec.Location = point2;
            this.lblIMEIdec.Name = "lblIMEIdec";
            size2 = new Size(0x3d, 13);
            this.lblIMEIdec.Size = size2;
            this.lblIMEIdec.TabIndex = 0;
            this.lblIMEIdec.Text = "IMEI (Dec):";
            point2 = new Point(0x70, 0x2d);
            this.txtMEIDhex.Location = point2;
            this.txtMEIDhex.MaxLength = 14;
            this.txtMEIDhex.Name = "txtMEIDhex";
            size2 = new Size(0x8f, 20);
            this.txtMEIDhex.Size = size2;
            this.txtMEIDhex.TabIndex = 5;
            this.txtMEIDhex.TextAlign = HorizontalAlignment.Center;
            this.lblESNhex.AutoSize = true;
            point2 = new Point(40, 0x16);
            this.lblESNhex.Location = point2;
            this.lblESNhex.Name = "lblESNhex";
            size2 = new Size(60, 13);
            this.lblESNhex.Size = size2;
            this.lblESNhex.TabIndex = 2;
            this.lblESNhex.Text = "ESN (Hex):";
            point2 = new Point(0x70, 0x13);
            this.txtESNhex.Location = point2;
            this.txtESNhex.MaxLength = 8;
            this.txtESNhex.Name = "txtESNhex";
            size2 = new Size(0x8f, 20);
            this.txtESNhex.Size = size2;
            this.txtESNhex.TabIndex = 3;
            this.txtESNhex.TextAlign = HorizontalAlignment.Center;
            this.lblMEIDFlipped.AutoSize = true;
            point2 = new Point(0x109, 0x30);
            this.lblMEIDFlipped.Location = point2;
            this.lblMEIDFlipped.Name = "lblMEIDFlipped";
            size2 = new Size(80, 13);
            this.lblMEIDFlipped.Size = size2;
            this.lblMEIDFlipped.TabIndex = 0x36;
            this.lblMEIDFlipped.Text = "MEID (Flipped):";
            point2 = new Point(0x15f, 0x13);
            this.txtESNFlipped.Location = point2;
            this.txtESNFlipped.MaxLength = 15;
            this.txtESNFlipped.Name = "txtESNFlipped";
            this.txtESNFlipped.ReadOnly = true;
            size2 = new Size(0x8f, 20);
            this.txtESNFlipped.Size = size2;
            this.txtESNFlipped.TabIndex = 0x35;
            this.txtESNFlipped.TextAlign = HorizontalAlignment.Center;
            this.lblESNFlipped.AutoSize = true;
            point2 = new Point(0x109, 0x16);
            this.lblESNFlipped.Location = point2;
            this.lblESNFlipped.Name = "lblESNFlipped";
            size2 = new Size(0x4b, 13);
            this.lblESNFlipped.Size = size2;
            this.lblESNFlipped.TabIndex = 0x34;
            this.lblESNFlipped.Text = "ESN (Flipped):";
            this.gbDiagPasswd.Controls.Add(this.lblDiagPasswdInfo);
            this.gbDiagPasswd.Controls.Add(this.btnSendDiagPasswd);
            this.gbDiagPasswd.Controls.Add(this.txtDiagPasswd);
            this.gbDiagPasswd.Controls.Add(this.lblDiagPasswd);
            point2 = new Point(9, 6);
            this.gbDiagPasswd.Location = point2;
            this.gbDiagPasswd.Name = "gbDiagPasswd";
            size2 = new Size(0x1fc, 60);
            this.gbDiagPasswd.Size = size2;
            this.gbDiagPasswd.TabIndex = 0x73;
            this.gbDiagPasswd.TabStop = false;
            this.gbDiagPasswd.Text = "Diagnostics Password (16 Digits Hex):";
            this.lblDiagPasswdInfo.AutoSize = true;
            point2 = new Point(0x144, 0x1a);
            this.lblDiagPasswdInfo.Location = point2;
            this.lblDiagPasswdInfo.Name = "lblDiagPasswdInfo";
            size2 = new Size(0xa9, 13);
            this.lblDiagPasswdInfo.Size = size2;
            this.lblDiagPasswdInfo.TabIndex = 0x33;
            this.lblDiagPasswdInfo.Text = "Send to unlock secure operations.";
            point2 = new Point(0x103, 0x15);
            this.btnSendDiagPasswd.Location = point2;
            this.btnSendDiagPasswd.Name = "btnSendDiagPasswd";
            size2 = new Size(0x33, 0x17);
            this.btnSendDiagPasswd.Size = size2;
            this.btnSendDiagPasswd.TabIndex = 50;
            this.btnSendDiagPasswd.Text = "Send";
            this.btnSendDiagPasswd.UseVisualStyleBackColor = true;
            point2 = new Point(110, 0x17);
            this.txtDiagPasswd.Location = point2;
            this.txtDiagPasswd.MaxLength = 0x10;
            this.txtDiagPasswd.Name = "txtDiagPasswd";
            size2 = new Size(0x8f, 20);
            this.txtDiagPasswd.Size = size2;
            this.txtDiagPasswd.TabIndex = 3;
            this.txtDiagPasswd.Text = "FFFFFFFFFFFFFFFF";
            this.txtDiagPasswd.TextAlign = HorizontalAlignment.Center;
            this.lblDiagPasswd.AutoSize = true;
            point2 = new Point(20, 0x1a);
            this.lblDiagPasswd.Location = point2;
            this.lblDiagPasswd.Name = "lblDiagPasswd";
            size2 = new Size(0x54, 13);
            this.lblDiagPasswd.Size = size2;
            this.lblDiagPasswd.TabIndex = 2;
            this.lblDiagPasswd.Text = "Diag. Password:";
            this.tabNVBackupRestore.Controls.Add(this.gbNVItems);
            point2 = new Point(4, 0x16);
            this.tabNVBackupRestore.Location = point2;
            this.tabNVBackupRestore.Name = "tabNVBackupRestore";
            padding2 = new Padding(3);
            this.tabNVBackupRestore.Padding = padding2;
            size2 = new Size(0x20f, 0x1a8);
            this.tabNVBackupRestore.Size = size2;
            this.tabNVBackupRestore.TabIndex = 1;
            this.tabNVBackupRestore.Text = "NV Backup / Restore";
            this.tabNVBackupRestore.UseVisualStyleBackColor = true;
            this.gbNVItems.Controls.Add(this.gbNVIOptions);
            this.gbNVItems.Controls.Add(this.gbNVIRange);
            this.gbNVItems.Controls.Add(this.gbSkipNVItems);
            this.gbNVItems.Controls.Add(this.btnRestoreNVItems);
            this.gbNVItems.Controls.Add(this.btnBackupNVItems);
            this.gbNVItems.Controls.Add(this.btnCancel);
            this.gbNVItems.Controls.Add(this.gbCheckNVStatus);
            point2 = new Point(9, 6);
            this.gbNVItems.Location = point2;
            this.gbNVItems.Name = "gbNVItems";
            size2 = new Size(0x1fc, 0x19c);
            this.gbNVItems.Size = size2;
            this.gbNVItems.TabIndex = 0;
            this.gbNVItems.TabStop = false;
            this.gbNVItems.Text = "NV Items:";
            this.gbNVIOptions.Controls.Add(this.chkEnableCstNVIRange);
            this.gbNVIOptions.Controls.Add(this.chkEnableNVISkip);
            point2 = new Point(6, 0x5f);
            this.gbNVIOptions.Location = point2;
            this.gbNVIOptions.Name = "gbNVIOptions";
            size2 = new Size(0x1f0, 0x2f);
            this.gbNVIOptions.Size = size2;
            this.gbNVIOptions.TabIndex = 0x17;
            this.gbNVIOptions.TabStop = false;
            this.gbNVIOptions.Text = "NV Backup / Restore Options:";
            this.chkEnableCstNVIRange.AutoSize = true;
            point2 = new Point(0x26, 0x13);
            this.chkEnableCstNVIRange.Location = point2;
            this.chkEnableCstNVIRange.Name = "chkEnableCstNVIRange";
            size2 = new Size(0xb2, 0x11);
            this.chkEnableCstNVIRange.Size = size2;
            this.chkEnableCstNVIRange.TabIndex = 1;
            this.chkEnableCstNVIRange.Text = "Enable Custom NV Items Range";
            this.chkEnableCstNVIRange.UseVisualStyleBackColor = true;
            this.chkEnableNVISkip.AutoSize = true;
            point2 = new Point(0x108, 0x13);
            this.chkEnableNVISkip.Location = point2;
            this.chkEnableNVISkip.Name = "chkEnableNVISkip";
            size2 = new Size(0x90, 0x11);
            this.chkEnableNVISkip.Size = size2;
            this.chkEnableNVISkip.TabIndex = 0;
            this.chkEnableNVISkip.Text = "Enable NV Item Skipping";
            this.chkEnableNVISkip.UseVisualStyleBackColor = true;
            this.gbNVIRange.Controls.Add(this.gbCustomRange);
            this.gbNVIRange.Controls.Add(this.gbRangeHex);
            this.gbNVIRange.Controls.Add(this.gbRangeDec);
            point2 = new Point(6, 0x94);
            this.gbNVIRange.Location = point2;
            this.gbNVIRange.Name = "gbNVIRange";
            size2 = new Size(0x1f0, 0x99);
            this.gbNVIRange.Size = size2;
            this.gbNVIRange.TabIndex = 0x16;
            this.gbNVIRange.TabStop = false;
            this.gbNVIRange.Text = "NV Items Range:";
            this.gbCustomRange.Controls.Add(this.txtNVI);
            this.gbCustomRange.Controls.Add(this.lblNVI);
            this.gbCustomRange.Controls.Add(this.lblCustomNVIList);
            this.gbCustomRange.Controls.Add(this.cbCustomNVIList);
            this.gbCustomRange.Controls.Add(this.btnClearNVI);
            this.gbCustomRange.Controls.Add(this.btnRemoveNVI);
            this.gbCustomRange.Controls.Add(this.btnAddNVI);
            point2 = new Point(6, 0x4a);
            this.gbCustomRange.Location = point2;
            this.gbCustomRange.Name = "gbCustomRange";
            size2 = new Size(0x1e4, 0x49);
            this.gbCustomRange.Size = size2;
            this.gbCustomRange.TabIndex = 0x15;
            this.gbCustomRange.TabStop = false;
            this.gbCustomRange.Text = "Custom Range:";
            point2 = new Point(0x8e, 0x2b);
            this.txtNVI.Location = point2;
            this.txtNVI.Name = "txtNVI";
            size2 = new Size(0x5c, 20);
            this.txtNVI.Size = size2;
            this.txtNVI.TabIndex = 0x19;
            this.lblNVI.AutoSize = true;
            point2 = new Point(0x3b, 0x2f);
            this.lblNVI.Location = point2;
            this.lblNVI.Name = "lblNVI";
            size2 = new Size(0x4d, 13);
            this.lblNVI.Size = size2;
            this.lblNVI.TabIndex = 0x18;
            this.lblNVI.Text = "NV Item (Dec):";
            this.lblCustomNVIList.AutoSize = true;
            point2 = new Point(0x1f, 0x12);
            this.lblCustomNVIList.Location = point2;
            this.lblCustomNVIList.Name = "lblCustomNVIList";
            size2 = new Size(0x69, 13);
            this.lblCustomNVIList.Size = size2;
            this.lblCustomNVIList.TabIndex = 0x16;
            this.lblCustomNVIList.Text = "Custom NV Item List:";
            this.cbCustomNVIList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCustomNVIList.FormattingEnabled = true;
            point2 = new Point(0x8e, 15);
            this.cbCustomNVIList.Location = point2;
            this.cbCustomNVIList.Name = "cbCustomNVIList";
            size2 = new Size(0x138, 0x15);
            this.cbCustomNVIList.Size = size2;
            this.cbCustomNVIList.TabIndex = 0x15;
            point2 = new Point(0x182, 0x2a);
            this.btnClearNVI.Location = point2;
            this.btnClearNVI.Name = "btnClearNVI";
            size2 = new Size(0x44, 0x16);
            this.btnClearNVI.Size = size2;
            this.btnClearNVI.TabIndex = 20;
            this.btnClearNVI.Text = "Clear";
            this.btnClearNVI.UseVisualStyleBackColor = true;
            point2 = new Point(0x138, 0x2a);
            this.btnRemoveNVI.Location = point2;
            this.btnRemoveNVI.Name = "btnRemoveNVI";
            size2 = new Size(0x44, 0x16);
            this.btnRemoveNVI.Size = size2;
            this.btnRemoveNVI.TabIndex = 0x13;
            this.btnRemoveNVI.Text = "Remove";
            this.btnRemoveNVI.UseVisualStyleBackColor = true;
            point2 = new Point(0xee, 0x2a);
            this.btnAddNVI.Location = point2;
            this.btnAddNVI.Name = "btnAddNVI";
            size2 = new Size(0x44, 0x16);
            this.btnAddNVI.Size = size2;
            this.btnAddNVI.TabIndex = 0x12;
            this.btnAddNVI.Text = "Add";
            this.btnAddNVI.UseVisualStyleBackColor = true;
            this.gbRangeHex.Controls.Add(this.txtToHex);
            this.gbRangeHex.Controls.Add(this.txtFromHex);
            this.gbRangeHex.Controls.Add(this.lblToHex);
            this.gbRangeHex.Controls.Add(this.lblFromHex);
            point2 = new Point(0x110, 0x13);
            this.gbRangeHex.Location = point2;
            this.gbRangeHex.Name = "gbRangeHex";
            size2 = new Size(0xda, 0x31);
            this.gbRangeHex.Size = size2;
            this.gbRangeHex.TabIndex = 0x11;
            this.gbRangeHex.TabStop = false;
            this.gbRangeHex.Text = "Range (Hex):";
            point2 = new Point(0x92, 0x11);
            this.txtToHex.Location = point2;
            this.txtToHex.MaxLength = 4;
            this.txtToHex.Name = "txtToHex";
            size2 = new Size(0x35, 20);
            this.txtToHex.Size = size2;
            this.txtToHex.TabIndex = 14;
            this.txtToHex.Text = "FFFF";
            this.txtToHex.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0x3a, 0x11);
            this.txtFromHex.Location = point2;
            this.txtFromHex.MaxLength = 4;
            this.txtFromHex.Name = "txtFromHex";
            size2 = new Size(0x35, 20);
            this.txtFromHex.Size = size2;
            this.txtFromHex.TabIndex = 13;
            this.txtFromHex.Text = "0000";
            this.txtFromHex.TextAlign = HorizontalAlignment.Center;
            this.lblToHex.AutoSize = true;
            point2 = new Point(0x75, 20);
            this.lblToHex.Location = point2;
            this.lblToHex.Name = "lblToHex";
            size2 = new Size(0x17, 13);
            this.lblToHex.Size = size2;
            this.lblToHex.TabIndex = 8;
            this.lblToHex.Text = "To:";
            this.lblFromHex.AutoSize = true;
            point2 = new Point(0x13, 20);
            this.lblFromHex.Location = point2;
            this.lblFromHex.Name = "lblFromHex";
            size2 = new Size(0x21, 13);
            this.lblFromHex.Size = size2;
            this.lblFromHex.TabIndex = 7;
            this.lblFromHex.Text = "From:";
            this.gbRangeDec.Controls.Add(this.txtToDec);
            this.gbRangeDec.Controls.Add(this.txtFromDec);
            this.gbRangeDec.Controls.Add(this.lblToDec);
            this.gbRangeDec.Controls.Add(this.lblFromDec);
            point2 = new Point(6, 0x13);
            this.gbRangeDec.Location = point2;
            this.gbRangeDec.Name = "gbRangeDec";
            size2 = new Size(0xda, 0x31);
            this.gbRangeDec.Size = size2;
            this.gbRangeDec.TabIndex = 0x10;
            this.gbRangeDec.TabStop = false;
            this.gbRangeDec.Text = "Range (Dec):";
            point2 = new Point(0x92, 0x11);
            this.txtToDec.Location = point2;
            this.txtToDec.MaxLength = 5;
            this.txtToDec.Name = "txtToDec";
            size2 = new Size(0x35, 20);
            this.txtToDec.Size = size2;
            this.txtToDec.TabIndex = 13;
            this.txtToDec.Text = "65535";
            this.txtToDec.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0x3a, 0x11);
            this.txtFromDec.Location = point2;
            this.txtFromDec.MaxLength = 5;
            this.txtFromDec.Name = "txtFromDec";
            size2 = new Size(0x35, 20);
            this.txtFromDec.Size = size2;
            this.txtFromDec.TabIndex = 12;
            this.txtFromDec.Text = "0";
            this.txtFromDec.TextAlign = HorizontalAlignment.Center;
            this.lblToDec.AutoSize = true;
            point2 = new Point(0x75, 20);
            this.lblToDec.Location = point2;
            this.lblToDec.Name = "lblToDec";
            size2 = new Size(0x17, 13);
            this.lblToDec.Size = size2;
            this.lblToDec.TabIndex = 8;
            this.lblToDec.Text = "To:";
            this.lblFromDec.AutoSize = true;
            point2 = new Point(0x13, 20);
            this.lblFromDec.Location = point2;
            this.lblFromDec.Name = "lblFromDec";
            size2 = new Size(0x21, 13);
            this.lblFromDec.Size = size2;
            this.lblFromDec.TabIndex = 7;
            this.lblFromDec.Text = "From:";
            this.gbSkipNVItems.Controls.Add(this.btnViewNVSkipProfile);
            this.gbSkipNVItems.Controls.Add(this.btnRefreshNVISkipList);
            this.gbSkipNVItems.Controls.Add(this.lblCurrProfile);
            this.gbSkipNVItems.Controls.Add(this.cbNVItemSkipList);
            point2 = new Point(6, 0x133);
            this.gbSkipNVItems.Location = point2;
            this.gbSkipNVItems.Name = "gbSkipNVItems";
            size2 = new Size(0x1f0, 0x49);
            this.gbSkipNVItems.Size = size2;
            this.gbSkipNVItems.TabIndex = 0x12;
            this.gbSkipNVItems.TabStop = false;
            this.gbSkipNVItems.Text = "Skip NV Items:";
            point2 = new Point(0xf4, 0x2a);
            this.btnViewNVSkipProfile.Location = point2;
            this.btnViewNVSkipProfile.Name = "btnViewNVSkipProfile";
            size2 = new Size(0x44, 0x16);
            this.btnViewNVSkipProfile.Size = size2;
            this.btnViewNVSkipProfile.TabIndex = 0x11;
            this.btnViewNVSkipProfile.Text = "View";
            this.btnViewNVSkipProfile.UseVisualStyleBackColor = true;
            point2 = new Point(0x13e, 0x2a);
            this.btnRefreshNVISkipList.Location = point2;
            this.btnRefreshNVISkipList.Name = "btnRefreshNVISkipList";
            size2 = new Size(0x44, 0x16);
            this.btnRefreshNVISkipList.Size = size2;
            this.btnRefreshNVISkipList.TabIndex = 0x10;
            this.btnRefreshNVISkipList.Text = "Refresh";
            this.btnRefreshNVISkipList.UseVisualStyleBackColor = true;
            this.lblCurrProfile.AutoSize = true;
            point2 = new Point(0x42, 0x12);
            this.lblCurrProfile.Location = point2;
            this.lblCurrProfile.Name = "lblCurrProfile";
            size2 = new Size(0x4c, 13);
            this.lblCurrProfile.Size = size2;
            this.lblCurrProfile.TabIndex = 2;
            this.lblCurrProfile.Text = "Current Profile:";
            this.cbNVItemSkipList.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbNVItemSkipList.FormattingEnabled = true;
            point2 = new Point(0x94, 15);
            this.cbNVItemSkipList.Location = point2;
            this.cbNVItemSkipList.Name = "cbNVItemSkipList";
            size2 = new Size(0xee, 0x15);
            this.cbNVItemSkipList.Size = size2;
            this.cbNVItemSkipList.TabIndex = 1;
            point2 = new Point(0x16a, 0x17f);
            this.btnRestoreNVItems.Location = point2;
            this.btnRestoreNVItems.Name = "btnRestoreNVItems";
            size2 = new Size(140, 0x17);
            this.btnRestoreNVItems.Size = size2;
            this.btnRestoreNVItems.TabIndex = 14;
            this.btnRestoreNVItems.Text = "Restore NV Items";
            this.btnRestoreNVItems.UseVisualStyleBackColor = true;
            point2 = new Point(6, 0x17f);
            this.btnBackupNVItems.Location = point2;
            this.btnBackupNVItems.Name = "btnBackupNVItems";
            size2 = new Size(140, 0x17);
            this.btnBackupNVItems.Size = size2;
            this.btnBackupNVItems.TabIndex = 15;
            this.btnBackupNVItems.Text = "Backup NV Items";
            this.btnBackupNVItems.UseVisualStyleBackColor = true;
            point2 = new Point(0xb8, 0x17f);
            this.btnCancel.Location = point2;
            this.btnCancel.Name = "btnCancel";
            size2 = new Size(0x8d, 0x17);
            this.btnCancel.Size = size2;
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.gbCheckNVStatus.Controls.Add(this.txtCompleteNV);
            this.gbCheckNVStatus.Controls.Add(this.txtInactiveNV);
            this.gbCheckNVStatus.Controls.Add(this.lblCompleteNV);
            this.gbCheckNVStatus.Controls.Add(this.lblInactiveNV);
            this.gbCheckNVStatus.Controls.Add(this.txtBadSecNV);
            this.gbCheckNVStatus.Controls.Add(this.txtBadParamNV);
            this.gbCheckNVStatus.Controls.Add(this.lblBadSecNV);
            this.gbCheckNVStatus.Controls.Add(this.lblBadParamNV);
            point2 = new Point(6, 0x13);
            this.gbCheckNVStatus.Location = point2;
            this.gbCheckNVStatus.Name = "gbCheckNVStatus";
            size2 = new Size(0x1f0, 70);
            this.gbCheckNVStatus.Size = size2;
            this.gbCheckNVStatus.TabIndex = 13;
            this.gbCheckNVStatus.TabStop = false;
            this.gbCheckNVStatus.Text = "NV Items Read / Write Status:";
            point2 = new Point(0x16f, 0x29);
            this.txtCompleteNV.Location = point2;
            this.txtCompleteNV.Name = "txtCompleteNV";
            this.txtCompleteNV.ReadOnly = true;
            size2 = new Size(0x39, 20);
            this.txtCompleteNV.Size = size2;
            this.txtCompleteNV.TabIndex = 0x1d;
            this.txtCompleteNV.Text = "0";
            this.txtCompleteNV.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0x16f, 15);
            this.txtInactiveNV.Location = point2;
            this.txtInactiveNV.Name = "txtInactiveNV";
            this.txtInactiveNV.ReadOnly = true;
            size2 = new Size(0x39, 20);
            this.txtInactiveNV.Size = size2;
            this.txtInactiveNV.TabIndex = 0x1c;
            this.txtInactiveNV.Text = "0";
            this.txtInactiveNV.TextAlign = HorizontalAlignment.Center;
            this.lblCompleteNV.AutoSize = true;
            point2 = new Point(0x105, 0x2c);
            this.lblCompleteNV.Location = point2;
            this.lblCompleteNV.Name = "lblCompleteNV";
            size2 = new Size(100, 13);
            this.lblCompleteNV.Size = size2;
            this.lblCompleteNV.TabIndex = 0x1b;
            this.lblCompleteNV.Text = "Complete NV Items:";
            this.lblInactiveNV.AutoSize = true;
            point2 = new Point(0x105, 0x12);
            this.lblInactiveNV.Location = point2;
            this.lblInactiveNV.Name = "lblInactiveNV";
            size2 = new Size(0x5e, 13);
            this.lblInactiveNV.Size = size2;
            this.lblInactiveNV.TabIndex = 0x1a;
            this.lblInactiveNV.Text = "Inactive NV Items:";
            point2 = new Point(0xa7, 0x29);
            this.txtBadSecNV.Location = point2;
            this.txtBadSecNV.Name = "txtBadSecNV";
            this.txtBadSecNV.ReadOnly = true;
            size2 = new Size(0x39, 20);
            this.txtBadSecNV.Size = size2;
            this.txtBadSecNV.TabIndex = 0x19;
            this.txtBadSecNV.Text = "0";
            this.txtBadSecNV.TextAlign = HorizontalAlignment.Center;
            point2 = new Point(0xa7, 15);
            this.txtBadParamNV.Location = point2;
            this.txtBadParamNV.Name = "txtBadParamNV";
            this.txtBadParamNV.ReadOnly = true;
            size2 = new Size(0x39, 20);
            this.txtBadParamNV.Size = size2;
            this.txtBadParamNV.TabIndex = 0x18;
            this.txtBadParamNV.Text = "0";
            this.txtBadParamNV.TextAlign = HorizontalAlignment.Center;
            this.lblBadSecNV.AutoSize = true;
            point2 = new Point(0x23, 0x2c);
            this.lblBadSecNV.Location = point2;
            this.lblBadSecNV.Name = "lblBadSecNV";
            size2 = new Size(0x74, 13);
            this.lblBadSecNV.Size = size2;
            this.lblBadSecNV.TabIndex = 0x17;
            this.lblBadSecNV.Text = "Bad Security NV Items:";
            this.lblBadParamNV.AutoSize = true;
            point2 = new Point(0x23, 0x12);
            this.lblBadParamNV.Location = point2;
            this.lblBadParamNV.Name = "lblBadParamNV";
            size2 = new Size(0x7e, 13);
            this.lblBadParamNV.Size = size2;
            this.lblBadParamNV.TabIndex = 0x16;
            this.lblBadParamNV.Text = "Bad Parameter NV Items:";
            this.tabTerminal.Controls.Add(this.gbQCDMCmdTerm);
            this.tabTerminal.Controls.Add(this.gbATCmdTerm);
            this.tabTerminal.Controls.Add(this.gbTermResponse);
            point2 = new Point(4, 0x16);
            this.tabTerminal.Location = point2;
            this.tabTerminal.Name = "tabTerminal";
            padding2 = new Padding(3);
            this.tabTerminal.Padding = padding2;
            size2 = new Size(0x20f, 0x1a8);
            this.tabTerminal.Size = size2;
            this.tabTerminal.TabIndex = 4;
            this.tabTerminal.Text = "Terminal";
            this.tabTerminal.UseVisualStyleBackColor = true;
            this.gbQCDMCmdTerm.Controls.Add(this.chkCRC7E);
            this.gbQCDMCmdTerm.Controls.Add(this.cbDiagCmds);
            this.gbQCDMCmdTerm.Controls.Add(this.btnSendQCDM);
            this.gbQCDMCmdTerm.Controls.Add(this.lblDiagCmds);
            this.gbQCDMCmdTerm.Controls.Add(this.lblNVItems);
            this.gbQCDMCmdTerm.Controls.Add(this.cbNVItems);
            this.gbQCDMCmdTerm.Controls.Add(this.lblQCDMFormat);
            this.gbQCDMCmdTerm.Controls.Add(this.lbl7E);
            this.gbQCDMCmdTerm.Controls.Add(this.lblPlus);
            this.gbQCDMCmdTerm.Controls.Add(this.lblCRC);
            this.gbQCDMCmdTerm.Controls.Add(this.txtQCDMCmd);
            point2 = new Point(270, 6);
            this.gbQCDMCmdTerm.Location = point2;
            this.gbQCDMCmdTerm.Name = "gbQCDMCmdTerm";
            size2 = new Size(0xf7, 0xbd);
            this.gbQCDMCmdTerm.Size = size2;
            this.gbQCDMCmdTerm.TabIndex = 2;
            this.gbQCDMCmdTerm.TabStop = false;
            this.gbQCDMCmdTerm.Text = "QCDM Commands:";
            this.chkCRC7E.AutoSize = true;
            this.chkCRC7E.Checked = true;
            this.chkCRC7E.CheckState = CheckState.Checked;
            point2 = new Point(0x17, 0xa2);
            this.chkCRC7E.Location = point2;
            this.chkCRC7E.Name = "chkCRC7E";
            size2 = new Size(0x43, 0x11);
            this.chkCRC7E.Size = size2;
            this.chkCRC7E.TabIndex = 11;
            this.chkCRC7E.Text = "CRC+7E";
            this.chkCRC7E.UseVisualStyleBackColor = true;
            this.cbDiagCmds.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbDiagCmds.FormattingEnabled = true;
            point2 = new Point(6, 0x55);
            this.cbDiagCmds.Location = point2;
            this.cbDiagCmds.Name = "cbDiagCmds";
            size2 = new Size(0xeb, 0x15);
            this.cbDiagCmds.Size = size2;
            this.cbDiagCmds.TabIndex = 10;
            point2 = new Point(0xa9, 0x9d);
            this.btnSendQCDM.Location = point2;
            this.btnSendQCDM.Name = "btnSendQCDM";
            size2 = new Size(0x48, 0x18);
            this.btnSendQCDM.Size = size2;
            this.btnSendQCDM.TabIndex = 9;
            this.btnSendQCDM.Text = "Send";
            this.btnSendQCDM.UseVisualStyleBackColor = true;
            this.lblDiagCmds.AutoSize = true;
            point2 = new Point(3, 0x45);
            this.lblDiagCmds.Location = point2;
            this.lblDiagCmds.Name = "lblDiagCmds";
            size2 = new Size(0x57, 13);
            this.lblDiagCmds.Size = size2;
            this.lblDiagCmds.TabIndex = 8;
            this.lblDiagCmds.Text = "Diag Commands:";
            this.lblNVItems.AutoSize = true;
            point2 = new Point(3, 0x72);
            this.lblNVItems.Location = point2;
            this.lblNVItems.Name = "lblNVItems";
            size2 = new Size(0x35, 13);
            this.lblNVItems.Size = size2;
            this.lblNVItems.TabIndex = 7;
            this.lblNVItems.Text = "NV Items:";
            this.cbNVItems.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbNVItems.FormattingEnabled = true;
            point2 = new Point(6, 130);
            this.cbNVItems.Location = point2;
            this.cbNVItems.Name = "cbNVItems";
            size2 = new Size(0xeb, 0x15);
            this.cbNVItems.Size = size2;
            this.cbNVItems.TabIndex = 6;
            this.lblQCDMFormat.AutoSize = true;
            point2 = new Point(0x2c, 0x2a);
            this.lblQCDMFormat.Location = point2;
            this.lblQCDMFormat.Name = "lblQCDMFormat";
            size2 = new Size(0x6d, 13);
            this.lblQCDMFormat.Size = size2;
            this.lblQCDMFormat.TabIndex = 4;
            this.lblQCDMFormat.Text = "(Hexadecimal Format)";
            this.lbl7E.AutoSize = true;
            this.lbl7E.BorderStyle = BorderStyle.Fixed3D;
            point2 = new Point(0xdb, 0x2a);
            this.lbl7E.Location = point2;
            this.lbl7E.Name = "lbl7E";
            size2 = new Size(0x16, 15);
            this.lbl7E.Size = size2;
            this.lbl7E.TabIndex = 3;
            this.lbl7E.Text = "7E";
            this.lblPlus.AutoSize = true;
            this.lblPlus.BorderStyle = BorderStyle.Fixed3D;
            point2 = new Point(0xc6, 0x2a);
            this.lblPlus.Location = point2;
            this.lblPlus.Name = "lblPlus";
            size2 = new Size(15, 15);
            this.lblPlus.Size = size2;
            this.lblPlus.TabIndex = 2;
            this.lblPlus.Text = "+";
            this.lblCRC.AutoSize = true;
            this.lblCRC.BorderStyle = BorderStyle.Fixed3D;
            point2 = new Point(0x9f, 0x2a);
            this.lblCRC.Location = point2;
            this.lblCRC.Name = "lblCRC";
            size2 = new Size(0x21, 15);
            this.lblCRC.Size = size2;
            this.lblCRC.TabIndex = 1;
            this.lblCRC.Text = "FFFF";
            point2 = new Point(6, 0x13);
            this.txtQCDMCmd.Location = point2;
            this.txtQCDMCmd.Name = "txtQCDMCmd";
            size2 = new Size(0xeb, 20);
            this.txtQCDMCmd.Size = size2;
            this.txtQCDMCmd.TabIndex = 0;
            this.gbATCmdTerm.Controls.Add(this.cbATCmds);
            this.gbATCmdTerm.Controls.Add(this.lblATCmds);
            this.gbATCmdTerm.Controls.Add(this.lblATFormat);
            this.gbATCmdTerm.Controls.Add(this.btnSendAT);
            this.gbATCmdTerm.Controls.Add(this.txtATCmd);
            point2 = new Point(9, 6);
            this.gbATCmdTerm.Location = point2;
            this.gbATCmdTerm.Name = "gbATCmdTerm";
            size2 = new Size(0xf7, 0xbd);
            this.gbATCmdTerm.Size = size2;
            this.gbATCmdTerm.TabIndex = 1;
            this.gbATCmdTerm.TabStop = false;
            this.gbATCmdTerm.Text = "AT Commands:";
            this.cbATCmds.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbATCmds.FormattingEnabled = true;
            point2 = new Point(6, 0x55);
            this.cbATCmds.Location = point2;
            this.cbATCmds.Name = "cbATCmds";
            size2 = new Size(0xeb, 0x15);
            this.cbATCmds.Size = size2;
            this.cbATCmds.TabIndex = 0x10;
            this.lblATCmds.AutoSize = true;
            point2 = new Point(3, 0x45);
            this.lblATCmds.Location = point2;
            this.lblATCmds.Name = "lblATCmds";
            size2 = new Size(0x4f, 13);
            this.lblATCmds.Size = size2;
            this.lblATCmds.TabIndex = 15;
            this.lblATCmds.Text = "AT Commands:";
            this.lblATFormat.AutoSize = true;
            point2 = new Point(0x2c, 0x2a);
            this.lblATFormat.Location = point2;
            this.lblATFormat.Name = "lblATFormat";
            size2 = new Size(0x4b, 13);
            this.lblATFormat.Size = size2;
            this.lblATFormat.TabIndex = 14;
            this.lblATFormat.Text = "(String Format)";
            point2 = new Point(0xa9, 0x9d);
            this.btnSendAT.Location = point2;
            this.btnSendAT.Name = "btnSendAT";
            size2 = new Size(0x48, 0x18);
            this.btnSendAT.Size = size2;
            this.btnSendAT.TabIndex = 10;
            this.btnSendAT.Text = "Send";
            this.btnSendAT.UseVisualStyleBackColor = true;
            this.txtATCmd.CharacterCasing = CharacterCasing.Upper;
            point2 = new Point(6, 0x13);
            this.txtATCmd.Location = point2;
            this.txtATCmd.Name = "txtATCmd";
            size2 = new Size(0xeb, 20);
            this.txtATCmd.Size = size2;
            this.txtATCmd.TabIndex = 1;
            this.gbTermResponse.Controls.Add(this.lblErrResponse);
            this.gbTermResponse.Controls.Add(this.txtErrResponse);
            this.gbTermResponse.Controls.Add(this.btnClearTerm);
            this.gbTermResponse.Controls.Add(this.lblResponseLEN);
            this.gbTermResponse.Controls.Add(this.txtResponseLEN);
            this.gbTermResponse.Controls.Add(this.txtTermResponse);
            point2 = new Point(9, 0xc9);
            this.gbTermResponse.Location = point2;
            this.gbTermResponse.Name = "gbTermResponse";
            size2 = new Size(0x1fc, 0xd9);
            this.gbTermResponse.Size = size2;
            this.gbTermResponse.TabIndex = 0;
            this.gbTermResponse.TabStop = false;
            this.gbTermResponse.Text = "Terminal Response:";
            this.lblErrResponse.AutoSize = true;
            point2 = new Point(0xbd, 0xc0);
            this.lblErrResponse.Location = point2;
            this.lblErrResponse.Name = "lblErrResponse";
            size2 = new Size(0x53, 13);
            this.lblErrResponse.Size = size2;
            this.lblErrResponse.TabIndex = 12;
            this.lblErrResponse.Text = "Error Response:";
            point2 = new Point(0x116, 0xbd);
            this.txtErrResponse.Location = point2;
            this.txtErrResponse.Name = "txtErrResponse";
            this.txtErrResponse.ReadOnly = true;
            size2 = new Size(0x92, 20);
            this.txtErrResponse.Size = size2;
            this.txtErrResponse.TabIndex = 11;
            point2 = new Point(430, 0xbb);
            this.btnClearTerm.Location = point2;
            this.btnClearTerm.Name = "btnClearTerm";
            size2 = new Size(0x48, 0x18);
            this.btnClearTerm.Size = size2;
            this.btnClearTerm.TabIndex = 10;
            this.btnClearTerm.Text = "Clear";
            this.btnClearTerm.UseVisualStyleBackColor = true;
            this.lblResponseLEN.AutoSize = true;
            point2 = new Point(3, 0xc0);
            this.lblResponseLEN.Location = point2;
            this.lblResponseLEN.Name = "lblResponseLEN";
            size2 = new Size(0x5e, 13);
            this.lblResponseLEN.Size = size2;
            this.lblResponseLEN.TabIndex = 5;
            this.lblResponseLEN.Text = "Response Length:";
            point2 = new Point(0x67, 0xbd);
            this.txtResponseLEN.Location = point2;
            this.txtResponseLEN.Name = "txtResponseLEN";
            this.txtResponseLEN.ReadOnly = true;
            size2 = new Size(70, 20);
            this.txtResponseLEN.Size = size2;
            this.txtResponseLEN.TabIndex = 4;
            this.txtTermResponse.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(6, 0x13);
            this.txtTermResponse.Location = point2;
            this.txtTermResponse.Multiline = true;
            this.txtTermResponse.Name = "txtTermResponse";
            this.txtTermResponse.ReadOnly = true;
            this.txtTermResponse.ScrollBars = ScrollBars.Vertical;
            size2 = new Size(0x1f0, 0xa4);
            this.txtTermResponse.Size = size2;
            this.txtTermResponse.TabIndex = 0;
            this.tabConsole.Controls.Add(this.btnClear);
            this.tabConsole.Controls.Add(this.rtConsole);
            point2 = new Point(4, 0x16);
            this.tabConsole.Location = point2;
            this.tabConsole.Name = "tabConsole";
            size2 = new Size(0x20f, 0x1a8);
            this.tabConsole.Size = size2;
            this.tabConsole.TabIndex = 2;
            this.tabConsole.Text = "Console";
            this.tabConsole.UseVisualStyleBackColor = true;
            point2 = new Point(0xc9, 0x18d);
            this.btnClear.Location = point2;
            this.btnClear.Name = "btnClear";
            size2 = new Size(0x7d, 0x17);
            this.btnClear.Size = size2;
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Console";
            this.btnClear.UseVisualStyleBackColor = true;
            this.rtConsole.Dock = DockStyle.Top;
            this.rtConsole.Font = new Font("Consolas", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0, 0);
            this.rtConsole.Location = point2;
            this.rtConsole.Name = "rtConsole";
            this.rtConsole.ReadOnly = true;
            this.rtConsole.ScrollBars = RichTextBoxScrollBars.Vertical;
            size2 = new Size(0x20f, 0x188);
            this.rtConsole.Size = size2;
            this.rtConsole.TabIndex = 0;
            this.rtConsole.Text = "";
            this.tsActivityRX.BackColor = SystemColors.Control;
            this.tsActivityRX.BorderSides = ToolStripStatusLabelBorderSides.All;
            this.tsActivityRX.BorderStyle = Border3DStyle.SunkenOuter;
            this.tsActivityRX.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.tsActivityRX.Font = new Font("Segoe UI", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            padding2 = new Padding(1, 3, 3, 2);
            this.tsActivityRX.Margin = padding2;
            this.tsActivityRX.Name = "tsActivityRX";
            size2 = new Size(0x13, 0x11);
            this.tsActivityRX.Size = size2;
            this.tsActivityRX.Text = "RX";
            this.tsActivityTX.BackColor = SystemColors.Control;
            this.tsActivityTX.BorderSides = ToolStripStatusLabelBorderSides.All;
            this.tsActivityTX.BorderStyle = Border3DStyle.SunkenOuter;
            this.tsActivityTX.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.tsActivityTX.Font = new Font("Segoe UI", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            padding2 = new Padding(1, 3, 3, 2);
            this.tsActivityTX.Margin = padding2;
            this.tsActivityTX.Name = "tsActivityTX";
            size2 = new Size(0x13, 0x11);
            this.tsActivityTX.Size = size2;
            this.tsActivityTX.Text = "TX";
            this.tsStatus.Name = "tsStatus";
            size2 = new Size(0x170, 0x11);
            this.tsStatus.Size = size2;
            this.tsStatus.Spring = true;
            this.tsStatus.Text = "Not Connected!";
            this.tsStatus.TextAlign = ContentAlignment.MiddleLeft;
            this.tsStatus.TextDirection = ToolStripTextDirection.Horizontal;
            this.ssQCStatus.Items.AddRange(new ToolStripItem[] { this.tsStatus, this.tsProgress, this.tsActivityTX, this.tsActivityRX });
            point2 = new Point(0, 0x25c);
            this.ssQCStatus.Location = point2;
            this.ssQCStatus.Name = "ssQCStatus";
            size2 = new Size(0x217, 0x16);
            this.ssQCStatus.Size = size2;
            this.ssQCStatus.TabIndex = 0x75;
            this.tsProgress.Alignment = ToolStripItemAlignment.Right;
            padding2 = new Padding(1, 3, 5, 3);
            this.tsProgress.Margin = padding2;
            this.tsProgress.Name = "tsProgress";
            size2 = new Size(100, 0x10);
            this.tsProgress.Size = size2;
            this.tsProgress.Step = 1;
            this.tsProgress.Style = ProgressBarStyle.Continuous;
            point2 = new Point(0x1c0, 0x23e);
            this.btnDonate.Location = point2;
            this.btnDonate.Name = "btnDonate";
            size2 = new Size(0x4b, 0x17);
            this.btnDonate.Size = size2;
            this.btnDonate.TabIndex = 0x77;
            this.btnDonate.Text = "Donate!";
            this.btnDonate.UseVisualStyleBackColor = true;
            this.tmrActivityTX.Interval = 150;
            this.tmrActivityRX.Interval = 250;
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x23d);
            this.lblVersionInfo.Location = point2;
            this.lblVersionInfo.Name = "lblVersionInfo";
            size2 = new Size(0x12a, 0x15);
            this.lblVersionInfo.Size = size2;
            this.lblVersionInfo.TabIndex = 120;
            this.lblVersionInfo.Text = "Qualcomm NV Tools v#.#.# \x00a9 Gaz 2014.";
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x217, 0x272);
            this.ClientSize = size2;
            this.Controls.Add(this.lblVersionInfo);
            this.Controls.Add(this.gbConnSettings);
            this.Controls.Add(this.tcQCDMOptions);
            this.Controls.Add(this.ssQCStatus);
            this.Controls.Add(this.btnDonate);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmQualcommNVTools";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Qualcomm NV Tools";
            this.gbConnSettings.ResumeLayout(false);
            this.gbConnSettings.PerformLayout();
            this.gbPhoneMode.ResumeLayout(false);
            this.tabDiagnosticTools.ResumeLayout(false);
            this.gbDiagVerInfo.ResumeLayout(false);
            this.gbDiagVerInfo.PerformLayout();
            this.gbPhoneVerInfo.ResumeLayout(false);
            this.gbPhoneVerInfo.PerformLayout();
            this.tcQCDMOptions.ResumeLayout(false);
            this.tabSecureOps.ResumeLayout(false);
            this.gbSPCLock.ResumeLayout(false);
            this.gbSPCLock.PerformLayout();
            this.gbESNMEID.ResumeLayout(false);
            this.gbESNMEID.PerformLayout();
            this.gbTarget.ResumeLayout(false);
            this.gbSource.ResumeLayout(false);
            this.gbDiagPasswd.ResumeLayout(false);
            this.gbDiagPasswd.PerformLayout();
            this.tabNVBackupRestore.ResumeLayout(false);
            this.gbNVItems.ResumeLayout(false);
            this.gbNVIOptions.ResumeLayout(false);
            this.gbNVIOptions.PerformLayout();
            this.gbNVIRange.ResumeLayout(false);
            this.gbCustomRange.ResumeLayout(false);
            this.gbCustomRange.PerformLayout();
            this.gbRangeHex.ResumeLayout(false);
            this.gbRangeHex.PerformLayout();
            this.gbRangeDec.ResumeLayout(false);
            this.gbRangeDec.PerformLayout();
            this.gbSkipNVItems.ResumeLayout(false);
            this.gbSkipNVItems.PerformLayout();
            this.gbCheckNVStatus.ResumeLayout(false);
            this.gbCheckNVStatus.PerformLayout();
            this.tabTerminal.ResumeLayout(false);
            this.gbQCDMCmdTerm.ResumeLayout(false);
            this.gbQCDMCmdTerm.PerformLayout();
            this.gbATCmdTerm.ResumeLayout(false);
            this.gbATCmdTerm.PerformLayout();
            this.gbTermResponse.ResumeLayout(false);
            this.gbTermResponse.PerformLayout();
            this.tabConsole.ResumeLayout(false);
            this.ssQCStatus.ResumeLayout(false);
            this.ssQCStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void NVItemsStatusChanged_myCmdQueue(NVItemsStatusEventArgs e)
        {
            this.tsStatus.Text = "Writing NV Items to file: " + Conversions.ToString(e.Position) + " / " + Conversions.ToString(e.TotalLength) + " - " + Conversions.ToString(e.ProgressPercentage) + "%";
            this.txtBadParamNV.Text = Conversions.ToString(e.BadParameterNVItems);
            this.txtBadSecNV.Text = Conversions.ToString(e.BadSecurityNVItems);
            this.txtInactiveNV.Text = Conversions.ToString(e.InactiveNVItems);
            this.txtCompleteNV.Text = Conversions.ToString(e.OkayNVItems);
            this.tsProgress.Value = (int) e.ProgressPercentage;
        }

        private void NVItemsStatusChanged_myNVMemMgr(NVItemsStatusEventArgs e)
        {
            this.tsStatus.Text = "Reading NV Items from file: " + $"{e.Position:###,###,### Bytes}" + " / " + $"{e.TotalLength:###,###,### Bytes}" + " - " + Conversions.ToString(e.ProgressPercentage) + "%";
            this.txtBadParamNV.Text = Conversions.ToString(e.BadParameterNVItems);
            this.txtBadSecNV.Text = Conversions.ToString(e.BadSecurityNVItems);
            this.txtInactiveNV.Text = Conversions.ToString(e.InactiveNVItems);
            this.txtCompleteNV.Text = Conversions.ToString(e.OkayNVItems);
            this.tsProgress.Value = (int) e.ProgressPercentage;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.TimerOut.Enabled = true;
            }
            if (this._qcDevInstance != null)
            {
                if (this._qcDevInstance.CommandQueueInstance.IsBusy)
                {
                    Interaction.MsgBox("An operation is currently pending.\r\nCancel the operation first or wait for it to finish.", MsgBoxStyle.Exclamation, "Operation Pending!");
                    this.TimerIn.Interval = 20;
                    this.TimerIn.Enabled = true;
                    this.TimerOut.Interval = 20;
                    this.TimerOut.Enabled = false;
                    e.Cancel = true;
                }
                else
                {
                    this.ShowDonateDialog();
                }
            }
            else
            {
                Interaction.MsgBox("Please restart Qualcomm NV Tools!", MsgBoxStyle.Exclamation, null);
            }
            if ((this._qcDevInstance != null) && this._qcDevInstance.IsConnected())
            {
                this._qcDevInstance.Disconnect();
                this._qcDevInstance.Dispose();
            }
            if (this._myCmdQueue != null)
            {
                this._myCmdQueue.Dispose();
            }
            if (this._myNVMemManager != null)
            {
                this._myNVMemManager.Dispose();
            }
            this._qcDevInstance = null;
            this._myCmdQueue = null;
            this._myNVMemManager = null;
            base.OnFormClosing(e);
        }

        private string OpenReadQCN()
        {
            string str;
            try
            {
                string str2;
                OpenFileDialog dialog = new OpenFileDialog();
                OpenFileDialog dialog2 = dialog;
                dialog2.Filter = "QPST - QCN Backups (*.qcn)|*.qcn";
                dialog2.FileName = "*.qcn";
                dialog2 = null;
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    dialog.Dispose();
                    return "1";
                }
                byte[] pattern = new byte[] { 0x88, 0, 1, 0, 0, 0, 0, 0 };
                byte[] buffer4 = new byte[] { 0x88, 0, 1, 0, 0xde, 0x15, 0, 0 };
                byte[] buffer3 = new byte[] { 0x88, 0, 1, 0, 0x26, 2, 0, 0 };
                byte[] array = File.ReadAllBytes(dialog.FileName);
                int index = HelperUtils.FindByteOffset(array, pattern, 0);
                if (index != -1)
                {
                    str2 = ConversionUtils.BytesToHexString(HelperUtils.GetByteArray(array, index, 4));
                    this.txtESNhex.Text = ConversionUtils.ReverseHex(str2).Replace(" ", "");
                    this.txtESNFlipped.Text = ConversionUtils.FormatHexStr(str2);
                }
                index = HelperUtils.FindByteOffset(array, buffer4, 0);
                if (index != -1)
                {
                    str2 = ConversionUtils.BytesToHexString(HelperUtils.GetByteArray(array, index, 7));
                    this.txtMEIDhex.Text = ConversionUtils.ReverseHex(str2).Replace(" ", "");
                    this.txtMEIDFlipped.Text = ConversionUtils.FormatHexStr(str2);
                }
                index = HelperUtils.FindByteOffset(array, buffer3, 0);
                if (index != -1)
                {
                    str2 = ConversionUtils.BytesToHexString(HelperUtils.GetByteArray(array, index, 9));
                    this.txtIMEIFlipped.Text = ConversionUtils.FormatHexStr(str2);
                    this.txtIMEIdec.Text = ConversionUtils.ReverseHexToIMEI(str2);
                }
                dialog.Dispose();
                str = "0";
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                str = "-1";
                ProjectData.ClearProjectError();
            }
            return str;
        }

        private string OpenWriteQCN()
        {
            string str;
            try
            {
                byte[] buffer5;
                int num;
                SaveFileDialog dialog = new SaveFileDialog();
                SaveFileDialog dialog2 = dialog;
                dialog2.Filter = "QPST - QCN Backups (*.qcn)|*.qcn";
                dialog2.FileName = "*.qcn";
                dialog2.CheckFileExists = true;
                dialog2.CreatePrompt = false;
                dialog2 = null;
                if (dialog.ShowDialog() == DialogResult.Cancel)
                {
                    dialog.Dispose();
                    return "1";
                }
                byte[] pattern = new byte[] { 0x88, 0, 1, 0, 0, 0, 0, 0 };
                byte[] buffer4 = new byte[] { 0x88, 0, 1, 0, 0xde, 0x15, 0, 0 };
                byte[] buffer3 = new byte[] { 0x88, 0, 1, 0, 0x26, 2, 0, 0 };
                byte[] array = File.ReadAllBytes(dialog.FileName);
                if (this.chkESN.Checked)
                {
                    num = HelperUtils.FindByteOffset(array, pattern, 0);
                    buffer5 = ConversionUtils.HexStringToBytes(this.txtESNFlipped.Text.Replace(" ", ""));
                    if (!HelperUtils.ModifyFileBytes(dialog.FileName, (long) num, 4L, buffer5))
                    {
                        return "-1";
                    }
                }
                if (this.chkMEID.Checked)
                {
                    num = HelperUtils.FindByteOffset(array, buffer4, 0);
                    buffer5 = ConversionUtils.HexStringToBytes(this.txtMEIDFlipped.Text.Replace(" ", ""));
                    if (!HelperUtils.ModifyFileBytes(dialog.FileName, (long) num, 7L, buffer5))
                    {
                        return "-1";
                    }
                }
                if (this.chkIMEI.Checked)
                {
                    num = HelperUtils.FindByteOffset(array, buffer3, 0);
                    buffer5 = ConversionUtils.HexStringToBytes(this.txtIMEIFlipped.Text.Replace(" ", ""));
                    if (!HelperUtils.ModifyFileBytes(dialog.FileName, (long) num, 9L, buffer5))
                    {
                        return "-1";
                    }
                }
                dialog.Dispose();
                str = "0";
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                str = "-1";
                ProjectData.ClearProjectError();
            }
            return str;
        }

        private void ProgressChanged_myCmdQueue(CommandQueueProgressChangedEventArgs e)
        {
            if (e.NVItemNumber == -1222)
            {
                this.tsStatus.Text = "Processing QCDM Command: " + Conversions.ToString(e.CurrentNVItem) + " / " + Conversions.ToString(e.TotalNVItems) + " - " + Conversions.ToString(e.ProgressPercentage) + "%";
            }
            else
            {
                this.tsStatus.Text = "Processing NV Item: " + Conversions.ToString(e.NVItemNumber) + " ~ Total NV Items: " + Conversions.ToString(e.CurrentNVItem) + " / " + Conversions.ToString(e.TotalNVItems) + " - " + Conversions.ToString(e.ProgressPercentage) + "%";
            }
            this.tsProgress.Value = e.ProgressPercentage;
            if (!this._qcDevInstance.CommandQueueInstance.DisableLogging && !string.IsNullOrEmpty(e.ConsoleOutput))
            {
                this.UpdateConsole(e.ConsoleOutput, e.ConsoleTXOutput, e.ConsoleRXOutput, e.ConsoleRXASCIIOutput);
            }
        }

        private void QualcommNVTools_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            this.TimerIn.Interval = 20;
            this.TimerIn.Enabled = true;
            this.TimerOut.Interval = 20;
            this.TimerOut.Enabled = false;
            this.gbCustomRange.Enabled = false;
            this.gbSkipNVItems.Enabled = false;
            this.RefreshCOMPortList();
            this.RefreshCustomNVItemList();
            this.RefreshNVISkipList();
        }

        private bool ReadPhoneInfo()
        {
            bool flag;
            try
            {
                this._qcDevInstance.CommandQueueInstance.Clear();
                EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(Qcdm.Cmd.DIAG_VERNO_F);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(Qcdm.Cmd.DIAG_EXT_BUILD_ID_F);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_SEC_CODE_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_LOCK_CODE_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_ESN_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_MEID_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(NVItemList.NV_UE_IMEI_I);
                this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
                this._qcDevInstance.CommandQueueInstance.Run(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__104));
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

        private void RefreshCOMPortList()
        {
            _Closure$__16 e$__ = new _Closure$__16 {
                $VB$Me = this
            };
            this.gbConnSettings.Enabled = false;
            this.tcQCDMOptions.Enabled = false;
            ThreadPool.QueueUserWorkItem(new WaitCallback(e$__._Lambda$__96));
        }

        private bool RefreshCustomNVItemList()
        {
            this.cbCustomNVIList.Items.Clear();
            if (!this._qcDevInstance.NVMemMgrInstance.LoadCustomNVItemList())
            {
                return false;
            }
            foreach (long num in this._qcDevInstance.NVMemMgrInstance.CustomNVItemList)
            {
                if (Enum.IsDefined(typeof(NVItemList), num))
                {
                    string name = Enum.GetName(typeof(NVItemList), num);
                    if (!this.cbCustomNVIList.Items.Contains(name))
                    {
                        this.cbCustomNVIList.Items.Add(Enum.GetName(typeof(NVItemList), num));
                    }
                }
                else if (!this.cbCustomNVIList.Items.Contains(num))
                {
                    this.cbCustomNVIList.Items.Add(num);
                }
            }
            this.cbCustomNVIList.SelectedIndex = 0;
            return true;
        }

        private bool RefreshNVISkipList()
        {
            this.cbNVItemSkipList.Items.Clear();
            if (!this._qcDevInstance.NVMemMgrInstance.LoadNVItemSkipList())
            {
                return false;
            }
            foreach (NVItemSkipClass class2 in this._qcDevInstance.NVMemMgrInstance.NVItemSkipList)
            {
                this.cbNVItemSkipList.Items.Add(class2.DeviceName);
            }
            if (this.cbNVItemSkipList.Items.Count != 1)
            {
                this.cbNVItemSkipList.SelectedIndex = 0;
            }
            else
            {
                this.cbNVItemSkipList.SelectedIndex = -1;
            }
            return true;
        }

        private void ResetNVItemsStatus()
        {
            this.txtBadParamNV.Text = "0";
            this.txtBadSecNV.Text = "0";
            this.txtInactiveNV.Text = "0";
            this.txtCompleteNV.Text = "0";
        }

        private void RunCompleted_myCmdQueue(object sender, RunCompletedEventArgs e)
        {
            _Closure$__15 e$__ = new _Closure$__15 {
                $VB$Local_e = e
            };
            if (e$__.$VB$Local_e.Error != null)
            {
                this.Invoke(new VB$AnonymousDelegate_1(e$__._Lambda$__95));
                if (e$__.$VB$Local_e.Error.Message.ToLower() == "phone connection has been lost!")
                {
                    this.DisconnectCOMPort();
                }
                if (this._qcDevInstance != null)
                {
                    this._qcDevInstance.CommandQueueInstance.CheckNVItems = false;
                    this._qcDevInstance.CommandQueueInstance.OperationMode = OperationModes.Normal;
                }
                this._errorOccurred = true;
            }
            else if (e$__.$VB$Local_e.Cancelled)
            {
                this.tsProgress.Value = 100;
                this.tsStatus.Text = "Operation cancelled!";
                Interaction.MsgBox("The operation has been cancelled!", MsgBoxStyle.Information, null);
                this._qcDevInstance.CommandQueueInstance.CheckNVItems = false;
                this._qcDevInstance.CommandQueueInstance.OperationMode = OperationModes.Normal;
            }
            else
            {
                if (this._qcDevInstance.CommandQueueInstance.OperationMode == OperationModes.Backup)
                {
                    this.tsStatus.Text = "Backup operation completed!";
                    Interaction.MsgBox("Backup of NV Items completed successfully.", MsgBoxStyle.Information, null);
                }
                else if (this._qcDevInstance.CommandQueueInstance.OperationMode == OperationModes.Restore)
                {
                    this.tsStatus.Text = "Restore operation completed!";
                    Interaction.MsgBox("Restore of NV Items completed successfully.", MsgBoxStyle.Information, null);
                }
                this._qcDevInstance.CommandQueueInstance.CheckNVItems = false;
                this._qcDevInstance.CommandQueueInstance.OperationMode = OperationModes.Normal;
                this.tsProgress.Value = 0;
                this.tsStatus.Text = "Ready...";
                this._myCmdQueue.WaitEventSet();
            }
        }

        private string SendDiagPassword(string diagPasswd)
        {
            string str;
            this._qcDevInstance.CommandQueueInstance.Clear();
            EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(Qcdm.Cmd.DIAG_PASSWORD_F, ConversionUtils.HexStringToBytes(diagPasswd));
            this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
            this._qcDevInstance.CommandQueueInstance.Run(false);
            try
            {
                if (this._qcDevInstance.CommandQueueInstance.CommandOutput == null)
                {
                    return "-1";
                }
                if (Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]) == "0")
                {
                    return "0";
                }
                if (Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]) == "1")
                {
                    return "1";
                }
                str = "-1";
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                str = "-1";
                ProjectData.ClearProjectError();
            }
            return str;
        }

        private string SendSPC(string strSPC)
        {
            string str;
            this._qcDevInstance.CommandQueueInstance.Clear();
            EFS_Professional.Command inCommand = (EFS_Professional.Command) CommandFactory.GetCommand(Qcdm.Cmd.DIAG_SPC_F, Encoding.ASCII.GetBytes(strSPC));
            this._qcDevInstance.CommandQueueInstance.Add(ref inCommand);
            this._qcDevInstance.CommandQueueInstance.Run(false);
            try
            {
                if (this._qcDevInstance.CommandQueueInstance.CommandOutput == null)
                {
                    return "-1";
                }
                if (Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]) == "0")
                {
                    return "0";
                }
                if (Conversions.ToString(this._qcDevInstance.CommandQueueInstance.CommandOutput[0]) == "1")
                {
                    return "1";
                }
                str = "-1";
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                str = "-1";
                ProjectData.ClearProjectError();
            }
            return str;
        }

        private void ShowDonateDialog()
        {
            if (Interaction.MsgBox("Thank you for using Qualcomm NV Tools. Would you like to make a donation?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "Show Your Support! :-)") == MsgBoxResult.Yes)
            {
                Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=7910259");
            }
        }

        private void TimerIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.TimerIn.Stop();
            }
            else
            {
                this.Opacity += 0.02;
            }
        }

        private void TimerOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0.0)
            {
                this.TimerOut.Stop();
            }
            else
            {
                this.Opacity -= 0.02;
            }
        }

        private void tmrActivityRX_Tick(object sender, EventArgs e)
        {
            this.tsActivityRX.BackColor = SystemColors.Control;
            this.tmrActivityRX.Enabled = false;
        }

        private void tmrActivityTX_Tick(object sender, EventArgs e)
        {
            this.tsActivityTX.BackColor = SystemColors.Control;
            this.tmrActivityTX.Enabled = false;
        }

        private void txtATCmd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtATCmd.Text))
            {
                this.btnSendAT.Enabled = false;
            }
            else
            {
                this.btnSendAT.Enabled = true;
            }
        }

        private void txtDiagPasswd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { 
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F',
                '\b', '\x007f'
            };
            e.KeyChar = Conversions.ToChar(e.KeyChar.ToString().ToUpper());
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtESNhex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { 
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F',
                '\b', '\x007f'
            };
            e.KeyChar = Conversions.ToChar(e.KeyChar.ToString().ToUpper());
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtESNhex_TextChanged(object sender, EventArgs e)
        {
            if (this.txtESNhex.Focused)
            {
                this.txtESNFlipped.Text = ConversionUtils.ReverseHex(this.txtESNhex.Text);
            }
        }

        private void txtFromDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\b', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtFromDec_TextChanged(object sender, EventArgs e)
        {
            if (this.txtFromDec.Focused)
            {
                int num;
                if (string.IsNullOrEmpty(this.txtFromDec.Text))
                {
                    num = 0;
                }
                else
                {
                    if (Conversions.ToInteger(this.txtFromDec.Text) > 0xffff)
                    {
                        this.txtFromDec.Text = Conversions.ToString(0xffff);
                    }
                    num = Conversions.ToInteger(this.txtFromDec.Text);
                }
                this.txtFromHex.Text = Convert.ToString(num, 0x10).ToUpper().PadLeft(4, '0');
            }
        }

        private void txtFromHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { 
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F',
                '\b', '\x007f'
            };
            e.KeyChar = Conversions.ToChar(e.KeyChar.ToString().ToUpper());
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtFromHex_TextChanged(object sender, EventArgs e)
        {
            if (this.txtFromHex.Focused)
            {
                string text;
                if (string.IsNullOrEmpty(this.txtFromHex.Text))
                {
                    text = Conversions.ToString(0);
                }
                else
                {
                    text = this.txtFromHex.Text;
                }
                this.txtFromDec.Text = Convert.ToInt32(text, 0x10).ToString();
            }
        }

        private void txtIMEIdec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\b', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtIMEIdec_TextChanged(object sender, EventArgs e)
        {
            if (this.txtIMEIdec.Focused)
            {
                this.txtIMEIFlipped.Text = ConversionUtils.IMEIToReverseHex(this.txtIMEIdec.Text);
            }
        }

        private void txtLockCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\b', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtMEIDhex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { 
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F',
                '\b', '\x007f'
            };
            e.KeyChar = Conversions.ToChar(e.KeyChar.ToString().ToUpper());
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtMEIDhex_TextChanged(object sender, EventArgs e)
        {
            if (this.txtMEIDhex.Focused)
            {
                this.txtMEIDFlipped.Text = ConversionUtils.ReverseHex(this.txtMEIDhex.Text);
            }
        }

        private void txtNVI_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '\b', '\r', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) != -1)
            {
                if ((Conversions.ToString(e.KeyChar) == "-") & (this.txtNVI.Text.IndexOf("-") != -1))
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == '\r')
                {
                    this.btnAddNVI.PerformClick();
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtQCDMCmd_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { 
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F',
                '\b', '\x007f'
            };
            e.KeyChar = Conversions.ToChar(e.KeyChar.ToString().ToUpper());
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtQCDMCmd_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtQCDMCmd.Text))
            {
                this.btnSendQCDM.Enabled = false;
            }
            else
            {
                this.btnSendQCDM.Enabled = true;
            }
            this.txtQCDMCmd.Text = this.txtQCDMCmd.Text.Replace(" ", string.Empty);
            byte[] cRCAsByteFromByte = CRC.GetCRCAsByteFromByte(ConversionUtils.HexStringToBytes(this.txtQCDMCmd.Text).ToArray<byte>());
            this.lblCRC.Text = ConversionUtils.BytesToHexString(cRCAsByteFromByte);
        }

        private void txtSPC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\b', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtToDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\b', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtToDec_TextChanged(object sender, EventArgs e)
        {
            if (this.txtToDec.Focused)
            {
                int num;
                if (string.IsNullOrEmpty(this.txtToDec.Text))
                {
                    num = 0;
                }
                else
                {
                    if (Conversions.ToInteger(this.txtToDec.Text) > 0xffff)
                    {
                        this.txtToDec.Text = Conversions.ToString(0xffff);
                    }
                    num = Conversions.ToInteger(this.txtToDec.Text);
                }
                this.txtToHex.Text = Convert.ToString(num, 0x10).ToUpper().PadLeft(4, '0');
            }
        }

        private void txtToHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { 
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'A', 'B', 'C', 'D', 'E', 'F',
                '\b', '\x007f'
            };
            e.KeyChar = Conversions.ToChar(e.KeyChar.ToString().ToUpper());
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtToHex_TextChanged(object sender, EventArgs e)
        {
            if (this.txtToHex.Focused)
            {
                string text;
                if (string.IsNullOrEmpty(this.txtToHex.Text))
                {
                    text = Conversions.ToString(0);
                }
                else
                {
                    text = this.txtToHex.Text;
                }
                this.txtToDec.Text = Convert.ToInt32(text, 0x10).ToString();
            }
        }

        public void UpdateConsole(string consoleOut, string txStr, string rxStr, string rxStrASCII)
        {
            this.FormatText(consoleOut, 3, FontStyle.Bold, Color.DarkBlue);
            this.FormatText(Environment.NewLine, 0, FontStyle.Regular, Color.Black);
            this.FormatText("Transmit (TX):", 1, FontStyle.Bold, Color.DodgerBlue);
            this.FormatText(Environment.NewLine, 0, FontStyle.Regular, Color.Black);
            this.FormatText(txStr, 0, FontStyle.Regular, Color.Black);
            this.FormatText(Environment.NewLine + Environment.NewLine, 0, FontStyle.Regular, Color.Black);
            this.FormatText("Receive (RX):", 1, FontStyle.Bold, Color.DodgerBlue);
            this.FormatText(Environment.NewLine, 0, FontStyle.Regular, Color.Black);
            this.FormatText(rxStr, 0, FontStyle.Regular, Color.Black);
            this.FormatText(Environment.NewLine + Environment.NewLine, 0, FontStyle.Regular, Color.Black);
            this.FormatText("Response (ASCII): ", 1, FontStyle.Bold, Color.DodgerBlue);
            this.FormatText(rxStrASCII, 0, FontStyle.Regular, Color.Black);
            this.FormatText(Environment.NewLine + Environment.NewLine, 0, FontStyle.Regular, Color.Black);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == this.WM_DEVICECHANGE)
            {
                IntPtr wParam = m.WParam;
                if (wParam == ((IntPtr) 0x8000))
                {
                    this.RefreshCOMPortList();
                }
                else if (wParam == ((IntPtr) 0x8004))
                {
                    this.DisconnectCOMPort();
                    this.ClearFields();
                    this.RefreshCOMPortList();
                }
            }
            base.WndProc(ref m);
        }

        private CommandQueue _myCmdQueue
        {
            get => 
                this.__myCmdQueue;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RunCompletedEventHandler handler = new RunCompletedEventHandler(this.RunCompleted_myCmdQueue);
                NVItemsStatusEventHandler handler2 = new NVItemsStatusEventHandler(this.NVItemsStatusChanged_myCmdQueue);
                EFS_Professional.ProgressChangedEventHandler handler3 = new EFS_Professional.ProgressChangedEventHandler(this._Lambda$__94);
                DataActivityEventHandler handler4 = new DataActivityEventHandler(this.ActivityRX_myCmdQueue);
                DataActivityEventHandler handler5 = new DataActivityEventHandler(this.ActivityTX_mycmdQueue);
                if (this.__myCmdQueue != null)
                {
                    this.__myCmdQueue.RunCompleted -= handler;
                    this.__myCmdQueue.NVItemsStatusChanged -= handler2;
                    this.__myCmdQueue.ProgressChanged -= handler3;
                    this.__myCmdQueue.DataActivityRX -= handler4;
                    this.__myCmdQueue.DataActivityTX -= handler5;
                }
                this.__myCmdQueue = value;
                if (this.__myCmdQueue != null)
                {
                    this.__myCmdQueue.RunCompleted += handler;
                    this.__myCmdQueue.NVItemsStatusChanged += handler2;
                    this.__myCmdQueue.ProgressChanged += handler3;
                    this.__myCmdQueue.DataActivityRX += handler4;
                    this.__myCmdQueue.DataActivityTX += handler5;
                }
            }
        }

        private NVMemoryManager _myNVMemManager
        {
            get => 
                this.__myNVMemManager;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                NVItemsStatusEventHandler handler = new NVItemsStatusEventHandler(this.NVItemsStatusChanged_myNVMemMgr);
                if (this.__myNVMemManager != null)
                {
                    this.__myNVMemManager.NVItemsStatusChanged -= handler;
                }
                this.__myNVMemManager = value;
                if (this.__myNVMemManager != null)
                {
                    this.__myNVMemManager.NVItemsStatusChanged += handler;
                }
            }
        }

        private QualcommDeviceInstance _qcDevInstance
        {
            get => 
                this.__qcDevInstance;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this.__qcDevInstance = value;
            }
        }

        internal virtual Button btnAddNVI
        {
            get => 
                this._btnAddNVI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnAddNVI_Click);
                if (this._btnAddNVI != null)
                {
                    this._btnAddNVI.Click -= handler;
                }
                this._btnAddNVI = value;
                if (this._btnAddNVI != null)
                {
                    this._btnAddNVI.Click += handler;
                }
            }
        }

        internal virtual Button btnBackupNVItems
        {
            get => 
                this._btnBackupNVItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnBackupNVItems_Click);
                if (this._btnBackupNVItems != null)
                {
                    this._btnBackupNVItems.Click -= handler;
                }
                this._btnBackupNVItems = value;
                if (this._btnBackupNVItems != null)
                {
                    this._btnBackupNVItems.Click += handler;
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

        internal virtual Button btnChangeMode
        {
            get => 
                this._btnChangeMode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnChangeMode_Click);
                if (this._btnChangeMode != null)
                {
                    this._btnChangeMode.Click -= handler;
                }
                this._btnChangeMode = value;
                if (this._btnChangeMode != null)
                {
                    this._btnChangeMode.Click += handler;
                }
            }
        }

        internal virtual Button btnClear
        {
            get => 
                this._btnClear;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnClear_Click);
                if (this._btnClear != null)
                {
                    this._btnClear.Click -= handler;
                }
                this._btnClear = value;
                if (this._btnClear != null)
                {
                    this._btnClear.Click += handler;
                }
            }
        }

        internal virtual Button btnClearNVI
        {
            get => 
                this._btnClearNVI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnClearNVI_Click);
                if (this._btnClearNVI != null)
                {
                    this._btnClearNVI.Click -= handler;
                }
                this._btnClearNVI = value;
                if (this._btnClearNVI != null)
                {
                    this._btnClearNVI.Click += handler;
                }
            }
        }

        internal virtual Button btnClearTerm
        {
            get => 
                this._btnClearTerm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnClearTerm_Click);
                if (this._btnClearTerm != null)
                {
                    this._btnClearTerm.Click -= handler;
                }
                this._btnClearTerm = value;
                if (this._btnClearTerm != null)
                {
                    this._btnClearTerm.Click += handler;
                }
            }
        }

        internal virtual Button btnConnect
        {
            get => 
                this._btnConnect;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnConnect_Click);
                if (this._btnConnect != null)
                {
                    this._btnConnect.Click -= handler;
                }
                this._btnConnect = value;
                if (this._btnConnect != null)
                {
                    this._btnConnect.Click += handler;
                }
            }
        }

        internal virtual Button btnDisconnect
        {
            get => 
                this._btnDisconnect;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDisconnect_Click);
                if (this._btnDisconnect != null)
                {
                    this._btnDisconnect.Click -= handler;
                }
                this._btnDisconnect = value;
                if (this._btnDisconnect != null)
                {
                    this._btnDisconnect.Click += handler;
                }
            }
        }

        internal virtual Button btnDonate
        {
            get => 
                this._btnDonate;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDonate_Click);
                if (this._btnDonate != null)
                {
                    this._btnDonate.Click -= handler;
                }
                this._btnDonate = value;
                if (this._btnDonate != null)
                {
                    this._btnDonate.Click += handler;
                }
            }
        }

        internal virtual Button btnReadEMI
        {
            get => 
                this._btnReadEMI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnReadEMI_Click);
                if (this._btnReadEMI != null)
                {
                    this._btnReadEMI.Click -= handler;
                }
                this._btnReadEMI = value;
                if (this._btnReadEMI != null)
                {
                    this._btnReadEMI.Click += handler;
                }
            }
        }

        internal virtual Button btnReadLockCode
        {
            get => 
                this._btnReadLockCode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnReadLockCode_Click);
                if (this._btnReadLockCode != null)
                {
                    this._btnReadLockCode.Click -= handler;
                }
                this._btnReadLockCode = value;
                if (this._btnReadLockCode != null)
                {
                    this._btnReadLockCode.Click += handler;
                }
            }
        }

        internal virtual Button btnReadPhoneInfo
        {
            get => 
                this._btnReadPhoneInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnReadPhoneInfo_Click);
                if (this._btnReadPhoneInfo != null)
                {
                    this._btnReadPhoneInfo.Click -= handler;
                }
                this._btnReadPhoneInfo = value;
                if (this._btnReadPhoneInfo != null)
                {
                    this._btnReadPhoneInfo.Click += handler;
                }
            }
        }

        internal virtual Button btnReadSPC
        {
            get => 
                this._btnReadSPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnReadSPC_Click);
                if (this._btnReadSPC != null)
                {
                    this._btnReadSPC.Click -= handler;
                }
                this._btnReadSPC = value;
                if (this._btnReadSPC != null)
                {
                    this._btnReadSPC.Click += handler;
                }
            }
        }

        internal virtual Button btnRefresh
        {
            get => 
                this._btnRefresh;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRefresh_Click);
                if (this._btnRefresh != null)
                {
                    this._btnRefresh.Click -= handler;
                }
                this._btnRefresh = value;
                if (this._btnRefresh != null)
                {
                    this._btnRefresh.Click += handler;
                }
            }
        }

        internal virtual Button btnRefreshNVISkipList
        {
            get => 
                this._btnRefreshNVISkipList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRefreshNVISkipList_Click);
                if (this._btnRefreshNVISkipList != null)
                {
                    this._btnRefreshNVISkipList.Click -= handler;
                }
                this._btnRefreshNVISkipList = value;
                if (this._btnRefreshNVISkipList != null)
                {
                    this._btnRefreshNVISkipList.Click += handler;
                }
            }
        }

        internal virtual Button btnRemoveNVI
        {
            get => 
                this._btnRemoveNVI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRemoveNVI_Click);
                if (this._btnRemoveNVI != null)
                {
                    this._btnRemoveNVI.Click -= handler;
                }
                this._btnRemoveNVI = value;
                if (this._btnRemoveNVI != null)
                {
                    this._btnRemoveNVI.Click += handler;
                }
            }
        }

        internal virtual Button btnRestoreNVItems
        {
            get => 
                this._btnRestoreNVItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRestoreNVItems_Click);
                if (this._btnRestoreNVItems != null)
                {
                    this._btnRestoreNVItems.Click -= handler;
                }
                this._btnRestoreNVItems = value;
                if (this._btnRestoreNVItems != null)
                {
                    this._btnRestoreNVItems.Click += handler;
                }
            }
        }

        internal virtual Button btnSendAT
        {
            get => 
                this._btnSendAT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSendAT_Click);
                if (this._btnSendAT != null)
                {
                    this._btnSendAT.Click -= handler;
                }
                this._btnSendAT = value;
                if (this._btnSendAT != null)
                {
                    this._btnSendAT.Click += handler;
                }
            }
        }

        internal virtual Button btnSendDiagPasswd
        {
            get => 
                this._btnSendDiagPasswd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSendDiagPwd_Click);
                if (this._btnSendDiagPasswd != null)
                {
                    this._btnSendDiagPasswd.Click -= handler;
                }
                this._btnSendDiagPasswd = value;
                if (this._btnSendDiagPasswd != null)
                {
                    this._btnSendDiagPasswd.Click += handler;
                }
            }
        }

        internal virtual Button btnSendQCDM
        {
            get => 
                this._btnSendQCDM;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSendQCDM_Click);
                if (this._btnSendQCDM != null)
                {
                    this._btnSendQCDM.Click -= handler;
                }
                this._btnSendQCDM = value;
                if (this._btnSendQCDM != null)
                {
                    this._btnSendQCDM.Click += handler;
                }
            }
        }

        internal virtual Button btnSendSPC
        {
            get => 
                this._btnSendSPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSendSPC_Click);
                if (this._btnSendSPC != null)
                {
                    this._btnSendSPC.Click -= handler;
                }
                this._btnSendSPC = value;
                if (this._btnSendSPC != null)
                {
                    this._btnSendSPC.Click += handler;
                }
            }
        }

        internal virtual Button btnViewNVSkipProfile
        {
            get => 
                this._btnViewNVSkipProfile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnViewNVSkipProfile_Click);
                if (this._btnViewNVSkipProfile != null)
                {
                    this._btnViewNVSkipProfile.Click -= handler;
                }
                this._btnViewNVSkipProfile = value;
                if (this._btnViewNVSkipProfile != null)
                {
                    this._btnViewNVSkipProfile.Click += handler;
                }
            }
        }

        internal virtual Button btnWriteEMI
        {
            get => 
                this._btnWriteEMI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnWriteEMI_Click);
                if (this._btnWriteEMI != null)
                {
                    this._btnWriteEMI.Click -= handler;
                }
                this._btnWriteEMI = value;
                if (this._btnWriteEMI != null)
                {
                    this._btnWriteEMI.Click += handler;
                }
            }
        }

        internal virtual Button btnWriteLockCode
        {
            get => 
                this._btnWriteLockCode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnWriteLockCode_Click);
                if (this._btnWriteLockCode != null)
                {
                    this._btnWriteLockCode.Click -= handler;
                }
                this._btnWriteLockCode = value;
                if (this._btnWriteLockCode != null)
                {
                    this._btnWriteLockCode.Click += handler;
                }
            }
        }

        internal virtual Button btnWriteSPC
        {
            get => 
                this._btnWriteSPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnWriteSPC_Click);
                if (this._btnWriteSPC != null)
                {
                    this._btnWriteSPC.Click -= handler;
                }
                this._btnWriteSPC = value;
                if (this._btnWriteSPC != null)
                {
                    this._btnWriteSPC.Click += handler;
                }
            }
        }

        internal virtual ComboBox cbATCmds
        {
            get => 
                this._cbATCmds;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbATCmds_SelectedIndexChanged);
                if (this._cbATCmds != null)
                {
                    this._cbATCmds.SelectedIndexChanged -= handler;
                }
                this._cbATCmds = value;
                if (this._cbATCmds != null)
                {
                    this._cbATCmds.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbCOMPorts
        {
            get => 
                this._cbCOMPorts;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbCOMPorts = value;
            }
        }

        internal virtual ComboBox cbConnMode
        {
            get => 
                this._cbConnMode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbConnMode = value;
            }
        }

        internal virtual ComboBox cbCustomNVIList
        {
            get => 
                this._cbCustomNVIList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbCustomNVIList_SelectedIndexChanged);
                if (this._cbCustomNVIList != null)
                {
                    this._cbCustomNVIList.SelectedIndexChanged -= handler;
                }
                this._cbCustomNVIList = value;
                if (this._cbCustomNVIList != null)
                {
                    this._cbCustomNVIList.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbDiagCmds
        {
            get => 
                this._cbDiagCmds;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbDiagCmds_SelectedIndexChanged);
                if (this._cbDiagCmds != null)
                {
                    this._cbDiagCmds.SelectedIndexChanged -= handler;
                }
                this._cbDiagCmds = value;
                if (this._cbDiagCmds != null)
                {
                    this._cbDiagCmds.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbNVItems
        {
            get => 
                this._cbNVItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbNVItems_SelectedIndexChanged);
                if (this._cbNVItems != null)
                {
                    this._cbNVItems.SelectedIndexChanged -= handler;
                }
                this._cbNVItems = value;
                if (this._cbNVItems != null)
                {
                    this._cbNVItems.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbNVItemSkipList
        {
            get => 
                this._cbNVItemSkipList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbNVItemSkipList = value;
            }
        }

        internal virtual ComboBox cbSource
        {
            get => 
                this._cbSource;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbSource = value;
            }
        }

        internal virtual ComboBox cbTarget
        {
            get => 
                this._cbTarget;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbTarget = value;
            }
        }

        internal virtual CheckBox chkCRC7E
        {
            get => 
                this._chkCRC7E;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.chkIncludeCRC7E_CheckedChanged);
                if (this._chkCRC7E != null)
                {
                    this._chkCRC7E.CheckedChanged -= handler;
                }
                this._chkCRC7E = value;
                if (this._chkCRC7E != null)
                {
                    this._chkCRC7E.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chkEnableCstNVIRange
        {
            get => 
                this._chkEnableCstNVIRange;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.chkEnableCstNVIRange_CheckedChanged);
                if (this._chkEnableCstNVIRange != null)
                {
                    this._chkEnableCstNVIRange.CheckedChanged -= handler;
                }
                this._chkEnableCstNVIRange = value;
                if (this._chkEnableCstNVIRange != null)
                {
                    this._chkEnableCstNVIRange.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chkEnableNVISkip
        {
            get => 
                this._chkEnableNVISkip;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.chkEnableNVISkip_CheckedChanged);
                if (this._chkEnableNVISkip != null)
                {
                    this._chkEnableNVISkip.CheckedChanged -= handler;
                }
                this._chkEnableNVISkip = value;
                if (this._chkEnableNVISkip != null)
                {
                    this._chkEnableNVISkip.CheckedChanged += handler;
                }
            }
        }

        internal virtual CheckBox chkESN
        {
            get => 
                this._chkESN;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkESN = value;
            }
        }

        internal virtual CheckBox chkIMEI
        {
            get => 
                this._chkIMEI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkIMEI = value;
            }
        }

        internal virtual CheckBox chkMEID
        {
            get => 
                this._chkMEID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkMEID = value;
            }
        }

        internal virtual CheckBox chkReadPhone
        {
            get => 
                this._chkReadPhone;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkReadPhone = value;
            }
        }

        internal virtual CheckBox chkSendSPC
        {
            get => 
                this._chkSendSPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkSendSPC = value;
            }
        }

        internal virtual GroupBox gbATCmdTerm
        {
            get => 
                this._gbATCmdTerm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbATCmdTerm = value;
            }
        }

        internal virtual GroupBox gbCheckNVStatus
        {
            get => 
                this._gbCheckNVStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbCheckNVStatus = value;
            }
        }

        internal virtual GroupBox gbConnSettings
        {
            get => 
                this._gbConnSettings;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbConnSettings = value;
            }
        }

        internal virtual GroupBox gbCustomRange
        {
            get => 
                this._gbCustomRange;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbCustomRange = value;
            }
        }

        internal virtual GroupBox gbDiagPasswd
        {
            get => 
                this._gbDiagPasswd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbDiagPasswd = value;
            }
        }

        internal virtual GroupBox gbDiagVerInfo
        {
            get => 
                this._gbDiagVerInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbDiagVerInfo = value;
            }
        }

        internal virtual GroupBox gbESNMEID
        {
            get => 
                this._gbESNMEID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbESNMEID = value;
            }
        }

        internal virtual GroupBox gbNVIOptions
        {
            get => 
                this._gbNVIOptions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbNVIOptions = value;
            }
        }

        internal virtual GroupBox gbNVIRange
        {
            get => 
                this._gbNVIRange;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbNVIRange = value;
            }
        }

        internal virtual GroupBox gbNVItems
        {
            get => 
                this._gbNVItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbNVItems = value;
            }
        }

        internal virtual GroupBox gbPhoneMode
        {
            get => 
                this._gbPhoneMode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbPhoneMode = value;
            }
        }

        internal virtual GroupBox gbPhoneVerInfo
        {
            get => 
                this._gbPhoneVerInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbPhoneVerInfo = value;
            }
        }

        internal virtual GroupBox gbQCDMCmdTerm
        {
            get => 
                this._gbQCDMCmdTerm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbQCDMCmdTerm = value;
            }
        }

        internal virtual GroupBox gbRangeDec
        {
            get => 
                this._gbRangeDec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbRangeDec = value;
            }
        }

        internal virtual GroupBox gbRangeHex
        {
            get => 
                this._gbRangeHex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbRangeHex = value;
            }
        }

        internal virtual GroupBox gbSkipNVItems
        {
            get => 
                this._gbSkipNVItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbSkipNVItems = value;
            }
        }

        internal virtual GroupBox gbSource
        {
            get => 
                this._gbSource;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbSource = value;
            }
        }

        internal virtual GroupBox gbSPCLock
        {
            get => 
                this._gbSPCLock;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbSPCLock = value;
            }
        }

        internal virtual GroupBox gbTarget
        {
            get => 
                this._gbTarget;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbTarget = value;
            }
        }

        internal virtual GroupBox gbTermResponse
        {
            get => 
                this._gbTermResponse;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbTermResponse = value;
            }
        }

        internal virtual Label lbl7E
        {
            get => 
                this._lbl7E;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lbl7E = value;
            }
        }

        internal virtual Label lblATCmds
        {
            get => 
                this._lblATCmds;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblATCmds = value;
            }
        }

        internal virtual Label lblATFormat
        {
            get => 
                this._lblATFormat;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblATFormat = value;
            }
        }

        internal virtual Label lblAvailCOMPorts
        {
            get => 
                this._lblAvailCOMPorts;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblAvailCOMPorts = value;
            }
        }

        internal virtual Label lblBadParamNV
        {
            get => 
                this._lblBadParamNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblBadParamNV = value;
            }
        }

        internal virtual Label lblBadSecNV
        {
            get => 
                this._lblBadSecNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblBadSecNV = value;
            }
        }

        internal virtual Label lblCompiled
        {
            get => 
                this._lblCompiled;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCompiled = value;
            }
        }

        internal virtual Label lblCompleteNV
        {
            get => 
                this._lblCompleteNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCompleteNV = value;
            }
        }

        internal virtual Label lblCRC
        {
            get => 
                this._lblCRC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCRC = value;
            }
        }

        internal virtual Label lblCurrProfile
        {
            get => 
                this._lblCurrProfile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCurrProfile = value;
            }
        }

        internal virtual Label lblCustomNVIList
        {
            get => 
                this._lblCustomNVIList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCustomNVIList = value;
            }
        }

        internal virtual Label lblDiagCmds
        {
            get => 
                this._lblDiagCmds;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDiagCmds = value;
            }
        }

        internal virtual Label lblDiagPasswd
        {
            get => 
                this._lblDiagPasswd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDiagPasswd = value;
            }
        }

        internal virtual Label lblDiagPasswdInfo
        {
            get => 
                this._lblDiagPasswdInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDiagPasswdInfo = value;
            }
        }

        internal virtual Label lblErrResponse
        {
            get => 
                this._lblErrResponse;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblErrResponse = value;
            }
        }

        internal virtual Label lblESNFlipped
        {
            get => 
                this._lblESNFlipped;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblESNFlipped = value;
            }
        }

        internal virtual Label lblESNhex
        {
            get => 
                this._lblESNhex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblESNhex = value;
            }
        }

        internal virtual Label lblFromDec
        {
            get => 
                this._lblFromDec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFromDec = value;
            }
        }

        internal virtual Label lblFromHex
        {
            get => 
                this._lblFromHex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFromHex = value;
            }
        }

        internal virtual Label lblIMEIdec
        {
            get => 
                this._lblIMEIdec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblIMEIdec = value;
            }
        }

        internal virtual Label lblIMEIFlipped
        {
            get => 
                this._lblIMEIFlipped;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblIMEIFlipped = value;
            }
        }

        internal virtual Label lblInactiveNV
        {
            get => 
                this._lblInactiveNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblInactiveNV = value;
            }
        }

        internal virtual Label lblMEIDFlipped
        {
            get => 
                this._lblMEIDFlipped;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMEIDFlipped = value;
            }
        }

        internal virtual Label lblMEIDhex
        {
            get => 
                this._lblMEIDhex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMEIDhex = value;
            }
        }

        internal virtual Label lblMobCAIRev
        {
            get => 
                this._lblMobCAIRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMobCAIRev = value;
            }
        }

        internal virtual Label lblMobFWRev
        {
            get => 
                this._lblMobFWRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMobFWRev = value;
            }
        }

        internal virtual Label lblMobModel
        {
            get => 
                this._lblMobModel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMobModel = value;
            }
        }

        internal virtual Label lblMobModelID
        {
            get => 
                this._lblMobModelID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMobModelID = value;
            }
        }

        internal virtual Label lblMobSWRev
        {
            get => 
                this._lblMobSWRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMobSWRev = value;
            }
        }

        internal virtual Label lblMSMHWRev
        {
            get => 
                this._lblMSMHWRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMSMHWRev = value;
            }
        }

        internal virtual Label lblMSMRev
        {
            get => 
                this._lblMSMRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblMSMRev = value;
            }
        }

        internal virtual Label lblNVI
        {
            get => 
                this._lblNVI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblNVI = value;
            }
        }

        internal virtual Label lblNVItems
        {
            get => 
                this._lblNVItems;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblNVItems = value;
            }
        }

        internal virtual Label lblPlus
        {
            get => 
                this._lblPlus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPlus = value;
            }
        }

        internal virtual Label lblQCDMFormat
        {
            get => 
                this._lblQCDMFormat;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblQCDMFormat = value;
            }
        }

        internal virtual Label lblReleased
        {
            get => 
                this._lblReleased;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblReleased = value;
            }
        }

        internal virtual Label lblResponseLEN
        {
            get => 
                this._lblResponseLEN;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblResponseLEN = value;
            }
        }

        internal virtual Label lblSlotCycleIndex
        {
            get => 
                this._lblSlotCycleIndex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblSlotCycleIndex = value;
            }
        }

        internal virtual Label lblStationClassMark
        {
            get => 
                this._lblStationClassMark;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblStationClassMark = value;
            }
        }

        internal virtual Label lblToDec
        {
            get => 
                this._lblToDec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblToDec = value;
            }
        }

        internal virtual Label lblToHex
        {
            get => 
                this._lblToHex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblToHex = value;
            }
        }

        internal virtual Label lblVersionDir
        {
            get => 
                this._lblVersionDir;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblVersionDir = value;
            }
        }

        internal virtual Label lblVersionInfo
        {
            get => 
                this._lblVersionInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblVersionInfo = value;
            }
        }

        internal virtual RichTextBox rtConsole
        {
            get => 
                this._rtConsole;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rtConsole = value;
            }
        }

        internal virtual StatusStrip ssQCStatus
        {
            get => 
                this._ssQCStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ssQCStatus = value;
            }
        }

        internal virtual TabPage tabConsole
        {
            get => 
                this._tabConsole;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabConsole = value;
            }
        }

        internal virtual TabPage tabDiagnosticTools
        {
            get => 
                this._tabDiagnosticTools;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabDiagnosticTools = value;
            }
        }

        internal virtual TabPage tabNVBackupRestore
        {
            get => 
                this._tabNVBackupRestore;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabNVBackupRestore = value;
            }
        }

        internal virtual TabPage tabSecureOps
        {
            get => 
                this._tabSecureOps;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabSecureOps = value;
            }
        }

        internal virtual TabPage tabTerminal
        {
            get => 
                this._tabTerminal;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabTerminal = value;
            }
        }

        internal virtual TabControl tcQCDMOptions
        {
            get => 
                this._tcQCDMOptions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tcQCDMOptions = value;
            }
        }

        internal virtual System.Windows.Forms.Timer TimerIn
        {
            get => 
                this._TimerIn;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.TimerIn_Tick);
                if (this._TimerIn != null)
                {
                    this._TimerIn.Tick -= handler;
                }
                this._TimerIn = value;
                if (this._TimerIn != null)
                {
                    this._TimerIn.Tick += handler;
                }
            }
        }

        internal virtual System.Windows.Forms.Timer TimerOut
        {
            get => 
                this._TimerOut;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.TimerOut_Tick);
                if (this._TimerOut != null)
                {
                    this._TimerOut.Tick -= handler;
                }
                this._TimerOut = value;
                if (this._TimerOut != null)
                {
                    this._TimerOut.Tick += handler;
                }
            }
        }

        internal virtual System.Windows.Forms.Timer tmrActivityRX
        {
            get => 
                this._tmrActivityRX;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tmrActivityRX_Tick);
                if (this._tmrActivityRX != null)
                {
                    this._tmrActivityRX.Tick -= handler;
                }
                this._tmrActivityRX = value;
                if (this._tmrActivityRX != null)
                {
                    this._tmrActivityRX.Tick += handler;
                }
            }
        }

        internal virtual System.Windows.Forms.Timer tmrActivityTX
        {
            get => 
                this._tmrActivityTX;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tmrActivityTX_Tick);
                if (this._tmrActivityTX != null)
                {
                    this._tmrActivityTX.Tick -= handler;
                }
                this._tmrActivityTX = value;
                if (this._tmrActivityTX != null)
                {
                    this._tmrActivityTX.Tick += handler;
                }
            }
        }

        internal virtual ToolStripStatusLabel tsActivityRX
        {
            get => 
                this._tsActivityRX;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tsActivityRX = value;
            }
        }

        internal virtual ToolStripStatusLabel tsActivityTX
        {
            get => 
                this._tsActivityTX;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tsActivityTX = value;
            }
        }

        internal virtual ToolStripProgressBar tsProgress
        {
            get => 
                this._tsProgress;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tsProgress = value;
            }
        }

        internal virtual ToolStripStatusLabel tsStatus
        {
            get => 
                this._tsStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tsStatus = value;
            }
        }

        internal virtual TextBox txtATCmd
        {
            get => 
                this._txtATCmd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtATCmd_TextChanged);
                if (this._txtATCmd != null)
                {
                    this._txtATCmd.TextChanged -= handler;
                }
                this._txtATCmd = value;
                if (this._txtATCmd != null)
                {
                    this._txtATCmd.TextChanged += handler;
                }
            }
        }

        internal virtual TextBox txtBadParamNV
        {
            get => 
                this._txtBadParamNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtBadParamNV = value;
            }
        }

        internal virtual TextBox txtBadSecNV
        {
            get => 
                this._txtBadSecNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtBadSecNV = value;
            }
        }

        internal virtual TextBox txtCompiled
        {
            get => 
                this._txtCompiled;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtCompiled = value;
            }
        }

        internal virtual TextBox txtCompleteNV
        {
            get => 
                this._txtCompleteNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtCompleteNV = value;
            }
        }

        internal virtual TextBox txtDiagPasswd
        {
            get => 
                this._txtDiagPasswd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.txtDiagPasswd_KeyPress);
                if (this._txtDiagPasswd != null)
                {
                    this._txtDiagPasswd.KeyPress -= handler;
                }
                this._txtDiagPasswd = value;
                if (this._txtDiagPasswd != null)
                {
                    this._txtDiagPasswd.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox txtErrResponse
        {
            get => 
                this._txtErrResponse;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtErrResponse = value;
            }
        }

        internal virtual TextBox txtESNFlipped
        {
            get => 
                this._txtESNFlipped;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtESNFlipped = value;
            }
        }

        internal virtual TextBox txtESNhex
        {
            get => 
                this._txtESNhex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtESNhex_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtESNhex_KeyPress);
                if (this._txtESNhex != null)
                {
                    this._txtESNhex.TextChanged -= handler;
                    this._txtESNhex.KeyPress -= handler2;
                }
                this._txtESNhex = value;
                if (this._txtESNhex != null)
                {
                    this._txtESNhex.TextChanged += handler;
                    this._txtESNhex.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtFromDec
        {
            get => 
                this._txtFromDec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtFromDec_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtFromDec_KeyPress);
                if (this._txtFromDec != null)
                {
                    this._txtFromDec.TextChanged -= handler;
                    this._txtFromDec.KeyPress -= handler2;
                }
                this._txtFromDec = value;
                if (this._txtFromDec != null)
                {
                    this._txtFromDec.TextChanged += handler;
                    this._txtFromDec.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtFromHex
        {
            get => 
                this._txtFromHex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtFromHex_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtFromHex_KeyPress);
                if (this._txtFromHex != null)
                {
                    this._txtFromHex.TextChanged -= handler;
                    this._txtFromHex.KeyPress -= handler2;
                }
                this._txtFromHex = value;
                if (this._txtFromHex != null)
                {
                    this._txtFromHex.TextChanged += handler;
                    this._txtFromHex.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtIMEIdec
        {
            get => 
                this._txtIMEIdec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtIMEIdec_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtIMEIdec_KeyPress);
                if (this._txtIMEIdec != null)
                {
                    this._txtIMEIdec.TextChanged -= handler;
                    this._txtIMEIdec.KeyPress -= handler2;
                }
                this._txtIMEIdec = value;
                if (this._txtIMEIdec != null)
                {
                    this._txtIMEIdec.TextChanged += handler;
                    this._txtIMEIdec.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtIMEIFlipped
        {
            get => 
                this._txtIMEIFlipped;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtIMEIFlipped = value;
            }
        }

        internal virtual TextBox txtInactiveNV
        {
            get => 
                this._txtInactiveNV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtInactiveNV = value;
            }
        }

        internal virtual TextBox txtLockCode
        {
            get => 
                this._txtLockCode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.txtLockCode_KeyPress);
                if (this._txtLockCode != null)
                {
                    this._txtLockCode.KeyPress -= handler;
                }
                this._txtLockCode = value;
                if (this._txtLockCode != null)
                {
                    this._txtLockCode.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox txtMEIDFlipped
        {
            get => 
                this._txtMEIDFlipped;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMEIDFlipped = value;
            }
        }

        internal virtual TextBox txtMEIDhex
        {
            get => 
                this._txtMEIDhex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtMEIDhex_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtMEIDhex_KeyPress);
                if (this._txtMEIDhex != null)
                {
                    this._txtMEIDhex.TextChanged -= handler;
                    this._txtMEIDhex.KeyPress -= handler2;
                }
                this._txtMEIDhex = value;
                if (this._txtMEIDhex != null)
                {
                    this._txtMEIDhex.TextChanged += handler;
                    this._txtMEIDhex.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtMobCAIRev
        {
            get => 
                this._txtMobCAIRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMobCAIRev = value;
            }
        }

        internal virtual TextBox txtMobFWRev
        {
            get => 
                this._txtMobFWRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMobFWRev = value;
            }
        }

        internal virtual TextBox txtMobModel
        {
            get => 
                this._txtMobModel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMobModel = value;
            }
        }

        internal virtual TextBox txtMobModelID
        {
            get => 
                this._txtMobModelID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMobModelID = value;
            }
        }

        internal virtual TextBox txtMSMHWVer
        {
            get => 
                this._txtMSMHWVer;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMSMHWVer = value;
            }
        }

        internal virtual TextBox txtMSMRev
        {
            get => 
                this._txtMSMRev;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtMSMRev = value;
            }
        }

        internal virtual TextBox txtNVI
        {
            get => 
                this._txtNVI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.txtNVI_KeyPress);
                if (this._txtNVI != null)
                {
                    this._txtNVI.KeyPress -= handler;
                }
                this._txtNVI = value;
                if (this._txtNVI != null)
                {
                    this._txtNVI.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox txtQCDMCmd
        {
            get => 
                this._txtQCDMCmd;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtQCDMCmd_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtQCDMCmd_KeyPress);
                if (this._txtQCDMCmd != null)
                {
                    this._txtQCDMCmd.TextChanged -= handler;
                    this._txtQCDMCmd.KeyPress -= handler2;
                }
                this._txtQCDMCmd = value;
                if (this._txtQCDMCmd != null)
                {
                    this._txtQCDMCmd.TextChanged += handler;
                    this._txtQCDMCmd.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtReleased
        {
            get => 
                this._txtReleased;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtReleased = value;
            }
        }

        internal virtual TextBox txtResponseLEN
        {
            get => 
                this._txtResponseLEN;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtResponseLEN = value;
            }
        }

        internal virtual TextBox txtSendSPC
        {
            get => 
                this._txtSendSPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtSendSPC = value;
            }
        }

        internal virtual TextBox txtSlotCycleIndex
        {
            get => 
                this._txtSlotCycleIndex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtSlotCycleIndex = value;
            }
        }

        internal virtual TextBox txtSPC
        {
            get => 
                this._txtSPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler handler = new KeyPressEventHandler(this.txtSPC_KeyPress);
                if (this._txtSPC != null)
                {
                    this._txtSPC.KeyPress -= handler;
                }
                this._txtSPC = value;
                if (this._txtSPC != null)
                {
                    this._txtSPC.KeyPress += handler;
                }
            }
        }

        internal virtual TextBox txtStationClassMark
        {
            get => 
                this._txtStationClassMark;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtStationClassMark = value;
            }
        }

        internal virtual TextBox txtTermResponse
        {
            get => 
                this._txtTermResponse;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtTermResponse = value;
            }
        }

        internal virtual TextBox txtToDec
        {
            get => 
                this._txtToDec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtToDec_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtToDec_KeyPress);
                if (this._txtToDec != null)
                {
                    this._txtToDec.TextChanged -= handler;
                    this._txtToDec.KeyPress -= handler2;
                }
                this._txtToDec = value;
                if (this._txtToDec != null)
                {
                    this._txtToDec.TextChanged += handler;
                    this._txtToDec.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtToHex
        {
            get => 
                this._txtToHex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtToHex_TextChanged);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtToHex_KeyPress);
                if (this._txtToHex != null)
                {
                    this._txtToHex.TextChanged -= handler;
                    this._txtToHex.KeyPress -= handler2;
                }
                this._txtToHex = value;
                if (this._txtToHex != null)
                {
                    this._txtToHex.TextChanged += handler;
                    this._txtToHex.KeyPress += handler2;
                }
            }
        }

        internal virtual TextBox txtVersionDir
        {
            get => 
                this._txtVersionDir;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtVersionDir = value;
            }
        }

        internal virtual TextBox txtVersionString
        {
            get => 
                this._txtVersionString;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtVersionString = value;
            }
        }

        [CompilerGenerated]
        internal class _Closure$__15
        {
            public RunCompletedEventArgs $VB$Local_e;

            [CompilerGenerated]
            public void _Lambda$__95()
            {
                Interaction.MsgBox(this.$VB$Local_e.Error.Message, MsgBoxStyle.Critical, null);
            }
        }

        [CompilerGenerated]
        internal class _Closure$__16
        {
            public frmQualcommNVTools $VB$Me;

            [CompilerGenerated, DebuggerStepThrough]
            public void _Lambda$__96(object a0)
            {
                new VB$AnonymousDelegate_1(this._Lambda$__97)();
            }

            [CompilerGenerated]
            public void _Lambda$__97()
            {
                this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(this.$VB$Me._Lambda$__98));
                using (List<COMPortInfo>.Enumerator enumerator = this.$VB$Me._qcDevInstance.GetCOMPortList().GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        _Closure$__17 e$__;
                        e$__ = new _Closure$__17(e$__) {
                            $VB$Local_comPort = enumerator.Current,
                            $VB$NonLocal__Closure$__16 = this
                        };
                        this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(e$__._Lambda$__99));
                    }
                }
                this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(this.$VB$Me._Lambda$__100));
            }

            [CompilerGenerated]
            internal class _Closure$__17
            {
                public COMPortInfo $VB$Local_comPort;
                public frmQualcommNVTools._Closure$__16 $VB$NonLocal__Closure$__16;

                public _Closure$__17(frmQualcommNVTools._Closure$__16._Closure$__17 other)
                {
                    if (other != null)
                    {
                        this.$VB$NonLocal__Closure$__16 = other.$VB$NonLocal__Closure$__16;
                        this.$VB$Local_comPort = other.$VB$Local_comPort;
                    }
                }

                [CompilerGenerated]
                public void _Lambda$__99()
                {
                    this.$VB$NonLocal__Closure$__16.$VB$Me.cbCOMPorts.Items.Add(this.$VB$Local_comPort.DeviceName);
                }
            }
        }

        public enum WM_DEVICECHANGE_WPPARAMS
        {
            DBT_CONFIGCHANGECANCELED = 0x19,
            DBT_CONFIGCHANGED = 0x18,
            DBT_CUSTOMEVENT = 0x8006,
            DBT_DEVICEARRIVAL = 0x8000,
            DBT_DEVICEQUERYREMOVE = 0x8001,
            DBT_DEVICEQUERYREMOVEFAILED = 0x8002,
            DBT_DEVICEREMOVECOMPLETE = 0x8004,
            DBT_DEVICEREMOVEPENDING = 0x8003,
            DBT_DEVICETYPESPECIFIC = 0x8005,
            DBT_DEVNODES_CHANGED = 7,
            DBT_QUERYCHANGECONFIG = 0x17,
            DBT_USERDEFINED = 0xffff
        }
    }
}


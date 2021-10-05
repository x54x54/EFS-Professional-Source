namespace EFS_Professional
{
    using EFS_Professional.WinADBHelper;
    using EFS_Professional.WinADBHelper.Helpers;
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class frmEFSProMain : Form
    {
        [AccessedThroughProperty("btnBackup")]
        private Button _btnBackup;
        [AccessedThroughProperty("btnClearLog")]
        private Button _btnClearLog;
        [AccessedThroughProperty("btnDeselAllRest")]
        private Button _btnDeselAllRest;
        [AccessedThroughProperty("btnDeselectAll")]
        private Button _btnDeselectAll;
        [AccessedThroughProperty("btnDevADBShell")]
        private Button _btnDevADBShell;
        [AccessedThroughProperty("btnDeviceInfo")]
        private Button _btnDeviceInfo;
        [AccessedThroughProperty("btnDeviceToolsExec")]
        private Button _btnDeviceToolsExec;
        [AccessedThroughProperty("btnDonate")]
        private Button _btnDonate;
        [AccessedThroughProperty("btnGetEFSMountpoint")]
        private Button _btnGetEFSMountpoint;
        [AccessedThroughProperty("btnGetPartList")]
        private Button _btnGetPartList;
        [AccessedThroughProperty("btnGetPropQuery")]
        private Button _btnGetPropQuery;
        [AccessedThroughProperty("btnLaunchPhSVCApp")]
        private Button _btnLaunchPhSVCApp;
        [AccessedThroughProperty("btnManage")]
        private Button _btnManage;
        [AccessedThroughProperty("btnQCNVTools")]
        private Button _btnQCNVTools;
        [AccessedThroughProperty("btnRebootGo")]
        private Button _btnRebootGo;
        [AccessedThroughProperty("btnRefreshBackups")]
        private Button _btnRefreshBackups;
        [AccessedThroughProperty("btnRefreshList")]
        private Button _btnRefreshList;
        [AccessedThroughProperty("btnRestore")]
        private Button _btnRestore;
        [AccessedThroughProperty("btnSelAllRest")]
        private Button _btnSelAllRest;
        [AccessedThroughProperty("btnSelectAll")]
        private Button _btnSelectAll;
        [AccessedThroughProperty("btnTestBBPresence")]
        private Button _btnTestBBPresence;
        [AccessedThroughProperty("btnTestRootPerm")]
        private Button _btnTestRootPerm;
        [AccessedThroughProperty("btnTestWaitDevice")]
        private Button _btnTestWaitDevice;
        [AccessedThroughProperty("cbBackupArchives")]
        private ComboBox _cbBackupArchives;
        [AccessedThroughProperty("cbCurrUSBSettings")]
        private ComboBox _cbCurrUSBSettings;
        [AccessedThroughProperty("cbDeviceFilter")]
        private ComboBox _cbDeviceFilter;
        [AccessedThroughProperty("cbOtherTools")]
        private ComboBox _cbOtherTools;
        [AccessedThroughProperty("cbPhoneSVCApps")]
        private ComboBox _cbPhoneSVCApps;
        [AccessedThroughProperty("cbPITBufferSize")]
        private ComboBox _cbPITBufferSize;
        [AccessedThroughProperty("cbRebootOpt")]
        private ComboBox _cbRebootOpt;
        [AccessedThroughProperty("CheckBox1")]
        private CheckBox _CheckBox1;
        [AccessedThroughProperty("chkEnableAppDebug")]
        private CheckBox _chkEnableAppDebug;
        [AccessedThroughProperty("chkEnableMD5Backup")]
        private CheckBox _chkEnableMD5Backup;
        [AccessedThroughProperty("chkEnableMD5Restore")]
        private CheckBox _chkEnableMD5Restore;
        [AccessedThroughProperty("chkRbtDevAftRestore")]
        private CheckBox _chkRbtDevAftRestore;
        [AccessedThroughProperty("chkSwitchAuto")]
        private CheckBox _chkSwitchAuto;
        [AccessedThroughProperty("chkUseBPP")]
        private CheckBox _chkUseBPP;
        [AccessedThroughProperty("cmsManageFilters")]
        private ContextMenuStrip _cmsManageFilters;
        [AccessedThroughProperty("gbAppConfig")]
        private GroupBox _gbAppConfig;
        [AccessedThroughProperty("gbBackArchCont")]
        private GroupBox _gbBackArchCont;
        [AccessedThroughProperty("gbBackupArchives")]
        private GroupBox _gbBackupArchives;
        [AccessedThroughProperty("gbBackupOptions")]
        private GroupBox _gbBackupOptions;
        [AccessedThroughProperty("gbBuildProps")]
        private GroupBox _gbBuildProps;
        [AccessedThroughProperty("gbDeviceFilters")]
        private GroupBox _gbDeviceFilters;
        [AccessedThroughProperty("gbDevPartitions")]
        private GroupBox _gbDevPartitions;
        [AccessedThroughProperty("gbDevStorageOpt")]
        private GroupBox _gbDevStorageOpt;
        [AccessedThroughProperty("gbMountPart")]
        private GroupBox _gbMountPart;
        [AccessedThroughProperty("gbOtherTools")]
        private GroupBox _gbOtherTools;
        [AccessedThroughProperty("gbPhoneSVCApps")]
        private GroupBox _gbPhoneSVCApps;
        [AccessedThroughProperty("gbPITOptions")]
        private GroupBox _gbPITOptions;
        [AccessedThroughProperty("gbQCDevSupport")]
        private GroupBox _gbQCDevSupport;
        [AccessedThroughProperty("gbRebootOptions")]
        private GroupBox _gbRebootOptions;
        [AccessedThroughProperty("gbRestoreOptions")]
        private GroupBox _gbRestoreOptions;
        [AccessedThroughProperty("gbTests")]
        private GroupBox _gbTests;
        [AccessedThroughProperty("hdrBlockDevice")]
        private ColumnHeader _hdrBlockDevice;
        [AccessedThroughProperty("hdrFlashFileName")]
        private ColumnHeader _hdrFlashFileName;
        [AccessedThroughProperty("hdrPartitionName")]
        private ColumnHeader _hdrPartitionName;
        [AccessedThroughProperty("hdrTargetBlockDevice")]
        private ColumnHeader _hdrTargetBlockDevice;
        [AccessedThroughProperty("lblAppDebug")]
        private Label _lblAppDebug;
        [AccessedThroughProperty("lblCurrUSBSettings")]
        private Label _lblCurrUSBSettings;
        [AccessedThroughProperty("lblDevStorageLoc")]
        private Label _lblDevStorageLoc;
        [AccessedThroughProperty("lblDevStorageLocInfo")]
        private Label _lblDevStorageLocInfo;
        [AccessedThroughProperty("lblDisclaimer")]
        private Label _lblDisclaimer;
        [AccessedThroughProperty("lblDisclaimerInfo")]
        private Label _lblDisclaimerInfo;
        [AccessedThroughProperty("lblEnableAppDebugInfo")]
        private Label _lblEnableAppDebugInfo;
        [AccessedThroughProperty("lblLaunchPhSVCAppInfo")]
        private Label _lblLaunchPhSVCAppInfo;
        [AccessedThroughProperty("lblOtherToolsDesc")]
        private Label _lblOtherToolsDesc;
        [AccessedThroughProperty("lblOtherToolsDescTitle")]
        private Label _lblOtherToolsDescTitle;
        [AccessedThroughProperty("lblOtherToolsInfo")]
        private Label _lblOtherToolsInfo;
        [AccessedThroughProperty("lblPITBuffDefault")]
        private Label _lblPITBuffDefault;
        [AccessedThroughProperty("lblPITBufferSize")]
        private Label _lblPITBufferSize;
        [AccessedThroughProperty("lblPITBuffInfo")]
        private Label _lblPITBuffInfo;
        [AccessedThroughProperty("lblQCDevSuppInfo")]
        private Label _lblQCDevSuppInfo;
        [AccessedThroughProperty("lblVersionInfo")]
        private Label _lblVersionInfo;
        [AccessedThroughProperty("lvBackupContents")]
        private ListView _lvBackupContents;
        [AccessedThroughProperty("lvPartitions")]
        private ListView _lvPartitions;
        [AccessedThroughProperty("myProcess")]
        private AsyncProcess _myProcess;
        [AccessedThroughProperty("rtConsoleLog")]
        private RichTextBox _rtConsoleLog;
        [AccessedThroughProperty("tabAppConfig")]
        private TabPage _tabAppConfig;
        [AccessedThroughProperty("tabBackup")]
        private TabPage _tabBackup;
        [AccessedThroughProperty("tabDebug")]
        private TabPage _tabDebug;
        [AccessedThroughProperty("tabInformation")]
        private TabPage _tabInformation;
        [AccessedThroughProperty("tabRestore")]
        private TabPage _tabRestore;
        [AccessedThroughProperty("tabSamsungTools")]
        private TabPage _tabSamsungTools;
        [AccessedThroughProperty("tcEFSProUI")]
        private TabControl _tcEFSProUI;
        [AccessedThroughProperty("TimerIn")]
        private System.Windows.Forms.Timer _TimerIn;
        [AccessedThroughProperty("TimerOut")]
        private System.Windows.Forms.Timer _TimerOut;
        [AccessedThroughProperty("TimerTrigger")]
        private System.Windows.Forms.Timer _TimerTrigger;
        [AccessedThroughProperty("tsManFilterCreateNew")]
        private ToolStripMenuItem _tsManFilterCreateNew;
        [AccessedThroughProperty("tsManFilterDeleteSel")]
        private ToolStripMenuItem _tsManFilterDeleteSel;
        [AccessedThroughProperty("tsManFilterEditSel")]
        private ToolStripMenuItem _tsManFilterEditSel;
        [AccessedThroughProperty("tsManFilterRefresh")]
        private ToolStripMenuItem _tsManFilterRefresh;
        [AccessedThroughProperty("txtDevStorageLoc")]
        private TextBox _txtDevStorageLoc;
        [AccessedThroughProperty("txtInformation")]
        private TextBox _txtInformation;
        private IntPtr ADB_hWnd;
        private AppConfigClass appConfig;
        private bool appConfigChanged;
        private string appConfigFile;
        private short appDebug;
        private string AppPath;
        private AsyncOperation asyncOp;
        private string BackupFileName;
        private IContainer components;
        private List<DeviceFilterClass> devFilterList;
        private List<PartitionInfo> devicePartitions;
        private string devStorageLoc;
        private string efsLocation;
        private AndroidControl myAndroid;
        private DeviceIO myDevice;
        private SendOrPostCallback onOperationCompletedDelegate;
        private int pitBufferSize;
        private string RestoreFileName;
        private bool samsungMode;
        private frmWaitDeviceDialog waitDevice;
        private Thread workerThread;

        public event EventHandler OperationCompleted;

        public frmEFSProMain()
        {
            this.OperationCompleted += new EventHandler(this._Lambda$__19);
            base.Load += new EventHandler(this.frmEFSProMain_Load);
            base.Shown += new EventHandler(this.frmEFSProMain_Shown);
            this.samsungMode = true;
            this.appConfigFile = "efspro.cfg";
            this.appConfigChanged = false;
            this.AppPath = Application.StartupPath.ToString();
            this.devFilterList = new List<DeviceFilterClass>();
            this.appDebug = 0;
            this.devStorageLoc = "/sdcard";
            this.pitBufferSize = 0x400;
            this.BackupFileName = string.Empty;
            this.RestoreFileName = string.Empty;
            this.devicePartitions = new List<PartitionInfo>();
            this.myProcess = new AsyncProcess();
            this.myAndroid = null;
            this.myDevice = null;
            this.waitDevice = null;
            this.InitializeComponent();
            this.InitializeDelegates();
            this.lblVersionInfo.Text = "EFS Professional v" + VersionInfo.GetAppVersion() + " \x00a9 Gaz 2014.";
            this.ReadAppConfig(this.AppPath + @"\" + this.appConfigFile);
            if (this.appConfig != null)
            {
                this.appDebug = this.appConfig.EnableAppDebug;
                if (this.appDebug == 1)
                {
                    this.chkEnableAppDebug.Checked = true;
                }
                else
                {
                    this.chkEnableAppDebug.Checked = false;
                }
                this.devStorageLoc = this.appConfig.DeviceStorageLocation;
                this.txtDevStorageLoc.Text = this.devStorageLoc;
                this.pitBufferSize = this.appConfig.PITFileBufferSize;
                if (this.pitBufferSize == 0x400)
                {
                    this.cbPITBufferSize.SelectedIndex = 0;
                }
                else if (this.pitBufferSize == 0x800)
                {
                    this.cbPITBufferSize.SelectedIndex = 1;
                }
                else if (this.pitBufferSize == 0xc00)
                {
                    this.cbPITBufferSize.SelectedIndex = 2;
                }
                else if (this.pitBufferSize == 0x1000)
                {
                    this.cbPITBufferSize.SelectedIndex = 3;
                }
                else if (this.pitBufferSize == 0x1400)
                {
                    this.cbPITBufferSize.SelectedIndex = 4;
                }
            }
            else
            {
                this.appDebug = 0;
                this.chkEnableAppDebug.Checked = false;
                this.devStorageLoc = "/sdcard";
                this.txtDevStorageLoc.Text = this.devStorageLoc;
                this.pitBufferSize = 0x400;
                this.cbPITBufferSize.SelectedIndex = 0;
                this.WriteAppConfig("efspro.cfg");
            }
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__19(object a0, EventArgs a1)
        {
            this.OnOperationCompleted(RuntimeHelpers.GetObjectValue(a0), (OperationCompletedEventArgs) a1);
        }

        [CompilerGenerated]
        private bool _Lambda$__22() => 
            this.myAndroid.ShowWaitDeviceDialog(ref this.myDevice, null, "Plug in the USB cable to continue or press Cancel...", true);

        [CompilerGenerated]
        private static void _Lambda$__23()
        {
            Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
        }

        [CompilerGenerated]
        private void _Lambda$__24()
        {
            Interaction.MsgBox("Connected device is currently " + this.myAndroid.GetConnectedDevice().GetState.ToString() + ".\r\n\r\nPlease ensure the ADB server has been authorised by the connected device by confirming your PC's RSA Fingerprint then press 'OK' to continue.", MsgBoxStyle.Information, null);
        }

        [CompilerGenerated]
        private void _Lambda$__25()
        {
            this.tcEFSProUI.TabPages.Remove(this.tabSamsungTools);
            this.gbPITOptions.Enabled = false;
            this.btnGetEFSMountpoint.Enabled = false;
        }

        [CompilerGenerated]
        private void _Lambda$__27()
        {
            this.tcEFSProUI.TabPages.Remove(this.tabDebug);
        }

        [CompilerGenerated]
        private void _Lambda$__28()
        {
            this.RefreshFilterList();
            this.RefreshBackupArchList();
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__29(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__30)();
        }

        [CompilerGenerated]
        private void _Lambda$__30()
        {
            this.GetDeviceInfo();
        }

        [CompilerGenerated]
        private void _Lambda$__33()
        {
            this.cbCurrUSBSettings.SelectedIndexChanged -= new EventHandler(this.cbCurrUSBSettings_SelectedIndexChanged);
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), CompilerGenerated]
        private void _Lambda$__34()
        {
            if (!this.myAndroid.ShowWaitDeviceDialog(ref this.myDevice, null, "Disconnect the USB cable from your phone for a few seconds then reconnect it to continue or press Cancel...", true))
            {
                Interaction.MsgBox("Device is not connected! The application will now close!", MsgBoxStyle.Critical, null);
                if (this.myAndroid != null)
                {
                    this.myAndroid.Dispose();
                }
                ProjectData.EndApp();
            }
            this.Refresh();
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), CompilerGenerated]
        private void _Lambda$__36()
        {
            if (!this.myAndroid.ShowWaitDeviceDialog(ref this.myDevice, null, "Disconnect the USB cable from your phone for a few seconds then reconnect it to continue or press Cancel...", true))
            {
                Interaction.MsgBox("Device is not connected! The application will now close!", MsgBoxStyle.Critical, null);
                if (this.myAndroid != null)
                {
                    this.myAndroid.Dispose();
                }
                ProjectData.EndApp();
            }
            this.Refresh();
        }

        [CompilerGenerated]
        private void _Lambda$__37()
        {
            this.cbCurrUSBSettings.SelectedIndexChanged += new EventHandler(this.cbCurrUSBSettings_SelectedIndexChanged);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__38(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__39)();
        }

        [CompilerGenerated]
        private void _Lambda$__39()
        {
            this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__40));
            string property = BuildPropertyParser.GetProperty("sys.usb.config");
            this.ReadUSBSettings_MultiThread(property);
            this.Invoke(new VB$AnonymousDelegate_1(this._Lambda$__41));
        }

        [CompilerGenerated]
        private void _Lambda$__40()
        {
            this.cbCurrUSBSettings.SelectedIndexChanged -= new EventHandler(this.cbCurrUSBSettings_SelectedIndexChanged);
        }

        [CompilerGenerated]
        private void _Lambda$__41()
        {
            this.cbCurrUSBSettings.SelectedIndexChanged += new EventHandler(this.cbCurrUSBSettings_SelectedIndexChanged);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__42(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__43)();
        }

        [CompilerGenerated]
        private void _Lambda$__43()
        {
            string newValue = string.Empty;
            newValue = this.WriteUSBSettings_MultiThread();
            BuildPropertyParser.SetProperty("sys.usb.config", newValue);
            this.Invoke(new Action(this._Lambda$__44));
            this.myDevice = this.myAndroid.GetConnectedDevice(this.myAndroid.ConnectedDevices[0]);
            this.EnableControls_MultiThread();
            this.Invoke(new Action(this._Lambda$__45));
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), CompilerGenerated]
        private void _Lambda$__44()
        {
            if (!this.myAndroid.ShowWaitDeviceDialog(ref this.myDevice, null, "Disconnect the USB cable from your phone for a few seconds then reconnect it to continue or press Cancel...", true))
            {
                Interaction.MsgBox("Device is not connected! The application will now close!", MsgBoxStyle.Critical, null);
                if (this.myAndroid != null)
                {
                    this.myAndroid.Dispose();
                }
                ProjectData.EndApp();
            }
            this.Refresh();
        }

        [CompilerGenerated]
        private void _Lambda$__45()
        {
            this.rtConsoleLog.Clear();
            this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, false, true);
            this.UpdateLogText_MultiThread("Switched to: '" + this.cbCurrUSBSettings.SelectedItem.ToString() + "' successfully.", Color.Lime, false, false, true);
            this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, false, false);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__46(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__47)();
        }

        [CompilerGenerated]
        private void _Lambda$__47()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.Preconfig);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__48(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__49)();
        }

        [CompilerGenerated]
        private void _Lambda$__49()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.PhoneUtil);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__50(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__51)();
        }

        [CompilerGenerated]
        private void _Lambda$__51()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.PhoneUtilQCUSBSettings);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__52(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__53)();
        }

        [CompilerGenerated]
        private void _Lambda$__53()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.PhoneUtilNewDev);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__54(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__55)();
        }

        [CompilerGenerated]
        private void _Lambda$__55()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.USBSettingsNewDev);
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__56(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__57)();
        }

        [CompilerGenerated]
        private void _Lambda$__57()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.FactoryModeDialerTab);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__58(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__59)();
        }

        [CompilerGenerated]
        private void _Lambda$__59()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.IOTHiddenMenu);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__60(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__61)();
        }

        [CompilerGenerated]
        private void _Lambda$__61()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.UltraCfgUSBSettings);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__62(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__63)();
        }

        [CompilerGenerated]
        private void _Lambda$__63()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.EnableHiddenMenu);
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__64(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__65)();
        }

        [CompilerGenerated]
        private void _Lambda$__65()
        {
            this.LaunchPhoneUtility(PhoneUtilityType.DisableHiddenMenu);
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), CompilerGenerated]
        private void _Lambda$__66()
        {
            if (!this.myAndroid.HasConnectedDevices)
            {
                if (!this.myAndroid.ShowWaitDeviceDialog(ref this.myDevice, null, "Please wait while your device reboots...", true))
                {
                    Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
                    if (this.myAndroid != null)
                    {
                        this.myAndroid.Dispose();
                    }
                    ProjectData.EndApp();
                }
            }
            else
            {
                this.myDevice = this.myAndroid.GetConnectedDevice(this.myAndroid.ConnectedDevices[0]);
            }
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__67(object a0)
        {
            this.WritePhoneMode(Conversions.ToString(a0));
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__68(object a0)
        {
            this.WritePhoneMode(Conversions.ToString(a0));
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__69(object a0)
        {
            this.ResetCounterEFS((CounterResetType) Conversions.ToInteger(a0));
        }

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__70(object a0)
        {
            this.ResetCounterEFS((CounterResetType) Conversions.ToInteger(a0));
        }

        [CompilerGenerated, DebuggerStepThrough]
        private void _Lambda$__71(object a0)
        {
            this.ResetCounterEFS((CounterResetType) Conversions.ToInteger(a0));
        }

        [CompilerGenerated]
        private void _Lambda$__75()
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.lvPartitions.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = true;
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

        [CompilerGenerated]
        private void _Lambda$__81()
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.lvBackupContents.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = true;
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

        [DebuggerStepThrough, CompilerGenerated]
        private void _Lambda$__83(object a0)
        {
            new VB$AnonymousDelegate_1(this._Lambda$__84)();
        }

        [CompilerGenerated]
        private void _Lambda$__84()
        {
            string str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, false, "busybox", new string[] { "ls", "-l", this.devStorageLoc + "/EFSProBackup", "|", "busybox", "awk", "'{print $9}'" }));
            this.ScanForBackups_MultiThread(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
            this.EnableControls_MultiThread();
        }

        private void AsyncMethodCompleted(Exception exc, OperationType opType)
        {
            OperationCompletedEventArgs arg = new OperationCompletedEventArgs(exc, opType);
            this.asyncOp.PostOperationCompleted(this.onOperationCompletedDelegate, arg);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            this.RunBackupAsync();
        }

        private void btnbtnManage_Click(object sender, EventArgs e)
        {
            if (this.cbDeviceFilter.SelectedIndex != -1)
            {
                this.tsManFilterEditSel.Enabled = true;
                this.tsManFilterDeleteSel.Enabled = true;
            }
            else
            {
                this.tsManFilterEditSel.Enabled = false;
                this.tsManFilterDeleteSel.Enabled = false;
            }
            this.cmsManageFilters.Show(this.btnManage, (int) Math.Round((double) (((double) (this.btnManage.Width - this.cmsManageFilters.Width)) / 2.0)), this.btnManage.Height + 2);
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.ClearLog_MultiThread();
        }

        private void btnDeselAllRest_Click(object sender, EventArgs e)
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.lvBackupContents.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = false;
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

        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.lvPartitions.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = false;
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

        private void btnDevADBShell_Click(object sender, EventArgs e)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (!(process.MainWindowHandle == IntPtr.Zero) && (process.MainWindowHandle == this.ADB_hWnd))
                {
                    Interaction.MsgBox("Only one ADB Device Shell instance is allowed!", MsgBoxStyle.Information, null);
                    return;
                }
            }
            IntPtr ptr = ADB.StartDeviceADBShell();
            this.ADB_hWnd = ptr;
            if (!(ptr != IntPtr.Zero))
            {
                Interaction.MsgBox("Unable to start ADB Device Shell!", MsgBoxStyle.Exclamation, null);
            }
        }

        private void btnDeviceInfo_Click(object sender, EventArgs e)
        {
            this.DisableControls_MultiThread();
            this.ClearLog_MultiThread();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__29));
        }

        private void btnDeviceToolsExec_Click(object sender, EventArgs e)
        {
            this.DisableControls_MultiThread();
            this.ClearLog_MultiThread();
            if (!File.Exists(Application.StartupPath.ToString() + @"\ADB\adb.exe"))
            {
                Interaction.MsgBox("ADB executable is missing! Cannot continue!", MsgBoxStyle.Critical, null);
                this.EnableControls_MultiThread();
            }
            else
            {
                this.UpdateLogText_MultiThread("Checking device connection...  ", Color.White, false, false, false);
                if (!this.myAndroid.HasConnectedDevices)
                {
                    Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
                    this.UpdateLogText_MultiThread("Device is not connected!", Color.Red, false, false, false);
                    this.EnableControls_MultiThread();
                }
                else
                {
                    this.UpdateLogText_MultiThread("Device is connected!", Color.Lime, false, false, false);
                    if (this.cbOtherTools.SelectedIndex == 0)
                    {
                        if (!EFS_Professional.WinADBHelper.FileSystem.FileExists(this.efsLocation + "/nv_data.bin"))
                        {
                            Interaction.MsgBox("This option cannot be used with your device!", MsgBoxStyle.Information, null);
                            this.UpdateLogText_MultiThread("Operation cancelled!", Color.Yellow, false, true, false);
                            this.EnableControls_MultiThread();
                        }
                        else if (Interaction.MsgBox("You are about to restore the NV data from the internal '*.bak' files in your device's EFS folder if they exist.\r\n\r\nUse this option only if your device has a corrupted EFS folder and/or your device displays a corrupt or incorrect IMEI number and you do not have a valid EFS backup.\r\n\r\nPress OK if you want to continue or Cancel.", MsgBoxStyle.Exclamation | MsgBoxStyle.OkCancel, null) == MsgBoxResult.Cancel)
                        {
                            this.UpdateLogText_MultiThread("Operation cancelled!", Color.Yellow, false, true, false);
                            this.EnableControls_MultiThread();
                        }
                        else
                        {
                            this.asyncOp = AsyncOperationManager.CreateOperation(null);
                            this.workerThread = new Thread(new ThreadStart(this.RepairNVFromBAK));
                            this.workerThread.Start();
                        }
                    }
                    else if (this.cbOtherTools.SelectedIndex == 1)
                    {
                        if (!EFS_Professional.WinADBHelper.FileSystem.FileExists(this.efsLocation + "/nv_data.bin"))
                        {
                            Interaction.MsgBox("This option cannot be used with your device!", MsgBoxStyle.Information, null);
                            this.UpdateLogText_MultiThread("Operation cancelled!", Color.Yellow, false, true, false);
                            this.EnableControls_MultiThread();
                        }
                        else if (Interaction.MsgBox("You are about to repair the ownership of 'nv_data.bin' in your device's EFS folder.\r\n\r\nUse this option only if your device has 'Unknown baseband' and/or 'No signal' and you have already restored a valid EFS backup.\r\n\r\nPress OK if you want to continue or Cancel.", MsgBoxStyle.Exclamation | MsgBoxStyle.OkCancel, null) == MsgBoxResult.Cancel)
                        {
                            this.UpdateLogText_MultiThread("Operation cancelled!", Color.Yellow, false, true, false);
                            this.EnableControls_MultiThread();
                        }
                        else
                        {
                            this.asyncOp = AsyncOperationManager.CreateOperation(null);
                            this.workerThread = new Thread(new ThreadStart(this.RepairNVOwner));
                            this.workerThread.Start();
                        }
                    }
                    else if (this.cbOtherTools.SelectedIndex == 2)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ThreadStart(this.FixKeystr));
                        this.workerThread.Start();
                    }
                    else if (this.cbOtherTools.SelectedIndex == 3)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ThreadStart(this.ReadPhoneMode));
                        this.workerThread.Start();
                    }
                    else if (this.cbOtherTools.SelectedIndex == 4)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ParameterizedThreadStart(this._Lambda$__67));
                        this.workerThread.Start("ON");
                    }
                    else if (this.cbOtherTools.SelectedIndex == 5)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ParameterizedThreadStart(this._Lambda$__68));
                        this.workerThread.Start("OFF");
                    }
                    else if (this.cbOtherTools.SelectedIndex == 6)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ThreadStart(this.ExtractPIT));
                        this.workerThread.Start();
                    }
                    else if (this.cbOtherTools.SelectedIndex == 7)
                    {
                        if (Interaction.MsgBox("Formatting EFS folder will completely destroy all its contents.\r\nOnly proceed if you know what you are doing and ensure you have made a backup first!\r\n\r\nPress OK if you want to continue or Cancel.", MsgBoxStyle.Exclamation | MsgBoxStyle.OkCancel, "WARNING!") == MsgBoxResult.Cancel)
                        {
                            this.UpdateLogText_MultiThread("Operation cancelled!", Color.Yellow, false, true, false);
                            this.EnableControls_MultiThread();
                        }
                        else
                        {
                            this.asyncOp = AsyncOperationManager.CreateOperation(null);
                            this.workerThread = new Thread(new ThreadStart(this.FormatEFS));
                            this.workerThread.Start();
                        }
                    }
                    else if (this.cbOtherTools.SelectedIndex == 8)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ParameterizedThreadStart(this._Lambda$__69));
                        this.workerThread.Start(CounterResetType.BatteryCableCounter);
                    }
                    else if (this.cbOtherTools.SelectedIndex == 9)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ParameterizedThreadStart(this._Lambda$__70));
                        this.workerThread.Start(CounterResetType.SPenCounter);
                    }
                    else if (this.cbOtherTools.SelectedIndex == 10)
                    {
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ParameterizedThreadStart(this._Lambda$__71));
                        this.workerThread.Start(CounterResetType.EarphoneJackCounter);
                    }
                }
            }
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            this.ShowDonateDialog();
        }

        private void btnGetEFSMountpoint_Click(object sender, EventArgs e)
        {
            this.ClearLog_MultiThread();
            this.UpdateLogText_MultiThread("EFS Mountpoint Query:", Color.Yellow, false, false, true);
            this.UpdateLogText_MultiThread("---------------------", Color.Yellow, false, false, true);
            if (BusyBox.IsInstalled)
            {
                string str;
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    str = "/factory";
                }
                else
                {
                    str = "/efs";
                }
                string mountPoint = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint(str);
                this.UpdateLogText_MultiThread("Mount Folder: ", Color.Yellow, false, false, false);
                this.UpdateLogText_MultiThread(str, Color.White, false, false, true);
                this.UpdateLogText_MultiThread("Mountpoint: ", Color.Yellow, false, false, false);
                this.UpdateLogText_MultiThread(mountPoint, Color.White, false, false, true);
            }
            else
            {
                this.UpdateLogText_MultiThread("BusyBox is not installed!", Color.White, false, false, true);
            }
        }

        private void btnGetPartList_Click(object sender, EventArgs e)
        {
            this.ClearLog_MultiThread();
            this.UpdateLogText_MultiThread("Device Partition List:", Color.Yellow, false, false, true);
            this.UpdateLogText_MultiThread("----------------------", Color.Yellow, false, false, true);
            try
            {
                List<PartitionInfo> samsungPartitions;
                List<PartitionInfo>.Enumerator enumerator;
                string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
                string pitFile = this.AppPath + @"\PIT\" + str + ".pit";
                if (this.samsungMode)
                {
                    samsungPartitions = EFS_Professional.WinADBHelper.FileSystem.GetSamsungPartitions(pitFile);
                }
                else
                {
                    samsungPartitions = EFS_Professional.WinADBHelper.FileSystem.GetPartitions();
                }
                try
                {
                    enumerator = samsungPartitions.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        PartitionInfo current = enumerator.Current;
                        this.UpdateLogText_MultiThread(current.PartitionName, Color.Cyan, true, false, false);
                        this.UpdateLogText_MultiThread(current.BlockPath, Color.Magenta, false, false, true);
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, "Error!");
                ProjectData.ClearProjectError();
            }
        }

        private void btnGetPropQuery_Click(object sender, EventArgs e)
        {
            string propList = BuildPropertyParser.GetPropList();
            this.ClearLog_MultiThread();
            this.UpdateLogText_MultiThread("Build Property List:", Color.Yellow, false, false, true);
            this.UpdateLogText_MultiThread("--------------------", Color.Yellow, false, false, true);
            if (this.chkUseBPP.Checked)
            {
                this.UpdateLogText_MultiThread(propList, Color.White, false, false, true);
            }
            else
            {
                ADB.IssueADBCmdASync(this.myProcess, ADB.CreateADBShellCmd(this.myDevice, false, "getprop", new string[] { null }));
            }
        }

        private void btnLaunchPhSVCApp_Click(object sender, EventArgs e)
        {
            this.DisableControls_MultiThread();
            this.ClearLog_MultiThread();
            if (!File.Exists(Application.StartupPath.ToString() + @"\ADB\adb.exe"))
            {
                Interaction.MsgBox("ADB executable is missing! Cannot continue!", MsgBoxStyle.Critical, null);
                this.EnableControls_MultiThread();
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 0)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__46));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 1)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__48));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 2)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__50));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 3)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__52));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 4)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__54));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 5)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__56));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 6)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__58));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 7)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__60));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 8)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__62));
            }
            else if (this.cbPhoneSVCApps.SelectedIndex == 9)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__64));
            }
        }

        private void btnQCNVTools_Click(object sender, EventArgs e)
        {
            IEnumerator enumerator;
            _Closure$__7 e$__ = new _Closure$__7 {
                $VB$Me = this
            };
            bool flag = true;
            e$__.$VB$Local_instanceQCNVTools = null;
            e$__.$VB$Local_checkAutoSwitch = this.chkSwitchAuto.CheckState > CheckState.Unchecked;
            e$__.$VB$Local_prevIndex = this.cbCurrUSBSettings.SelectedIndex;
            this.DisableControls_MultiThread();
            this.ClearLog_MultiThread();
            try
            {
                enumerator = this.tcEFSProUI.TabPages.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    TabPage current = (TabPage) enumerator.Current;
                    if ((current.Name == "tabBackup") || (current.Name == "tabRestore"))
                    {
                        flag = false;
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
            if (flag)
            {
                this.UpdateLogText_MultiThread("Opened Qualcomm NV Tools...", Color.Yellow, false, false, true);
                e$__.$VB$Local_instanceQCNVTools = new frmQualcommNVTools();
                e$__.$VB$Local_instanceQCNVTools.ShowDialog();
                e$__.$VB$Local_instanceQCNVTools.Dispose();
                this.UpdateLogText_MultiThread("Closed Qualcomm NV Tools...", Color.Yellow, false, false, false);
                this.EnableControls_MultiThread();
            }
            else
            {
                try
                {
                    ThreadPool.QueueUserWorkItem(new WaitCallback(e$__._Lambda$__31));
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox(exception.Message, MsgBoxStyle.Critical, null);
                    this.EnableControls_MultiThread();
                    ProjectData.ClearProjectError();
                }
            }
        }

        private void btnRebootGo_Click(object sender, EventArgs e)
        {
            if (this.cbRebootOpt.SelectedIndex == 0)
            {
                this.rtConsoleLog.Clear();
                this.UpdateLogText_MultiThread("Command sent:  ", Color.White, false, false, false);
                this.UpdateLogText_MultiThread("reboot", Color.Lime, false, false, false);
                ADB.Reboot(true);
            }
            else if (this.cbRebootOpt.SelectedIndex == 1)
            {
                this.rtConsoleLog.Clear();
                this.UpdateLogText_MultiThread("Command sent:  ", Color.White, false, false, false);
                this.UpdateLogText_MultiThread("reboot download", Color.Lime, false, false, false);
                ADB.RebootDownload(true);
            }
            else if (this.cbRebootOpt.SelectedIndex == 2)
            {
                this.rtConsoleLog.Clear();
                this.UpdateLogText_MultiThread("Command sent:  ", Color.White, false, false, false);
                this.UpdateLogText_MultiThread("reboot recovery", Color.Lime, false, false, false);
                ADB.RebootRecovery(true);
            }
            else if (this.cbRebootOpt.SelectedIndex == 3)
            {
                this.rtConsoleLog.Clear();
                this.UpdateLogText_MultiThread("Command sent:  ", Color.White, false, false, false);
                this.UpdateLogText_MultiThread("reboot bootloader", Color.Lime, false, false, false);
                ADB.RebootBootLoader(true);
            }
        }

        private void btnRefreshBackups_Click(object sender, EventArgs e)
        {
            this.DisableControls_MultiThread();
            this.lvBackupContents.Items.Clear();
            if (!File.Exists(Application.StartupPath.ToString() + @"\ADB\adb.exe"))
            {
                Interaction.MsgBox("ADB executable is missing! Cannot continue!", MsgBoxStyle.Critical, null);
            }
            else
            {
                this.RefreshBackupArchList();
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            this.RefreshPartitionList();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (this.cbBackupArchives.Items.Count == 0)
            {
                Interaction.MsgBox("No Backup archives to restore!", MsgBoxStyle.Information, null);
            }
            else if (this.lvBackupContents.CheckedItems.Count == 0)
            {
                Interaction.MsgBox("You must select at least one partition to restore!", MsgBoxStyle.Exclamation, null);
            }
            else
            {
                this.DisableControls_MultiThread();
                this.asyncOp = AsyncOperationManager.CreateOperation(null);
                this.workerThread = new Thread(new ThreadStart(this.RunRestore));
                this.workerThread.Start();
            }
        }

        private void btnSelAllRest_Click(object sender, EventArgs e)
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.lvBackupContents.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = true;
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

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            IEnumerator enumerator;
            try
            {
                enumerator = this.lvPartitions.Items.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    ListViewItem current = (ListViewItem) enumerator.Current;
                    current.Checked = true;
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

        private void btnTestBBPresence_Click(object sender, EventArgs e)
        {
            this.ClearLog_MultiThread();
            this.UpdateLogText_MultiThread("BusyBox Presence Test:", Color.Yellow, false, false, true);
            this.UpdateLogText_MultiThread("----------------------", Color.Yellow, false, false, true);
            if (BusyBox.IsInstalled)
            {
                this.UpdateLogText_MultiThread("BusyBox is installed!", Color.White, false, false, true);
            }
            else
            {
                this.UpdateLogText_MultiThread("BusyBox is not installed!", Color.White, false, false, true);
            }
        }

        private void btnTestRootPerm_Click(object sender, EventArgs e)
        {
            this.ClearLog_MultiThread();
            this.UpdateLogText_MultiThread("Root Permissions Test:", Color.Yellow, false, false, true);
            this.UpdateLogText_MultiThread("----------------------", Color.Yellow, false, false, true);
            if (this.myDevice.IsRooted() == DeviceIO.RootAccessType.PermRooted)
            {
                this.UpdateLogText_MultiThread("Device is Perm Rooted!", Color.White, false, false, true);
            }
            else if (this.myDevice.IsRooted() == DeviceIO.RootAccessType.TempRooted)
            {
                this.UpdateLogText_MultiThread("Device is Temp Rooted!", Color.White, false, false, true);
            }
            else if (this.myDevice.IsRooted() == DeviceIO.RootAccessType.NotRooted)
            {
                this.UpdateLogText_MultiThread("Device is not Rooted!", Color.White, false, false, true);
            }
        }

        private void btnTestWaitDevice_Click(object sender, EventArgs e)
        {
            this.ClearLog_MultiThread();
            this.UpdateLogText_MultiThread("WaitDeviceDialog Test:", Color.Yellow, false, false, true);
            this.UpdateLogText_MultiThread("----------------------", Color.Yellow, false, false, true);
            if (!this.myAndroid.ShowWaitDeviceDialog(ref this.myDevice, null, "Testing USB connection...", false))
            {
                this.UpdateLogText_MultiThread("Device not connected!", Color.White, false, false, true);
            }
            else
            {
                this.UpdateLogText_MultiThread("Device is connected!", Color.White, false, false, true);
            }
        }

        private void cbBackupArchives_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Closure$__11 e$__ = new _Closure$__11 {
                $VB$Me = this
            };
            if (this.cbBackupArchives.SelectedIndex != -1)
            {
                e$__.$VB$Local_copyToDevice = false;
                string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
                e$__.$VB$Local_devicePIT = this.AppPath + @"\PIT\" + str + ".pit";
                this.DisableControls_MultiThread();
                this.lvBackupContents.Items.Clear();
                this.devicePartitions.Clear();
                this.ClearLog_MultiThread();
                if (!File.Exists(Application.StartupPath.ToString() + @"\ADB\adb.exe"))
                {
                    Interaction.MsgBox("ADB executable is missing! Cannot continue!", MsgBoxStyle.Critical, null);
                    this.EnableControls_MultiThread();
                }
                else
                {
                    this.UpdateLogText_MultiThread("Checking device connection...  ", Color.White, false, false, false);
                    if (!this.myAndroid.HasConnectedDevices)
                    {
                        Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
                        this.UpdateLogText_MultiThread("Device is not connected!", Color.Red, false, false, false);
                        this.EnableControls_MultiThread();
                    }
                    else
                    {
                        this.UpdateLogText_MultiThread("Device is connected!", Color.Lime, false, false, true);
                        ThreadPool.QueueUserWorkItem(new WaitCallback(e$__._Lambda$__77));
                    }
                }
            }
        }

        private void cbCurrUSBSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.DisableControls_MultiThread();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__42));
        }

        private void cbDeviceFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshPartitionList();
        }

        private void cbOtherTools_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbOtherTools.SelectedIndex == -1)
            {
                this.lblOtherToolsDesc.Text = string.Empty;
            }
            else if (this.cbOtherTools.SelectedIndex == 0)
            {
                this.lblOtherToolsDesc.Text = "Restores 'nv_data.bin' from the internal backup stored in your '/efs' folder (if supported).";
            }
            else if (this.cbOtherTools.SelectedIndex == 1)
            {
                this.lblOtherToolsDesc.Text = "Repairs 'nv_data.bin' file permissions to fix 'Unknown Baseband' and 'No Signal' issues (if supported).";
            }
            else if (this.cbOtherTools.SelectedIndex == 2)
            {
                this.lblOtherToolsDesc.Text = "Modifies 'keystr' file to fix Lock Screen display issues and loss of Power Button Menu when power button is long-pressed.";
            }
            else if (this.cbOtherTools.SelectedIndex == 3)
            {
                this.lblOtherToolsDesc.Text = "Reads current phone mode; USER MODE / FACTORY MODE.";
            }
            else if (this.cbOtherTools.SelectedIndex == 4)
            {
                this.lblOtherToolsDesc.Text = "Changes phone mode to USER MODE - Normal operation.";
            }
            else if (this.cbOtherTools.SelectedIndex == 5)
            {
                this.lblOtherToolsDesc.Text = "Changes phone mode to FACTORY MODE - Factory info will be displayed on the device's screen.";
            }
            else if (this.cbOtherTools.SelectedIndex == 6)
            {
                this.lblOtherToolsDesc.Text = "Extracts the full CSB signed PIT file from your device and places it in the current working folder on your PC.";
            }
            else if (this.cbOtherTools.SelectedIndex == 7)
            {
                this.lblOtherToolsDesc.Text = "Formats the '/efs' folder on your device erasing all data contained within and repairs the folder's permissions.";
            }
            else if (this.cbOtherTools.SelectedIndex == 8)
            {
                this.lblOtherToolsDesc.Text = "Resets the Battery Cable Counter located in the '/efs' folder to zero (if supported).";
            }
            else if (this.cbOtherTools.SelectedIndex == 9)
            {
                this.lblOtherToolsDesc.Text = "Resets the SPen Counter located in the '/efs' folder to zero (if supported).";
            }
            else if (this.cbOtherTools.SelectedIndex == 10)
            {
                this.lblOtherToolsDesc.Text = "Resets the Earphone Jack Counter located in the '/efs' folder (if supported).";
            }
        }

        private void ChangeUSBMode(int index)
        {
            this.cbCurrUSBSettings.SelectedIndex = index;
        }

        private void ChangeUSBMode_MultiThread(int index)
        {
            if (this.InvokeRequired)
            {
                ChangeUSBMode_Delegate method = new ChangeUSBMode_Delegate(this.ChangeUSBMode);
                this.Invoke(method, new object[] { index });
            }
            else
            {
                this.ChangeUSBMode(index);
            }
        }

        private void CheckAppConfig()
        {
            string str;
            if (this.cbPITBufferSize.SelectedIndex != -1)
            {
                str = this.cbPITBufferSize.SelectedItem.ToString();
                str = str.Remove(str.IndexOf(" "));
            }
            else
            {
                this.cbPITBufferSize.SelectedIndex = 0;
                str = "1024";
            }
            if (((this.chkEnableAppDebug.Checked & (this.appDebug == 0)) || (!this.chkEnableAppDebug.Checked & (this.appDebug == 1))) || ((this.txtDevStorageLoc.Text != this.devStorageLoc) || (Conversions.ToInteger(str) != this.pitBufferSize)))
            {
                this.appConfigChanged = true;
            }
            if (this.appConfigChanged)
            {
                this.WriteAppConfig(this.AppPath + @"\" + this.appConfigFile);
                this.appConfigChanged = false;
            }
        }

        private bool CheckMD5Sum(string partitionSource, string filenameTarget)
        {
            this.UpdateLogText_MultiThread("Verifying MD5 Checksum...  ", Color.White, false, true, false);
            string logText = EFS_Professional.WinADBHelper.FileSystem.MD5Sum(partitionSource);
            string str2 = EFS_Professional.WinADBHelper.FileSystem.MD5Sum(filenameTarget);
            if (logText == str2)
            {
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                this.UpdateLogText_MultiThread("Device MD5 Hash:  ", Color.White, true, true, false);
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, false);
                this.UpdateLogText_MultiThread("Backup Data MD5 Hash:  ", Color.White, true, true, false);
                this.UpdateLogText_MultiThread(str2, Color.Yellow, false, false, false);
                return true;
            }
            if (logText.ToLower().Contains("md5sum applet not found"))
            {
                this.UpdateLogText_MultiThread("Failed!", Color.Red, false, false, false);
                this.UpdateLogText_MultiThread("Error: md5sum Applet Not Found!", Color.Red, false, true, false);
                return false;
            }
            this.UpdateLogText_MultiThread("Failed!", Color.Red, false, false, false);
            this.UpdateLogText_MultiThread("Device MD5 Hash:  ", Color.White, true, true, false);
            this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, false);
            this.UpdateLogText_MultiThread("Backup Data MD5 Hash:  ", Color.White, true, true, false);
            this.UpdateLogText_MultiThread(str2, Color.Yellow, false, false, false);
            this.UpdateLogText_MultiThread("Error: MD5 Checksum Mismatch!!!", Color.Red, false, true, false);
            this.UpdateLogText_MultiThread("DO NOT USE THIS BACKUP!!!", Color.Red, false, true, false);
            return false;
        }

        public void CleanUpTempFiles()
        {
            if (EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(this.devStorageLoc + "/EFSProBackup/temp", false))
            {
                ADB.IssueADBCmdNoOutput(ADB.CreateADBShellCmd(this.myDevice, true, "busybox rm -rf", new string[] { this.devStorageLoc + "/EFSProBackup/temp" }));
            }
        }

        private void ClearLog()
        {
            this.rtConsoleLog.Clear();
            this.rtConsoleLog.Refresh();
        }

        private void ClearLog_MultiThread()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ClearLog_Delegate(this.ClearLog));
            }
            else
            {
                this.ClearLog();
            }
        }

        private void DisableControls()
        {
            this.ControlBox = false;
            this.tcEFSProUI.Enabled = false;
            this.btnDonate.Enabled = false;
            this.btnDeviceInfo.Enabled = false;
            this.btnClearLog.Enabled = false;
            this.Refresh();
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

        private void DoOperationCompleted(object operationState)
        {
            OperationCompletedEventArgs e = (OperationCompletedEventArgs) operationState;
            this.OnOperationCompleted(e);
        }

        private void EnableControls()
        {
            this.ControlBox = true;
            this.tcEFSProUI.Enabled = true;
            this.btnDonate.Enabled = true;
            this.btnDeviceInfo.Enabled = true;
            this.btnClearLog.Enabled = true;
            this.Refresh();
        }

        private void EnableControls_MultiThread()
        {
            EnableControls_Delegate method = new EnableControls_Delegate(this.EnableControls);
            this.Invoke(method);
        }

        private void ExtractPIT()
        {
            string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
            string path = this.AppPath + @"\PIT\" + str + ".pit";
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Extracting PIT file from device...  ", Color.White, false, true, false);
                if (File.Exists(path))
                {
                    this.UpdateLogText_MultiThread("PIT file already exists!", Color.Yellow, false, false, false);
                }
                else
                {
                    if (!Directory.Exists(this.AppPath + @"\PIT"))
                    {
                        Directory.CreateDirectory(this.AppPath + @"\PIT");
                    }
                    if (!EFS_Professional.WinADBHelper.FileSystem.GetDevicePIT(this.AppPath + @"\PIT", ref path, this.devStorageLoc, this.pitBufferSize))
                    {
                        throw new Exception("Unable to extract PIT file from device!");
                    }
                    path = path.Insert(0, this.AppPath + @"\PIT\");
                    this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                }
                this.UpdateLogText_MultiThread("Checking PIT file integrity...  ", Color.White, false, true, false);
                if (EFS_Professional.WinADBHelper.FileSystem.ParsePIT(path) == null)
                {
                    throw new Exception("The PIT file is corrupt or invalid!");
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private void FixKeystr()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            string logText = string.Empty;
            string str3 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected EFS partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str3 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str3 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", logText, str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                if (EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(str3 + "/FactoryApp", false))
                {
                    str2 = str3 + "/FactoryApp";
                }
                else
                {
                    str2 = str3 + "/imei";
                }
                this.UpdateLogText_MultiThread("Fixing '" + str2 + "/keystr'...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "echo", new string[] { "-n ON > " + str2 + "/keystr" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Setting Permissions of '" + str2 + "/keystr'...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "chown", new string[] { "1001:1001 " + str2 + "/keystr" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private void FormatEFS()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            string logText = string.Empty;
            string str3 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected '/efs' partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str3 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str3 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Detected '/efs' file system type:  ", Color.White, false, false, false);
                str2 = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, false, "mount | busybox grep " + str3 + " | busybox awk '{print $3}'", new string[0]));
                if (!str2.Contains("exitcode=0"))
                {
                    throw new Exception(str2.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread(str2.Remove(str2.IndexOf("exitcode=0")).Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids), Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Unmounting '/efs' folder...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "umount", new string[] { str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Formatting '/efs' folder...  ", Color.Cyan, false, false, true);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "busybox rm -rf", new string[] { str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mkdir", new string[] { str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "chmod", new string[] { "0771", str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "chown", new string[] { "radio.system", str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mke2fs", new string[] { logText }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids), Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-w", "-o nosuid,nodev", "-t", str2, logText, str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private void frmEFSProMain_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            this.TimerIn.Interval = 20;
            this.TimerIn.Enabled = true;
            this.TimerOut.Interval = 20;
            this.TimerOut.Enabled = false;
        }

        private void frmEFSProMain_Shown(object sender, EventArgs e)
        {
            _Closure$__5 e$__ = new _Closure$__5 {
                $VB$Me = this
            };
            this.DisableControls_MultiThread();
            ThreadPool.QueueUserWorkItem(new WaitCallback(e$__._Lambda$__20));
        }

        private void GetDeviceInfo()
        {
            this.UpdateLogText_MultiThread("---------- Hardware Information ----------", Color.Yellow, true, false, true);
            this.UpdateLogText_MultiThread("Connected Device SN.:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(this.myDevice.SerialNumber, Color.Lime, false, false, true);
            this.UpdateLogText_MultiThread("Device Manufacturer:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ro.product.manufacturer").ToUpper(), Color.Lime, false, false, true);
            this.UpdateLogText_MultiThread("Device Model:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ro.product.model"), Color.Lime, false, false, true);
            if (this.samsungMode)
            {
                this.UpdateLogText_MultiThread("Product Code:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ril.product_code"), Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Hardware Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ril.hw_ver"), Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("---------- Firmware Information ----------", Color.Yellow, true, true, true);
                this.UpdateLogText_MultiThread("PDA Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ro.build.PDA"), Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Baseband Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ril.sw_ver"), Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("CSC Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ril.official_cscver"), Color.Lime, false, false, true);
            }
            this.UpdateLogText_MultiThread("---------- Software Information ----------", Color.Yellow, true, true, true);
            this.UpdateLogText_MultiThread("Kernel Release:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(KernelInfo.Release, Color.Lime, false, false, true);
            this.UpdateLogText_MultiThread("Kernel Version:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(KernelInfo.Version, Color.Lime, false, false, true);
            this.UpdateLogText_MultiThread("ROM Build:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ro.build.description"), Color.Lime, false, false, true);
            this.UpdateLogText_MultiThread("Android Version:  ", Color.White, true, false, false);
            this.UpdateLogText_MultiThread(BuildPropertyParser.GetProperty("ro.build.version.release"), Color.Lime, false, false, true);
            if (BusyBox.IsInstalled)
            {
                this.UpdateLogText_MultiThread("BusyBox Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(BusyBox.Version, Color.Lime, false, false, true);
            }
            else
            {
                this.UpdateLogText_MultiThread("BusyBox Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread("Not Present!", Color.Lime, false, false, true);
            }
            if (SU_Binary.IsPresent)
            {
                this.UpdateLogText_MultiThread("SU Binary Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread(this.myDevice.SUBinary.Version, Color.Lime, false, false, false);
            }
            else
            {
                this.UpdateLogText_MultiThread("SU Binary Version:  ", Color.White, true, false, false);
                this.UpdateLogText_MultiThread("Not Present!", Color.Lime, false, false, false);
            }
            this.EnableControls_MultiThread();
        }

        private List<PartitionInfo> GetSelectedPartitions(SelectedPartitionsMode mode)
        {
            List<PartitionInfo> list2 = new List<PartitionInfo>();
            if (mode == SelectedPartitionsMode.Backup)
            {
                int num3 = this.lvPartitions.Items.Count - 1;
                for (int i = 0; i <= num3; i++)
                {
                    if (this.lvPartitions.Items[i].Checked)
                    {
                        string text = this.lvPartitions.Items[i].Text;
                        string partitionName = this.lvPartitions.Items[i].SubItems[1].Text;
                        foreach (PartitionInfo info in this.devicePartitions)
                        {
                            if (info.PartitionName.ToLower() == partitionName.ToLower())
                            {
                                list2.Add(new PartitionInfo(partitionName, info.FlashFileName, text, info.BlockName));
                                break;
                            }
                        }
                    }
                }
                return list2;
            }
            if (mode == SelectedPartitionsMode.Restore)
            {
                int num4 = this.lvBackupContents.Items.Count - 1;
                for (int j = 0; j <= num4; j++)
                {
                    if (this.lvBackupContents.Items[j].Checked)
                    {
                        string blockPath = this.lvBackupContents.Items[j].Text;
                        string flashFileName = this.lvBackupContents.Items[j].SubItems[1].Text;
                        foreach (PartitionInfo info2 in this.devicePartitions)
                        {
                            if (info2.FlashFileName.ToLower() == flashFileName.ToLower())
                            {
                                list2.Add(new PartitionInfo(info2.PartitionName, flashFileName, blockPath, info2.BlockName));
                                break;
                            }
                        }
                    }
                }
            }
            return list2;
        }

        public List<PartitionInfo> GetSelectedPartitions_MultiThread(SelectedPartitionsMode mode)
        {
            if (this.InvokeRequired)
            {
                GetSelectedPartitions_Delegate method = new GetSelectedPartitions_Delegate(this.GetSelectedPartitions);
                return (List<PartitionInfo>) this.Invoke(method, new object[] { mode });
            }
            return this.GetSelectedPartitions(mode);
        }

        [DebuggerStepThrough]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmEFSProMain));
            this.btnRefreshList = new Button();
            this.btnManage = new Button();
            this.chkEnableMD5Backup = new CheckBox();
            this.btnDeselectAll = new Button();
            this.lvPartitions = new ListView();
            this.hdrBlockDevice = new ColumnHeader();
            this.hdrPartitionName = new ColumnHeader();
            this.tabRestore = new TabPage();
            this.gbBackupArchives = new GroupBox();
            this.cbBackupArchives = new ComboBox();
            this.btnRefreshBackups = new Button();
            this.gbBackArchCont = new GroupBox();
            this.btnSelAllRest = new Button();
            this.btnDeselAllRest = new Button();
            this.lvBackupContents = new ListView();
            this.hdrTargetBlockDevice = new ColumnHeader();
            this.hdrFlashFileName = new ColumnHeader();
            this.gbRestoreOptions = new GroupBox();
            this.chkRbtDevAftRestore = new CheckBox();
            this.chkEnableMD5Restore = new CheckBox();
            this.btnRestore = new Button();
            this.tabSamsungTools = new TabPage();
            this.gbOtherTools = new GroupBox();
            this.lblOtherToolsDescTitle = new Label();
            this.lblOtherToolsDesc = new Label();
            this.lblOtherToolsInfo = new Label();
            this.btnDeviceToolsExec = new Button();
            this.cbOtherTools = new ComboBox();
            this.gbPhoneSVCApps = new GroupBox();
            this.cbPhoneSVCApps = new ComboBox();
            this.btnLaunchPhSVCApp = new Button();
            this.lblLaunchPhSVCAppInfo = new Label();
            this.gbQCDevSupport = new GroupBox();
            this.lblQCDevSuppInfo = new Label();
            this.cbCurrUSBSettings = new ComboBox();
            this.chkSwitchAuto = new CheckBox();
            this.lblCurrUSBSettings = new Label();
            this.btnQCNVTools = new Button();
            this.btnDonate = new Button();
            this.btnGetPropQuery = new Button();
            this.gbBuildProps = new GroupBox();
            this.chkUseBPP = new CheckBox();
            this.btnGetEFSMountpoint = new Button();
            this.btnGetPartList = new Button();
            this.gbMountPart = new GroupBox();
            this.btnSelectAll = new Button();
            this.btnTestWaitDevice = new Button();
            this.btnTestRootPerm = new Button();
            this.btnTestBBPresence = new Button();
            this.tabDebug = new TabPage();
            this.gbRebootOptions = new GroupBox();
            this.cbRebootOpt = new ComboBox();
            this.btnRebootGo = new Button();
            this.lblAppDebug = new Label();
            this.btnDevADBShell = new Button();
            this.gbTests = new GroupBox();
            this.cbDeviceFilter = new ComboBox();
            this.tcEFSProUI = new TabControl();
            this.tabInformation = new TabPage();
            this.txtInformation = new TextBox();
            this.lblDisclaimer = new Label();
            this.lblDisclaimerInfo = new Label();
            this.tabBackup = new TabPage();
            this.gbDeviceFilters = new GroupBox();
            this.gbBackupOptions = new GroupBox();
            this.gbDevPartitions = new GroupBox();
            this.btnBackup = new Button();
            this.tabAppConfig = new TabPage();
            this.gbAppConfig = new GroupBox();
            this.gbPITOptions = new GroupBox();
            this.lblPITBuffDefault = new Label();
            this.cbPITBufferSize = new ComboBox();
            this.lblPITBufferSize = new Label();
            this.lblPITBuffInfo = new Label();
            this.lblEnableAppDebugInfo = new Label();
            this.gbDevStorageOpt = new GroupBox();
            this.txtDevStorageLoc = new TextBox();
            this.lblDevStorageLoc = new Label();
            this.lblDevStorageLocInfo = new Label();
            this.chkEnableAppDebug = new CheckBox();
            this.lblVersionInfo = new Label();
            this.btnClearLog = new Button();
            this.TimerIn = new System.Windows.Forms.Timer(this.components);
            this.TimerOut = new System.Windows.Forms.Timer(this.components);
            this.rtConsoleLog = new RichTextBox();
            this.btnDeviceInfo = new Button();
            this.cmsManageFilters = new ContextMenuStrip(this.components);
            this.tsManFilterCreateNew = new ToolStripMenuItem();
            this.tsManFilterEditSel = new ToolStripMenuItem();
            this.tsManFilterDeleteSel = new ToolStripMenuItem();
            this.tsManFilterRefresh = new ToolStripMenuItem();
            this.TimerTrigger = new System.Windows.Forms.Timer(this.components);
            this.CheckBox1 = new CheckBox();
            this.tabRestore.SuspendLayout();
            this.gbBackupArchives.SuspendLayout();
            this.gbBackArchCont.SuspendLayout();
            this.gbRestoreOptions.SuspendLayout();
            this.tabSamsungTools.SuspendLayout();
            this.gbOtherTools.SuspendLayout();
            this.gbPhoneSVCApps.SuspendLayout();
            this.gbQCDevSupport.SuspendLayout();
            this.gbBuildProps.SuspendLayout();
            this.gbMountPart.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.gbRebootOptions.SuspendLayout();
            this.gbTests.SuspendLayout();
            this.tcEFSProUI.SuspendLayout();
            this.tabInformation.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.gbDeviceFilters.SuspendLayout();
            this.gbBackupOptions.SuspendLayout();
            this.gbDevPartitions.SuspendLayout();
            this.tabAppConfig.SuspendLayout();
            this.gbAppConfig.SuspendLayout();
            this.gbPITOptions.SuspendLayout();
            this.gbDevStorageOpt.SuspendLayout();
            this.cmsManageFilters.SuspendLayout();
            this.SuspendLayout();
            Point point2 = new Point(0xbf, 0xc7);
            this.btnRefreshList.Location = point2;
            this.btnRefreshList.Name = "btnRefreshList";
            Size size2 = new Size(0x51, 0x17);
            this.btnRefreshList.Size = size2;
            this.btnRefreshList.TabIndex = 0x15;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            point2 = new Point(0xfd, 0x2e);
            this.btnManage.Location = point2;
            this.btnManage.Name = "btnManage";
            size2 = new Size(0x51, 0x17);
            this.btnManage.Size = size2;
            this.btnManage.TabIndex = 5;
            this.btnManage.Text = "Manage >>";
            this.btnManage.UseVisualStyleBackColor = true;
            this.chkEnableMD5Backup.AutoSize = true;
            this.chkEnableMD5Backup.Checked = true;
            this.chkEnableMD5Backup.CheckState = CheckState.Checked;
            point2 = new Point(6, 0x13);
            this.chkEnableMD5Backup.Location = point2;
            this.chkEnableMD5Backup.Name = "chkEnableMD5Backup";
            size2 = new Size(0xc1, 0x11);
            this.chkEnableMD5Backup.Size = size2;
            this.chkEnableMD5Backup.TabIndex = 0x10;
            this.chkEnableMD5Backup.Text = "Enable MD5 Checksum Verification";
            this.chkEnableMD5Backup.UseVisualStyleBackColor = true;
            point2 = new Point(0x63, 0xc7);
            this.btnDeselectAll.Location = point2;
            this.btnDeselectAll.Name = "btnDeselectAll";
            size2 = new Size(0x51, 0x17);
            this.btnDeselectAll.Size = size2;
            this.btnDeselectAll.TabIndex = 20;
            this.btnDeselectAll.Text = "Deselect All";
            this.btnDeselectAll.UseVisualStyleBackColor = true;
            this.lvPartitions.CheckBoxes = true;
            this.lvPartitions.Columns.AddRange(new ColumnHeader[] { this.hdrBlockDevice, this.hdrPartitionName });
            this.lvPartitions.FullRowSelect = true;
            this.lvPartitions.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            point2 = new Point(6, 0x13);
            this.lvPartitions.Location = point2;
            this.lvPartitions.Name = "lvPartitions";
            size2 = new Size(0x10a, 0xaf);
            this.lvPartitions.Size = size2;
            this.lvPartitions.TabIndex = 0;
            this.lvPartitions.UseCompatibleStateImageBehavior = false;
            this.lvPartitions.View = View.Details;
            this.hdrBlockDevice.Text = "Block Device";
            this.hdrBlockDevice.Width = 0x9b;
            this.hdrPartitionName.Text = "Partition Name";
            this.hdrPartitionName.Width = 0x58;
            this.tabRestore.Controls.Add(this.gbBackupArchives);
            this.tabRestore.Controls.Add(this.gbBackArchCont);
            this.tabRestore.Controls.Add(this.gbRestoreOptions);
            this.tabRestore.Controls.Add(this.btnRestore);
            point2 = new Point(4, 0x16);
            this.tabRestore.Location = point2;
            this.tabRestore.Name = "tabRestore";
            Padding padding2 = new Padding(3);
            this.tabRestore.Padding = padding2;
            size2 = new Size(0x27c, 0x115);
            this.tabRestore.Size = size2;
            this.tabRestore.TabIndex = 1;
            this.tabRestore.Text = "Restore";
            this.tabRestore.UseVisualStyleBackColor = true;
            this.gbBackupArchives.Controls.Add(this.cbBackupArchives);
            this.gbBackupArchives.Controls.Add(this.btnRefreshBackups);
            point2 = new Point(290, 6);
            this.gbBackupArchives.Location = point2;
            this.gbBackupArchives.Name = "gbBackupArchives";
            size2 = new Size(340, 0x4d);
            this.gbBackupArchives.Size = size2;
            this.gbBackupArchives.TabIndex = 20;
            this.gbBackupArchives.TabStop = false;
            this.gbBackupArchives.Text = "Backup Archives:";
            this.cbBackupArchives.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbBackupArchives.FormattingEnabled = true;
            point2 = new Point(6, 0x13);
            this.cbBackupArchives.Location = point2;
            this.cbBackupArchives.Name = "cbBackupArchives";
            size2 = new Size(0x148, 0x15);
            this.cbBackupArchives.Size = size2;
            this.cbBackupArchives.TabIndex = 9;
            point2 = new Point(0xfd, 0x2e);
            this.btnRefreshBackups.Location = point2;
            this.btnRefreshBackups.Name = "btnRefreshBackups";
            size2 = new Size(0x51, 0x17);
            this.btnRefreshBackups.Size = size2;
            this.btnRefreshBackups.TabIndex = 10;
            this.btnRefreshBackups.Text = "Refresh Backups";
            this.btnRefreshBackups.UseVisualStyleBackColor = true;
            this.gbBackArchCont.Controls.Add(this.btnSelAllRest);
            this.gbBackArchCont.Controls.Add(this.btnDeselAllRest);
            this.gbBackArchCont.Controls.Add(this.lvBackupContents);
            point2 = new Point(6, 6);
            this.gbBackArchCont.Location = point2;
            this.gbBackArchCont.Name = "gbBackArchCont";
            size2 = new Size(0x116, 0xe4);
            this.gbBackArchCont.Size = size2;
            this.gbBackArchCont.TabIndex = 0x13;
            this.gbBackArchCont.TabStop = false;
            this.gbBackArchCont.Text = "Backup Archive Contents:";
            point2 = new Point(0x34, 0xc7);
            this.btnSelAllRest.Location = point2;
            this.btnSelAllRest.Name = "btnSelAllRest";
            size2 = new Size(0x51, 0x17);
            this.btnSelAllRest.Size = size2;
            this.btnSelAllRest.TabIndex = 6;
            this.btnSelAllRest.Text = "Select All";
            this.btnSelAllRest.UseVisualStyleBackColor = true;
            point2 = new Point(0x91, 0xc7);
            this.btnDeselAllRest.Location = point2;
            this.btnDeselAllRest.Name = "btnDeselAllRest";
            size2 = new Size(0x51, 0x17);
            this.btnDeselAllRest.Size = size2;
            this.btnDeselAllRest.TabIndex = 20;
            this.btnDeselAllRest.Text = "Deselect All";
            this.btnDeselAllRest.UseVisualStyleBackColor = true;
            this.lvBackupContents.CheckBoxes = true;
            this.lvBackupContents.Columns.AddRange(new ColumnHeader[] { this.hdrTargetBlockDevice, this.hdrFlashFileName });
            this.lvBackupContents.FullRowSelect = true;
            this.lvBackupContents.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            point2 = new Point(6, 0x13);
            this.lvBackupContents.Location = point2;
            this.lvBackupContents.Name = "lvBackupContents";
            size2 = new Size(0x10a, 0xaf);
            this.lvBackupContents.Size = size2;
            this.lvBackupContents.TabIndex = 0;
            this.lvBackupContents.UseCompatibleStateImageBehavior = false;
            this.lvBackupContents.View = View.Details;
            this.hdrTargetBlockDevice.Text = "Target Block Device";
            this.hdrTargetBlockDevice.Width = 0x9b;
            this.hdrFlashFileName.Text = "Flash File Name";
            this.hdrFlashFileName.Width = 0x58;
            this.gbRestoreOptions.Controls.Add(this.chkRbtDevAftRestore);
            this.gbRestoreOptions.Controls.Add(this.chkEnableMD5Restore);
            point2 = new Point(290, 0x59);
            this.gbRestoreOptions.Location = point2;
            this.gbRestoreOptions.Name = "gbRestoreOptions";
            size2 = new Size(340, 0x91);
            this.gbRestoreOptions.Size = size2;
            this.gbRestoreOptions.TabIndex = 7;
            this.gbRestoreOptions.TabStop = false;
            this.gbRestoreOptions.Text = "Restore Options:";
            this.chkRbtDevAftRestore.AutoSize = true;
            this.chkRbtDevAftRestore.Checked = true;
            this.chkRbtDevAftRestore.CheckState = CheckState.Checked;
            point2 = new Point(6, 0x2a);
            this.chkRbtDevAftRestore.Location = point2;
            this.chkRbtDevAftRestore.Name = "chkRbtDevAftRestore";
            size2 = new Size(0xa3, 0x11);
            this.chkRbtDevAftRestore.Size = size2;
            this.chkRbtDevAftRestore.TabIndex = 0x12;
            this.chkRbtDevAftRestore.Text = "Reboot Device After Restore";
            this.chkRbtDevAftRestore.UseVisualStyleBackColor = true;
            this.chkEnableMD5Restore.AutoSize = true;
            this.chkEnableMD5Restore.Checked = true;
            this.chkEnableMD5Restore.CheckState = CheckState.Checked;
            point2 = new Point(6, 0x13);
            this.chkEnableMD5Restore.Location = point2;
            this.chkEnableMD5Restore.Name = "chkEnableMD5Restore";
            size2 = new Size(0xc1, 0x11);
            this.chkEnableMD5Restore.Size = size2;
            this.chkEnableMD5Restore.TabIndex = 0x11;
            this.chkEnableMD5Restore.Text = "Enable MD5 Checksum Verification";
            this.chkEnableMD5Restore.UseVisualStyleBackColor = true;
            point2 = new Point(0x1f9, 240);
            this.btnRestore.Location = point2;
            this.btnRestore.Name = "btnRestore";
            size2 = new Size(0x7d, 0x22);
            this.btnRestore.Size = size2;
            this.btnRestore.TabIndex = 13;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.tabSamsungTools.Controls.Add(this.gbOtherTools);
            this.tabSamsungTools.Controls.Add(this.gbPhoneSVCApps);
            this.tabSamsungTools.Controls.Add(this.gbQCDevSupport);
            point2 = new Point(4, 0x16);
            this.tabSamsungTools.Location = point2;
            this.tabSamsungTools.Name = "tabSamsungTools";
            padding2 = new Padding(3);
            this.tabSamsungTools.Padding = padding2;
            size2 = new Size(0x27c, 0x115);
            this.tabSamsungTools.Size = size2;
            this.tabSamsungTools.TabIndex = 2;
            this.tabSamsungTools.Text = "Samsung Tools";
            this.tabSamsungTools.UseVisualStyleBackColor = true;
            this.gbOtherTools.Controls.Add(this.lblOtherToolsDescTitle);
            this.gbOtherTools.Controls.Add(this.lblOtherToolsDesc);
            this.gbOtherTools.Controls.Add(this.lblOtherToolsInfo);
            this.gbOtherTools.Controls.Add(this.btnDeviceToolsExec);
            this.gbOtherTools.Controls.Add(this.cbOtherTools);
            point2 = new Point(0x143, 6);
            this.gbOtherTools.Location = point2;
            this.gbOtherTools.Name = "gbOtherTools";
            size2 = new Size(0x133, 0xba);
            this.gbOtherTools.Size = size2;
            this.gbOtherTools.TabIndex = 0x13;
            this.gbOtherTools.TabStop = false;
            this.gbOtherTools.Text = "Other Tools:";
            this.lblOtherToolsDescTitle.AutoSize = true;
            point2 = new Point(3, 0x51);
            this.lblOtherToolsDescTitle.Location = point2;
            this.lblOtherToolsDescTitle.Name = "lblOtherToolsDescTitle";
            size2 = new Size(0x3f, 13);
            this.lblOtherToolsDescTitle.Size = size2;
            this.lblOtherToolsDescTitle.TabIndex = 0x29;
            this.lblOtherToolsDescTitle.Text = "Description:";
            this.lblOtherToolsDesc.BorderStyle = BorderStyle.FixedSingle;
            point2 = new Point(6, 0x61);
            this.lblOtherToolsDesc.Location = point2;
            this.lblOtherToolsDesc.Name = "lblOtherToolsDesc";
            size2 = new Size(0x127, 0x52);
            this.lblOtherToolsDesc.Size = size2;
            this.lblOtherToolsDesc.TabIndex = 40;
            this.lblOtherToolsInfo.AutoSize = true;
            point2 = new Point(3, 0x2b);
            this.lblOtherToolsInfo.Location = point2;
            this.lblOtherToolsInfo.Name = "lblOtherToolsInfo";
            size2 = new Size(0xd7, 13);
            this.lblOtherToolsInfo.Size = size2;
            this.lblOtherToolsInfo.TabIndex = 0x27;
            this.lblOtherToolsInfo.Text = "Executes the selected action on the device.";
            point2 = new Point(0xf2, 0x2e);
            this.btnDeviceToolsExec.Location = point2;
            this.btnDeviceToolsExec.Name = "btnDeviceToolsExec";
            size2 = new Size(0x3b, 0x17);
            this.btnDeviceToolsExec.Size = size2;
            this.btnDeviceToolsExec.TabIndex = 0x26;
            this.btnDeviceToolsExec.Text = "Execute";
            this.btnDeviceToolsExec.UseVisualStyleBackColor = true;
            this.cbOtherTools.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbOtherTools.FormattingEnabled = true;
            this.cbOtherTools.Items.AddRange(new object[] { "Restore NV Data From Internal File Backup", "Repair NV Data File Permissions", "Repair Lock Screen / Power Button Menu", "Read Current Phone Mode", "Change Phone Mode: Factory Mode > User Mode", "Change Phone Mode: User Mode > Factory Mode", "Extract Device's PIT File", "Format EFS Folder", "Reset Battery Cable Counter", "Reset SPen Counter", "Reset Earphone Jack Counter" });
            point2 = new Point(6, 0x13);
            this.cbOtherTools.Location = point2;
            this.cbOtherTools.Name = "cbOtherTools";
            size2 = new Size(0x127, 0x15);
            this.cbOtherTools.Size = size2;
            this.cbOtherTools.TabIndex = 0x24;
            this.gbPhoneSVCApps.Controls.Add(this.cbPhoneSVCApps);
            this.gbPhoneSVCApps.Controls.Add(this.btnLaunchPhSVCApp);
            this.gbPhoneSVCApps.Controls.Add(this.lblLaunchPhSVCAppInfo);
            point2 = new Point(6, 0xc6);
            this.gbPhoneSVCApps.Location = point2;
            this.gbPhoneSVCApps.Name = "gbPhoneSVCApps";
            size2 = new Size(0x133, 0x4c);
            this.gbPhoneSVCApps.Size = size2;
            this.gbPhoneSVCApps.TabIndex = 0x12;
            this.gbPhoneSVCApps.TabStop = false;
            this.gbPhoneSVCApps.Text = "Phone Service Apps:";
            this.cbPhoneSVCApps.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbPhoneSVCApps.FormattingEnabled = true;
            this.cbPhoneSVCApps.Items.AddRange(new object[] { "Preconfig (Change CSC)", "PhoneUtil", "PhoneUtil > Qualcomm USB Settings", "PhoneUtil (Newer Devices)", "USB Settings (Newer Devices)", "Factory Mode Dialer (Tablet Devices)", "IOTHiddenMenu (US Variants)", "UltraCfg > USB Settings", "Enable HiddenMenu (Requires Reboot)", "Disable HiddenMenu (Requires Reboot)" });
            point2 = new Point(6, 0x13);
            this.cbPhoneSVCApps.Location = point2;
            this.cbPhoneSVCApps.Name = "cbPhoneSVCApps";
            size2 = new Size(0x127, 0x15);
            this.cbPhoneSVCApps.Size = size2;
            this.cbPhoneSVCApps.TabIndex = 0x18;
            point2 = new Point(0xf2, 0x2e);
            this.btnLaunchPhSVCApp.Location = point2;
            this.btnLaunchPhSVCApp.Name = "btnLaunchPhSVCApp";
            size2 = new Size(0x3b, 0x17);
            this.btnLaunchPhSVCApp.Size = size2;
            this.btnLaunchPhSVCApp.TabIndex = 20;
            this.btnLaunchPhSVCApp.Text = "Launch";
            this.btnLaunchPhSVCApp.UseVisualStyleBackColor = true;
            this.lblLaunchPhSVCAppInfo.AutoSize = true;
            point2 = new Point(3, 0x2b);
            this.lblLaunchPhSVCAppInfo.Location = point2;
            this.lblLaunchPhSVCAppInfo.Name = "lblLaunchPhSVCAppInfo";
            size2 = new Size(0xde, 13);
            this.lblLaunchPhSVCAppInfo.Size = size2;
            this.lblLaunchPhSVCAppInfo.TabIndex = 0x21;
            this.lblLaunchPhSVCAppInfo.Text = "Launches the selected activity on the device.";
            this.gbQCDevSupport.Controls.Add(this.lblQCDevSuppInfo);
            this.gbQCDevSupport.Controls.Add(this.cbCurrUSBSettings);
            this.gbQCDevSupport.Controls.Add(this.chkSwitchAuto);
            this.gbQCDevSupport.Controls.Add(this.lblCurrUSBSettings);
            this.gbQCDevSupport.Controls.Add(this.btnQCNVTools);
            point2 = new Point(6, 6);
            this.gbQCDevSupport.Location = point2;
            this.gbQCDevSupport.Name = "gbQCDevSupport";
            size2 = new Size(0x133, 0xba);
            this.gbQCDevSupport.Size = size2;
            this.gbQCDevSupport.TabIndex = 0x10;
            this.gbQCDevSupport.TabStop = false;
            this.gbQCDevSupport.Text = "Qualcomm Device Support:";
            this.lblQCDevSuppInfo.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(6, 0x57);
            this.lblQCDevSuppInfo.Location = point2;
            this.lblQCDevSuppInfo.Name = "lblQCDevSuppInfo";
            size2 = new Size(0x127, 0x3f);
            this.lblQCDevSuppInfo.Size = size2;
            this.lblQCDevSuppInfo.TabIndex = 0x16;
            this.lblQCDevSuppInfo.Text = manager.GetString("lblQCDevSuppInfo.Text");
            this.cbCurrUSBSettings.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCurrUSBSettings.FormattingEnabled = true;
            this.cbCurrUSBSettings.Items.AddRange(new object[] { "MTP + ADB", "PTP + ADB", "DIAG + MODEM + ADB" });
            point2 = new Point(6, 40);
            this.cbCurrUSBSettings.Location = point2;
            this.cbCurrUSBSettings.Name = "cbCurrUSBSettings";
            size2 = new Size(0x127, 0x15);
            this.cbCurrUSBSettings.Size = size2;
            this.cbCurrUSBSettings.TabIndex = 0x15;
            this.chkSwitchAuto.AutoSize = true;
            this.chkSwitchAuto.Checked = true;
            this.chkSwitchAuto.CheckState = CheckState.Checked;
            point2 = new Point(0xb2, 0x43);
            this.chkSwitchAuto.Location = point2;
            this.chkSwitchAuto.Name = "chkSwitchAuto";
            size2 = new Size(0x7b, 0x11);
            this.chkSwitchAuto.Size = size2;
            this.chkSwitchAuto.TabIndex = 0x12;
            this.chkSwitchAuto.Text = "Switch Automatically";
            this.chkSwitchAuto.UseVisualStyleBackColor = true;
            this.lblCurrUSBSettings.AutoSize = true;
            point2 = new Point(3, 0x18);
            this.lblCurrUSBSettings.Location = point2;
            this.lblCurrUSBSettings.Name = "lblCurrUSBSettings";
            size2 = new Size(110, 13);
            this.lblCurrUSBSettings.Size = size2;
            this.lblCurrUSBSettings.TabIndex = 0x11;
            this.lblCurrUSBSettings.Text = "Current USB Settings:";
            point2 = new Point(80, 0x99);
            this.btnQCNVTools.Location = point2;
            this.btnQCNVTools.Name = "btnQCNVTools";
            size2 = new Size(0x91, 0x1a);
            this.btnQCNVTools.Size = size2;
            this.btnQCNVTools.TabIndex = 14;
            this.btnQCNVTools.Text = "Qualcomm NV Tools";
            this.btnQCNVTools.UseVisualStyleBackColor = true;
            point2 = new Point(0x175, 0x233);
            this.btnDonate.Location = point2;
            this.btnDonate.Name = "btnDonate";
            size2 = new Size(0x55, 0x22);
            this.btnDonate.Size = size2;
            this.btnDonate.TabIndex = 0x1d;
            this.btnDonate.Text = "Donate!";
            this.btnDonate.UseVisualStyleBackColor = true;
            point2 = new Point(0x1d, 0x13);
            this.btnGetPropQuery.Location = point2;
            this.btnGetPropQuery.Name = "btnGetPropQuery";
            size2 = new Size(0x8f, 0x1a);
            this.btnGetPropQuery.Size = size2;
            this.btnGetPropQuery.TabIndex = 0;
            this.btnGetPropQuery.Text = "getprop Query (ALL)";
            this.btnGetPropQuery.UseVisualStyleBackColor = true;
            this.gbBuildProps.Controls.Add(this.btnGetPropQuery);
            this.gbBuildProps.Controls.Add(this.chkUseBPP);
            point2 = new Point(6, 0x36);
            this.gbBuildProps.Location = point2;
            this.gbBuildProps.Name = "gbBuildProps";
            size2 = new Size(200, 0x4e);
            this.gbBuildProps.Size = size2;
            this.gbBuildProps.TabIndex = 7;
            this.gbBuildProps.TabStop = false;
            this.gbBuildProps.Text = "Build Properties:";
            this.chkUseBPP.AutoSize = true;
            point2 = new Point(0x20, 0x33);
            this.chkUseBPP.Location = point2;
            this.chkUseBPP.Name = "chkUseBPP";
            size2 = new Size(140, 0x11);
            this.chkUseBPP.Size = size2;
            this.chkUseBPP.TabIndex = 6;
            this.chkUseBPP.Text = "Use BuildPropertyParser";
            this.chkUseBPP.UseVisualStyleBackColor = true;
            point2 = new Point(0x1d, 40);
            this.btnGetEFSMountpoint.Location = point2;
            this.btnGetEFSMountpoint.Name = "btnGetEFSMountpoint";
            size2 = new Size(0x8f, 0x1a);
            this.btnGetEFSMountpoint.Size = size2;
            this.btnGetEFSMountpoint.TabIndex = 1;
            this.btnGetEFSMountpoint.Text = "Get EFS Mountpoint";
            this.btnGetEFSMountpoint.UseVisualStyleBackColor = true;
            point2 = new Point(0x1d, 0x48);
            this.btnGetPartList.Location = point2;
            this.btnGetPartList.Name = "btnGetPartList";
            size2 = new Size(0x8f, 0x1a);
            this.btnGetPartList.Size = size2;
            this.btnGetPartList.TabIndex = 5;
            this.btnGetPartList.Text = "Get Partition List";
            this.btnGetPartList.UseVisualStyleBackColor = true;
            this.gbMountPart.Controls.Add(this.btnGetEFSMountpoint);
            this.gbMountPart.Controls.Add(this.btnGetPartList);
            point2 = new Point(0xda, 0x36);
            this.gbMountPart.Location = point2;
            this.gbMountPart.Name = "gbMountPart";
            size2 = new Size(200, 0x84);
            this.gbMountPart.Size = size2;
            this.gbMountPart.TabIndex = 8;
            this.gbMountPart.TabStop = false;
            this.gbMountPart.Text = "Mounts / Partitions:";
            point2 = new Point(6, 0xc7);
            this.btnSelectAll.Location = point2;
            this.btnSelectAll.Name = "btnSelectAll";
            size2 = new Size(0x51, 0x17);
            this.btnSelectAll.Size = size2;
            this.btnSelectAll.TabIndex = 6;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            point2 = new Point(0x1d, 0x18);
            this.btnTestWaitDevice.Location = point2;
            this.btnTestWaitDevice.Name = "btnTestWaitDevice";
            size2 = new Size(0x8f, 0x1a);
            this.btnTestWaitDevice.Size = size2;
            this.btnTestWaitDevice.TabIndex = 2;
            this.btnTestWaitDevice.Text = "Test WaitDeviceDialog";
            this.btnTestWaitDevice.UseVisualStyleBackColor = true;
            point2 = new Point(0x1d, 0x38);
            this.btnTestRootPerm.Location = point2;
            this.btnTestRootPerm.Name = "btnTestRootPerm";
            size2 = new Size(0x8f, 0x1a);
            this.btnTestRootPerm.Size = size2;
            this.btnTestRootPerm.TabIndex = 3;
            this.btnTestRootPerm.Text = "Test Root Permissions";
            this.btnTestRootPerm.UseVisualStyleBackColor = true;
            point2 = new Point(0x1d, 0x58);
            this.btnTestBBPresence.Location = point2;
            this.btnTestBBPresence.Name = "btnTestBBPresence";
            size2 = new Size(0x8f, 0x1a);
            this.btnTestBBPresence.Size = size2;
            this.btnTestBBPresence.TabIndex = 4;
            this.btnTestBBPresence.Text = "Test BusyBox Presence";
            this.btnTestBBPresence.UseVisualStyleBackColor = true;
            this.tabDebug.Controls.Add(this.gbRebootOptions);
            this.tabDebug.Controls.Add(this.lblAppDebug);
            this.tabDebug.Controls.Add(this.btnDevADBShell);
            this.tabDebug.Controls.Add(this.gbTests);
            this.tabDebug.Controls.Add(this.gbMountPart);
            this.tabDebug.Controls.Add(this.gbBuildProps);
            point2 = new Point(4, 0x16);
            this.tabDebug.Location = point2;
            this.tabDebug.Name = "tabDebug";
            padding2 = new Padding(3);
            this.tabDebug.Padding = padding2;
            size2 = new Size(0x27c, 0x115);
            this.tabDebug.Size = size2;
            this.tabDebug.TabIndex = 4;
            this.tabDebug.Text = "Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            this.gbRebootOptions.Controls.Add(this.cbRebootOpt);
            this.gbRebootOptions.Controls.Add(this.btnRebootGo);
            point2 = new Point(6, 0x8a);
            this.gbRebootOptions.Location = point2;
            this.gbRebootOptions.Name = "gbRebootOptions";
            size2 = new Size(200, 0x30);
            this.gbRebootOptions.Size = size2;
            this.gbRebootOptions.TabIndex = 14;
            this.gbRebootOptions.TabStop = false;
            this.gbRebootOptions.Text = "Reboot Options:";
            this.cbRebootOpt.FormattingEnabled = true;
            this.cbRebootOpt.Items.AddRange(new object[] { "Reboot", "Download", "Recovery", "Bootloader" });
            point2 = new Point(7, 0x11);
            this.cbRebootOpt.Location = point2;
            this.cbRebootOpt.Name = "cbRebootOpt";
            size2 = new Size(0x69, 0x15);
            this.cbRebootOpt.Size = size2;
            this.cbRebootOpt.TabIndex = 8;
            point2 = new Point(0x76, 15);
            this.btnRebootGo.Location = point2;
            this.btnRebootGo.Name = "btnRebootGo";
            size2 = new Size(0x4b, 0x17);
            this.btnRebootGo.Size = size2;
            this.btnRebootGo.TabIndex = 7;
            this.btnRebootGo.Text = "Go!";
            this.btnRebootGo.UseVisualStyleBackColor = true;
            this.lblAppDebug.AutoSize = true;
            this.lblAppDebug.Font = new Font("Microsoft Sans Serif", 18f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblAppDebug.ForeColor = Color.Blue;
            point2 = new Point(0xb0, 13);
            this.lblAppDebug.Location = point2;
            this.lblAppDebug.Name = "lblAppDebug";
            size2 = new Size(0x11d, 0x1d);
            this.lblAppDebug.Size = size2;
            this.lblAppDebug.TabIndex = 13;
            this.lblAppDebug.Text = "Application Debugging:";
            point2 = new Point(0xf7, 0xc9);
            this.btnDevADBShell.Location = point2;
            this.btnDevADBShell.Name = "btnDevADBShell";
            size2 = new Size(0x8f, 0x1a);
            this.btnDevADBShell.Size = size2;
            this.btnDevADBShell.TabIndex = 10;
            this.btnDevADBShell.Text = "Start Device ADB Shell";
            this.btnDevADBShell.UseVisualStyleBackColor = true;
            this.gbTests.Controls.Add(this.btnTestWaitDevice);
            this.gbTests.Controls.Add(this.btnTestRootPerm);
            this.gbTests.Controls.Add(this.btnTestBBPresence);
            point2 = new Point(430, 0x36);
            this.gbTests.Location = point2;
            this.gbTests.Name = "gbTests";
            size2 = new Size(200, 0x84);
            this.gbTests.Size = size2;
            this.gbTests.TabIndex = 9;
            this.gbTests.TabStop = false;
            this.gbTests.Text = "Tests:";
            this.cbDeviceFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbDeviceFilter.FormattingEnabled = true;
            point2 = new Point(6, 0x13);
            this.cbDeviceFilter.Location = point2;
            this.cbDeviceFilter.Name = "cbDeviceFilter";
            size2 = new Size(0x148, 0x15);
            this.cbDeviceFilter.Size = size2;
            this.cbDeviceFilter.TabIndex = 6;
            this.tcEFSProUI.Controls.Add(this.tabInformation);
            this.tcEFSProUI.Controls.Add(this.tabBackup);
            this.tcEFSProUI.Controls.Add(this.tabRestore);
            this.tcEFSProUI.Controls.Add(this.tabSamsungTools);
            this.tcEFSProUI.Controls.Add(this.tabAppConfig);
            this.tcEFSProUI.Controls.Add(this.tabDebug);
            this.tcEFSProUI.Dock = DockStyle.Top;
            point2 = new Point(0, 0);
            this.tcEFSProUI.Location = point2;
            this.tcEFSProUI.Name = "tcEFSProUI";
            this.tcEFSProUI.SelectedIndex = 0;
            size2 = new Size(0x284, 0x12f);
            this.tcEFSProUI.Size = size2;
            this.tcEFSProUI.TabIndex = 0x1c;
            this.tabInformation.Controls.Add(this.txtInformation);
            this.tabInformation.Controls.Add(this.lblDisclaimer);
            this.tabInformation.Controls.Add(this.lblDisclaimerInfo);
            point2 = new Point(4, 0x16);
            this.tabInformation.Location = point2;
            this.tabInformation.Name = "tabInformation";
            size2 = new Size(0x27c, 0x115);
            this.tabInformation.Size = size2;
            this.tabInformation.TabIndex = 3;
            this.tabInformation.Text = "Information";
            this.tabInformation.UseVisualStyleBackColor = true;
            this.txtInformation.BackColor = Color.FromArgb(0xc0, 0xff, 0xff);
            this.txtInformation.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtInformation.ForeColor = SystemColors.WindowText;
            point2 = new Point(8, 8);
            this.txtInformation.Location = point2;
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            size2 = new Size(620, 0x68);
            this.txtInformation.Size = size2;
            this.txtInformation.TabIndex = 2;
            this.txtInformation.Text = manager.GetString("txtInformation.Text");
            this.lblDisclaimer.AutoSize = true;
            this.lblDisclaimer.Font = new Font("Arial", 12f, FontStyle.Underline | FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblDisclaimer.ForeColor = Color.Blue;
            point2 = new Point(0x21, 0x7b);
            this.lblDisclaimer.Location = point2;
            this.lblDisclaimer.Name = "lblDisclaimer";
            size2 = new Size(0x71, 0x13);
            this.lblDisclaimer.Size = size2;
            this.lblDisclaimer.TabIndex = 1;
            this.lblDisclaimer.Text = "DISCLAIMER!";
            this.lblDisclaimerInfo.AutoSize = true;
            this.lblDisclaimerInfo.Font = new Font("Consolas", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblDisclaimerInfo.ForeColor = Color.FromArgb(0xff, 0x80, 0);
            point2 = new Point(0x22, 0x90);
            this.lblDisclaimerInfo.Location = point2;
            this.lblDisclaimerInfo.Name = "lblDisclaimerInfo";
            size2 = new Size(0x238, 0x7e);
            this.lblDisclaimerInfo.Size = size2;
            this.lblDisclaimerInfo.TabIndex = 0;
            this.lblDisclaimerInfo.Text = manager.GetString("lblDisclaimerInfo.Text");
            this.tabBackup.Controls.Add(this.gbDeviceFilters);
            this.tabBackup.Controls.Add(this.gbBackupOptions);
            this.tabBackup.Controls.Add(this.gbDevPartitions);
            this.tabBackup.Controls.Add(this.btnBackup);
            point2 = new Point(4, 0x16);
            this.tabBackup.Location = point2;
            this.tabBackup.Name = "tabBackup";
            padding2 = new Padding(3);
            this.tabBackup.Padding = padding2;
            size2 = new Size(0x27c, 0x115);
            this.tabBackup.Size = size2;
            this.tabBackup.TabIndex = 0;
            this.tabBackup.Text = "Backup";
            this.tabBackup.UseVisualStyleBackColor = true;
            this.gbDeviceFilters.Controls.Add(this.btnManage);
            this.gbDeviceFilters.Controls.Add(this.cbDeviceFilter);
            point2 = new Point(290, 6);
            this.gbDeviceFilters.Location = point2;
            this.gbDeviceFilters.Name = "gbDeviceFilters";
            size2 = new Size(340, 0x4d);
            this.gbDeviceFilters.Size = size2;
            this.gbDeviceFilters.TabIndex = 0x15;
            this.gbDeviceFilters.TabStop = false;
            this.gbDeviceFilters.Text = "Device Filters:";
            this.gbBackupOptions.Controls.Add(this.CheckBox1);
            this.gbBackupOptions.Controls.Add(this.chkEnableMD5Backup);
            point2 = new Point(290, 0x59);
            this.gbBackupOptions.Location = point2;
            this.gbBackupOptions.Name = "gbBackupOptions";
            size2 = new Size(340, 0x91);
            this.gbBackupOptions.Size = size2;
            this.gbBackupOptions.TabIndex = 0x13;
            this.gbBackupOptions.TabStop = false;
            this.gbBackupOptions.Text = "Backup Options:";
            this.gbDevPartitions.Controls.Add(this.btnRefreshList);
            this.gbDevPartitions.Controls.Add(this.btnSelectAll);
            this.gbDevPartitions.Controls.Add(this.btnDeselectAll);
            this.gbDevPartitions.Controls.Add(this.lvPartitions);
            point2 = new Point(6, 6);
            this.gbDevPartitions.Location = point2;
            this.gbDevPartitions.Name = "gbDevPartitions";
            size2 = new Size(0x116, 0xe4);
            this.gbDevPartitions.Size = size2;
            this.gbDevPartitions.TabIndex = 0x12;
            this.gbDevPartitions.TabStop = false;
            this.gbDevPartitions.Text = "Device Partitions:";
            point2 = new Point(0x1f9, 240);
            this.btnBackup.Location = point2;
            this.btnBackup.Name = "btnBackup";
            size2 = new Size(0x7d, 0x22);
            this.btnBackup.Size = size2;
            this.btnBackup.TabIndex = 6;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.tabAppConfig.Controls.Add(this.gbAppConfig);
            point2 = new Point(4, 0x16);
            this.tabAppConfig.Location = point2;
            this.tabAppConfig.Name = "tabAppConfig";
            size2 = new Size(0x27c, 0x115);
            this.tabAppConfig.Size = size2;
            this.tabAppConfig.TabIndex = 5;
            this.tabAppConfig.Text = "App. Config";
            this.tabAppConfig.UseVisualStyleBackColor = true;
            this.gbAppConfig.Controls.Add(this.gbPITOptions);
            this.gbAppConfig.Controls.Add(this.lblEnableAppDebugInfo);
            this.gbAppConfig.Controls.Add(this.gbDevStorageOpt);
            this.gbAppConfig.Controls.Add(this.chkEnableAppDebug);
            point2 = new Point(6, 6);
            this.gbAppConfig.Location = point2;
            this.gbAppConfig.Name = "gbAppConfig";
            size2 = new Size(0x270, 0x10c);
            this.gbAppConfig.Size = size2;
            this.gbAppConfig.TabIndex = 0;
            this.gbAppConfig.TabStop = false;
            this.gbAppConfig.Text = "Application Configuration:";
            this.gbPITOptions.Controls.Add(this.lblPITBuffDefault);
            this.gbPITOptions.Controls.Add(this.cbPITBufferSize);
            this.gbPITOptions.Controls.Add(this.lblPITBufferSize);
            this.gbPITOptions.Controls.Add(this.lblPITBuffInfo);
            point2 = new Point(6, 0xb5);
            this.gbPITOptions.Location = point2;
            this.gbPITOptions.Name = "gbPITOptions";
            size2 = new Size(0x264, 0x51);
            this.gbPITOptions.Size = size2;
            this.gbPITOptions.TabIndex = 7;
            this.gbPITOptions.TabStop = false;
            this.gbPITOptions.Text = "PIT File Extraction Options:";
            this.lblPITBuffDefault.AutoSize = true;
            point2 = new Point(0x171, 0x16);
            this.lblPITBuffDefault.Location = point2;
            this.lblPITBuffDefault.Name = "lblPITBuffDefault";
            size2 = new Size(0x5e, 13);
            this.lblPITBuffDefault.Size = size2;
            this.lblPITBuffDefault.TabIndex = 5;
            this.lblPITBuffDefault.Text = "(Default: 1024 KB)";
            this.cbPITBufferSize.FormattingEnabled = true;
            this.cbPITBufferSize.Items.AddRange(new object[] { "1024 KB", "2048 KB", "3072 KB", "4096 KB", "5120 KB" });
            point2 = new Point(0xd9, 0x13);
            this.cbPITBufferSize.Location = point2;
            this.cbPITBufferSize.Name = "cbPITBufferSize";
            size2 = new Size(0x92, 0x15);
            this.cbPITBufferSize.Size = size2;
            this.cbPITBufferSize.TabIndex = 4;
            this.lblPITBufferSize.AutoSize = true;
            point2 = new Point(130, 0x16);
            this.lblPITBufferSize.Location = point2;
            this.lblPITBufferSize.Name = "lblPITBufferSize";
            size2 = new Size(0x51, 13);
            this.lblPITBufferSize.Size = size2;
            this.lblPITBufferSize.TabIndex = 2;
            this.lblPITBufferSize.Text = "PIT Buffer Size:";
            this.lblPITBuffInfo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0xd6, 0x2c);
            this.lblPITBuffInfo.Location = point2;
            this.lblPITBuffInfo.Name = "lblPITBuffInfo";
            size2 = new Size(0x126, 0x21);
            this.lblPITBuffInfo.Size = size2;
            this.lblPITBuffInfo.TabIndex = 3;
            this.lblPITBuffInfo.Text = "Buffer size in Kilobytes used to determine amount of data to read from 'mmcblk0' when finding and extracting the PIT file.\r\n";
            this.lblEnableAppDebugInfo.AutoSize = true;
            point2 = new Point(0x9c, 0x27);
            this.lblEnableAppDebugInfo.Location = point2;
            this.lblEnableAppDebugInfo.Name = "lblEnableAppDebugInfo";
            size2 = new Size(0x139, 13);
            this.lblEnableAppDebugInfo.Size = size2;
            this.lblEnableAppDebugInfo.TabIndex = 6;
            this.lblEnableAppDebugInfo.Text = "EFS Professional must be restarted for this change to take effect.";
            this.gbDevStorageOpt.Controls.Add(this.txtDevStorageLoc);
            this.gbDevStorageOpt.Controls.Add(this.lblDevStorageLoc);
            this.gbDevStorageOpt.Controls.Add(this.lblDevStorageLocInfo);
            point2 = new Point(6, 0x42);
            this.gbDevStorageOpt.Location = point2;
            this.gbDevStorageOpt.Name = "gbDevStorageOpt";
            size2 = new Size(0x264, 0x6d);
            this.gbDevStorageOpt.Size = size2;
            this.gbDevStorageOpt.TabIndex = 5;
            this.gbDevStorageOpt.TabStop = false;
            this.gbDevStorageOpt.Text = "Device Storage Options:";
            point2 = new Point(0x99, 0x20);
            this.txtDevStorageLoc.Location = point2;
            this.txtDevStorageLoc.Name = "txtDevStorageLoc";
            size2 = new Size(310, 20);
            this.txtDevStorageLoc.Size = size2;
            this.txtDevStorageLoc.TabIndex = 4;
            this.lblDevStorageLoc.AutoSize = true;
            point2 = new Point(150, 0x10);
            this.lblDevStorageLoc.Location = point2;
            this.lblDevStorageLoc.Name = "lblDevStorageLoc";
            size2 = new Size(0x80, 13);
            this.lblDevStorageLoc.Size = size2;
            this.lblDevStorageLoc.TabIndex = 2;
            this.lblDevStorageLoc.Text = "Device Storage Location:";
            this.lblDevStorageLocInfo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(150, 0x38);
            this.lblDevStorageLocInfo.Location = point2;
            this.lblDevStorageLocInfo.Name = "lblDevStorageLocInfo";
            size2 = new Size(0x139, 0x2e);
            this.lblDevStorageLocInfo.Size = size2;
            this.lblDevStorageLocInfo.TabIndex = 3;
            this.lblDevStorageLocInfo.Text = "Path to your device's internal or external storage location.\r\n\r\nFor example: /sdcard, /extSdCard, usbStorage";
            this.chkEnableAppDebug.AutoSize = true;
            point2 = new Point(0x9f, 0x13);
            this.chkEnableAppDebug.Location = point2;
            this.chkEnableAppDebug.Name = "chkEnableAppDebug";
            size2 = new Size(0xa9, 0x11);
            this.chkEnableAppDebug.Size = size2;
            this.chkEnableAppDebug.TabIndex = 0;
            this.chkEnableAppDebug.Text = "Enable Application Debugging";
            this.chkEnableAppDebug.UseVisualStyleBackColor = true;
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x238);
            this.lblVersionInfo.Location = point2;
            this.lblVersionInfo.Name = "lblVersionInfo";
            size2 = new Size(0x10b, 0x15);
            this.lblVersionInfo.Size = size2;
            this.lblVersionInfo.TabIndex = 0x1b;
            this.lblVersionInfo.Text = "EFS Professional v#.#.# \x00a9 Gaz 2014.";
            point2 = new Point(0x22b, 0x233);
            this.btnClearLog.Location = point2;
            this.btnClearLog.Name = "btnClearLog";
            size2 = new Size(0x55, 0x22);
            this.btnClearLog.Size = size2;
            this.btnClearLog.TabIndex = 0x1a;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.rtConsoleLog.BackColor = Color.Black;
            this.rtConsoleLog.Font = new Font("Lucida Console", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.rtConsoleLog.ForeColor = Color.White;
            point2 = new Point(4, 0x131);
            this.rtConsoleLog.Location = point2;
            this.rtConsoleLog.Name = "rtConsoleLog";
            this.rtConsoleLog.ReadOnly = true;
            this.rtConsoleLog.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            size2 = new Size(0x27c, 0xfc);
            this.rtConsoleLog.Size = size2;
            this.rtConsoleLog.TabIndex = 0x18;
            this.rtConsoleLog.Text = "";
            point2 = new Point(0x1d0, 0x233);
            this.btnDeviceInfo.Location = point2;
            this.btnDeviceInfo.Name = "btnDeviceInfo";
            size2 = new Size(0x55, 0x22);
            this.btnDeviceInfo.Size = size2;
            this.btnDeviceInfo.TabIndex = 0x19;
            this.btnDeviceInfo.Text = "Device Info";
            this.btnDeviceInfo.UseVisualStyleBackColor = true;
            this.cmsManageFilters.Items.AddRange(new ToolStripItem[] { this.tsManFilterCreateNew, this.tsManFilterEditSel, this.tsManFilterDeleteSel, this.tsManFilterRefresh });
            this.cmsManageFilters.Name = "cmsManageFilters";
            size2 = new Size(0x9b, 0x5c);
            this.cmsManageFilters.Size = size2;
            this.tsManFilterCreateNew.Name = "tsManFilterCreateNew";
            size2 = new Size(0x9a, 0x16);
            this.tsManFilterCreateNew.Size = size2;
            this.tsManFilterCreateNew.Text = "Create New...";
            this.tsManFilterEditSel.Name = "tsManFilterEditSel";
            size2 = new Size(0x9a, 0x16);
            this.tsManFilterEditSel.Size = size2;
            this.tsManFilterEditSel.Text = "Edit Selected";
            this.tsManFilterDeleteSel.Name = "tsManFilterDeleteSel";
            size2 = new Size(0x9a, 0x16);
            this.tsManFilterDeleteSel.Size = size2;
            this.tsManFilterDeleteSel.Text = "Delete Selected";
            this.tsManFilterRefresh.Name = "tsManFilterRefresh";
            size2 = new Size(0x9a, 0x16);
            this.tsManFilterRefresh.Size = size2;
            this.tsManFilterRefresh.Text = "Refresh";
            this.TimerTrigger.Interval = 0x3e8;
            this.CheckBox1.AutoSize = true;
            point2 = new Point(6, 0x2a);
            this.CheckBox1.Location = point2;
            this.CheckBox1.Name = "CheckBox1";
            size2 = new Size(0xf2, 0x11);
            this.CheckBox1.Size = size2;
            this.CheckBox1.TabIndex = 0x11;
            this.CheckBox1.Text = "Verify Archive Contents After Backup (Slower)";
            this.CheckBox1.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x284, 0x25c);
            this.ClientSize = size2;
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.tcEFSProUI);
            this.Controls.Add(this.lblVersionInfo);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.rtConsoleLog);
            this.Controls.Add(this.btnDeviceInfo);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEFSProMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "EFS Professional";
            this.tabRestore.ResumeLayout(false);
            this.gbBackupArchives.ResumeLayout(false);
            this.gbBackArchCont.ResumeLayout(false);
            this.gbRestoreOptions.ResumeLayout(false);
            this.gbRestoreOptions.PerformLayout();
            this.tabSamsungTools.ResumeLayout(false);
            this.gbOtherTools.ResumeLayout(false);
            this.gbOtherTools.PerformLayout();
            this.gbPhoneSVCApps.ResumeLayout(false);
            this.gbPhoneSVCApps.PerformLayout();
            this.gbQCDevSupport.ResumeLayout(false);
            this.gbQCDevSupport.PerformLayout();
            this.gbBuildProps.ResumeLayout(false);
            this.gbBuildProps.PerformLayout();
            this.gbMountPart.ResumeLayout(false);
            this.tabDebug.ResumeLayout(false);
            this.tabDebug.PerformLayout();
            this.gbRebootOptions.ResumeLayout(false);
            this.gbTests.ResumeLayout(false);
            this.tcEFSProUI.ResumeLayout(false);
            this.tabInformation.ResumeLayout(false);
            this.tabInformation.PerformLayout();
            this.tabBackup.ResumeLayout(false);
            this.gbDeviceFilters.ResumeLayout(false);
            this.gbBackupOptions.ResumeLayout(false);
            this.gbBackupOptions.PerformLayout();
            this.gbDevPartitions.ResumeLayout(false);
            this.tabAppConfig.ResumeLayout(false);
            this.gbAppConfig.ResumeLayout(false);
            this.gbAppConfig.PerformLayout();
            this.gbPITOptions.ResumeLayout(false);
            this.gbPITOptions.PerformLayout();
            this.gbDevStorageOpt.ResumeLayout(false);
            this.gbDevStorageOpt.PerformLayout();
            this.cmsManageFilters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected void InitializeDelegates()
        {
            this.onOperationCompletedDelegate = new SendOrPostCallback(this.DoOperationCompleted);
        }

        private void LaunchPhoneUtility(PhoneUtilityType phoneUtility)
        {
            try
            {
                this.UpdateLogText_MultiThread("Checking device connection...  ", Color.White, false, false, false);
                if (!this.myAndroid.HasConnectedDevices)
                {
                    Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
                    this.UpdateLogText_MultiThread("Device is not connected!", Color.Red, false, false, false);
                    this.EnableControls_MultiThread();
                }
                else
                {
                    this.UpdateLogText_MultiThread("Device is connected!", Color.Lime, false, false, true);
                    string str = string.Empty;
                    if (phoneUtility == PhoneUtilityType.Preconfig)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: Preconfig (Change CSC)...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.android.Preconfig/.Preconfig" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.PhoneUtil)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: PhoneUtil...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.android.app.phoneutil/.PhoneUtil_MDM9x15" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.PhoneUtilQCUSBSettings)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: PhoneUtil > Qualcomm USB Settings...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.android.app.phoneutil/.USBSettings" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.PhoneUtilNewDev)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: PhoneUtil (Newer Devices)...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.android.app.servicemodeapp/com.sec.android.app.modemui.activities.PhoneUtil" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.USBSettingsNewDev)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: USB Settings (Newer Devices)...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.usbsettings/.USBSettings" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.FactoryModeDialerTab)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: Factory Mode Dialer (Tablet Devices)...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.android.app.parser/.SecretCodeIME" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.IOTHiddenMenu)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: IOTHiddenMenu...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.android.hiddenmenu/.IOTHiddenMenu" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.UltraCfgUSBSettings)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: UltraCfg > USB Settings...  ", Color.White, false, false, false);
                        str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "am", new string[] { "start", "-n", "com.sec.modem.settings/.usbsettings.USBSettings" }));
                    }
                    else if (phoneUtility == PhoneUtilityType.EnableHiddenMenu)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: Enable HiddenMenu...  ", Color.White, false, false, false);
                        str = EFS_Professional.WinADBHelper.FileSystem.EnableHiddenMenu(true);
                    }
                    else if (phoneUtility == PhoneUtilityType.DisableHiddenMenu)
                    {
                        this.UpdateLogText_MultiThread("Sending Launch Command: Disable HiddenMenu...  ", Color.White, false, false, false);
                        str = EFS_Professional.WinADBHelper.FileSystem.EnableHiddenMenu(false);
                    }
                    this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                    this.EnableControls_MultiThread();
                    if (str.ToLower().Contains("does not exist"))
                    {
                        this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, true, true);
                        this.UpdateLogText_MultiThread("Activity does not exist! This is not intended for your device variant!", Color.Red, false, false, true);
                        this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, false, false);
                    }
                    else if (str.ToLower().Contains("brought to the front"))
                    {
                        this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, true, true);
                        this.UpdateLogText_MultiThread("Activity already running, brought to the front!", Color.Yellow, false, false, true);
                        this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, false, false);
                    }
                    else
                    {
                        this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, true, true);
                        this.UpdateLogText_MultiThread("Launching activity intent...", Color.Lime, false, false, true);
                        this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, false, false);
                    }
                    if ((((phoneUtility == PhoneUtilityType.EnableHiddenMenu) || (phoneUtility == PhoneUtilityType.DisableHiddenMenu)) && str.ToLower().Contains("has been enabled")) || str.ToLower().Contains("has been disabled"))
                    {
                        this.UpdateLogText_MultiThread("Rebooting device...  ", Color.Yellow, false, true, false);
                        ADB.Reboot(false);
                        this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                        this.myAndroid.RefreshDevices();
                        this.Invoke(new Action(this._Lambda$__66));
                    }
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, true, true);
                this.UpdateLogText_MultiThread(exception.Message, Color.Red, false, false, true);
                this.UpdateLogText_MultiThread("----------------------------------------------------------------------", Color.Cyan, false, false, false);
                this.EnableControls_MultiThread();
                ProjectData.ClearProjectError();
            }
        }

        private void lvBackupContents_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if ((e.ColumnIndex == 0) || (e.ColumnIndex == 1))
            {
                e.NewWidth = this.lvBackupContents.Columns[e.ColumnIndex].Width;
            }
            e.Cancel = true;
        }

        private void lvPartitions_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if ((e.ColumnIndex == 0) || (e.ColumnIndex == 1))
            {
                e.NewWidth = this.lvPartitions.Columns[e.ColumnIndex].Width;
            }
            e.Cancel = true;
        }

        protected void myProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.UpdateLogText_MultiThread(e.Data, Color.White, false, false, true);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this.CheckAppConfig();
            if (this.Opacity == 1.0)
            {
                this.TimerOut.Enabled = true;
            }
            switch (Interaction.MsgBox("Would you like to Kill the ADB Server also?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
            {
                case MsgBoxResult.Yes:
                    this.CleanUpTempFiles();
                    if (this.myAndroid != null)
                    {
                        this.myAndroid.Dispose();
                    }
                    break;

                case MsgBoxResult.No:
                    this.CleanUpTempFiles();
                    break;

                case MsgBoxResult.Cancel:
                    this.TimerIn.Interval = 20;
                    this.TimerIn.Enabled = true;
                    this.TimerOut.Interval = 20;
                    this.TimerOut.Enabled = false;
                    e.Cancel = true;
                    break;
            }
            base.OnFormClosing(e);
        }

        protected void OnOperationCompleted(OperationCompletedEventArgs e)
        {
            EventHandler operationCompletedEvent = this.OperationCompletedEvent;
            if (operationCompletedEvent != null)
            {
                operationCompletedEvent(this, e);
            }
        }

        private void OnOperationCompleted(object sender, OperationCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                this.UpdateLogText_MultiThread("Operation failed!", Color.Red, false, true, false);
                Interaction.MsgBox(e.Error.Message, MsgBoxStyle.Critical, null);
                this.EnableControls_MultiThread();
            }
            else
            {
                if (e.Operation == OperationType.Backup)
                {
                    this.UpdateLogText_MultiThread("Operation successful!", Color.DodgerBlue, false, true, false);
                    Interaction.MsgBox("Backup completed successfully!", MsgBoxStyle.Information, null);
                    this.EnableControls_MultiThread();
                }
                else if (e.Operation == OperationType.Restore)
                {
                    this.UpdateLogText_MultiThread("Operation successful!", Color.DodgerBlue, false, true, false);
                    Interaction.MsgBox("Restore completed successfully!", MsgBoxStyle.Information, null);
                    this.lvBackupContents.Items.Clear();
                    this.cbBackupArchives.SelectedIndex = -1;
                    this.EnableControls_MultiThread();
                }
                else if (e.Operation == OperationType.Normal)
                {
                    this.UpdateLogText_MultiThread("Operation successful!", Color.DodgerBlue, false, true, false);
                    Interaction.MsgBox("Operation completed successfully!", MsgBoxStyle.Information, null);
                    this.EnableControls_MultiThread();
                }
                this.ShowDonateDialog();
            }
        }

        private void ReadAppConfig(string fileName)
        {
            if (!AppConfigClass.ReadConfigBIN(fileName, ref this.appConfig))
            {
            }
        }

        private void ReadPhoneMode()
        {
            string str = string.Empty;
            string str2 = string.Empty;
            string logText = string.Empty;
            string str3 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected EFS partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str3 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str3 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", logText, str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                if (!EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(str3 + "/FactoryApp", false))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                str2 = str3 + "/FactoryApp";
                this.UpdateLogText_MultiThread("Reading current Phone Mode...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "cat", new string[] { str2 + "/factorymode" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                string str5 = str.Remove(str.IndexOf("exitcode=0")).Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids);
                this.UpdateLogText_MultiThread("Phone Mode is currently set to:  ", Color.White, false, true, false);
                if (str5.ToLower() == "on")
                {
                    this.UpdateLogText_MultiThread("USER MODE", Color.Magenta, false, false, false);
                }
                else if (str5.ToLower() == "off")
                {
                    this.UpdateLogText_MultiThread("FACTORY MODE", Color.Magenta, false, false, false);
                }
                else
                {
                    this.UpdateLogText_MultiThread("UNKNOWN!", Color.Red, false, false, false);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private void ReadUSBSettings(string inputStr)
        {
            if (inputStr.ToLower().Equals("mtp,adb"))
            {
                this.cbCurrUSBSettings.SelectedIndex = 0;
            }
            else if (inputStr.ToLower().Equals("ptp,adb"))
            {
                this.cbCurrUSBSettings.SelectedIndex = 1;
            }
            else if (inputStr.ToLower().Equals("diag,acm,adb"))
            {
                this.cbCurrUSBSettings.SelectedIndex = 2;
            }
        }

        private void ReadUSBSettings_MultiThread(string inputStr)
        {
            if (this.InvokeRequired)
            {
                ReadUSBSettings_Delegate method = new ReadUSBSettings_Delegate(this.ReadUSBSettings);
                this.Invoke(method, new object[] { inputStr });
            }
            else
            {
                this.ReadUSBSettings(inputStr);
            }
        }

        private void RefreshBackupArchList()
        {
            this.cbBackupArchives.Items.Clear();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__83));
        }

        private void RefreshFilterList()
        {
            this.devFilterList.Clear();
            this.lvPartitions.Items.Clear();
            this.cbDeviceFilter.Items.Clear();
            if (!Directory.Exists(this.AppPath + @"\DF"))
            {
                Directory.CreateDirectory(this.AppPath + @"\DF");
            }
            DirectoryInfo info = new DirectoryInfo(this.AppPath + @"\DF");
            DeviceFilterClass devFilter = null;
            foreach (FileInfo info2 in info.GetFiles())
            {
                if ((info2.Extension == ".bin") && DeviceFilterClass.ReadBIN(info2.FullName, ref devFilter))
                {
                    this.devFilterList.Add(devFilter);
                    this.cbDeviceFilter.Items.Add(devFilter.DisplayName);
                }
            }
        }

        private void RefreshPartitionList()
        {
            if (this.cbDeviceFilter.SelectedIndex != -1)
            {
                _Closure$__8 e$__ = new _Closure$__8 {
                    $VB$Me = this
                };
                string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
                e$__.$VB$Local_devicePIT = this.AppPath + @"\PIT\" + str + ".pit";
                int selectedIndex = this.cbDeviceFilter.SelectedIndex;
                string partitionsToDisplay = this.devFilterList[selectedIndex].PartitionsToDisplay;
                this.DisableControls_MultiThread();
                this.lvPartitions.Items.Clear();
                this.devicePartitions.Clear();
                this.ClearLog_MultiThread();
                e$__.$VB$Local_deviceFilter = new Regex(@"\b\W*(" + partitionsToDisplay + @")\W*\b", RegexOptions.IgnoreCase);
                ThreadPool.QueueUserWorkItem(new WaitCallback(e$__._Lambda$__72));
            }
            else
            {
                this.lvPartitions.Items.Clear();
            }
        }

        private void RepairNVFromBAK()
        {
            string str = string.Empty;
            string logText = string.Empty;
            string str2 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected EFS partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str2 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str2 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", logText, str2 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Processing 'nv_data.bin'...  ", Color.White, false, true, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "cp", new string[] { "-f", "-p", str2 + "/.nv_data.bak", str2 + "/nv_data.bin" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Processing 'nv_data.bin.md5'...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "cp", new string[] { "-f", "-p", str2 + "/.nv_data.bak.md5", str2 + "/nv_data.bin.md5" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Setting permissions...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "chown", new string[] { "1001:1001", str2 + "/nv_data.bin" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private void RepairNVOwner()
        {
            string str = string.Empty;
            string logText = string.Empty;
            string str2 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected EFS partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str2 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str2 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", logText, str2 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Repairing ownership of '" + str2 + "/nv_data.bin'...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "chown", new string[] { "1001:1001", str2 + "/nv_data.bin" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private void ResetCounterEFS(CounterResetType counter)
        {
            string str = string.Empty;
            string str3 = string.Empty;
            string str2 = string.Empty;
            string logText = string.Empty;
            string str4 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected EFS partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str4 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str4 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", logText, str4 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                if (counter == CounterResetType.BatteryCableCounter)
                {
                    if (!EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(str4 + "/FactoryApp", false))
                    {
                        throw new Exception("This function is not compatible with your device and/or firmware!");
                    }
                    if (!EFS_Professional.WinADBHelper.FileSystem.FileExists(str4 + "/FactoryApp/batt_cable_count"))
                    {
                        throw new Exception("Battery Counter not found on this device!");
                    }
                    str3 = "Battery Cable Counter";
                    str2 = str4 + "/FactoryApp/batt_cable_count";
                }
                else if (counter == CounterResetType.SPenCounter)
                {
                    if (!EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(str4 + "/FactoryApp", false))
                    {
                        throw new Exception("This function is not compatible with your device and/or firmware!");
                    }
                    if (!EFS_Professional.WinADBHelper.FileSystem.FileExists(str4 + "/FactoryApp/epen_count"))
                    {
                        throw new Exception("Battery Counter not found on this device!");
                    }
                    str3 = "SPen Counter";
                    str2 = str4 + "/FactoryApp/epen_count";
                }
                else if (counter == CounterResetType.EarphoneJackCounter)
                {
                    if (!EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(str4 + "/FactoryApp", false))
                    {
                        throw new Exception("This function is not compatible with your device and/or firmware!");
                    }
                    if (!EFS_Professional.WinADBHelper.FileSystem.FileExists(str4 + "/FactoryApp/earjack_count"))
                    {
                        throw new Exception("Battery Counter not found on this device!");
                    }
                    str3 = "Earphone Jack Counter";
                    str2 = str4 + "/FactoryApp/earjack_count";
                }
                this.UpdateLogText_MultiThread("Reading current " + str3 + " value...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "cat", new string[] { str2 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread(str.Remove(str.IndexOf("exitcode=0")).Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids), Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Resetting " + str3 + "...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "echo", new string[] { "-n 0 > " + str2 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Reading NEW " + str3 + " value...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "cat", new string[] { str2 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread(str.Remove(str.IndexOf("exitcode=0")).Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids), Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        public void RunBackup()
        {
            string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
            bool flag = this.chkEnableMD5Backup.CheckState > CheckState.Unchecked;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Checking backup folder location...  ", Color.White, false, false, false);
                EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(this.devStorageLoc + "/EFSProBackup", true);
                EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(this.devStorageLoc + "/EFSProBackup/temp", true);
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                Thread.Sleep(100);
                this.UpdateLogText_MultiThread("Backing up selected partition(s)...", Color.DodgerBlue, false, false, false);
                string expression = string.Empty;
                string[] strArray = new string[] { string.Empty };
                foreach (PartitionInfo info in this.GetSelectedPartitions_MultiThread(SelectedPartitionsMode.Backup))
                {
                    Thread.Sleep(100);
                    this.UpdateLogText_MultiThread(info.PartitionName + " - read: " + info.BlockPath + " - write: " + info.FlashFileName + "...  ", Color.Magenta, false, true, false);
                    expression = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "busybox dd", new string[] { "if=" + info.BlockPath, "of=" + this.devStorageLoc + "/EFSProBackup/temp/" + info.FlashFileName, "bs=4096" }));
                    strArray = Strings.Split(expression, "\r\n", -1, CompareMethod.Binary);
                    if (!expression.ToLower().Contains("exitcode=0"))
                    {
                        throw new Exception("Unable to backup selected partition(s)!\r\n\r\n" + expression);
                    }
                    foreach (string str5 in strArray)
                    {
                        str5 = str5.Trim(new char[] { '\r' });
                        if (str5.ToLower().Contains("bytes transferred") | str5.ToLower().Contains("copied"))
                        {
                            this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                            this.UpdateLogText_MultiThread(str5, Color.Yellow, false, true, false);
                        }
                    }
                    if (flag && !this.CheckMD5Sum(info.BlockPath, this.devStorageLoc + "/EFSProBackup/temp/" + info.FlashFileName))
                    {
                        throw new Exception("MD5 Checksums do not match!");
                    }
                    Thread.Sleep(100);
                }
                this.BackupFileName = string.Format("{0}_{1:D4}{2:D2}{3:D2}_{4:D2}{5:D2}{6:D2}.tar.gz", (object[]) new string[] { str, Conversions.ToString(DateAndTime.Now.Year), Conversions.ToString(DateAndTime.Now.Month), Conversions.ToString(DateAndTime.Now.Day), Conversions.ToString(DateAndTime.Now.Hour), Conversions.ToString(DateAndTime.Now.Minute), Conversions.ToString(DateAndTime.Now.Second) });
                this.UpdateLogText_MultiThread("Creating archive: " + this.BackupFileName + "...  ", Color.White, false, true, false);
                string prompt = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "cd " + this.devStorageLoc + "/EFSProBackup/temp ;", new string[] { "tar czf \"../" + this.BackupFileName + "\" *" }));
                if (prompt.TrimEnd(new char[0]).Contains("exitcode=0"))
                {
                    this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                }
                else
                {
                    Interaction.MsgBox(prompt, MsgBoxStyle.ApplicationModal, null);
                    throw new Exception("Unable to create archive!");
                }
                if (!Directory.Exists(this.AppPath + @"\EFSProBackup"))
                {
                    Directory.CreateDirectory(this.AppPath + @"\EFSProBackup");
                }
                Thread.Sleep(100);
                this.UpdateLogText_MultiThread("Copying: " + this.BackupFileName + " to PC storage...  ", Color.White, false, false, false);
                string str3 = this.myDevice.PullFile(this.devStorageLoc + "/EFSProBackup/" + this.BackupFileName, this.AppPath + @"\EFSProBackup");
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Copied: " + str3, Color.Yellow, false, false, true);
                Thread.Sleep(100);
                this.UpdateLogText_MultiThread("Cleaning up temporary files...  ", Color.White, false, false, false);
                this.CleanUpTempFiles();
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                this.EnableControls_MultiThread();
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Backup);
        }

        public void RunBackupAsync()
        {
            if (this.cbDeviceFilter.SelectedIndex == -1)
            {
                Interaction.MsgBox("To begin, choose a Device Filter then select the partitions you would like to backup.", MsgBoxStyle.Information, null);
            }
            else if (this.lvPartitions.CheckedItems.Count <= 0)
            {
                Interaction.MsgBox("You must select at least one partition to backup!", MsgBoxStyle.Exclamation, null);
            }
            else
            {
                this.DisableControls_MultiThread();
                this.ClearLog_MultiThread();
                if (!File.Exists(Application.StartupPath.ToString() + @"\ADB\adb.exe"))
                {
                    Interaction.MsgBox("ADB executable is missing! Cannot continue!", MsgBoxStyle.Critical, null);
                    this.EnableControls_MultiThread();
                }
                else
                {
                    this.UpdateLogText_MultiThread("Checking device connection...  ", Color.White, false, false, false);
                    if (!this.myAndroid.HasConnectedDevices)
                    {
                        Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
                        this.UpdateLogText_MultiThread("Device is not connected!", Color.Red, false, false, false);
                        this.EnableControls_MultiThread();
                    }
                    else
                    {
                        this.UpdateLogText_MultiThread("Device is connected!", Color.Lime, false, false, true);
                        this.asyncOp = AsyncOperationManager.CreateOperation(null);
                        this.workerThread = new Thread(new ThreadStart(this.RunBackup));
                        this.workerThread.Start();
                    }
                }
            }
        }

        public void RunRestore()
        {
            bool flag = this.chkEnableMD5Restore.CheckState > CheckState.Unchecked;
            bool flag2 = this.chkRbtDevAftRestore.CheckState > CheckState.Unchecked;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Unpacking backup archive contents...  ", Color.White, false, true, false);
                if (!ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "busybox", new string[] { "tar zxf", "\"" + this.devStorageLoc + "/EFSProBackup/" + this.RestoreFileName + "\"", "-C", this.devStorageLoc + "/EFSProBackup/temp" })).TrimEnd(new char[0]).Contains("exitcode=0"))
                {
                    throw new Exception("Unable to extract archive!");
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                Thread.Sleep(100);
                this.UpdateLogText_MultiThread("Restoring selected partition(s)...", Color.DodgerBlue, false, false, false);
                string expression = string.Empty;
                string[] strArray = new string[] { string.Empty };
                foreach (PartitionInfo info in this.GetSelectedPartitions_MultiThread(SelectedPartitionsMode.Restore))
                {
                    Thread.Sleep(100);
                    this.UpdateLogText_MultiThread(info.PartitionName + " - read: " + info.FlashFileName + " - write: " + info.BlockPath + "...  ", Color.Magenta, false, true, false);
                    expression = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "busybox dd", new string[] { "if=\"" + this.devStorageLoc + "/EFSProBackup/temp/" + info.FlashFileName + "\"", "of=" + info.BlockPath, "bs=4096" }));
                    strArray = Strings.Split(expression, "\r\n", -1, CompareMethod.Binary);
                    if (!expression.ToLower().Contains("exitcode=0"))
                    {
                        throw new Exception("Unable to restore selected partition(s)!\r\n\r\n" + expression);
                    }
                    foreach (string str4 in strArray)
                    {
                        str4 = str4.Trim(new char[] { '\r' });
                        if (str4.ToLower().Contains("bytes transferred") | str4.ToLower().Contains("copied"))
                        {
                            this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                            this.UpdateLogText_MultiThread(str4, Color.Yellow, false, true, false);
                        }
                    }
                    if (flag && !this.CheckMD5Sum(info.BlockPath, this.devStorageLoc + "/EFSProBackup/temp/" + info.FlashFileName))
                    {
                        throw new Exception("MD5 Checksums do not match!");
                    }
                }
                this.UpdateLogText_MultiThread("Cleaning up temporary files...  ", Color.White, false, true, false);
                this.CleanUpTempFiles();
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                if (flag2)
                {
                    this.UpdateLogText_MultiThread("Rebooting Device...  ", Color.White, false, true, false);
                    ADB.Reboot(false);
                    this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Restore);
        }

        private bool ScanForBackups(string commandInput)
        {
            string[] strArray = Strings.Split(commandInput, "\r\n", -1, CompareMethod.Binary);
            string str = BuildPropertyParser.GetProperty("ro.product.model").Replace(" ", "_");
            bool flag2 = true;
            if (flag2 == commandInput.ToLower().Contains("permission denied"))
            {
                return false;
            }
            if (flag2 == commandInput.ToLower().Contains("no such file or directory"))
            {
                return false;
            }
            foreach (string str2 in strArray)
            {
                str2 = str2.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids);
                if (str2.ToLower().StartsWith(str.ToLower()) && str2.ToLower().Contains(".tar.gz"))
                {
                    this.cbBackupArchives.Items.Add(str2 + " (Device)");
                }
            }
            if (!Directory.Exists(this.AppPath + @"\EFSProBackup"))
            {
                return false;
            }
            foreach (string str3 in Directory.GetFiles(this.AppPath + @"\EFSProBackup"))
            {
                if (Path.GetFileName(str3).ToLower().StartsWith(str.ToLower()) && Path.GetFileName(str3).ToLower().Contains(".tar.gz"))
                {
                    this.cbBackupArchives.Items.Add(Path.GetFileName(str3) + " (PC)");
                }
            }
            this.cbBackupArchives.Refresh();
            return true;
        }

        public bool ScanForBackups_MultiThread(string commandInput)
        {
            if (this.InvokeRequired)
            {
                ScanForBackups_Delegate method = new ScanForBackups_Delegate(this.ScanForBackups);
                return Conversions.ToBoolean(this.Invoke(method, new object[] { commandInput }));
            }
            return this.ScanForBackups(commandInput);
        }

        private void ShowDonateDialog()
        {
            if (Interaction.MsgBox("Thank you for using EFS Professional. Would you like to make a donation?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "Show Your Support! :-)") == MsgBoxResult.Yes)
            {
                Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=7910259");
            }
        }

        private void tcEFSProUI_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.CheckAppConfig();
            if (this.tcEFSProUI.SelectedIndex == 3)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this._Lambda$__38));
            }
            if (this.tcEFSProUI.SelectedIndex == 4)
            {
                if (this.appDebug == 1)
                {
                    this.chkEnableAppDebug.Checked = true;
                }
                else
                {
                    this.chkEnableAppDebug.Checked = false;
                }
                this.txtDevStorageLoc.Text = this.devStorageLoc;
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

        private void tsManFilterCreateNew_Click(object sender, EventArgs e)
        {
            try
            {
                DeviceFilterEditor editor = new DeviceFilterEditor(this.myDevice, this.myAndroid, this.devStorageLoc, this.pitBufferSize, this.samsungMode);
                if (editor.ShowDialog() != DialogResult.Cancel)
                {
                    this.RefreshFilterList();
                }
                editor.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An error occurred while loading the Device Filter Editor.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void tsManFilterDeleteSel_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.cbDeviceFilter.SelectedIndex;
            if (Interaction.MsgBox("Would you like to delete the selected Device Filter?", MsgBoxStyle.Question | MsgBoxStyle.OkCancel, null) == MsgBoxResult.Ok)
            {
                if (File.Exists(this.devFilterList[selectedIndex].FileName))
                {
                    File.Delete(this.devFilterList[selectedIndex].FileName);
                }
                this.RefreshFilterList();
            }
        }

        private void tsManFilterEditSel_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = this.cbDeviceFilter.SelectedIndex;
                DeviceFilterEditor editor = new DeviceFilterEditor(this.devFilterList[selectedIndex].FileName, this.myDevice, this.myAndroid, this.devStorageLoc, this.pitBufferSize, this.samsungMode);
                if (editor.ShowDialog() != DialogResult.Cancel)
                {
                    this.RefreshFilterList();
                    this.cbDeviceFilter.SelectedIndex = selectedIndex;
                }
                editor.Dispose();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An error occurred while loading the Device Filter Editor.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void tsManFilterRefresh_Click(object sender, EventArgs e)
        {
            this.RefreshFilterList();
        }

        private void TxtLog_TextChanged(object sender, EventArgs e)
        {
            this.rtConsoleLog.ScrollToCaret();
        }

        private void UpdateLogText(string LogText, Color LogTextColour, bool Aligned, bool NewLineBefore, bool NewLineAfter)
        {
            if (NewLineBefore)
            {
                this.rtConsoleLog.AppendText("\r\n");
            }
            this.rtConsoleLog.SelectionColor = LogTextColour;
            this.rtConsoleLog.SelectionHangingIndent = 0xb8;
            if (Aligned)
            {
                if (!string.IsNullOrEmpty(LogText))
                {
                    this.rtConsoleLog.AppendText(string.Format("{0,-23}", LogText));
                }
                else
                {
                    this.rtConsoleLog.AppendText(string.Format("{0,-23}", string.Empty));
                }
            }
            else if (!string.IsNullOrEmpty(LogText))
            {
                this.rtConsoleLog.AppendText(LogText);
            }
            else
            {
                this.rtConsoleLog.AppendText(string.Empty);
            }
            if (NewLineAfter)
            {
                this.rtConsoleLog.AppendText("\r\n");
            }
            this.rtConsoleLog.ScrollToCaret();
            this.rtConsoleLog.Refresh();
        }

        public void UpdateLogText_MultiThread(string LogText, Color LogTextColour, bool Aligned, bool NewLineBefore, bool NewLineAfter)
        {
            if (this.InvokeRequired)
            {
                UpdateLogText_Delegate method = new UpdateLogText_Delegate(this.UpdateLogText);
                this.Invoke(method, new object[] { LogText, LogTextColour, Aligned, NewLineBefore, NewLineAfter });
            }
            else
            {
                this.UpdateLogText(LogText, LogTextColour, Aligned, NewLineBefore, NewLineAfter);
            }
        }

        private void WriteAppConfig(string fileName)
        {
            string str;
            if (this.chkEnableAppDebug.Checked)
            {
                this.appDebug = 1;
            }
            else
            {
                this.appDebug = 0;
            }
            if (!string.IsNullOrEmpty(this.txtDevStorageLoc.Text))
            {
                this.devStorageLoc = this.txtDevStorageLoc.Text;
            }
            if (this.cbPITBufferSize.SelectedIndex != -1)
            {
                str = this.cbPITBufferSize.SelectedItem.ToString();
                str = str.Remove(str.IndexOf(" "));
            }
            else
            {
                this.cbPITBufferSize.SelectedIndex = 0;
                str = "1024";
            }
            this.pitBufferSize = Conversions.ToInteger(str);
            if (!AppConfigClass.WriteConfigBIN(new AppConfigClass(this.appDebug, this.devStorageLoc, this.pitBufferSize), this.AppPath + @"\" + this.appConfigFile))
            {
            }
        }

        private void WritePhoneMode(string inputStr)
        {
            string str = string.Empty;
            string str2 = string.Empty;
            string logText = string.Empty;
            string str3 = string.Empty;
            Exception exc = null;
            try
            {
                this.UpdateLogText_MultiThread("Detected EFS partition location:  ", Color.White, false, true, false);
                if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/factory");
                    str3 = "factory";
                }
                else
                {
                    logText = EFS_Professional.WinADBHelper.FileSystem.GetMountPoint("/efs");
                    str3 = "efs";
                }
                if (logText == "Failed!")
                {
                    throw new Exception("Can't locate mount point!");
                }
                if (logText.ToLower().Contains("mountpoint applet not found"))
                {
                    throw new Exception("mountpoint applet not found!");
                }
                this.UpdateLogText_MultiThread(logText, Color.Yellow, false, false, true);
                this.UpdateLogText_MultiThread("Re-mounting ROOT file system...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", "rootfs", "/" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Mounting EFS folder as read/write...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "mount", new string[] { "-o", "rw,remount", logText, str3 }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                if (!EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(str3 + "/FactoryApp", false))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                str2 = str3 + "/FactoryApp";
                this.UpdateLogText_MultiThread("Writing Phone Mode...  ", Color.White, false, false, false);
                str = ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.myDevice, true, "echo", new string[] { "-n " + inputStr + " > " + str2 + "/factorymode" }));
                if (!str.Contains("exitcode=0"))
                {
                    throw new Exception(str.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids));
                }
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                this.UpdateLogText_MultiThread("Rebooting Device...  ", Color.White, false, false, false);
                ADB.Reboot(false);
                this.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                exc = exception1;
                ProjectData.ClearProjectError();
            }
            this.AsyncMethodCompleted(exc, OperationType.Normal);
        }

        private string WriteUSBSettings()
        {
            if (this.cbCurrUSBSettings.SelectedIndex == 0)
            {
                return "mtp,adb";
            }
            if (this.cbCurrUSBSettings.SelectedIndex == 1)
            {
                return "ptp,adb";
            }
            if (this.cbCurrUSBSettings.SelectedIndex == 2)
            {
                return "diag,acm,adb";
            }
            return "-1";
        }

        private string WriteUSBSettings_MultiThread()
        {
            if (this.InvokeRequired)
            {
                return Conversions.ToString(this.Invoke(new WriteUSBSettings_Delegate(this.WriteUSBSettings)));
            }
            return this.WriteUSBSettings();
        }

        internal virtual Button btnBackup
        {
            get => 
                this._btnBackup;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnBackup_Click);
                if (this._btnBackup != null)
                {
                    this._btnBackup.Click -= handler;
                }
                this._btnBackup = value;
                if (this._btnBackup != null)
                {
                    this._btnBackup.Click += handler;
                }
            }
        }

        internal virtual Button btnClearLog
        {
            get => 
                this._btnClearLog;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnClearLog_Click);
                if (this._btnClearLog != null)
                {
                    this._btnClearLog.Click -= handler;
                }
                this._btnClearLog = value;
                if (this._btnClearLog != null)
                {
                    this._btnClearLog.Click += handler;
                }
            }
        }

        internal virtual Button btnDeselAllRest
        {
            get => 
                this._btnDeselAllRest;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDeselAllRest_Click);
                if (this._btnDeselAllRest != null)
                {
                    this._btnDeselAllRest.Click -= handler;
                }
                this._btnDeselAllRest = value;
                if (this._btnDeselAllRest != null)
                {
                    this._btnDeselAllRest.Click += handler;
                }
            }
        }

        internal virtual Button btnDeselectAll
        {
            get => 
                this._btnDeselectAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDeselectAll_Click);
                if (this._btnDeselectAll != null)
                {
                    this._btnDeselectAll.Click -= handler;
                }
                this._btnDeselectAll = value;
                if (this._btnDeselectAll != null)
                {
                    this._btnDeselectAll.Click += handler;
                }
            }
        }

        internal virtual Button btnDevADBShell
        {
            get => 
                this._btnDevADBShell;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDevADBShell_Click);
                if (this._btnDevADBShell != null)
                {
                    this._btnDevADBShell.Click -= handler;
                }
                this._btnDevADBShell = value;
                if (this._btnDevADBShell != null)
                {
                    this._btnDevADBShell.Click += handler;
                }
            }
        }

        internal virtual Button btnDeviceInfo
        {
            get => 
                this._btnDeviceInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDeviceInfo_Click);
                if (this._btnDeviceInfo != null)
                {
                    this._btnDeviceInfo.Click -= handler;
                }
                this._btnDeviceInfo = value;
                if (this._btnDeviceInfo != null)
                {
                    this._btnDeviceInfo.Click += handler;
                }
            }
        }

        internal virtual Button btnDeviceToolsExec
        {
            get => 
                this._btnDeviceToolsExec;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnDeviceToolsExec_Click);
                if (this._btnDeviceToolsExec != null)
                {
                    this._btnDeviceToolsExec.Click -= handler;
                }
                this._btnDeviceToolsExec = value;
                if (this._btnDeviceToolsExec != null)
                {
                    this._btnDeviceToolsExec.Click += handler;
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

        internal virtual Button btnGetEFSMountpoint
        {
            get => 
                this._btnGetEFSMountpoint;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnGetEFSMountpoint_Click);
                if (this._btnGetEFSMountpoint != null)
                {
                    this._btnGetEFSMountpoint.Click -= handler;
                }
                this._btnGetEFSMountpoint = value;
                if (this._btnGetEFSMountpoint != null)
                {
                    this._btnGetEFSMountpoint.Click += handler;
                }
            }
        }

        internal virtual Button btnGetPartList
        {
            get => 
                this._btnGetPartList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnGetPartList_Click);
                if (this._btnGetPartList != null)
                {
                    this._btnGetPartList.Click -= handler;
                }
                this._btnGetPartList = value;
                if (this._btnGetPartList != null)
                {
                    this._btnGetPartList.Click += handler;
                }
            }
        }

        internal virtual Button btnGetPropQuery
        {
            get => 
                this._btnGetPropQuery;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnGetPropQuery_Click);
                if (this._btnGetPropQuery != null)
                {
                    this._btnGetPropQuery.Click -= handler;
                }
                this._btnGetPropQuery = value;
                if (this._btnGetPropQuery != null)
                {
                    this._btnGetPropQuery.Click += handler;
                }
            }
        }

        internal virtual Button btnLaunchPhSVCApp
        {
            get => 
                this._btnLaunchPhSVCApp;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnLaunchPhSVCApp_Click);
                if (this._btnLaunchPhSVCApp != null)
                {
                    this._btnLaunchPhSVCApp.Click -= handler;
                }
                this._btnLaunchPhSVCApp = value;
                if (this._btnLaunchPhSVCApp != null)
                {
                    this._btnLaunchPhSVCApp.Click += handler;
                }
            }
        }

        internal virtual Button btnManage
        {
            get => 
                this._btnManage;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnbtnManage_Click);
                if (this._btnManage != null)
                {
                    this._btnManage.Click -= handler;
                }
                this._btnManage = value;
                if (this._btnManage != null)
                {
                    this._btnManage.Click += handler;
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

        internal virtual Button btnRebootGo
        {
            get => 
                this._btnRebootGo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRebootGo_Click);
                if (this._btnRebootGo != null)
                {
                    this._btnRebootGo.Click -= handler;
                }
                this._btnRebootGo = value;
                if (this._btnRebootGo != null)
                {
                    this._btnRebootGo.Click += handler;
                }
            }
        }

        internal virtual Button btnRefreshBackups
        {
            get => 
                this._btnRefreshBackups;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRefreshBackups_Click);
                if (this._btnRefreshBackups != null)
                {
                    this._btnRefreshBackups.Click -= handler;
                }
                this._btnRefreshBackups = value;
                if (this._btnRefreshBackups != null)
                {
                    this._btnRefreshBackups.Click += handler;
                }
            }
        }

        internal virtual Button btnRefreshList
        {
            get => 
                this._btnRefreshList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRefreshList_Click);
                if (this._btnRefreshList != null)
                {
                    this._btnRefreshList.Click -= handler;
                }
                this._btnRefreshList = value;
                if (this._btnRefreshList != null)
                {
                    this._btnRefreshList.Click += handler;
                }
            }
        }

        internal virtual Button btnRestore
        {
            get => 
                this._btnRestore;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRestore_Click);
                if (this._btnRestore != null)
                {
                    this._btnRestore.Click -= handler;
                }
                this._btnRestore = value;
                if (this._btnRestore != null)
                {
                    this._btnRestore.Click += handler;
                }
            }
        }

        internal virtual Button btnSelAllRest
        {
            get => 
                this._btnSelAllRest;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSelAllRest_Click);
                if (this._btnSelAllRest != null)
                {
                    this._btnSelAllRest.Click -= handler;
                }
                this._btnSelAllRest = value;
                if (this._btnSelAllRest != null)
                {
                    this._btnSelAllRest.Click += handler;
                }
            }
        }

        internal virtual Button btnSelectAll
        {
            get => 
                this._btnSelectAll;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSelectAll_Click);
                if (this._btnSelectAll != null)
                {
                    this._btnSelectAll.Click -= handler;
                }
                this._btnSelectAll = value;
                if (this._btnSelectAll != null)
                {
                    this._btnSelectAll.Click += handler;
                }
            }
        }

        internal virtual Button btnTestBBPresence
        {
            get => 
                this._btnTestBBPresence;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnTestBBPresence_Click);
                if (this._btnTestBBPresence != null)
                {
                    this._btnTestBBPresence.Click -= handler;
                }
                this._btnTestBBPresence = value;
                if (this._btnTestBBPresence != null)
                {
                    this._btnTestBBPresence.Click += handler;
                }
            }
        }

        internal virtual Button btnTestRootPerm
        {
            get => 
                this._btnTestRootPerm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnTestRootPerm_Click);
                if (this._btnTestRootPerm != null)
                {
                    this._btnTestRootPerm.Click -= handler;
                }
                this._btnTestRootPerm = value;
                if (this._btnTestRootPerm != null)
                {
                    this._btnTestRootPerm.Click += handler;
                }
            }
        }

        internal virtual Button btnTestWaitDevice
        {
            get => 
                this._btnTestWaitDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnTestWaitDevice_Click);
                if (this._btnTestWaitDevice != null)
                {
                    this._btnTestWaitDevice.Click -= handler;
                }
                this._btnTestWaitDevice = value;
                if (this._btnTestWaitDevice != null)
                {
                    this._btnTestWaitDevice.Click += handler;
                }
            }
        }

        internal virtual ComboBox cbBackupArchives
        {
            get => 
                this._cbBackupArchives;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbBackupArchives_SelectedIndexChanged);
                if (this._cbBackupArchives != null)
                {
                    this._cbBackupArchives.SelectedIndexChanged -= handler;
                }
                this._cbBackupArchives = value;
                if (this._cbBackupArchives != null)
                {
                    this._cbBackupArchives.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbCurrUSBSettings
        {
            get => 
                this._cbCurrUSBSettings;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbCurrUSBSettings_SelectedIndexChanged);
                if (this._cbCurrUSBSettings != null)
                {
                    this._cbCurrUSBSettings.SelectedIndexChanged -= handler;
                }
                this._cbCurrUSBSettings = value;
                if (this._cbCurrUSBSettings != null)
                {
                    this._cbCurrUSBSettings.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbDeviceFilter
        {
            get => 
                this._cbDeviceFilter;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbDeviceFilter_SelectedIndexChanged);
                if (this._cbDeviceFilter != null)
                {
                    this._cbDeviceFilter.SelectedIndexChanged -= handler;
                }
                this._cbDeviceFilter = value;
                if (this._cbDeviceFilter != null)
                {
                    this._cbDeviceFilter.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbOtherTools
        {
            get => 
                this._cbOtherTools;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbOtherTools_SelectedIndexChanged);
                if (this._cbOtherTools != null)
                {
                    this._cbOtherTools.SelectedIndexChanged -= handler;
                }
                this._cbOtherTools = value;
                if (this._cbOtherTools != null)
                {
                    this._cbOtherTools.SelectedIndexChanged += handler;
                }
            }
        }

        internal virtual ComboBox cbPhoneSVCApps
        {
            get => 
                this._cbPhoneSVCApps;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbPhoneSVCApps = value;
            }
        }

        internal virtual ComboBox cbPITBufferSize
        {
            get => 
                this._cbPITBufferSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbPITBufferSize = value;
            }
        }

        internal virtual ComboBox cbRebootOpt
        {
            get => 
                this._cbRebootOpt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cbRebootOpt = value;
            }
        }

        internal virtual CheckBox CheckBox1
        {
            get => 
                this._CheckBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._CheckBox1 = value;
            }
        }

        internal virtual CheckBox chkEnableAppDebug
        {
            get => 
                this._chkEnableAppDebug;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkEnableAppDebug = value;
            }
        }

        internal virtual CheckBox chkEnableMD5Backup
        {
            get => 
                this._chkEnableMD5Backup;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkEnableMD5Backup = value;
            }
        }

        internal virtual CheckBox chkEnableMD5Restore
        {
            get => 
                this._chkEnableMD5Restore;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkEnableMD5Restore = value;
            }
        }

        internal virtual CheckBox chkRbtDevAftRestore
        {
            get => 
                this._chkRbtDevAftRestore;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkRbtDevAftRestore = value;
            }
        }

        internal virtual CheckBox chkSwitchAuto
        {
            get => 
                this._chkSwitchAuto;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkSwitchAuto = value;
            }
        }

        internal virtual CheckBox chkUseBPP
        {
            get => 
                this._chkUseBPP;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._chkUseBPP = value;
            }
        }

        internal virtual ContextMenuStrip cmsManageFilters
        {
            get => 
                this._cmsManageFilters;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._cmsManageFilters = value;
            }
        }

        internal virtual GroupBox gbAppConfig
        {
            get => 
                this._gbAppConfig;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbAppConfig = value;
            }
        }

        internal virtual GroupBox gbBackArchCont
        {
            get => 
                this._gbBackArchCont;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbBackArchCont = value;
            }
        }

        internal virtual GroupBox gbBackupArchives
        {
            get => 
                this._gbBackupArchives;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbBackupArchives = value;
            }
        }

        internal virtual GroupBox gbBackupOptions
        {
            get => 
                this._gbBackupOptions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbBackupOptions = value;
            }
        }

        internal virtual GroupBox gbBuildProps
        {
            get => 
                this._gbBuildProps;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbBuildProps = value;
            }
        }

        internal virtual GroupBox gbDeviceFilters
        {
            get => 
                this._gbDeviceFilters;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbDeviceFilters = value;
            }
        }

        internal virtual GroupBox gbDevPartitions
        {
            get => 
                this._gbDevPartitions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbDevPartitions = value;
            }
        }

        internal virtual GroupBox gbDevStorageOpt
        {
            get => 
                this._gbDevStorageOpt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbDevStorageOpt = value;
            }
        }

        internal virtual GroupBox gbMountPart
        {
            get => 
                this._gbMountPart;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbMountPart = value;
            }
        }

        internal virtual GroupBox gbOtherTools
        {
            get => 
                this._gbOtherTools;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbOtherTools = value;
            }
        }

        internal virtual GroupBox gbPhoneSVCApps
        {
            get => 
                this._gbPhoneSVCApps;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbPhoneSVCApps = value;
            }
        }

        internal virtual GroupBox gbPITOptions
        {
            get => 
                this._gbPITOptions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbPITOptions = value;
            }
        }

        internal virtual GroupBox gbQCDevSupport
        {
            get => 
                this._gbQCDevSupport;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbQCDevSupport = value;
            }
        }

        internal virtual GroupBox gbRebootOptions
        {
            get => 
                this._gbRebootOptions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbRebootOptions = value;
            }
        }

        internal virtual GroupBox gbRestoreOptions
        {
            get => 
                this._gbRestoreOptions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbRestoreOptions = value;
            }
        }

        internal virtual GroupBox gbTests
        {
            get => 
                this._gbTests;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbTests = value;
            }
        }

        internal virtual ColumnHeader hdrBlockDevice
        {
            get => 
                this._hdrBlockDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._hdrBlockDevice = value;
            }
        }

        internal virtual ColumnHeader hdrFlashFileName
        {
            get => 
                this._hdrFlashFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._hdrFlashFileName = value;
            }
        }

        internal virtual ColumnHeader hdrPartitionName
        {
            get => 
                this._hdrPartitionName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._hdrPartitionName = value;
            }
        }

        internal virtual ColumnHeader hdrTargetBlockDevice
        {
            get => 
                this._hdrTargetBlockDevice;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._hdrTargetBlockDevice = value;
            }
        }

        internal virtual Label lblAppDebug
        {
            get => 
                this._lblAppDebug;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblAppDebug = value;
            }
        }

        internal virtual Label lblCurrUSBSettings
        {
            get => 
                this._lblCurrUSBSettings;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblCurrUSBSettings = value;
            }
        }

        internal virtual Label lblDevStorageLoc
        {
            get => 
                this._lblDevStorageLoc;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDevStorageLoc = value;
            }
        }

        internal virtual Label lblDevStorageLocInfo
        {
            get => 
                this._lblDevStorageLocInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDevStorageLocInfo = value;
            }
        }

        internal virtual Label lblDisclaimer
        {
            get => 
                this._lblDisclaimer;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDisclaimer = value;
            }
        }

        internal virtual Label lblDisclaimerInfo
        {
            get => 
                this._lblDisclaimerInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDisclaimerInfo = value;
            }
        }

        internal virtual Label lblEnableAppDebugInfo
        {
            get => 
                this._lblEnableAppDebugInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblEnableAppDebugInfo = value;
            }
        }

        internal virtual Label lblLaunchPhSVCAppInfo
        {
            get => 
                this._lblLaunchPhSVCAppInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblLaunchPhSVCAppInfo = value;
            }
        }

        internal virtual Label lblOtherToolsDesc
        {
            get => 
                this._lblOtherToolsDesc;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblOtherToolsDesc = value;
            }
        }

        internal virtual Label lblOtherToolsDescTitle
        {
            get => 
                this._lblOtherToolsDescTitle;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblOtherToolsDescTitle = value;
            }
        }

        internal virtual Label lblOtherToolsInfo
        {
            get => 
                this._lblOtherToolsInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblOtherToolsInfo = value;
            }
        }

        internal virtual Label lblPITBuffDefault
        {
            get => 
                this._lblPITBuffDefault;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITBuffDefault = value;
            }
        }

        internal virtual Label lblPITBufferSize
        {
            get => 
                this._lblPITBufferSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITBufferSize = value;
            }
        }

        internal virtual Label lblPITBuffInfo
        {
            get => 
                this._lblPITBuffInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITBuffInfo = value;
            }
        }

        internal virtual Label lblQCDevSuppInfo
        {
            get => 
                this._lblQCDevSuppInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblQCDevSuppInfo = value;
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

        internal virtual ListView lvBackupContents
        {
            get => 
                this._lvBackupContents;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ColumnWidthChangingEventHandler handler = new ColumnWidthChangingEventHandler(this.lvBackupContents_ColumnWidthChanging);
                if (this._lvBackupContents != null)
                {
                    this._lvBackupContents.ColumnWidthChanging -= handler;
                }
                this._lvBackupContents = value;
                if (this._lvBackupContents != null)
                {
                    this._lvBackupContents.ColumnWidthChanging += handler;
                }
            }
        }

        internal virtual ListView lvPartitions
        {
            get => 
                this._lvPartitions;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                ColumnWidthChangingEventHandler handler = new ColumnWidthChangingEventHandler(this.lvPartitions_ColumnWidthChanging);
                if (this._lvPartitions != null)
                {
                    this._lvPartitions.ColumnWidthChanging -= handler;
                }
                this._lvPartitions = value;
                if (this._lvPartitions != null)
                {
                    this._lvPartitions.ColumnWidthChanging += handler;
                }
            }
        }

        private AsyncProcess myProcess
        {
            get => 
                this._myProcess;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                AsyncProcess.OnOutputDataReceivedEventHandler handler = new AsyncProcess.OnOutputDataReceivedEventHandler(this.myProcess_OutputDataReceived);
                if (this._myProcess != null)
                {
                    this._myProcess.OnOutputDataReceived -= handler;
                }
                this._myProcess = value;
                if (this._myProcess != null)
                {
                    this._myProcess.OnOutputDataReceived += handler;
                }
            }
        }

        internal virtual RichTextBox rtConsoleLog
        {
            get => 
                this._rtConsoleLog;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.TxtLog_TextChanged);
                if (this._rtConsoleLog != null)
                {
                    this._rtConsoleLog.TextChanged -= handler;
                }
                this._rtConsoleLog = value;
                if (this._rtConsoleLog != null)
                {
                    this._rtConsoleLog.TextChanged += handler;
                }
            }
        }

        internal virtual TabPage tabAppConfig
        {
            get => 
                this._tabAppConfig;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabAppConfig = value;
            }
        }

        internal virtual TabPage tabBackup
        {
            get => 
                this._tabBackup;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabBackup = value;
            }
        }

        internal virtual TabPage tabDebug
        {
            get => 
                this._tabDebug;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabDebug = value;
            }
        }

        internal virtual TabPage tabInformation
        {
            get => 
                this._tabInformation;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabInformation = value;
            }
        }

        internal virtual TabPage tabRestore
        {
            get => 
                this._tabRestore;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabRestore = value;
            }
        }

        internal virtual TabPage tabSamsungTools
        {
            get => 
                this._tabSamsungTools;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabSamsungTools = value;
            }
        }

        internal virtual TabControl tcEFSProUI
        {
            get => 
                this._tcEFSProUI;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tcEFSProUI_SelectedIndexChanged);
                if (this._tcEFSProUI != null)
                {
                    this._tcEFSProUI.SelectedIndexChanged -= handler;
                }
                this._tcEFSProUI = value;
                if (this._tcEFSProUI != null)
                {
                    this._tcEFSProUI.SelectedIndexChanged += handler;
                }
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

        internal virtual System.Windows.Forms.Timer TimerTrigger
        {
            get => 
                this._TimerTrigger;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._TimerTrigger = value;
            }
        }

        internal virtual ToolStripMenuItem tsManFilterCreateNew
        {
            get => 
                this._tsManFilterCreateNew;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tsManFilterCreateNew_Click);
                if (this._tsManFilterCreateNew != null)
                {
                    this._tsManFilterCreateNew.Click -= handler;
                }
                this._tsManFilterCreateNew = value;
                if (this._tsManFilterCreateNew != null)
                {
                    this._tsManFilterCreateNew.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem tsManFilterDeleteSel
        {
            get => 
                this._tsManFilterDeleteSel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tsManFilterDeleteSel_Click);
                if (this._tsManFilterDeleteSel != null)
                {
                    this._tsManFilterDeleteSel.Click -= handler;
                }
                this._tsManFilterDeleteSel = value;
                if (this._tsManFilterDeleteSel != null)
                {
                    this._tsManFilterDeleteSel.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem tsManFilterEditSel
        {
            get => 
                this._tsManFilterEditSel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tsManFilterEditSel_Click);
                if (this._tsManFilterEditSel != null)
                {
                    this._tsManFilterEditSel.Click -= handler;
                }
                this._tsManFilterEditSel = value;
                if (this._tsManFilterEditSel != null)
                {
                    this._tsManFilterEditSel.Click += handler;
                }
            }
        }

        internal virtual ToolStripMenuItem tsManFilterRefresh
        {
            get => 
                this._tsManFilterRefresh;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.tsManFilterRefresh_Click);
                if (this._tsManFilterRefresh != null)
                {
                    this._tsManFilterRefresh.Click -= handler;
                }
                this._tsManFilterRefresh = value;
                if (this._tsManFilterRefresh != null)
                {
                    this._tsManFilterRefresh.Click += handler;
                }
            }
        }

        internal virtual TextBox txtDevStorageLoc
        {
            get => 
                this._txtDevStorageLoc;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtDevStorageLoc = value;
            }
        }

        internal virtual TextBox txtInformation
        {
            get => 
                this._txtInformation;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtInformation = value;
            }
        }

        [CompilerGenerated]
        internal class _Closure$__11
        {
            public bool $VB$Local_copyToDevice;
            public string $VB$Local_devicePIT;
            public frmEFSProMain $VB$Me;

            [CompilerGenerated, DebuggerStepThrough]
            public void _Lambda$__77(object a0)
            {
                new VB$AnonymousDelegate_1(this._Lambda$__78)();
            }

            [CompilerGenerated]
            public void _Lambda$__78()
            {
                try
                {
                    this.$VB$Me.UpdateLogText_MultiThread("Preparing backup archive for restore, please wait...", Color.DodgerBlue, false, false, false);
                    Thread.Sleep(100);
                    if (this.$VB$Me.samsungMode)
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("Extracting PIT from device for mapping...  ", Color.White, false, true, false);
                        if (File.Exists(this.$VB$Local_devicePIT))
                        {
                            this.$VB$Me.UpdateLogText_MultiThread("Skipped, already exists.", Color.Yellow, false, false, false);
                        }
                        else
                        {
                            if (!Directory.Exists(this.$VB$Me.AppPath + @"\PIT"))
                            {
                                Directory.CreateDirectory(this.$VB$Me.AppPath + @"\PIT");
                            }
                            if (!EFS_Professional.WinADBHelper.FileSystem.GetDevicePIT(this.$VB$Me.AppPath + @"\PIT", ref this.$VB$Local_devicePIT, this.$VB$Me.devStorageLoc, this.$VB$Me.pitBufferSize))
                            {
                                throw new Exception("Unable to extract PIT from device!");
                            }
                            this.$VB$Local_devicePIT = this.$VB$Local_devicePIT.Insert(0, this.$VB$Me.AppPath + @"\PIT\");
                            this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                        }
                        this.$VB$Me.UpdateLogText_MultiThread("Checking PIT file integrity...  ", Color.White, false, true, false);
                        if (EFS_Professional.WinADBHelper.FileSystem.ParsePIT(this.$VB$Local_devicePIT) == null)
                        {
                            throw new Exception("The PIT file is corrupt or invalid!");
                        }
                        this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                        this.$VB$Me.devicePartitions = EFS_Professional.WinADBHelper.FileSystem.GetSamsungPartitions(this.$VB$Local_devicePIT);
                    }
                    else
                    {
                        this.$VB$Me.devicePartitions = EFS_Professional.WinADBHelper.FileSystem.GetPartitions();
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Checking backup folder location...  ", Color.White, false, true, false);
                    EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(this.$VB$Me.devStorageLoc + "/EFSProBackup", true);
                    if (EFS_Professional.WinADBHelper.FileSystem.DirectoryExists(this.$VB$Me.devStorageLoc + "/EFSProBackup/temp", true))
                    {
                        ADB.IssueADBCmdNoOutput(ADB.CreateADBShellCmd(this.$VB$Me.myDevice, true, "busybox rm -rf", new string[] { this.$VB$Me.devStorageLoc + "/EFSProBackup/temp/*" }));
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                    this.$VB$Me.Invoke(new Action(this._Lambda$__79));
                    if (this.$VB$Local_copyToDevice)
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("Copying backup archive to device...  ", Color.White, false, true, false);
                        string str2 = this.$VB$Me.myDevice.PushFile(this.$VB$Me.AppPath + @"\EFSProBackup\" + this.$VB$Me.RestoreFileName, this.$VB$Me.devStorageLoc + "/EFSProBackup");
                        this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                        this.$VB$Me.UpdateLogText_MultiThread("Copied: " + str2, Color.Yellow, false, true, false);
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Reading backup archive contents...  ", Color.White, false, true, false);
                    string[] strArray = Strings.Split(ADB.IssueADBCmd(ADB.CreateADBShellCmd(this.$VB$Me.myDevice, true, "busybox", new string[] { "tar", "-tzf", "\"" + this.$VB$Me.devStorageLoc + "/EFSProBackup/" + this.$VB$Me.RestoreFileName + "\"" })), "\r\n", -1, CompareMethod.Binary);
                    using (List<PartitionInfo>.Enumerator enumerator = this.$VB$Me.devicePartitions.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            _Closure$__12 e$__;
                            e$__ = new _Closure$__12(e$__) {
                                $VB$Local_item = enumerator.Current,
                                $VB$NonLocal__Closure$__11 = this
                            };
                            foreach (string str3 in strArray)
                            {
                                str3 = str3.Trim(EFS_Professional.WinADBHelper.FileSystem.Invalids);
                                if (e$__.$VB$Local_item.FlashFileName.ToLower() == str3.ToLower())
                                {
                                    this.$VB$Me.Invoke(new Action(e$__._Lambda$__80));
                                    continue;
                                }
                            }
                        }
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                    this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(this.$VB$Me._Lambda$__81));
                    this.$VB$Me.UpdateLogText_MultiThread("Backup archive is now ready for restore!", Color.DodgerBlue, false, true, false);
                    this.$VB$Me.EnableControls_MultiThread();
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    _Closure$__13 e$__2 = new _Closure$__13 {
                        $VB$Local_ex = exception
                    };
                    this.$VB$Me.UpdateLogText_MultiThread("Operation Failed!", Color.Red, false, true, false);
                    this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(e$__2._Lambda$__82));
                    this.$VB$Me.EnableControls_MultiThread();
                    ProjectData.ClearProjectError();
                }
            }

            [CompilerGenerated]
            public void _Lambda$__79()
            {
                if (this.$VB$Me.cbBackupArchives.SelectedItem.ToString().Contains("Device"))
                {
                    this.$VB$Me.RestoreFileName = this.$VB$Me.cbBackupArchives.SelectedItem.ToString().Substring(0, this.$VB$Me.cbBackupArchives.SelectedItem.ToString().Length - 9);
                }
                else if (this.$VB$Me.cbBackupArchives.SelectedItem.ToString().Contains("PC"))
                {
                    this.$VB$Me.RestoreFileName = this.$VB$Me.cbBackupArchives.SelectedItem.ToString().Substring(0, this.$VB$Me.cbBackupArchives.SelectedItem.ToString().Length - 5);
                    this.$VB$Local_copyToDevice = true;
                }
            }

            [CompilerGenerated]
            internal class _Closure$__12
            {
                public PartitionInfo $VB$Local_item;
                public frmEFSProMain._Closure$__11 $VB$NonLocal__Closure$__11;

                public _Closure$__12(frmEFSProMain._Closure$__11._Closure$__12 other)
                {
                    if (other != null)
                    {
                        this.$VB$Local_item = other.$VB$Local_item;
                        this.$VB$NonLocal__Closure$__11 = other.$VB$NonLocal__Closure$__11;
                    }
                }

                [CompilerGenerated]
                public void _Lambda$__80()
                {
                    this.$VB$NonLocal__Closure$__11.$VB$Me.lvBackupContents.Items.Add(this.$VB$Local_item.BlockPath).SubItems.Add(this.$VB$Local_item.FlashFileName);
                }
            }

            [CompilerGenerated]
            internal class _Closure$__13
            {
                public Exception $VB$Local_ex;

                [CompilerGenerated]
                public void _Lambda$__82()
                {
                    Interaction.MsgBox(this.$VB$Local_ex.Message, MsgBoxStyle.Critical, null);
                }
            }
        }

        [CompilerGenerated]
        internal class _Closure$__5
        {
            public frmEFSProMain $VB$Me;

            [DebuggerStepThrough, CompilerGenerated]
            public void _Lambda$__20(object a0)
            {
                new VB$AnonymousDelegate_1(this._Lambda$__21)();
            }

            [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), CompilerGenerated]
            public void _Lambda$__21()
            {
                try
                {
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, false, false);
                    this.$VB$Me.UpdateLogText_MultiThread("Checking application environment...  ", Color.Cyan, false, true, false);
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, true, false);
                    foreach (Process process in Process.GetProcesses())
                    {
                        if ((process.ProcessName == "Kies") | (process.ProcessName == "adb"))
                        {
                            this.$VB$Me.UpdateLogText_MultiThread("Terminating process: " + process.MainModule.ModuleName + ", PID: " + Conversions.ToString(process.Id) + " ...  ", Color.Yellow, false, true, false);
                            process.Kill();
                        }
                    }
                    if (!File.Exists(Application.StartupPath.ToString() + @"\ADB\adb.exe"))
                    {
                        Interaction.MsgBox("ADB executable is missing! Cannot continue!", MsgBoxStyle.Critical, null);
                        ProjectData.EndApp();
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Initializing ADB server...  ", Color.White, false, true, false);
                    this.$VB$Me.myAndroid = new AndroidControl();
                    this.$VB$Me.myAndroid = AndroidControl.Init;
                    if (ADB.IsADBServerRunning)
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                        this.$VB$Me.UpdateLogText_MultiThread("ADB server is running!", Color.Magenta, false, false, true);
                    }
                    else
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("Failed!", Color.Red, false, false, false);
                        Interaction.MsgBox("Failed to start the ADB server! The application will now close.", MsgBoxStyle.Critical, null);
                        if (this.$VB$Me.myAndroid != null)
                        {
                            this.$VB$Me.myAndroid.Dispose();
                        }
                        ProjectData.EndApp();
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Searching for device...  ", Color.White, false, false, false);
                    this.$VB$Me.myAndroid.DisableFastboot = true;
                    if (!this.$VB$Me.myAndroid.HasConnectedDevices && Conversions.ToBoolean(Operators.NotObject(this.$VB$Me.Invoke(new VB$AnonymousDelegate_0<bool>(this.$VB$Me._Lambda$__22)))))
                    {
                        this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(frmEFSProMain._Lambda$__23));
                        this.$VB$Me.UpdateLogText_MultiThread("Failed!", Color.Red, false, true, false);
                        if (this.$VB$Me.myAndroid != null)
                        {
                            this.$VB$Me.myAndroid.Dispose();
                        }
                        ProjectData.EndApp();
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                    this.$VB$Me.UpdateLogText_MultiThread("Connecting to device...  ", Color.White, false, false, false);
                    this.$VB$Me.myDevice = this.$VB$Me.myAndroid.GetConnectedDevice(this.$VB$Me.myAndroid.ConnectedDevices[0]);
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                    this.$VB$Me.UpdateLogText_MultiThread("Checking device status...  ", Color.White, false, false, false);
                    if (this.$VB$Me.myAndroid.GetConnectedDevice().GetState != DeviceIO.DeviceState.ONLINE)
                    {
                        goto Label_037B;
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                    goto Label_03FA;
                Label_035D:
                    this.$VB$Me.Invoke(new Action(this.$VB$Me._Lambda$__24));
                Label_037B:
                    if ((this.$VB$Me.myAndroid.GetConnectedDevice().GetState != DeviceIO.DeviceState.ONLINE) | (this.$VB$Me.myAndroid.GetConnectedDevice().GetState == DeviceIO.DeviceState.RECOVERY))
                    {
                        goto Label_035D;
                    }
                    this.$VB$Me.myDevice = this.$VB$Me.myAndroid.GetConnectedDevice(this.$VB$Me.myAndroid.ConnectedDevices[0]);
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                Label_03FA:
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, false, true);
                    this.$VB$Me.UpdateLogText_MultiThread("Performing device checks...", Color.Cyan, false, false, true);
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, false, false);
                    if (!BuildPropertyParser.GetProperty("ro.product.manufacturer").ToLower().Contains("samsung"))
                    {
                        this.$VB$Me.samsungMode = false;
                        this.$VB$Me.Invoke(new Action(this.$VB$Me._Lambda$__25));
                    }
                    if (this.$VB$Me.myDevice.IsRooted() != DeviceIO.RootAccessType.PermRooted)
                    {
                        Interaction.MsgBox("Your device is NOT Perm Rooted!\r\n\r\nThe application will now exit.", MsgBoxStyle.Critical, "Error!");
                        if (this.$VB$Me.myAndroid != null)
                        {
                            this.$VB$Me.myAndroid.Dispose();
                        }
                        ProjectData.EndApp();
                    }
                    else
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("Root status:  ", Color.White, false, true, false);
                        this.$VB$Me.UpdateLogText_MultiThread("Perm Rooted", Color.Yellow, false, false, false);
                        this.$VB$Me.UpdateLogText_MultiThread("SU binary version:  ", Color.White, false, true, false);
                        this.$VB$Me.UpdateLogText_MultiThread(this.$VB$Me.myDevice.SUBinary.Version, Color.Yellow, false, false, false);
                    }
                    if (!BusyBox.IsInstalled)
                    {
                        Interaction.MsgBox("BusyBox is NOT installed on your device!\r\n\r\nThe application will now exit.", MsgBoxStyle.Critical, "Error!");
                        if (this.$VB$Me.myAndroid != null)
                        {
                            this.$VB$Me.myAndroid.Dispose();
                        }
                        ProjectData.EndApp();
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, true, false);
                    this.$VB$Me.UpdateLogText_MultiThread("BusyBox status:  ", Color.White, false, true, false);
                    this.$VB$Me.UpdateLogText_MultiThread("Installed", Color.Yellow, false, false, false);
                    this.$VB$Me.UpdateLogText_MultiThread("BusyBox version:  ", Color.White, false, true, false);
                    this.$VB$Me.UpdateLogText_MultiThread(BusyBox.Version, Color.Yellow, false, false, false);
                    this.$VB$Me.UpdateLogText_MultiThread("Checking BusyBox applets...  ", Color.White, false, true, false);
                    string[] strArray3 = new string[] { "basename", "dd", "find", "grep", "gunzip", "gzip", "ls", "md5sum", "readlink", "rm", "sed", "tac", "tar", "tr" };
                    for (int i = 0; i < strArray3.Length; i++)
                    {
                        _Closure$__6 e$__;
                        e$__ = new _Closure$__6(e$__) {
                            $VB$Local_applet = strArray3[i]
                        };
                        if (Array.Find<string>(BusyBox.Commands.ToArray(), new Predicate<string>(e$__._Lambda$__26)) != e$__.$VB$Local_applet)
                        {
                            this.$VB$Me.UpdateLogText_MultiThread("Failed!", Color.Red, false, false, false);
                            Interaction.MsgBox("BusyBox applet: '" + e$__.$VB$Local_applet + "' is missing from your binary!\r\n\r\nThe application will now exit.", MsgBoxStyle.Critical, "Error!");
                            if (this.$VB$Me.myAndroid != null)
                            {
                                this.$VB$Me.myAndroid.Dispose();
                            }
                            ProjectData.EndApp();
                        }
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                    if (this.$VB$Me.appDebug == 1)
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, true, false);
                        this.$VB$Me.UpdateLogText_MultiThread("Debug mode active.", Color.Magenta, false, true, false);
                    }
                    else
                    {
                        this.$VB$Me.Invoke(new Action(this.$VB$Me._Lambda$__27));
                    }
                    if (this.$VB$Me.samsungMode)
                    {
                        if (BuildPropertyParser.GetProperty("ro.product.model").ToLower().Contains("nexus"))
                        {
                            this.$VB$Me.efsLocation = "/factory";
                        }
                        else
                        {
                            this.$VB$Me.efsLocation = "/efs";
                        }
                    }
                    this.$VB$Me.Invoke(new Action(this.$VB$Me._Lambda$__28));
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, true, true);
                    this.$VB$Me.UpdateLogText_MultiThread("EFS Professional is ready for use.", Color.Cyan, false, false, true);
                    this.$VB$Me.UpdateLogText_MultiThread("-----------------------------------", Color.Cyan, false, false, false);
                    this.$VB$Me.EnableControls_MultiThread();
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    Interaction.MsgBox("An internal error occurred while trying to interrogate the device!\r\n\r\nIf you are running Android 4.2.2 Jelly Bean or higher, make sure you have allowed your device to communicate with your PC via ADB.", MsgBoxStyle.Critical, null);
                    if (this.$VB$Me.myAndroid != null)
                    {
                        this.$VB$Me.myAndroid.Dispose();
                    }
                    ProjectData.EndApp();
                    ProjectData.ClearProjectError();
                }
            }

            [CompilerGenerated]
            internal class _Closure$__6
            {
                public string $VB$Local_applet;

                public _Closure$__6(frmEFSProMain._Closure$__5._Closure$__6 other)
                {
                    if (other != null)
                    {
                        this.$VB$Local_applet = other.$VB$Local_applet;
                    }
                }

                [CompilerGenerated]
                public bool _Lambda$__26(string s) => 
                    (s == this.$VB$Local_applet);
            }
        }

        [CompilerGenerated]
        internal class _Closure$__7
        {
            public bool $VB$Local_checkAutoSwitch;
            public frmQualcommNVTools $VB$Local_instanceQCNVTools;
            public int $VB$Local_prevIndex;
            public frmEFSProMain $VB$Me;

            [DebuggerStepThrough, CompilerGenerated]
            public void _Lambda$__31(object a0)
            {
                new VB$AnonymousDelegate_1(this._Lambda$__32)();
            }

            [CompilerGenerated]
            public void _Lambda$__32()
            {
                this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(this.$VB$Me._Lambda$__33));
                string str = string.Empty;
                if (this.$VB$Local_checkAutoSwitch && (this.$VB$Local_prevIndex != 2))
                {
                    this.$VB$Me.UpdateLogText_MultiThread("Checking device connection...  ", Color.White, false, false, false);
                    if (!this.$VB$Me.myAndroid.HasConnectedDevices)
                    {
                        Interaction.MsgBox("Device is not connected! Please connect the USB cable and try again!", MsgBoxStyle.Critical, null);
                        this.$VB$Me.UpdateLogText_MultiThread("Device is not connected!", Color.Red, false, false, false);
                        this.$VB$Me.EnableControls_MultiThread();
                        return;
                    }
                    this.$VB$Me.UpdateLogText_MultiThread("Device is connected!", Color.Lime, false, false, true);
                    Thread.Sleep(250);
                    this.$VB$Me.UpdateLogText_MultiThread("Switching to Diag Mode...  ", Color.White, false, false, false);
                    this.$VB$Me.ChangeUSBMode_MultiThread(2);
                    str = this.$VB$Me.WriteUSBSettings_MultiThread();
                    ADB.IssueADBCmdNoOutput(ADB.CreateADBShellCmd(this.$VB$Me.myDevice, true, "setprop", new string[] { "sys.usb.config", str }));
                    this.$VB$Me.Invoke(new Action(this.$VB$Me._Lambda$__34));
                    this.$VB$Me.myDevice = this.$VB$Me.myAndroid.GetConnectedDevice(this.$VB$Me.myAndroid.ConnectedDevices[0]);
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, true);
                    Thread.Sleep(0x7d0);
                }
                this.$VB$Me.UpdateLogText_MultiThread("Opened Qualcomm NV Tools...", Color.Yellow, false, false, true);
                this.$VB$Me.Invoke(new Action(this._Lambda$__35));
                this.$VB$Me.UpdateLogText_MultiThread("Closed Qualcomm NV Tools...", Color.Yellow, false, false, false);
                if (this.$VB$Local_checkAutoSwitch && (this.$VB$Local_prevIndex != 2))
                {
                    Thread.Sleep(0x7d0);
                    this.$VB$Me.UpdateLogText_MultiThread("Restoring previous USB settings...  ", Color.White, false, true, false);
                    this.$VB$Me.ChangeUSBMode_MultiThread(this.$VB$Local_prevIndex);
                    str = this.$VB$Me.WriteUSBSettings_MultiThread();
                    ADB.IssueADBCmdNoOutput(ADB.CreateADBShellCmd(this.$VB$Me.myDevice, true, "setprop", new string[] { "sys.usb.config", str }));
                    this.$VB$Me.Invoke(new Action(this.$VB$Me._Lambda$__36));
                    this.$VB$Me.myDevice = this.$VB$Me.myAndroid.GetConnectedDevice(this.$VB$Me.myAndroid.ConnectedDevices[0]);
                    this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                }
                this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(this.$VB$Me._Lambda$__37));
                this.$VB$Me.EnableControls_MultiThread();
            }

            [CompilerGenerated]
            public void _Lambda$__35()
            {
                this.$VB$Local_instanceQCNVTools = new frmQualcommNVTools();
                this.$VB$Local_instanceQCNVTools.ShowDialog();
                this.$VB$Local_instanceQCNVTools.Dispose();
            }
        }

        [CompilerGenerated]
        internal class _Closure$__8
        {
            public Regex $VB$Local_deviceFilter;
            public string $VB$Local_devicePIT;
            public frmEFSProMain $VB$Me;

            [DebuggerStepThrough, CompilerGenerated]
            public void _Lambda$__72(object a0)
            {
                new VB$AnonymousDelegate_1(this._Lambda$__73)();
            }

            [CompilerGenerated]
            public void _Lambda$__73()
            {
                try
                {
                    this.$VB$Me.UpdateLogText_MultiThread("Enumerating device partitions...  ", Color.DodgerBlue, false, false, false);
                    if (this.$VB$Me.samsungMode)
                    {
                        this.$VB$Me.UpdateLogText_MultiThread("Extracting PIT from device for mapping...  ", Color.White, false, true, false);
                        if (File.Exists(this.$VB$Local_devicePIT))
                        {
                            this.$VB$Me.UpdateLogText_MultiThread("Skipped, already exists.", Color.Yellow, false, false, false);
                        }
                        else
                        {
                            if (!Directory.Exists(this.$VB$Me.AppPath + @"\PIT"))
                            {
                                Directory.CreateDirectory(this.$VB$Me.AppPath + @"\PIT");
                            }
                            if (!EFS_Professional.WinADBHelper.FileSystem.GetDevicePIT(this.$VB$Me.AppPath + @"\PIT", ref this.$VB$Local_devicePIT, this.$VB$Me.devStorageLoc, this.$VB$Me.pitBufferSize))
                            {
                                throw new Exception("Unable to extract PIT from device!");
                            }
                            this.$VB$Local_devicePIT = this.$VB$Local_devicePIT.Insert(0, this.$VB$Me.AppPath + @"\PIT\");
                            this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                        }
                        this.$VB$Me.UpdateLogText_MultiThread("Checking PIT file integrity...  ", Color.White, false, true, false);
                        if (EFS_Professional.WinADBHelper.FileSystem.ParsePIT(this.$VB$Local_devicePIT) == null)
                        {
                            throw new Exception("The PIT file is corrupt or invalid!");
                        }
                        this.$VB$Me.UpdateLogText_MultiThread("Okay.", Color.Lime, false, false, false);
                        this.$VB$Me.devicePartitions = EFS_Professional.WinADBHelper.FileSystem.GetSamsungPartitions(this.$VB$Local_devicePIT);
                    }
                    else
                    {
                        this.$VB$Me.devicePartitions = EFS_Professional.WinADBHelper.FileSystem.GetPartitions();
                    }
                    using (List<PartitionInfo>.Enumerator enumerator = this.$VB$Me.devicePartitions.GetEnumerator())
                    {
                        while (enumerator.MoveNext())
                        {
                            _Closure$__9 e$__;
                            e$__ = new _Closure$__9(e$__) {
                                $VB$Local_partItem = enumerator.Current,
                                $VB$NonLocal__Closure$__8 = this
                            };
                            if (this.$VB$Local_deviceFilter.IsMatch(e$__.$VB$Local_partItem.PartitionName))
                            {
                                this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(e$__._Lambda$__74));
                            }
                        }
                    }
                    this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(this.$VB$Me._Lambda$__75));
                    this.$VB$Me.UpdateLogText_MultiThread("Finished enumerating device partitions!", Color.DodgerBlue, false, true, false);
                    this.$VB$Me.EnableControls_MultiThread();
                }
                catch (Exception exception1)
                {
                    ProjectData.SetProjectError(exception1);
                    Exception exception = exception1;
                    _Closure$__10 e$__2 = new _Closure$__10 {
                        $VB$Local_ex = exception
                    };
                    this.$VB$Me.UpdateLogText_MultiThread("Operation Failed!", Color.Red, false, true, false);
                    this.$VB$Me.Invoke(new VB$AnonymousDelegate_1(e$__2._Lambda$__76));
                    this.$VB$Me.EnableControls_MultiThread();
                    ProjectData.ClearProjectError();
                }
            }

            [CompilerGenerated]
            internal class _Closure$__10
            {
                public Exception $VB$Local_ex;

                [CompilerGenerated]
                public void _Lambda$__76()
                {
                    Interaction.MsgBox(this.$VB$Local_ex.Message, MsgBoxStyle.Critical, null);
                }
            }

            [CompilerGenerated]
            internal class _Closure$__9
            {
                public PartitionInfo $VB$Local_partItem;
                public frmEFSProMain._Closure$__8 $VB$NonLocal__Closure$__8;

                public _Closure$__9(frmEFSProMain._Closure$__8._Closure$__9 other)
                {
                    if (other != null)
                    {
                        this.$VB$Local_partItem = other.$VB$Local_partItem;
                        this.$VB$NonLocal__Closure$__8 = other.$VB$NonLocal__Closure$__8;
                    }
                }

                [CompilerGenerated]
                public void _Lambda$__74()
                {
                    this.$VB$NonLocal__Closure$__8.$VB$Me.lvPartitions.Items.Add(this.$VB$Local_partItem.BlockPath).SubItems.Add(this.$VB$Local_partItem.PartitionName);
                }
            }
        }

        public delegate void ChangeUSBMode_Delegate(int index);

        public delegate void ClearLog_Delegate();

        public enum CounterResetType
        {
            BatteryCableCounter,
            SPenCounter,
            EarphoneJackCounter
        }

        public delegate void DisableControls_Delegate();

        public delegate void EnableControls_Delegate();

        public delegate List<PartitionInfo> GetSelectedPartitions_Delegate(frmEFSProMain.SelectedPartitionsMode mode);

        public enum PhoneUtilityType
        {
            Preconfig,
            PhoneUtil,
            PhoneUtilQCUSBSettings,
            PhoneUtilNewDev,
            USBSettingsNewDev,
            FactoryModeDialerTab,
            IOTHiddenMenu,
            UltraCfgUSBSettings,
            EnableHiddenMenu,
            DisableHiddenMenu
        }

        public delegate void ReadUSBSettings_Delegate(string inputStr);

        public delegate bool ScanForBackups_Delegate(string commandInput);

        public enum SelectedPartitionsMode
        {
            Backup,
            Restore
        }

        public delegate void UpdateLogText_Delegate(string LogText, Color LogTextColour, bool Aligned, bool NewLineBefore, bool NewLineAfter);

        public delegate string WriteUSBSettings_Delegate();
    }
}


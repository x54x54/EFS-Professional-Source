namespace EFS_Professional
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    [DesignerGenerated]
    public class frmPIT_Magic_Main : Form
    {
        [AccessedThroughProperty("btnCopyClipboard")]
        private Button _btnCopyClipboard;
        [AccessedThroughProperty("btnCreatePITEntry")]
        private Button _btnCreatePITEntry;
        [AccessedThroughProperty("btnDonate")]
        private Button _btnDonate;
        [AccessedThroughProperty("btnExport")]
        private Button _btnExport;
        [AccessedThroughProperty("btnNew")]
        private Button _btnNew;
        [AccessedThroughProperty("btnOpen")]
        private Button _btnOpen;
        [AccessedThroughProperty("btnOpenPITFile")]
        private Button _btnOpenPITFile;
        [AccessedThroughProperty("btnRemPITEntry")]
        private Button _btnRemPITEntry;
        [AccessedThroughProperty("btnResetForm")]
        private Button _btnResetForm;
        [AccessedThroughProperty("btnSave")]
        private Button _btnSave;
        [AccessedThroughProperty("btnSaveAs")]
        private Button _btnSaveAs;
        [AccessedThroughProperty("cbPITEntries")]
        private ComboBox _cbPITEntries;
        [AccessedThroughProperty("gbCurrentPITEntry")]
        private GroupBox _gbCurrentPITEntry;
        [AccessedThroughProperty("gbHdrSize")]
        private GroupBox _gbHdrSize;
        [AccessedThroughProperty("gbPITFileHdrInfo")]
        private GroupBox _gbPITFileHdrInfo;
        [AccessedThroughProperty("gbPITOps")]
        private GroupBox _gbPITOps;
        [AccessedThroughProperty("lblAPVendor")]
        private Label _lblAPVendor;
        [AccessedThroughProperty("lblAttribStatus")]
        private Label _lblAttribStatus;
        [AccessedThroughProperty("lblBinTypeStatus")]
        private Label _lblBinTypeStatus;
        [AccessedThroughProperty("lblBlockCount")]
        private Label _lblBlockCount;
        [AccessedThroughProperty("lblBlockSize")]
        private Label _lblBlockSize;
        [AccessedThroughProperty("lblDeviceType")]
        private Label _lblDeviceType;
        [AccessedThroughProperty("lblDevTypeStatus")]
        private Label _lblDevTypeStatus;
        [AccessedThroughProperty("lblDummyDataTypeMsg")]
        private Label _lblDummyDataTypeMsg;
        [AccessedThroughProperty("lblFileOffset")]
        private Label _lblFileOffset;
        [AccessedThroughProperty("lblFileSize")]
        private Label _lblFileSize;
        [AccessedThroughProperty("lblFileSystemType")]
        private Label _lblFileSystemType;
        [AccessedThroughProperty("lblFlashFileName")]
        private Label _lblFlashFileName;
        [AccessedThroughProperty("lblFotaFileName")]
        private Label _lblFotaFileName;
        [AccessedThroughProperty("lblHdrMagic")]
        private Label _lblHdrMagic;
        [AccessedThroughProperty("lblHdrMagicType")]
        private Label _lblHdrMagicType;
        [AccessedThroughProperty("lblHdrSizeType")]
        private Label _lblHdrSizeType;
        [AccessedThroughProperty("lblImageType")]
        private Label _lblImageType;
        [AccessedThroughProperty("lblPartitionID")]
        private Label _lblPartitionID;
        [AccessedThroughProperty("lblPartitionType")]
        private Label _lblPartitionType;
        [AccessedThroughProperty("lblPartName")]
        private Label _lblPartName;
        [AccessedThroughProperty("lblPITEntryCnt")]
        private Label _lblPITEntryCnt;
        [AccessedThroughProperty("lblPITEntryCntType")]
        private Label _lblPITEntryCntType;
        [AccessedThroughProperty("lblPITEntryList")]
        private Label _lblPITEntryList;
        [AccessedThroughProperty("lblPITFile")]
        private Label _lblPITFile;
        [AccessedThroughProperty("lblProjectName")]
        private Label _lblProjectName;
        [AccessedThroughProperty("lblReserved")]
        private Label _lblReserved;
        [AccessedThroughProperty("lblUpdAttrStatus")]
        private Label _lblUpdAttrStatus;
        [AccessedThroughProperty("lblVersionInfo")]
        private Label _lblVersionInfo;
        [AccessedThroughProperty("numBlockCount")]
        private NumericUpDown _numBlockCount;
        [AccessedThroughProperty("numBlockSize")]
        private NumericUpDown _numBlockSize;
        [AccessedThroughProperty("numDeviceType")]
        private NumericUpDown _numDeviceType;
        [AccessedThroughProperty("numFileOffset")]
        private NumericUpDown _numFileOffset;
        [AccessedThroughProperty("numFileSize")]
        private NumericUpDown _numFileSize;
        [AccessedThroughProperty("numFileSystemType")]
        private NumericUpDown _numFileSystemType;
        [AccessedThroughProperty("numImageType")]
        private NumericUpDown _numImageType;
        [AccessedThroughProperty("numPartitionID")]
        private NumericUpDown _numPartitionID;
        [AccessedThroughProperty("numPartitionType")]
        private NumericUpDown _numPartitionType;
        [AccessedThroughProperty("ofdPIT")]
        private OpenFileDialog _ofdPIT;
        [AccessedThroughProperty("rtAnalysisOutput")]
        private RichTextBox _rtAnalysisOutput;
        [AccessedThroughProperty("sfdPIT")]
        private SaveFileDialog _sfdPIT;
        [AccessedThroughProperty("tabPITFileAnalysis")]
        private TabPage _tabPITFileAnalysis;
        [AccessedThroughProperty("tabPITFileEditor")]
        private TabPage _tabPITFileEditor;
        [AccessedThroughProperty("tcPITLayout")]
        private TabControl _tcPITLayout;
        [AccessedThroughProperty("TimerIn")]
        private Timer _TimerIn;
        [AccessedThroughProperty("TimerOut")]
        private Timer _TimerOut;
        [AccessedThroughProperty("txtAPVendor")]
        private TextBox _txtAPVendor;
        [AccessedThroughProperty("txtFlashFileName")]
        private TextBox _txtFlashFileName;
        [AccessedThroughProperty("txtFotaFileName")]
        private TextBox _txtFotaFileName;
        [AccessedThroughProperty("txtHdrMagic")]
        private TextBox _txtHdrMagic;
        [AccessedThroughProperty("txtHdrSize")]
        private TextBox _txtHdrSize;
        [AccessedThroughProperty("txtPartName")]
        private TextBox _txtPartName;
        [AccessedThroughProperty("txtPITEntryCnt")]
        private TextBox _txtPITEntryCnt;
        [AccessedThroughProperty("txtPITFile")]
        private TextBox _txtPITFile;
        [AccessedThroughProperty("txtProjectName")]
        private TextBox _txtProjectName;
        [AccessedThroughProperty("txtReserved")]
        private TextBox _txtReserved;
        private string AppPath;
        private IContainer components;
        private PitData myPitData;
        private PitEntry myPitEntry;
        private PitInputStream myPitInputStream;
        private PitOutputStream myPitOutputStream;
        private int newFileCounter;
        private PitData originalPitData;

        public frmPIT_Magic_Main()
        {
            base.Load += new EventHandler(this.PIT_Magic_Main_Load);
            this.AppPath = Application.StartupPath.ToString();
            this.newFileCounter = 1;
            this.InitializeComponent();
            this.lblVersionInfo.Text = "PIT Magic v" + VersionInfo.GetAppVersion() + " \x00a9 Gaz 2014.";
            this.sfdPIT.FileName = $"NewPitFile{this.newFileCounter:00}.pit";
            this.txtPITFile.Text = this.sfdPIT.FileName;
            this.ofdPIT.FileName = this.sfdPIT.FileName;
            this.newFileCounter++;
            this.txtHdrMagic.Text = $"0x{0x12349876.ToString("X")}";
            this.txtHdrSize.Text = Conversions.ToString(0x1c);
            this.txtPITEntryCnt.Text = "0";
            this.originalPitData = new PitData();
            this.myPitData = new PitData();
            this.myPitEntry = null;
            this.originalPitData = PitData.Clone(this.myPitData);
            this.btnSave.Enabled = false;
            this.btnExport.Enabled = false;
            this.btnCopyClipboard.Enabled = false;
        }

        private void btnCopyClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            this.rtAnalysisOutput.SelectAll();
            this.rtAnalysisOutput.Copy();
            Interaction.MsgBox("PIT Analysis was copied to clipboard successfully.", MsgBoxStyle.Information, null);
        }

        private void btnCreatePITEntry_Click(object sender, EventArgs e)
        {
            if (this.myPitData == null)
            {
                this.myPitData = new PitData();
                this.myPitEntry = new PitEntry();
                this.myPitEntry.PartitionName = "PIT_ENTRY";
                this.myPitData.AddEntry(this.myPitEntry);
            }
            else
            {
                this.myPitEntry = new PitEntry();
                this.myPitEntry.PartitionName = "PIT_ENTRY";
                this.myPitData.AddEntry(this.myPitEntry);
            }
            this.cbPITEntries.Items.Clear();
            int num = 0;
            foreach (PitEntry entry in this.myPitData.Entries)
            {
                this.cbPITEntries.Items.Add($"Entry #{num:00}: {string.IsNullOrEmpty(entry.EntryMemAddr) ? "New PIT Entry" : entry.EntryMemAddr:D}
");
                num++;
            }
            this.cbPITEntries.SelectedIndex = this.cbPITEntries.Items.Count - 1;
            this.txtPITEntryCnt.Text = Conversions.ToString(this.myPitData.EntryCount);
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            this.ShowDonateDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                int num = 1;
                string format = this.AppPath + @"\PIT_Analysis_{0:000}.txt";
                string path = string.Empty;
                path = string.Format(format, num);
                while (File.Exists(path))
                {
                    num++;
                    path = string.Format(format, num);
                }
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (string str3 in this.rtAnalysisOutput.Lines)
                    {
                        writer.WriteLine(str3);
                    }
                    writer.WriteLine();
                    writer.Write("Generated on: " + Conversions.ToString(DateTime.Now));
                }
                Interaction.MsgBox(path + "\r\n\r\nFile saved successfully.", MsgBoxStyle.Information, null);
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An error occurred while saving the 'PIT Analysis' file to disk.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (this.CheckPITChanged() == CheckPITStatus.PIT_Changed)
            {
                switch (Interaction.MsgBox(Path.GetFileName(this.ofdPIT.FileName) + " has been modified. Do you want to save changes?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
                {
                    case MsgBoxResult.Yes:
                        this.SavePITChanges();
                        break;

                    case MsgBoxResult.Cancel:
                        return;
                }
            }
            else if (this.CheckPITChanged() == CheckPITStatus.PIT_NewFile)
            {
                switch (Interaction.MsgBox(this.txtPITFile.Text + " has been modified. Do you want to save new file?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, null))
                {
                    case MsgBoxResult.Yes:
                        this.SaveNewPITFile(null);
                        break;

                    case MsgBoxResult.Cancel:
                        return;
                }
            }
            this.ClearAll();
            this.cbPITEntries.Items.Clear();
            this.originalPitData = new PitData();
            this.myPitData = new PitData();
            this.myPitEntry = null;
            this.sfdPIT.FileName = $"NewPitFile{this.newFileCounter:00}.pit";
            this.txtPITFile.Text = this.sfdPIT.FileName;
            this.ofdPIT.FileName = this.sfdPIT.FileName;
            this.txtHdrMagic.Text = $"0x{0x12349876.ToString("X")}";
            this.txtHdrSize.Text = Conversions.ToString(0x1c);
            this.txtPITEntryCnt.Text = "0";
            this.newFileCounter++;
            this.txtPITEntryCnt.Text = Conversions.ToString(this.myPitData.EntryCount);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = this.ofdPIT.FileName;
            if (this.CheckPITChanged() == CheckPITStatus.PIT_Changed)
            {
                switch (Interaction.MsgBox(Path.GetFileName(this.ofdPIT.FileName) + " has been modified. Do you want to save changes?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
                {
                    case MsgBoxResult.Yes:
                        this.SavePITChanges();
                        break;

                    case MsgBoxResult.Cancel:
                        return;
                }
            }
            else if (this.CheckPITChanged() == CheckPITStatus.PIT_NewFile)
            {
                switch (Interaction.MsgBox(this.txtPITFile.Text + " has been modified. Do you want to save new file?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, null))
                {
                    case MsgBoxResult.Yes:
                        this.SaveNewPITFile(null);
                        break;

                    case MsgBoxResult.Cancel:
                        return;
                }
            }
            string text = this.txtPITFile.Text;
            try
            {
                this.ofdPIT.FileName = string.Empty;
                this.ofdPIT.InitialDirectory = this.AppPath;
                if (this.ofdPIT.ShowDialog() == DialogResult.Cancel)
                {
                    this.ofdPIT.FileName = fileName;
                }
                else
                {
                    FileStream byteStream = new FileStream(this.ofdPIT.FileName, FileMode.Open, FileAccess.Read);
                    this.txtPITFile.Text = Path.GetFileName(this.ofdPIT.FileName);
                    this.myPitInputStream = new PitInputStream(byteStream);
                    this.myPitData = new PitData();
                    if (this.myPitData.ReadPITFile(this.myPitInputStream))
                    {
                        this.txtAPVendor.Text = this.myPitData.APVendor;
                        this.txtProjectName.Text = this.myPitData.ProjectName;
                        this.txtReserved.Text = Conversions.ToString(this.myPitData.Reserved);
                        this.originalPitData = new PitData();
                        this.originalPitData = PitData.Clone(this.myPitData);
                        this.cbPITEntries.Items.Clear();
                        this.txtPITEntryCnt.Text = Conversions.ToString(this.myPitData.EntryCount);
                        int num = 0;
                        foreach (PitEntry entry in this.myPitData.Entries)
                        {
                            this.cbPITEntries.Items.Add($"Entry #{num:000}: {entry.EntryMemAddr}
");
                            num++;
                        }
                        if (this.cbPITEntries.Items.Count > 0)
                        {
                            this.cbPITEntries.SelectedIndex = 0;
                        }
                    }
                    byteStream.Close();
                    this.btnSave.Enabled = true;
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                this.txtPITFile.Text = text;
                Interaction.MsgBox("An error occurred while opening the requested file.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void btnOpenPITFile_Click(object sender, EventArgs e)
        {
            string fileName = this.ofdPIT.FileName;
            try
            {
                this.ofdPIT.FileName = string.Empty;
                this.ofdPIT.InitialDirectory = this.AppPath;
                if (this.ofdPIT.ShowDialog() != DialogResult.Cancel)
                {
                    FileStream byteStream = new FileStream(this.ofdPIT.FileName, FileMode.Open, FileAccess.Read);
                    PitInputStream inputStream = new PitInputStream(byteStream);
                    PitData data = new PitData();
                    if (data.ReadPITFile(inputStream))
                    {
                        this.rtAnalysisOutput.Clear();
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("PIT Magic v" + VersionInfo.GetAppVersion() + " Copyright \x00a9 Gaz 2014." + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("Analysis for: " + Path.GetFileName(this.ofdPIT.FileName) + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("<<< Pit File Start >>>" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("<<< PIT File Header Information >>>" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText($"Header Magic: 0x{0x12349876:X}     (4 Bytes)
");
                        this.rtAnalysisOutput.AppendText($"Entry Count:  {data.EntryCount:D}             (4 Bytes)

");
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("AP Vendor (String Value, 8 Bytes):" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("String:       " + data.APVendor);
                        this.rtAnalysisOutput.AppendText(Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("Project Name (String Value, 8 Bytes):" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("String:       " + data.ProjectName);
                        this.rtAnalysisOutput.AppendText(Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("Reserved (Integer Value, 4 Bytes):" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("Integer:      " + Conversions.ToString(data.Reserved));
                        this.rtAnalysisOutput.AppendText(Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("8 Bytes + 8 Bytes + 4 Bytes / 20 Bytes Total." + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("Total Header Size: (" + Conversions.ToString(0x1c) + " Bytes)" + Environment.NewLine + Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("<<< PIT File Entries >>>" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        foreach (PitEntry entry in data.Entries)
                        {
                            string str2;
                            string str3;
                            string str4;
                            string str5;
                            this.rtAnalysisOutput.AppendText(Environment.NewLine + Environment.NewLine);
                            this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                            this.rtAnalysisOutput.AppendText($"Entry Memory Address: {entry.EntryMemAddr:D}
");
                            this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                            this.rtAnalysisOutput.AppendText(Environment.NewLine);
                            Array names = Enum.GetNames(typeof(PitEntry.EntryImageType));
                            Array values = Enum.GetValues(typeof(PitEntry.EntryImageType));
                            if (Conversions.ToBoolean(Operators.AndObject(entry.ImageType, NewLateBinding.LateIndexGet(values, new object[] { entry.ImageType }, null))))
                            {
                                str4 = "(" + NewLateBinding.LateIndexGet(names, new object[] { entry.ImageType }, null).ToString() + ")";
                            }
                            else
                            {
                                str4 = "(Unknown)";
                            }
                            this.rtAnalysisOutput.AppendText("Image Type: " + string.Format("                {0} {1,20}\n", (int) entry.ImageType, str4));
                            names = Enum.GetNames(typeof(PitEntry.EntryDeviceType));
                            values = Enum.GetValues(typeof(PitEntry.EntryDeviceType));
                            if (Conversions.ToBoolean(Operators.AndObject(entry.DeviceType, NewLateBinding.LateIndexGet(values, new object[] { entry.DeviceType }, null))))
                            {
                                str2 = "(" + NewLateBinding.LateIndexGet(names, new object[] { entry.DeviceType }, null).ToString() + ")";
                            }
                            else
                            {
                                str2 = "(Unknown)";
                            }
                            this.rtAnalysisOutput.AppendText("Device Type: " + string.Format("               {0} {1,20}\n", (int) entry.DeviceType, str2));
                            this.rtAnalysisOutput.AppendText("Partition ID: " + $"              {entry.PartitionID:D}
");
                            names = Enum.GetNames(typeof(PitEntry.EntryPartitionType));
                            values = Enum.GetValues(typeof(PitEntry.EntryPartitionType));
                            if (Conversions.ToBoolean(Operators.AndObject(entry.PartitionType, NewLateBinding.LateIndexGet(values, new object[] { entry.PartitionType }, null))))
                            {
                                str5 = "(" + NewLateBinding.LateIndexGet(names, new object[] { entry.PartitionType }, null).ToString() + ")";
                            }
                            else
                            {
                                str5 = "(Unknown)";
                            }
                            this.rtAnalysisOutput.AppendText("Partition Type: " + string.Format("            {0} {1,20}\n", (int) entry.PartitionType, str5));
                            names = Enum.GetNames(typeof(PitEntry.EntryFileSystemType));
                            values = Enum.GetValues(typeof(PitEntry.EntryFileSystemType));
                            if (Conversions.ToBoolean(Operators.AndObject(entry.FileSystemType, NewLateBinding.LateIndexGet(values, new object[] { entry.FileSystemType }, null))))
                            {
                                str3 = "(" + NewLateBinding.LateIndexGet(names, new object[] { entry.FileSystemType }, null).ToString() + ")";
                            }
                            else
                            {
                                str3 = "(Unknown)";
                            }
                            this.rtAnalysisOutput.AppendText("File System Type: " + string.Format("          {0} {1,20}\n", (int) entry.FileSystemType, str3));
                            this.rtAnalysisOutput.AppendText("Block Count (KB): " + $"          {entry.BlockCount:N0}
");
                            this.rtAnalysisOutput.AppendText("Block Size (KB): " + $"           {entry.BlockSize:N0}
");
                            this.rtAnalysisOutput.AppendText("File Offset (In TAR): " + $"      {entry.FileOffset:N0}
");
                            this.rtAnalysisOutput.AppendText("File Size: " + $"                 {entry.FileSize:N0}
");
                            this.rtAnalysisOutput.AppendText("Partition Name: " + $"            {RuntimeHelpers.GetObjectValue(Interaction.IIf(string.IsNullOrEmpty(entry.PartitionName), entry.PartitionName, string.Empty))}
");
                            this.rtAnalysisOutput.AppendText("Flash FileName: " + $"            {RuntimeHelpers.GetObjectValue(Interaction.IIf(string.IsNullOrEmpty(entry.PartitionName), entry.FlashFileName, string.Empty))}
");
                            this.rtAnalysisOutput.AppendText("FOTA FileName: " + $"             {RuntimeHelpers.GetObjectValue(Interaction.IIf(string.IsNullOrEmpty(entry.PartitionName), entry.FOTAFileName, string.Empty))}
");
                        }
                        this.rtAnalysisOutput.AppendText(Environment.NewLine + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("<<< Pit File End >>>" + Environment.NewLine);
                        this.rtAnalysisOutput.AppendText("----------------------------------------------------------");
                    }
                    this.btnExport.Enabled = true;
                    this.btnCopyClipboard.Enabled = true;
                    this.ofdPIT.FileName = fileName;
                    byteStream.Close();
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An error occurred while opening the requested file.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void btnRemPITEntry_Click(object sender, EventArgs e)
        {
            if (this.cbPITEntries.Items.Count > 0)
            {
                if (Interaction.MsgBox("Remove Selected PIT Entry?\r\n\r\n" + this.cbPITEntries.SelectedItem.ToString(), MsgBoxStyle.Question | MsgBoxStyle.OkCancel, null) == MsgBoxResult.Ok)
                {
                    string text = this.txtPITFile.Text;
                    this.myPitData.RemoveEntry(this.myPitEntry.Index);
                    if (this.cbPITEntries.SelectedIndex >= 0)
                    {
                        this.cbPITEntries.Items.RemoveAt(this.cbPITEntries.SelectedIndex);
                    }
                    this.cbPITEntries.Items.Clear();
                    int num2 = this.myPitEntry.Index - 1;
                    int num = 0;
                    foreach (PitEntry entry in this.myPitData.Entries)
                    {
                        this.cbPITEntries.Items.Add($"Entry #{num:00}: {string.IsNullOrEmpty(entry.EntryMemAddr) ? "New PIT Entry" : entry.EntryMemAddr:D}
");
                        num++;
                    }
                    if (this.myPitData.EntryCount > 0)
                    {
                        this.cbPITEntries.SelectedIndex = (num2 < 0) ? 0 : num2;
                        this.txtPITEntryCnt.Text = Conversions.ToString(this.myPitData.EntryCount);
                    }
                    else
                    {
                        this.ClearAll();
                        this.txtPITFile.Text = text;
                        this.txtHdrMagic.Text = $"0x{0x12349876.ToString("X")}";
                        this.txtPITEntryCnt.Text = Conversions.ToString(this.myPitData.EntryCount);
                        this.txtHdrSize.Text = Conversions.ToString(0x1c);
                        this.txtAPVendor.Text = this.myPitData.APVendor;
                        this.txtProjectName.Text = this.myPitData.ProjectName;
                        this.txtReserved.Text = Conversions.ToString(this.myPitData.Reserved);
                    }
                }
            }
            else
            {
                Interaction.MsgBox("Nothing to remove! PIT Entry list is empty!", MsgBoxStyle.Information, null);
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            string text = this.txtPITFile.Text;
            if (this.originalPitData != null)
            {
                this.ClearAll();
                this.txtPITFile.Text = text;
                int num = 0x12349876;
                this.txtHdrMagic.Text = $"0x{num.ToString("X")}";
                this.txtPITEntryCnt.Text = Conversions.ToString(this.myPitData.EntryCount);
                this.txtHdrSize.Text = Conversions.ToString(0x1c);
                this.txtAPVendor.Text = this.myPitData.APVendor;
                this.txtProjectName.Text = this.myPitData.ProjectName;
            }
            else
            {
                this.txtPITFile.Text = text;
                this.txtHdrMagic.Text = $"0x{0x12349876.ToString("X")}";
                this.txtPITEntryCnt.Text = "0";
                this.txtHdrSize.Text = Conversions.ToString(0x1c);
            }
            if (this.cbPITEntries.Items.Count > 0)
            {
                this.cbPITEntries.SelectedIndex = 0;
            }
            this.UpdatePITHeader();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SavePITChanges();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            this.SaveNewPITFile(null);
        }

        private void cbDumDisplayType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.myPitData != null)
            {
                if (!string.IsNullOrEmpty(this.myPitData.APVendor))
                {
                    this.txtAPVendor.Text = this.myPitData.APVendor;
                }
                if (!string.IsNullOrEmpty(this.myPitData.ProjectName))
                {
                    this.txtProjectName.Text = this.myPitData.ProjectName;
                }
                this.txtReserved.Text = Conversions.ToString(this.myPitData.Reserved);
            }
        }

        private void cbPITEntries_Click(object sender, EventArgs e)
        {
            if (this.cbPITEntries.Items.Count > 0)
            {
                this.UpdatePIT();
            }
        }

        private void cbPITEntries_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.cbPITEntries.SelectedIndex != -1)
                {
                    this.myPitEntry = this.myPitData.GetEntry(this.cbPITEntries.SelectedIndex);
                    this.numImageType.Value = new decimal((int) this.myPitEntry.ImageType);
                    Array names = Enum.GetNames(typeof(PitEntry.EntryImageType));
                    if (Enum.IsDefined(typeof(PitEntry.EntryImageType), this.myPitEntry.ImageType))
                    {
                        this.lblBinTypeStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.myPitEntry.ImageType }, null).ToString();
                    }
                    else
                    {
                        this.lblBinTypeStatus.Text = "Unknown";
                    }
                    this.numDeviceType.Value = new decimal((int) this.myPitEntry.DeviceType);
                    names = Enum.GetNames(typeof(PitEntry.EntryDeviceType));
                    if (Enum.IsDefined(typeof(PitEntry.EntryDeviceType), this.myPitEntry.DeviceType))
                    {
                        this.lblDevTypeStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.myPitEntry.DeviceType }, null).ToString();
                    }
                    else
                    {
                        this.lblDevTypeStatus.Text = "Unknown";
                    }
                    this.numPartitionID.Value = new decimal(this.myPitEntry.PartitionID);
                    this.numPartitionType.Value = new decimal((int) this.myPitEntry.PartitionType);
                    names = Enum.GetNames(typeof(PitEntry.EntryPartitionType));
                    if (Enum.IsDefined(typeof(PitEntry.EntryPartitionType), this.myPitEntry.PartitionType))
                    {
                        this.lblAttribStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.myPitEntry.PartitionType }, null).ToString();
                    }
                    else
                    {
                        this.lblAttribStatus.Text = "Unknown";
                    }
                    this.numFileSystemType.Value = new decimal((int) this.myPitEntry.FileSystemType);
                    names = Enum.GetNames(typeof(PitEntry.EntryFileSystemType));
                    if (Enum.IsDefined(typeof(PitEntry.EntryFileSystemType), this.myPitEntry.FileSystemType))
                    {
                        this.lblUpdAttrStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.myPitEntry.FileSystemType }, null).ToString();
                    }
                    else
                    {
                        this.lblUpdAttrStatus.Text = "Unknown";
                    }
                    this.numBlockCount.Value = new decimal(this.myPitEntry.BlockCount);
                    this.numBlockSize.Value = new decimal(this.myPitEntry.BlockSize);
                    this.numFileOffset.Value = new decimal(this.myPitEntry.FileOffset);
                    this.numFileSize.Value = new decimal(this.myPitEntry.FileSize);
                    this.txtPartName.Text = this.myPitEntry.PartitionName;
                    this.txtFlashFileName.Text = this.myPitEntry.FlashFileName;
                    this.txtFotaFileName.Text = this.myPitEntry.FOTAFileName;
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An indexing error occurred while selecting PIT Entry!", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private CheckPITStatus CheckPITChanged()
        {
            if ((this.myPitData != null) & (this.originalPitData != null))
            {
                if (this.myPitData.Matches(this.originalPitData))
                {
                    return CheckPITStatus.PIT_Unchanged;
                }
                return CheckPITStatus.PIT_Changed;
            }
            if ((this.myPitData != null) & (this.originalPitData == null))
            {
                return CheckPITStatus.PIT_NewFile;
            }
            return CheckPITStatus.PIT_Unchanged;
        }

        private void ClearAll()
        {
            try
            {
                IEnumerator enumerator;
                try
                {
                    enumerator = this.Controls.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        Control current = (Control) enumerator.Current;
                        if (current.GetType().Name == "Panel")
                        {
                            this.ClearControls(current);
                        }
                        if (current.GetType().Name == "GroupBox")
                        {
                            this.ClearControls(current);
                        }
                        if (current.GetType().Name == "TabControl")
                        {
                            this.ClearControls(current);
                        }
                        if (current.GetType().Name == "TextBox")
                        {
                            (current as TextBox).Clear();
                        }
                        if (current.GetType().Name == "RadioButton")
                        {
                            RadioButton button = current as RadioButton;
                            button.Checked = false;
                        }
                        if (current.GetType().Name == "CheckBox")
                        {
                            CheckBox box2 = current as CheckBox;
                            box2.Checked = false;
                        }
                        if (current.GetType().Name == "ComboBox")
                        {
                            ComboBox box3 = current as ComboBox;
                            box3.SelectedIndex = -1;
                        }
                        if (current.GetType().Name == "NumericUpDown")
                        {
                            NumericUpDown down = current as NumericUpDown;
                            down.Value = decimal.Zero;
                        }
                        if (current.GetType().Name == "RichTextBox")
                        {
                            (current as RichTextBox).Clear();
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
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MessageBox.Show(exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
            }
        }

        private void ClearControls(Control Type)
        {
            try
            {
                IEnumerator enumerator;
                try
                {
                    enumerator = Type.Controls.GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        Control current = (Control) enumerator.Current;
                        if (current.GetType().Name == "TextBox")
                        {
                            (current as TextBox).Clear();
                        }
                        if (current.GetType().Name == "Panel")
                        {
                            this.ClearControls(current);
                        }
                        if (current.GetType().Name == "GroupBox")
                        {
                            this.ClearControls(current);
                        }
                        if (current.GetType().Name == "TabPage")
                        {
                            this.ClearControls(current);
                        }
                        if (current.GetType().Name == "ComboBox")
                        {
                            ComboBox box2 = current as ComboBox;
                            box2.SelectedIndex = -1;
                        }
                        if (current.GetType().Name == "NumericUpDown")
                        {
                            NumericUpDown down = current as NumericUpDown;
                            down.Value = decimal.Zero;
                        }
                        if (current.GetType().Name == "RadioButton")
                        {
                            RadioButton button = current as RadioButton;
                            button.Checked = false;
                        }
                        if (current.GetType().Name == "CheckBox")
                        {
                            CheckBox box3 = current as CheckBox;
                            box3.Checked = false;
                        }
                        if (current.GetType().Name == "RichTextBox")
                        {
                            (current as RichTextBox).Clear();
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
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                MessageBox.Show(exception.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ProjectData.ClearProjectError();
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
            this.components = new System.ComponentModel.Container();
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmPIT_Magic_Main));
            this.tcPITLayout = new TabControl();
            this.tabPITFileEditor = new TabPage();
            this.btnResetForm = new Button();
            this.btnRemPITEntry = new Button();
            this.btnCreatePITEntry = new Button();
            this.gbPITOps = new GroupBox();
            this.btnNew = new Button();
            this.lblPITFile = new Label();
            this.txtPITFile = new TextBox();
            this.btnOpen = new Button();
            this.lblPITEntryList = new Label();
            this.btnSaveAs = new Button();
            this.cbPITEntries = new ComboBox();
            this.btnSave = new Button();
            this.gbPITFileHdrInfo = new GroupBox();
            this.lblReserved = new Label();
            this.lblProjectName = new Label();
            this.lblAPVendor = new Label();
            this.txtReserved = new TextBox();
            this.txtProjectName = new TextBox();
            this.lblDummyDataTypeMsg = new Label();
            this.txtAPVendor = new TextBox();
            this.gbHdrSize = new GroupBox();
            this.lblHdrSizeType = new Label();
            this.txtHdrSize = new TextBox();
            this.lblPITEntryCntType = new Label();
            this.lblHdrMagicType = new Label();
            this.lblPITEntryCnt = new Label();
            this.txtPITEntryCnt = new TextBox();
            this.lblHdrMagic = new Label();
            this.txtHdrMagic = new TextBox();
            this.gbCurrentPITEntry = new GroupBox();
            this.lblUpdAttrStatus = new Label();
            this.lblDevTypeStatus = new Label();
            this.numImageType = new NumericUpDown();
            this.lblBinTypeStatus = new Label();
            this.lblFotaFileName = new Label();
            this.txtFotaFileName = new TextBox();
            this.lblFlashFileName = new Label();
            this.lblPartName = new Label();
            this.txtFlashFileName = new TextBox();
            this.txtPartName = new TextBox();
            this.numBlockCount = new NumericUpDown();
            this.lblBlockSize = new Label();
            this.numBlockSize = new NumericUpDown();
            this.lblBlockCount = new Label();
            this.numPartitionType = new NumericUpDown();
            this.lblAttribStatus = new Label();
            this.numFileSystemType = new NumericUpDown();
            this.numPartitionID = new NumericUpDown();
            this.numFileSize = new NumericUpDown();
            this.lblImageType = new Label();
            this.numFileOffset = new NumericUpDown();
            this.numDeviceType = new NumericUpDown();
            this.lblDeviceType = new Label();
            this.lblPartitionID = new Label();
            this.lblPartitionType = new Label();
            this.lblFileSystemType = new Label();
            this.lblFileSize = new Label();
            this.lblFileOffset = new Label();
            this.tabPITFileAnalysis = new TabPage();
            this.btnOpenPITFile = new Button();
            this.btnExport = new Button();
            this.btnCopyClipboard = new Button();
            this.rtAnalysisOutput = new RichTextBox();
            this.lblVersionInfo = new Label();
            this.ofdPIT = new OpenFileDialog();
            this.sfdPIT = new SaveFileDialog();
            this.btnDonate = new Button();
            this.TimerIn = new Timer(this.components);
            this.TimerOut = new Timer(this.components);
            this.tcPITLayout.SuspendLayout();
            this.tabPITFileEditor.SuspendLayout();
            this.gbPITOps.SuspendLayout();
            this.gbPITFileHdrInfo.SuspendLayout();
            this.gbHdrSize.SuspendLayout();
            this.gbCurrentPITEntry.SuspendLayout();
            this.numImageType.BeginInit();
            this.numBlockCount.BeginInit();
            this.numBlockSize.BeginInit();
            this.numPartitionType.BeginInit();
            this.numFileSystemType.BeginInit();
            this.numPartitionID.BeginInit();
            this.numFileSize.BeginInit();
            this.numFileOffset.BeginInit();
            this.numDeviceType.BeginInit();
            this.tabPITFileAnalysis.SuspendLayout();
            this.SuspendLayout();
            this.tcPITLayout.Controls.Add(this.tabPITFileEditor);
            this.tcPITLayout.Controls.Add(this.tabPITFileAnalysis);
            this.tcPITLayout.Dock = DockStyle.Top;
            Point point2 = new Point(0, 0);
            this.tcPITLayout.Location = point2;
            this.tcPITLayout.Name = "tcPITLayout";
            this.tcPITLayout.SelectedIndex = 0;
            Size size2 = new Size(0x200, 0x21b);
            this.tcPITLayout.Size = size2;
            this.tcPITLayout.TabIndex = 6;
            this.tabPITFileEditor.Controls.Add(this.btnResetForm);
            this.tabPITFileEditor.Controls.Add(this.btnRemPITEntry);
            this.tabPITFileEditor.Controls.Add(this.btnCreatePITEntry);
            this.tabPITFileEditor.Controls.Add(this.gbPITOps);
            this.tabPITFileEditor.Controls.Add(this.gbPITFileHdrInfo);
            this.tabPITFileEditor.Controls.Add(this.gbCurrentPITEntry);
            point2 = new Point(4, 0x16);
            this.tabPITFileEditor.Location = point2;
            this.tabPITFileEditor.Name = "tabPITFileEditor";
            Padding padding2 = new Padding(3);
            this.tabPITFileEditor.Padding = padding2;
            size2 = new Size(0x1f8, 0x201);
            this.tabPITFileEditor.Size = size2;
            this.tabPITFileEditor.TabIndex = 0;
            this.tabPITFileEditor.Text = "PIT File Editor";
            this.tabPITFileEditor.UseVisualStyleBackColor = true;
            this.btnResetForm.Image = (Image) manager.GetObject("btnResetForm.Image");
            this.btnResetForm.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x184, 0x1e3);
            this.btnResetForm.Location = point2;
            this.btnResetForm.Name = "btnResetForm";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnResetForm.Padding = padding2;
            size2 = new Size(110, 0x19);
            this.btnResetForm.Size = size2;
            this.btnResetForm.TabIndex = 0x27;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnRemPITEntry.Image = (Image) manager.GetObject("btnRemPITEntry.Image");
            this.btnRemPITEntry.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0xae, 0x1e3);
            this.btnRemPITEntry.Location = point2;
            this.btnRemPITEntry.Name = "btnRemPITEntry";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnRemPITEntry.Padding = padding2;
            size2 = new Size(0x9c, 0x19);
            this.btnRemPITEntry.Size = size2;
            this.btnRemPITEntry.TabIndex = 0x26;
            this.btnRemPITEntry.Text = "Remove PIT Entry";
            this.btnRemPITEntry.UseVisualStyleBackColor = true;
            this.btnCreatePITEntry.Image = (Image) manager.GetObject("btnCreatePITEntry.Image");
            this.btnCreatePITEntry.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(6, 0x1e3);
            this.btnCreatePITEntry.Location = point2;
            this.btnCreatePITEntry.Name = "btnCreatePITEntry";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnCreatePITEntry.Padding = padding2;
            size2 = new Size(0x9c, 0x19);
            this.btnCreatePITEntry.Size = size2;
            this.btnCreatePITEntry.TabIndex = 0x25;
            this.btnCreatePITEntry.Text = "Create PIT Entry";
            this.btnCreatePITEntry.UseVisualStyleBackColor = true;
            this.gbPITOps.Controls.Add(this.btnNew);
            this.gbPITOps.Controls.Add(this.lblPITFile);
            this.gbPITOps.Controls.Add(this.txtPITFile);
            this.gbPITOps.Controls.Add(this.btnOpen);
            this.gbPITOps.Controls.Add(this.lblPITEntryList);
            this.gbPITOps.Controls.Add(this.btnSaveAs);
            this.gbPITOps.Controls.Add(this.cbPITEntries);
            this.gbPITOps.Controls.Add(this.btnSave);
            point2 = new Point(6, 6);
            this.gbPITOps.Location = point2;
            this.gbPITOps.Name = "gbPITOps";
            size2 = new Size(0x1ec, 0x67);
            this.gbPITOps.Size = size2;
            this.gbPITOps.TabIndex = 0x24;
            this.gbPITOps.TabStop = false;
            this.gbPITOps.Text = "PIT Operations:";
            this.btnNew.Image = (Image) manager.GetObject("btnNew.Image");
            this.btnNew.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(10, 0x12);
            this.btnNew.Location = point2;
            this.btnNew.Name = "btnNew";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnNew.Padding = padding2;
            size2 = new Size(110, 0x19);
            this.btnNew.Size = size2;
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New...";
            this.btnNew.UseVisualStyleBackColor = true;
            this.lblPITFile.AutoSize = true;
            point2 = new Point(6, 0x34);
            this.lblPITFile.Location = point2;
            this.lblPITFile.Name = "lblPITFile";
            size2 = new Size(0x2e, 13);
            this.lblPITFile.Size = size2;
            this.lblPITFile.TabIndex = 7;
            this.lblPITFile.Text = "PIT File:";
            this.txtPITFile.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(9, 0x44);
            this.txtPITFile.Location = point2;
            this.txtPITFile.Name = "txtPITFile";
            this.txtPITFile.ReadOnly = true;
            size2 = new Size(0x124, 20);
            this.txtPITFile.Size = size2;
            this.txtPITFile.TabIndex = 6;
            this.btnOpen.Image = (Image) manager.GetObject("btnOpen.Image");
            this.btnOpen.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x83, 0x12);
            this.btnOpen.Location = point2;
            this.btnOpen.Name = "btnOpen";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnOpen.Padding = padding2;
            size2 = new Size(110, 0x19);
            this.btnOpen.Size = size2;
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.lblPITEntryList.AutoSize = true;
            point2 = new Point(320, 0x33);
            this.lblPITEntryList.Location = point2;
            this.lblPITEntryList.Name = "lblPITEntryList";
            size2 = new Size(0x49, 13);
            this.lblPITEntryList.Size = size2;
            this.lblPITEntryList.TabIndex = 5;
            this.lblPITEntryList.Text = "PIT Entry List:";
            this.btnSaveAs.Image = (Image) manager.GetObject("btnSaveAs.Image");
            this.btnSaveAs.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x175, 0x12);
            this.btnSaveAs.Location = point2;
            this.btnSaveAs.Name = "btnSaveAs";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnSaveAs.Padding = padding2;
            size2 = new Size(110, 0x19);
            this.btnSaveAs.Size = size2;
            this.btnSaveAs.TabIndex = 3;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.cbPITEntries.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbPITEntries.FormattingEnabled = true;
            point2 = new Point(0x143, 0x43);
            this.cbPITEntries.Location = point2;
            this.cbPITEntries.Name = "cbPITEntries";
            size2 = new Size(160, 0x15);
            this.cbPITEntries.Size = size2;
            this.cbPITEntries.TabIndex = 4;
            this.btnSave.Image = (Image) manager.GetObject("btnSave.Image");
            this.btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0xfc, 0x12);
            this.btnSave.Location = point2;
            this.btnSave.Name = "btnSave";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnSave.Padding = padding2;
            size2 = new Size(110, 0x19);
            this.btnSave.Size = size2;
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.gbPITFileHdrInfo.Controls.Add(this.lblReserved);
            this.gbPITFileHdrInfo.Controls.Add(this.lblProjectName);
            this.gbPITFileHdrInfo.Controls.Add(this.lblAPVendor);
            this.gbPITFileHdrInfo.Controls.Add(this.txtReserved);
            this.gbPITFileHdrInfo.Controls.Add(this.txtProjectName);
            this.gbPITFileHdrInfo.Controls.Add(this.lblDummyDataTypeMsg);
            this.gbPITFileHdrInfo.Controls.Add(this.txtAPVendor);
            this.gbPITFileHdrInfo.Controls.Add(this.gbHdrSize);
            this.gbPITFileHdrInfo.Controls.Add(this.lblPITEntryCntType);
            this.gbPITFileHdrInfo.Controls.Add(this.lblHdrMagicType);
            this.gbPITFileHdrInfo.Controls.Add(this.lblPITEntryCnt);
            this.gbPITFileHdrInfo.Controls.Add(this.txtPITEntryCnt);
            this.gbPITFileHdrInfo.Controls.Add(this.lblHdrMagic);
            this.gbPITFileHdrInfo.Controls.Add(this.txtHdrMagic);
            point2 = new Point(6, 0x73);
            this.gbPITFileHdrInfo.Location = point2;
            this.gbPITFileHdrInfo.Name = "gbPITFileHdrInfo";
            size2 = new Size(0x1ec, 150);
            this.gbPITFileHdrInfo.Size = size2;
            this.gbPITFileHdrInfo.TabIndex = 0x23;
            this.gbPITFileHdrInfo.TabStop = false;
            this.gbPITFileHdrInfo.Text = "PIT File Header Information:";
            this.lblReserved.AutoSize = true;
            point2 = new Point(0x14f, 0x49);
            this.lblReserved.Location = point2;
            this.lblReserved.Name = "lblReserved";
            size2 = new Size(0x38, 13);
            this.lblReserved.Size = size2;
            this.lblReserved.TabIndex = 0x4e;
            this.lblReserved.Text = "Reserved:";
            this.lblProjectName.AutoSize = true;
            point2 = new Point(0xab, 0x49);
            this.lblProjectName.Location = point2;
            this.lblProjectName.Name = "lblProjectName";
            size2 = new Size(0x89, 13);
            this.lblProjectName.Size = size2;
            this.lblProjectName.TabIndex = 0x4d;
            this.lblProjectName.Text = "Project Name (Max 8 Char):";
            this.lblAPVendor.AutoSize = true;
            point2 = new Point(6, 0x49);
            this.lblAPVendor.Location = point2;
            this.lblAPVendor.Name = "lblAPVendor";
            size2 = new Size(0x7c, 13);
            this.lblAPVendor.Size = size2;
            this.lblAPVendor.TabIndex = 0x4c;
            this.lblAPVendor.Text = "AP Vendor (Max 8 Char):";
            this.txtReserved.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(0x151, 0x59);
            this.txtReserved.Location = point2;
            this.txtReserved.MaxLength = 0x7fffffff;
            this.txtReserved.Name = "txtReserved";
            size2 = new Size(0x92, 20);
            this.txtReserved.Size = size2;
            this.txtReserved.TabIndex = 0x49;
            this.txtProjectName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(0xad, 0x59);
            this.txtProjectName.Location = point2;
            this.txtProjectName.MaxLength = 8;
            this.txtProjectName.Name = "txtProjectName";
            size2 = new Size(0x92, 20);
            this.txtProjectName.Size = size2;
            this.txtProjectName.TabIndex = 0x48;
            this.lblDummyDataTypeMsg.AutoSize = true;
            point2 = new Point(0x29, 120);
            this.lblDummyDataTypeMsg.Location = point2;
            this.lblDummyDataTypeMsg.Name = "lblDummyDataTypeMsg";
            size2 = new Size(410, 13);
            this.lblDummyDataTypeMsg.Size = size2;
            this.lblDummyDataTypeMsg.TabIndex = 0x47;
            this.lblDummyDataTypeMsg.Text = "AP Vendor + Project Name - 8 Bytes Per Block / Reserved - 4 Bytes / 20 Bytes Total.";
            this.lblDummyDataTypeMsg.TextAlign = ContentAlignment.MiddleCenter;
            this.txtAPVendor.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(9, 0x59);
            this.txtAPVendor.Location = point2;
            this.txtAPVendor.MaxLength = 8;
            this.txtAPVendor.Name = "txtAPVendor";
            size2 = new Size(0x92, 20);
            this.txtAPVendor.Size = size2;
            this.txtAPVendor.TabIndex = 0x42;
            this.gbHdrSize.Controls.Add(this.lblHdrSizeType);
            this.gbHdrSize.Controls.Add(this.txtHdrSize);
            point2 = new Point(0x15c, 0x12);
            this.gbHdrSize.Location = point2;
            this.gbHdrSize.Name = "gbHdrSize";
            size2 = new Size(0x87, 0x2e);
            this.gbHdrSize.Size = size2;
            this.gbHdrSize.TabIndex = 0x3d;
            this.gbHdrSize.TabStop = false;
            this.gbHdrSize.Text = "Header Size:";
            this.lblHdrSizeType.AutoSize = true;
            point2 = new Point(0x53, 0x13);
            this.lblHdrSizeType.Location = point2;
            this.lblHdrSizeType.Name = "lblHdrSizeType";
            size2 = new Size(0x27, 13);
            this.lblHdrSizeType.Size = size2;
            this.lblHdrSizeType.TabIndex = 0x41;
            this.lblHdrSizeType.Text = "(Bytes)";
            this.txtHdrSize.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x10);
            this.txtHdrSize.Location = point2;
            this.txtHdrSize.Name = "txtHdrSize";
            this.txtHdrSize.ReadOnly = true;
            size2 = new Size(0x41, 20);
            this.txtHdrSize.Size = size2;
            this.txtHdrSize.TabIndex = 0x40;
            this.lblPITEntryCntType.AutoSize = true;
            point2 = new Point(0xb7, 0x2f);
            this.lblPITEntryCntType.Location = point2;
            this.lblPITEntryCntType.Name = "lblPITEntryCntType";
            size2 = new Size(0x99, 13);
            this.lblPITEntryCntType.Size = size2;
            this.lblPITEntryCntType.TabIndex = 0x3b;
            this.lblPITEntryCntType.Text = "(32-Bit Signed Integer, 4 Bytes)";
            this.lblHdrMagicType.AutoSize = true;
            point2 = new Point(0xb7, 0x15);
            this.lblHdrMagicType.Location = point2;
            this.lblHdrMagicType.Name = "lblHdrMagicType";
            size2 = new Size(0x99, 13);
            this.lblHdrMagicType.Size = size2;
            this.lblHdrMagicType.TabIndex = 0x3a;
            this.lblHdrMagicType.Text = "(32-Bit Signed Integer, 4 Bytes)";
            this.lblPITEntryCnt.AutoSize = true;
            point2 = new Point(6, 0x2f);
            this.lblPITEntryCnt.Location = point2;
            this.lblPITEntryCnt.Name = "lblPITEntryCnt";
            size2 = new Size(0x55, 13);
            this.lblPITEntryCnt.Size = size2;
            this.lblPITEntryCnt.TabIndex = 0x39;
            this.lblPITEntryCnt.Text = "PIT Entry Count:";
            this.txtPITEntryCnt.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0x65, 0x2c);
            this.txtPITEntryCnt.Location = point2;
            this.txtPITEntryCnt.Name = "txtPITEntryCnt";
            this.txtPITEntryCnt.ReadOnly = true;
            size2 = new Size(0x4c, 20);
            this.txtPITEntryCnt.Size = size2;
            this.txtPITEntryCnt.TabIndex = 0x38;
            this.lblHdrMagic.AutoSize = true;
            point2 = new Point(6, 0x15);
            this.lblHdrMagic.Location = point2;
            this.lblHdrMagic.Name = "lblHdrMagic";
            size2 = new Size(0x4d, 13);
            this.lblHdrMagic.Size = size2;
            this.lblHdrMagic.TabIndex = 0x37;
            this.lblHdrMagic.Text = "Header Magic:";
            this.txtHdrMagic.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(0x65, 0x12);
            this.txtHdrMagic.Location = point2;
            this.txtHdrMagic.Name = "txtHdrMagic";
            this.txtHdrMagic.ReadOnly = true;
            size2 = new Size(0x4c, 20);
            this.txtHdrMagic.Size = size2;
            this.txtHdrMagic.TabIndex = 0x36;
            this.gbCurrentPITEntry.Controls.Add(this.lblUpdAttrStatus);
            this.gbCurrentPITEntry.Controls.Add(this.lblDevTypeStatus);
            this.gbCurrentPITEntry.Controls.Add(this.numImageType);
            this.gbCurrentPITEntry.Controls.Add(this.lblBinTypeStatus);
            this.gbCurrentPITEntry.Controls.Add(this.lblFotaFileName);
            this.gbCurrentPITEntry.Controls.Add(this.txtFotaFileName);
            this.gbCurrentPITEntry.Controls.Add(this.lblFlashFileName);
            this.gbCurrentPITEntry.Controls.Add(this.lblPartName);
            this.gbCurrentPITEntry.Controls.Add(this.txtFlashFileName);
            this.gbCurrentPITEntry.Controls.Add(this.txtPartName);
            this.gbCurrentPITEntry.Controls.Add(this.numBlockCount);
            this.gbCurrentPITEntry.Controls.Add(this.lblBlockSize);
            this.gbCurrentPITEntry.Controls.Add(this.numBlockSize);
            this.gbCurrentPITEntry.Controls.Add(this.lblBlockCount);
            this.gbCurrentPITEntry.Controls.Add(this.numPartitionType);
            this.gbCurrentPITEntry.Controls.Add(this.lblAttribStatus);
            this.gbCurrentPITEntry.Controls.Add(this.numFileSystemType);
            this.gbCurrentPITEntry.Controls.Add(this.numPartitionID);
            this.gbCurrentPITEntry.Controls.Add(this.numFileSize);
            this.gbCurrentPITEntry.Controls.Add(this.lblImageType);
            this.gbCurrentPITEntry.Controls.Add(this.numFileOffset);
            this.gbCurrentPITEntry.Controls.Add(this.numDeviceType);
            this.gbCurrentPITEntry.Controls.Add(this.lblDeviceType);
            this.gbCurrentPITEntry.Controls.Add(this.lblPartitionID);
            this.gbCurrentPITEntry.Controls.Add(this.lblPartitionType);
            this.gbCurrentPITEntry.Controls.Add(this.lblFileSystemType);
            this.gbCurrentPITEntry.Controls.Add(this.lblFileSize);
            this.gbCurrentPITEntry.Controls.Add(this.lblFileOffset);
            point2 = new Point(6, 0x10f);
            this.gbCurrentPITEntry.Location = point2;
            this.gbCurrentPITEntry.Name = "gbCurrentPITEntry";
            size2 = new Size(0x1ec, 0xce);
            this.gbCurrentPITEntry.Size = size2;
            this.gbCurrentPITEntry.TabIndex = 0x22;
            this.gbCurrentPITEntry.TabStop = false;
            this.gbCurrentPITEntry.Text = "Current PIT Entry:";
            point2 = new Point(0x95, 0x7c);
            this.lblUpdAttrStatus.Location = point2;
            this.lblUpdAttrStatus.Name = "lblUpdAttrStatus";
            size2 = new Size(0x4a, 13);
            this.lblUpdAttrStatus.Size = size2;
            this.lblUpdAttrStatus.TabIndex = 0x34;
            this.lblUpdAttrStatus.Text = "Generic";
            this.lblUpdAttrStatus.TextAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x95, 0x2e);
            this.lblDevTypeStatus.Location = point2;
            this.lblDevTypeStatus.Name = "lblDevTypeStatus";
            size2 = new Size(0x4a, 13);
            this.lblDevTypeStatus.Size = size2;
            this.lblDevTypeStatus.TabIndex = 0x33;
            this.lblDevTypeStatus.Text = "All";
            this.lblDevTypeStatus.TextAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x65, 0x12);
            this.numImageType.Location = point2;
            decimal num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numImageType.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numImageType.Minimum = num;
            this.numImageType.Name = "numImageType";
            size2 = new Size(0x2a, 20);
            this.numImageType.Size = size2;
            this.numImageType.TabIndex = 50;
            point2 = new Point(0x95, 20);
            this.lblBinTypeStatus.Location = point2;
            this.lblBinTypeStatus.Name = "lblBinTypeStatus";
            size2 = new Size(0x4a, 13);
            this.lblBinTypeStatus.Size = size2;
            this.lblBinTypeStatus.TabIndex = 0x31;
            this.lblBinTypeStatus.Text = "AP";
            this.lblBinTypeStatus.TextAlign = ContentAlignment.MiddleLeft;
            this.lblFotaFileName.AutoSize = true;
            point2 = new Point(0xe1, 0xb0);
            this.lblFotaFileName.Location = point2;
            this.lblFotaFileName.Name = "lblFotaFileName";
            size2 = new Size(0x98, 13);
            this.lblFotaFileName.Size = size2;
            this.lblFotaFileName.TabIndex = 0x30;
            this.lblFotaFileName.Text = "FOTA Filename (Max 32 Char):";
            this.txtFotaFileName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(0x17b, 0xad);
            this.txtFotaFileName.Location = point2;
            this.txtFotaFileName.MaxLength = 0x20;
            this.txtFotaFileName.Name = "txtFotaFileName";
            size2 = new Size(0x68, 20);
            this.txtFotaFileName.Size = size2;
            this.txtFotaFileName.TabIndex = 0x2f;
            this.lblFlashFileName.AutoSize = true;
            point2 = new Point(0xe1, 150);
            this.lblFlashFileName.Location = point2;
            this.lblFlashFileName.Name = "lblFlashFileName";
            size2 = new Size(0x95, 13);
            this.lblFlashFileName.Size = size2;
            this.lblFlashFileName.TabIndex = 0x2e;
            this.lblFlashFileName.Text = "Flash Filename (Max 32 Char):";
            this.lblPartName.AutoSize = true;
            point2 = new Point(0xe1, 0x7c);
            this.lblPartName.Location = point2;
            this.lblPartName.Name = "lblPartName";
            size2 = new Size(0x94, 13);
            this.lblPartName.Size = size2;
            this.lblPartName.TabIndex = 0x2d;
            this.lblPartName.Text = "Partition Name (Max 32 Char):";
            this.txtFlashFileName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(0x17b, 0x93);
            this.txtFlashFileName.Location = point2;
            this.txtFlashFileName.MaxLength = 0x20;
            this.txtFlashFileName.Name = "txtFlashFileName";
            size2 = new Size(0x68, 20);
            this.txtFlashFileName.Size = size2;
            this.txtFlashFileName.TabIndex = 0x2c;
            this.txtPartName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(0x17b, 0x79);
            this.txtPartName.Location = point2;
            this.txtPartName.MaxLength = 0x20;
            this.txtPartName.Name = "txtPartName";
            size2 = new Size(0x68, 20);
            this.txtPartName.Size = size2;
            this.txtPartName.TabIndex = 0x2b;
            point2 = new Point(0x65, 0x94);
            this.numBlockCount.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numBlockCount.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numBlockCount.Minimum = num;
            this.numBlockCount.Name = "numBlockCount";
            size2 = new Size(0x68, 20);
            this.numBlockCount.Size = size2;
            this.numBlockCount.TabIndex = 0x29;
            this.numBlockCount.ThousandsSeparator = true;
            this.lblBlockSize.AutoSize = true;
            point2 = new Point(6, 0xb0);
            this.lblBlockSize.Location = point2;
            this.lblBlockSize.Name = "lblBlockSize";
            size2 = new Size(0x53, 13);
            this.lblBlockSize.Size = size2;
            this.lblBlockSize.TabIndex = 40;
            this.lblBlockSize.Text = "Block Size (KB):";
            point2 = new Point(0x65, 0xae);
            this.numBlockSize.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numBlockSize.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numBlockSize.Minimum = num;
            this.numBlockSize.Name = "numBlockSize";
            size2 = new Size(0x68, 20);
            this.numBlockSize.Size = size2;
            this.numBlockSize.TabIndex = 0x2a;
            this.numBlockSize.ThousandsSeparator = true;
            this.lblBlockCount.AutoSize = true;
            point2 = new Point(6, 150);
            this.lblBlockCount.Location = point2;
            this.lblBlockCount.Name = "lblBlockCount";
            size2 = new Size(0x5b, 13);
            this.lblBlockCount.Size = size2;
            this.lblBlockCount.TabIndex = 0x27;
            this.lblBlockCount.Text = "Block Count (KB):";
            point2 = new Point(0x65, 0x60);
            this.numPartitionType.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numPartitionType.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numPartitionType.Minimum = num;
            this.numPartitionType.Name = "numPartitionType";
            size2 = new Size(0x2a, 20);
            this.numPartitionType.Size = size2;
            this.numPartitionType.TabIndex = 0x24;
            point2 = new Point(0x95, 0x62);
            this.lblAttribStatus.Location = point2;
            this.lblAttribStatus.Name = "lblAttribStatus";
            size2 = new Size(0x4a, 13);
            this.lblAttribStatus.Size = size2;
            this.lblAttribStatus.TabIndex = 0x23;
            this.lblAttribStatus.Text = "Generic";
            this.lblAttribStatus.TextAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x65, 0x7a);
            this.numFileSystemType.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numFileSystemType.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numFileSystemType.Minimum = num;
            this.numFileSystemType.Name = "numFileSystemType";
            size2 = new Size(0x2a, 20);
            this.numFileSystemType.Size = size2;
            this.numFileSystemType.TabIndex = 0x1f;
            point2 = new Point(0x65, 70);
            this.numPartitionID.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numPartitionID.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numPartitionID.Minimum = num;
            this.numPartitionID.Name = "numPartitionID";
            size2 = new Size(0x2a, 20);
            this.numPartitionID.Size = size2;
            this.numPartitionID.TabIndex = 0x21;
            point2 = new Point(0x17b, 0x2c);
            this.numFileSize.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numFileSize.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numFileSize.Minimum = num;
            this.numFileSize.Name = "numFileSize";
            size2 = new Size(0x68, 20);
            this.numFileSize.Size = size2;
            this.numFileSize.TabIndex = 30;
            this.lblImageType.AutoSize = true;
            point2 = new Point(6, 20);
            this.lblImageType.Location = point2;
            this.lblImageType.Name = "lblImageType";
            size2 = new Size(0x42, 13);
            this.lblImageType.Size = size2;
            this.lblImageType.TabIndex = 6;
            this.lblImageType.Text = "Image Type:";
            point2 = new Point(0x17b, 0x12);
            this.numFileOffset.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numFileOffset.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numFileOffset.Minimum = num;
            this.numFileOffset.Name = "numFileOffset";
            size2 = new Size(0x68, 20);
            this.numFileOffset.Size = size2;
            this.numFileOffset.TabIndex = 0x1d;
            point2 = new Point(0x65, 0x2c);
            this.numDeviceType.Location = point2;
            num = new decimal(new int[] { 0x7fffffff, 0, 0, 0 });
            this.numDeviceType.Maximum = num;
            num = new decimal(new int[] { -2147483648, 0, 0, -2147483648 });
            this.numDeviceType.Minimum = num;
            this.numDeviceType.Name = "numDeviceType";
            size2 = new Size(0x2a, 20);
            this.numDeviceType.Size = size2;
            this.numDeviceType.TabIndex = 0x20;
            this.lblDeviceType.AutoSize = true;
            point2 = new Point(6, 0x2e);
            this.lblDeviceType.Location = point2;
            this.lblDeviceType.Name = "lblDeviceType";
            size2 = new Size(0x47, 13);
            this.lblDeviceType.Size = size2;
            this.lblDeviceType.TabIndex = 8;
            this.lblDeviceType.Text = "Device Type:";
            this.lblPartitionID.AutoSize = true;
            point2 = new Point(6, 0x48);
            this.lblPartitionID.Location = point2;
            this.lblPartitionID.Name = "lblPartitionID";
            size2 = new Size(0x3e, 13);
            this.lblPartitionID.Size = size2;
            this.lblPartitionID.TabIndex = 10;
            this.lblPartitionID.Text = "Partition ID:";
            this.lblPartitionType.AutoSize = true;
            point2 = new Point(6, 0x62);
            this.lblPartitionType.Location = point2;
            this.lblPartitionType.Name = "lblPartitionType";
            size2 = new Size(0x4b, 13);
            this.lblPartitionType.Size = size2;
            this.lblPartitionType.TabIndex = 12;
            this.lblPartitionType.Text = "Partition Type:";
            this.lblFileSystemType.AutoSize = true;
            point2 = new Point(6, 0x7c);
            this.lblFileSystemType.Location = point2;
            this.lblFileSystemType.Name = "lblFileSystemType";
            size2 = new Size(90, 13);
            this.lblFileSystemType.Size = size2;
            this.lblFileSystemType.TabIndex = 0x12;
            this.lblFileSystemType.Text = "File System Type:";
            this.lblFileSize.AutoSize = true;
            point2 = new Point(0xe1, 0x2e);
            this.lblFileSize.Location = point2;
            this.lblFileSize.Name = "lblFileSize";
            size2 = new Size(100, 13);
            this.lblFileSize.Size = size2;
            this.lblFileSize.TabIndex = 0x10;
            this.lblFileSize.Text = "File Size (Obsolete):";
            this.lblFileOffset.AutoSize = true;
            point2 = new Point(0xe1, 20);
            this.lblFileOffset.Location = point2;
            this.lblFileOffset.Name = "lblFileOffset";
            size2 = new Size(0x97, 13);
            this.lblFileOffset.Size = size2;
            this.lblFileOffset.TabIndex = 14;
            this.lblFileOffset.Text = "File Offset (In TAR) (Obsolete):";
            this.tabPITFileAnalysis.Controls.Add(this.btnOpenPITFile);
            this.tabPITFileAnalysis.Controls.Add(this.btnExport);
            this.tabPITFileAnalysis.Controls.Add(this.btnCopyClipboard);
            this.tabPITFileAnalysis.Controls.Add(this.rtAnalysisOutput);
            point2 = new Point(4, 0x16);
            this.tabPITFileAnalysis.Location = point2;
            this.tabPITFileAnalysis.Name = "tabPITFileAnalysis";
            padding2 = new Padding(3);
            this.tabPITFileAnalysis.Padding = padding2;
            size2 = new Size(0x1f8, 0x201);
            this.tabPITFileAnalysis.Size = size2;
            this.tabPITFileAnalysis.TabIndex = 1;
            this.tabPITFileAnalysis.Text = "PIT File Analysis";
            this.tabPITFileAnalysis.UseVisualStyleBackColor = true;
            this.btnOpenPITFile.Image = (Image) manager.GetObject("btnOpenPITFile.Image");
            this.btnOpenPITFile.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(6, 0x1e3);
            this.btnOpenPITFile.Location = point2;
            this.btnOpenPITFile.Name = "btnOpenPITFile";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnOpenPITFile.Padding = padding2;
            size2 = new Size(0x8f, 0x19);
            this.btnOpenPITFile.Size = size2;
            this.btnOpenPITFile.TabIndex = 6;
            this.btnOpenPITFile.Text = "Open PIT File...";
            this.btnOpenPITFile.UseVisualStyleBackColor = true;
            this.btnExport.Image = (Image) manager.GetObject("btnExport.Image");
            this.btnExport.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0xb5, 0x1e3);
            this.btnExport.Location = point2;
            this.btnExport.Name = "btnExport";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnExport.Padding = padding2;
            size2 = new Size(0x8f, 0x19);
            this.btnExport.Size = size2;
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export To File...";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnCopyClipboard.Image = (Image) manager.GetObject("btnCopyClipboard.Image");
            this.btnCopyClipboard.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x163, 0x1e3);
            this.btnCopyClipboard.Location = point2;
            this.btnCopyClipboard.Name = "btnCopyClipboard";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnCopyClipboard.Padding = padding2;
            size2 = new Size(0x8f, 0x19);
            this.btnCopyClipboard.Size = size2;
            this.btnCopyClipboard.TabIndex = 4;
            this.btnCopyClipboard.Text = "Copy To Clipboard";
            this.btnCopyClipboard.UseVisualStyleBackColor = true;
            this.rtAnalysisOutput.Font = new Font("Lucida Console", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            point2 = new Point(6, 6);
            this.rtAnalysisOutput.Location = point2;
            this.rtAnalysisOutput.Name = "rtAnalysisOutput";
            this.rtAnalysisOutput.ReadOnly = true;
            size2 = new Size(0x1ec, 0x1d7);
            this.rtAnalysisOutput.Size = size2;
            this.rtAnalysisOutput.TabIndex = 0;
            this.rtAnalysisOutput.Text = "Open a PIT file to analyze it's contents.";
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            point2 = new Point(12, 0x222);
            this.lblVersionInfo.Location = point2;
            this.lblVersionInfo.Name = "lblVersionInfo";
            size2 = new Size(0xdd, 0x15);
            this.lblVersionInfo.Size = size2;
            this.lblVersionInfo.TabIndex = 9;
            this.lblVersionInfo.Text = "PIT Magic v#.#.# \x00a9 Gaz 2014.";
            this.ofdPIT.DefaultExt = "pit";
            this.ofdPIT.Filter = "Samsung PIT Files (*.pit)|*.pit";
            this.ofdPIT.Title = "Open PIT File...";
            this.sfdPIT.DefaultExt = "pit";
            this.sfdPIT.Filter = "Samsung PIT Files (*.pit)|*.pit";
            this.sfdPIT.Title = "Save PIT File As...";
            this.btnDonate.Image = (Image) manager.GetObject("btnDonate.Image");
            this.btnDonate.ImageAlign = ContentAlignment.MiddleLeft;
            point2 = new Point(0x188, 0x221);
            this.btnDonate.Location = point2;
            this.btnDonate.Name = "btnDonate";
            padding2 = new Padding(5, 0, 0, 0);
            this.btnDonate.Padding = padding2;
            size2 = new Size(110, 0x19);
            this.btnDonate.Size = size2;
            this.btnDonate.TabIndex = 0x27;
            this.btnDonate.Text = "Donate...";
            this.btnDonate.UseVisualStyleBackColor = true;
            SizeF ef2 = new SizeF(6f, 13f);
            this.AutoScaleDimensions = ef2;
            this.AutoScaleMode = AutoScaleMode.Font;
            size2 = new Size(0x200, 0x241);
            this.ClientSize = size2;
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.lblVersionInfo);
            this.Controls.Add(this.tcPITLayout);
            this.Icon = (Icon) manager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPIT_Magic_Main";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PIT Magic";
            this.tcPITLayout.ResumeLayout(false);
            this.tabPITFileEditor.ResumeLayout(false);
            this.gbPITOps.ResumeLayout(false);
            this.gbPITOps.PerformLayout();
            this.gbPITFileHdrInfo.ResumeLayout(false);
            this.gbPITFileHdrInfo.PerformLayout();
            this.gbHdrSize.ResumeLayout(false);
            this.gbHdrSize.PerformLayout();
            this.gbCurrentPITEntry.ResumeLayout(false);
            this.gbCurrentPITEntry.PerformLayout();
            this.numImageType.EndInit();
            this.numBlockCount.EndInit();
            this.numBlockSize.EndInit();
            this.numPartitionType.EndInit();
            this.numFileSystemType.EndInit();
            this.numPartitionID.EndInit();
            this.numFileSize.EndInit();
            this.numFileOffset.EndInit();
            this.numDeviceType.EndInit();
            this.tabPITFileAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void numDeviceType_ValueChanged(object sender, EventArgs e)
        {
            Array names = Enum.GetNames(typeof(PitEntry.EntryDeviceType));
            if (Enum.IsDefined(typeof(PitEntry.EntryDeviceType), Convert.ToInt32(this.numDeviceType.Value)))
            {
                this.lblDevTypeStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.numDeviceType.Value }, null).ToString();
            }
            else
            {
                this.lblDevTypeStatus.Text = "Unknown";
            }
        }

        private void numFileSystemType_ValueChanged(object sender, EventArgs e)
        {
            Array names = Enum.GetNames(typeof(PitEntry.EntryFileSystemType));
            if (Enum.IsDefined(typeof(PitEntry.EntryFileSystemType), Convert.ToInt32(this.numFileSystemType.Value)))
            {
                this.lblUpdAttrStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.numFileSystemType.Value }, null).ToString();
            }
            else
            {
                this.lblUpdAttrStatus.Text = "Unknown";
            }
        }

        private void numImageType_ValueChanged(object sender, EventArgs e)
        {
            Array names = Enum.GetNames(typeof(PitEntry.EntryImageType));
            if (Enum.IsDefined(typeof(PitEntry.EntryImageType), Convert.ToInt32(this.numImageType.Value)))
            {
                this.lblBinTypeStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.numImageType.Value }, null).ToString();
            }
            else
            {
                this.lblBinTypeStatus.Text = "Unknown";
            }
        }

        private void numPartitionType_ValueChanged(object sender, EventArgs e)
        {
            Array names = Enum.GetNames(typeof(PitEntry.EntryPartitionType));
            if (Enum.IsDefined(typeof(PitEntry.EntryPartitionType), Convert.ToInt32(this.numPartitionType.Value)))
            {
                this.lblAttribStatus.Text = NewLateBinding.LateIndexGet(names, new object[] { this.numPartitionType.Value }, null).ToString();
            }
            else
            {
                this.lblAttribStatus.Text = "Unknown";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (this.CheckPITChanged() == CheckPITStatus.PIT_Changed)
            {
                switch (Interaction.MsgBox(Path.GetFileName(this.ofdPIT.FileName) + " has been modified. Do you want to save changes?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
                {
                    case MsgBoxResult.Yes:
                        this.SavePITChanges();
                        break;

                    case MsgBoxResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            else if (this.CheckPITChanged() == CheckPITStatus.PIT_NewFile)
            {
                switch (Interaction.MsgBox(this.txtPITFile.Text + " has been modified. Do you want to save new file?", MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
                {
                    case MsgBoxResult.Yes:
                        this.SaveNewPITFile(e);
                        break;

                    case MsgBoxResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            if (this.Opacity == 1.0)
            {
                this.TimerOut.Enabled = true;
            }
            this.ShowDonateDialog();
            base.OnFormClosing(e);
        }

        private void PIT_Magic_Main_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            this.TimerIn.Interval = 20;
            this.TimerIn.Enabled = true;
            this.TimerOut.Interval = 20;
            this.TimerOut.Enabled = false;
        }

        private void SaveNewPITFile(FormClosingEventArgs e = null)
        {
            try
            {
                if (this.cbPITEntries.Items.Count > 0)
                {
                    this.sfdPIT.FileName = this.txtPITFile.Text;
                    this.sfdPIT.InitialDirectory = this.AppPath;
                    if (this.sfdPIT.ShowDialog() == DialogResult.Cancel)
                    {
                        if (e != null)
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        MemoryStream stream2 = new MemoryStream();
                        FileStream byteStream = new FileStream(this.sfdPIT.FileName, FileMode.Create);
                        PitOutputStream outputStream = new PitOutputStream(byteStream);
                        this.myPitData.WritePITFile(outputStream);
                        stream2.WriteTo(byteStream);
                        stream2.Close();
                        byteStream.Close();
                        this.ofdPIT.FileName = this.sfdPIT.FileName;
                        this.btnSave.Enabled = true;
                        this.originalPitData = null;
                        this.originalPitData = new PitData();
                        this.originalPitData = PitData.Clone(this.myPitData);
                        Interaction.MsgBox("Changes saved to '" + Path.GetFileName(this.sfdPIT.FileName) + "' successfully.", MsgBoxStyle.Information, null);
                    }
                }
                else
                {
                    Interaction.MsgBox("You MUST create at least ONE PIT Entry before saving to disk.", MsgBoxStyle.Exclamation, null);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An error occurred while saving the file to disk.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void SavePITChanges()
        {
            try
            {
                if (this.cbPITEntries.Items.Count > 0)
                {
                    MemoryStream stream2 = new MemoryStream();
                    FileStream byteStream = new FileStream(this.ofdPIT.FileName, FileMode.Create);
                    PitOutputStream outputStream = new PitOutputStream(byteStream);
                    this.myPitData.WritePITFile(outputStream);
                    stream2.WriteTo(byteStream);
                    stream2.Close();
                    byteStream.Close();
                    this.originalPitData = null;
                    this.originalPitData = new PitData();
                    this.originalPitData = PitData.Clone(this.myPitData);
                    Interaction.MsgBox("Changes saved to '" + Path.GetFileName(this.ofdPIT.FileName) + "' successfully.", MsgBoxStyle.Information, null);
                }
                else
                {
                    Interaction.MsgBox("You MUST create at least ONE PIT Entry before saving to disk.", MsgBoxStyle.Exclamation, null);
                }
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception exception = exception1;
                Interaction.MsgBox("An error occurred while saving the file to disk.", MsgBoxStyle.Critical, null);
                ProjectData.ClearProjectError();
            }
        }

        private void ShowDonateDialog()
        {
            if (Interaction.MsgBox("Thank you for using PIT Magic. Would you like to make a donation?", MsgBoxStyle.Question | MsgBoxStyle.YesNo, "Show Your Support! :-)") == MsgBoxResult.Yes)
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

        private void txtAPVendor_LostFocus(object sender, EventArgs e)
        {
            this.UpdatePITHeader();
        }

        private void txtProjectName_LostFocus(object sender, EventArgs e)
        {
            this.UpdatePITHeader();
        }

        private void txtReserved_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] array = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\b', '\x007f' };
            if (Array.IndexOf<char>(array, e.KeyChar) == -1)
            {
                e.Handled = true;
            }
        }

        private void txtReserved_LostFocus(object sender, EventArgs e)
        {
            this.UpdatePITHeader();
        }

        private void UpdatePIT()
        {
            this.UpdatePITHeader();
            if (this.cbPITEntries.Items.Count > 0)
            {
                this.myPitEntry.ImageType = (PitEntry.EntryImageType) Convert.ToInt32(this.numImageType.Value);
                this.myPitEntry.DeviceType = (PitEntry.EntryDeviceType) Convert.ToInt32(this.numDeviceType.Value);
                this.myPitEntry.PartitionID = Convert.ToInt32(this.numPartitionID.Value);
                this.myPitEntry.PartitionType = (PitEntry.EntryPartitionType) Convert.ToInt32(this.numPartitionType.Value);
                this.myPitEntry.FileSystemType = (PitEntry.EntryFileSystemType) Convert.ToInt32(this.numFileSystemType.Value);
                this.myPitEntry.BlockCount = Convert.ToInt32(this.numBlockCount.Value);
                this.myPitEntry.BlockSize = Convert.ToInt32(this.numBlockSize.Value);
                this.myPitEntry.FileOffset = Convert.ToInt32(this.numFileOffset.Value);
                this.myPitEntry.FileSize = Convert.ToInt32(this.numFileSize.Value);
                if (string.IsNullOrEmpty(this.txtPartName.Text))
                {
                    this.myPitEntry.PartitionName = string.Empty;
                }
                else
                {
                    this.myPitEntry.PartitionName = this.txtPartName.Text;
                }
                if (string.IsNullOrEmpty(this.txtFlashFileName.Text))
                {
                    this.myPitEntry.FlashFileName = string.Empty;
                }
                else
                {
                    this.myPitEntry.FlashFileName = this.txtFlashFileName.Text;
                }
                if (string.IsNullOrEmpty(this.txtFotaFileName.Text))
                {
                    this.myPitEntry.FOTAFileName = string.Empty;
                }
                else
                {
                    this.myPitEntry.FOTAFileName = this.txtFotaFileName.Text;
                }
            }
        }

        private void UpdatePITHeader()
        {
            if (this.myPitData == null)
            {
                this.myPitData = new PitData();
            }
            if (!string.IsNullOrEmpty(this.txtAPVendor.Text))
            {
                this.myPitData.APVendor = this.txtAPVendor.Text;
            }
            else
            {
                this.myPitData.APVendor = string.Empty;
            }
            if (!string.IsNullOrEmpty(this.txtProjectName.Text))
            {
                this.myPitData.ProjectName = this.txtProjectName.Text;
            }
            else
            {
                this.myPitData.ProjectName = string.Empty;
            }
            if (!string.IsNullOrEmpty(this.txtReserved.Text))
            {
                this.myPitData.Reserved = Conversions.ToInteger(this.txtReserved.Text);
            }
            else
            {
                this.myPitData.Reserved = 0;
            }
        }

        internal virtual Button btnCopyClipboard
        {
            get => 
                this._btnCopyClipboard;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnCopyClipboard_Click);
                if (this._btnCopyClipboard != null)
                {
                    this._btnCopyClipboard.Click -= handler;
                }
                this._btnCopyClipboard = value;
                if (this._btnCopyClipboard != null)
                {
                    this._btnCopyClipboard.Click += handler;
                }
            }
        }

        internal virtual Button btnCreatePITEntry
        {
            get => 
                this._btnCreatePITEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnCreatePITEntry_Click);
                if (this._btnCreatePITEntry != null)
                {
                    this._btnCreatePITEntry.Click -= handler;
                }
                this._btnCreatePITEntry = value;
                if (this._btnCreatePITEntry != null)
                {
                    this._btnCreatePITEntry.Click += handler;
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

        internal virtual Button btnExport
        {
            get => 
                this._btnExport;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnExport_Click);
                if (this._btnExport != null)
                {
                    this._btnExport.Click -= handler;
                }
                this._btnExport = value;
                if (this._btnExport != null)
                {
                    this._btnExport.Click += handler;
                }
            }
        }

        internal virtual Button btnNew
        {
            get => 
                this._btnNew;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnNew_Click);
                if (this._btnNew != null)
                {
                    this._btnNew.Click -= handler;
                }
                this._btnNew = value;
                if (this._btnNew != null)
                {
                    this._btnNew.Click += handler;
                }
            }
        }

        internal virtual Button btnOpen
        {
            get => 
                this._btnOpen;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnOpen_Click);
                if (this._btnOpen != null)
                {
                    this._btnOpen.Click -= handler;
                }
                this._btnOpen = value;
                if (this._btnOpen != null)
                {
                    this._btnOpen.Click += handler;
                }
            }
        }

        internal virtual Button btnOpenPITFile
        {
            get => 
                this._btnOpenPITFile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnOpenPITFile_Click);
                if (this._btnOpenPITFile != null)
                {
                    this._btnOpenPITFile.Click -= handler;
                }
                this._btnOpenPITFile = value;
                if (this._btnOpenPITFile != null)
                {
                    this._btnOpenPITFile.Click += handler;
                }
            }
        }

        internal virtual Button btnRemPITEntry
        {
            get => 
                this._btnRemPITEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnRemPITEntry_Click);
                if (this._btnRemPITEntry != null)
                {
                    this._btnRemPITEntry.Click -= handler;
                }
                this._btnRemPITEntry = value;
                if (this._btnRemPITEntry != null)
                {
                    this._btnRemPITEntry.Click += handler;
                }
            }
        }

        internal virtual Button btnResetForm
        {
            get => 
                this._btnResetForm;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnResetForm_Click);
                if (this._btnResetForm != null)
                {
                    this._btnResetForm.Click -= handler;
                }
                this._btnResetForm = value;
                if (this._btnResetForm != null)
                {
                    this._btnResetForm.Click += handler;
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

        internal virtual Button btnSaveAs
        {
            get => 
                this._btnSaveAs;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.btnSaveAs_Click);
                if (this._btnSaveAs != null)
                {
                    this._btnSaveAs.Click -= handler;
                }
                this._btnSaveAs = value;
                if (this._btnSaveAs != null)
                {
                    this._btnSaveAs.Click += handler;
                }
            }
        }

        internal virtual ComboBox cbPITEntries
        {
            get => 
                this._cbPITEntries;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.cbPITEntries_SelectedIndexChanged);
                EventHandler handler2 = new EventHandler(this.cbPITEntries_Click);
                if (this._cbPITEntries != null)
                {
                    this._cbPITEntries.SelectedIndexChanged -= handler;
                    this._cbPITEntries.Click -= handler2;
                }
                this._cbPITEntries = value;
                if (this._cbPITEntries != null)
                {
                    this._cbPITEntries.SelectedIndexChanged += handler;
                    this._cbPITEntries.Click += handler2;
                }
            }
        }

        internal virtual GroupBox gbCurrentPITEntry
        {
            get => 
                this._gbCurrentPITEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbCurrentPITEntry = value;
            }
        }

        internal virtual GroupBox gbHdrSize
        {
            get => 
                this._gbHdrSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbHdrSize = value;
            }
        }

        internal virtual GroupBox gbPITFileHdrInfo
        {
            get => 
                this._gbPITFileHdrInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbPITFileHdrInfo = value;
            }
        }

        internal virtual GroupBox gbPITOps
        {
            get => 
                this._gbPITOps;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._gbPITOps = value;
            }
        }

        internal virtual Label lblAPVendor
        {
            get => 
                this._lblAPVendor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblAPVendor = value;
            }
        }

        internal virtual Label lblAttribStatus
        {
            get => 
                this._lblAttribStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblAttribStatus = value;
            }
        }

        internal virtual Label lblBinTypeStatus
        {
            get => 
                this._lblBinTypeStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblBinTypeStatus = value;
            }
        }

        internal virtual Label lblBlockCount
        {
            get => 
                this._lblBlockCount;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblBlockCount = value;
            }
        }

        internal virtual Label lblBlockSize
        {
            get => 
                this._lblBlockSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblBlockSize = value;
            }
        }

        internal virtual Label lblDeviceType
        {
            get => 
                this._lblDeviceType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDeviceType = value;
            }
        }

        internal virtual Label lblDevTypeStatus
        {
            get => 
                this._lblDevTypeStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDevTypeStatus = value;
            }
        }

        internal virtual Label lblDummyDataTypeMsg
        {
            get => 
                this._lblDummyDataTypeMsg;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblDummyDataTypeMsg = value;
            }
        }

        internal virtual Label lblFileOffset
        {
            get => 
                this._lblFileOffset;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFileOffset = value;
            }
        }

        internal virtual Label lblFileSize
        {
            get => 
                this._lblFileSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFileSize = value;
            }
        }

        internal virtual Label lblFileSystemType
        {
            get => 
                this._lblFileSystemType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFileSystemType = value;
            }
        }

        internal virtual Label lblFlashFileName
        {
            get => 
                this._lblFlashFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFlashFileName = value;
            }
        }

        internal virtual Label lblFotaFileName
        {
            get => 
                this._lblFotaFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblFotaFileName = value;
            }
        }

        internal virtual Label lblHdrMagic
        {
            get => 
                this._lblHdrMagic;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblHdrMagic = value;
            }
        }

        internal virtual Label lblHdrMagicType
        {
            get => 
                this._lblHdrMagicType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblHdrMagicType = value;
            }
        }

        internal virtual Label lblHdrSizeType
        {
            get => 
                this._lblHdrSizeType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblHdrSizeType = value;
            }
        }

        internal virtual Label lblImageType
        {
            get => 
                this._lblImageType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblImageType = value;
            }
        }

        internal virtual Label lblPartitionID
        {
            get => 
                this._lblPartitionID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPartitionID = value;
            }
        }

        internal virtual Label lblPartitionType
        {
            get => 
                this._lblPartitionType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPartitionType = value;
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

        internal virtual Label lblPITEntryCnt
        {
            get => 
                this._lblPITEntryCnt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITEntryCnt = value;
            }
        }

        internal virtual Label lblPITEntryCntType
        {
            get => 
                this._lblPITEntryCntType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITEntryCntType = value;
            }
        }

        internal virtual Label lblPITEntryList
        {
            get => 
                this._lblPITEntryList;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITEntryList = value;
            }
        }

        internal virtual Label lblPITFile
        {
            get => 
                this._lblPITFile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblPITFile = value;
            }
        }

        internal virtual Label lblProjectName
        {
            get => 
                this._lblProjectName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblProjectName = value;
            }
        }

        internal virtual Label lblReserved
        {
            get => 
                this._lblReserved;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblReserved = value;
            }
        }

        internal virtual Label lblUpdAttrStatus
        {
            get => 
                this._lblUpdAttrStatus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._lblUpdAttrStatus = value;
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

        internal virtual NumericUpDown numBlockCount
        {
            get => 
                this._numBlockCount;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._numBlockCount = value;
            }
        }

        internal virtual NumericUpDown numBlockSize
        {
            get => 
                this._numBlockSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._numBlockSize = value;
            }
        }

        internal virtual NumericUpDown numDeviceType
        {
            get => 
                this._numDeviceType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.numDeviceType_ValueChanged);
                if (this._numDeviceType != null)
                {
                    this._numDeviceType.ValueChanged -= handler;
                }
                this._numDeviceType = value;
                if (this._numDeviceType != null)
                {
                    this._numDeviceType.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown numFileOffset
        {
            get => 
                this._numFileOffset;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._numFileOffset = value;
            }
        }

        internal virtual NumericUpDown numFileSize
        {
            get => 
                this._numFileSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._numFileSize = value;
            }
        }

        internal virtual NumericUpDown numFileSystemType
        {
            get => 
                this._numFileSystemType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.numFileSystemType_ValueChanged);
                if (this._numFileSystemType != null)
                {
                    this._numFileSystemType.ValueChanged -= handler;
                }
                this._numFileSystemType = value;
                if (this._numFileSystemType != null)
                {
                    this._numFileSystemType.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown numImageType
        {
            get => 
                this._numImageType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.numImageType_ValueChanged);
                if (this._numImageType != null)
                {
                    this._numImageType.ValueChanged -= handler;
                }
                this._numImageType = value;
                if (this._numImageType != null)
                {
                    this._numImageType.ValueChanged += handler;
                }
            }
        }

        internal virtual NumericUpDown numPartitionID
        {
            get => 
                this._numPartitionID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._numPartitionID = value;
            }
        }

        internal virtual NumericUpDown numPartitionType
        {
            get => 
                this._numPartitionType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.numPartitionType_ValueChanged);
                if (this._numPartitionType != null)
                {
                    this._numPartitionType.ValueChanged -= handler;
                }
                this._numPartitionType = value;
                if (this._numPartitionType != null)
                {
                    this._numPartitionType.ValueChanged += handler;
                }
            }
        }

        internal virtual OpenFileDialog ofdPIT
        {
            get => 
                this._ofdPIT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._ofdPIT = value;
            }
        }

        internal virtual RichTextBox rtAnalysisOutput
        {
            get => 
                this._rtAnalysisOutput;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._rtAnalysisOutput = value;
            }
        }

        internal virtual SaveFileDialog sfdPIT
        {
            get => 
                this._sfdPIT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._sfdPIT = value;
            }
        }

        internal virtual TabPage tabPITFileAnalysis
        {
            get => 
                this._tabPITFileAnalysis;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabPITFileAnalysis = value;
            }
        }

        internal virtual TabPage tabPITFileEditor
        {
            get => 
                this._tabPITFileEditor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tabPITFileEditor = value;
            }
        }

        internal virtual TabControl tcPITLayout
        {
            get => 
                this._tcPITLayout;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._tcPITLayout = value;
            }
        }

        internal virtual Timer TimerIn
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

        internal virtual Timer TimerOut
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

        internal virtual TextBox txtAPVendor
        {
            get => 
                this._txtAPVendor;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtAPVendor_LostFocus);
                if (this._txtAPVendor != null)
                {
                    this._txtAPVendor.LostFocus -= handler;
                }
                this._txtAPVendor = value;
                if (this._txtAPVendor != null)
                {
                    this._txtAPVendor.LostFocus += handler;
                }
            }
        }

        internal virtual TextBox txtFlashFileName
        {
            get => 
                this._txtFlashFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtFlashFileName = value;
            }
        }

        internal virtual TextBox txtFotaFileName
        {
            get => 
                this._txtFotaFileName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtFotaFileName = value;
            }
        }

        internal virtual TextBox txtHdrMagic
        {
            get => 
                this._txtHdrMagic;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtHdrMagic = value;
            }
        }

        internal virtual TextBox txtHdrSize
        {
            get => 
                this._txtHdrSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtHdrSize = value;
            }
        }

        internal virtual TextBox txtPartName
        {
            get => 
                this._txtPartName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtPartName = value;
            }
        }

        internal virtual TextBox txtPITEntryCnt
        {
            get => 
                this._txtPITEntryCnt;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtPITEntryCnt = value;
            }
        }

        internal virtual TextBox txtPITFile
        {
            get => 
                this._txtPITFile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                this._txtPITFile = value;
            }
        }

        internal virtual TextBox txtProjectName
        {
            get => 
                this._txtProjectName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtProjectName_LostFocus);
                if (this._txtProjectName != null)
                {
                    this._txtProjectName.LostFocus -= handler;
                }
                this._txtProjectName = value;
                if (this._txtProjectName != null)
                {
                    this._txtProjectName.LostFocus += handler;
                }
            }
        }

        internal virtual TextBox txtReserved
        {
            get => 
                this._txtReserved;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler handler = new EventHandler(this.txtReserved_LostFocus);
                KeyPressEventHandler handler2 = new KeyPressEventHandler(this.txtReserved_KeyPress);
                if (this._txtReserved != null)
                {
                    this._txtReserved.LostFocus -= handler;
                    this._txtReserved.KeyPress -= handler2;
                }
                this._txtReserved = value;
                if (this._txtReserved != null)
                {
                    this._txtReserved.LostFocus += handler;
                    this._txtReserved.KeyPress += handler2;
                }
            }
        }

        public enum CheckPITStatus
        {
            PIT_Unchanged,
            PIT_Changed,
            PIT_NewFile
        }
    }
}


namespace AcroPlotUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQueue = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctxFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxZoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.fitToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddDitherType = new System.Windows.Forms.ComboBox();
            this.ddOutputDevice = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddOutputFolder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddDPI = new System.Windows.Forms.ComboBox();
            this.cbCrop = new System.Windows.Forms.CheckBox();
            this.nudBrightness = new System.Windows.Forms.NumericUpDown();
            this.nudMinLineWidth = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabJobSetup = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.tabQueue = new System.Windows.Forms.TabPage();
            this.btnClearErrorQueue = new System.Windows.Forms.Button();
            this.cbAutoScroll = new System.Windows.Forms.CheckBox();
            this.btnCancelQueue = new System.Windows.Forms.Button();
            this.btnClearFinishedQueue = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAcroPlotPathBrowse = new System.Windows.Forms.Button();
            this.txtAcroPlotPath = new System.Windows.Forms.TextBox();
            this.cbFontWarningDialog = new System.Windows.Forms.CheckBox();
            this.cbErrorDialog = new System.Windows.Forms.CheckBox();
            this.cbProgressDialog = new System.Windows.Forms.CheckBox();
            this.btnSaveProgramSettings = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMaxAutoRetryCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudProcessStartDelay = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMaxConcurrentProcesses = new System.Windows.Forms.NumericUpDown();
            this.gridJobSetup = new AcroPlotUI.Grid();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PageSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridQueue = new AcroPlotUI.Grid();
            this.QueuePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueuePageNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueJobStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QueueJobTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.ctxFile.SuspendLayout();
            this.ctxZoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLineWidth)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabJobSetup.SuspendLayout();
            this.tabQueue.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAutoRetryCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcessStartDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentProcesses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobSetup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblQueue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(308, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Text = "Checking Files";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblQueue
            // 
            this.lblQueue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblQueue.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(308, 17);
            this.lblQueue.Spring = true;
            this.lblQueue.Text = "Queue";
            this.lblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ctxFile
            // 
            this.ctxFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.ctxFile.Name = "ctxFile";
            this.ctxFile.Size = new System.Drawing.Size(115, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // ctxZoom
            // 
            this.ctxZoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.customToolStripMenuItem,
            this.fitToToolStripMenuItem});
            this.ctxZoom.Name = "ctxZoom";
            this.ctxZoom.Size = new System.Drawing.Size(111, 182);
            this.ctxZoom.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.CtxZoom_Closed);
            this.ctxZoom.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CtxZoom_ItemClicked);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "25";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem3.Text = "50";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem4.Text = "75";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem5.Text = "80";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem6.Text = "100";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem7.Text = "200";
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.customToolStripMenuItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomToolStripMenuItem_KeyDown);
            // 
            // fitToToolStripMenuItem
            // 
            this.fitToToolStripMenuItem.Name = "fitToToolStripMenuItem";
            this.fitToToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.fitToToolStripMenuItem.Text = "Fit to";
            this.fitToToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FitToToolStripMenuItem_DropDownItemClicked);
            // 
            // ddDitherType
            // 
            this.ddDitherType.DisplayMember = "DisplayName";
            this.ddDitherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddDitherType.FormattingEnabled = true;
            this.ddDitherType.Location = new System.Drawing.Point(283, 33);
            this.ddDitherType.Name = "ddDitherType";
            this.ddDitherType.Size = new System.Drawing.Size(247, 21);
            this.ddDitherType.TabIndex = 8;
            // 
            // ddOutputDevice
            // 
            this.ddOutputDevice.DisplayMember = "DisplayName";
            this.ddOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddOutputDevice.FormattingEnabled = true;
            this.ddOutputDevice.Location = new System.Drawing.Point(283, 60);
            this.ddOutputDevice.Name = "ddOutputDevice";
            this.ddOutputDevice.Size = new System.Drawing.Size(247, 21);
            this.ddOutputDevice.TabIndex = 9;
            this.ddOutputDevice.SelectedIndexChanged += new System.EventHandler(this.DdOutputDevice_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dither Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Output File";
            // 
            // ddOutputFolder
            // 
            this.ddOutputFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddOutputFolder.FormattingEnabled = true;
            this.ddOutputFolder.Items.AddRange(new object[] {
            "<Same as file>",
            "<Same as file>\\FULL",
            "<Same as file>\\HALF"});
            this.ddOutputFolder.Location = new System.Drawing.Point(112, 3);
            this.ddOutputFolder.Name = "ddOutputFolder";
            this.ddOutputFolder.Size = new System.Drawing.Size(418, 21);
            this.ddOutputFolder.TabIndex = 12;
            this.ddOutputFolder.SelectedIndexChanged += new System.EventHandler(this.DdOutputFolder_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Output Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Output DPI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Brightness";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Min Line Width (px)";
            // 
            // ddDPI
            // 
            this.ddDPI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddDPI.FormattingEnabled = true;
            this.ddDPI.Items.AddRange(new object[] {
            "150",
            "200",
            "300",
            "400",
            "600"});
            this.ddDPI.Location = new System.Drawing.Point(112, 33);
            this.ddDPI.Name = "ddDPI";
            this.ddDPI.Size = new System.Drawing.Size(58, 21);
            this.ddDPI.TabIndex = 17;
            // 
            // cbCrop
            // 
            this.cbCrop.AutoSize = true;
            this.cbCrop.Location = new System.Drawing.Point(283, 89);
            this.cbCrop.Name = "cbCrop";
            this.cbCrop.Size = new System.Drawing.Size(168, 17);
            this.cbCrop.TabIndex = 20;
            this.cbCrop.Text = "Crop to Remove White Space";
            this.cbCrop.UseVisualStyleBackColor = true;
            // 
            // nudBrightness
            // 
            this.nudBrightness.Location = new System.Drawing.Point(112, 60);
            this.nudBrightness.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudBrightness.Name = "nudBrightness";
            this.nudBrightness.Size = new System.Drawing.Size(58, 20);
            this.nudBrightness.TabIndex = 22;
            // 
            // nudMinLineWidth
            // 
            this.nudMinLineWidth.Location = new System.Drawing.Point(112, 86);
            this.nudMinLineWidth.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMinLineWidth.Name = "nudMinLineWidth";
            this.nudMinLineWidth.Size = new System.Drawing.Size(58, 20);
            this.nudMinLineWidth.TabIndex = 23;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabJobSetup);
            this.tabControl1.Controls.Add(this.tabQueue);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 24);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 420);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 26;
            // 
            // tabJobSetup
            // 
            this.tabJobSetup.Controls.Add(this.label3);
            this.tabJobSetup.Controls.Add(this.ddOutputFolder);
            this.tabJobSetup.Controls.Add(this.ddDPI);
            this.tabJobSetup.Controls.Add(this.nudBrightness);
            this.tabJobSetup.Controls.Add(this.nudMinLineWidth);
            this.tabJobSetup.Controls.Add(this.cbCrop);
            this.tabJobSetup.Controls.Add(this.label2);
            this.tabJobSetup.Controls.Add(this.label4);
            this.tabJobSetup.Controls.Add(this.label1);
            this.tabJobSetup.Controls.Add(this.label5);
            this.tabJobSetup.Controls.Add(this.ddOutputDevice);
            this.tabJobSetup.Controls.Add(this.label6);
            this.tabJobSetup.Controls.Add(this.ddDitherType);
            this.tabJobSetup.Controls.Add(this.btnClear);
            this.tabJobSetup.Controls.Add(this.gridJobSetup);
            this.tabJobSetup.Controls.Add(this.btnProcess);
            this.tabJobSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabJobSetup.Location = new System.Drawing.Point(4, 28);
            this.tabJobSetup.Margin = new System.Windows.Forms.Padding(0);
            this.tabJobSetup.Name = "tabJobSetup";
            this.tabJobSetup.Size = new System.Drawing.Size(623, 388);
            this.tabJobSetup.TabIndex = 0;
            this.tabJobSetup.Text = "Job Setup";
            this.tabJobSetup.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::AcroPlotUI.Properties.Resources.RemoveIcon64;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(11, 112);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Transparent;
            this.btnProcess.BackgroundImage = global::AcroPlotUI.Properties.Resources.ProcessIcon64;
            this.btnProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcess.Location = new System.Drawing.Point(67, 112);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(50, 35);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.BtnProcess_Click);
            // 
            // tabQueue
            // 
            this.tabQueue.Controls.Add(this.btnClearErrorQueue);
            this.tabQueue.Controls.Add(this.cbAutoScroll);
            this.tabQueue.Controls.Add(this.btnCancelQueue);
            this.tabQueue.Controls.Add(this.btnClearFinishedQueue);
            this.tabQueue.Controls.Add(this.gridQueue);
            this.tabQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabQueue.Location = new System.Drawing.Point(4, 28);
            this.tabQueue.Margin = new System.Windows.Forms.Padding(0);
            this.tabQueue.Name = "tabQueue";
            this.tabQueue.Size = new System.Drawing.Size(623, 388);
            this.tabQueue.TabIndex = 1;
            this.tabQueue.Text = "Queue";
            this.tabQueue.UseVisualStyleBackColor = true;
            // 
            // btnClearErrorQueue
            // 
            this.btnClearErrorQueue.Location = new System.Drawing.Point(260, 13);
            this.btnClearErrorQueue.Name = "btnClearErrorQueue";
            this.btnClearErrorQueue.Size = new System.Drawing.Size(120, 32);
            this.btnClearErrorQueue.TabIndex = 4;
            this.btnClearErrorQueue.Text = "Clear Errors";
            this.btnClearErrorQueue.UseVisualStyleBackColor = true;
            this.btnClearErrorQueue.Click += new System.EventHandler(this.BtnClearErrorQueue_Click);
            // 
            // cbAutoScroll
            // 
            this.cbAutoScroll.AutoSize = true;
            this.cbAutoScroll.Checked = true;
            this.cbAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoScroll.Location = new System.Drawing.Point(412, 22);
            this.cbAutoScroll.Name = "cbAutoScroll";
            this.cbAutoScroll.Size = new System.Drawing.Size(77, 17);
            this.cbAutoScroll.TabIndex = 3;
            this.cbAutoScroll.Text = "Auto Scroll";
            this.cbAutoScroll.UseVisualStyleBackColor = true;
            this.cbAutoScroll.CheckedChanged += new System.EventHandler(this.CbAutoScroll_CheckedChanged);
            // 
            // btnCancelQueue
            // 
            this.btnCancelQueue.Location = new System.Drawing.Point(8, 13);
            this.btnCancelQueue.Name = "btnCancelQueue";
            this.btnCancelQueue.Size = new System.Drawing.Size(120, 32);
            this.btnCancelQueue.TabIndex = 1;
            this.btnCancelQueue.Text = "Cancel Queued";
            this.btnCancelQueue.UseVisualStyleBackColor = true;
            this.btnCancelQueue.Click += new System.EventHandler(this.BtnCancelQueue_Click);
            // 
            // btnClearFinishedQueue
            // 
            this.btnClearFinishedQueue.Location = new System.Drawing.Point(134, 13);
            this.btnClearFinishedQueue.Name = "btnClearFinishedQueue";
            this.btnClearFinishedQueue.Size = new System.Drawing.Size(120, 32);
            this.btnClearFinishedQueue.TabIndex = 1;
            this.btnClearFinishedQueue.Text = "Clear Finished";
            this.btnClearFinishedQueue.UseVisualStyleBackColor = true;
            this.btnClearFinishedQueue.Click += new System.EventHandler(this.BtnClearFinishedQueue_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Controls.Add(this.btnSaveProgramSettings);
            this.tabSettings.Controls.Add(this.label9);
            this.tabSettings.Controls.Add(this.nudMaxAutoRetryCount);
            this.tabSettings.Controls.Add(this.label8);
            this.tabSettings.Controls.Add(this.nudProcessStartDelay);
            this.tabSettings.Controls.Add(this.label7);
            this.tabSettings.Controls.Add(this.nudMaxConcurrentProcesses);
            this.tabSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSettings.Location = new System.Drawing.Point(4, 28);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(623, 388);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnAcroPlotPathBrowse);
            this.groupBox1.Controls.Add(this.txtAcroPlotPath);
            this.groupBox1.Controls.Add(this.cbFontWarningDialog);
            this.groupBox1.Controls.Add(this.cbErrorDialog);
            this.groupBox1.Controls.Add(this.cbProgressDialog);
            this.groupBox1.Location = new System.Drawing.Point(8, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AcroPlot Settings";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Path to AcroPlot EXE";
            // 
            // btnAcroPlotPathBrowse
            // 
            this.btnAcroPlotPathBrowse.Location = new System.Drawing.Point(473, 120);
            this.btnAcroPlotPathBrowse.Name = "btnAcroPlotPathBrowse";
            this.btnAcroPlotPathBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnAcroPlotPathBrowse.TabIndex = 4;
            this.btnAcroPlotPathBrowse.Text = "Browse...";
            this.btnAcroPlotPathBrowse.UseVisualStyleBackColor = true;
            this.btnAcroPlotPathBrowse.Click += new System.EventHandler(this.BtnAcroPlotPathBrowse_Click);
            // 
            // txtAcroPlotPath
            // 
            this.txtAcroPlotPath.Location = new System.Drawing.Point(6, 123);
            this.txtAcroPlotPath.Name = "txtAcroPlotPath";
            this.txtAcroPlotPath.Size = new System.Drawing.Size(461, 20);
            this.txtAcroPlotPath.TabIndex = 3;
            // 
            // cbFontWarningDialog
            // 
            this.cbFontWarningDialog.AutoSize = true;
            this.cbFontWarningDialog.Location = new System.Drawing.Point(6, 19);
            this.cbFontWarningDialog.Name = "cbFontWarningDialog";
            this.cbFontWarningDialog.Size = new System.Drawing.Size(196, 17);
            this.cbFontWarningDialog.TabIndex = 0;
            this.cbFontWarningDialog.Text = "Show AcroPlot Font Warning Dialog";
            this.cbFontWarningDialog.UseVisualStyleBackColor = true;
            // 
            // cbErrorDialog
            // 
            this.cbErrorDialog.AutoSize = true;
            this.cbErrorDialog.Location = new System.Drawing.Point(6, 42);
            this.cbErrorDialog.Name = "cbErrorDialog";
            this.cbErrorDialog.Size = new System.Drawing.Size(154, 17);
            this.cbErrorDialog.TabIndex = 1;
            this.cbErrorDialog.Text = "Show AcroPlot Error Dialog";
            this.cbErrorDialog.UseVisualStyleBackColor = true;
            // 
            // cbProgressDialog
            // 
            this.cbProgressDialog.AutoSize = true;
            this.cbProgressDialog.Location = new System.Drawing.Point(6, 65);
            this.cbProgressDialog.Name = "cbProgressDialog";
            this.cbProgressDialog.Size = new System.Drawing.Size(173, 17);
            this.cbProgressDialog.TabIndex = 2;
            this.cbProgressDialog.Text = "Show AcroPlot Progress Dialog";
            this.cbProgressDialog.UseVisualStyleBackColor = true;
            // 
            // btnSaveProgramSettings
            // 
            this.btnSaveProgramSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveProgramSettings.Location = new System.Drawing.Point(8, 342);
            this.btnSaveProgramSettings.Name = "btnSaveProgramSettings";
            this.btnSaveProgramSettings.Size = new System.Drawing.Size(123, 31);
            this.btnSaveProgramSettings.TabIndex = 9;
            this.btnSaveProgramSettings.Text = "Save Settings";
            this.btnSaveProgramSettings.UseVisualStyleBackColor = true;
            this.btnSaveProgramSettings.Click += new System.EventHandler(this.BtnSaveProgramSettings_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Max. Auto. Retry Failed Conversion";
            // 
            // nudMaxAutoRetryCount
            // 
            this.nudMaxAutoRetryCount.Location = new System.Drawing.Point(8, 88);
            this.nudMaxAutoRetryCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMaxAutoRetryCount.Name = "nudMaxAutoRetryCount";
            this.nudMaxAutoRetryCount.Size = new System.Drawing.Size(53, 20);
            this.nudMaxAutoRetryCount.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Process Start Delay (ms)";
            // 
            // nudProcessStartDelay
            // 
            this.nudProcessStartDelay.Location = new System.Drawing.Point(8, 62);
            this.nudProcessStartDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProcessStartDelay.Name = "nudProcessStartDelay";
            this.nudProcessStartDelay.Size = new System.Drawing.Size(53, 20);
            this.nudProcessStartDelay.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Max. Concurrent Processes";
            // 
            // nudMaxConcurrentProcesses
            // 
            this.nudMaxConcurrentProcesses.Location = new System.Drawing.Point(8, 36);
            this.nudMaxConcurrentProcesses.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudMaxConcurrentProcesses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMaxConcurrentProcesses.Name = "nudMaxConcurrentProcesses";
            this.nudMaxConcurrentProcesses.Size = new System.Drawing.Size(53, 20);
            this.nudMaxConcurrentProcesses.TabIndex = 3;
            this.nudMaxConcurrentProcesses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gridJobSetup
            // 
            this.gridJobSetup.AllowUserToAddRows = false;
            this.gridJobSetup.AllowUserToDeleteRows = false;
            this.gridJobSetup.AllowUserToResizeRows = false;
            this.gridJobSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridJobSetup.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridJobSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridJobSetup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FilePath,
            this.FileName,
            this.PageNum,
            this.PageSize,
            this.Zoom,
            this.OutputSize,
            this.OutputFolder,
            this.OutputFile});
            this.gridJobSetup.Location = new System.Drawing.Point(0, 153);
            this.gridJobSetup.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.gridJobSetup.Name = "gridJobSetup";
            this.gridJobSetup.ReadOnly = true;
            this.gridJobSetup.RowHeadersVisible = false;
            this.gridJobSetup.RowTemplate.Height = 18;
            this.gridJobSetup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridJobSetup.Size = new System.Drawing.Size(616, 235);
            this.gridJobSetup.TabIndex = 5;
            this.gridJobSetup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.JobGrid_MouseDown);
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "Path";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FilePath.Width = 200;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FileName.Width = 200;
            // 
            // PageNum
            // 
            this.PageNum.FillWeight = 25F;
            this.PageNum.HeaderText = "Page";
            this.PageNum.Name = "PageNum";
            this.PageNum.ReadOnly = true;
            this.PageNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.PageNum.Width = 50;
            // 
            // PageSize
            // 
            this.PageSize.FillWeight = 25F;
            this.PageSize.HeaderText = "Size";
            this.PageSize.Name = "PageSize";
            this.PageSize.ReadOnly = true;
            this.PageSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Zoom
            // 
            this.Zoom.FillWeight = 25F;
            this.Zoom.HeaderText = "Zoom";
            this.Zoom.Name = "Zoom";
            this.Zoom.ReadOnly = true;
            this.Zoom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Zoom.Width = 50;
            // 
            // OutputSize
            // 
            this.OutputSize.HeaderText = "Output Size";
            this.OutputSize.Name = "OutputSize";
            this.OutputSize.ReadOnly = true;
            this.OutputSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OutputFolder
            // 
            this.OutputFolder.HeaderText = "Output Folder";
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.ReadOnly = true;
            this.OutputFolder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OutputFolder.Width = 200;
            // 
            // OutputFile
            // 
            this.OutputFile.HeaderText = "Output File";
            this.OutputFile.Name = "OutputFile";
            this.OutputFile.ReadOnly = true;
            this.OutputFile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OutputFile.Width = 200;
            // 
            // gridQueue
            // 
            this.gridQueue.AllowUserToAddRows = false;
            this.gridQueue.AllowUserToDeleteRows = false;
            this.gridQueue.AllowUserToResizeRows = false;
            this.gridQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QueuePath,
            this.QueueFilename,
            this.QueuePageNum,
            this.QueueJobStatus,
            this.QueueJobTime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridQueue.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridQueue.Location = new System.Drawing.Point(0, 51);
            this.gridQueue.Margin = new System.Windows.Forms.Padding(0);
            this.gridQueue.Name = "gridQueue";
            this.gridQueue.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridQueue.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridQueue.RowHeadersVisible = false;
            this.gridQueue.RowTemplate.Height = 18;
            this.gridQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridQueue.Size = new System.Drawing.Size(616, 337);
            this.gridQueue.TabIndex = 2;
            // 
            // QueuePath
            // 
            this.QueuePath.HeaderText = "Path";
            this.QueuePath.Name = "QueuePath";
            this.QueuePath.ReadOnly = true;
            this.QueuePath.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.QueuePath.Width = 200;
            // 
            // QueueFilename
            // 
            this.QueueFilename.HeaderText = "Filename";
            this.QueueFilename.Name = "QueueFilename";
            this.QueueFilename.ReadOnly = true;
            this.QueueFilename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.QueueFilename.Width = 200;
            // 
            // QueuePageNum
            // 
            this.QueuePageNum.HeaderText = "Page";
            this.QueuePageNum.Name = "QueuePageNum";
            this.QueuePageNum.ReadOnly = true;
            this.QueuePageNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // QueueJobStatus
            // 
            this.QueueJobStatus.HeaderText = "Status";
            this.QueueJobStatus.Name = "QueueJobStatus";
            this.QueueJobStatus.ReadOnly = true;
            this.QueueJobStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // QueueJobTime
            // 
            this.QueueJobTime.HeaderText = "Time";
            this.QueueJobTime.Name = "QueueJobTime";
            this.QueueJobTime.ReadOnly = true;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 442);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.Text = "AcroPlot UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ctxFile.ResumeLayout(false);
            this.ctxZoom.ResumeLayout(false);
            this.ctxZoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinLineWidth)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabJobSetup.ResumeLayout(false);
            this.tabJobSetup.PerformLayout();
            this.tabQueue.ResumeLayout(false);
            this.tabQueue.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxAutoRetryCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProcessStartDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxConcurrentProcesses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobSetup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProcess;
        private Grid gridJobSetup;
        private System.Windows.Forms.ContextMenuStrip ctxFile;
        private System.Windows.Forms.ContextMenuStrip ctxZoom;
        private System.Windows.Forms.ComboBox ddDitherType;
        private System.Windows.Forms.ComboBox ddOutputDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddOutputFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddDPI;
        private System.Windows.Forms.CheckBox cbCrop;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PageSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputFile;
        private System.Windows.Forms.ToolStripTextBox customToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudBrightness;
        private System.Windows.Forms.NumericUpDown nudMinLineWidth;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabJobSetup;
        private System.Windows.Forms.TabPage tabQueue;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMaxConcurrentProcesses;
        private System.Windows.Forms.CheckBox cbProgressDialog;
        private System.Windows.Forms.CheckBox cbErrorDialog;
        private System.Windows.Forms.CheckBox cbFontWarningDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMaxAutoRetryCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudProcessStartDelay;
        private System.Windows.Forms.Button btnCancelQueue;
        private Grid gridQueue;
        private System.Windows.Forms.Button btnSaveProgramSettings;
        private System.Windows.Forms.Button btnClearFinishedQueue;
        private System.Windows.Forms.CheckBox cbAutoScroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueuePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueueFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueuePageNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueueJobStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn QueueJobTime;
        private System.Windows.Forms.ToolStripStatusLabel lblQueue;
        private System.Windows.Forms.Button btnClearErrorQueue;
        private System.Windows.Forms.ToolStripMenuItem fitToToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAcroPlotPathBrowse;
        private System.Windows.Forms.TextBox txtAcroPlotPath;
    }
}


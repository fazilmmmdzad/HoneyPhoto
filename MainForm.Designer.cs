namespace HoneyPhoto
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnlHeader = new Panel();
            lblFileName = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            minimizeToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            btnClose = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            btnExport = new Button();
            btnInfo = new Button();
            btnRefresh = new Button();
            btnFlip = new Button();
            btnRotateLeft = new Button();
            btnSaveFile = new Button();
            btnOpenFile = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            toolTip = new ToolTip(components);
            panel9 = new Panel();
            panel14 = new Panel();
            label3 = new Label();
            btnApplyResize = new Button();
            label4 = new Label();
            nudHeight = new NumericUpDown();
            btnDownResizePanel = new Button();
            label5 = new Label();
            nudWidth = new NumericUpDown();
            panel11 = new Panel();
            panel15 = new Panel();
            label2 = new Label();
            btnConvert = new Button();
            label6 = new Label();
            cmbFileType = new ComboBox();
            btnDownConvertToPanel = new Button();
            panel10 = new Panel();
            pictureBox = new PictureBox();
            panel12 = new Panel();
            lblStatus = new Label();
            lblType = new Label();
            lblFileSize = new Label();
            lblSize = new Label();
            panel13 = new Panel();
            pnlExportTo = new Panel();
            panel16 = new Panel();
            btnOutlook = new Button();
            btnWord = new Button();
            btnFileExplorer = new Button();
            btnPhotos = new Button();
            btnPaint = new Button();
            btnClipboard = new Button();
            btnPDF = new Button();
            btnPowerPoint = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
            panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).BeginInit();
            panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            pnlExportTo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(209, 0, 31);
            pnlHeader.Controls.Add(lblFileName);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Controls.Add(btnExit);
            pnlHeader.Location = new Point(1, 1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(998, 46);
            pnlHeader.TabIndex = 0;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFileName.ForeColor = Color.White;
            lblFileName.Location = new Point(160, 11);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(91, 23);
            lblFileName.TabIndex = 2;
            lblFileName.Text = "l FileName";
            lblFileName.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 11);
            label1.Name = "label1";
            label1.Size = new Size(112, 23);
            label1.TabIndex = 2;
            label1.Text = "Honey Photo";
            // 
            // pictureBox1
            // 
            pictureBox1.ContextMenuStrip = contextMenuStrip1;
            pictureBox1.Image = Properties.Resources.Logo_removebg_preview;
            pictureBox1.Location = new Point(5, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { minimizeToolStripMenuItem, closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(115, 52);
            // 
            // minimizeToolStripMenuItem
            // 
            minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            minimizeToolStripMenuItem.Size = new Size(114, 24);
            minimizeToolStripMenuItem.Text = "Minimize";
            minimizeToolStripMenuItem.Click += minimizeToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(114, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 0, 20);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 15, 50);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(906, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(46, 46);
            btnClose.TabIndex = 1;
            btnClose.Text = "─";
            toolTip.SetToolTip(btnClose, "Minimize");
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnExit
            // 
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 0, 20);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(240, 15, 50);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(952, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(46, 46);
            btnExit.TabIndex = 1;
            btnExit.Text = "✕";
            toolTip.SetToolTip(btnExit, "Close");
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(btnInfo);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnFlip);
            panel2.Controls.Add(btnRotateLeft);
            panel2.Controls.Add(btnSaveFile);
            panel2.Controls.Add(btnOpenFile);
            panel2.Location = new Point(1, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 55);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Location = new Point(318, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 40);
            panel1.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gray;
            panel8.Location = new Point(236, 6);
            panel8.Name = "panel8";
            panel8.Size = new Size(2, 40);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Gray;
            panel7.Location = new Point(112, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(2, 40);
            panel7.TabIndex = 1;
            // 
            // btnExport
            // 
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Image = Properties.Resources.share;
            btnExport.Location = new Point(947, 8);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(40, 40);
            btnExport.TabIndex = 0;
            toolTip.SetToolTip(btnExport, "Export To (Ctrl + E)");
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Image = Properties.Resources.info;
            btnInfo.Location = new Point(341, 6);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(40, 40);
            btnInfo.TabIndex = 0;
            toolTip.SetToolTip(btnInfo, "Information (Ctrl + I)");
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Image = Properties.Resources.repeat;
            btnRefresh.Location = new Point(254, 6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(40, 40);
            btnRefresh.TabIndex = 0;
            toolTip.SetToolTip(btnRefresh, "Refresh (Ctrl + R)");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnFlip
            // 
            btnFlip.FlatAppearance.BorderSize = 0;
            btnFlip.FlatStyle = FlatStyle.Flat;
            btnFlip.Image = Properties.Resources.mirror_horizontally;
            btnFlip.Location = new Point(179, 6);
            btnFlip.Name = "btnFlip";
            btnFlip.Size = new Size(40, 40);
            btnFlip.TabIndex = 0;
            toolTip.SetToolTip(btnFlip, "Flip (Ctrl + F)");
            btnFlip.UseVisualStyleBackColor = true;
            btnFlip.Click += btnFlip_Click;
            // 
            // btnRotateLeft
            // 
            btnRotateLeft.FlatAppearance.BorderSize = 0;
            btnRotateLeft.FlatStyle = FlatStyle.Flat;
            btnRotateLeft.Image = Properties.Resources.rotate_left;
            btnRotateLeft.Location = new Point(130, 6);
            btnRotateLeft.Name = "btnRotateLeft";
            btnRotateLeft.Size = new Size(40, 40);
            btnRotateLeft.TabIndex = 0;
            toolTip.SetToolTip(btnRotateLeft, "Rotate Left (Ctrl + L)");
            btnRotateLeft.UseVisualStyleBackColor = true;
            btnRotateLeft.Click += btnRotateLeft_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.FlatAppearance.BorderSize = 0;
            btnSaveFile.FlatStyle = FlatStyle.Flat;
            btnSaveFile.Image = Properties.Resources.diskette;
            btnSaveFile.Location = new Point(57, 6);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(40, 40);
            btnSaveFile.TabIndex = 0;
            toolTip.SetToolTip(btnSaveFile, "Save File (Ctrl + S)");
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.FlatAppearance.BorderSize = 0;
            btnOpenFile.FlatStyle = FlatStyle.Flat;
            btnOpenFile.Image = (Image)resources.GetObject("btnOpenFile.Image");
            btnOpenFile.Location = new Point(11, 6);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(40, 40);
            btnOpenFile.TabIndex = 0;
            toolTip.SetToolTip(btnOpenFile, "Open File (Ctrl + O)");
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1, 650);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Location = new Point(999, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1, 650);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 1);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(64, 64, 64);
            panel6.Location = new Point(0, 649);
            panel6.Name = "panel6";
            panel6.Size = new Size(1000, 1);
            panel6.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ControlLight;
            panel9.Controls.Add(panel14);
            panel9.Controls.Add(panel15);
            panel9.Location = new Point(1, 101);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 502);
            panel9.TabIndex = 3;
            // 
            // panel14
            // 
            panel14.Controls.Add(label3);
            panel14.Controls.Add(btnApplyResize);
            panel14.Controls.Add(label4);
            panel14.Controls.Add(nudHeight);
            panel14.Controls.Add(btnDownResizePanel);
            panel14.Controls.Add(label5);
            panel14.Controls.Add(nudWidth);
            panel14.Controls.Add(panel11);
            panel14.Location = new Point(25, 177);
            panel14.Name = "panel14";
            panel14.Size = new Size(200, 177);
            panel14.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(34, 34, 34);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 2;
            label3.Text = "Resize";
            label3.Click += btnDownResizePanel_Click;
            // 
            // btnApplyResize
            // 
            btnApplyResize.FlatAppearance.BorderSize = 0;
            btnApplyResize.FlatStyle = FlatStyle.Flat;
            btnApplyResize.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApplyResize.ForeColor = Color.FromArgb(34, 34, 34);
            btnApplyResize.Image = (Image)resources.GetObject("btnApplyResize.Image");
            btnApplyResize.ImageAlign = ContentAlignment.MiddleRight;
            btnApplyResize.Location = new Point(110, 131);
            btnApplyResize.Name = "btnApplyResize";
            btnApplyResize.Size = new Size(86, 28);
            btnApplyResize.TabIndex = 6;
            btnApplyResize.Text = "Resize";
            btnApplyResize.TextAlign = ContentAlignment.MiddleLeft;
            btnApplyResize.UseVisualStyleBackColor = true;
            btnApplyResize.Click += btnApplyResize_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(34, 34, 34);
            label4.Location = new Point(16, 41);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 2;
            label4.Text = "Width";
            // 
            // nudHeight
            // 
            nudHeight.BorderStyle = BorderStyle.FixedSingle;
            nudHeight.Location = new Point(107, 79);
            nudHeight.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(82, 27);
            nudHeight.TabIndex = 5;
            // 
            // btnDownResizePanel
            // 
            btnDownResizePanel.FlatAppearance.BorderSize = 0;
            btnDownResizePanel.FlatStyle = FlatStyle.Flat;
            btnDownResizePanel.Image = Properties.Resources.down;
            btnDownResizePanel.Location = new Point(168, 4);
            btnDownResizePanel.Name = "btnDownResizePanel";
            btnDownResizePanel.Size = new Size(28, 14);
            btnDownResizePanel.TabIndex = 0;
            btnDownResizePanel.UseVisualStyleBackColor = true;
            btnDownResizePanel.Click += btnDownResizePanel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(34, 34, 34);
            label5.Location = new Point(14, 81);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 2;
            label5.Text = "Height";
            // 
            // nudWidth
            // 
            nudWidth.BorderStyle = BorderStyle.FixedSingle;
            nudWidth.Location = new Point(107, 39);
            nudWidth.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudWidth.Name = "nudWidth";
            nudWidth.Size = new Size(82, 27);
            nudWidth.TabIndex = 5;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Gray;
            panel11.Location = new Point(0, 173);
            panel11.Name = "panel11";
            panel11.Size = new Size(200, 2);
            panel11.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.Controls.Add(label2);
            panel15.Controls.Add(btnConvert);
            panel15.Controls.Add(label6);
            panel15.Controls.Add(cmbFileType);
            panel15.Controls.Add(btnDownConvertToPanel);
            panel15.Controls.Add(panel10);
            panel15.Location = new Point(25, 29);
            panel15.Name = "panel15";
            panel15.Size = new Size(200, 132);
            panel15.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(34, 34, 34);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 2;
            label2.Text = "Convert To";
            label2.Click += btnDownConvertToPanel_Click;
            // 
            // btnConvert
            // 
            btnConvert.FlatAppearance.BorderSize = 0;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.ForeColor = Color.FromArgb(34, 34, 34);
            btnConvert.Image = (Image)resources.GetObject("btnConvert.Image");
            btnConvert.ImageAlign = ContentAlignment.MiddleRight;
            btnConvert.Location = new Point(91, 80);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(99, 28);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.TextAlign = ContentAlignment.MiddleLeft;
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(34, 34, 34);
            label6.Location = new Point(13, 35);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 2;
            label6.Text = "File Type";
            // 
            // cmbFileType
            // 
            cmbFileType.FormattingEnabled = true;
            cmbFileType.Location = new Point(104, 32);
            cmbFileType.Name = "cmbFileType";
            cmbFileType.Size = new Size(82, 28);
            cmbFileType.TabIndex = 3;
            // 
            // btnDownConvertToPanel
            // 
            btnDownConvertToPanel.FlatAppearance.BorderSize = 0;
            btnDownConvertToPanel.FlatStyle = FlatStyle.Flat;
            btnDownConvertToPanel.Image = Properties.Resources.down;
            btnDownConvertToPanel.Location = new Point(168, 4);
            btnDownConvertToPanel.Name = "btnDownConvertToPanel";
            btnDownConvertToPanel.Size = new Size(28, 14);
            btnDownConvertToPanel.TabIndex = 0;
            btnDownConvertToPanel.UseVisualStyleBackColor = true;
            btnDownConvertToPanel.Click += btnDownConvertToPanel_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Gray;
            panel10.Location = new Point(-1, 127);
            panel10.Name = "panel10";
            panel10.Size = new Size(200, 2);
            panel10.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(749, 502);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Gainsboro;
            panel12.Controls.Add(lblStatus);
            panel12.Controls.Add(lblType);
            panel12.Controls.Add(lblFileSize);
            panel12.Controls.Add(lblSize);
            panel12.Location = new Point(1, 602);
            panel12.Name = "panel12";
            panel12.Size = new Size(998, 47);
            panel12.TabIndex = 4;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.FromArgb(34, 34, 34);
            lblStatus.Location = new Point(11, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Ready";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 9F);
            lblType.ForeColor = Color.FromArgb(34, 34, 34);
            lblType.Location = new Point(117, 14);
            lblType.Name = "lblType";
            lblType.Size = new Size(0, 20);
            lblType.TabIndex = 2;
            // 
            // lblFileSize
            // 
            lblFileSize.AutoSize = true;
            lblFileSize.Font = new Font("Segoe UI", 9F);
            lblFileSize.ForeColor = Color.FromArgb(34, 34, 34);
            lblFileSize.Location = new Point(308, 14);
            lblFileSize.Name = "lblFileSize";
            lblFileSize.Size = new Size(0, 20);
            lblFileSize.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI", 9F);
            lblSize.ForeColor = Color.FromArgb(34, 34, 34);
            lblSize.Location = new Point(188, 14);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(0, 20);
            lblSize.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Controls.Add(pictureBox);
            panel13.Location = new Point(250, 101);
            panel13.Name = "panel13";
            panel13.Size = new Size(749, 502);
            panel13.TabIndex = 6;
            // 
            // pnlExportTo
            // 
            pnlExportTo.BackColor = SystemColors.ControlLight;
            pnlExportTo.BorderStyle = BorderStyle.FixedSingle;
            pnlExportTo.Controls.Add(panel16);
            pnlExportTo.Controls.Add(btnOutlook);
            pnlExportTo.Controls.Add(btnWord);
            pnlExportTo.Controls.Add(btnFileExplorer);
            pnlExportTo.Controls.Add(btnPhotos);
            pnlExportTo.Controls.Add(btnPaint);
            pnlExportTo.Controls.Add(btnClipboard);
            pnlExportTo.Controls.Add(btnPDF);
            pnlExportTo.Controls.Add(btnPowerPoint);
            pnlExportTo.Location = new Point(867, 95);
            pnlExportTo.Name = "pnlExportTo";
            pnlExportTo.Size = new Size(122, 245);
            pnlExportTo.TabIndex = 2;
            pnlExportTo.Visible = false;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Gray;
            panel16.Location = new Point(0, 210);
            panel16.Name = "panel16";
            panel16.Size = new Size(122, 1);
            panel16.TabIndex = 1;
            // 
            // btnOutlook
            // 
            btnOutlook.FlatAppearance.BorderSize = 0;
            btnOutlook.FlatStyle = FlatStyle.Flat;
            btnOutlook.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOutlook.Image = Properties.Resources.outlook;
            btnOutlook.ImageAlign = ContentAlignment.MiddleLeft;
            btnOutlook.Location = new Point(0, 60);
            btnOutlook.Name = "btnOutlook";
            btnOutlook.Size = new Size(122, 30);
            btnOutlook.TabIndex = 0;
            btnOutlook.Text = "Outlook";
            btnOutlook.UseVisualStyleBackColor = true;
            btnOutlook.Click += btnOutlook_Click;
            // 
            // btnWord
            // 
            btnWord.FlatAppearance.BorderSize = 0;
            btnWord.FlatStyle = FlatStyle.Flat;
            btnWord.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWord.Image = Properties.Resources.word;
            btnWord.ImageAlign = ContentAlignment.MiddleLeft;
            btnWord.Location = new Point(0, 30);
            btnWord.Name = "btnWord";
            btnWord.Size = new Size(122, 30);
            btnWord.TabIndex = 0;
            btnWord.Text = "Word";
            btnWord.UseVisualStyleBackColor = true;
            btnWord.Click += btnWord_Click;
            // 
            // btnFileExplorer
            // 
            btnFileExplorer.FlatAppearance.BorderSize = 0;
            btnFileExplorer.FlatStyle = FlatStyle.Flat;
            btnFileExplorer.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFileExplorer.Image = Properties.Resources.file_explorer;
            btnFileExplorer.ImageAlign = ContentAlignment.MiddleLeft;
            btnFileExplorer.Location = new Point(0, 211);
            btnFileExplorer.Name = "btnFileExplorer";
            btnFileExplorer.Size = new Size(122, 30);
            btnFileExplorer.TabIndex = 0;
            btnFileExplorer.Text = "File Explorer";
            btnFileExplorer.TextAlign = ContentAlignment.MiddleRight;
            btnFileExplorer.UseVisualStyleBackColor = true;
            btnFileExplorer.Click += btnFileExplorer_Click;
            // 
            // btnPhotos
            // 
            btnPhotos.FlatAppearance.BorderSize = 0;
            btnPhotos.FlatStyle = FlatStyle.Flat;
            btnPhotos.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPhotos.Image = Properties.Resources.image;
            btnPhotos.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhotos.Location = new Point(0, 180);
            btnPhotos.Name = "btnPhotos";
            btnPhotos.Size = new Size(122, 30);
            btnPhotos.TabIndex = 0;
            btnPhotos.Text = "Photos";
            btnPhotos.UseVisualStyleBackColor = true;
            btnPhotos.Click += btnPhotos_Click;
            // 
            // btnPaint
            // 
            btnPaint.FlatAppearance.BorderSize = 0;
            btnPaint.FlatStyle = FlatStyle.Flat;
            btnPaint.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaint.Image = Properties.Resources.paint_board_and_brush;
            btnPaint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPaint.Location = new Point(0, 150);
            btnPaint.Name = "btnPaint";
            btnPaint.Size = new Size(122, 30);
            btnPaint.TabIndex = 0;
            btnPaint.Text = "Paint";
            btnPaint.UseVisualStyleBackColor = true;
            btnPaint.Click += btnPaint_Click;
            // 
            // btnClipboard
            // 
            btnClipboard.FlatAppearance.BorderSize = 0;
            btnClipboard.FlatStyle = FlatStyle.Flat;
            btnClipboard.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClipboard.Image = Properties.Resources.clipboard;
            btnClipboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnClipboard.Location = new Point(0, 120);
            btnClipboard.Name = "btnClipboard";
            btnClipboard.Size = new Size(122, 30);
            btnClipboard.TabIndex = 0;
            btnClipboard.Text = "Copy";
            btnClipboard.UseVisualStyleBackColor = true;
            btnClipboard.Click += btnClipboard_Click;
            // 
            // btnPDF
            // 
            btnPDF.FlatAppearance.BorderSize = 0;
            btnPDF.FlatStyle = FlatStyle.Flat;
            btnPDF.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPDF.Image = Properties.Resources.pdf_file;
            btnPDF.ImageAlign = ContentAlignment.MiddleLeft;
            btnPDF.Location = new Point(0, 90);
            btnPDF.Name = "btnPDF";
            btnPDF.Size = new Size(122, 30);
            btnPDF.TabIndex = 0;
            btnPDF.Text = "PDF";
            btnPDF.UseVisualStyleBackColor = true;
            btnPDF.Click += btnPDF_Click;
            // 
            // btnPowerPoint
            // 
            btnPowerPoint.FlatAppearance.BorderSize = 0;
            btnPowerPoint.FlatStyle = FlatStyle.Flat;
            btnPowerPoint.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPowerPoint.Image = Properties.Resources.powerpoint;
            btnPowerPoint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPowerPoint.Location = new Point(0, 0);
            btnPowerPoint.Name = "btnPowerPoint";
            btnPowerPoint.Size = new Size(122, 30);
            btnPowerPoint.TabIndex = 0;
            btnPowerPoint.Text = "PowerPoint";
            btnPowerPoint.TextAlign = ContentAlignment.MiddleRight;
            btnPowerPoint.UseVisualStyleBackColor = true;
            btnPowerPoint.Click += btnPowerPoint_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(pnlExportTo);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel9);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Honey Photo";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudWidth).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            pnlExportTo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnExit;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnOpenFile;
        private Button btnRefresh;
        private Button btnFlip;
        private Button btnRotateLeft;
        private Button btnSaveFile;
        private Panel panel7;
        private Panel panel8;
        private ToolTip toolTip;
        private Panel panel9;
        private ComboBox cmbFileType;
        private Label label2;
        private Panel panel10;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private NumericUpDown nudHeight;
        private NumericUpDown nudWidth;
        private Panel panel12;
        private Label lblStatus;
        private Label lblType;
        private Label lblSize;
        private PictureBox pictureBox;
        private Panel panel13;
        private Label lblFileSize;
        private Button btnApplyResize;
        private Button btnConvert;
        private Panel panel11;
        private Panel panel14;
        private Panel panel15;
        private Button btnDownConvertToPanel;
        private Button btnDownResizePanel;
        private Label lblFileName;
        private Button btnExport;
        private Panel pnlExportTo;
        private Button btnPDF;
        private Button btnPowerPoint;
        private Button btnWord;
        private Button btnClipboard;
        private Button btnOutlook;
        private Button btnPhotos;
        private Button btnPaint;
        private Button btnFileExplorer;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem minimizeToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Panel panel1;
        private Button btnInfo;
        private Panel panel16;
    }
}

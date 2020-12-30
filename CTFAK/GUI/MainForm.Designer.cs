﻿namespace CTFAK.GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GameInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageBar = new System.Windows.Forms.ProgressBar();
            this.imageLabel = new System.Windows.Forms.Label();
            this.soundLabel = new System.Windows.Forms.Label();
            this.soundBar = new System.Windows.Forms.ProgressBar();
            this.FolderBTN = new System.Windows.Forms.Button();
            this.soundsButton = new System.Windows.Forms.Button();
            this.imagesButton = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.dumpSortedBtn = new System.Windows.Forms.Button();
            this.ChunkCombo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveChunkBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHexBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.previewFrameBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.musicsButton = new System.Windows.Forms.Button();
            this.musicBar = new System.Windows.Forms.ProgressBar();
            this.musicLabel = new System.Windows.Forms.Label();
            this.SortedProgressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.mfaTab = new System.Windows.Forms.TabPage();
            this.dumpMFAButton = new System.Windows.Forms.Button();
            this.mfaLogBox = new System.Windows.Forms.TextBox();
            this.packDataTab = new System.Windows.Forms.TabPage();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dumpAllPackButton = new System.Windows.Forms.Button();
            this.dumpPackButton = new System.Windows.Forms.Button();
            this.packDataListBox = new System.Windows.Forms.ListBox();
            this.imgViewerTab = new System.Windows.Forms.TabPage();
            this.imageViewerInfo = new System.Windows.Forms.Label();
            this.imageViewerPlayAnim = new System.Windows.Forms.Button();
            this.imageViewPictureBox = new System.Windows.Forms.PictureBox();
            this.imagesTreeView = new System.Windows.Forms.TreeView();
            this.soundViewTab = new System.Windows.Forms.TabPage();
            this.soundList = new System.Windows.Forms.TreeView();
            this.playSoundBtn = new System.Windows.Forms.Button();
            this.cryptKeyTab = new System.Windows.Forms.TabPage();
            this.minusCharButton = new System.Windows.Forms.Button();
            this.plusCharBtn = new System.Windows.Forms.Button();
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.charBox = new System.Windows.Forms.TextBox();
            this.pluginTab = new System.Windows.Forms.TabPage();
            this.pluginLogBox = new System.Windows.Forms.TextBox();
            this.activatePluginBtn = new System.Windows.Forms.Button();
            this.pluginsList = new System.Windows.Forms.ListBox();
            this.packDataDialog = new System.Windows.Forms.SaveFileDialog();
            this.ChunkCombo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.mfaTab.SuspendLayout();
            this.packDataTab.SuspendLayout();
            this.imgViewerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.imageViewPictureBox)).BeginInit();
            this.soundViewTab.SuspendLayout();
            this.cryptKeyTab.SuspendLayout();
            this.pluginTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.button1.Location = new System.Drawing.Point(8, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "fnaf3.exe";
            this.openFileDialog1.Filter = "CTF Executable|*.exe";
            this.openFileDialog1.InitialDirectory = "E:\\";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.Black;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.treeView1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.treeView1.Location = new System.Drawing.Point(649, 8);
            this.treeView1.Margin = new System.Windows.Forms.Padding(0);
            this.treeView1.MaximumSize = new System.Drawing.Size(500, 900);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(286, 460);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_AfterDblClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_RightClick);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(349, 8);
            this.listBox1.Margin = new System.Windows.Forms.Padding(0);
            this.listBox1.MaximumSize = new System.Drawing.Size(300, 50000);
            this.listBox1.MinimumSize = new System.Drawing.Size(180, 234);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 277);
            this.listBox1.TabIndex = 5;
            // 
            // GameInfo
            // 
            this.GameInfo.AutoSize = true;
            this.GameInfo.BackColor = System.Drawing.Color.Transparent;
            this.GameInfo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.GameInfo.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.GameInfo.Location = new System.Drawing.Point(8, 36);
            this.GameInfo.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.GameInfo.Name = "GameInfo";
            this.GameInfo.Size = new System.Drawing.Size(182, 105);
            this.GameInfo.TabIndex = 3;
            this.GameInfo.Text = "GameInfo will appear here\r\nLine2\r\nLine3\r\nLine4\r\nLine5\r\nLine6\r\n\r\n";
            this.GameInfo.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.label1.Location = new System.Drawing.Point(6, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "CTFDumper 0.1.1 Debug";
            // 
            // imageBar
            // 
            this.imageBar.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageBar.BackColor = System.Drawing.Color.Black;
            this.imageBar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.imageBar.Location = new System.Drawing.Point(97, 272);
            this.imageBar.Name = "imageBar";
            this.imageBar.Size = new System.Drawing.Size(126, 24);
            this.imageBar.Step = 2;
            this.imageBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.imageBar.TabIndex = 8;
            this.imageBar.Visible = false;
            // 
            // imageLabel
            // 
            this.imageLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imageLabel.BackColor = System.Drawing.Color.Transparent;
            this.imageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.imageLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.imageLabel.Location = new System.Drawing.Point(229, 272);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(126, 24);
            this.imageLabel.TabIndex = 9;
            this.imageLabel.Text = "0/0";
            this.imageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imageLabel.Visible = false;
            // 
            // soundLabel
            // 
            this.soundLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soundLabel.BackColor = System.Drawing.Color.Black;
            this.soundLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.soundLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.soundLabel.Location = new System.Drawing.Point(229, 320);
            this.soundLabel.Name = "soundLabel";
            this.soundLabel.Size = new System.Drawing.Size(126, 24);
            this.soundLabel.TabIndex = 11;
            this.soundLabel.Text = "0/0";
            this.soundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.soundLabel.Visible = false;
            // 
            // soundBar
            // 
            this.soundBar.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soundBar.BackColor = System.Drawing.Color.Black;
            this.soundBar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.soundBar.Location = new System.Drawing.Point(97, 320);
            this.soundBar.Name = "soundBar";
            this.soundBar.Size = new System.Drawing.Size(126, 23);
            this.soundBar.Step = 2;
            this.soundBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.soundBar.TabIndex = 10;
            this.soundBar.Visible = false;
            // 
            // FolderBTN
            // 
            this.FolderBTN.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FolderBTN.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.FolderBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FolderBTN.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FolderBTN.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.FolderBTN.Location = new System.Drawing.Point(8, 214);
            this.FolderBTN.Name = "FolderBTN";
            this.FolderBTN.Size = new System.Drawing.Size(83, 42);
            this.FolderBTN.TabIndex = 12;
            this.FolderBTN.Text = "Open Dump Folder";
            this.FolderBTN.UseVisualStyleBackColor = false;
            this.FolderBTN.Visible = false;
            this.FolderBTN.Click += new System.EventHandler(this.FolderBTN_Click);
            // 
            // soundsButton
            // 
            this.soundsButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.soundsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.soundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundsButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.soundsButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.soundsButton.Location = new System.Drawing.Point(8, 310);
            this.soundsButton.Name = "soundsButton";
            this.soundsButton.Size = new System.Drawing.Size(83, 42);
            this.soundsButton.TabIndex = 14;
            this.soundsButton.Text = "Dump Sounds";
            this.soundsButton.UseVisualStyleBackColor = false;
            this.soundsButton.Visible = false;
            this.soundsButton.Click += new System.EventHandler(this.soundsButton_Click);
            // 
            // imagesButton
            // 
            this.imagesButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imagesButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.imagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagesButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.imagesButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.imagesButton.Location = new System.Drawing.Point(8, 262);
            this.imagesButton.Name = "imagesButton";
            this.imagesButton.Size = new System.Drawing.Size(83, 42);
            this.imagesButton.TabIndex = 15;
            this.imagesButton.Text = "Dump\r\nImages";
            this.imagesButton.UseVisualStyleBackColor = false;
            this.imagesButton.Visible = false;
            this.imagesButton.Click += new System.EventHandler(this.imagesButton_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.loadingLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.loadingLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.loadingLabel.Location = new System.Drawing.Point(4, 10);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(110, 23);
            this.loadingLabel.TabIndex = 16;
            this.loadingLabel.Text = "Loading...";
            // 
            // dumpSortedBtn
            // 
            this.dumpSortedBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dumpSortedBtn.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dumpSortedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpSortedBtn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dumpSortedBtn.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.dumpSortedBtn.Location = new System.Drawing.Point(8, 406);
            this.dumpSortedBtn.Name = "dumpSortedBtn";
            this.dumpSortedBtn.Size = new System.Drawing.Size(83, 42);
            this.dumpSortedBtn.TabIndex = 19;
            this.dumpSortedBtn.Text = "Dump Sorted";
            this.dumpSortedBtn.UseVisualStyleBackColor = false;
            this.dumpSortedBtn.Visible = false;
            this.dumpSortedBtn.Click += new System.EventHandler(this.dumpSortedBtn_Click);
            // 
            // ChunkCombo
            // 
            this.ChunkCombo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.saveChunkBtn, this.viewHexBtn, this.previewFrameBtn});
            this.ChunkCombo.Name = "Save";
            this.ChunkCombo.Size = new System.Drawing.Size(152, 70);
            this.ChunkCombo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ChunkCombo_ItemSelected);
            // 
            // saveChunkBtn
            // 
            this.saveChunkBtn.Name = "saveChunkBtn";
            this.saveChunkBtn.Size = new System.Drawing.Size(151, 22);
            this.saveChunkBtn.Text = "Save";
            // 
            // viewHexBtn
            // 
            this.viewHexBtn.Name = "viewHexBtn";
            this.viewHexBtn.Size = new System.Drawing.Size(151, 22);
            this.viewHexBtn.Text = "View Hex";
            // 
            // previewFrameBtn
            // 
            this.previewFrameBtn.Name = "previewFrameBtn";
            this.previewFrameBtn.Size = new System.Drawing.Size(151, 22);
            this.previewFrameBtn.Text = "Preview Frame";
            // 
            // musicsButton
            // 
            this.musicsButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musicsButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.musicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicsButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.musicsButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.musicsButton.Location = new System.Drawing.Point(8, 358);
            this.musicsButton.Name = "musicsButton";
            this.musicsButton.Size = new System.Drawing.Size(83, 42);
            this.musicsButton.TabIndex = 21;
            this.musicsButton.Text = "Dump Musics";
            this.musicsButton.UseVisualStyleBackColor = false;
            this.musicsButton.Visible = false;
            this.musicsButton.Click += new System.EventHandler(this.musicsButton_Click);
            // 
            // musicBar
            // 
            this.musicBar.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musicBar.BackColor = System.Drawing.Color.Black;
            this.musicBar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.musicBar.Location = new System.Drawing.Point(97, 368);
            this.musicBar.Name = "musicBar";
            this.musicBar.Size = new System.Drawing.Size(126, 23);
            this.musicBar.Step = 2;
            this.musicBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.musicBar.TabIndex = 22;
            this.musicBar.Visible = false;
            // 
            // musicLabel
            // 
            this.musicLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.musicLabel.BackColor = System.Drawing.Color.Black;
            this.musicLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicLabel.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.musicLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.musicLabel.Location = new System.Drawing.Point(229, 368);
            this.musicLabel.Name = "musicLabel";
            this.musicLabel.Size = new System.Drawing.Size(126, 24);
            this.musicLabel.TabIndex = 23;
            this.musicLabel.Text = "0/0";
            this.musicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.musicLabel.Visible = false;
            // 
            // SortedProgressBar
            // 
            this.SortedProgressBar.Location = new System.Drawing.Point(97, 407);
            this.SortedProgressBar.Name = "SortedProgressBar";
            this.SortedProgressBar.Size = new System.Drawing.Size(209, 41);
            this.SortedProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.SortedProgressBar.TabIndex = 24;
            this.SortedProgressBar.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.mfaTab);
            this.tabControl1.Controls.Add(this.packDataTab);
            this.tabControl1.Controls.Add(this.imgViewerTab);
            this.tabControl1.Controls.Add(this.soundViewTab);
            this.tabControl1.Controls.Add(this.cryptKeyTab);
            this.tabControl1.Controls.Add(this.pluginTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 507);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 25;
            // 
            // mainTab
            // 
            this.mainTab.BackColor = System.Drawing.Color.Black;
            this.mainTab.Controls.Add(this.imagesButton);
            this.mainTab.Controls.Add(this.listBox1);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Controls.Add(this.loadingLabel);
            this.mainTab.Controls.Add(this.button1);
            this.mainTab.Controls.Add(this.SortedProgressBar);
            this.mainTab.Controls.Add(this.imageBar);
            this.mainTab.Controls.Add(this.treeView1);
            this.mainTab.Controls.Add(this.musicLabel);
            this.mainTab.Controls.Add(this.imageLabel);
            this.mainTab.Controls.Add(this.GameInfo);
            this.mainTab.Controls.Add(this.musicBar);
            this.mainTab.Controls.Add(this.soundBar);
            this.mainTab.Controls.Add(this.musicsButton);
            this.mainTab.Controls.Add(this.soundLabel);
            this.mainTab.Controls.Add(this.FolderBTN);
            this.mainTab.Controls.Add(this.dumpSortedBtn);
            this.mainTab.Controls.Add(this.soundsButton);
            this.mainTab.Location = new System.Drawing.Point(4, 24);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(935, 479);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            // 
            // mfaTab
            // 
            this.mfaTab.BackColor = System.Drawing.Color.Black;
            this.mfaTab.Controls.Add(this.dumpMFAButton);
            this.mfaTab.Controls.Add(this.mfaLogBox);
            this.mfaTab.Location = new System.Drawing.Point(4, 24);
            this.mfaTab.Name = "mfaTab";
            this.mfaTab.Size = new System.Drawing.Size(935, 479);
            this.mfaTab.TabIndex = 2;
            this.mfaTab.Text = "MFA Dump";
            // 
            // dumpMFAButton
            // 
            this.dumpMFAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpMFAButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dumpMFAButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dumpMFAButton.Location = new System.Drawing.Point(411, 3);
            this.dumpMFAButton.Name = "dumpMFAButton";
            this.dumpMFAButton.Size = new System.Drawing.Size(103, 61);
            this.dumpMFAButton.TabIndex = 1;
            this.dumpMFAButton.Text = "Dump MFA";
            this.dumpMFAButton.UseVisualStyleBackColor = true;
            this.dumpMFAButton.Click += new System.EventHandler(this.dumpMFAButton_Click);
            // 
            // mfaLogBox
            // 
            this.mfaLogBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.mfaLogBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.mfaLogBox.Location = new System.Drawing.Point(0, 0);
            this.mfaLogBox.MaxLength = 999999999;
            this.mfaLogBox.Multiline = true;
            this.mfaLogBox.Name = "mfaLogBox";
            this.mfaLogBox.ReadOnly = true;
            this.mfaLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mfaLogBox.Size = new System.Drawing.Size(405, 479);
            this.mfaLogBox.TabIndex = 0;
            this.mfaLogBox.Text = "MFA Generation is currently unstable\r\nUSE AT YOUR OWN RISK";
            // 
            // packDataTab
            // 
            this.packDataTab.BackColor = System.Drawing.Color.Black;
            this.packDataTab.Controls.Add(this.infoLabel);
            this.packDataTab.Controls.Add(this.dumpAllPackButton);
            this.packDataTab.Controls.Add(this.dumpPackButton);
            this.packDataTab.Controls.Add(this.packDataListBox);
            this.packDataTab.Location = new System.Drawing.Point(4, 24);
            this.packDataTab.Name = "packDataTab";
            this.packDataTab.Size = new System.Drawing.Size(935, 479);
            this.packDataTab.TabIndex = 4;
            this.packDataTab.Text = "Pack Data";
            // 
            // infoLabel
            // 
            this.infoLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.infoLabel.Location = new System.Drawing.Point(204, 11);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(255, 91);
            this.infoLabel.TabIndex = 7;
            this.infoLabel.Text = "Name: PackFile1.mvx\r\nSize: 5 MB\r\n";
            // 
            // dumpAllPackButton
            // 
            this.dumpAllPackButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dumpAllPackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpAllPackButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dumpAllPackButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.dumpAllPackButton.Location = new System.Drawing.Point(204, 148);
            this.dumpAllPackButton.Name = "dumpAllPackButton";
            this.dumpAllPackButton.Size = new System.Drawing.Size(143, 37);
            this.dumpAllPackButton.TabIndex = 6;
            this.dumpAllPackButton.Text = "Dump All";
            this.dumpAllPackButton.UseVisualStyleBackColor = false;
            this.dumpAllPackButton.Click += new System.EventHandler(this.dumpAllPackButton_Click);
            // 
            // dumpPackButton
            // 
            this.dumpPackButton.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.dumpPackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dumpPackButton.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.dumpPackButton.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.dumpPackButton.Location = new System.Drawing.Point(204, 105);
            this.dumpPackButton.Name = "dumpPackButton";
            this.dumpPackButton.Size = new System.Drawing.Size(143, 37);
            this.dumpPackButton.TabIndex = 5;
            this.dumpPackButton.Text = "Dump";
            this.dumpPackButton.UseVisualStyleBackColor = false;
            this.dumpPackButton.Click += new System.EventHandler(this.dumpPackButton_Click);
            // 
            // packDataListBox
            // 
            this.packDataListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.packDataListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.packDataListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.packDataListBox.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.packDataListBox.FormattingEnabled = true;
            this.packDataListBox.ItemHeight = 15;
            this.packDataListBox.Items.AddRange(new object[] {"PackFile1", "PackFile2", "PackFile3", "PackFile4", "PackFile5", "PackFile6"});
            this.packDataListBox.Location = new System.Drawing.Point(0, 0);
            this.packDataListBox.Name = "packDataListBox";
            this.packDataListBox.Size = new System.Drawing.Size(198, 479);
            this.packDataListBox.TabIndex = 4;
            this.packDataListBox.SelectedIndexChanged += new System.EventHandler(this.packDataListBox_SelectedIndexChanged);
            // 
            // imgViewerTab
            // 
            this.imgViewerTab.BackColor = System.Drawing.Color.DimGray;
            this.imgViewerTab.Controls.Add(this.imageViewerInfo);
            this.imgViewerTab.Controls.Add(this.imageViewerPlayAnim);
            this.imgViewerTab.Controls.Add(this.imageViewPictureBox);
            this.imgViewerTab.Controls.Add(this.imagesTreeView);
            this.imgViewerTab.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.imgViewerTab.Location = new System.Drawing.Point(4, 24);
            this.imgViewerTab.Name = "imgViewerTab";
            this.imgViewerTab.Padding = new System.Windows.Forms.Padding(3);
            this.imgViewerTab.Size = new System.Drawing.Size(935, 479);
            this.imgViewerTab.TabIndex = 1;
            this.imgViewerTab.Text = "Images";
            // 
            // imageViewerInfo
            // 
            this.imageViewerInfo.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageViewerInfo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.imageViewerInfo.Location = new System.Drawing.Point(777, 3);
            this.imageViewerInfo.Name = "imageViewerInfo";
            this.imageViewerInfo.Size = new System.Drawing.Size(155, 63);
            this.imageViewerInfo.TabIndex = 3;
            this.imageViewerInfo.Text = "DEBUG";
            // 
            // imageViewerPlayAnim
            // 
            this.imageViewerPlayAnim.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageViewerPlayAnim.Location = new System.Drawing.Point(203, 441);
            this.imageViewerPlayAnim.Name = "imageViewerPlayAnim";
            this.imageViewerPlayAnim.Size = new System.Drawing.Size(729, 35);
            this.imageViewerPlayAnim.TabIndex = 2;
            this.imageViewerPlayAnim.Text = "Play Animation";
            this.imageViewerPlayAnim.UseVisualStyleBackColor = true;
            this.imageViewerPlayAnim.Click += new System.EventHandler(this.advancedPlayAnimation_Click);
            // 
            // imageViewPictureBox
            // 
            this.imageViewPictureBox.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.imageViewPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewPictureBox.Location = new System.Drawing.Point(203, 3);
            this.imageViewPictureBox.Name = "imageViewPictureBox";
            this.imageViewPictureBox.Size = new System.Drawing.Size(729, 473);
            this.imageViewPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageViewPictureBox.TabIndex = 1;
            this.imageViewPictureBox.TabStop = false;
            // 
            // imagesTreeView
            // 
            this.imagesTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.imagesTreeView.Location = new System.Drawing.Point(3, 3);
            this.imagesTreeView.Name = "imagesTreeView";
            this.imagesTreeView.Size = new System.Drawing.Size(200, 473);
            this.imagesTreeView.TabIndex = 0;
            this.imagesTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.advancedTreeView_AfterSelect);
            // 
            // soundViewTab
            // 
            this.soundViewTab.BackColor = System.Drawing.Color.Black;
            this.soundViewTab.Controls.Add(this.soundList);
            this.soundViewTab.Controls.Add(this.playSoundBtn);
            this.soundViewTab.Location = new System.Drawing.Point(4, 24);
            this.soundViewTab.Name = "soundViewTab";
            this.soundViewTab.Size = new System.Drawing.Size(935, 479);
            this.soundViewTab.TabIndex = 6;
            this.soundViewTab.Text = "Sounds";
            // 
            // soundList
            // 
            this.soundList.Dock = System.Windows.Forms.DockStyle.Left;
            this.soundList.Location = new System.Drawing.Point(0, 0);
            this.soundList.Name = "soundList";
            this.soundList.Size = new System.Drawing.Size(200, 479);
            this.soundList.TabIndex = 1;
            this.soundList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.soundList_AfterSelect);
            // 
            // playSoundBtn
            // 
            this.playSoundBtn.Location = new System.Drawing.Point(209, 3);
            this.playSoundBtn.Name = "playSoundBtn";
            this.playSoundBtn.Size = new System.Drawing.Size(113, 50);
            this.playSoundBtn.TabIndex = 0;
            this.playSoundBtn.Text = "Play Sound";
            this.playSoundBtn.UseVisualStyleBackColor = true;
            this.playSoundBtn.Click += new System.EventHandler(this.playSoundBtn_Click);
            // 
            // cryptKeyTab
            // 
            this.cryptKeyTab.BackColor = System.Drawing.Color.Black;
            this.cryptKeyTab.Controls.Add(this.minusCharButton);
            this.cryptKeyTab.Controls.Add(this.plusCharBtn);
            this.cryptKeyTab.Controls.Add(this.hexBox1);
            this.cryptKeyTab.Controls.Add(this.charBox);
            this.cryptKeyTab.Location = new System.Drawing.Point(4, 24);
            this.cryptKeyTab.Name = "cryptKeyTab";
            this.cryptKeyTab.Size = new System.Drawing.Size(935, 479);
            this.cryptKeyTab.TabIndex = 3;
            this.cryptKeyTab.Text = "CryptoKey";
            // 
            // minusCharButton
            // 
            this.minusCharButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.minusCharButton.Location = new System.Drawing.Point(0, 21);
            this.minusCharButton.Name = "minusCharButton";
            this.minusCharButton.Size = new System.Drawing.Size(20, 458);
            this.minusCharButton.TabIndex = 3;
            this.minusCharButton.Text = "-";
            this.minusCharButton.UseVisualStyleBackColor = true;
            this.minusCharButton.Click += new System.EventHandler(this.minusCharButton_Click);
            // 
            // plusCharBtn
            // 
            this.plusCharBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.plusCharBtn.Location = new System.Drawing.Point(915, 21);
            this.plusCharBtn.Name = "plusCharBtn";
            this.plusCharBtn.Size = new System.Drawing.Size(20, 458);
            this.plusCharBtn.TabIndex = 2;
            this.plusCharBtn.Text = "+";
            this.plusCharBtn.UseVisualStyleBackColor = true;
            this.plusCharBtn.Click += new System.EventHandler(this.plusCharBtn_Click);
            // 
            // hexBox1
            // 
            this.hexBox1.ColumnInfoVisible = true;
            this.hexBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new System.Drawing.Point(0, 21);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int) (((byte) (100)))), ((int) (((byte) (60)))), ((int) (((byte) (188)))), ((int) (((byte) (255)))));
            this.hexBox1.Size = new System.Drawing.Size(935, 458);
            this.hexBox1.StringViewVisible = true;
            this.hexBox1.TabIndex = 1;
            // 
            // charBox
            // 
            this.charBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.charBox.Location = new System.Drawing.Point(0, 0);
            this.charBox.Name = "charBox";
            this.charBox.Size = new System.Drawing.Size(935, 21);
            this.charBox.TabIndex = 0;
            this.charBox.Text = "54";
            this.charBox.TextChanged += new System.EventHandler(this.charBox_TextChanged);
            // 
            // pluginTab
            // 
            this.pluginTab.BackColor = System.Drawing.Color.Black;
            this.pluginTab.Controls.Add(this.pluginLogBox);
            this.pluginTab.Controls.Add(this.activatePluginBtn);
            this.pluginTab.Controls.Add(this.pluginsList);
            this.pluginTab.Location = new System.Drawing.Point(4, 24);
            this.pluginTab.Name = "pluginTab";
            this.pluginTab.Size = new System.Drawing.Size(935, 479);
            this.pluginTab.TabIndex = 5;
            this.pluginTab.Text = "Plugins";
            // 
            // pluginLogBox
            // 
            this.pluginLogBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pluginLogBox.Location = new System.Drawing.Point(530, 0);
            this.pluginLogBox.Multiline = true;
            this.pluginLogBox.Name = "pluginLogBox";
            this.pluginLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.pluginLogBox.Size = new System.Drawing.Size(405, 448);
            this.pluginLogBox.TabIndex = 2;
            // 
            // activatePluginBtn
            // 
            this.activatePluginBtn.AutoSize = true;
            this.activatePluginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.activatePluginBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.activatePluginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activatePluginBtn.Font = new System.Drawing.Font("Feast of Flesh BB", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte) (77)));
            this.activatePluginBtn.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (128)))), ((int) (((byte) (0)))));
            this.activatePluginBtn.Location = new System.Drawing.Point(252, 448);
            this.activatePluginBtn.Name = "activatePluginBtn";
            this.activatePluginBtn.Size = new System.Drawing.Size(683, 31);
            this.activatePluginBtn.TabIndex = 1;
            this.activatePluginBtn.Text = "Activate";
            this.activatePluginBtn.UseVisualStyleBackColor = true;
            this.activatePluginBtn.Click += new System.EventHandler(this.activatePluginBtn_Click);
            // 
            // pluginsList
            // 
            this.pluginsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pluginsList.FormattingEnabled = true;
            this.pluginsList.ItemHeight = 15;
            this.pluginsList.Location = new System.Drawing.Point(0, 0);
            this.pluginsList.Name = "pluginsList";
            this.pluginsList.Size = new System.Drawing.Size(252, 479);
            this.pluginsList.TabIndex = 0;
            // 
            // packDataDialog
            // 
            this.packDataDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.packDataDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(943, 507);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            this.Text = "DotNetCTFDumper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ChunkCombo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.mfaTab.ResumeLayout(false);
            this.mfaTab.PerformLayout();
            this.packDataTab.ResumeLayout(false);
            this.imgViewerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.imageViewPictureBox)).EndInit();
            this.soundViewTab.ResumeLayout(false);
            this.cryptKeyTab.ResumeLayout(false);
            this.cryptKeyTab.PerformLayout();
            this.pluginTab.ResumeLayout(false);
            this.pluginTab.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView soundList;

        private System.Windows.Forms.Button playSoundBtn;

        private System.Windows.Forms.TabPage soundViewTab;

        private System.Windows.Forms.TreeView imagesTreeView;
        private System.Windows.Forms.Button imageViewerPlayAnim;
        private System.Windows.Forms.PictureBox imageViewPictureBox;
        private System.Windows.Forms.TabPage imgViewerTab;

        private System.Windows.Forms.Label imageViewerInfo;

        public System.Windows.Forms.TextBox pluginLogBox;

        private System.Windows.Forms.Button activatePluginBtn;
        private System.Windows.Forms.ListBox pluginsList;

        private System.Windows.Forms.TabPage pluginTab;

        private System.Windows.Forms.Button dumpAllPackButton;
        private System.Windows.Forms.Button dumpPackButton;
        private System.Windows.Forms.SaveFileDialog packDataDialog;
        private System.Windows.Forms.ListBox packDataListBox;

        private System.Windows.Forms.Label infoLabel;

        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage mfaTab;
        private System.Windows.Forms.TabPage packDataTab;

        private System.Windows.Forms.TextBox charBox;

        private System.Windows.Forms.Button minusCharButton;

        private System.Windows.Forms.Button plusCharBtn;

        private Be.Windows.Forms.HexBox hexBox1;

        private System.Windows.Forms.TabPage cryptKeyTab;

        private System.Windows.Forms.TextBox mfaLogBox;

        private System.Windows.Forms.Button dumpMFAButton;

        private System.Windows.Forms.TabControl tabControl1;

        private System.Windows.Forms.ProgressBar SortedProgressBar;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip ChunkCombo;
        private System.Windows.Forms.Button dumpSortedBtn;
        private System.Windows.Forms.Button FolderBTN;
        private System.Windows.Forms.Label GameInfo;
        private System.Windows.Forms.ProgressBar imageBar;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.Button imagesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.ProgressBar musicBar;
        private System.Windows.Forms.Label musicLabel;
        private System.Windows.Forms.Button musicsButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem previewFrameBtn;
        private System.Windows.Forms.ToolStripMenuItem saveChunkBtn;
        private System.Windows.Forms.ProgressBar soundBar;
        private System.Windows.Forms.Label soundLabel;
        private System.Windows.Forms.Button soundsButton;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem viewHexBtn;

        #endregion
    }
}
﻿namespace TerrainGenerator
{
    partial class TerrainGeneratorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerrainGeneratorMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightMapPanel = new System.Windows.Forms.Panel();
            this.heightMapPicture = new System.Windows.Forms.PictureBox();
            this.generateTerrainButton = new System.Windows.Forms.Button();
            this.mapTabs = new System.Windows.Forms.TabControl();
            this.heightMapTab = new System.Windows.Forms.TabPage();
            this.colorMapTab = new System.Windows.Forms.TabPage();
            this.colorMapPanel = new System.Windows.Forms.Panel();
            this.colorMapPicture = new System.Windows.Forms.PictureBox();
            this.waterMapTab = new System.Windows.Forms.TabPage();
            this.waterMapPanel = new System.Windows.Forms.Panel();
            this.waterMapPicture = new System.Windows.Forms.PictureBox();
            this.customMap1Tab = new System.Windows.Forms.TabPage();
            this.customMap1Panel = new System.Windows.Forms.Panel();
            this.customMap1Picture = new System.Windows.Forms.PictureBox();
            this.customMap2Tab = new System.Windows.Forms.TabPage();
            this.customMap2Panel = new System.Windows.Forms.Panel();
            this.customMap2Picture = new System.Windows.Forms.PictureBox();
            this.toolTabs = new System.Windows.Forms.TabControl();
            this.generateTab = new System.Windows.Forms.TabPage();
            this.noisePropBox = new System.Windows.Forms.GroupBox();
            this.yOffsetNum = new System.Windows.Forms.NumericUpDown();
            this.xOffsetNum = new System.Windows.Forms.NumericUpDown();
            this.octavesNum = new System.Windows.Forms.NumericUpDown();
            this.noiseWeightNum = new System.Windows.Forms.NumericUpDown();
            this.muNum = new System.Windows.Forms.NumericUpDown();
            this.persistenceNum = new System.Windows.Forms.NumericUpDown();
            this.lacunarityNum = new System.Windows.Forms.NumericUpDown();
            this.frequencyNum = new System.Windows.Forms.NumericUpDown();
            this.xOffsetLabel = new System.Windows.Forms.Label();
            this.persistenceLabel = new System.Windows.Forms.Label();
            this.yOffsetLabel = new System.Windows.Forms.Label();
            this.slopeDistributionLabel = new System.Windows.Forms.Label();
            this.lacunarityLabel = new System.Windows.Forms.Label();
            this.noiseWeightLabel = new System.Windows.Forms.Label();
            this.octaveLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.mapPropertiesBox = new System.Windows.Forms.GroupBox();
            this.maxAltNum = new System.Windows.Forms.NumericUpDown();
            this.ySizeNum = new System.Windows.Forms.NumericUpDown();
            this.xSizeNum = new System.Windows.Forms.NumericUpDown();
            this.yMapSizeNum = new System.Windows.Forms.NumericUpDown();
            this.xMapSizeNum = new System.Windows.Forms.NumericUpDown();
            this.maxAltLabel = new System.Windows.Forms.Label();
            this.xActualSizeLabel = new System.Windows.Forms.Label();
            this.yActualSizeLabel = new System.Windows.Forms.Label();
            this.xSizeLabel = new System.Windows.Forms.Label();
            this.ySizeLabel = new System.Windows.Forms.Label();
            this.addNoiseButton = new System.Windows.Forms.Button();
            this.importMapButton = new System.Windows.Forms.Button();
            this.erosionTab = new System.Windows.Forms.TabPage();
            this.hydroErosionGroup = new System.Windows.Forms.GroupBox();
            this.hydroErodeRunButton = new System.Windows.Forms.Button();
            this.hydroPassesLabel = new System.Windows.Forms.Label();
            this.timeStepLabel = new System.Windows.Forms.Label();
            this.evapConstLabel = new System.Windows.Forms.Label();
            this.rainAmountLabel = new System.Windows.Forms.Label();
            this.rainChanceLabel = new System.Windows.Forms.Label();
            this.waterCapLabel = new System.Windows.Forms.Label();
            this.depRateLabel = new System.Windows.Forms.Label();
            this.solubilityLabel = new System.Windows.Forms.Label();
            this.hydroPassesNum = new System.Windows.Forms.NumericUpDown();
            this.timeStepNum = new System.Windows.Forms.NumericUpDown();
            this.evapConstNum = new System.Windows.Forms.NumericUpDown();
            this.rainAmountNum = new System.Windows.Forms.NumericUpDown();
            this.rainChanceNum = new System.Windows.Forms.NumericUpDown();
            this.waterCapNum = new System.Windows.Forms.NumericUpDown();
            this.depRateNum = new System.Windows.Forms.NumericUpDown();
            this.solubilityNum = new System.Windows.Forms.NumericUpDown();
            this.thermalErosionGroup = new System.Windows.Forms.GroupBox();
            this.tErodeRunButton = new System.Windows.Forms.Button();
            this.tErodePassLabel = new System.Windows.Forms.Label();
            this.talusAngleLabel = new System.Windows.Forms.Label();
            this.tErodePassNum = new System.Windows.Forms.NumericUpDown();
            this.talusAngleNum = new System.Windows.Forms.NumericUpDown();
            this.textureMapTab = new System.Windows.Forms.TabPage();
            this.saveMapBox = new System.Windows.Forms.GroupBox();
            this.saveMapButton = new System.Windows.Forms.Button();
            this.mapSaveSelect = new System.Windows.Forms.ComboBox();
            this.customMapBox = new System.Windows.Forms.GroupBox();
            this.customMapButton = new System.Windows.Forms.Button();
            this.noiseAmountLabel = new System.Windows.Forms.Label();
            this.maxAltFuzzLabel = new System.Windows.Forms.Label();
            this.splatNoiseAmountNum = new System.Windows.Forms.NumericUpDown();
            this.maxAltFuzzNum = new System.Windows.Forms.NumericUpDown();
            this.maxAltiLabel = new System.Windows.Forms.Label();
            this.minAltFuzzLabel = new System.Windows.Forms.Label();
            this.minAltLabel = new System.Windows.Forms.Label();
            this.maxSlopeFuzzLabel = new System.Windows.Forms.Label();
            this.maxSlopeLabel = new System.Windows.Forms.Label();
            this.minSlopeFuzzLabel = new System.Windows.Forms.Label();
            this.minSlopeLabel = new System.Windows.Forms.Label();
            this.customMapLabel = new System.Windows.Forms.Label();
            this.customMapSelect = new System.Windows.Forms.ComboBox();
            this.maxSplatAltNum = new System.Windows.Forms.NumericUpDown();
            this.minAltFuzzNum = new System.Windows.Forms.NumericUpDown();
            this.minAltNum = new System.Windows.Forms.NumericUpDown();
            this.maxSlopeFuzzNum = new System.Windows.Forms.NumericUpDown();
            this.maxSlopeNum = new System.Windows.Forms.NumericUpDown();
            this.minSlopeFuzzNum = new System.Windows.Forms.NumericUpDown();
            this.minSlopeNum = new System.Windows.Forms.NumericUpDown();
            this.colorMapGroup = new System.Windows.Forms.GroupBox();
            this.importTexSample = new System.Windows.Forms.Button();
            this.texSamplePicture = new System.Windows.Forms.PictureBox();
            this.importMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.generalTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.importTexSampleDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveHeightMapDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveBmpDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.heightMapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightMapPicture)).BeginInit();
            this.mapTabs.SuspendLayout();
            this.heightMapTab.SuspendLayout();
            this.colorMapTab.SuspendLayout();
            this.colorMapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorMapPicture)).BeginInit();
            this.waterMapTab.SuspendLayout();
            this.waterMapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterMapPicture)).BeginInit();
            this.customMap1Tab.SuspendLayout();
            this.customMap1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customMap1Picture)).BeginInit();
            this.customMap2Tab.SuspendLayout();
            this.customMap2Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customMap2Picture)).BeginInit();
            this.toolTabs.SuspendLayout();
            this.generateTab.SuspendLayout();
            this.noisePropBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octavesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseWeightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persistenceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lacunarityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNum)).BeginInit();
            this.mapPropertiesBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAltNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMapSizeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMapSizeNum)).BeginInit();
            this.erosionTab.SuspendLayout();
            this.hydroErosionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hydroPassesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStepNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evapConstNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainAmountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainChanceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterCapNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depRateNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solubilityNum)).BeginInit();
            this.thermalErosionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tErodePassNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talusAngleNum)).BeginInit();
            this.textureMapTab.SuspendLayout();
            this.saveMapBox.SuspendLayout();
            this.customMapBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splatNoiseAmountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAltFuzzNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSplatAltNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAltFuzzNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAltNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSlopeFuzzNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSlopeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSlopeFuzzNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSlopeNum)).BeginInit();
            this.colorMapGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.texSamplePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.aboutMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            this.fileMenu.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.ShortcutKeyDisplayString = "";
            this.quitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quitMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitMenuItem.Text = "&Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(44, 20);
            this.aboutMenu.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(201, 22);
            this.aboutMenuItem.Text = "About Terrain Generator";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // heightMapPanel
            // 
            this.heightMapPanel.AutoScroll = true;
            this.heightMapPanel.Controls.Add(this.heightMapPicture);
            this.heightMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightMapPanel.Location = new System.Drawing.Point(0, 0);
            this.heightMapPanel.Name = "heightMapPanel";
            this.heightMapPanel.Size = new System.Drawing.Size(507, 545);
            this.heightMapPanel.TabIndex = 1;
            // 
            // heightMapPicture
            // 
            this.heightMapPicture.Location = new System.Drawing.Point(0, 0);
            this.heightMapPicture.Margin = new System.Windows.Forms.Padding(0);
            this.heightMapPicture.Name = "heightMapPicture";
            this.heightMapPicture.Size = new System.Drawing.Size(100, 50);
            this.heightMapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.heightMapPicture.TabIndex = 3;
            this.heightMapPicture.TabStop = false;
            // 
            // generateTerrainButton
            // 
            this.generateTerrainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generateTerrainButton.Location = new System.Drawing.Point(37, 487);
            this.generateTerrainButton.Name = "generateTerrainButton";
            this.generateTerrainButton.Size = new System.Drawing.Size(103, 23);
            this.generateTerrainButton.TabIndex = 18;
            this.generateTerrainButton.Text = "Generate Terrain";
            this.generalTooltip.SetToolTip(this.generateTerrainButton, "Generate new terrain, overwriting any existing terrain.");
            this.generateTerrainButton.UseVisualStyleBackColor = true;
            this.generateTerrainButton.Click += new System.EventHandler(this.generateTerrainButton_Click);
            // 
            // mapTabs
            // 
            this.mapTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapTabs.Controls.Add(this.heightMapTab);
            this.mapTabs.Controls.Add(this.colorMapTab);
            this.mapTabs.Controls.Add(this.waterMapTab);
            this.mapTabs.Controls.Add(this.customMap1Tab);
            this.mapTabs.Controls.Add(this.customMap2Tab);
            this.mapTabs.Location = new System.Drawing.Point(13, 28);
            this.mapTabs.Name = "mapTabs";
            this.mapTabs.SelectedIndex = 0;
            this.mapTabs.Size = new System.Drawing.Size(515, 571);
            this.mapTabs.TabIndex = 0;
            // 
            // heightMapTab
            // 
            this.heightMapTab.Controls.Add(this.heightMapPanel);
            this.heightMapTab.Location = new System.Drawing.Point(4, 22);
            this.heightMapTab.Name = "heightMapTab";
            this.heightMapTab.Size = new System.Drawing.Size(507, 545);
            this.heightMapTab.TabIndex = 0;
            this.heightMapTab.Text = "Height";
            this.heightMapTab.UseVisualStyleBackColor = true;
            // 
            // colorMapTab
            // 
            this.colorMapTab.Controls.Add(this.colorMapPanel);
            this.colorMapTab.Location = new System.Drawing.Point(4, 22);
            this.colorMapTab.Name = "colorMapTab";
            this.colorMapTab.Size = new System.Drawing.Size(507, 545);
            this.colorMapTab.TabIndex = 1;
            this.colorMapTab.Text = "Color";
            this.colorMapTab.UseVisualStyleBackColor = true;
            // 
            // colorMapPanel
            // 
            this.colorMapPanel.AutoScroll = true;
            this.colorMapPanel.Controls.Add(this.colorMapPicture);
            this.colorMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorMapPanel.Location = new System.Drawing.Point(0, 0);
            this.colorMapPanel.Name = "colorMapPanel";
            this.colorMapPanel.Size = new System.Drawing.Size(507, 545);
            this.colorMapPanel.TabIndex = 0;
            // 
            // colorMapPicture
            // 
            this.colorMapPicture.Location = new System.Drawing.Point(0, 0);
            this.colorMapPicture.Margin = new System.Windows.Forms.Padding(0);
            this.colorMapPicture.Name = "colorMapPicture";
            this.colorMapPicture.Size = new System.Drawing.Size(100, 50);
            this.colorMapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colorMapPicture.TabIndex = 0;
            this.colorMapPicture.TabStop = false;
            // 
            // waterMapTab
            // 
            this.waterMapTab.Controls.Add(this.waterMapPanel);
            this.waterMapTab.Location = new System.Drawing.Point(4, 22);
            this.waterMapTab.Name = "waterMapTab";
            this.waterMapTab.Size = new System.Drawing.Size(507, 545);
            this.waterMapTab.TabIndex = 2;
            this.waterMapTab.Text = "Water";
            this.waterMapTab.UseVisualStyleBackColor = true;
            // 
            // waterMapPanel
            // 
            this.waterMapPanel.AutoScroll = true;
            this.waterMapPanel.Controls.Add(this.waterMapPicture);
            this.waterMapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterMapPanel.Location = new System.Drawing.Point(0, 0);
            this.waterMapPanel.Name = "waterMapPanel";
            this.waterMapPanel.Size = new System.Drawing.Size(507, 545);
            this.waterMapPanel.TabIndex = 1;
            // 
            // waterMapPicture
            // 
            this.waterMapPicture.Location = new System.Drawing.Point(0, 0);
            this.waterMapPicture.Margin = new System.Windows.Forms.Padding(0);
            this.waterMapPicture.Name = "waterMapPicture";
            this.waterMapPicture.Size = new System.Drawing.Size(100, 50);
            this.waterMapPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.waterMapPicture.TabIndex = 0;
            this.waterMapPicture.TabStop = false;
            // 
            // customMap1Tab
            // 
            this.customMap1Tab.Controls.Add(this.customMap1Panel);
            this.customMap1Tab.Location = new System.Drawing.Point(4, 22);
            this.customMap1Tab.Name = "customMap1Tab";
            this.customMap1Tab.Size = new System.Drawing.Size(507, 545);
            this.customMap1Tab.TabIndex = 3;
            this.customMap1Tab.Text = "Custom 1";
            this.customMap1Tab.UseVisualStyleBackColor = true;
            // 
            // customMap1Panel
            // 
            this.customMap1Panel.AutoScroll = true;
            this.customMap1Panel.Controls.Add(this.customMap1Picture);
            this.customMap1Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customMap1Panel.Location = new System.Drawing.Point(0, 0);
            this.customMap1Panel.Name = "customMap1Panel";
            this.customMap1Panel.Size = new System.Drawing.Size(507, 545);
            this.customMap1Panel.TabIndex = 1;
            // 
            // customMap1Picture
            // 
            this.customMap1Picture.Location = new System.Drawing.Point(0, 0);
            this.customMap1Picture.Margin = new System.Windows.Forms.Padding(0);
            this.customMap1Picture.Name = "customMap1Picture";
            this.customMap1Picture.Size = new System.Drawing.Size(100, 50);
            this.customMap1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.customMap1Picture.TabIndex = 0;
            this.customMap1Picture.TabStop = false;
            // 
            // customMap2Tab
            // 
            this.customMap2Tab.Controls.Add(this.customMap2Panel);
            this.customMap2Tab.Location = new System.Drawing.Point(4, 22);
            this.customMap2Tab.Name = "customMap2Tab";
            this.customMap2Tab.Size = new System.Drawing.Size(507, 545);
            this.customMap2Tab.TabIndex = 4;
            this.customMap2Tab.Text = "Custom 2";
            this.customMap2Tab.UseVisualStyleBackColor = true;
            // 
            // customMap2Panel
            // 
            this.customMap2Panel.AutoScroll = true;
            this.customMap2Panel.Controls.Add(this.customMap2Picture);
            this.customMap2Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customMap2Panel.Location = new System.Drawing.Point(0, 0);
            this.customMap2Panel.Name = "customMap2Panel";
            this.customMap2Panel.Size = new System.Drawing.Size(507, 545);
            this.customMap2Panel.TabIndex = 1;
            // 
            // customMap2Picture
            // 
            this.customMap2Picture.Location = new System.Drawing.Point(0, 0);
            this.customMap2Picture.Margin = new System.Windows.Forms.Padding(0);
            this.customMap2Picture.Name = "customMap2Picture";
            this.customMap2Picture.Size = new System.Drawing.Size(100, 50);
            this.customMap2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.customMap2Picture.TabIndex = 0;
            this.customMap2Picture.TabStop = false;
            // 
            // toolTabs
            // 
            this.toolTabs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolTabs.Controls.Add(this.generateTab);
            this.toolTabs.Controls.Add(this.erosionTab);
            this.toolTabs.Controls.Add(this.textureMapTab);
            this.toolTabs.Location = new System.Drawing.Point(534, 28);
            this.toolTabs.Multiline = true;
            this.toolTabs.Name = "toolTabs";
            this.toolTabs.SelectedIndex = 0;
            this.toolTabs.Size = new System.Drawing.Size(188, 571);
            this.toolTabs.TabIndex = 2;
            // 
            // generateTab
            // 
            this.generateTab.Controls.Add(this.noisePropBox);
            this.generateTab.Controls.Add(this.mapPropertiesBox);
            this.generateTab.Controls.Add(this.addNoiseButton);
            this.generateTab.Controls.Add(this.importMapButton);
            this.generateTab.Controls.Add(this.generateTerrainButton);
            this.generateTab.Location = new System.Drawing.Point(4, 22);
            this.generateTab.Name = "generateTab";
            this.generateTab.Padding = new System.Windows.Forms.Padding(3);
            this.generateTab.Size = new System.Drawing.Size(180, 545);
            this.generateTab.TabIndex = 0;
            this.generateTab.Text = "Generate";
            this.generateTab.UseVisualStyleBackColor = true;
            // 
            // noisePropBox
            // 
            this.noisePropBox.Controls.Add(this.yOffsetNum);
            this.noisePropBox.Controls.Add(this.xOffsetNum);
            this.noisePropBox.Controls.Add(this.octavesNum);
            this.noisePropBox.Controls.Add(this.noiseWeightNum);
            this.noisePropBox.Controls.Add(this.muNum);
            this.noisePropBox.Controls.Add(this.persistenceNum);
            this.noisePropBox.Controls.Add(this.lacunarityNum);
            this.noisePropBox.Controls.Add(this.frequencyNum);
            this.noisePropBox.Controls.Add(this.xOffsetLabel);
            this.noisePropBox.Controls.Add(this.persistenceLabel);
            this.noisePropBox.Controls.Add(this.yOffsetLabel);
            this.noisePropBox.Controls.Add(this.slopeDistributionLabel);
            this.noisePropBox.Controls.Add(this.lacunarityLabel);
            this.noisePropBox.Controls.Add(this.noiseWeightLabel);
            this.noisePropBox.Controls.Add(this.octaveLabel);
            this.noisePropBox.Controls.Add(this.frequencyLabel);
            this.noisePropBox.Location = new System.Drawing.Point(6, 144);
            this.noisePropBox.Name = "noisePropBox";
            this.noisePropBox.Size = new System.Drawing.Size(168, 228);
            this.noisePropBox.TabIndex = 2;
            this.noisePropBox.TabStop = false;
            this.noisePropBox.Text = "Noise Generator Properties";
            // 
            // yOffsetNum
            // 
            this.yOffsetNum.DecimalPlaces = 2;
            this.yOffsetNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.yOffsetNum.Location = new System.Drawing.Point(89, 32);
            this.yOffsetNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.yOffsetNum.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147352576});
            this.yOffsetNum.Name = "yOffsetNum";
            this.yOffsetNum.Size = new System.Drawing.Size(74, 20);
            this.yOffsetNum.TabIndex = 9;
            this.yOffsetNum.ThousandsSeparator = true;
            // 
            // xOffsetNum
            // 
            this.xOffsetNum.DecimalPlaces = 2;
            this.xOffsetNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.xOffsetNum.Location = new System.Drawing.Point(9, 32);
            this.xOffsetNum.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            131072});
            this.xOffsetNum.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147352576});
            this.xOffsetNum.Name = "xOffsetNum";
            this.xOffsetNum.Size = new System.Drawing.Size(74, 20);
            this.xOffsetNum.TabIndex = 8;
            this.xOffsetNum.ThousandsSeparator = true;
            // 
            // octavesNum
            // 
            this.octavesNum.Location = new System.Drawing.Point(88, 92);
            this.octavesNum.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.octavesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.octavesNum.Name = "octavesNum";
            this.octavesNum.Size = new System.Drawing.Size(74, 20);
            this.octavesNum.TabIndex = 11;
            this.octavesNum.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // noiseWeightNum
            // 
            this.noiseWeightNum.DecimalPlaces = 3;
            this.noiseWeightNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.noiseWeightNum.Location = new System.Drawing.Point(88, 196);
            this.noiseWeightNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noiseWeightNum.Name = "noiseWeightNum";
            this.noiseWeightNum.Size = new System.Drawing.Size(74, 20);
            this.noiseWeightNum.TabIndex = 16;
            this.noiseWeightNum.ThousandsSeparator = true;
            this.noiseWeightNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // muNum
            // 
            this.muNum.DecimalPlaces = 4;
            this.muNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.muNum.Location = new System.Drawing.Point(88, 170);
            this.muNum.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            65536});
            this.muNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.muNum.Name = "muNum";
            this.muNum.Size = new System.Drawing.Size(74, 20);
            this.muNum.TabIndex = 15;
            this.muNum.ThousandsSeparator = true;
            this.muNum.Value = new decimal(new int[] {
            1005,
            0,
            0,
            196608});
            // 
            // persistenceNum
            // 
            this.persistenceNum.DecimalPlaces = 3;
            this.persistenceNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.persistenceNum.Location = new System.Drawing.Point(89, 144);
            this.persistenceNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.persistenceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.persistenceNum.Name = "persistenceNum";
            this.persistenceNum.Size = new System.Drawing.Size(74, 20);
            this.persistenceNum.TabIndex = 14;
            this.persistenceNum.ThousandsSeparator = true;
            this.persistenceNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lacunarityNum
            // 
            this.lacunarityNum.DecimalPlaces = 2;
            this.lacunarityNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.lacunarityNum.Location = new System.Drawing.Point(88, 118);
            this.lacunarityNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lacunarityNum.Minimum = new decimal(new int[] {
            101,
            0,
            0,
            131072});
            this.lacunarityNum.Name = "lacunarityNum";
            this.lacunarityNum.Size = new System.Drawing.Size(74, 20);
            this.lacunarityNum.TabIndex = 13;
            this.lacunarityNum.ThousandsSeparator = true;
            this.lacunarityNum.Value = new decimal(new int[] {
            19,
            0,
            0,
            65536});
            // 
            // frequencyNum
            // 
            this.frequencyNum.DecimalPlaces = 2;
            this.frequencyNum.Location = new System.Drawing.Point(88, 66);
            this.frequencyNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencyNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frequencyNum.Name = "frequencyNum";
            this.frequencyNum.Size = new System.Drawing.Size(74, 20);
            this.frequencyNum.TabIndex = 10;
            this.frequencyNum.ThousandsSeparator = true;
            this.frequencyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xOffsetLabel
            // 
            this.xOffsetLabel.AutoSize = true;
            this.xOffsetLabel.Location = new System.Drawing.Point(6, 16);
            this.xOffsetLabel.Name = "xOffsetLabel";
            this.xOffsetLabel.Size = new System.Drawing.Size(45, 13);
            this.xOffsetLabel.TabIndex = 3;
            this.xOffsetLabel.Text = "X Offset";
            this.generalTooltip.SetToolTip(this.xOffsetLabel, "X & Y Offset act as the seed for the random noise generation.");
            // 
            // persistenceLabel
            // 
            this.persistenceLabel.AutoSize = true;
            this.persistenceLabel.Location = new System.Drawing.Point(6, 146);
            this.persistenceLabel.Margin = new System.Windows.Forms.Padding(3);
            this.persistenceLabel.Name = "persistenceLabel";
            this.persistenceLabel.Size = new System.Drawing.Size(62, 13);
            this.persistenceLabel.TabIndex = 10;
            this.persistenceLabel.Text = "Persistence";
            this.generalTooltip.SetToolTip(this.persistenceLabel, "Persistence multiplies the amplitude of each successive octave of noise.");
            // 
            // yOffsetLabel
            // 
            this.yOffsetLabel.AutoSize = true;
            this.yOffsetLabel.Location = new System.Drawing.Point(97, 16);
            this.yOffsetLabel.Name = "yOffsetLabel";
            this.yOffsetLabel.Size = new System.Drawing.Size(45, 13);
            this.yOffsetLabel.TabIndex = 4;
            this.yOffsetLabel.Text = "Y Offset";
            this.generalTooltip.SetToolTip(this.yOffsetLabel, "X & Y Offset act as the seed for the random noise generation.");
            // 
            // slopeDistributionLabel
            // 
            this.slopeDistributionLabel.AutoSize = true;
            this.slopeDistributionLabel.Location = new System.Drawing.Point(6, 172);
            this.slopeDistributionLabel.Margin = new System.Windows.Forms.Padding(3);
            this.slopeDistributionLabel.Name = "slopeDistributionLabel";
            this.slopeDistributionLabel.Size = new System.Drawing.Size(78, 13);
            this.slopeDistributionLabel.TabIndex = 11;
            this.slopeDistributionLabel.Text = "Slope Variation";
            this.generalTooltip.SetToolTip(this.slopeDistributionLabel, "Slope distribution determines the variation in the landscape. 1.0 is an even dist" +
        "ribution, higher numbers result in more varied landscape. Values higher than ~ 1" +
        ".015 result in odd terrains.");
            // 
            // lacunarityLabel
            // 
            this.lacunarityLabel.AutoSize = true;
            this.lacunarityLabel.Location = new System.Drawing.Point(6, 120);
            this.lacunarityLabel.Margin = new System.Windows.Forms.Padding(3);
            this.lacunarityLabel.Name = "lacunarityLabel";
            this.lacunarityLabel.Size = new System.Drawing.Size(56, 13);
            this.lacunarityLabel.TabIndex = 9;
            this.lacunarityLabel.Text = "Lacunarity";
            this.generalTooltip.SetToolTip(this.lacunarityLabel, "Lacunarity multiplies the frequency of each successive octave of noise.");
            // 
            // noiseWeightLabel
            // 
            this.noiseWeightLabel.AutoSize = true;
            this.noiseWeightLabel.Location = new System.Drawing.Point(6, 198);
            this.noiseWeightLabel.Margin = new System.Windows.Forms.Padding(3);
            this.noiseWeightLabel.Name = "noiseWeightLabel";
            this.noiseWeightLabel.Size = new System.Drawing.Size(71, 13);
            this.noiseWeightLabel.TabIndex = 12;
            this.noiseWeightLabel.Text = "Noise Weight";
            this.generalTooltip.SetToolTip(this.noiseWeightLabel, "Noise weight determines the amount of noise applied by the Add Noise command.");
            // 
            // octaveLabel
            // 
            this.octaveLabel.AutoSize = true;
            this.octaveLabel.Location = new System.Drawing.Point(6, 94);
            this.octaveLabel.Margin = new System.Windows.Forms.Padding(3);
            this.octaveLabel.Name = "octaveLabel";
            this.octaveLabel.Size = new System.Drawing.Size(47, 13);
            this.octaveLabel.TabIndex = 8;
            this.octaveLabel.Text = "Octaves";
            this.generalTooltip.SetToolTip(this.octaveLabel, "Octaves are the number of noise passes to layer when generating terrain.");
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 68);
            this.frequencyLabel.Margin = new System.Windows.Forms.Padding(3);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.frequencyLabel.TabIndex = 7;
            this.frequencyLabel.Text = "Frequency";
            this.generalTooltip.SetToolTip(this.frequencyLabel, resources.GetString("frequencyLabel.ToolTip"));
            // 
            // mapPropertiesBox
            // 
            this.mapPropertiesBox.Controls.Add(this.maxAltNum);
            this.mapPropertiesBox.Controls.Add(this.ySizeNum);
            this.mapPropertiesBox.Controls.Add(this.xSizeNum);
            this.mapPropertiesBox.Controls.Add(this.yMapSizeNum);
            this.mapPropertiesBox.Controls.Add(this.xMapSizeNum);
            this.mapPropertiesBox.Controls.Add(this.maxAltLabel);
            this.mapPropertiesBox.Controls.Add(this.xActualSizeLabel);
            this.mapPropertiesBox.Controls.Add(this.yActualSizeLabel);
            this.mapPropertiesBox.Controls.Add(this.xSizeLabel);
            this.mapPropertiesBox.Controls.Add(this.ySizeLabel);
            this.mapPropertiesBox.Location = new System.Drawing.Point(6, 6);
            this.mapPropertiesBox.Name = "mapPropertiesBox";
            this.mapPropertiesBox.Size = new System.Drawing.Size(168, 132);
            this.mapPropertiesBox.TabIndex = 1;
            this.mapPropertiesBox.TabStop = false;
            this.mapPropertiesBox.Text = "Map Properties";
            // 
            // maxAltNum
            // 
            this.maxAltNum.DecimalPlaces = 2;
            this.maxAltNum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxAltNum.Location = new System.Drawing.Point(88, 100);
            this.maxAltNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.maxAltNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxAltNum.Name = "maxAltNum";
            this.maxAltNum.Size = new System.Drawing.Size(74, 20);
            this.maxAltNum.TabIndex = 7;
            this.maxAltNum.ThousandsSeparator = true;
            this.maxAltNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // ySizeNum
            // 
            this.ySizeNum.Location = new System.Drawing.Point(89, 32);
            this.ySizeNum.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.ySizeNum.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.ySizeNum.Name = "ySizeNum";
            this.ySizeNum.Size = new System.Drawing.Size(74, 20);
            this.ySizeNum.TabIndex = 4;
            this.ySizeNum.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // xSizeNum
            // 
            this.xSizeNum.Location = new System.Drawing.Point(9, 32);
            this.xSizeNum.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.xSizeNum.Minimum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.xSizeNum.Name = "xSizeNum";
            this.xSizeNum.Size = new System.Drawing.Size(74, 20);
            this.xSizeNum.TabIndex = 3;
            this.xSizeNum.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // yMapSizeNum
            // 
            this.yMapSizeNum.DecimalPlaces = 2;
            this.yMapSizeNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yMapSizeNum.Location = new System.Drawing.Point(89, 71);
            this.yMapSizeNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.yMapSizeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yMapSizeNum.Name = "yMapSizeNum";
            this.yMapSizeNum.Size = new System.Drawing.Size(74, 20);
            this.yMapSizeNum.TabIndex = 6;
            this.yMapSizeNum.ThousandsSeparator = true;
            this.yMapSizeNum.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // xMapSizeNum
            // 
            this.xMapSizeNum.DecimalPlaces = 2;
            this.xMapSizeNum.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.xMapSizeNum.Location = new System.Drawing.Point(9, 71);
            this.xMapSizeNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.xMapSizeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xMapSizeNum.Name = "xMapSizeNum";
            this.xMapSizeNum.Size = new System.Drawing.Size(74, 20);
            this.xMapSizeNum.TabIndex = 5;
            this.xMapSizeNum.ThousandsSeparator = true;
            this.xMapSizeNum.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // maxAltLabel
            // 
            this.maxAltLabel.AutoSize = true;
            this.maxAltLabel.Location = new System.Drawing.Point(8, 102);
            this.maxAltLabel.Name = "maxAltLabel";
            this.maxAltLabel.Size = new System.Drawing.Size(65, 13);
            this.maxAltLabel.TabIndex = 27;
            this.maxAltLabel.Text = "Max Altitude";
            this.generalTooltip.SetToolTip(this.maxAltLabel, "Max Altitude determines the maximum altitude, in meters, of the generated heightm" +
        "ap.");
            // 
            // xActualSizeLabel
            // 
            this.xActualSizeLabel.AutoSize = true;
            this.xActualSizeLabel.Location = new System.Drawing.Point(6, 55);
            this.xActualSizeLabel.Name = "xActualSizeLabel";
            this.xActualSizeLabel.Size = new System.Drawing.Size(61, 13);
            this.xActualSizeLabel.TabIndex = 23;
            this.xActualSizeLabel.Text = "X Map Size";
            this.generalTooltip.SetToolTip(this.xActualSizeLabel, "X & Y map size determine the real world size of the generated map, in meters.");
            // 
            // yActualSizeLabel
            // 
            this.yActualSizeLabel.AutoSize = true;
            this.yActualSizeLabel.Location = new System.Drawing.Point(86, 55);
            this.yActualSizeLabel.Name = "yActualSizeLabel";
            this.yActualSizeLabel.Size = new System.Drawing.Size(61, 13);
            this.yActualSizeLabel.TabIndex = 24;
            this.yActualSizeLabel.Text = "Y Map Size";
            this.generalTooltip.SetToolTip(this.yActualSizeLabel, "X & Y map size determine the real world size of the generated map, in meters.");
            // 
            // xSizeLabel
            // 
            this.xSizeLabel.AutoSize = true;
            this.xSizeLabel.Location = new System.Drawing.Point(6, 16);
            this.xSizeLabel.Name = "xSizeLabel";
            this.xSizeLabel.Size = new System.Drawing.Size(67, 13);
            this.xSizeLabel.TabIndex = 19;
            this.xSizeLabel.Text = "X Resolution";
            this.generalTooltip.SetToolTip(this.xSizeLabel, "X & Y Resolution determine the size, in pixels, of the generated heightmap.");
            // 
            // ySizeLabel
            // 
            this.ySizeLabel.AutoSize = true;
            this.ySizeLabel.Location = new System.Drawing.Point(86, 16);
            this.ySizeLabel.Name = "ySizeLabel";
            this.ySizeLabel.Size = new System.Drawing.Size(67, 13);
            this.ySizeLabel.TabIndex = 20;
            this.ySizeLabel.Text = "Y Resolution";
            this.generalTooltip.SetToolTip(this.ySizeLabel, "X & Y Resolution determine the size, in pixels, of the generated heightmap.");
            // 
            // addNoiseButton
            // 
            this.addNoiseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addNoiseButton.Location = new System.Drawing.Point(37, 516);
            this.addNoiseButton.Name = "addNoiseButton";
            this.addNoiseButton.Size = new System.Drawing.Size(103, 23);
            this.addNoiseButton.TabIndex = 19;
            this.addNoiseButton.Text = "Add Noise";
            this.generalTooltip.SetToolTip(this.addNoiseButton, "Add noise, mixed with the existing terrain.");
            this.addNoiseButton.UseVisualStyleBackColor = true;
            this.addNoiseButton.Click += new System.EventHandler(this.addNoiseButton_Click);
            // 
            // importMapButton
            // 
            this.importMapButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.importMapButton.Location = new System.Drawing.Point(37, 458);
            this.importMapButton.Name = "importMapButton";
            this.importMapButton.Size = new System.Drawing.Size(103, 23);
            this.importMapButton.TabIndex = 17;
            this.importMapButton.Text = "Import Map";
            this.generalTooltip.SetToolTip(this.importMapButton, "Import a BMP or 16-bit grayscale TIFF.\r\n");
            this.importMapButton.UseVisualStyleBackColor = true;
            this.importMapButton.Click += new System.EventHandler(this.importMapButton_Click);
            // 
            // erosionTab
            // 
            this.erosionTab.Controls.Add(this.hydroErosionGroup);
            this.erosionTab.Controls.Add(this.thermalErosionGroup);
            this.erosionTab.Location = new System.Drawing.Point(4, 22);
            this.erosionTab.Name = "erosionTab";
            this.erosionTab.Padding = new System.Windows.Forms.Padding(3);
            this.erosionTab.Size = new System.Drawing.Size(180, 545);
            this.erosionTab.TabIndex = 1;
            this.erosionTab.Text = "Erosion";
            this.erosionTab.UseVisualStyleBackColor = true;
            // 
            // hydroErosionGroup
            // 
            this.hydroErosionGroup.Controls.Add(this.hydroErodeRunButton);
            this.hydroErosionGroup.Controls.Add(this.hydroPassesLabel);
            this.hydroErosionGroup.Controls.Add(this.timeStepLabel);
            this.hydroErosionGroup.Controls.Add(this.evapConstLabel);
            this.hydroErosionGroup.Controls.Add(this.rainAmountLabel);
            this.hydroErosionGroup.Controls.Add(this.rainChanceLabel);
            this.hydroErosionGroup.Controls.Add(this.waterCapLabel);
            this.hydroErosionGroup.Controls.Add(this.depRateLabel);
            this.hydroErosionGroup.Controls.Add(this.solubilityLabel);
            this.hydroErosionGroup.Controls.Add(this.hydroPassesNum);
            this.hydroErosionGroup.Controls.Add(this.timeStepNum);
            this.hydroErosionGroup.Controls.Add(this.evapConstNum);
            this.hydroErosionGroup.Controls.Add(this.rainAmountNum);
            this.hydroErosionGroup.Controls.Add(this.rainChanceNum);
            this.hydroErosionGroup.Controls.Add(this.waterCapNum);
            this.hydroErosionGroup.Controls.Add(this.depRateNum);
            this.hydroErosionGroup.Controls.Add(this.solubilityNum);
            this.hydroErosionGroup.Location = new System.Drawing.Point(6, 124);
            this.hydroErosionGroup.Name = "hydroErosionGroup";
            this.hydroErosionGroup.Size = new System.Drawing.Size(168, 270);
            this.hydroErosionGroup.TabIndex = 1;
            this.hydroErosionGroup.TabStop = false;
            this.hydroErosionGroup.Text = "Hydraulic Erosion";
            // 
            // hydroErodeRunButton
            // 
            this.hydroErodeRunButton.Location = new System.Drawing.Point(45, 231);
            this.hydroErodeRunButton.Name = "hydroErodeRunButton";
            this.hydroErodeRunButton.Size = new System.Drawing.Size(75, 23);
            this.hydroErodeRunButton.TabIndex = 31;
            this.hydroErodeRunButton.Text = "Run";
            this.generalTooltip.SetToolTip(this.hydroErodeRunButton, "Execute Hydraulic Erosion.");
            this.hydroErodeRunButton.UseVisualStyleBackColor = true;
            this.hydroErodeRunButton.Click += new System.EventHandler(this.hydroErodeRunButton_Click);
            // 
            // hydroPassesLabel
            // 
            this.hydroPassesLabel.AutoSize = true;
            this.hydroPassesLabel.Location = new System.Drawing.Point(6, 203);
            this.hydroPassesLabel.Name = "hydroPassesLabel";
            this.hydroPassesLabel.Size = new System.Drawing.Size(41, 13);
            this.hydroPassesLabel.TabIndex = 48;
            this.hydroPassesLabel.Text = "Passes";
            this.generalTooltip.SetToolTip(this.hydroPassesLabel, "Number of passes to execute.");
            // 
            // timeStepLabel
            // 
            this.timeStepLabel.AutoSize = true;
            this.timeStepLabel.Location = new System.Drawing.Point(6, 177);
            this.timeStepLabel.Name = "timeStepLabel";
            this.timeStepLabel.Size = new System.Drawing.Size(55, 13);
            this.timeStepLabel.TabIndex = 47;
            this.timeStepLabel.Text = "Time Step";
            this.generalTooltip.SetToolTip(this.timeStepLabel, "Time step is the amount of time to simulate per pass, in seconds.");
            // 
            // evapConstLabel
            // 
            this.evapConstLabel.AutoSize = true;
            this.evapConstLabel.Location = new System.Drawing.Point(6, 151);
            this.evapConstLabel.Name = "evapConstLabel";
            this.evapConstLabel.Size = new System.Drawing.Size(64, 13);
            this.evapConstLabel.TabIndex = 46;
            this.evapConstLabel.Text = "Evaporation";
            this.generalTooltip.SetToolTip(this.evapConstLabel, "Evaporation is the amount of water that is removed from each pixel on each pass.");
            // 
            // rainAmountLabel
            // 
            this.rainAmountLabel.AutoSize = true;
            this.rainAmountLabel.Location = new System.Drawing.Point(6, 125);
            this.rainAmountLabel.Name = "rainAmountLabel";
            this.rainAmountLabel.Size = new System.Drawing.Size(68, 13);
            this.rainAmountLabel.TabIndex = 45;
            this.rainAmountLabel.Text = "Rain Amount";
            this.generalTooltip.SetToolTip(this.rainAmountLabel, "Rain amount is the amount of water to be added to a pixel on the map when rain oc" +
        "curs.");
            // 
            // rainChanceLabel
            // 
            this.rainChanceLabel.AutoSize = true;
            this.rainChanceLabel.Location = new System.Drawing.Point(6, 99);
            this.rainChanceLabel.Name = "rainChanceLabel";
            this.rainChanceLabel.Size = new System.Drawing.Size(69, 13);
            this.rainChanceLabel.TabIndex = 44;
            this.rainChanceLabel.Text = "Rain Chance";
            this.generalTooltip.SetToolTip(this.rainChanceLabel, "Rain chance is the chance, per pixel, per pass, that rain will be generated.");
            // 
            // waterCapLabel
            // 
            this.waterCapLabel.AutoSize = true;
            this.waterCapLabel.Location = new System.Drawing.Point(6, 73);
            this.waterCapLabel.Name = "waterCapLabel";
            this.waterCapLabel.Size = new System.Drawing.Size(80, 13);
            this.waterCapLabel.TabIndex = 43;
            this.waterCapLabel.Text = "Water Capacity";
            this.generalTooltip.SetToolTip(this.waterCapLabel, "Water Capacity is the total amount of sediment water may carry.");
            // 
            // depRateLabel
            // 
            this.depRateLabel.AutoSize = true;
            this.depRateLabel.Location = new System.Drawing.Point(6, 47);
            this.depRateLabel.Name = "depRateLabel";
            this.depRateLabel.Size = new System.Drawing.Size(69, 13);
            this.depRateLabel.TabIndex = 42;
            this.depRateLabel.Text = "Deposit Rate";
            this.generalTooltip.SetToolTip(this.depRateLabel, "Deposit rate is the amount of material that may be deposited in a single pass.\r\n");
            // 
            // solubilityLabel
            // 
            this.solubilityLabel.AutoSize = true;
            this.solubilityLabel.Location = new System.Drawing.Point(6, 21);
            this.solubilityLabel.Name = "solubilityLabel";
            this.solubilityLabel.Size = new System.Drawing.Size(48, 13);
            this.solubilityLabel.TabIndex = 38;
            this.solubilityLabel.Text = "Solubility";
            this.generalTooltip.SetToolTip(this.solubilityLabel, "Solubility is the amount of material that may be dissolved in a single pass.");
            // 
            // hydroPassesNum
            // 
            this.hydroPassesNum.Location = new System.Drawing.Point(88, 201);
            this.hydroPassesNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hydroPassesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hydroPassesNum.Name = "hydroPassesNum";
            this.hydroPassesNum.Size = new System.Drawing.Size(74, 20);
            this.hydroPassesNum.TabIndex = 30;
            this.hydroPassesNum.ThousandsSeparator = true;
            this.hydroPassesNum.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // timeStepNum
            // 
            this.timeStepNum.DecimalPlaces = 2;
            this.timeStepNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timeStepNum.Location = new System.Drawing.Point(88, 175);
            this.timeStepNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeStepNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeStepNum.Name = "timeStepNum";
            this.timeStepNum.Size = new System.Drawing.Size(74, 20);
            this.timeStepNum.TabIndex = 29;
            this.timeStepNum.ThousandsSeparator = true;
            this.timeStepNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // evapConstNum
            // 
            this.evapConstNum.DecimalPlaces = 5;
            this.evapConstNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            327680});
            this.evapConstNum.Location = new System.Drawing.Point(88, 149);
            this.evapConstNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.evapConstNum.Name = "evapConstNum";
            this.evapConstNum.Size = new System.Drawing.Size(74, 20);
            this.evapConstNum.TabIndex = 28;
            this.evapConstNum.ThousandsSeparator = true;
            this.evapConstNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            // 
            // rainAmountNum
            // 
            this.rainAmountNum.DecimalPlaces = 2;
            this.rainAmountNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.rainAmountNum.Location = new System.Drawing.Point(88, 123);
            this.rainAmountNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.rainAmountNum.Name = "rainAmountNum";
            this.rainAmountNum.Size = new System.Drawing.Size(74, 20);
            this.rainAmountNum.TabIndex = 27;
            this.rainAmountNum.ThousandsSeparator = true;
            this.rainAmountNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // rainChanceNum
            // 
            this.rainChanceNum.DecimalPlaces = 4;
            this.rainChanceNum.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.rainChanceNum.Location = new System.Drawing.Point(88, 97);
            this.rainChanceNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rainChanceNum.Name = "rainChanceNum";
            this.rainChanceNum.Size = new System.Drawing.Size(74, 20);
            this.rainChanceNum.TabIndex = 26;
            this.rainChanceNum.ThousandsSeparator = true;
            this.rainChanceNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // waterCapNum
            // 
            this.waterCapNum.DecimalPlaces = 4;
            this.waterCapNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.waterCapNum.Location = new System.Drawing.Point(88, 71);
            this.waterCapNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.waterCapNum.Name = "waterCapNum";
            this.waterCapNum.Size = new System.Drawing.Size(74, 20);
            this.waterCapNum.TabIndex = 25;
            this.waterCapNum.ThousandsSeparator = true;
            this.waterCapNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // depRateNum
            // 
            this.depRateNum.DecimalPlaces = 4;
            this.depRateNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.depRateNum.Location = new System.Drawing.Point(88, 45);
            this.depRateNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.depRateNum.Name = "depRateNum";
            this.depRateNum.Size = new System.Drawing.Size(74, 20);
            this.depRateNum.TabIndex = 24;
            this.depRateNum.ThousandsSeparator = true;
            this.depRateNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // solubilityNum
            // 
            this.solubilityNum.DecimalPlaces = 4;
            this.solubilityNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.solubilityNum.Location = new System.Drawing.Point(88, 19);
            this.solubilityNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.solubilityNum.Name = "solubilityNum";
            this.solubilityNum.Size = new System.Drawing.Size(74, 20);
            this.solubilityNum.TabIndex = 23;
            this.solubilityNum.ThousandsSeparator = true;
            this.solubilityNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // thermalErosionGroup
            // 
            this.thermalErosionGroup.Controls.Add(this.tErodeRunButton);
            this.thermalErosionGroup.Controls.Add(this.tErodePassLabel);
            this.thermalErosionGroup.Controls.Add(this.talusAngleLabel);
            this.thermalErosionGroup.Controls.Add(this.tErodePassNum);
            this.thermalErosionGroup.Controls.Add(this.talusAngleNum);
            this.thermalErosionGroup.Location = new System.Drawing.Point(6, 6);
            this.thermalErosionGroup.Name = "thermalErosionGroup";
            this.thermalErosionGroup.Size = new System.Drawing.Size(168, 112);
            this.thermalErosionGroup.TabIndex = 0;
            this.thermalErosionGroup.TabStop = false;
            this.thermalErosionGroup.Text = "Thermal Erosion";
            // 
            // tErodeRunButton
            // 
            this.tErodeRunButton.Location = new System.Drawing.Point(45, 76);
            this.tErodeRunButton.Name = "tErodeRunButton";
            this.tErodeRunButton.Size = new System.Drawing.Size(75, 23);
            this.tErodeRunButton.TabIndex = 22;
            this.tErodeRunButton.Text = "Run";
            this.generalTooltip.SetToolTip(this.tErodeRunButton, "Execute Thermal Erosion");
            this.tErodeRunButton.UseVisualStyleBackColor = true;
            this.tErodeRunButton.Click += new System.EventHandler(this.tErodeRunButton_Click);
            // 
            // tErodePassLabel
            // 
            this.tErodePassLabel.AutoSize = true;
            this.tErodePassLabel.Location = new System.Drawing.Point(6, 47);
            this.tErodePassLabel.Name = "tErodePassLabel";
            this.tErodePassLabel.Size = new System.Drawing.Size(41, 13);
            this.tErodePassLabel.TabIndex = 36;
            this.tErodePassLabel.Text = "Passes";
            this.generalTooltip.SetToolTip(this.tErodePassLabel, "Number of passes to execute");
            // 
            // talusAngleLabel
            // 
            this.talusAngleLabel.AutoSize = true;
            this.talusAngleLabel.Location = new System.Drawing.Point(6, 21);
            this.talusAngleLabel.Name = "talusAngleLabel";
            this.talusAngleLabel.Size = new System.Drawing.Size(63, 13);
            this.talusAngleLabel.TabIndex = 35;
            this.talusAngleLabel.Text = "Talus Angle";
            this.generalTooltip.SetToolTip(this.talusAngleLabel, "Talus angle is angle above which material will fall downslope");
            // 
            // tErodePassNum
            // 
            this.tErodePassNum.Location = new System.Drawing.Point(88, 45);
            this.tErodePassNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tErodePassNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tErodePassNum.Name = "tErodePassNum";
            this.tErodePassNum.Size = new System.Drawing.Size(74, 20);
            this.tErodePassNum.TabIndex = 21;
            this.tErodePassNum.ThousandsSeparator = true;
            this.tErodePassNum.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // talusAngleNum
            // 
            this.talusAngleNum.DecimalPlaces = 2;
            this.talusAngleNum.Location = new System.Drawing.Point(88, 19);
            this.talusAngleNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.talusAngleNum.Name = "talusAngleNum";
            this.talusAngleNum.Size = new System.Drawing.Size(74, 20);
            this.talusAngleNum.TabIndex = 20;
            this.talusAngleNum.ThousandsSeparator = true;
            this.talusAngleNum.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // textureMapTab
            // 
            this.textureMapTab.Controls.Add(this.saveMapBox);
            this.textureMapTab.Controls.Add(this.customMapBox);
            this.textureMapTab.Controls.Add(this.colorMapGroup);
            this.textureMapTab.Location = new System.Drawing.Point(4, 22);
            this.textureMapTab.Name = "textureMapTab";
            this.textureMapTab.Size = new System.Drawing.Size(180, 545);
            this.textureMapTab.TabIndex = 2;
            this.textureMapTab.Text = "Maps";
            this.textureMapTab.UseVisualStyleBackColor = true;
            // 
            // saveMapBox
            // 
            this.saveMapBox.Controls.Add(this.saveMapButton);
            this.saveMapBox.Controls.Add(this.mapSaveSelect);
            this.saveMapBox.Location = new System.Drawing.Point(6, 468);
            this.saveMapBox.Name = "saveMapBox";
            this.saveMapBox.Size = new System.Drawing.Size(168, 74);
            this.saveMapBox.TabIndex = 3;
            this.saveMapBox.TabStop = false;
            this.saveMapBox.Text = "Save Maps";
            // 
            // saveMapButton
            // 
            this.saveMapButton.Location = new System.Drawing.Point(41, 46);
            this.saveMapButton.Name = "saveMapButton";
            this.saveMapButton.Size = new System.Drawing.Size(75, 23);
            this.saveMapButton.TabIndex = 45;
            this.saveMapButton.Text = "Save Map";
            this.generalTooltip.SetToolTip(this.saveMapButton, "Save the selected map.");
            this.saveMapButton.UseVisualStyleBackColor = true;
            this.saveMapButton.Click += new System.EventHandler(this.saveMapButton_Click);
            // 
            // mapSaveSelect
            // 
            this.mapSaveSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mapSaveSelect.FormattingEnabled = true;
            this.mapSaveSelect.Items.AddRange(new object[] {
            "Height Map",
            "Color Map",
            "Water Map",
            "Custom Map 1",
            "Custom Map 2",
            "Normal Map",
            "Slope Map",
            "Hydraulic Erosion Map",
            "Sediment Deposition Map",
            "Thermal Erosion Map",
            "Talus Map"});
            this.mapSaveSelect.Location = new System.Drawing.Point(9, 19);
            this.mapSaveSelect.Name = "mapSaveSelect";
            this.mapSaveSelect.Size = new System.Drawing.Size(153, 21);
            this.mapSaveSelect.TabIndex = 44;
            this.generalTooltip.SetToolTip(this.mapSaveSelect, "Choose a map to be saved.");
            // 
            // customMapBox
            // 
            this.customMapBox.Controls.Add(this.customMapButton);
            this.customMapBox.Controls.Add(this.noiseAmountLabel);
            this.customMapBox.Controls.Add(this.maxAltFuzzLabel);
            this.customMapBox.Controls.Add(this.splatNoiseAmountNum);
            this.customMapBox.Controls.Add(this.maxAltFuzzNum);
            this.customMapBox.Controls.Add(this.maxAltiLabel);
            this.customMapBox.Controls.Add(this.minAltFuzzLabel);
            this.customMapBox.Controls.Add(this.minAltLabel);
            this.customMapBox.Controls.Add(this.maxSlopeFuzzLabel);
            this.customMapBox.Controls.Add(this.maxSlopeLabel);
            this.customMapBox.Controls.Add(this.minSlopeFuzzLabel);
            this.customMapBox.Controls.Add(this.minSlopeLabel);
            this.customMapBox.Controls.Add(this.customMapLabel);
            this.customMapBox.Controls.Add(this.customMapSelect);
            this.customMapBox.Controls.Add(this.maxSplatAltNum);
            this.customMapBox.Controls.Add(this.minAltFuzzNum);
            this.customMapBox.Controls.Add(this.minAltNum);
            this.customMapBox.Controls.Add(this.maxSlopeFuzzNum);
            this.customMapBox.Controls.Add(this.maxSlopeNum);
            this.customMapBox.Controls.Add(this.minSlopeFuzzNum);
            this.customMapBox.Controls.Add(this.minSlopeNum);
            this.customMapBox.Location = new System.Drawing.Point(6, 154);
            this.customMapBox.Name = "customMapBox";
            this.customMapBox.Size = new System.Drawing.Size(168, 308);
            this.customMapBox.TabIndex = 2;
            this.customMapBox.TabStop = false;
            this.customMapBox.Text = "Custom Splat Maps";
            // 
            // customMapButton
            // 
            this.customMapButton.Location = new System.Drawing.Point(41, 279);
            this.customMapButton.Name = "customMapButton";
            this.customMapButton.Size = new System.Drawing.Size(75, 23);
            this.customMapButton.TabIndex = 43;
            this.customMapButton.Text = "Generate";
            this.generalTooltip.SetToolTip(this.customMapButton, "Create the selected splat map.");
            this.customMapButton.UseVisualStyleBackColor = true;
            this.customMapButton.Click += new System.EventHandler(this.customMapButton_Click);
            // 
            // noiseAmountLabel
            // 
            this.noiseAmountLabel.AutoSize = true;
            this.noiseAmountLabel.Location = new System.Drawing.Point(6, 256);
            this.noiseAmountLabel.Name = "noiseAmountLabel";
            this.noiseAmountLabel.Size = new System.Drawing.Size(73, 13);
            this.noiseAmountLabel.TabIndex = 54;
            this.noiseAmountLabel.Text = "Noise Amount";
            this.generalTooltip.SetToolTip(this.noiseAmountLabel, "Amount of gradient noise to be added to the splat map.");
            // 
            // maxAltFuzzLabel
            // 
            this.maxAltFuzzLabel.AutoSize = true;
            this.maxAltFuzzLabel.Location = new System.Drawing.Point(6, 230);
            this.maxAltFuzzLabel.Name = "maxAltFuzzLabel";
            this.maxAltFuzzLabel.Size = new System.Drawing.Size(67, 13);
            this.maxAltFuzzLabel.TabIndex = 53;
            this.maxAltFuzzLabel.Text = "Max Alt Fuzz";
            this.generalTooltip.SetToolTip(this.maxAltFuzzLabel, "Number of meters below the max altitude to interpolate.");
            // 
            // splatNoiseAmountNum
            // 
            this.splatNoiseAmountNum.DecimalPlaces = 2;
            this.splatNoiseAmountNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.splatNoiseAmountNum.Location = new System.Drawing.Point(88, 254);
            this.splatNoiseAmountNum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.splatNoiseAmountNum.Name = "splatNoiseAmountNum";
            this.splatNoiseAmountNum.Size = new System.Drawing.Size(74, 20);
            this.splatNoiseAmountNum.TabIndex = 42;
            this.splatNoiseAmountNum.ThousandsSeparator = true;
            this.splatNoiseAmountNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // maxAltFuzzNum
            // 
            this.maxAltFuzzNum.DecimalPlaces = 2;
            this.maxAltFuzzNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxAltFuzzNum.Location = new System.Drawing.Point(88, 228);
            this.maxAltFuzzNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.maxAltFuzzNum.Name = "maxAltFuzzNum";
            this.maxAltFuzzNum.Size = new System.Drawing.Size(74, 20);
            this.maxAltFuzzNum.TabIndex = 41;
            this.maxAltFuzzNum.ThousandsSeparator = true;
            // 
            // maxAltiLabel
            // 
            this.maxAltiLabel.AutoSize = true;
            this.maxAltiLabel.Location = new System.Drawing.Point(6, 204);
            this.maxAltiLabel.Name = "maxAltiLabel";
            this.maxAltiLabel.Size = new System.Drawing.Size(65, 13);
            this.maxAltiLabel.TabIndex = 50;
            this.maxAltiLabel.Text = "Max Altitude";
            this.generalTooltip.SetToolTip(this.maxAltiLabel, "Maximum altitude, in meters, for this splat map.");
            // 
            // minAltFuzzLabel
            // 
            this.minAltFuzzLabel.AutoSize = true;
            this.minAltFuzzLabel.Location = new System.Drawing.Point(6, 178);
            this.minAltFuzzLabel.Name = "minAltFuzzLabel";
            this.minAltFuzzLabel.Size = new System.Drawing.Size(64, 13);
            this.minAltFuzzLabel.TabIndex = 49;
            this.minAltFuzzLabel.Text = "Min Alt Fuzz";
            this.generalTooltip.SetToolTip(this.minAltFuzzLabel, "Number of meters above the min altitude to interpolate.");
            // 
            // minAltLabel
            // 
            this.minAltLabel.AutoSize = true;
            this.minAltLabel.Location = new System.Drawing.Point(6, 152);
            this.minAltLabel.Name = "minAltLabel";
            this.minAltLabel.Size = new System.Drawing.Size(62, 13);
            this.minAltLabel.TabIndex = 48;
            this.minAltLabel.Text = "Min Altitude";
            this.generalTooltip.SetToolTip(this.minAltLabel, "Minimum altitude, in meters, for this splat map.");
            // 
            // maxSlopeFuzzLabel
            // 
            this.maxSlopeFuzzLabel.AutoSize = true;
            this.maxSlopeFuzzLabel.Location = new System.Drawing.Point(6, 126);
            this.maxSlopeFuzzLabel.Name = "maxSlopeFuzzLabel";
            this.maxSlopeFuzzLabel.Size = new System.Drawing.Size(82, 13);
            this.maxSlopeFuzzLabel.TabIndex = 47;
            this.maxSlopeFuzzLabel.Text = "Max Slope Fuzz";
            this.generalTooltip.SetToolTip(this.maxSlopeFuzzLabel, "Number of degrees below the max slope to be interpolated.");
            // 
            // maxSlopeLabel
            // 
            this.maxSlopeLabel.AutoSize = true;
            this.maxSlopeLabel.Location = new System.Drawing.Point(6, 100);
            this.maxSlopeLabel.Name = "maxSlopeLabel";
            this.maxSlopeLabel.Size = new System.Drawing.Size(57, 13);
            this.maxSlopeLabel.TabIndex = 46;
            this.maxSlopeLabel.Text = "Max Slope";
            this.generalTooltip.SetToolTip(this.maxSlopeLabel, "Maximum slope, in degrees, for this splat map.");
            // 
            // minSlopeFuzzLabel
            // 
            this.minSlopeFuzzLabel.AutoSize = true;
            this.minSlopeFuzzLabel.Location = new System.Drawing.Point(6, 74);
            this.minSlopeFuzzLabel.Name = "minSlopeFuzzLabel";
            this.minSlopeFuzzLabel.Size = new System.Drawing.Size(79, 13);
            this.minSlopeFuzzLabel.TabIndex = 45;
            this.minSlopeFuzzLabel.Text = "Min Slope Fuzz";
            this.generalTooltip.SetToolTip(this.minSlopeFuzzLabel, "Range, in degrees, that will be interpolated above the min slope.");
            // 
            // minSlopeLabel
            // 
            this.minSlopeLabel.AutoSize = true;
            this.minSlopeLabel.Location = new System.Drawing.Point(6, 48);
            this.minSlopeLabel.Name = "minSlopeLabel";
            this.minSlopeLabel.Size = new System.Drawing.Size(54, 13);
            this.minSlopeLabel.TabIndex = 44;
            this.minSlopeLabel.Text = "Min Slope";
            this.generalTooltip.SetToolTip(this.minSlopeLabel, "Minimum Slope, in degrees, for this splat map.");
            // 
            // customMapLabel
            // 
            this.customMapLabel.AutoSize = true;
            this.customMapLabel.Location = new System.Drawing.Point(6, 22);
            this.customMapLabel.Name = "customMapLabel";
            this.customMapLabel.Size = new System.Drawing.Size(42, 13);
            this.customMapLabel.TabIndex = 43;
            this.customMapLabel.Text = "Editing:";
            // 
            // customMapSelect
            // 
            this.customMapSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customMapSelect.FormattingEnabled = true;
            this.customMapSelect.Items.AddRange(new object[] {
            "Custom 1",
            "Custom 2"});
            this.customMapSelect.Location = new System.Drawing.Point(62, 19);
            this.customMapSelect.MaxDropDownItems = 2;
            this.customMapSelect.Name = "customMapSelect";
            this.customMapSelect.Size = new System.Drawing.Size(100, 21);
            this.customMapSelect.TabIndex = 33;
            this.generalTooltip.SetToolTip(this.customMapSelect, "Select which splat map is being edited.");
            // 
            // maxSplatAltNum
            // 
            this.maxSplatAltNum.DecimalPlaces = 2;
            this.maxSplatAltNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxSplatAltNum.Location = new System.Drawing.Point(88, 202);
            this.maxSplatAltNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.maxSplatAltNum.Name = "maxSplatAltNum";
            this.maxSplatAltNum.Size = new System.Drawing.Size(74, 20);
            this.maxSplatAltNum.TabIndex = 40;
            this.maxSplatAltNum.ThousandsSeparator = true;
            this.maxSplatAltNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // minAltFuzzNum
            // 
            this.minAltFuzzNum.DecimalPlaces = 2;
            this.minAltFuzzNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minAltFuzzNum.Location = new System.Drawing.Point(88, 176);
            this.minAltFuzzNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.minAltFuzzNum.Name = "minAltFuzzNum";
            this.minAltFuzzNum.Size = new System.Drawing.Size(74, 20);
            this.minAltFuzzNum.TabIndex = 39;
            this.minAltFuzzNum.ThousandsSeparator = true;
            // 
            // minAltNum
            // 
            this.minAltNum.DecimalPlaces = 2;
            this.minAltNum.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minAltNum.Location = new System.Drawing.Point(88, 150);
            this.minAltNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            131072});
            this.minAltNum.Name = "minAltNum";
            this.minAltNum.Size = new System.Drawing.Size(74, 20);
            this.minAltNum.TabIndex = 38;
            this.minAltNum.ThousandsSeparator = true;
            // 
            // maxSlopeFuzzNum
            // 
            this.maxSlopeFuzzNum.DecimalPlaces = 2;
            this.maxSlopeFuzzNum.Location = new System.Drawing.Point(88, 124);
            this.maxSlopeFuzzNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.maxSlopeFuzzNum.Name = "maxSlopeFuzzNum";
            this.maxSlopeFuzzNum.Size = new System.Drawing.Size(74, 20);
            this.maxSlopeFuzzNum.TabIndex = 37;
            this.maxSlopeFuzzNum.ThousandsSeparator = true;
            // 
            // maxSlopeNum
            // 
            this.maxSlopeNum.DecimalPlaces = 2;
            this.maxSlopeNum.Location = new System.Drawing.Point(88, 98);
            this.maxSlopeNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.maxSlopeNum.Name = "maxSlopeNum";
            this.maxSlopeNum.Size = new System.Drawing.Size(74, 20);
            this.maxSlopeNum.TabIndex = 36;
            this.maxSlopeNum.ThousandsSeparator = true;
            this.maxSlopeNum.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // minSlopeFuzzNum
            // 
            this.minSlopeFuzzNum.DecimalPlaces = 2;
            this.minSlopeFuzzNum.Location = new System.Drawing.Point(88, 72);
            this.minSlopeFuzzNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.minSlopeFuzzNum.Name = "minSlopeFuzzNum";
            this.minSlopeFuzzNum.Size = new System.Drawing.Size(74, 20);
            this.minSlopeFuzzNum.TabIndex = 35;
            this.minSlopeFuzzNum.ThousandsSeparator = true;
            // 
            // minSlopeNum
            // 
            this.minSlopeNum.DecimalPlaces = 2;
            this.minSlopeNum.Location = new System.Drawing.Point(88, 46);
            this.minSlopeNum.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.minSlopeNum.Name = "minSlopeNum";
            this.minSlopeNum.Size = new System.Drawing.Size(74, 20);
            this.minSlopeNum.TabIndex = 34;
            this.minSlopeNum.ThousandsSeparator = true;
            // 
            // colorMapGroup
            // 
            this.colorMapGroup.Controls.Add(this.importTexSample);
            this.colorMapGroup.Controls.Add(this.texSamplePicture);
            this.colorMapGroup.Location = new System.Drawing.Point(6, 6);
            this.colorMapGroup.Name = "colorMapGroup";
            this.colorMapGroup.Size = new System.Drawing.Size(168, 142);
            this.colorMapGroup.TabIndex = 1;
            this.colorMapGroup.TabStop = false;
            this.colorMapGroup.Text = "Color Map";
            // 
            // importTexSample
            // 
            this.importTexSample.Location = new System.Drawing.Point(34, 108);
            this.importTexSample.Name = "importTexSample";
            this.importTexSample.Size = new System.Drawing.Size(92, 23);
            this.importTexSample.TabIndex = 32;
            this.importTexSample.Text = "Import Sample";
            this.generalTooltip.SetToolTip(this.importTexSample, "Import a new texture sample, in BMP format, to be used to generate the color map." +
        "");
            this.importTexSample.UseVisualStyleBackColor = true;
            this.importTexSample.Click += new System.EventHandler(this.importTexSample_Click);
            // 
            // texSamplePicture
            // 
            this.texSamplePicture.Location = new System.Drawing.Point(41, 19);
            this.texSamplePicture.Name = "texSamplePicture";
            this.texSamplePicture.Size = new System.Drawing.Size(80, 80);
            this.texSamplePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.texSamplePicture.TabIndex = 0;
            this.texSamplePicture.TabStop = false;
            this.generalTooltip.SetToolTip(this.texSamplePicture, "The texture sample being used to generate the color map.");
            // 
            // importMapDialog
            // 
            this.importMapDialog.Filter = "Windows Bitmap|*.bmp|TIFF Images|*.tif";
            this.importMapDialog.FilterIndex = 2;
            // 
            // importTexSampleDialog
            // 
            this.importTexSampleDialog.Filter = "Windows Bitmap|*.bmp";
            // 
            // saveHeightMapDialog
            // 
            this.saveHeightMapDialog.Filter = "Windows Bitmap|*.bmp|TIFF Image|*.tif|RAW Heightmap|*.raw";
            this.saveHeightMapDialog.FilterIndex = 2;
            // 
            // saveBmpDialog
            // 
            this.saveBmpDialog.Filter = "Windows Bitmap|*.bmp";
            // 
            // TerrainGeneratorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 611);
            this.Controls.Add(this.toolTabs);
            this.Controls.Add(this.mapTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(750, 650);
            this.Name = "TerrainGeneratorMainForm";
            this.Text = "Procedural Terrain Generator";
            this.Load += new System.EventHandler(this.TerrainGeneratorMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.heightMapPanel.ResumeLayout(false);
            this.heightMapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightMapPicture)).EndInit();
            this.mapTabs.ResumeLayout(false);
            this.heightMapTab.ResumeLayout(false);
            this.colorMapTab.ResumeLayout(false);
            this.colorMapPanel.ResumeLayout(false);
            this.colorMapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorMapPicture)).EndInit();
            this.waterMapTab.ResumeLayout(false);
            this.waterMapPanel.ResumeLayout(false);
            this.waterMapPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waterMapPicture)).EndInit();
            this.customMap1Tab.ResumeLayout(false);
            this.customMap1Panel.ResumeLayout(false);
            this.customMap1Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customMap1Picture)).EndInit();
            this.customMap2Tab.ResumeLayout(false);
            this.customMap2Panel.ResumeLayout(false);
            this.customMap2Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customMap2Picture)).EndInit();
            this.toolTabs.ResumeLayout(false);
            this.generateTab.ResumeLayout(false);
            this.noisePropBox.ResumeLayout(false);
            this.noisePropBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yOffsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xOffsetNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octavesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseWeightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persistenceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lacunarityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNum)).EndInit();
            this.mapPropertiesBox.ResumeLayout(false);
            this.mapPropertiesBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAltNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ySizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xSizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMapSizeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMapSizeNum)).EndInit();
            this.erosionTab.ResumeLayout(false);
            this.hydroErosionGroup.ResumeLayout(false);
            this.hydroErosionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hydroPassesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeStepNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evapConstNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainAmountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rainChanceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterCapNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depRateNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solubilityNum)).EndInit();
            this.thermalErosionGroup.ResumeLayout(false);
            this.thermalErosionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tErodePassNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talusAngleNum)).EndInit();
            this.textureMapTab.ResumeLayout(false);
            this.saveMapBox.ResumeLayout(false);
            this.customMapBox.ResumeLayout(false);
            this.customMapBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splatNoiseAmountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxAltFuzzNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSplatAltNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAltFuzzNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minAltNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSlopeFuzzNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxSlopeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSlopeFuzzNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minSlopeNum)).EndInit();
            this.colorMapGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.texSamplePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Panel heightMapPanel;
        private System.Windows.Forms.PictureBox heightMapPicture;
        private System.Windows.Forms.Button generateTerrainButton;
        private System.Windows.Forms.TabControl mapTabs;
        private System.Windows.Forms.TabPage heightMapTab;
        private System.Windows.Forms.TabPage colorMapTab;
        private System.Windows.Forms.TabControl toolTabs;
        private System.Windows.Forms.TabPage generateTab;
        private System.Windows.Forms.TabPage erosionTab;
        private System.Windows.Forms.Panel colorMapPanel;
        private System.Windows.Forms.PictureBox colorMapPicture;
        private System.Windows.Forms.TabPage textureMapTab;
        private System.Windows.Forms.TabPage waterMapTab;
        private System.Windows.Forms.TabPage customMap1Tab;
        private System.Windows.Forms.TabPage customMap2Tab;
        private System.Windows.Forms.Panel waterMapPanel;
        private System.Windows.Forms.PictureBox waterMapPicture;
        private System.Windows.Forms.Panel customMap1Panel;
        private System.Windows.Forms.PictureBox customMap1Picture;
        private System.Windows.Forms.Panel customMap2Panel;
        private System.Windows.Forms.PictureBox customMap2Picture;
        private System.Windows.Forms.Button importMapButton;
        private System.Windows.Forms.OpenFileDialog importMapDialog;
        private System.Windows.Forms.Button addNoiseButton;
        private System.Windows.Forms.Label yOffsetLabel;
        private System.Windows.Forms.Label xOffsetLabel;
        private System.Windows.Forms.Label noiseWeightLabel;
        private System.Windows.Forms.Label slopeDistributionLabel;
        private System.Windows.Forms.Label persistenceLabel;
        private System.Windows.Forms.Label lacunarityLabel;
        private System.Windows.Forms.Label octaveLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label ySizeLabel;
        private System.Windows.Forms.Label xSizeLabel;
        private System.Windows.Forms.GroupBox mapPropertiesBox;
        private System.Windows.Forms.Label xActualSizeLabel;
        private System.Windows.Forms.Label yActualSizeLabel;
        private System.Windows.Forms.Label maxAltLabel;
        private System.Windows.Forms.GroupBox noisePropBox;
        private System.Windows.Forms.ToolTip generalTooltip;
        private System.Windows.Forms.NumericUpDown yOffsetNum;
        private System.Windows.Forms.NumericUpDown xOffsetNum;
        private System.Windows.Forms.NumericUpDown octavesNum;
        private System.Windows.Forms.NumericUpDown noiseWeightNum;
        private System.Windows.Forms.NumericUpDown muNum;
        private System.Windows.Forms.NumericUpDown persistenceNum;
        private System.Windows.Forms.NumericUpDown lacunarityNum;
        private System.Windows.Forms.NumericUpDown frequencyNum;
        private System.Windows.Forms.NumericUpDown maxAltNum;
        private System.Windows.Forms.NumericUpDown ySizeNum;
        private System.Windows.Forms.NumericUpDown xSizeNum;
        private System.Windows.Forms.NumericUpDown yMapSizeNum;
        private System.Windows.Forms.NumericUpDown xMapSizeNum;
        private System.Windows.Forms.GroupBox hydroErosionGroup;
        private System.Windows.Forms.GroupBox thermalErosionGroup;
        private System.Windows.Forms.Button tErodeRunButton;
        private System.Windows.Forms.Label tErodePassLabel;
        private System.Windows.Forms.Label talusAngleLabel;
        private System.Windows.Forms.NumericUpDown tErodePassNum;
        private System.Windows.Forms.NumericUpDown talusAngleNum;
        private System.Windows.Forms.Button hydroErodeRunButton;
        private System.Windows.Forms.Label hydroPassesLabel;
        private System.Windows.Forms.Label timeStepLabel;
        private System.Windows.Forms.Label evapConstLabel;
        private System.Windows.Forms.Label rainAmountLabel;
        private System.Windows.Forms.Label rainChanceLabel;
        private System.Windows.Forms.Label waterCapLabel;
        private System.Windows.Forms.Label depRateLabel;
        private System.Windows.Forms.Label solubilityLabel;
        private System.Windows.Forms.NumericUpDown hydroPassesNum;
        private System.Windows.Forms.NumericUpDown timeStepNum;
        private System.Windows.Forms.NumericUpDown evapConstNum;
        private System.Windows.Forms.NumericUpDown rainAmountNum;
        private System.Windows.Forms.NumericUpDown rainChanceNum;
        private System.Windows.Forms.NumericUpDown waterCapNum;
        private System.Windows.Forms.NumericUpDown depRateNum;
        private System.Windows.Forms.NumericUpDown solubilityNum;
        private System.Windows.Forms.GroupBox colorMapGroup;
        private System.Windows.Forms.PictureBox texSamplePicture;
        private System.Windows.Forms.Button importTexSample;
        private System.Windows.Forms.OpenFileDialog importTexSampleDialog;
        private System.Windows.Forms.GroupBox customMapBox;
        private System.Windows.Forms.ComboBox customMapSelect;
        private System.Windows.Forms.NumericUpDown maxSplatAltNum;
        private System.Windows.Forms.NumericUpDown minAltFuzzNum;
        private System.Windows.Forms.NumericUpDown minAltNum;
        private System.Windows.Forms.NumericUpDown maxSlopeFuzzNum;
        private System.Windows.Forms.NumericUpDown maxSlopeNum;
        private System.Windows.Forms.NumericUpDown minSlopeFuzzNum;
        private System.Windows.Forms.NumericUpDown minSlopeNum;
        private System.Windows.Forms.Label maxAltiLabel;
        private System.Windows.Forms.Label minAltFuzzLabel;
        private System.Windows.Forms.Label minAltLabel;
        private System.Windows.Forms.Label maxSlopeFuzzLabel;
        private System.Windows.Forms.Label maxSlopeLabel;
        private System.Windows.Forms.Label minSlopeFuzzLabel;
        private System.Windows.Forms.Label minSlopeLabel;
        private System.Windows.Forms.Label customMapLabel;
        private System.Windows.Forms.GroupBox saveMapBox;
        private System.Windows.Forms.Label noiseAmountLabel;
        private System.Windows.Forms.Label maxAltFuzzLabel;
        private System.Windows.Forms.NumericUpDown splatNoiseAmountNum;
        private System.Windows.Forms.NumericUpDown maxAltFuzzNum;
        private System.Windows.Forms.Button saveMapButton;
        private System.Windows.Forms.ComboBox mapSaveSelect;
        private System.Windows.Forms.Button customMapButton;
        private System.Windows.Forms.SaveFileDialog saveHeightMapDialog;
        private System.Windows.Forms.SaveFileDialog saveBmpDialog;
    }
}
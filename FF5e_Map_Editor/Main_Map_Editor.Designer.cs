namespace FF5e_Map_Editor
{
    partial class Main_Map_Editor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public partial class BufferPanel : System.Windows.Forms.Panel
        {
            public BufferPanel()
            {
                SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
                UpdateStyles();
            }
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Map_Editor));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.checkBoxBgMiscs = new System.Windows.Forms.CheckBox();
            this.labelLocationName = new System.Windows.Forms.Label();
            this.panelCurrenTile = new System.Windows.Forms.Panel();
            this.labelSub = new System.Windows.Forms.Label();
            this.numericUpDownQuadrant = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownZoom = new System.Windows.Forms.NumericUpDown();
            this.buttonZoom = new System.Windows.Forms.Button();
            this.buttonSaveBg01 = new System.Windows.Forms.Button();
            this.buttonSaveBg00 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownSelectedTileBg01 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSelectedTileBg00 = new System.Windows.Forms.NumericUpDown();
            this.labelPointedTileBg1 = new System.Windows.Forms.Label();
            this.labelPointedTileBg0 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.checkBoxBgNPCs = new System.Windows.Forms.CheckBox();
            this.checkBoxBgWalls = new System.Windows.Forms.CheckBox();
            this.labelPointedTile = new System.Windows.Forms.Label();
            this.checkBoxBg01 = new System.Windows.Forms.CheckBox();
            this.checkBoxBg02 = new System.Windows.Forms.CheckBox();
            this.checkBoxBg00 = new System.Windows.Forms.CheckBox();
            this.numericUpDownMap = new System.Windows.Forms.NumericUpDown();
            this.panelMap = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.panelBoxMap = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelCurrentPalette = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.panelBoxVRAM = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.bufferPanelVRAM = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTileMouse = new System.Windows.Forms.Label();
            this.panelTilesetDisplay = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBoxDescriptors = new System.Windows.Forms.GroupBox();
            this.buttonInjectDescriptors = new System.Windows.Forms.Button();
            this.labelDescriptorMusic = new System.Windows.Forms.Label();
            this.labelDescriptorPalette = new System.Windows.Forms.Label();
            this.labelDescriptorVRAMGraphics = new System.Windows.Forms.Label();
            this.labelDescriptortileBlocks = new System.Windows.Forms.Label();
            this.labelDescriptorTileProperties = new System.Windows.Forms.Label();
            this.labelDescriptorGraphicMaths = new System.Windows.Forms.Label();
            this.labelUnknown17 = new System.Windows.Forms.Label();
            this.labelUnknown13 = new System.Windows.Forms.Label();
            this.labelUnknown10 = new System.Windows.Forms.Label();
            this.labelUnknown06 = new System.Windows.Forms.Label();
            this.labelUnknown03 = new System.Windows.Forms.Label();
            this.labelDescriptorLocationName = new System.Windows.Forms.Label();
            this.labelDescriptorId = new System.Windows.Forms.Label();
            this.labelDescriptorTilemaps = new System.Windows.Forms.Label();
            this.numericUpDownDescriptor19 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor18 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor17 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor16 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor15 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor14 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor13 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor11 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor10 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor0F = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor0E = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor0D = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor0C = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor0B = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor0A = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor09 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor08 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor07 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor06 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor05 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor04 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor03 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor02 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor01 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDescriptor00 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTreasureDisplay = new System.Windows.Forms.Label();
            this.buttonInjectTreasure = new System.Windows.Forms.Button();
            this.labelTreasuresContentId = new System.Windows.Forms.Label();
            this.numericUpDownTreasureContentId = new System.Windows.Forms.NumericUpDown();
            this.labelTreasuresModifier = new System.Windows.Forms.Label();
            this.numericUpDownTreasureModifier = new System.Windows.Forms.NumericUpDown();
            this.labelTreasureContent = new System.Windows.Forms.Label();
            this.comboBoxTreasureBehavior = new System.Windows.Forms.ComboBox();
            this.labelTreasureY = new System.Windows.Forms.Label();
            this.comboBoxTreasures = new System.Windows.Forms.ComboBox();
            this.numericUpDownTreasureY = new System.Windows.Forms.NumericUpDown();
            this.labelTreasureX = new System.Windows.Forms.Label();
            this.numericUpDownTreasureX = new System.Windows.Forms.NumericUpDown();
            this.groupBoxExits = new System.Windows.Forms.GroupBox();
            this.labelExitProperties = new System.Windows.Forms.Label();
            this.numericUpDownExitProperties = new System.Windows.Forms.NumericUpDown();
            this.labelExitDestinationY = new System.Windows.Forms.Label();
            this.labelExitDestinationX = new System.Windows.Forms.Label();
            this.labelExitMapID = new System.Windows.Forms.Label();
            this.labelExitOriginY = new System.Windows.Forms.Label();
            this.labelExitOriginX = new System.Windows.Forms.Label();
            this.buttonInjectExit = new System.Windows.Forms.Button();
            this.numericUpDownExitDestinationY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExitDestinationX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExitMapId = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExitOriginY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownExitOriginX = new System.Windows.Forms.NumericUpDown();
            this.comboBoxExits = new System.Windows.Forms.ComboBox();
            this.groupBoxNPCs = new System.Windows.Forms.GroupBox();
            this.buttonInjectNPC = new System.Windows.Forms.Button();
            this.panelNPCSprite = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxNPCs = new System.Windows.Forms.ComboBox();
            this.numericUpDownNPCsGraphicId = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownNPCsX = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownNPCsY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownNPCsActionID = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownNPCsWP = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownNPCsProperties = new System.Windows.Forms.NumericUpDown();
            this.groupBoxEvents = new System.Windows.Forms.GroupBox();
            this.buttonEventDisplay = new System.Windows.Forms.Button();
            this.buttonInjectEvent = new System.Windows.Forms.Button();
            this.labelEventsID = new System.Windows.Forms.Label();
            this.labelEventsY = new System.Windows.Forms.Label();
            this.numericUpDownEventID = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEventY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEventX = new System.Windows.Forms.NumericUpDown();
            this.labelEventX = new System.Windows.Forms.Label();
            this.comboBoxEvents = new System.Windows.Forms.ComboBox();
            this.textBoxMapProperties = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelMapEncounters = new System.Windows.Forms.Label();
            this.textBoxMapEncounters = new System.Windows.Forms.TextBox();
            this.numericUpDownEnemyFormations = new System.Windows.Forms.NumericUpDown();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxenemyFormations = new System.Windows.Forms.GroupBox();
            this.labelEnemyFormation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelEnemyGroups = new System.Windows.Forms.Label();
            this.numericUpDownEnemyGroups = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuadrant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedTileBg01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedTileBg00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMap)).BeginInit();
            this.panelMap.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelBoxVRAM.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBoxDescriptors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0F)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor09)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor00)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureContentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureX)).BeginInit();
            this.groupBoxExits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitDestinationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitDestinationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitMapId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitOriginY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitOriginX)).BeginInit();
            this.groupBoxNPCs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsGraphicId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsActionID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsWP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsProperties)).BeginInit();
            this.groupBoxEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventX)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnemyFormations)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.groupBoxenemyFormations.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnemyGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 564);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.checkBoxBgMiscs);
            this.tabPage0.Controls.Add(this.labelLocationName);
            this.tabPage0.Controls.Add(this.panelCurrenTile);
            this.tabPage0.Controls.Add(this.labelSub);
            this.tabPage0.Controls.Add(this.numericUpDownQuadrant);
            this.tabPage0.Controls.Add(this.label3);
            this.tabPage0.Controls.Add(this.numericUpDownZoom);
            this.tabPage0.Controls.Add(this.buttonZoom);
            this.tabPage0.Controls.Add(this.buttonSaveBg01);
            this.tabPage0.Controls.Add(this.buttonSaveBg00);
            this.tabPage0.Controls.Add(this.label2);
            this.tabPage0.Controls.Add(this.label1);
            this.tabPage0.Controls.Add(this.numericUpDownSelectedTileBg01);
            this.tabPage0.Controls.Add(this.numericUpDownSelectedTileBg00);
            this.tabPage0.Controls.Add(this.labelPointedTileBg1);
            this.tabPage0.Controls.Add(this.labelPointedTileBg0);
            this.tabPage0.Controls.Add(this.label57);
            this.tabPage0.Controls.Add(this.checkBoxBgNPCs);
            this.tabPage0.Controls.Add(this.checkBoxBgWalls);
            this.tabPage0.Controls.Add(this.labelPointedTile);
            this.tabPage0.Controls.Add(this.checkBoxBg01);
            this.tabPage0.Controls.Add(this.checkBoxBg02);
            this.tabPage0.Controls.Add(this.checkBoxBg00);
            this.tabPage0.Controls.Add(this.numericUpDownMap);
            this.tabPage0.Controls.Add(this.panelMap);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Size = new System.Drawing.Size(726, 538);
            this.tabPage0.TabIndex = 0;
            this.tabPage0.Text = "Maps";
            // 
            // checkBoxBgMiscs
            // 
            this.checkBoxBgMiscs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBgMiscs.AutoSize = true;
            this.checkBoxBgMiscs.Checked = true;
            this.checkBoxBgMiscs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBgMiscs.Location = new System.Drawing.Point(645, 491);
            this.checkBoxBgMiscs.Name = "checkBoxBgMiscs";
            this.checkBoxBgMiscs.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBgMiscs.TabIndex = 67;
            this.checkBoxBgMiscs.Text = "Miscs";
            this.checkBoxBgMiscs.UseVisualStyleBackColor = true;
            this.checkBoxBgMiscs.CheckedChanged += new System.EventHandler(this.checkBoxBg_CheckedChanged);
            // 
            // labelLocationName
            // 
            this.labelLocationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocationName.AutoSize = true;
            this.labelLocationName.Location = new System.Drawing.Point(542, 54);
            this.labelLocationName.Name = "labelLocationName";
            this.labelLocationName.Size = new System.Drawing.Size(98, 13);
            this.labelLocationName.TabIndex = 66;
            this.labelLocationName.Text = "labelLocationName";
            // 
            // panelCurrenTile
            // 
            this.panelCurrenTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCurrenTile.BackColor = System.Drawing.Color.Black;
            this.panelCurrenTile.Location = new System.Drawing.Point(692, 399);
            this.panelCurrenTile.Name = "panelCurrenTile";
            this.panelCurrenTile.Size = new System.Drawing.Size(31, 31);
            this.panelCurrenTile.TabIndex = 65;
            this.panelCurrenTile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCurrenTile_Paint);
            // 
            // labelSub
            // 
            this.labelSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSub.AutoSize = true;
            this.labelSub.Location = new System.Drawing.Point(652, 33);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(26, 13);
            this.labelSub.TabIndex = 64;
            this.labelSub.Text = "Sub";
            // 
            // numericUpDownQuadrant
            // 
            this.numericUpDownQuadrant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuadrant.Hexadecimal = true;
            this.numericUpDownQuadrant.Location = new System.Drawing.Point(684, 31);
            this.numericUpDownQuadrant.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownQuadrant.Name = "numericUpDownQuadrant";
            this.numericUpDownQuadrant.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownQuadrant.TabIndex = 63;
            this.numericUpDownQuadrant.ValueChanged += new System.EventHandler(this.numericUpDownQuadrant_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 516);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Zoom";
            // 
            // numericUpDownZoom
            // 
            this.numericUpDownZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownZoom.DecimalPlaces = 2;
            this.numericUpDownZoom.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numericUpDownZoom.Location = new System.Drawing.Point(580, 514);
            this.numericUpDownZoom.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownZoom.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownZoom.Name = "numericUpDownZoom";
            this.numericUpDownZoom.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownZoom.TabIndex = 61;
            this.numericUpDownZoom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownZoom.ValueChanged += new System.EventHandler(this.numericUpDownZoom_ValueChanged);
            // 
            // buttonZoom
            // 
            this.buttonZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonZoom.Location = new System.Drawing.Point(646, 511);
            this.buttonZoom.Name = "buttonZoom";
            this.buttonZoom.Size = new System.Drawing.Size(77, 23);
            this.buttonZoom.TabIndex = 59;
            this.buttonZoom.Text = "Export PNG";
            this.buttonZoom.UseVisualStyleBackColor = true;
            this.buttonZoom.Click += new System.EventHandler(this.buttonZoom_Click);
            // 
            // buttonSaveBg01
            // 
            this.buttonSaveBg01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveBg01.Enabled = false;
            this.buttonSaveBg01.Location = new System.Drawing.Point(644, 91);
            this.buttonSaveBg01.Name = "buttonSaveBg01";
            this.buttonSaveBg01.Size = new System.Drawing.Size(77, 23);
            this.buttonSaveBg01.TabIndex = 58;
            this.buttonSaveBg01.Text = "Inject Bg01";
            this.buttonSaveBg01.UseVisualStyleBackColor = true;
            this.buttonSaveBg01.Click += new System.EventHandler(this.buttonSaveBg01_Click);
            // 
            // buttonSaveBg00
            // 
            this.buttonSaveBg00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveBg00.Enabled = false;
            this.buttonSaveBg00.Location = new System.Drawing.Point(543, 91);
            this.buttonSaveBg00.Name = "buttonSaveBg00";
            this.buttonSaveBg00.Size = new System.Drawing.Size(77, 23);
            this.buttonSaveBg00.TabIndex = 57;
            this.buttonSaveBg00.Text = "Inject Bg00";
            this.buttonSaveBg00.UseVisualStyleBackColor = true;
            this.buttonSaveBg00.Click += new System.EventHandler(this.buttonSaveBg00_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Background 01";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Background 00";
            // 
            // numericUpDownSelectedTileBg01
            // 
            this.numericUpDownSelectedTileBg01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSelectedTileBg01.Hexadecimal = true;
            this.numericUpDownSelectedTileBg01.Location = new System.Drawing.Point(644, 120);
            this.numericUpDownSelectedTileBg01.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownSelectedTileBg01.Name = "numericUpDownSelectedTileBg01";
            this.numericUpDownSelectedTileBg01.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownSelectedTileBg01.TabIndex = 54;
            this.numericUpDownSelectedTileBg01.ValueChanged += new System.EventHandler(this.numericUpDownSelectedTileBg01_ValueChanged);
            // 
            // numericUpDownSelectedTileBg00
            // 
            this.numericUpDownSelectedTileBg00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSelectedTileBg00.Hexadecimal = true;
            this.numericUpDownSelectedTileBg00.Location = new System.Drawing.Point(545, 120);
            this.numericUpDownSelectedTileBg00.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownSelectedTileBg00.Name = "numericUpDownSelectedTileBg00";
            this.numericUpDownSelectedTileBg00.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownSelectedTileBg00.TabIndex = 53;
            this.numericUpDownSelectedTileBg00.ValueChanged += new System.EventHandler(this.numericUpDownSelectedTile_ValueChanged);
            // 
            // labelPointedTileBg1
            // 
            this.labelPointedTileBg1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPointedTileBg1.AutoSize = true;
            this.labelPointedTileBg1.Location = new System.Drawing.Point(641, 143);
            this.labelPointedTileBg1.Name = "labelPointedTileBg1";
            this.labelPointedTileBg1.Size = new System.Drawing.Size(32, 13);
            this.labelPointedTileBg1.TabIndex = 52;
            this.labelPointedTileBg1.Text = "Bg01";
            // 
            // labelPointedTileBg0
            // 
            this.labelPointedTileBg0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPointedTileBg0.AutoSize = true;
            this.labelPointedTileBg0.Location = new System.Drawing.Point(545, 143);
            this.labelPointedTileBg0.Name = "labelPointedTileBg0";
            this.labelPointedTileBg0.Size = new System.Drawing.Size(32, 13);
            this.labelPointedTileBg0.TabIndex = 51;
            this.labelPointedTileBg0.Text = "Bg00";
            // 
            // label57
            // 
            this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(542, 33);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(39, 13);
            this.label57.TabIndex = 50;
            this.label57.Text = "Map id";
            // 
            // checkBoxBgNPCs
            // 
            this.checkBoxBgNPCs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBgNPCs.AutoSize = true;
            this.checkBoxBgNPCs.Checked = true;
            this.checkBoxBgNPCs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBgNPCs.Location = new System.Drawing.Point(540, 491);
            this.checkBoxBgNPCs.Name = "checkBoxBgNPCs";
            this.checkBoxBgNPCs.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBgNPCs.TabIndex = 49;
            this.checkBoxBgNPCs.Text = "NPCs";
            this.checkBoxBgNPCs.UseVisualStyleBackColor = true;
            this.checkBoxBgNPCs.CheckedChanged += new System.EventHandler(this.checkBoxBg_CheckedChanged);
            // 
            // checkBoxBgWalls
            // 
            this.checkBoxBgWalls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBgWalls.AutoSize = true;
            this.checkBoxBgWalls.Location = new System.Drawing.Point(540, 468);
            this.checkBoxBgWalls.Name = "checkBoxBgWalls";
            this.checkBoxBgWalls.Size = new System.Drawing.Size(52, 17);
            this.checkBoxBgWalls.TabIndex = 49;
            this.checkBoxBgWalls.Text = "Walls";
            this.checkBoxBgWalls.UseVisualStyleBackColor = true;
            this.checkBoxBgWalls.CheckedChanged += new System.EventHandler(this.checkBoxBg_CheckedChanged);
            // 
            // labelPointedTile
            // 
            this.labelPointedTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPointedTile.AutoSize = true;
            this.labelPointedTile.Location = new System.Drawing.Point(540, 7);
            this.labelPointedTile.Name = "labelPointedTile";
            this.labelPointedTile.Size = new System.Drawing.Size(57, 13);
            this.labelPointedTile.TabIndex = 48;
            this.labelPointedTile.Text = "Tile 00, 00";
            // 
            // checkBoxBg01
            // 
            this.checkBoxBg01.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBg01.AutoSize = true;
            this.checkBoxBg01.Checked = true;
            this.checkBoxBg01.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBg01.Location = new System.Drawing.Point(540, 422);
            this.checkBoxBg01.Name = "checkBoxBg01";
            this.checkBoxBg01.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBg01.TabIndex = 47;
            this.checkBoxBg01.Text = "Background 01";
            this.checkBoxBg01.UseVisualStyleBackColor = true;
            this.checkBoxBg01.CheckedChanged += new System.EventHandler(this.checkBoxBg_CheckedChanged);
            // 
            // checkBoxBg02
            // 
            this.checkBoxBg02.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBg02.AutoSize = true;
            this.checkBoxBg02.Checked = true;
            this.checkBoxBg02.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBg02.Location = new System.Drawing.Point(540, 445);
            this.checkBoxBg02.Name = "checkBoxBg02";
            this.checkBoxBg02.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBg02.TabIndex = 46;
            this.checkBoxBg02.Text = "Background 02";
            this.checkBoxBg02.UseVisualStyleBackColor = true;
            this.checkBoxBg02.CheckedChanged += new System.EventHandler(this.checkBoxBg_CheckedChanged);
            // 
            // checkBoxBg00
            // 
            this.checkBoxBg00.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBg00.AutoSize = true;
            this.checkBoxBg00.Checked = true;
            this.checkBoxBg00.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBg00.Location = new System.Drawing.Point(540, 399);
            this.checkBoxBg00.Name = "checkBoxBg00";
            this.checkBoxBg00.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBg00.TabIndex = 45;
            this.checkBoxBg00.Text = "Background 00";
            this.checkBoxBg00.UseVisualStyleBackColor = true;
            this.checkBoxBg00.CheckedChanged += new System.EventHandler(this.checkBoxBg_CheckedChanged);
            // 
            // numericUpDownMap
            // 
            this.numericUpDownMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownMap.Hexadecimal = true;
            this.numericUpDownMap.Location = new System.Drawing.Point(587, 31);
            this.numericUpDownMap.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.numericUpDownMap.Name = "numericUpDownMap";
            this.numericUpDownMap.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownMap.TabIndex = 44;
            this.numericUpDownMap.ValueChanged += new System.EventHandler(this.numericUpDownMap_ValueChanged);
            // 
            // panelMap
            // 
            this.panelMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMap.AutoScroll = true;
            this.panelMap.BackColor = System.Drawing.Color.Black;
            this.panelMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMap.Controls.Add(this.panelBoxMap);
            this.panelMap.Location = new System.Drawing.Point(3, 3);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(533, 533);
            this.panelMap.TabIndex = 0;
            // 
            // panelBoxMap
            // 
            this.panelBoxMap.AutoSize = true;
            this.panelBoxMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBoxMap.Location = new System.Drawing.Point(0, 0);
            this.panelBoxMap.Name = "panelBoxMap";
            this.panelBoxMap.Size = new System.Drawing.Size(529, 529);
            this.panelBoxMap.TabIndex = 45;
            this.panelBoxMap.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBoxMap_Paint);
            this.panelBoxMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBoxMap_MouseClick);
            this.panelBoxMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBoxMap_MouseDown);
            this.panelBoxMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBoxMap_MouseMove);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.panelCurrentPalette);
            this.tabPage1.Controls.Add(this.panelBoxVRAM);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(726, 538);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "VRAM";
            // 
            // panelCurrentPalette
            // 
            this.panelCurrentPalette.BackColor = System.Drawing.Color.Black;
            this.panelCurrentPalette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCurrentPalette.Location = new System.Drawing.Point(286, 3);
            this.panelCurrentPalette.Name = "panelCurrentPalette";
            this.panelCurrentPalette.Size = new System.Drawing.Size(262, 134);
            this.panelCurrentPalette.TabIndex = 48;
            this.panelCurrentPalette.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCurrentPalette_Paint);
            // 
            // panelBoxVRAM
            // 
            this.panelBoxVRAM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBoxVRAM.AutoScroll = true;
            this.panelBoxVRAM.BackColor = System.Drawing.Color.Black;
            this.panelBoxVRAM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBoxVRAM.Controls.Add(this.bufferPanelVRAM);
            this.panelBoxVRAM.Location = new System.Drawing.Point(3, 3);
            this.panelBoxVRAM.Name = "panelBoxVRAM";
            this.panelBoxVRAM.Size = new System.Drawing.Size(277, 532);
            this.panelBoxVRAM.TabIndex = 47;
            // 
            // bufferPanelVRAM
            // 
            this.bufferPanelVRAM.BackColor = System.Drawing.Color.Black;
            this.bufferPanelVRAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bufferPanelVRAM.Location = new System.Drawing.Point(0, 0);
            this.bufferPanelVRAM.Name = "bufferPanelVRAM";
            this.bufferPanelVRAM.Size = new System.Drawing.Size(273, 528);
            this.bufferPanelVRAM.TabIndex = 46;
            this.bufferPanelVRAM.Paint += new System.Windows.Forms.PaintEventHandler(this.bufferPanelVRAM_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTileMouse);
            this.tabPage2.Controls.Add(this.panelTilesetDisplay);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(726, 538);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Tileset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTileMouse
            // 
            this.labelTileMouse.AutoSize = true;
            this.labelTileMouse.Location = new System.Drawing.Point(525, 3);
            this.labelTileMouse.Name = "labelTileMouse";
            this.labelTileMouse.Size = new System.Drawing.Size(58, 13);
            this.labelTileMouse.TabIndex = 1;
            this.labelTileMouse.Text = "00, 00 (00)";
            // 
            // panelTilesetDisplay
            // 
            this.panelTilesetDisplay.BackColor = System.Drawing.Color.Black;
            this.panelTilesetDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTilesetDisplay.Location = new System.Drawing.Point(3, 3);
            this.panelTilesetDisplay.Name = "panelTilesetDisplay";
            this.panelTilesetDisplay.Size = new System.Drawing.Size(516, 516);
            this.panelTilesetDisplay.TabIndex = 0;
            this.panelTilesetDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTilemapDisplay_Paint);
            this.panelTilesetDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTilemapDisplay_MouseMove);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBoxDescriptors);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.groupBoxExits);
            this.tabPage3.Controls.Add(this.groupBoxNPCs);
            this.tabPage3.Controls.Add(this.groupBoxEvents);
            this.tabPage3.Controls.Add(this.textBoxMapProperties);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(726, 538);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Map Properties";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBoxDescriptors
            // 
            this.groupBoxDescriptors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDescriptors.Controls.Add(this.buttonInjectDescriptors);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorMusic);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorPalette);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorVRAMGraphics);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptortileBlocks);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorTileProperties);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorGraphicMaths);
            this.groupBoxDescriptors.Controls.Add(this.labelUnknown17);
            this.groupBoxDescriptors.Controls.Add(this.labelUnknown13);
            this.groupBoxDescriptors.Controls.Add(this.labelUnknown10);
            this.groupBoxDescriptors.Controls.Add(this.labelUnknown06);
            this.groupBoxDescriptors.Controls.Add(this.labelUnknown03);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorLocationName);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorId);
            this.groupBoxDescriptors.Controls.Add(this.labelDescriptorTilemaps);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor19);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor18);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor17);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor16);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor15);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor14);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor13);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor12);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor11);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor10);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor0F);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor0E);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor0D);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor0C);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor0B);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor0A);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor09);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor08);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor07);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor06);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor05);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor04);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor03);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor02);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor01);
            this.groupBoxDescriptors.Controls.Add(this.numericUpDownDescriptor00);
            this.groupBoxDescriptors.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDescriptors.Name = "groupBoxDescriptors";
            this.groupBoxDescriptors.Size = new System.Drawing.Size(449, 398);
            this.groupBoxDescriptors.TabIndex = 54;
            this.groupBoxDescriptors.TabStop = false;
            this.groupBoxDescriptors.Text = "Map descriptors";
            // 
            // buttonInjectDescriptors
            // 
            this.buttonInjectDescriptors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInjectDescriptors.Location = new System.Drawing.Point(368, 17);
            this.buttonInjectDescriptors.Name = "buttonInjectDescriptors";
            this.buttonInjectDescriptors.Size = new System.Drawing.Size(75, 23);
            this.buttonInjectDescriptors.TabIndex = 9;
            this.buttonInjectDescriptors.Text = "Inject";
            this.buttonInjectDescriptors.UseVisualStyleBackColor = true;
            this.buttonInjectDescriptors.Click += new System.EventHandler(this.buttonInjectDescriptors_Click);
            // 
            // labelDescriptorMusic
            // 
            this.labelDescriptorMusic.AutoSize = true;
            this.labelDescriptorMusic.Location = new System.Drawing.Point(7, 357);
            this.labelDescriptorMusic.Name = "labelDescriptorMusic";
            this.labelDescriptorMusic.Size = new System.Drawing.Size(35, 13);
            this.labelDescriptorMusic.TabIndex = 42;
            this.labelDescriptorMusic.Text = "Music";
            // 
            // labelDescriptorPalette
            // 
            this.labelDescriptorPalette.AutoSize = true;
            this.labelDescriptorPalette.Location = new System.Drawing.Point(7, 305);
            this.labelDescriptorPalette.Name = "labelDescriptorPalette";
            this.labelDescriptorPalette.Size = new System.Drawing.Size(40, 13);
            this.labelDescriptorPalette.TabIndex = 41;
            this.labelDescriptorPalette.Text = "Palette";
            // 
            // labelDescriptorVRAMGraphics
            // 
            this.labelDescriptorVRAMGraphics.AutoSize = true;
            this.labelDescriptorVRAMGraphics.Location = new System.Drawing.Point(7, 201);
            this.labelDescriptorVRAMGraphics.Name = "labelDescriptorVRAMGraphics";
            this.labelDescriptorVRAMGraphics.Size = new System.Drawing.Size(81, 13);
            this.labelDescriptorVRAMGraphics.TabIndex = 40;
            this.labelDescriptorVRAMGraphics.Text = "VRAM graphics";
            // 
            // labelDescriptortileBlocks
            // 
            this.labelDescriptortileBlocks.AutoSize = true;
            this.labelDescriptortileBlocks.Location = new System.Drawing.Point(7, 175);
            this.labelDescriptortileBlocks.Name = "labelDescriptortileBlocks";
            this.labelDescriptortileBlocks.Size = new System.Drawing.Size(58, 13);
            this.labelDescriptortileBlocks.TabIndex = 39;
            this.labelDescriptortileBlocks.Text = "Tile blocks";
            // 
            // labelDescriptorTileProperties
            // 
            this.labelDescriptorTileProperties.AutoSize = true;
            this.labelDescriptorTileProperties.Location = new System.Drawing.Point(7, 123);
            this.labelDescriptorTileProperties.Name = "labelDescriptorTileProperties";
            this.labelDescriptorTileProperties.Size = new System.Drawing.Size(73, 13);
            this.labelDescriptorTileProperties.TabIndex = 38;
            this.labelDescriptorTileProperties.Text = "Tile properties";
            // 
            // labelDescriptorGraphicMaths
            // 
            this.labelDescriptorGraphicMaths.AutoSize = true;
            this.labelDescriptorGraphicMaths.Location = new System.Drawing.Point(7, 97);
            this.labelDescriptorGraphicMaths.Name = "labelDescriptorGraphicMaths";
            this.labelDescriptorGraphicMaths.Size = new System.Drawing.Size(75, 13);
            this.labelDescriptorGraphicMaths.TabIndex = 37;
            this.labelDescriptorGraphicMaths.Text = "Graphic maths";
            // 
            // labelUnknown17
            // 
            this.labelUnknown17.AutoSize = true;
            this.labelUnknown17.Location = new System.Drawing.Point(7, 331);
            this.labelUnknown17.Name = "labelUnknown17";
            this.labelUnknown17.Size = new System.Drawing.Size(65, 13);
            this.labelUnknown17.TabIndex = 36;
            this.labelUnknown17.Text = "<Unknown>";
            // 
            // labelUnknown13
            // 
            this.labelUnknown13.AutoSize = true;
            this.labelUnknown13.Location = new System.Drawing.Point(7, 279);
            this.labelUnknown13.Name = "labelUnknown13";
            this.labelUnknown13.Size = new System.Drawing.Size(65, 13);
            this.labelUnknown13.TabIndex = 35;
            this.labelUnknown13.Text = "<Unknown>";
            // 
            // labelUnknown10
            // 
            this.labelUnknown10.AutoSize = true;
            this.labelUnknown10.Location = new System.Drawing.Point(7, 253);
            this.labelUnknown10.Name = "labelUnknown10";
            this.labelUnknown10.Size = new System.Drawing.Size(65, 13);
            this.labelUnknown10.TabIndex = 34;
            this.labelUnknown10.Text = "<Unknown>";
            // 
            // labelUnknown06
            // 
            this.labelUnknown06.AutoSize = true;
            this.labelUnknown06.Location = new System.Drawing.Point(7, 149);
            this.labelUnknown06.Name = "labelUnknown06";
            this.labelUnknown06.Size = new System.Drawing.Size(65, 13);
            this.labelUnknown06.TabIndex = 33;
            this.labelUnknown06.Text = "<Unknown>";
            // 
            // labelUnknown03
            // 
            this.labelUnknown03.AutoSize = true;
            this.labelUnknown03.Location = new System.Drawing.Point(7, 71);
            this.labelUnknown03.Name = "labelUnknown03";
            this.labelUnknown03.Size = new System.Drawing.Size(65, 13);
            this.labelUnknown03.TabIndex = 32;
            this.labelUnknown03.Text = "<Unknown>";
            // 
            // labelDescriptorLocationName
            // 
            this.labelDescriptorLocationName.AutoSize = true;
            this.labelDescriptorLocationName.Location = new System.Drawing.Point(7, 45);
            this.labelDescriptorLocationName.Name = "labelDescriptorLocationName";
            this.labelDescriptorLocationName.Size = new System.Drawing.Size(77, 13);
            this.labelDescriptorLocationName.TabIndex = 31;
            this.labelDescriptorLocationName.Text = "Location name";
            // 
            // labelDescriptorId
            // 
            this.labelDescriptorId.AutoSize = true;
            this.labelDescriptorId.Location = new System.Drawing.Point(7, 19);
            this.labelDescriptorId.Name = "labelDescriptorId";
            this.labelDescriptorId.Size = new System.Drawing.Size(15, 13);
            this.labelDescriptorId.TabIndex = 30;
            this.labelDescriptorId.Text = "id";
            // 
            // labelDescriptorTilemaps
            // 
            this.labelDescriptorTilemaps.AutoSize = true;
            this.labelDescriptorTilemaps.Location = new System.Drawing.Point(7, 227);
            this.labelDescriptorTilemaps.Name = "labelDescriptorTilemaps";
            this.labelDescriptorTilemaps.Size = new System.Drawing.Size(49, 13);
            this.labelDescriptorTilemaps.TabIndex = 29;
            this.labelDescriptorTilemaps.Text = "Tilemaps";
            // 
            // numericUpDownDescriptor19
            // 
            this.numericUpDownDescriptor19.Hexadecimal = true;
            this.numericUpDownDescriptor19.Location = new System.Drawing.Point(94, 355);
            this.numericUpDownDescriptor19.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor19.Name = "numericUpDownDescriptor19";
            this.numericUpDownDescriptor19.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor19.TabIndex = 28;
            // 
            // numericUpDownDescriptor18
            // 
            this.numericUpDownDescriptor18.Hexadecimal = true;
            this.numericUpDownDescriptor18.Location = new System.Drawing.Point(146, 329);
            this.numericUpDownDescriptor18.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor18.Name = "numericUpDownDescriptor18";
            this.numericUpDownDescriptor18.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor18.TabIndex = 27;
            // 
            // numericUpDownDescriptor17
            // 
            this.numericUpDownDescriptor17.Hexadecimal = true;
            this.numericUpDownDescriptor17.Location = new System.Drawing.Point(94, 329);
            this.numericUpDownDescriptor17.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor17.Name = "numericUpDownDescriptor17";
            this.numericUpDownDescriptor17.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor17.TabIndex = 26;
            // 
            // numericUpDownDescriptor16
            // 
            this.numericUpDownDescriptor16.Hexadecimal = true;
            this.numericUpDownDescriptor16.Location = new System.Drawing.Point(94, 303);
            this.numericUpDownDescriptor16.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor16.Name = "numericUpDownDescriptor16";
            this.numericUpDownDescriptor16.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor16.TabIndex = 25;
            // 
            // numericUpDownDescriptor15
            // 
            this.numericUpDownDescriptor15.Hexadecimal = true;
            this.numericUpDownDescriptor15.Location = new System.Drawing.Point(198, 277);
            this.numericUpDownDescriptor15.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor15.Name = "numericUpDownDescriptor15";
            this.numericUpDownDescriptor15.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor15.TabIndex = 24;
            // 
            // numericUpDownDescriptor14
            // 
            this.numericUpDownDescriptor14.Hexadecimal = true;
            this.numericUpDownDescriptor14.Location = new System.Drawing.Point(146, 277);
            this.numericUpDownDescriptor14.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor14.Name = "numericUpDownDescriptor14";
            this.numericUpDownDescriptor14.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor14.TabIndex = 23;
            // 
            // numericUpDownDescriptor13
            // 
            this.numericUpDownDescriptor13.Hexadecimal = true;
            this.numericUpDownDescriptor13.Location = new System.Drawing.Point(94, 277);
            this.numericUpDownDescriptor13.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor13.Name = "numericUpDownDescriptor13";
            this.numericUpDownDescriptor13.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor13.TabIndex = 22;
            // 
            // numericUpDownDescriptor12
            // 
            this.numericUpDownDescriptor12.Hexadecimal = true;
            this.numericUpDownDescriptor12.Location = new System.Drawing.Point(198, 251);
            this.numericUpDownDescriptor12.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor12.Name = "numericUpDownDescriptor12";
            this.numericUpDownDescriptor12.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor12.TabIndex = 21;
            // 
            // numericUpDownDescriptor11
            // 
            this.numericUpDownDescriptor11.Hexadecimal = true;
            this.numericUpDownDescriptor11.Location = new System.Drawing.Point(146, 251);
            this.numericUpDownDescriptor11.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor11.Name = "numericUpDownDescriptor11";
            this.numericUpDownDescriptor11.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor11.TabIndex = 20;
            // 
            // numericUpDownDescriptor10
            // 
            this.numericUpDownDescriptor10.Hexadecimal = true;
            this.numericUpDownDescriptor10.Location = new System.Drawing.Point(94, 251);
            this.numericUpDownDescriptor10.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor10.Name = "numericUpDownDescriptor10";
            this.numericUpDownDescriptor10.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor10.TabIndex = 19;
            // 
            // numericUpDownDescriptor0F
            // 
            this.numericUpDownDescriptor0F.Hexadecimal = true;
            this.numericUpDownDescriptor0F.Location = new System.Drawing.Point(250, 225);
            this.numericUpDownDescriptor0F.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor0F.Name = "numericUpDownDescriptor0F";
            this.numericUpDownDescriptor0F.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor0F.TabIndex = 18;
            // 
            // numericUpDownDescriptor0E
            // 
            this.numericUpDownDescriptor0E.Hexadecimal = true;
            this.numericUpDownDescriptor0E.Location = new System.Drawing.Point(198, 225);
            this.numericUpDownDescriptor0E.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor0E.Name = "numericUpDownDescriptor0E";
            this.numericUpDownDescriptor0E.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor0E.TabIndex = 17;
            // 
            // numericUpDownDescriptor0D
            // 
            this.numericUpDownDescriptor0D.Hexadecimal = true;
            this.numericUpDownDescriptor0D.Location = new System.Drawing.Point(146, 225);
            this.numericUpDownDescriptor0D.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor0D.Name = "numericUpDownDescriptor0D";
            this.numericUpDownDescriptor0D.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor0D.TabIndex = 16;
            // 
            // numericUpDownDescriptor0C
            // 
            this.numericUpDownDescriptor0C.Hexadecimal = true;
            this.numericUpDownDescriptor0C.Location = new System.Drawing.Point(94, 225);
            this.numericUpDownDescriptor0C.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor0C.Name = "numericUpDownDescriptor0C";
            this.numericUpDownDescriptor0C.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor0C.TabIndex = 15;
            // 
            // numericUpDownDescriptor0B
            // 
            this.numericUpDownDescriptor0B.Hexadecimal = true;
            this.numericUpDownDescriptor0B.Location = new System.Drawing.Point(198, 199);
            this.numericUpDownDescriptor0B.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor0B.Name = "numericUpDownDescriptor0B";
            this.numericUpDownDescriptor0B.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor0B.TabIndex = 14;
            // 
            // numericUpDownDescriptor0A
            // 
            this.numericUpDownDescriptor0A.Hexadecimal = true;
            this.numericUpDownDescriptor0A.Location = new System.Drawing.Point(146, 199);
            this.numericUpDownDescriptor0A.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor0A.Name = "numericUpDownDescriptor0A";
            this.numericUpDownDescriptor0A.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor0A.TabIndex = 13;
            // 
            // numericUpDownDescriptor09
            // 
            this.numericUpDownDescriptor09.Hexadecimal = true;
            this.numericUpDownDescriptor09.Location = new System.Drawing.Point(94, 199);
            this.numericUpDownDescriptor09.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor09.Name = "numericUpDownDescriptor09";
            this.numericUpDownDescriptor09.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor09.TabIndex = 12;
            // 
            // numericUpDownDescriptor08
            // 
            this.numericUpDownDescriptor08.Hexadecimal = true;
            this.numericUpDownDescriptor08.Location = new System.Drawing.Point(94, 173);
            this.numericUpDownDescriptor08.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor08.Name = "numericUpDownDescriptor08";
            this.numericUpDownDescriptor08.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor08.TabIndex = 11;
            // 
            // numericUpDownDescriptor07
            // 
            this.numericUpDownDescriptor07.Hexadecimal = true;
            this.numericUpDownDescriptor07.Location = new System.Drawing.Point(146, 147);
            this.numericUpDownDescriptor07.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor07.Name = "numericUpDownDescriptor07";
            this.numericUpDownDescriptor07.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor07.TabIndex = 10;
            // 
            // numericUpDownDescriptor06
            // 
            this.numericUpDownDescriptor06.Hexadecimal = true;
            this.numericUpDownDescriptor06.Location = new System.Drawing.Point(94, 147);
            this.numericUpDownDescriptor06.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor06.Name = "numericUpDownDescriptor06";
            this.numericUpDownDescriptor06.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor06.TabIndex = 9;
            // 
            // numericUpDownDescriptor05
            // 
            this.numericUpDownDescriptor05.Hexadecimal = true;
            this.numericUpDownDescriptor05.Location = new System.Drawing.Point(94, 121);
            this.numericUpDownDescriptor05.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor05.Name = "numericUpDownDescriptor05";
            this.numericUpDownDescriptor05.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor05.TabIndex = 8;
            // 
            // numericUpDownDescriptor04
            // 
            this.numericUpDownDescriptor04.Hexadecimal = true;
            this.numericUpDownDescriptor04.Location = new System.Drawing.Point(94, 95);
            this.numericUpDownDescriptor04.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor04.Name = "numericUpDownDescriptor04";
            this.numericUpDownDescriptor04.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor04.TabIndex = 7;
            // 
            // numericUpDownDescriptor03
            // 
            this.numericUpDownDescriptor03.Hexadecimal = true;
            this.numericUpDownDescriptor03.Location = new System.Drawing.Point(94, 69);
            this.numericUpDownDescriptor03.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor03.Name = "numericUpDownDescriptor03";
            this.numericUpDownDescriptor03.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor03.TabIndex = 6;
            // 
            // numericUpDownDescriptor02
            // 
            this.numericUpDownDescriptor02.Hexadecimal = true;
            this.numericUpDownDescriptor02.Location = new System.Drawing.Point(94, 43);
            this.numericUpDownDescriptor02.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor02.Name = "numericUpDownDescriptor02";
            this.numericUpDownDescriptor02.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor02.TabIndex = 5;
            // 
            // numericUpDownDescriptor01
            // 
            this.numericUpDownDescriptor01.Enabled = false;
            this.numericUpDownDescriptor01.Hexadecimal = true;
            this.numericUpDownDescriptor01.Location = new System.Drawing.Point(146, 17);
            this.numericUpDownDescriptor01.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor01.Name = "numericUpDownDescriptor01";
            this.numericUpDownDescriptor01.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor01.TabIndex = 4;
            // 
            // numericUpDownDescriptor00
            // 
            this.numericUpDownDescriptor00.Enabled = false;
            this.numericUpDownDescriptor00.Hexadecimal = true;
            this.numericUpDownDescriptor00.Location = new System.Drawing.Point(94, 17);
            this.numericUpDownDescriptor00.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDescriptor00.Name = "numericUpDownDescriptor00";
            this.numericUpDownDescriptor00.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownDescriptor00.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelTreasureDisplay);
            this.groupBox1.Controls.Add(this.buttonInjectTreasure);
            this.groupBox1.Controls.Add(this.labelTreasuresContentId);
            this.groupBox1.Controls.Add(this.numericUpDownTreasureContentId);
            this.groupBox1.Controls.Add(this.labelTreasuresModifier);
            this.groupBox1.Controls.Add(this.numericUpDownTreasureModifier);
            this.groupBox1.Controls.Add(this.labelTreasureContent);
            this.groupBox1.Controls.Add(this.comboBoxTreasureBehavior);
            this.groupBox1.Controls.Add(this.labelTreasureY);
            this.groupBox1.Controls.Add(this.comboBoxTreasures);
            this.groupBox1.Controls.Add(this.numericUpDownTreasureY);
            this.groupBox1.Controls.Add(this.labelTreasureX);
            this.groupBox1.Controls.Add(this.numericUpDownTreasureX);
            this.groupBox1.Location = new System.Drawing.Point(458, 407);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 128);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treasures";
            // 
            // labelTreasureDisplay
            // 
            this.labelTreasureDisplay.AutoSize = true;
            this.labelTreasureDisplay.Location = new System.Drawing.Point(121, 95);
            this.labelTreasureDisplay.Name = "labelTreasureDisplay";
            this.labelTreasureDisplay.Size = new System.Drawing.Size(53, 13);
            this.labelTreasureDisplay.TabIndex = 19;
            this.labelTreasureDisplay.Text = "<Display>";
            // 
            // buttonInjectTreasure
            // 
            this.buttonInjectTreasure.Location = new System.Drawing.Point(184, 17);
            this.buttonInjectTreasure.Name = "buttonInjectTreasure";
            this.buttonInjectTreasure.Size = new System.Drawing.Size(75, 23);
            this.buttonInjectTreasure.TabIndex = 16;
            this.buttonInjectTreasure.Text = "Inject";
            this.buttonInjectTreasure.UseVisualStyleBackColor = true;
            this.buttonInjectTreasure.Click += new System.EventHandler(this.buttonInjectTreasure_Click);
            // 
            // labelTreasuresContentId
            // 
            this.labelTreasuresContentId.AutoSize = true;
            this.labelTreasuresContentId.Location = new System.Drawing.Point(185, 47);
            this.labelTreasuresContentId.Name = "labelTreasuresContentId";
            this.labelTreasuresContentId.Size = new System.Drawing.Size(55, 13);
            this.labelTreasuresContentId.TabIndex = 18;
            this.labelTreasuresContentId.Text = "Content id";
            // 
            // numericUpDownTreasureContentId
            // 
            this.numericUpDownTreasureContentId.Hexadecimal = true;
            this.numericUpDownTreasureContentId.Location = new System.Drawing.Point(188, 63);
            this.numericUpDownTreasureContentId.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTreasureContentId.Name = "numericUpDownTreasureContentId";
            this.numericUpDownTreasureContentId.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTreasureContentId.TabIndex = 17;
            this.numericUpDownTreasureContentId.ValueChanged += new System.EventHandler(this.comboBoxTreasureProperty_SelectedIndexChanged);
            // 
            // labelTreasuresModifier
            // 
            this.labelTreasuresModifier.AutoSize = true;
            this.labelTreasuresModifier.Location = new System.Drawing.Point(64, 87);
            this.labelTreasuresModifier.Name = "labelTreasuresModifier";
            this.labelTreasuresModifier.Size = new System.Drawing.Size(44, 13);
            this.labelTreasuresModifier.TabIndex = 16;
            this.labelTreasuresModifier.Text = "Modifier";
            // 
            // numericUpDownTreasureModifier
            // 
            this.numericUpDownTreasureModifier.Hexadecimal = true;
            this.numericUpDownTreasureModifier.Location = new System.Drawing.Point(67, 103);
            this.numericUpDownTreasureModifier.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownTreasureModifier.Name = "numericUpDownTreasureModifier";
            this.numericUpDownTreasureModifier.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTreasureModifier.TabIndex = 15;
            this.numericUpDownTreasureModifier.ValueChanged += new System.EventHandler(this.comboBoxTreasureProperty_SelectedIndexChanged);
            // 
            // labelTreasureContent
            // 
            this.labelTreasureContent.AutoSize = true;
            this.labelTreasureContent.Location = new System.Drawing.Point(64, 46);
            this.labelTreasureContent.Name = "labelTreasureContent";
            this.labelTreasureContent.Size = new System.Drawing.Size(44, 13);
            this.labelTreasureContent.TabIndex = 14;
            this.labelTreasureContent.Text = "Content";
            // 
            // comboBoxTreasureBehavior
            // 
            this.comboBoxTreasureBehavior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreasureBehavior.FormattingEnabled = true;
            this.comboBoxTreasureBehavior.Items.AddRange(new object[] {
            "Money",
            "Spell",
            "Item",
            "????",
            "????",
            "Item + Enemies",
            "????",
            "Spell + Enemies"});
            this.comboBoxTreasureBehavior.Location = new System.Drawing.Point(67, 62);
            this.comboBoxTreasureBehavior.Name = "comboBoxTreasureBehavior";
            this.comboBoxTreasureBehavior.Size = new System.Drawing.Size(107, 21);
            this.comboBoxTreasureBehavior.TabIndex = 13;
            this.comboBoxTreasureBehavior.SelectedIndexChanged += new System.EventHandler(this.comboBoxTreasureProperty_SelectedIndexChanged);
            // 
            // labelTreasureY
            // 
            this.labelTreasureY.AutoSize = true;
            this.labelTreasureY.Location = new System.Drawing.Point(3, 87);
            this.labelTreasureY.Name = "labelTreasureY";
            this.labelTreasureY.Size = new System.Drawing.Size(12, 13);
            this.labelTreasureY.TabIndex = 12;
            this.labelTreasureY.Text = "y";
            // 
            // comboBoxTreasures
            // 
            this.comboBoxTreasures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTreasures.FormattingEnabled = true;
            this.comboBoxTreasures.Location = new System.Drawing.Point(6, 19);
            this.comboBoxTreasures.Name = "comboBoxTreasures";
            this.comboBoxTreasures.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTreasures.TabIndex = 1;
            this.comboBoxTreasures.SelectedIndexChanged += new System.EventHandler(this.comboBoxTreasures_SelectedIndexChanged);
            // 
            // numericUpDownTreasureY
            // 
            this.numericUpDownTreasureY.Hexadecimal = true;
            this.numericUpDownTreasureY.Location = new System.Drawing.Point(6, 103);
            this.numericUpDownTreasureY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTreasureY.Name = "numericUpDownTreasureY";
            this.numericUpDownTreasureY.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTreasureY.TabIndex = 11;
            // 
            // labelTreasureX
            // 
            this.labelTreasureX.AutoSize = true;
            this.labelTreasureX.Location = new System.Drawing.Point(6, 47);
            this.labelTreasureX.Name = "labelTreasureX";
            this.labelTreasureX.Size = new System.Drawing.Size(12, 13);
            this.labelTreasureX.TabIndex = 9;
            this.labelTreasureX.Text = "x";
            // 
            // numericUpDownTreasureX
            // 
            this.numericUpDownTreasureX.Hexadecimal = true;
            this.numericUpDownTreasureX.Location = new System.Drawing.Point(6, 63);
            this.numericUpDownTreasureX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownTreasureX.Name = "numericUpDownTreasureX";
            this.numericUpDownTreasureX.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTreasureX.TabIndex = 10;
            // 
            // groupBoxExits
            // 
            this.groupBoxExits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxExits.Controls.Add(this.labelExitProperties);
            this.groupBoxExits.Controls.Add(this.numericUpDownExitProperties);
            this.groupBoxExits.Controls.Add(this.labelExitDestinationY);
            this.groupBoxExits.Controls.Add(this.labelExitDestinationX);
            this.groupBoxExits.Controls.Add(this.labelExitMapID);
            this.groupBoxExits.Controls.Add(this.labelExitOriginY);
            this.groupBoxExits.Controls.Add(this.labelExitOriginX);
            this.groupBoxExits.Controls.Add(this.buttonInjectExit);
            this.groupBoxExits.Controls.Add(this.numericUpDownExitDestinationY);
            this.groupBoxExits.Controls.Add(this.numericUpDownExitDestinationX);
            this.groupBoxExits.Controls.Add(this.numericUpDownExitMapId);
            this.groupBoxExits.Controls.Add(this.numericUpDownExitOriginY);
            this.groupBoxExits.Controls.Add(this.numericUpDownExitOriginX);
            this.groupBoxExits.Controls.Add(this.comboBoxExits);
            this.groupBoxExits.Location = new System.Drawing.Point(458, 272);
            this.groupBoxExits.Name = "groupBoxExits";
            this.groupBoxExits.Size = new System.Drawing.Size(265, 129);
            this.groupBoxExits.TabIndex = 52;
            this.groupBoxExits.TabStop = false;
            this.groupBoxExits.Text = "Exits";
            // 
            // labelExitProperties
            // 
            this.labelExitProperties.AutoSize = true;
            this.labelExitProperties.Location = new System.Drawing.Point(64, 87);
            this.labelExitProperties.Name = "labelExitProperties";
            this.labelExitProperties.Size = new System.Drawing.Size(54, 13);
            this.labelExitProperties.TabIndex = 15;
            this.labelExitProperties.Text = "Properties";
            // 
            // numericUpDownExitProperties
            // 
            this.numericUpDownExitProperties.Hexadecimal = true;
            this.numericUpDownExitProperties.Location = new System.Drawing.Point(67, 103);
            this.numericUpDownExitProperties.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numericUpDownExitProperties.Name = "numericUpDownExitProperties";
            this.numericUpDownExitProperties.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExitProperties.TabIndex = 14;
            // 
            // labelExitDestinationY
            // 
            this.labelExitDestinationY.AutoSize = true;
            this.labelExitDestinationY.Location = new System.Drawing.Point(138, 87);
            this.labelExitDestinationY.Name = "labelExitDestinationY";
            this.labelExitDestinationY.Size = new System.Drawing.Size(40, 13);
            this.labelExitDestinationY.TabIndex = 13;
            this.labelExitDestinationY.Text = "Dest. y";
            // 
            // labelExitDestinationX
            // 
            this.labelExitDestinationX.AutoSize = true;
            this.labelExitDestinationX.Location = new System.Drawing.Point(138, 48);
            this.labelExitDestinationX.Name = "labelExitDestinationX";
            this.labelExitDestinationX.Size = new System.Drawing.Size(40, 13);
            this.labelExitDestinationX.TabIndex = 12;
            this.labelExitDestinationX.Text = "Dest. x";
            // 
            // labelExitMapID
            // 
            this.labelExitMapID.AutoSize = true;
            this.labelExitMapID.Location = new System.Drawing.Point(64, 48);
            this.labelExitMapID.Name = "labelExitMapID";
            this.labelExitMapID.Size = new System.Drawing.Size(39, 13);
            this.labelExitMapID.TabIndex = 11;
            this.labelExitMapID.Text = "Map id";
            // 
            // labelExitOriginY
            // 
            this.labelExitOriginY.AutoSize = true;
            this.labelExitOriginY.Location = new System.Drawing.Point(6, 87);
            this.labelExitOriginY.Name = "labelExitOriginY";
            this.labelExitOriginY.Size = new System.Drawing.Size(42, 13);
            this.labelExitOriginY.TabIndex = 10;
            this.labelExitOriginY.Text = "Origin y";
            // 
            // labelExitOriginX
            // 
            this.labelExitOriginX.AutoSize = true;
            this.labelExitOriginX.Location = new System.Drawing.Point(6, 48);
            this.labelExitOriginX.Name = "labelExitOriginX";
            this.labelExitOriginX.Size = new System.Drawing.Size(42, 13);
            this.labelExitOriginX.TabIndex = 9;
            this.labelExitOriginX.Text = "Origin x";
            // 
            // buttonInjectExit
            // 
            this.buttonInjectExit.Location = new System.Drawing.Point(184, 17);
            this.buttonInjectExit.Name = "buttonInjectExit";
            this.buttonInjectExit.Size = new System.Drawing.Size(75, 23);
            this.buttonInjectExit.TabIndex = 8;
            this.buttonInjectExit.Text = "Inject";
            this.buttonInjectExit.UseVisualStyleBackColor = true;
            this.buttonInjectExit.Click += new System.EventHandler(this.buttonInjectExit_Click);
            // 
            // numericUpDownExitDestinationY
            // 
            this.numericUpDownExitDestinationY.Hexadecimal = true;
            this.numericUpDownExitDestinationY.Location = new System.Drawing.Point(141, 103);
            this.numericUpDownExitDestinationY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownExitDestinationY.Name = "numericUpDownExitDestinationY";
            this.numericUpDownExitDestinationY.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExitDestinationY.TabIndex = 7;
            // 
            // numericUpDownExitDestinationX
            // 
            this.numericUpDownExitDestinationX.Hexadecimal = true;
            this.numericUpDownExitDestinationX.Location = new System.Drawing.Point(141, 64);
            this.numericUpDownExitDestinationX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownExitDestinationX.Name = "numericUpDownExitDestinationX";
            this.numericUpDownExitDestinationX.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExitDestinationX.TabIndex = 6;
            // 
            // numericUpDownExitMapId
            // 
            this.numericUpDownExitMapId.Hexadecimal = true;
            this.numericUpDownExitMapId.Location = new System.Drawing.Point(67, 64);
            this.numericUpDownExitMapId.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.numericUpDownExitMapId.Name = "numericUpDownExitMapId";
            this.numericUpDownExitMapId.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownExitMapId.TabIndex = 5;
            // 
            // numericUpDownExitOriginY
            // 
            this.numericUpDownExitOriginY.Hexadecimal = true;
            this.numericUpDownExitOriginY.Location = new System.Drawing.Point(6, 103);
            this.numericUpDownExitOriginY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownExitOriginY.Name = "numericUpDownExitOriginY";
            this.numericUpDownExitOriginY.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExitOriginY.TabIndex = 4;
            // 
            // numericUpDownExitOriginX
            // 
            this.numericUpDownExitOriginX.Hexadecimal = true;
            this.numericUpDownExitOriginX.Location = new System.Drawing.Point(6, 64);
            this.numericUpDownExitOriginX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownExitOriginX.Name = "numericUpDownExitOriginX";
            this.numericUpDownExitOriginX.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExitOriginX.TabIndex = 3;
            // 
            // comboBoxExits
            // 
            this.comboBoxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExits.FormattingEnabled = true;
            this.comboBoxExits.Location = new System.Drawing.Point(6, 19);
            this.comboBoxExits.Name = "comboBoxExits";
            this.comboBoxExits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExits.TabIndex = 1;
            this.comboBoxExits.SelectedIndexChanged += new System.EventHandler(this.comboBoxExits_SelectedIndexChanged);
            // 
            // groupBoxNPCs
            // 
            this.groupBoxNPCs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxNPCs.Controls.Add(this.buttonInjectNPC);
            this.groupBoxNPCs.Controls.Add(this.panelNPCSprite);
            this.groupBoxNPCs.Controls.Add(this.label4);
            this.groupBoxNPCs.Controls.Add(this.comboBoxNPCs);
            this.groupBoxNPCs.Controls.Add(this.numericUpDownNPCsGraphicId);
            this.groupBoxNPCs.Controls.Add(this.label5);
            this.groupBoxNPCs.Controls.Add(this.numericUpDownNPCsX);
            this.groupBoxNPCs.Controls.Add(this.label6);
            this.groupBoxNPCs.Controls.Add(this.numericUpDownNPCsY);
            this.groupBoxNPCs.Controls.Add(this.label7);
            this.groupBoxNPCs.Controls.Add(this.numericUpDownNPCsActionID);
            this.groupBoxNPCs.Controls.Add(this.label8);
            this.groupBoxNPCs.Controls.Add(this.numericUpDownNPCsWP);
            this.groupBoxNPCs.Controls.Add(this.label9);
            this.groupBoxNPCs.Controls.Add(this.numericUpDownNPCsProperties);
            this.groupBoxNPCs.Location = new System.Drawing.Point(458, 138);
            this.groupBoxNPCs.Name = "groupBoxNPCs";
            this.groupBoxNPCs.Size = new System.Drawing.Size(265, 128);
            this.groupBoxNPCs.TabIndex = 51;
            this.groupBoxNPCs.TabStop = false;
            this.groupBoxNPCs.Text = "NPCs";
            // 
            // buttonInjectNPC
            // 
            this.buttonInjectNPC.Location = new System.Drawing.Point(184, 17);
            this.buttonInjectNPC.Name = "buttonInjectNPC";
            this.buttonInjectNPC.Size = new System.Drawing.Size(75, 23);
            this.buttonInjectNPC.TabIndex = 30;
            this.buttonInjectNPC.Text = "Inject";
            this.buttonInjectNPC.UseVisualStyleBackColor = true;
            this.buttonInjectNPC.Click += new System.EventHandler(this.buttonInjectNPC_Click);
            // 
            // panelNPCSprite
            // 
            this.panelNPCSprite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNPCSprite.Location = new System.Drawing.Point(191, 54);
            this.panelNPCSprite.Name = "panelNPCSprite";
            this.panelNPCSprite.Size = new System.Drawing.Size(68, 68);
            this.panelNPCSprite.TabIndex = 29;
            this.panelNPCSprite.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNPCSprite_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Graphic id";
            // 
            // comboBoxNPCs
            // 
            this.comboBoxNPCs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNPCs.FormattingEnabled = true;
            this.comboBoxNPCs.Location = new System.Drawing.Point(6, 19);
            this.comboBoxNPCs.Name = "comboBoxNPCs";
            this.comboBoxNPCs.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNPCs.TabIndex = 1;
            this.comboBoxNPCs.SelectedIndexChanged += new System.EventHandler(this.comboBoxNPCs_SelectedIndexChanged);
            // 
            // numericUpDownNPCsGraphicId
            // 
            this.numericUpDownNPCsGraphicId.Hexadecimal = true;
            this.numericUpDownNPCsGraphicId.Location = new System.Drawing.Point(6, 102);
            this.numericUpDownNPCsGraphicId.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownNPCsGraphicId.Name = "numericUpDownNPCsGraphicId";
            this.numericUpDownNPCsGraphicId.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNPCsGraphicId.TabIndex = 27;
            this.numericUpDownNPCsGraphicId.ValueChanged += new System.EventHandler(this.numericUpDownNPCsProperty_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Properties";
            // 
            // numericUpDownNPCsX
            // 
            this.numericUpDownNPCsX.Hexadecimal = true;
            this.numericUpDownNPCsX.Location = new System.Drawing.Point(72, 63);
            this.numericUpDownNPCsX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownNPCsX.Name = "numericUpDownNPCsX";
            this.numericUpDownNPCsX.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNPCsX.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Walk. p.";
            // 
            // numericUpDownNPCsY
            // 
            this.numericUpDownNPCsY.Hexadecimal = true;
            this.numericUpDownNPCsY.Location = new System.Drawing.Point(72, 102);
            this.numericUpDownNPCsY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownNPCsY.Name = "numericUpDownNPCsY";
            this.numericUpDownNPCsY.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNPCsY.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Action id";
            // 
            // numericUpDownNPCsActionID
            // 
            this.numericUpDownNPCsActionID.Hexadecimal = true;
            this.numericUpDownNPCsActionID.Location = new System.Drawing.Point(6, 63);
            this.numericUpDownNPCsActionID.Maximum = new decimal(new int[] {
            65355,
            0,
            0,
            0});
            this.numericUpDownNPCsActionID.Name = "numericUpDownNPCsActionID";
            this.numericUpDownNPCsActionID.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownNPCsActionID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "y";
            // 
            // numericUpDownNPCsWP
            // 
            this.numericUpDownNPCsWP.Hexadecimal = true;
            this.numericUpDownNPCsWP.Location = new System.Drawing.Point(124, 63);
            this.numericUpDownNPCsWP.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownNPCsWP.Name = "numericUpDownNPCsWP";
            this.numericUpDownNPCsWP.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNPCsWP.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "x";
            // 
            // numericUpDownNPCsProperties
            // 
            this.numericUpDownNPCsProperties.Hexadecimal = true;
            this.numericUpDownNPCsProperties.Location = new System.Drawing.Point(124, 102);
            this.numericUpDownNPCsProperties.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownNPCsProperties.Name = "numericUpDownNPCsProperties";
            this.numericUpDownNPCsProperties.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownNPCsProperties.TabIndex = 21;
            this.numericUpDownNPCsProperties.ValueChanged += new System.EventHandler(this.numericUpDownNPCsProperty_ValueChanged);
            // 
            // groupBoxEvents
            // 
            this.groupBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEvents.Controls.Add(this.buttonEventDisplay);
            this.groupBoxEvents.Controls.Add(this.buttonInjectEvent);
            this.groupBoxEvents.Controls.Add(this.labelEventsID);
            this.groupBoxEvents.Controls.Add(this.labelEventsY);
            this.groupBoxEvents.Controls.Add(this.numericUpDownEventID);
            this.groupBoxEvents.Controls.Add(this.numericUpDownEventY);
            this.groupBoxEvents.Controls.Add(this.numericUpDownEventX);
            this.groupBoxEvents.Controls.Add(this.labelEventX);
            this.groupBoxEvents.Controls.Add(this.comboBoxEvents);
            this.groupBoxEvents.Location = new System.Drawing.Point(458, 3);
            this.groupBoxEvents.Name = "groupBoxEvents";
            this.groupBoxEvents.Size = new System.Drawing.Size(265, 129);
            this.groupBoxEvents.TabIndex = 50;
            this.groupBoxEvents.TabStop = false;
            this.groupBoxEvents.Text = "Events";
            // 
            // buttonEventDisplay
            // 
            this.buttonEventDisplay.Location = new System.Drawing.Point(67, 100);
            this.buttonEventDisplay.Name = "buttonEventDisplay";
            this.buttonEventDisplay.Size = new System.Drawing.Size(60, 23);
            this.buttonEventDisplay.TabIndex = 8;
            this.buttonEventDisplay.Text = "Preview";
            this.buttonEventDisplay.UseVisualStyleBackColor = true;
            this.buttonEventDisplay.Click += new System.EventHandler(this.buttonEventDisplay_Click);
            // 
            // buttonInjectEvent
            // 
            this.buttonInjectEvent.Location = new System.Drawing.Point(184, 17);
            this.buttonInjectEvent.Name = "buttonInjectEvent";
            this.buttonInjectEvent.Size = new System.Drawing.Size(75, 23);
            this.buttonInjectEvent.TabIndex = 7;
            this.buttonInjectEvent.Text = "Inject";
            this.buttonInjectEvent.UseVisualStyleBackColor = true;
            this.buttonInjectEvent.Click += new System.EventHandler(this.buttonInjectEvent_Click);
            // 
            // labelEventsID
            // 
            this.labelEventsID.AutoSize = true;
            this.labelEventsID.Location = new System.Drawing.Point(64, 47);
            this.labelEventsID.Name = "labelEventsID";
            this.labelEventsID.Size = new System.Drawing.Size(46, 13);
            this.labelEventsID.TabIndex = 6;
            this.labelEventsID.Text = "Event id";
            // 
            // labelEventsY
            // 
            this.labelEventsY.AutoSize = true;
            this.labelEventsY.Location = new System.Drawing.Point(3, 87);
            this.labelEventsY.Name = "labelEventsY";
            this.labelEventsY.Size = new System.Drawing.Size(12, 13);
            this.labelEventsY.TabIndex = 5;
            this.labelEventsY.Text = "y";
            // 
            // numericUpDownEventID
            // 
            this.numericUpDownEventID.Hexadecimal = true;
            this.numericUpDownEventID.Location = new System.Drawing.Point(67, 63);
            this.numericUpDownEventID.Maximum = new decimal(new int[] {
            687,
            0,
            0,
            0});
            this.numericUpDownEventID.Name = "numericUpDownEventID";
            this.numericUpDownEventID.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownEventID.TabIndex = 4;
            // 
            // numericUpDownEventY
            // 
            this.numericUpDownEventY.Hexadecimal = true;
            this.numericUpDownEventY.Location = new System.Drawing.Point(6, 103);
            this.numericUpDownEventY.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEventY.Name = "numericUpDownEventY";
            this.numericUpDownEventY.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownEventY.TabIndex = 3;
            // 
            // numericUpDownEventX
            // 
            this.numericUpDownEventX.Hexadecimal = true;
            this.numericUpDownEventX.Location = new System.Drawing.Point(6, 63);
            this.numericUpDownEventX.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEventX.Name = "numericUpDownEventX";
            this.numericUpDownEventX.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownEventX.TabIndex = 2;
            // 
            // labelEventX
            // 
            this.labelEventX.AutoSize = true;
            this.labelEventX.Location = new System.Drawing.Point(6, 47);
            this.labelEventX.Name = "labelEventX";
            this.labelEventX.Size = new System.Drawing.Size(12, 13);
            this.labelEventX.TabIndex = 1;
            this.labelEventX.Text = "x";
            // 
            // comboBoxEvents
            // 
            this.comboBoxEvents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvents.FormattingEnabled = true;
            this.comboBoxEvents.Location = new System.Drawing.Point(6, 19);
            this.comboBoxEvents.Name = "comboBoxEvents";
            this.comboBoxEvents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEvents.TabIndex = 0;
            this.comboBoxEvents.SelectedIndexChanged += new System.EventHandler(this.comboBoxEvents_SelectedIndexChanged);
            // 
            // textBoxMapProperties
            // 
            this.textBoxMapProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMapProperties.Location = new System.Drawing.Point(3, 407);
            this.textBoxMapProperties.Multiline = true;
            this.textBoxMapProperties.Name = "textBoxMapProperties";
            this.textBoxMapProperties.ReadOnly = true;
            this.textBoxMapProperties.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxMapProperties.Size = new System.Drawing.Size(449, 128);
            this.textBoxMapProperties.TabIndex = 49;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.groupBoxenemyFormations);
            this.tabPage4.Controls.Add(this.labelMapEncounters);
            this.tabPage4.Controls.Add(this.textBoxMapEncounters);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(726, 538);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Encounters";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelMapEncounters
            // 
            this.labelMapEncounters.AutoSize = true;
            this.labelMapEncounters.Location = new System.Drawing.Point(9, 3);
            this.labelMapEncounters.Name = "labelMapEncounters";
            this.labelMapEncounters.Size = new System.Drawing.Size(120, 13);
            this.labelMapEncounters.TabIndex = 51;
            this.labelMapEncounters.Text = "Current map encounters";
            // 
            // textBoxMapEncounters
            // 
            this.textBoxMapEncounters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMapEncounters.Location = new System.Drawing.Point(3, 19);
            this.textBoxMapEncounters.Multiline = true;
            this.textBoxMapEncounters.Name = "textBoxMapEncounters";
            this.textBoxMapEncounters.ReadOnly = true;
            this.textBoxMapEncounters.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxMapEncounters.Size = new System.Drawing.Size(449, 393);
            this.textBoxMapEncounters.TabIndex = 50;
            // 
            // numericUpDownEnemyFormations
            // 
            this.numericUpDownEnemyFormations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownEnemyFormations.Hexadecimal = true;
            this.numericUpDownEnemyFormations.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownEnemyFormations.Maximum = new decimal(new int[] {
            511,
            0,
            0,
            0});
            this.numericUpDownEnemyFormations.Name = "numericUpDownEnemyFormations";
            this.numericUpDownEnemyFormations.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownEnemyFormations.TabIndex = 45;
            this.numericUpDownEnemyFormations.ValueChanged += new System.EventHandler(this.numericUpDownEnemyFormations_ValueChanged);
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(752, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSMCToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openSMCToolStripMenuItem
            // 
            this.openSMCToolStripMenuItem.Name = "openSMCToolStripMenuItem";
            this.openSMCToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.openSMCToolStripMenuItem.Text = "Open ROM";
            this.openSMCToolStripMenuItem.Click += new System.EventHandler(this.openSMCToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // groupBoxenemyFormations
            // 
            this.groupBoxenemyFormations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxenemyFormations.Controls.Add(this.labelEnemyFormation);
            this.groupBoxenemyFormations.Controls.Add(this.numericUpDownEnemyFormations);
            this.groupBoxenemyFormations.Location = new System.Drawing.Point(458, 3);
            this.groupBoxenemyFormations.Name = "groupBoxenemyFormations";
            this.groupBoxenemyFormations.Size = new System.Drawing.Size(265, 409);
            this.groupBoxenemyFormations.TabIndex = 52;
            this.groupBoxenemyFormations.TabStop = false;
            this.groupBoxenemyFormations.Text = "Enemy formations viewer";
            // 
            // labelEnemyFormation
            // 
            this.labelEnemyFormation.AutoSize = true;
            this.labelEnemyFormation.Location = new System.Drawing.Point(6, 42);
            this.labelEnemyFormation.Name = "labelEnemyFormation";
            this.labelEnemyFormation.Size = new System.Drawing.Size(19, 13);
            this.labelEnemyFormation.TabIndex = 46;
            this.labelEnemyFormation.Text = "<>";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labelEnemyGroups);
            this.groupBox2.Controls.Add(this.numericUpDownEnemyGroups);
            this.groupBox2.Location = new System.Drawing.Point(3, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 117);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enemy groups viewer";
            // 
            // labelEnemyGroups
            // 
            this.labelEnemyGroups.AutoSize = true;
            this.labelEnemyGroups.Location = new System.Drawing.Point(6, 42);
            this.labelEnemyGroups.Name = "labelEnemyGroups";
            this.labelEnemyGroups.Size = new System.Drawing.Size(19, 13);
            this.labelEnemyGroups.TabIndex = 46;
            this.labelEnemyGroups.Text = "<>";
            // 
            // numericUpDownEnemyGroups
            // 
            this.numericUpDownEnemyGroups.Hexadecimal = true;
            this.numericUpDownEnemyGroups.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownEnemyGroups.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownEnemyGroups.Name = "numericUpDownEnemyGroups";
            this.numericUpDownEnemyGroups.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownEnemyGroups.TabIndex = 45;
            this.numericUpDownEnemyGroups.ValueChanged += new System.EventHandler(this.numericUpDownEnemyGroups_ValueChanged);
            // 
            // Main_Map_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(768, 634);
            this.Name = "Main_Map_Editor";
            this.Text = "FF5e_Map_Editor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuadrant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedTileBg01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSelectedTileBg00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMap)).EndInit();
            this.panelMap.ResumeLayout(false);
            this.panelMap.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panelBoxVRAM.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBoxDescriptors.ResumeLayout(false);
            this.groupBoxDescriptors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0F)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor0A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor09)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDescriptor00)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureContentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTreasureX)).EndInit();
            this.groupBoxExits.ResumeLayout(false);
            this.groupBoxExits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitDestinationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitDestinationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitMapId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitOriginY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExitOriginX)).EndInit();
            this.groupBoxNPCs.ResumeLayout(false);
            this.groupBoxNPCs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsGraphicId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsActionID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsWP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNPCsProperties)).EndInit();
            this.groupBoxEvents.ResumeLayout(false);
            this.groupBoxEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEventX)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnemyFormations)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxenemyFormations.ResumeLayout(false);
            this.groupBoxenemyFormations.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnemyGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage0;
        private Main_Map_Editor.BufferPanel panelMap;
        private System.Windows.Forms.NumericUpDown numericUpDownMap;
        private Main_Map_Editor.BufferPanel panelBoxMap;
        private System.Windows.Forms.CheckBox checkBoxBg01;
        private System.Windows.Forms.CheckBox checkBoxBg02;
        private System.Windows.Forms.CheckBox checkBoxBg00;
        private System.Windows.Forms.Label labelPointedTile;
        private System.Windows.Forms.CheckBox checkBoxBgWalls;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label labelPointedTileBg0;
        private System.Windows.Forms.Label labelPointedTileBg1;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedTileBg00;
        private System.Windows.Forms.NumericUpDown numericUpDownSelectedTileBg01;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveBg00;
        private System.Windows.Forms.Button buttonSaveBg01;
        private System.Windows.Forms.CheckBox checkBoxBgNPCs;
        private System.Windows.Forms.Button buttonZoom;
        private System.Windows.Forms.TabPage tabPage1;
        private Main_Map_Editor.BufferPanel bufferPanelVRAM;
        private Main_Map_Editor.BufferPanel panelBoxVRAM;
        private Main_Map_Editor.BufferPanel panelCurrentPalette;
        private System.Windows.Forms.NumericUpDown numericUpDownZoom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMapProperties;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.NumericUpDown numericUpDownQuadrant;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelTilesetDisplay;
        private System.Windows.Forms.Label labelTileMouse;
        private System.Windows.Forms.Panel panelCurrenTile;
        private System.Windows.Forms.Label labelLocationName;
        private System.Windows.Forms.CheckBox checkBoxBgMiscs;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBoxEvents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxExits;
        private System.Windows.Forms.GroupBox groupBoxNPCs;
        private System.Windows.Forms.ComboBox comboBoxTreasures;
        private System.Windows.Forms.ComboBox comboBoxExits;
        private System.Windows.Forms.ComboBox comboBoxNPCs;
        private System.Windows.Forms.ComboBox comboBoxEvents;
        private System.Windows.Forms.Label labelEventsID;
        private System.Windows.Forms.Label labelEventsY;
        private System.Windows.Forms.NumericUpDown numericUpDownEventID;
        private System.Windows.Forms.NumericUpDown numericUpDownEventY;
        private System.Windows.Forms.NumericUpDown numericUpDownEventX;
        private System.Windows.Forms.Label labelEventX;
        private System.Windows.Forms.Button buttonInjectEvent;
        private System.Windows.Forms.Button buttonInjectExit;
        private System.Windows.Forms.NumericUpDown numericUpDownExitDestinationY;
        private System.Windows.Forms.NumericUpDown numericUpDownExitDestinationX;
        private System.Windows.Forms.NumericUpDown numericUpDownExitMapId;
        private System.Windows.Forms.NumericUpDown numericUpDownExitOriginY;
        private System.Windows.Forms.NumericUpDown numericUpDownExitOriginX;
        private System.Windows.Forms.Label labelExitDestinationY;
        private System.Windows.Forms.Label labelExitDestinationX;
        private System.Windows.Forms.Label labelExitMapID;
        private System.Windows.Forms.Label labelExitOriginY;
        private System.Windows.Forms.Label labelExitOriginX;
        private System.Windows.Forms.Label labelExitProperties;
        private System.Windows.Forms.NumericUpDown numericUpDownExitProperties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCsGraphicId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCsX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCsY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCsActionID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCsWP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownNPCsProperties;
        private System.Windows.Forms.Panel panelNPCSprite;
        private System.Windows.Forms.Button buttonInjectNPC;
        private System.Windows.Forms.Button buttonEventDisplay;
        private System.Windows.Forms.GroupBox groupBoxDescriptors;
        private System.Windows.Forms.Label labelTreasureY;
        private System.Windows.Forms.NumericUpDown numericUpDownTreasureY;
        private System.Windows.Forms.Label labelTreasureX;
        private System.Windows.Forms.NumericUpDown numericUpDownTreasureX;
        private System.Windows.Forms.ComboBox comboBoxTreasureBehavior;
        private System.Windows.Forms.Label labelTreasuresContentId;
        private System.Windows.Forms.NumericUpDown numericUpDownTreasureContentId;
        private System.Windows.Forms.Label labelTreasuresModifier;
        private System.Windows.Forms.NumericUpDown numericUpDownTreasureModifier;
        private System.Windows.Forms.Label labelTreasureContent;
        private System.Windows.Forms.Label labelTreasureDisplay;
        private System.Windows.Forms.Button buttonInjectTreasure;
        private System.Windows.Forms.Label labelDescriptorMusic;
        private System.Windows.Forms.Label labelDescriptorPalette;
        private System.Windows.Forms.Label labelDescriptorVRAMGraphics;
        private System.Windows.Forms.Label labelDescriptortileBlocks;
        private System.Windows.Forms.Label labelDescriptorTileProperties;
        private System.Windows.Forms.Label labelDescriptorGraphicMaths;
        private System.Windows.Forms.Label labelUnknown17;
        private System.Windows.Forms.Label labelUnknown13;
        private System.Windows.Forms.Label labelUnknown10;
        private System.Windows.Forms.Label labelUnknown06;
        private System.Windows.Forms.Label labelUnknown03;
        private System.Windows.Forms.Label labelDescriptorLocationName;
        private System.Windows.Forms.Label labelDescriptorId;
        private System.Windows.Forms.Label labelDescriptorTilemaps;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor19;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor18;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor17;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor16;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor15;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor14;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor13;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor12;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor11;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor10;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor0F;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor0E;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor0D;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor0C;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor0B;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor0A;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor09;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor08;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor07;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor06;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor05;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor04;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor03;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor02;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor01;
        private System.Windows.Forms.NumericUpDown numericUpDownDescriptor00;
        private System.Windows.Forms.Button buttonInjectDescriptors;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numericUpDownEnemyFormations;
        private System.Windows.Forms.Label labelMapEncounters;
        private System.Windows.Forms.TextBox textBoxMapEncounters;
        private System.Windows.Forms.GroupBox groupBoxenemyFormations;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEnemyGroups;
        private System.Windows.Forms.NumericUpDown numericUpDownEnemyGroups;
        private System.Windows.Forms.Label labelEnemyFormation;
    }
}


namespace FF5e_Map_Editor
{
    partial class DisplayTileset
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayTileset));
            this.panelTilesetDisplay = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.labelTileMouse = new System.Windows.Forms.Label();
            this.groupBoxClipboard = new System.Windows.Forms.GroupBox();
            this.checkBoxBg01 = new System.Windows.Forms.CheckBox();
            this.checkBoxBg00 = new System.Windows.Forms.CheckBox();
            this.panelClipboard = new System.Windows.Forms.Panel();
            this.groupBoxClipboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTilesetDisplay
            // 
            this.panelTilesetDisplay.BackColor = System.Drawing.Color.Black;
            this.panelTilesetDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTilesetDisplay.Location = new System.Drawing.Point(12, 12);
            this.panelTilesetDisplay.Name = "panelTilesetDisplay";
            this.panelTilesetDisplay.Size = new System.Drawing.Size(516, 516);
            this.panelTilesetDisplay.TabIndex = 0;
            this.panelTilesetDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTilemapDisplay_Paint);
            this.panelTilesetDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTilesetDisplay_MouseClick);
            this.panelTilesetDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTilemapDisplay_MouseMove);
            // 
            // labelTileMouse
            // 
            this.labelTileMouse.AutoSize = true;
            this.labelTileMouse.Location = new System.Drawing.Point(535, 13);
            this.labelTileMouse.Name = "labelTileMouse";
            this.labelTileMouse.Size = new System.Drawing.Size(58, 13);
            this.labelTileMouse.TabIndex = 1;
            this.labelTileMouse.Text = "00, 00 (00)";
            // 
            // groupBoxClipboard
            // 
            this.groupBoxClipboard.Controls.Add(this.checkBoxBg01);
            this.groupBoxClipboard.Controls.Add(this.checkBoxBg00);
            this.groupBoxClipboard.Controls.Add(this.panelClipboard);
            this.groupBoxClipboard.Location = new System.Drawing.Point(534, 347);
            this.groupBoxClipboard.Name = "groupBoxClipboard";
            this.groupBoxClipboard.Size = new System.Drawing.Size(181, 181);
            this.groupBoxClipboard.TabIndex = 2;
            this.groupBoxClipboard.TabStop = false;
            this.groupBoxClipboard.Text = "Clipboard";
            // 
            // checkBoxBg01
            // 
            this.checkBoxBg01.Location = new System.Drawing.Point(6, 42);
            this.checkBoxBg01.Name = "checkBoxBg01";
            this.checkBoxBg01.Size = new System.Drawing.Size(80, 17);
            this.checkBoxBg01.TabIndex = 6;
            this.checkBoxBg01.Text = "Bg 01";
            this.checkBoxBg01.UseVisualStyleBackColor = true;
            this.checkBoxBg01.CheckedChanged += new System.EventHandler(this.checkBoxBg0x_CheckedChanged);
            // 
            // checkBoxBg00
            // 
            this.checkBoxBg00.Location = new System.Drawing.Point(6, 19);
            this.checkBoxBg00.Name = "checkBoxBg00";
            this.checkBoxBg00.Size = new System.Drawing.Size(80, 17);
            this.checkBoxBg00.TabIndex = 0;
            this.checkBoxBg00.Text = "Bg 00";
            this.checkBoxBg00.UseVisualStyleBackColor = true;
            this.checkBoxBg00.CheckedChanged += new System.EventHandler(this.checkBoxBg0x_CheckedChanged);
            // 
            // panelClipboard
            // 
            this.panelClipboard.BackColor = System.Drawing.Color.Black;
            this.panelClipboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelClipboard.Location = new System.Drawing.Point(75, 75);
            this.panelClipboard.Name = "panelClipboard";
            this.panelClipboard.Size = new System.Drawing.Size(100, 100);
            this.panelClipboard.TabIndex = 5;
            this.panelClipboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClipboard_Paint);
            // 
            // DisplayTileset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 540);
            this.Controls.Add(this.groupBoxClipboard);
            this.Controls.Add(this.labelTileMouse);
            this.Controls.Add(this.panelTilesetDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayTileset";
            this.Text = "Display tileset";
            this.groupBoxClipboard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTileMouse;
        private Main_Map_Editor.BufferPanel panelTilesetDisplay;
        private System.Windows.Forms.GroupBox groupBoxClipboard;
        private System.Windows.Forms.Panel panelClipboard;
        private System.Windows.Forms.CheckBox checkBoxBg01;
        private System.Windows.Forms.CheckBox checkBoxBg00;
    }
}
namespace FF5e_Map_Editor
{
    partial class DisplayTilemap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayTilemap));
            this.panelTilemapDisplay = new FF5e_Map_Editor.Main_Map_Editor.BufferPanel();
            this.labelTileMouse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelTilemapDisplay
            // 
            this.panelTilemapDisplay.BackColor = System.Drawing.Color.Black;
            this.panelTilemapDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTilemapDisplay.Location = new System.Drawing.Point(12, 12);
            this.panelTilemapDisplay.Name = "panelTilemapDisplay";
            this.panelTilemapDisplay.Size = new System.Drawing.Size(516, 516);
            this.panelTilemapDisplay.TabIndex = 0;
            this.panelTilemapDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTilemapDisplay_Paint);
            this.panelTilemapDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTilemapDisplay_MouseMove);
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
            // DisplayTilemap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 540);
            this.Controls.Add(this.labelTileMouse);
            this.Controls.Add(this.panelTilemapDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayTilemap";
            this.Text = "Display tilemap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTileMouse;
        private Main_Map_Editor.BufferPanel panelTilemapDisplay;
    }
}
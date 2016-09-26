namespace FF5e_Map_Editor
{
    partial class DisplayEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayEvent));
            this.listViewPreviews = new System.Windows.Forms.ListView();
            this.Column00 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column01 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Column02 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelEventIDText = new System.Windows.Forms.Label();
            this.labelCoordinatesText = new System.Windows.Forms.Label();
            this.labelEventID = new System.Windows.Forms.Label();
            this.labelCoordinates = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPreviews
            // 
            this.listViewPreviews.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewPreviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPreviews.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Column00,
            this.Column01,
            this.Column02});
            this.listViewPreviews.FullRowSelect = true;
            this.listViewPreviews.GridLines = true;
            this.listViewPreviews.Location = new System.Drawing.Point(12, 42);
            this.listViewPreviews.Name = "listViewPreviews";
            this.listViewPreviews.Size = new System.Drawing.Size(614, 417);
            this.listViewPreviews.TabIndex = 1;
            this.listViewPreviews.UseCompatibleStateImageBehavior = false;
            this.listViewPreviews.View = System.Windows.Forms.View.Details;
            // 
            // Column00
            // 
            this.Column00.Text = "Address";
            this.Column00.Width = 100;
            // 
            // Column01
            // 
            this.Column01.Text = "Bytes";
            this.Column01.Width = 175;
            // 
            // Column02
            // 
            this.Column02.Text = "Description";
            this.Column02.Width = 331;
            // 
            // labelEventIDText
            // 
            this.labelEventIDText.AutoSize = true;
            this.labelEventIDText.Location = new System.Drawing.Point(12, 9);
            this.labelEventIDText.Name = "labelEventIDText";
            this.labelEventIDText.Size = new System.Drawing.Size(52, 13);
            this.labelEventIDText.TabIndex = 2;
            this.labelEventIDText.Text = "Event ID:";
            // 
            // labelCoordinatesText
            // 
            this.labelCoordinatesText.AutoSize = true;
            this.labelCoordinatesText.Location = new System.Drawing.Point(12, 26);
            this.labelCoordinatesText.Name = "labelCoordinatesText";
            this.labelCoordinatesText.Size = new System.Drawing.Size(66, 13);
            this.labelCoordinatesText.TabIndex = 3;
            this.labelCoordinatesText.Text = "Coordinates:";
            // 
            // labelEventID
            // 
            this.labelEventID.AutoSize = true;
            this.labelEventID.Location = new System.Drawing.Point(84, 9);
            this.labelEventID.Name = "labelEventID";
            this.labelEventID.Size = new System.Drawing.Size(31, 13);
            this.labelEventID.TabIndex = 4;
            this.labelEventID.Text = "0000";
            // 
            // labelCoordinates
            // 
            this.labelCoordinates.AutoSize = true;
            this.labelCoordinates.Location = new System.Drawing.Point(84, 26);
            this.labelCoordinates.Name = "labelCoordinates";
            this.labelCoordinates.Size = new System.Drawing.Size(37, 13);
            this.labelCoordinates.TabIndex = 5;
            this.labelCoordinates.Text = "00, 00";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(551, 13);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // DisplayEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 471);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.labelCoordinates);
            this.Controls.Add(this.labelEventID);
            this.Controls.Add(this.labelCoordinatesText);
            this.Controls.Add(this.labelEventIDText);
            this.Controls.Add(this.listViewPreviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayEvent";
            this.Text = "Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPreviews;
        private System.Windows.Forms.ColumnHeader Column00;
        private System.Windows.Forms.ColumnHeader Column01;
        private System.Windows.Forms.ColumnHeader Column02;
        private System.Windows.Forms.Label labelEventIDText;
        private System.Windows.Forms.Label labelCoordinatesText;
        private System.Windows.Forms.Label labelEventID;
        private System.Windows.Forms.Label labelCoordinates;
        private System.Windows.Forms.Button buttonCopy;
    }
}
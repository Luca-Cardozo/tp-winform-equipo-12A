namespace winform_app
{
    partial class frmAltaModificacionImagen
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
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.dgvImagenes = new System.Windows.Forms.DataGridView();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.txtAgregarImagen = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(465, 49);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(486, 281);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // dgvImagenes
            // 
            this.dgvImagenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagenes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagenes.Location = new System.Drawing.Point(52, 49);
            this.dgvImagenes.MultiSelect = false;
            this.dgvImagenes.Name = "dgvImagenes";
            this.dgvImagenes.RowHeadersWidth = 51;
            this.dgvImagenes.RowTemplate.Height = 24;
            this.dgvImagenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagenes.Size = new System.Drawing.Size(361, 281);
            this.dgvImagenes.TabIndex = 1;
            this.dgvImagenes.SelectionChanged += new System.EventHandler(this.dgvImagenes_SelectionChanged);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Location = new System.Drawing.Point(465, 355);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(182, 35);
            this.btnAgregarImagen.TabIndex = 2;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtAgregarImagen
            // 
            this.txtAgregarImagen.Location = new System.Drawing.Point(52, 361);
            this.txtAgregarImagen.Name = "txtAgregarImagen";
            this.txtAgregarImagen.Size = new System.Drawing.Size(361, 22);
            this.txtAgregarImagen.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(886, 418);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAltaModificacionImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 465);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAgregarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.pbxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAltaModificacionImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaModificacionImagen";
            this.Load += new System.EventHandler(this.frmAltaModificacionImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.DataGridView dgvImagenes;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.TextBox txtAgregarImagen;
        private System.Windows.Forms.Button btnSalir;
    }
}
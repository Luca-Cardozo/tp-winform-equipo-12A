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
            this.txtModificarImagen = new System.Windows.Forms.TextBox();
            this.btnModificarImagen = new System.Windows.Forms.Button();
            this.btnEliminarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagenes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btnAgregarImagen.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarImagen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.Location = new System.Drawing.Point(465, 355);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(208, 35);
            this.btnAgregarImagen.TabIndex = 2;
            this.btnAgregarImagen.Text = "Agregar Imagen";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // txtAgregarImagen
            // 
            this.txtAgregarImagen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgregarImagen.Location = new System.Drawing.Point(52, 361);
            this.txtAgregarImagen.Name = "txtAgregarImagen";
            this.txtAgregarImagen.Size = new System.Drawing.Size(361, 25);
            this.txtAgregarImagen.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(864, 406);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtModificarImagen
            // 
            this.txtModificarImagen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarImagen.Location = new System.Drawing.Point(52, 406);
            this.txtModificarImagen.Name = "txtModificarImagen";
            this.txtModificarImagen.Size = new System.Drawing.Size(361, 25);
            this.txtModificarImagen.TabIndex = 6;
            // 
            // btnModificarImagen
            // 
            this.btnModificarImagen.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarImagen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarImagen.ForeColor = System.Drawing.Color.White;
            this.btnModificarImagen.Location = new System.Drawing.Point(465, 400);
            this.btnModificarImagen.Name = "btnModificarImagen";
            this.btnModificarImagen.Size = new System.Drawing.Size(208, 35);
            this.btnModificarImagen.TabIndex = 5;
            this.btnModificarImagen.Text = "Modificar Imagen";
            this.btnModificarImagen.UseVisualStyleBackColor = false;
            this.btnModificarImagen.Click += new System.EventHandler(this.btnModificarImagen_Click);
            // 
            // btnEliminarImagen
            // 
            this.btnEliminarImagen.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarImagen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarImagen.ForeColor = System.Drawing.Color.White;
            this.btnEliminarImagen.Location = new System.Drawing.Point(769, 354);
            this.btnEliminarImagen.Name = "btnEliminarImagen";
            this.btnEliminarImagen.Size = new System.Drawing.Size(182, 36);
            this.btnEliminarImagen.TabIndex = 7;
            this.btnEliminarImagen.Text = "Eliminar Imagen";
            this.btnEliminarImagen.UseVisualStyleBackColor = false;
            this.btnEliminarImagen.Click += new System.EventHandler(this.btnEliminarImagen_Click);
            // 
            // frmAltaModificacionImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1003, 491);
            this.Controls.Add(this.btnEliminarImagen);
            this.Controls.Add(this.txtModificarImagen);
            this.Controls.Add(this.btnModificarImagen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtAgregarImagen);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.dgvImagenes);
            this.Controls.Add(this.pbxImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAltaModificacionImagen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Imágenes";
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
        private System.Windows.Forms.TextBox txtModificarImagen;
        private System.Windows.Forms.Button btnModificarImagen;
        private System.Windows.Forms.Button btnEliminarImagen;
    }
}
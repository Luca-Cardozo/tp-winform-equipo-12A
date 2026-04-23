namespace winform_app
{
    partial class frmDetalleArticulo
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.lblImagen = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(315, 49);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(148, 16);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción del Artículo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(152, 68);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(475, 22);
            this.txtDescripcion.TabIndex = 1;
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(167, 161);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(443, 283);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagen.TabIndex = 2;
            this.pbxImagen.TabStop = false;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(315, 122);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(111, 16);
            this.lblImagen.TabIndex = 3;
            this.lblImagen.Text = "Imagen ilustrativa";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(466, 460);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(144, 45);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente Imagen";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(167, 460);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(144, 45);
            this.btnAnterior.TabIndex = 5;
            this.btnAnterior.Text = "Anterior Imagen";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(756, 460);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 45);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 517);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.pbxImagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSalir;
    }
}
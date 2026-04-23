namespace winform_app
{
    partial class frmCatalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogo));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnCargarCatalogo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctsCat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCat = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ctsMar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMar = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAgregarImagen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvArticulos.Location = new System.Drawing.Point(239, 198);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(860, 303);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.TabStop = false;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(40, 206);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(161, 43);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarProducto.Location = new System.Drawing.Point(40, 277);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(158, 45);
            this.btnModificarProducto.TabIndex = 2;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(40, 343);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(157, 43);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.BackColor = System.Drawing.Color.SeaGreen;
            this.lblFiltroRapido.ForeColor = System.Drawing.Color.White;
            this.lblFiltroRapido.Location = new System.Drawing.Point(240, 165);
            this.lblFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(135, 24);
            this.lblFiltroRapido.TabIndex = 4;
            this.lblFiltroRapido.Text = "Filtrar por nombre";
            this.lblFiltroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.BackColor = System.Drawing.Color.White;
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroRapido.Location = new System.Drawing.Point(403, 165);
            this.txtFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(234, 27);
            this.txtFiltroRapido.TabIndex = 5;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1122, 560);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 29);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCampo.ForeColor = System.Drawing.Color.White;
            this.lblCampo.Location = new System.Drawing.Point(226, 557);
            this.lblCampo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(77, 24);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo:";
            this.lblCampo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCriterio
            // 
            this.lblCriterio.BackColor = System.Drawing.Color.SeaGreen;
            this.lblCriterio.ForeColor = System.Drawing.Color.White;
            this.lblCriterio.Location = new System.Drawing.Point(544, 560);
            this.lblCriterio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(77, 24);
            this.lblCriterio.TabIndex = 8;
            this.lblCriterio.Text = "Criterio:";
            this.lblCriterio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFiltro
            // 
            this.lblFiltro.BackColor = System.Drawing.Color.SeaGreen;
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(816, 560);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(77, 24);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Filtro:";
            this.lblFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(311, 557);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(166, 28);
            this.cboCampo.TabIndex = 10;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.Color.White;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(629, 560);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(166, 28);
            this.cboCriterio.TabIndex = 11;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Location = new System.Drawing.Point(901, 560);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(194, 27);
            this.txtFiltro.TabIndex = 12;
            // 
            // btnCargarCatalogo
            // 
            this.btnCargarCatalogo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCargarCatalogo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCargarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCargarCatalogo.Location = new System.Drawing.Point(40, 419);
            this.btnCargarCatalogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarCatalogo.Name = "btnCargarCatalogo";
            this.btnCargarCatalogo.Size = new System.Drawing.Size(157, 63);
            this.btnCargarCatalogo.TabIndex = 13;
            this.btnCargarCatalogo.Text = "Cargar catálogo completo";
            this.btnCargarCatalogo.UseVisualStyleBackColor = false;
            this.btnCargarCatalogo.Click += new System.EventHandler(this.btnCargarCatalogo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsCat,
            this.ctsMar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1282, 48);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctsCat
            // 
            this.ctsCat.BackColor = System.Drawing.Color.SeaGreen;
            this.ctsCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCat,
            this.eliminarToolStripMenuItem1});
            this.ctsCat.ForeColor = System.Drawing.Color.Black;
            this.ctsCat.Name = "ctsCat";
            this.ctsCat.Size = new System.Drawing.Size(88, 42);
            this.ctsCat.Text = "Categoría";
            // 
            // tsmCat
            // 
            this.tsmCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.tsmCat.Name = "tsmCat";
            this.tsmCat.Size = new System.Drawing.Size(216, 26);
            this.tsmCat.Text = "Agregar/Modificar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click_1);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // ctsMar
            // 
            this.ctsMar.BackColor = System.Drawing.Color.SeaGreen;
            this.ctsMar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMar,
            this.eliminarToolStripMenuItem});
            this.ctsMar.ForeColor = System.Drawing.Color.Black;
            this.ctsMar.Name = "ctsMar";
            this.ctsMar.Size = new System.Drawing.Size(64, 42);
            this.ctsMar.Text = "Marca";
            // 
            // tsmMar
            // 
            this.tsmMar.BackColor = System.Drawing.SystemColors.Control;
            this.tsmMar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem1});
            this.tsmMar.Name = "tsmMar";
            this.tsmMar.Size = new System.Drawing.Size(216, 26);
            this.tsmMar.Text = "Agregar/Modificar";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click_1);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(156, 26);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDetalle.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(1112, 323);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(157, 63);
            this.btnDetalle.TabIndex = 15;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.btnAgregarImagen,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1282, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 24);
            this.toolStripLabel1.Text = "Administrar Imágenes";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImagen.Image")));
            this.btnAgregarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(29, 24);
            this.btnAgregarImagen.Text = "toolStripButton1";
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1282, 691);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnCargarCatalogo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltroRapido);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnModificarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de artículos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCatalogo_FormClosing);
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Label lblFiltroRapido;
        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnCargarCatalogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctsCat;
        private System.Windows.Forms.ToolStripMenuItem tsmCat;
        private System.Windows.Forms.ToolStripMenuItem ctsMar;
        private System.Windows.Forms.ToolStripMenuItem tsmMar;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnAgregarImagen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}


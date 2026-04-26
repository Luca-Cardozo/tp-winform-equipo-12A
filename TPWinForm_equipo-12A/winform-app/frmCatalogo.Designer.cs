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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tsLabelCat = new System.Windows.Forms.ToolStripLabel();
            this.tscboCategorias = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnAgregarImagen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblFiltroRapidoMarca = new System.Windows.Forms.Label();
            this.lblFilroRapidoCategoria = new System.Windows.Forms.Label();
            this.txtFiltroMarca = new System.Windows.Forms.TextBox();
            this.txtFiltroCategoria = new System.Windows.Forms.TextBox();
            this.tsLabelMar = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tscboMarcas = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvArticulos.Location = new System.Drawing.Point(230, 142);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(859, 303);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.TabStop = false;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(30, 150);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(177, 43);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarProducto.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarProducto.Location = new System.Drawing.Point(30, 211);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(177, 45);
            this.btnModificarProducto.TabIndex = 2;
            this.btnModificarProducto.Text = "Modificar Producto";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            this.btnModificarProducto.MouseEnter += new System.EventHandler(this.btnModificarProducto_MouseEnter);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(30, 277);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(177, 43);
            this.btnEliminarProducto.TabIndex = 3;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            this.btnEliminarProducto.MouseEnter += new System.EventHandler(this.btnEliminarProducto_MouseEnter);
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.BackColor = System.Drawing.Color.SeaGreen;
            this.lblFiltroRapido.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapido.ForeColor = System.Drawing.Color.White;
            this.lblFiltroRapido.Location = new System.Drawing.Point(230, 109);
            this.lblFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(94, 24);
            this.lblFiltroRapido.TabIndex = 4;
            this.lblFiltroRapido.Text = "Nombre:";
            this.lblFiltroRapido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.BackColor = System.Drawing.Color.White;
            this.txtFiltroRapido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroRapido.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroRapido.Location = new System.Drawing.Point(332, 109);
            this.txtFiltroRapido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(166, 21);
            this.txtFiltroRapido.TabIndex = 5;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(1102, 467);
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
            this.lblCampo.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampo.ForeColor = System.Drawing.Color.White;
            this.lblCampo.Location = new System.Drawing.Point(230, 464);
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
            this.lblCriterio.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterio.ForeColor = System.Drawing.Color.White;
            this.lblCriterio.Location = new System.Drawing.Point(548, 467);
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
            this.lblFiltro.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.White;
            this.lblFiltro.Location = new System.Drawing.Point(820, 467);
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
            this.cboCampo.Location = new System.Drawing.Point(315, 464);
            this.cboCampo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(166, 23);
            this.cboCampo.TabIndex = 10;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.BackColor = System.Drawing.Color.White;
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(633, 467);
            this.cboCriterio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(166, 23);
            this.cboCriterio.TabIndex = 11;
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.Color.White;
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(905, 467);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(184, 21);
            this.txtFiltro.TabIndex = 12;
            // 
            // btnCargarCatalogo
            // 
            this.btnCargarCatalogo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCargarCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarCatalogo.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCargarCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarCatalogo.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnCargarCatalogo.Location = new System.Drawing.Point(30, 382);
            this.btnCargarCatalogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCargarCatalogo.Name = "btnCargarCatalogo";
            this.btnCargarCatalogo.Size = new System.Drawing.Size(177, 63);
            this.btnCargarCatalogo.TabIndex = 13;
            this.btnCargarCatalogo.Text = "Cargar catálogo completo";
            this.btnCargarCatalogo.UseVisualStyleBackColor = false;
            this.btnCargarCatalogo.Click += new System.EventHandler(this.btnCargarCatalogo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Beige;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctsCat,
            this.ctsMar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1285, 48);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctsCat
            // 
            this.ctsCat.BackColor = System.Drawing.Color.Beige;
            this.ctsCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCat,
            this.eliminarToolStripMenuItem1});
            this.ctsCat.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctsCat.ForeColor = System.Drawing.Color.Black;
            this.ctsCat.Name = "ctsCat";
            this.ctsCat.Size = new System.Drawing.Size(79, 42);
            this.ctsCat.Text = "&Categoría";
            // 
            // tsmCat
            // 
            this.tsmCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.tsmCat.Name = "tsmCat";
            this.tsmCat.Size = new System.Drawing.Size(188, 22);
            this.tsmCat.Text = "&Agregar/Modificar";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.agregarToolStripMenuItem.Text = "&Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click_1);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.modificarToolStripMenuItem.Text = "&Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.eliminarToolStripMenuItem1.Text = "&Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // ctsMar
            // 
            this.ctsMar.BackColor = System.Drawing.Color.Beige;
            this.ctsMar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMar,
            this.eliminarToolStripMenuItem});
            this.ctsMar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctsMar.ForeColor = System.Drawing.Color.Black;
            this.ctsMar.Name = "ctsMar";
            this.ctsMar.Size = new System.Drawing.Size(58, 42);
            this.ctsMar.Text = "&Marca";
            // 
            // tsmMar
            // 
            this.tsmMar.BackColor = System.Drawing.SystemColors.Control;
            this.tsmMar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.modificarToolStripMenuItem1});
            this.tsmMar.Name = "tsmMar";
            this.tsmMar.Size = new System.Drawing.Size(188, 22);
            this.tsmMar.Text = "&Agregar/Modificar";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.agregarToolStripMenuItem1.Text = "&Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click_1);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.modificarToolStripMenuItem1.Text = "&Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.eliminarToolStripMenuItem.Text = "&Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDetalle.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Location = new System.Drawing.Point(1102, 267);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(157, 63);
            this.btnDetalle.TabIndex = 15;
            this.btnDetalle.Text = "Ver detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            this.btnDetalle.MouseEnter += new System.EventHandler(this.btnDetalle_MouseEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelCat,
            this.tscboCategorias,
            this.toolStripSeparator3,
            this.tsLabelMar,
            this.tscboMarcas,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.btnAgregarImagen,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 48);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1285, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsLabelCat
            // 
            this.tsLabelCat.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabelCat.Image = ((System.Drawing.Image)(resources.GetObject("tsLabelCat.Image")));
            this.tsLabelCat.Name = "tsLabelCat";
            this.tsLabelCat.Size = new System.Drawing.Size(155, 24);
            this.tsLabelCat.Text = "Filtrar por categoría:";
            // 
            // tscboCategorias
            // 
            this.tscboCategorias.Name = "tscboCategorias";
            this.tscboCategorias.Size = new System.Drawing.Size(121, 27);
            this.tscboCategorias.SelectedIndexChanged += new System.EventHandler(this.tscboCategorias_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(144, 24);
            this.toolStripLabel1.Text = "Administrar Imágenes";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregarImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarImagen.Image")));
            this.btnAgregarImagen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(24, 24);
            this.btnAgregarImagen.Text = "toolStripButton1";
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1285, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblFiltroRapidoMarca
            // 
            this.lblFiltroRapidoMarca.BackColor = System.Drawing.Color.SeaGreen;
            this.lblFiltroRapidoMarca.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroRapidoMarca.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFiltroRapidoMarca.Location = new System.Drawing.Point(517, 110);
            this.lblFiltroRapidoMarca.Name = "lblFiltroRapidoMarca";
            this.lblFiltroRapidoMarca.Size = new System.Drawing.Size(94, 24);
            this.lblFiltroRapidoMarca.TabIndex = 18;
            this.lblFiltroRapidoMarca.Text = "Marca:";
            this.lblFiltroRapidoMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFilroRapidoCategoria
            // 
            this.lblFilroRapidoCategoria.BackColor = System.Drawing.Color.SeaGreen;
            this.lblFilroRapidoCategoria.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilroRapidoCategoria.ForeColor = System.Drawing.Color.White;
            this.lblFilroRapidoCategoria.Location = new System.Drawing.Point(803, 111);
            this.lblFilroRapidoCategoria.Name = "lblFilroRapidoCategoria";
            this.lblFilroRapidoCategoria.Size = new System.Drawing.Size(94, 24);
            this.lblFilroRapidoCategoria.TabIndex = 19;
            this.lblFilroRapidoCategoria.Text = "Categoría:";
            this.lblFilroRapidoCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFiltroMarca
            // 
            this.txtFiltroMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroMarca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroMarca.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroMarca.Location = new System.Drawing.Point(617, 110);
            this.txtFiltroMarca.Name = "txtFiltroMarca";
            this.txtFiltroMarca.Size = new System.Drawing.Size(166, 21);
            this.txtFiltroMarca.TabIndex = 20;
            this.txtFiltroMarca.TextChanged += new System.EventHandler(this.txtFiltroMarca_TextChanged);
            // 
            // txtFiltroCategoria
            // 
            this.txtFiltroCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltroCategoria.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroCategoria.Location = new System.Drawing.Point(905, 111);
            this.txtFiltroCategoria.Name = "txtFiltroCategoria";
            this.txtFiltroCategoria.Size = new System.Drawing.Size(166, 21);
            this.txtFiltroCategoria.TabIndex = 21;
            this.txtFiltroCategoria.TextChanged += new System.EventHandler(this.txtFiltroCategoria_TextChanged);
            // 
            // tsLabelMar
            // 
            this.tsLabelMar.Font = new System.Drawing.Font("Constantia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsLabelMar.Image = ((System.Drawing.Image)(resources.GetObject("tsLabelMar.Image")));
            this.tsLabelMar.Name = "tsLabelMar";
            this.tsLabelMar.Size = new System.Drawing.Size(155, 24);
            this.tsLabelMar.Text = "Filtrar por categoría:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tscboMarcas
            // 
            this.tscboMarcas.Name = "tscboMarcas";
            this.tscboMarcas.Size = new System.Drawing.Size(121, 27);
            this.tscboMarcas.SelectedIndexChanged += new System.EventHandler(this.tscboMarcas_SelectedIndexChanged);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1285, 574);
            this.Controls.Add(this.txtFiltroCategoria);
            this.Controls.Add(this.txtFiltroMarca);
            this.Controls.Add(this.lblFilroRapidoCategoria);
            this.Controls.Add(this.lblFiltroRapidoMarca);
            this.Controls.Add(this.statusStrip1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label lblFiltroRapidoMarca;
        private System.Windows.Forms.Label lblFilroRapidoCategoria;
        private System.Windows.Forms.TextBox txtFiltroMarca;
        private System.Windows.Forms.TextBox txtFiltroCategoria;
        private System.Windows.Forms.ToolStripLabel tsLabelCat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox tscboCategorias;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsLabelMar;
        private System.Windows.Forms.ToolStripComboBox tscboMarcas;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace winform_app
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("F");
            cargar();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
            cboCampo.Items.Add("Precio");
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
                dgvArticulos.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 12, FontStyle.Bold);
                dgvArticulos.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvArticulos.ColumnHeadersHeight = 30;
                dgvArticulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ocultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
        }

        private void frmCatalogo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea cerrar la aplicación?", "Atención: cierre del programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No) e.Cancel = true;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmAltaModificacionArticulo alta = new frmAltaModificacionArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccioná un artículo primero");
                return;
            }

            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;


            frmAltaModificacionArticulo form = new frmAltaModificacionArticulo(seleccionado);
            form.ShowDialog();


            cargar();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Seleccioná un artículo primero");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que querés eliminar este artículo?",
                "Eliminar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            try
            {
                if (respuesta == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.eliminar(seleccionado.Id);

                    MessageBox.Show("Eliminado correctamente");

                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
                ocultarColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;


            string filtro = txtFiltroRapido.Text;
            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "C2";
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Mayor o igual a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Menor o igual a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        public bool validarFiltro()
        {
            if (cboCampo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un campo para filtrar", "Atención campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cboCriterio.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un criterio para filtrar", "Atención criterio vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty((txtFiltro.Text)))
                {
                    MessageBox.Show("Por favor, ingrese un número para filtrar", "Atención filtro vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                if (!(soloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Por favor, ingrese solo números", "Atención filtro vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }

        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnCargarCatalogo_Click(object sender, EventArgs e)
        {
            try
            {
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void agregarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string data = ctsCat.Text;
            Form frm = new frmAltaModificacionCategoriaMarca(data, "Agregar");
            frm.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = ctsCat.Text;
            Form frm = new frmAltaModificacionCategoriaMarca(data, "Modificar");
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string data = ctsCat.Text;
            Form frm = new frmAltaModificacionCategoriaMarca(data, "Eliminar");
            frm.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            string data = ctsMar.Text;
            Form frm = new frmAltaModificacionCategoriaMarca(data, "Agregar");
            frm.ShowDialog();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string data = ctsMar.Text;
            Form frm = new frmAltaModificacionCategoriaMarca(data, "Modificar");
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string data = ctsMar.Text;
            Form frm = new frmAltaModificacionCategoriaMarca(data, "Eliminar");
            frm.ShowDialog();
        }


        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Articulo artSeleccionado = null;
                if (e.RowIndex >= 0)
                {
                    artSeleccionado = (Articulo)dgvArticulos.Rows[e.RowIndex].DataBoundItem;
                }
                if (artSeleccionado != null)
                {
                    frmAltaModificacionArticulo formAltaArticulo = new frmAltaModificacionArticulo(artSeleccionado);
                    formAltaArticulo.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo Válido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Debe seleccionar una fila para ver el detalle del artículo", "Atención: detalle del producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalleArticulo ventanaDetalle = new frmDetalleArticulo(seleccionado);
                ventanaDetalle.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Debe seleccionar una fila para administrar las imágenes del artículo", "Atención: imágenes del producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Articulo seleccionado;
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaModificacionImagen ventanaImagenes = new frmAltaModificacionImagen(seleccionado);
                ventanaImagenes.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("F");
        }

        private void cambiarCursorBotones(Button boton)
        {
            if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                boton.Cursor = Cursors.No;
            else
                boton.Cursor = Cursors.Hand;
        }

        private void btnModificarProducto_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                cambiarCursorBotones(btnModificarProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminarProducto_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                cambiarCursorBotones(btnEliminarProducto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalle_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                cambiarCursorBotones(btnDetalle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

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
    public partial class frmAltaModificacionArticulo : Form
    {
        
        private Articulo articulo = null;
        public frmAltaModificacionArticulo()
        {
            InitializeComponent();
            Text = "Nuevo Artículo";
        }
        public frmAltaModificacionArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private bool chequearVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
           

            if (chequearVacio(txtCodigo.Text))
            {
                MessageBox.Show("El código es obligatorio");
                return;
            }

            if (!int.TryParse(txtCodigo.Text, out _))
            {
                MessageBox.Show("El código debe ser numérico");
                return;
            }

            if (chequearVacio(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            if (chequearVacio(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción es obligatoria");
                return;
            }

            if (chequearVacio(txtPrecio.Text))
            {
                MessageBox.Show("El precio es obligatorio");
                return;
            }
            if (articulo == null)
                articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            /// estan preestablecidos hasta que se cree el ambde cada uno
            articulo.Marca = new Marca();
            articulo.Marca.Id = 1;

            articulo.Categoria = new Categoria();
            articulo.Categoria.Id = 1;

            articulo.Precio = decimal.Parse(txtPrecio.Text);

            if (articulo.Id != 0)
                negocio.modificar(articulo);
            else
                negocio.agregar(articulo);

            MessageBox.Show("Guardado correctamente");
            this.Close();

        }

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmAltaModificacionArticulo_Load(object sender, EventArgs e)
        {
            if (articulo != null)
            {


                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
            }

        }

        
    }
}

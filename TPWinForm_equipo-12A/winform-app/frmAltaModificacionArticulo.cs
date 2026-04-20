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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (articulo == null)
                articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;

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

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

            try
            {
                if (chequearVacio(txtCodigo.Text))
                {
                    MessageBox.Show("El código es obligatorio", "Atención: código obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!validarCodigo(txtCodigo.Text))
                {
                    return;
                }

                bool codigoDuplicado = negocio.validarCodigoDuplicado(txtCodigo.Text);

                if (articulo == null)
                {
                    if(codigoDuplicado)
                    {
                        MessageBox.Show("El código ya existe", "Atención: código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    if(articulo.Codigo != txtCodigo.Text && codigoDuplicado)
                    {
                        MessageBox.Show("El código ya existe", "Atención: código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (chequearVacio(txtNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio", "Atención: nombre obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool nombreDuplicado = negocio.validarNombreDuplicado(txtNombre.Text);

                if (articulo == null)
                {
                    if (nombreDuplicado)
                    {
                        MessageBox.Show("El nombre ya existe", "Atención: nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    if (articulo.Nombre != txtNombre.Text && nombreDuplicado)
                    {
                        MessageBox.Show("El nombre ya existe", "Atención: nombre duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

                if (chequearVacio(txtPrecio.Text))
                {
                    MessageBox.Show("El precio es obligatorio", "Atención: precio obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!validarPrecio(txtPrecio.Text, out decimal precio))
                {
                    return;
                }

                if (chequearCBOVacio(cboMarca.SelectedIndex) || chequearCBOVacio(cboCategoria.SelectedIndex))
                {
                    MessageBox.Show("Es obligatorio seleccionar una Marca y una Categoría", "Atención: marca y categorías obligatorias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text.ToUpper();
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                    negocio.modificar(articulo);
                else
                    negocio.agregar(articulo);

                MessageBox.Show("Guardado correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCncelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaModificacionArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                cboMarca.SelectedIndex = -1;
                cboCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    txtPrecio.Text = articulo.Precio.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool chequearCBOVacio(int indice)
        {
            if (indice == -1) return true;
            else return false;
        }

        public bool validarCodigo(string codigo)
        {
            if (codigo.Length != 3)
            {
                MessageBox.Show("El código debe tener solo 3 caracteres", "Atención: código erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!(char.IsLetter(codigo[0])))
            {
                MessageBox.Show("El código debe comenzar con una letra", "Atención: código erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!(char.IsDigit(codigo[1])) || !(char.IsDigit(codigo[2])))
            {
                MessageBox.Show("El código debe tener dos números luego de la letra", "Atención: código erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool validarPrecio(string texto, out decimal precio)
        {
            if (!decimal.TryParse(texto, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}

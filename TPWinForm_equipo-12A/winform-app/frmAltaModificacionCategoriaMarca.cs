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
    public partial class frmAltaModificacionCategoriaMarca : Form
    {

        private string dataRecibida;
        private MarcaNegocio marNeg = new MarcaNegocio();
        private CategoriaNegocio catNeg = new CategoriaNegocio();

        public frmAltaModificacionCategoriaMarca()
        {
            InitializeComponent();
        }

        public frmAltaModificacionCategoriaMarca(string data)
        {
            InitializeComponent();

            if (data == "Marca")
            {
                dataRecibida = "MenuMarca"; //para que sae mas facil modificar el codigo en caso de necesitarlo
                this.Text = "Marca";
            }
            else
            {
                dataRecibida = "MenuCategoría";
                this.Text = "Categoría";
            }
        }

        private void frmAltaModificacionCategoriaMarca_Load(object sender, EventArgs e)
        {
            if (dataRecibida == "MenuMarca")
            {
                MostrarGrilla(dgvMC, dataRecibida);
            }
            else
            {
                MostrarGrilla(dgvMC, dataRecibida);
            }

            dgvMC.ReadOnly = true;
        }

        private void MostrarGrilla(DataGridView dgv, string data)
        {

            if (data == "MenuMarca")
            {

                dgv.DataSource = marNeg.listar();
            }
            else
            {

                dgv.DataSource = catNeg.listar();
            }


            dgv.Columns["Id"].Visible = false;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dato = txtAgregar.Text;
            if (string.IsNullOrEmpty(dato))
            {
                MessageBox.Show("No se puede agregar un elemento vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dataRecibida == "MenuMarca")
            {
                marNeg.agregar(dato);
            }
            else
            {
                catNeg.agregar(dato);
            }
            MostrarGrilla(dgvMC, dataRecibida);
            txtAgregar.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvMC.CurrentRow != null)
            {
                string dato = txtModificar.Text;
                if (string.IsNullOrEmpty(dato))
                {
                    MessageBox.Show("No se puede modificar un elemento vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (dataRecibida == "MenuMarca")
                {
                    Marca marca = (Marca)dgvMC.CurrentRow.DataBoundItem;
                    marca.Descripcion = dato;
                    marNeg.modificar(marca);
                }
                else
                {
                    Categoria categoria = (Categoria)dgvMC.CurrentRow.DataBoundItem;
                    categoria.Descripcion = dato;
                    catNeg.modificar(categoria);
                }
                MostrarGrilla(dgvMC, dataRecibida);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún elemento...");
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

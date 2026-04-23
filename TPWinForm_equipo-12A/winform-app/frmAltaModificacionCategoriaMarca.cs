using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public frmAltaModificacionCategoriaMarca(string data, string accion)
        {
            InitializeComponent();

            if (data == "Marca")
            {
                dataRecibida = "MenuMarca"; //para que sea mas facil modificar el codigo en caso de necesitarlo
                this.Text = "Marca";
            }
            else
            {
                dataRecibida = "MenuCategoría";
                this.Text = "Categoría";
            }
            if (accion == "Agregar")
            {
                txtModificar.Visible = false;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
            }
            if (accion == "Modificar")
            {
                txtAgregar.Visible = false;
                btnAgregar.Visible = false;
                btnEliminar.Visible = false;
            }
            if (accion == "Eliminar")
            {
                txtAgregar.Visible = false;
                btnAgregar.Visible = false;
                txtModificar.Visible = false;
                btnModificar.Visible = false;
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

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 12, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.ColumnHeadersHeight = 30;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.Columns["Id"].Visible = false;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txtAgregar.Text;
                if (string.IsNullOrEmpty(dato))
                {
                    MessageBox.Show("No se puede agregar un elemento vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMC.CurrentRow != null && dgvMC.CurrentRow.DataBoundItem != null)
                {
                    string dato = txtModificar.Text;
                    if (string.IsNullOrEmpty(dato))
                    {
                        MessageBox.Show("No se puede modificar un elemento vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMC.CurrentRow != null && dgvMC.CurrentRow.DataBoundItem != null)
                {
                    if (dataRecibida == "MenuMarca")
                    {
                        Marca marca = (Marca)dgvMC.CurrentRow.DataBoundItem;
                        if (marNeg.tieneArticulosAsociados(marca.Id))
                        {
                            MessageBox.Show("No se puede eliminar una marca asociada a un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult respuesta = MessageBox.Show(
                                "¿Seguro que querés eliminar esta marca?",
                                "Eliminar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                            if (respuesta == DialogResult.Yes)
                            {
                                marNeg.eliminar(marca);
                                MessageBox.Show("Marca eliminada correctamente.");
                            }
                        }
                    }
                    else
                    {
                        Categoria categoria = (Categoria)dgvMC.CurrentRow.DataBoundItem;
                        if (catNeg.tieneArticulosAsociados(categoria.Id))
                        {
                            MessageBox.Show("No se puede eliminar una categoría asociada a un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            DialogResult respuesta = MessageBox.Show(
                                "¿Seguro que querés eliminar esta categoría?",
                                "Eliminar",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                            if (respuesta == DialogResult.Yes)
                            {
                                catNeg.eliminar(categoria);
                                MessageBox.Show("Categoría eliminada correctamente.");
                            }
                        }
                    }
                    MostrarGrilla(dgvMC, dataRecibida);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún elemento...");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

}

using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmAltaModificacionImagen : Form
    {
        private ImagenNegocio negocio = new ImagenNegocio();
        private List<Imagen> imagenes;
        private int IdArticulo;
        private int IdImagen = -1;
        public frmAltaModificacionImagen(Articulo seleccionado)
        {
            InitializeComponent();
            IdArticulo = seleccionado.Id;            
        }

        private void frmAltaModificacionImagen_Load(object sender, EventArgs e)
        {
            cargarImagenes(IdArticulo);
            cargarImagenInicial();
        }

        private void cargarImagenes(int id)
        {
            try
            {
                imagenes = negocio.listarPorArticulo(id);
                dgvImagenes.DataSource = imagenes;

                dgvImagenes.ColumnHeadersDefaultCellStyle.Font = new Font("Century", 12, FontStyle.Bold);
                dgvImagenes.DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                dgvImagenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvImagenes.ColumnHeadersHeight = 30;
                dgvImagenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                dgvImagenes.Columns["Id"].Visible = false;
                dgvImagenes.Columns["IdArticulo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void cargarImagenInicial()
        {


            try
            {
                if (imagenes != null && imagenes.Count > 0 && !string.IsNullOrEmpty(imagenes[0].ImagenUrl))
                {
                    pbxImagen.Load(imagenes[0].ImagenUrl);
                }
                else
                {
                    pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
                }
            }
            catch
            {
                MessageBox.Show(
            "No se pudo mostrar una imagen para este artículo. Verifique las URL cargadas o agregue una nueva.",
            "Imagen no disponible",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);


                pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }

        private void mostrarImagen()
        {
            try
            {
                if (imagenes != null && imagenes.Count > 0 && !string.IsNullOrEmpty(imagenes[0].ImagenUrl))
                {
                    pbxImagen.Load(dgvImagenes.CurrentRow.DataBoundItem.ToString());
                }
                else
                {
                    pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
                }
            }
            catch 
            {
               
                pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }            
        }

        private void dgvImagenes_SelectionChanged(object sender, EventArgs e)
        {
            Imagen img = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
            if (img != null)
            {
                IdImagen = img.Id;
                txtModificarImagen.Text = img.ImagenUrl;
            }
            else
            {
                IdImagen = -1;
                txtModificarImagen.Text = "";
            }
            mostrarImagen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            Imagen nueva = new Imagen();
            try
            {
                if (chequearVacio(txtAgregarImagen.Text))
                {
                    MessageBox.Show("Ingrese una URL por favor", "Atención: URL vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (imagenes != null && imagenes.Exists(x =>
                  x.ImagenUrl != null &&
                  x.ImagenUrl.ToUpper() == txtAgregarImagen.Text.ToUpper()))
                {
                    MessageBox.Show("La imagen ya existe para este artículo.");
                    return;
                }
                nueva.IdArticulo = IdArticulo;
                nueva.ImagenUrl = txtAgregarImagen.Text;
                negocio.agregarImagen(nueva);
                cargarImagenes(IdArticulo);
                txtAgregarImagen.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificarImagen_Click(object sender, EventArgs e)
        {
            Imagen modificada = new Imagen();
            try
            {
                if (chequearVacio(txtModificarImagen.Text))
                {
                    MessageBox.Show("No se puede cargar una URL vacía", "Atención: URL vacía", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                modificada.ImagenUrl = txtModificarImagen.Text;
                modificada.IdArticulo = IdArticulo;
                modificada.Id = IdImagen;
                negocio.modificarImagen(modificada);
                cargarImagenes(IdArticulo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnEliminarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvImagenes.CurrentRow != null && dgvImagenes.CurrentRow.DataBoundItem != null)
                {
                    Imagen img = (Imagen)dgvImagenes.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show(
                    "¿Seguro que querés eliminar esta imagen?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        negocio.eliminarImagen(img.Id);
                        MessageBox.Show("Imagen eliminada correctamente.");
                    }
                    cargarImagenes(IdArticulo);
                }
                else
                {
                    MessageBox.Show("Seleccione una imagen a eliminar", "Atención: selección obligatoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool chequearVacio(string texto)
        {
            return string.IsNullOrWhiteSpace(texto);
        }

    }
}

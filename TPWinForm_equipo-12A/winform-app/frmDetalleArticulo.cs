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
    public partial class frmDetalleArticulo : Form
    {
        int indiceImagen = 0;
        List<Imagen> imagenes;
        public frmDetalleArticulo(Articulo seleccionado)
        {
            InitializeComponent();
            ImagenNegocio negocio = new ImagenNegocio();
            seleccionado.Imagenes = negocio.listarPorArticulo(seleccionado.Id);
            cargarImagenInicial(seleccionado.Imagenes);
            cargarDescripcion(seleccionado.Descripcion);
        }

        public void cargarImagenInicial(List<Imagen> imgs)
        {
            imagenes = imgs;
            try
            {
                if (imagenes != null && imagenes.Count > 0 && !string.IsNullOrEmpty(imagenes[0].ImagenUrl))
                {
                    pbxImagen.Load(imgs[0].ImagenUrl);
                }
                else
                {
                    pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                pbxImagen.Load("https://t4.ftcdn.net/jpg/06/57/37/01/360_F_657370150_pdNeG5pjI976ZasVbKN9VqH1rfoykdYU.jpg");
            }
        }

        public void cargarDescripcion(string descripcion)
        {
            try
            {
                txtDescripcion.Text = descripcion;
            }
            catch (Exception ex)
            {
                txtDescripcion.Text = "No hay descripción cargada para este producto todavía";
            }
        }

        private void mostrarImagen()
        {
            if (imagenes != null && imagenes.Count > 0 && !string.IsNullOrEmpty(imagenes[0].ImagenUrl))
            {
                pbxImagen.Load(imagenes[indiceImagen].ImagenUrl);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;
            indiceImagen++;
            if (indiceImagen >= imagenes.Count) indiceImagen = 0;
            mostrarImagen();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes.Count == 0) return;
            indiceImagen--;
            if (indiceImagen < 0) indiceImagen = imagenes.Count - 1;
            mostrarImagen();
        }
    }
}

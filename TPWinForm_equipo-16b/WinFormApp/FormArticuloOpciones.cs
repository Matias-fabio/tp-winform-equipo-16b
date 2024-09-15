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
namespace WinFormApp
{
    public partial class FormArticuloOpciones : Form
    {
        private List<Articulo>listaArticulos;
        public FormArticuloOpciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cargar();

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panelOpcionesArticulos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarArt_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo agregarArticulo = new FormAgregarArticulo();
            agregarArticulo.StartPosition = FormStartPosition.Manual;
            agregarArticulo.Location = new Point(0, 0);
            agregarArticulo.ShowDialog();
            cargar();
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if(dgvArticulo.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                FormAgregarArticulo modificarArt = new FormAgregarArticulo(seleccionado);
                modificarArt.StartPosition = FormStartPosition.Manual;
                modificarArt.Location = new Point(0, 0);
                modificarArt.ShowDialog();
                cargar();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un articulo a modificar, intente nuevamente");
            }


        }

        private void FormArticuloOpciones_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulo.CurrentRow != null)
                {
                    Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    cargarImgen(seleccionado.ImagenUrl);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
            

        }
        private void cargarImgen(string imagen)
        {
            try
            {
                pboxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pboxArticulo.Load("https://yaktribe.games/community/media/placeholder-jpg.84782/full");
            }
        }

        private void cargar()
        {
            ComercioArticulo comercio = new ComercioArticulo();
            try
            {
                listaArticulos = comercio.articuloListar();
                dgvArticulo.DataSource = listaArticulos;
                dgvArticulo.Columns["ImagenUrl"].Visible = false;
                dgvArticulo.Columns["Id"].Visible = false;
                cargarImgen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ComercioArticulo comercio = new ComercioArticulo();
            Articulo seleccionado;
            try
            {
                DialogResult resp = MessageBox.Show("¿Eliminar este artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    comercio.eliminar(seleccionado.Id);
                    MessageBox.Show("Elimiado con exito");
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede Eliminar el articulo seleccionado, intente mas tarde", "Error Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw ex;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
        }
    }
}

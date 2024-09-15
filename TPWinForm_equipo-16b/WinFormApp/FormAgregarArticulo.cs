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
    public partial class FormAgregarArticulo : Form
    {
        private Articulo articulo = null;
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        public FormAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            lblTitulo.Text = "MODIFICAR ARTICULO";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PanelAgregarArticulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                if(articulo != null)
                {
                    textCodigo.Text = articulo.Codigo;
                    NombreArticulo.Text = articulo.Nombre;
                    textDescripcion.Text = articulo.Descripcion;
                    textPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            ComercioArticulo comercio = new ComercioArticulo();
            try
            {
                if(articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = textCodigo.Text;
                articulo.Nombre = NombreArticulo.Text;
                articulo.Descripcion = textDescripcion.Text;
                articulo.Precio = decimal .Parse(textPrecio.Text);

                if(articulo.Id != 0)
                {
                    comercio.modificar(articulo);
                    MessageBox.Show("Articulo modificado correctamente");
                }
                else
                {
                    comercio.agregar(articulo);
                    MessageBox.Show("Agregado correctamente");
                }
                
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());

            }
        }
    }
}

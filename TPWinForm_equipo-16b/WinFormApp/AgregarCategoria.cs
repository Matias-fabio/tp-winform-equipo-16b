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
using dominio;
using negocio;

namespace WinFormApp
{
    public partial class AgregarCategoria : Form
    {
        private Categoria categoria = null;
        public AgregarCategoria()
        {
            InitializeComponent();
        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void textCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();
            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Nombre = textNuevaCategoria.Text;
                comercioArticulo.AgregarCategoria(categoria);
                MessageBox.Show("Agregado correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

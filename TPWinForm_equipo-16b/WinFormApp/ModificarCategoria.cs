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

namespace WinFormApp
{
    public partial class ModificarCategoria : Form
    {
        private Categoria categoria = null;
        public ModificarCategoria()
        {
            InitializeComponent();
        }
      

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();
            try
            {
                if (categoria == null)
                    categoria = new Categoria();
                categoria.Nombre = textBoxModCategoria.Text;
                categoria.Id = comboBoxModificarCategoria.SelectedIndex + 1;
                comercioArticulo.ModificarCategoria(categoria);
                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ModificarCategoria_Load(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();

            try
            {
                comboBoxModificarCategoria.DataSource = comercioArticulo.categoriaListar();
           
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

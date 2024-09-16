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
    public partial class EliminarCategoria : Form
    {
        private Categoria categoria = null;
        
        public EliminarCategoria()
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
                
                categoria = new Categoria();
               
                categoria.Id = comboBoxEliminarCategoria.SelectedIndex+1;
                comercioArticulo.ModificarCategoria(categoria);
                MessageBox.Show("Eliminado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }
        private void EliminarCategoria_Load(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();

            try
            {
                comboBoxEliminarCategoria.DataSource = comercioArticulo.categoriaListar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

       
    }
}

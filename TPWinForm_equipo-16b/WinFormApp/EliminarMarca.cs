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
    public partial class EliminarMarca : Form
    {
        private Marca Mar = null;
        public EliminarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarMarca_Load(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();
            try
            {
                comboBoxEliminarMarca.DataSource = comercioArticulo.MarcasListar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();
            try
            {
                if(Mar == null)
                    Mar = new Marca();
                Mar.Id = comboBoxEliminarMarca.SelectedIndex + 1;
                comercioArticulo.EliminarMarca(Mar);
                MessageBox.Show("Eliminado correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

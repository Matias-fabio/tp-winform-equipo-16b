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
    public partial class ModificarMarca : Form
    {
        private Marca Mar = null;
        public ModificarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarMarca_Load(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();

            try
            {
                comboBoxSelecionarMarca.DataSource = comercioArticulo.MarcasListar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptarModMarca_Click(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();

            Mar = new Marca();
            try
            {
                Mar.Nombre = textBoxModMarca.Text;
                Mar.Id = comboBoxSelecionarMarca.SelectedIndex + 1;
                comercioArticulo.Modificarmarca(Mar);
                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

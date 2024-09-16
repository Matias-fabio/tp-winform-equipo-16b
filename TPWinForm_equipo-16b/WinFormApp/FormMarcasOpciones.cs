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
    public partial class FormMarcasOpciones : Form
    {
        public FormMarcasOpciones()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMarcasOpciones_Load(object sender, EventArgs e)
        {
            ComercioArticulo comercioArticulo = new ComercioArticulo();
            dgvMarca.DataSource = comercioArticulo.MarcasListar();
            try
            {
                comboBoxBuscarMarca.DataSource = comercioArticulo.MarcasListar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonAgregarMarcas_Click(object sender, EventArgs e)
        {
            AgregarMarca agregarMarca = new AgregarMarca();
            agregarMarca.ShowDialog();
        }

        private void buttonEliminarMarca_Click(object sender, EventArgs e)
        {
            EliminarMarca eliminarMarca = new EliminarMarca();
            eliminarMarca.ShowDialog();
        }

        private void buttonModificarMarcas_Click(object sender, EventArgs e)
        {
            ModificarMarca modificarMarca = new ModificarMarca();   
            modificarMarca.ShowDialog();
        }
    }
}

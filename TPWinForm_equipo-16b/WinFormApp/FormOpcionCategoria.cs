﻿using dominio;
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
    public partial class FormOpcionCategoria : Form
    {
        public FormOpcionCategoria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormOpcionCategoria_Load(object sender, EventArgs e)
        {

            
            ComercioArticulo comercioArticulo = new ComercioArticulo();
            dgvCategoria.DataSource = comercioArticulo.categoriaListar();
            try
            {
                comboBoxBuscarCategoria.DataSource = comercioArticulo.categoriaListar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ButtonAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria Ventana = new AgregarCategoria();
            Ventana.ShowDialog();
        }

        private void buttonEliminarCategoria_Click(object sender, EventArgs e)
        {
            EliminarCategoria Ventana = new EliminarCategoria();
            Ventana.ShowDialog();

        }

        private void buttonModificarCategoria_Click(object sender, EventArgs e)
        {
           
            ModificarCategoria modificarCategoria = new ModificarCategoria();
            modificarCategoria.ShowDialog();
        }
    }
}

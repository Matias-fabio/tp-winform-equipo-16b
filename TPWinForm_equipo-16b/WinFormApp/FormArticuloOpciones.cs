﻿using System;
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
           
            ComercioArticulo comercio = new ComercioArticulo();
            listaArticulos = comercio.articuloListar();
            dgvArticulo.DataSource = listaArticulos;
            dgvArticulo.Columns["ImagenUrl"].Visible = false;
            dgvArticulo.Columns["Id"].Visible = false;
            cargarImgen(listaArticulos[0].ImagenUrl);

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
        }

        private void btnModificarArt_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            FormAgregarArticulo modificarArt = new FormAgregarArticulo(seleccionado);
            modificarArt.StartPosition = FormStartPosition.Manual;
            modificarArt.Location = new Point(0, 0);
            modificarArt.ShowDialog();

        }

        private void FormArticuloOpciones_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImgen(seleccionado.ImagenUrl);

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

        private void button2_Click(object sender, EventArgs e)
        {

        }


    }
}

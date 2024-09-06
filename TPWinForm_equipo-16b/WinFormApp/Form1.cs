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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            foreach (Form form in this.MdiChildren)
            {
                form.Close(); 
            }

        }
        private void btnArticulo_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormArticuloOpciones))
                    return;

            }

            FormArticuloOpciones formArticuloOpciones = new FormArticuloOpciones();
            formArticuloOpciones.MdiParent = this;
            formArticuloOpciones.Show();

        }
        private void navTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void navTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {

        }


    }
}

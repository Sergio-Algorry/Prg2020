using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaDatos
{
    public partial class frmInicio : Form
    {
        string[] Datos;
        int Indice = 0;

        public frmInicio()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            if (Indice < Datos.Length)
            {
                Datos[Indice] = txtDato.Text;
                Indice = Indice + 1;
            }
            else
            {
                lblSalida.Text = "El dato " + txtDato.Text + " no se cargó por exceder el límite";
            }
            txtDato.Focus();
            txtDato.SelectAll();
            //txtDato.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            Datos = new string[System.Convert.ToInt32( txtCantidad.Text)];
            Indice = 0;

            btCargar.Enabled = true;

            txtDato.Focus();
        }
    } 
}

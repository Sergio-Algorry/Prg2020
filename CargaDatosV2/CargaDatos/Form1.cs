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
        string[] Datos = new string[1];
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
                string[] temp = new string[Datos.Length + 1];

                for (int i = 0; i < Datos.Length; i++)
                {
                    temp[i] = Datos[i];
                }

                Datos = temp;

                Datos[Indice] = txtDato.Text;
            }
            txtDato.Focus();
            txtDato.SelectAll();
            //txtDato.Text = "";
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        //private void btIniciar_Click(object sender, EventArgs e)
        //{
        //    Datos = new string[System.Convert.ToInt32( txtCantidad.Text)];
        //    Indice = 0;

        //    btCargar.Enabled = true;

        //    txtDato.Focus();
        //}
    } 
}

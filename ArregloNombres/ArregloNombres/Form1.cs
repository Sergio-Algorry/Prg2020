using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloNombres
{
    public partial class frmNombres : Form
    {
        string[] Lista;
        int Posicion;
        public frmNombres()
        {
            InitializeComponent();
            btIngresar.Enabled = false;
            btListar.Enabled = false;
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            Lista[Posicion] = txtNombre.Text;
            Posicion = Posicion + 1;
            
            //lblLista.Text = lblLista.Text + txtNombre.Text + "\r\n";

            txtNombre.Text = "";
            txtNombre.Focus();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lista.Length; i++)
            {
                lblLista.Text = lblLista.Text + Lista[i] + "\r\n";
            }
        }

        private void btDimensionar_Click(object sender, EventArgs e)
        {
            Lista = new string[System.Convert.ToInt32(txtCantidad.Text) ];
            Posicion = 0;
            btIngresar.Enabled = true;
            btListar.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class frmContador : Form
    {
        public frmContador()
        {
            InitializeComponent();
        }

        private void btContar_Click(object sender, EventArgs e)
        {

            for (int i = System.Convert.ToInt32(txtDesde.Text); //desde
                     i <= System.Convert.ToInt32(txtHasta.Text); //hasta
                     i = i + System.Convert.ToInt32(txtPaso.Text) //paso
                ) 
            {
                lblRes.Text = i.ToString();
                this.Refresh();
            }
        }

        private void txtHasta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIf2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            int edad = System.Convert.ToInt32(txtEdad.Text );

            if (edad<12)
            {
                lblRes.Text = "NIÑO";
            }
            else if(edad>=12 && edad<18)
            {
                lblRes.Text = "ADOLECENTE";
            }
            else if(edad>=18 && edad<60)
            {
                lblRes.Text = "ADULTO";
            }
            else
            {
                lblRes.Text = "Adulto Mayor";
            }

        }
    }
}

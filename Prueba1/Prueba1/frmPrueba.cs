using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class frmPrueba : Form
    {
        string PrimerVariable = "sergio";

        public frmPrueba()
        {
            string SegundaVariable = " ¿Que tal?";
            InitializeComponent();
            label1.Text = "Hola " + PrimerVariable + SegundaVariable; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string terceraVariable = " ¿Como te va?";

            label1.Text = "Hola " + PrimerVariable + terceraVariable;

        }
    }
}

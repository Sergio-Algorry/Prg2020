using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumador
{
    public partial class Form1 : Form
    {
        Suma oSuma = new Suma();

        public Form1()
        {
            InitializeComponent();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            //int resultado = 0;

            //Suma oSuma = new Suma();
            
            oSuma.Sumando1 = System.Convert.ToInt32(txtSumando1.Text);
            oSuma.Sumando2 = System.Convert.ToInt32(txtSumando2.Text);

            //resultado = oSuma.Sumar();

            oSuma.Sumar();

            //resultado = oSuma.Result;

            txtResultado.Text = System.Convert.ToString(oSuma.Result);
            txtAcumulado.Text = System.Convert.ToString(oSuma.Acumulador);

 
            //int Sumando1 = System.Convert.ToInt32(txtSumando1.Text);
            //int Sumando2 = System.Convert.ToInt32(txtSumando2.Text);

            //int Resultado = Sumando1 + Sumando2;

            //txtResultado.Text = System.Convert.ToString(Resultado);
        }
    }
}

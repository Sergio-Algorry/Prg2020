using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConversion
{
    public partial class frmConvertir : Form
    {
        public frmConvertir()
        {
            InitializeComponent();
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            decimal oper1 = System.Convert.ToDecimal(txtOper1.Text);
            decimal oper2 = System.Convert.ToDecimal(txtOper2.Text);

            decimal res = oper1 + oper2;

            lblRes.Text = System.Convert.ToString(res);
        }








        private void frmConvertir_Load(object sender, EventArgs e)
        {

        }

        private void txtOper2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

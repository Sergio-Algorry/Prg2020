using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaIf
{
    public partial class frmArranque : Form
    {
        public frmArranque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSiguiente pepe = new frmSiguiente();
            pepe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSiguiente pepe2 = new frmSiguiente();
            pepe2.Show();
        }
    }
}

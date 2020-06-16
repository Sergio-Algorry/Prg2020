using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWhile
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            int AnchoFormulario = this.Width;
            int AnchoLabel = lbl.Width;
            int AnchoBorde = 20;
            int X = 0;
            int Paso = 1;

            //for (int X = 0; X < AnchoFormulario-AnchoLabel-AnchoBorde; X++)
            //{
            //    lbl.Left = X;

            //}

            while (X < AnchoFormulario - AnchoLabel - AnchoBorde)
            {
                lbl.Left = X;
                //lbl.Top = X;
                X = X + Paso;
            }
        }
    }
}

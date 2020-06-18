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
            Random Generador = new Random();
            
            int AnchoFormulario;
            int AnchoLabel;
            int AnchoBorde;
            int X;
            int Paso;
            int Repeticion = 0;
            int TotalRepeticion = 10;
            lbl.Width = 106;
            lbl.Height = 15;
            do
            {
                AnchoFormulario = this.Width;
                AnchoLabel = lbl.Width;
                AnchoBorde = 0;
                X = 0;
                Paso = Generador.Next(1, 50);
                Repeticion = Repeticion + 1;

                while (X < (AnchoFormulario - AnchoBorde - AnchoLabel))
                {
                    lbl.Left = X;
                    this.Refresh();
                    X = X + Paso;
                }

                lbl.Width = Generador.Next(2, 300);
                lbl.Height = Generador.Next(5, 50);
               

                //lbl.Width = System.Convert.ToInt32( 0.7 * lbl.Width);
                //lbl.Height = lbl.Height * 2;

            } while (Repeticion < TotalRepeticion);
        }
    }
}

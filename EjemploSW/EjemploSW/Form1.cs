using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
                int nota = System.Convert.ToInt32(txtNota.Text);
                switch (nota)
                {
                    case 1:
                        lblRes.Text = "Aplazado";
                        break;
                    case 2:
                        lblRes.Text = "Aplazado";
                        break;
                    case 3:
                        lblRes.Text = "Aprobado";
                        break;
                    case 4:
                        lblRes.Text = "Promocionado";
                        break;
                    case 5:
                        lblRes.Text = "Promocionado";
                        break;
                    default:
                        lblRes.Text = "Nota no válida";
                        break;
                }


            //switch (txtNota.Text.Trim())
            //{
            //    case "1":
            //        lblRes.Text = "Aplazado";
            //        break;
            //    case "2":
            //        lblRes.Text = "Aplazado";
            //        break;
            //    case "3":
            //        lblRes.Text = "Aprobado";
            //        break;
            //    case "4":
            //        lblRes.Text = "Promocionado";
            //        break;
            //    case "5":
            //        lblRes.Text = "Promocionado";
            //        break;
            //    default:
            //        lblRes.Text = "Nota no válida";
            //        break;
            //}

        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

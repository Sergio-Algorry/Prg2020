using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistencia
{
    public partial class frmDatos : Form
    {
        DataTable tabla = new DataTable();

        public frmDatos()
        {
            InitializeComponent();
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            tabla.TableName = "Lista";
            tabla.Columns.Add("Nombre", typeof(string));
            tabla.Columns.Add("Cantidad", typeof(int));

            DGV.DataSource = tabla;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                tabla.Rows.Add();

                tabla.Rows[tabla.Rows.Count - 1]["Nombre"] = "Pepe";
                tabla.Rows[tabla.Rows.Count - 1]["Cantidad"] = 1050;

                tabla.Rows.Add();

                tabla.Rows[tabla.Rows.Count - 1][0] = "Italo";
                tabla.Rows[tabla.Rows.Count - 1][1] = 3;
                
                decimal dummy = 0;
                decimal pepe = 10 / dummy;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error:\r\n" 
                                 + ee.Message
                                 + "\r\n" + ee.StackTrace);

            }
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            tabla.WriteXml(@"C:\Users\Sergio-Algorry\Desktop\lista.xml");
        }

        private void btLeer_Click(object sender, EventArgs e)
        {
            tabla.ReadXml(@"C:\Users\Sergio-Algorry\Desktop\lista.xml");

            DGV.DataSource = tabla;
        }
    }
}

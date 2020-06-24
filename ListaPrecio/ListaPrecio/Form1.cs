using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPrecio
{
    public partial class frmListaPrecio : Form
    {
        private string[,] Producto = new string[3,2];
        private decimal[] Precio = new decimal[3];

        private int Fila = 0;

        public frmListaPrecio()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Fila > 2)
            {
                lblListaPrecio.Text = "Solo se aceptan 3 productos";
            }
            else
            {
                Producto[Fila, 0] = txtCodigo.Text;
                Producto[Fila, 1] = txtProducto.Text;

                Precio[Fila] = System.Convert.ToDecimal(txtPrecio.Text);

                Fila = Fila + 1;
            }
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            lblListaPrecio.Text = "LISTA DE PRECIO\r\n";

            for (int i = 0; i < Precio.Length; i++)
            {
                lblListaPrecio.Text = lblListaPrecio.Text 
                                        + Producto[i, 0] 
                                        + " - " + Producto[i, 1] 
                                        + " -- " + Precio[i].ToString()
                                        + "\r\n";
            }
        }
    }
}

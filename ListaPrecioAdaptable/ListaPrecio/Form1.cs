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
        private string[,] Producto = new string[1,2];
        private decimal[] Precio = new decimal[1];

        private int Fila = 0;

        public frmListaPrecio()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (Fila > Precio.Length-1)
            {
                //lblListaPrecio.Text = "Solo se aceptan 3 productos";
                AddRegistro();
            }
            //else
            //{
            Producto[Fila, 0] = txtCodigo.Text;
            Producto[Fila, 1] = txtProducto.Text;

            Precio[Fila] = System.Convert.ToDecimal(txtPrecio.Text);

            Fila = Fila + 1;
            //}

            LimpiaPantalla();
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

        private void AddRegistro()
        {
            string[,] ProductoTmp = Producto;
            decimal[] PrecioTmp = Precio;

            Producto = new string[Precio.Length + 1, 2];
            Precio = new decimal[Precio.Length + 1];

            for (int i = 0; i < Precio.Length-1; i++)
            {
                Producto[i, 0] = ProductoTmp[i, 0];
                Producto[i, 1] = ProductoTmp[i, 1];

                Precio[i] = PrecioTmp[i];
            }
        }

        private void LimpiaPantalla()
        {
            txtCodigo.Text = "";
            txtProducto.Text = "";
            txtPrecio.Text = "";

            lblListaPrecio.Text = "";

            txtCodigo.Focus();
        }
    }
}

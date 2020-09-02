using BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE
{
    public partial class frmFacturar : Form
    {
        Factura facturaObj;

        public frmFacturar()
        {
            InitializeComponent();
        }

        private void btNueva_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            NuevaFactura();
            txtFecha.Text = facturaObj.Fecha.ToString("dd/MM/yyyy");
        }

        private void LimpiarControles()
        {
            txtBruto.Text = "";
            txtCliente.Text = "";
            txtCuit.Text = "";
            txtFecha.Text = "";
            txtIVA.Text = "";
            txtNumero.Text = "";
            txtTotal.Text = "";
        }

        private void NuevaFactura()
        {
            facturaObj = new Factura();
        }
    }
}

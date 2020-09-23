using BA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FE
{
    public partial class frmFactura : Form
    {
        #region Propiedades
        Factura facturaObj;
        RngFactura rngFacturaObj;
        #endregion

        #region Constructor
        public frmFactura()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void btNueva_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            NuevaFactura();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            LimpiaBlancosEncab();

            //validar datos
            if (txtCliente.Text == "" || txtNumero.Text == "" || txtCuit.Text == "")
            {
                lblErrorEncabezado.Text = "Falta datos de encabezado";
                txtNumero.Focus();
            }
            else
            {
                //llenar propiedades del encabezado
                facturaObj.NumeroFactura = txtNumero.Text;
                facturaObj.Cliente = txtCliente.Text;
                facturaObj.CUIT = txtCuit.Text;
                facturaObj.Fecha = System.Convert.ToDateTime(txtFecha.Text);

                //Continuar
                lblErrorEncabezado.Text = "";
                paRenglones.Enabled = true;
                txtCantidad.Focus();
            }
        }

        private void btNuevoRenglon_Click(object sender, EventArgs e)
        {
            rngFacturaObj = new RngFactura();
            rngFacturaObj.cantidad = System.Convert.ToDecimal(txtCantidad.Text);
            rngFacturaObj.producto = txtProducto.Text;
            //rngFacturaObj.preUnitario = decimal.Parse(txtUnitario.Text);
            rngFacturaObj.preUnitario = System.Convert.ToDecimal(txtUnitario.Text);

            facturaObj.AddRngFactura(rngFacturaObj);

            //txtTotRenglon.Text = System.Convert.ToString(rngFacturaObj.Total());
            txtTotRenglon.Text = rngFacturaObj.Total().ToString("#,##0.00");

            MuestraRenglones();
        }
        #endregion

        #region Metodos
        private void LimpiarControles()
        {
            lblBruto.Text = "";
            txtCliente.Text = "";
            txtCuit.Text = "";
            txtFecha.Text = "";
            lblIVA.Text = "";
            txtNumero.Text = "";
            lblTotal.Text = "";

            paRenglones.Enabled = false;
        }

        private void NuevaFactura()
        {
            facturaObj = new Factura();
            txtFecha.Text = facturaObj.Fecha.ToString("dd/MM/yyyy");
            //todo: ACTUALIZAR NUMERO DE FACTURA

            txtNumero.Focus();
        }

        private void LimpiaBlancosEncab()
        {
            txtCliente.Text = txtCliente.Text.Trim();
            txtNumero.Text = txtNumero.Text.Trim();
            txtCuit.Text = txtCuit.Text.Trim();
        }

        private void MuestraRenglones()
        {
            //TODO:MOSTRAR TODOS LOS RENGLONES
            lblRenglones.Text = facturaObj.MuestraRenglones();
        }
        #endregion
    }
}

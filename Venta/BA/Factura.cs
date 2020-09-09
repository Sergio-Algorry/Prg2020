using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class Factura
    {
        #region Propiedades
        public DateTime Fecha;

        public string NumeroFactura = "";

        public string Cliente = "";
        public string CUIT = "";

        public decimal Neto = 0;
        public decimal IVA = 0;
        public decimal Total = 0;

        public RngFactura[] ListaRngFactura = new RngFactura[10];
        private int indice = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// CONSTRUCTOR de objeto de clase Factura
        /// </summary>
        public Factura()
        {
            Fecha = DateTime.Now;
            //todo: nuevo numero de factura
        }
        #endregion

        #region Metodo
        public void AddRngFactura(RngFactura rngFacturaObj)
        {
            //todo: CONTROLAR ERROR DE SOBREPASAR CAPACIDAD DEL ARREGLO
            ListaRngFactura[indice] = rngFacturaObj;
            indice = indice + 1;
        }
        #endregion
    }
}

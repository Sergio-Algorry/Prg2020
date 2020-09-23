using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA
{
    public class RngFactura
    {
        #region Propiedades
        public decimal cantidad = 0;
        public string producto = "";
        public decimal preUnitario = 0;
        #endregion

        #region Constructor

        #endregion

        #region Metodos
        public decimal Total()
        {
            return cantidad * preUnitario;
        }

        public string MuestraRenglon()
        {
            return cantidad.ToString("#,##0.00") + " - "
                   + producto + "  "
                   + preUnitario.ToString("#,##0.00") + "  "
                   + Total().ToString("#,##0.00");
        }          
        #endregion
    }
}

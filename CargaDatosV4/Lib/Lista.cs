using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    /// <summary>
    /// Clase especializada en manejo de listas alfanumericas
    /// </summary>
    public class Lista
    {
        private string[] arreglo = new string[1];
        private int indice = 0;

        /// <summary>
        /// Incorpora un nuevo registro con el valor de dato
        /// </summary>
        /// <param name="dato">String con el dato a incorporar en el ultimo registro</param>
        public void CargaDatos(string dato)
        {
            if(indice >= arreglo.Length)
            {
                Redimension();
            }
            arreglo[indice] = dato;
            indice = indice + 1;
        }

        /// <summary>
        /// Agrega un nuevo registro al arreglo
        /// </summary>
        private void Redimension()
        {
            string[] temp = new string[arreglo.Length + 1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                temp[i] = arreglo[i];
            }
            arreglo = temp;
        }
    }
}
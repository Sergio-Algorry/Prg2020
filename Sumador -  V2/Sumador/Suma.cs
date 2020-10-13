using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumador
{
    public class Suma
    {
        public int Sumando1 = 0;
        public int Sumando2 = 0;

        public int Result = 0;
        public int Acumulador = 0;

        public void Sumar()
        {
            Result = Sumando1 + Sumando2;
            Acumulador = Acumulador + Result;
        }

        //public void Sumar()
        //{
        //    Result = Sumando1 + Sumando2;
        //}

        //public int Sumar()
        //{
        //    int res = 0;
        //    res = Sumando1 + Sumando2;

        //    return res;
        //}

    }
}

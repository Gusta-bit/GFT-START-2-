using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class ICMS : Imposto
    {
        public double Valor { get; set; }

        public ICMS(double valor)
        {
            Valor = Valor;
        }



        public override double imposto()
        {
            {
                return Valor *= 0.27;
            }

        }
    }
}
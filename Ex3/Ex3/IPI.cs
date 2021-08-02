using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class IPI : Imposto
    {

        public double Valor { get; set; }

        public IPI(double valor)
        {
            Valor = Valor;
        }

                  

        public override double imposto()
        {
            if (Valor > 2500)
                return Valor *= 0.11;
            else
                return Valor *= 0.05;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex3
{
    class Cofins : Imposto

    {
        public double Valor { get; set; }

        public Cofins(double valor)
        {
            Valor = Valor;
        }
        

        public override double imposto()
        {
            {
                if (Valor > 13000)
                    return Valor *= 0.04;
                else
                    return Valor;

            }
        }
    }
    }

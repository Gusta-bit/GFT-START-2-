using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Atleta
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public int DistanciaAremesso { get; set; }

        public Atleta()
        {

        }

        public Atleta(string nome, string pais, int distanciaAremesso)
        {
            Nome = nome;
            Pais = pais;
            DistanciaAremesso = distanciaAremesso;
        }
    }
}

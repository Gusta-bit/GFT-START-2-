using System;
using System.Globalization;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a quantidade de atletas: ");
            int qts = int.Parse(Console.ReadLine());

            List<Atleta> list = new List<Atleta>();

            for (int i = 1; i <= qts; i++)
            {

                Console.Write("Digite o nome do atleta {0}: ", i);
                string nome = Console.ReadLine();
                Console.Write("Digite o pais atleta {0}: ", i);
                string pais = Console.ReadLine();
                Console.Write("Digite o resultado (em metros) do atleta {0}: ", i);
                int distanciaAremesso = int.Parse(Console.ReadLine());
                list.Add(new Atleta(nome, pais, distanciaAremesso));
                Console.WriteLine();


            }

            foreach (Atleta tp in list)
            {

              int distancia = (tp.DistanciaAremesso);

                Console.WriteLine("Ouro: " + tp.Nome + " - "+ tp.Pais + " Resultado: " + tp.DistanciaAremesso + "m");

            }
        }
    }
}

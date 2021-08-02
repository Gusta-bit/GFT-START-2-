using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int N1 = numero.Next(0,7);

            Console.WriteLine("Acerte o numero entre 0 e 7: ");
            int teste = int.Parse(Console.ReadLine());

            while (teste != N1)
            {                

                Console.WriteLine("Tente novamente: ");
                teste = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Você acertou!!");

                                }
    }
}

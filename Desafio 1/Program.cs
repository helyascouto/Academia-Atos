using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 1000;
            double p = 1000;
            char sinal;
            for (int i = 1; i <= 50; i++)
            {
                sinal = (p % 2 == 0) ? sinal = '-' : sinal = '+';
                Console.Write("({0}/{1}) {2} ", p, i, sinal);
                p -= 3;
            }
        }
    }
}

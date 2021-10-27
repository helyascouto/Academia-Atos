using System;

namespace Desafio_1_Calcula
{
    class Program
    {
        static void Main(string[] args)
        {

            double ax, res = 0;
            double p = 1000;
            char sinal;

            for (int i = 1; i <= 50; p -= 3,i++)
            {
                sinal = (p % 2 == 0) ? sinal = '-' : sinal = '+';
                res = (p % 2 == 0) ? res += p / i : res -= p / i;
                ax = p / i;

                Console.Write("({0}/{1}={2:f}) {3} ", p, i, ax, sinal);
                ax = 0;
                
            }
            Console.WriteLine("\n Resultado= {0:f}", res);

        }
    }
}

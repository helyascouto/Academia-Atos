using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, ant, antant, fib;
            Console.WriteLine("Digite um valor para N: ");
            n = int.Parse(Console.ReadLine());
            ant = 1;
            antant = 0;
            if (n <= 0)
            {
                Console.WriteLine("Digite um número maior que 0");
            }
            else
            {
                Console.WriteLine("A sequência de fibonacci é: ");
                if (n == 1)
                    Console.Write(antant);
                else if (n == 2)
                    Console.Write(antant + " " + ant + " ");
                else
                {
                    Console.Write(antant + " " + ant + " ");
                    for (i = 2; i < n; i++)
                    {
                        fib = ant + antant;
                        Console.Write(fib + " ");
                        antant = ant;
                        ant = fib;
                    }
                }
            }
        }
    }
}

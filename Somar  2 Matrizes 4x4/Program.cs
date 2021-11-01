using System;

namespace Somar__2_Matrizes_4x4
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int[,] matriz = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Digite o valor da Matriz na posição {i + 1} x {j + 1} !");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                    soma += matriz[i, j];
                }
            }
            Console.WriteLine($"Soma das Matrizes:{soma}");
        }
    }
}

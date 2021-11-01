using System;

namespace Tranpor_uma_matriz_3x4_para_outro_4x3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz_3x4 = new int[3, 4];
            int[,] matriz_4x3 = new int[4, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Clear();
                    Console.WriteLine($"Digite o valor da Matriz 3x4 na posição {i + 1} x {j + 1} !");
                    matriz_3x4[i, j] = int.Parse(Console.ReadLine());
                    matriz_4x3[j, i] = matriz_3x4[i, j];
                }
            }

            Console.Clear();
            Console.WriteLine("Matrizes 3x4");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{ matriz_3x4[i, 0]} { matriz_3x4[i, 1]} { matriz_3x4[i, 2]} { matriz_3x4[i, 3]} ");
            }
           
            Console.WriteLine("");
            Console.WriteLine("Matrizes 4x3");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($" { matriz_4x3[i, 0]} { matriz_4x3[i, 1]} { matriz_4x3[i, 2]}");
            }

        }
    }
}

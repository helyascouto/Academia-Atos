using System;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] mat = new int[3, 4];
            ////Console.WriteLine(mat.Length);
            //int i, j;
            //for (i = 0; i < 3; i++) //linha
            //{
            //    for (j = 0; j < 4; j++) //coluna
            //    {
            //        Console.WriteLine("Digite o elemento [" + i + "] - [" + j + "]");
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (i = 0; i < 3; i++)
            //{
            //    for (j = 0; j < 4; j++)
            //    {
            //        Console.Write(mat[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int res = 0;
            //int[,] mat = new int[4, 4];
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        Console.WriteLine("Digite o numero!");
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //        res += mat[i, j];
            //    }
            //}

            //Console.WriteLine("Resultado:" + res);

            //int res = 0, soma = 0, soma2 = 0;
            //int[,] mat = new int[4, 3];
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Digite o numero!");
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //        res += i + j;
            //        if (res % 2 == 0)
            //        {
            //            Console.WriteLine($"{i}+{j}={res}");

            //        }

            //        if (j == 1)
            //        {
            //            soma += mat[i, j] * 2;
            //        }
            //        if (j == 2)
            //        {
            //            soma2 += mat[i, j] * 3;


            //        }
            //    }
            //}

            //Console.WriteLine("Terceira coluna" + soma);
            //Console.WriteLine("Terceira coluna" + soma2);

            //int res = 0, soma = 0, soma2 = 0;
            //int[,] mat = new int[3, 3];
            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.WriteLine("Digite o numero!");
            //        mat[i, j] = int.Parse(Console.ReadLine());
            //        res += i + j;
            //        if (res % 2 == 0)
            //        {
            //            Console.WriteLine($"{i}+{j}={res}");

            //        }

            //        if (j == 1)
            //        {
            //            soma += mat[i, j] * 2;
            //        }
            //        if (j == 2)
            //        {
            //            soma2 += mat[i, j] * 3;


            //        }
            //    }
            //}

            int[,] mat = new int[3, 3];
            int i, j;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    mat[i, j] = i * j;
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i == j)
                        Console.WriteLine("elemento da linha " + i + " e coluna " + j + " = " + mat[i, j]);
                }
            }
        }
    }
}


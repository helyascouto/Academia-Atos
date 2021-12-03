using System;

namespace Funcao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite n1!");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite n2!");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"{n1}+{n2}={Somar(n1, n2)}");
            //Console.WriteLine($"{n1}-{n2}={subtrair(n1, n2)}");
            //Console.WriteLine($"{n1}*{n2}={ Multiplicacao(n1, n2)}");
            //Console.WriteLine($"{n1}/{n2}={ Divisao(n1, n2)}");


            //static int Somar(int n1, int n2)
            //{
            //    var total = n1 + n2;
            //    return total;
            //}
            //static int subtrair(int n1, int n2)
            //{
            //    var total = n1 - n2;
            //    return total;
            //}
            //static int Multiplicacao(int n1, int n2)
            //{
            //    var total = n1 * n2;
            //    return total;
            //}
            //static int Divisao(int n1, int n2)
            //{
            //    var total = n1 / n2;
            //    return total;
            //}








            //char op  , operacao = ' ';
            //double n1 = 0, n2 = 0;
            //do
            //{
            //    Console.WriteLine("digite a operação +|-|*|/");
            //    operacao = char.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite n1!");
            //    n1 = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite n2!");
            //    n2 = double.Parse(Console.ReadLine());


            //    switch (operacao)
            //    {
            //        case '+':
            //            Console.WriteLine($"{n1}+{n2}={Somar(n1, n2)}");
            //            break;

            //        case '-':
            //            Console.WriteLine($"{n1}-{n2}={subtrair(n1, n2)}");
            //            break;

            //        case '*':
            //            Console.WriteLine($"{n1}*{n2}={ Multiplicacao(n1, n2)}");
            //            break;

            //        case '/':
            //            Console.WriteLine($"{n1}/{n2}={ Divisao(n1, n2)}");
            //            break;

            //        default:
            //            Console.WriteLine("Operação invalida!");
            //            break;
            //    }

            //    static int Somar(double n1, double n2)
            //    {

            //        return (int)(n1 + n2);
            //    }
            //    static int subtrair(double n1, double n2)
            //    {
            //        return (int)(n1 - n2);
            //    }
            //    static int Multiplicacao(double n1, double n2)
            //    {
            //        return (int)(n1 * n2);
            //    }
            //    static int Divisao(double n1, double n2)
            //    {
            //        return (int)(n1 / n2);
            //    }
            //    Console.WriteLine("Digite q para sair ou Enter para continuar!");
            //    op = char.Parse(Console.ReadLine().Trim().ToUpper());
            //    n1 = n2 = 0;
            //} while (op != 'Q');

            //    int[] numero = new int[30];
            //    for (int i = 0; i > 30; i++)
            //    {
            //        numero[i] = i;
            //    }

            //    OrdemIversa(numero);
            //    ParInpar();

            //    static void ParInpar()
            //    {
            //        int[] par = new int[15];
            //        int[] impar = new int[15];

            //        for (int i = 0; i < 30; i++)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                par[i] = i;
            //            }
            //            else
            //            {
            //                impar[i] = i;
            //            }
            //            Console.Write($"Pares{par[i]}");
            //            Console.Write($"Impares{impar[i]}");
            //        }

            //    }

            //    static void OrdemIversa(int[]numero)
            //    {

            //        for (int i = 30; i >=0; i--)
            //        {
            //            Console.WriteLine(numero[i]);
            //        }

            //    }


            /*Escreva um programa que leia um vetor com 30 elementos inteiros e escreva funções para fazer o que se pede
         * (utilizar o vetor declarado globalmente)
       a. Exibir os elementos do vetor na ordem inversa
       b. Decompor em dois outros vetores, um contendo os elementos de índice ímpar e outro com os elementos de índice par
       c. Decompor em dois outros vetores, um contendo os elementos de valor ímpar e outro com os elementos de valor par.*/

            //    int[] vetor = new int[10];
            //    int i;
            //    for (i = 0; i < 10; i++)
            //    {
            //        Console.Write("Digite o elemento " + i + " = ");
            //        vetor[i] = int.Parse(Console.ReadLine());
            //    }
            //    exibirInverso(vetor);
            //    decompoeIPar(vetor);
            //    decompoeIImpar(vetor);
            //    decompoePar(vetor);
            //    decompoeImpar(vetor);
            //}
            //private static void decompoeImpar(int[] vetor)
            //{
            //    int i, j, ei = 0;
            //    for (i = 0; i < vetor.Length; i++)
            //    {
            //        if (vetor[i] % 2 != 0)
            //        {
            //            ei++;
            //        }
            //    }
            //    int[] impar = new int[ei];
            //    for (i = 0, j = 0; i < vetor.Length; i++)
            //    {
            //        if (vetor[i] % 2 != 0)
            //        {
            //            impar[j] = vetor[i];
            //            j++;
            //        }
            //    }
            //    Console.WriteLine("Elementos ímpares: ");
            //    mostraVetor(impar);
            //}
            //private static void decompoePar(int[] vetor)
            //{
            //    int i, j, p = 0;
            //    int[] par;
            //    for (i = 0; i < vetor.Length; i++)
            //        if (vetor[i] % 2 == 0)
            //            p++;
            //    par = new int[p];
            //    for (i = 0, j = 0; i < vetor.Length; i++)
            //    {
            //        if (vetor[i] % 2 == 0)
            //        {
            //            par[j] = vetor[i];
            //            j++;
            //        }
            //    }
            //    Console.WriteLine("Elementos pares: ");
            //    mostraVetor(par);
            //}
            //private static void decompoeIImpar(int[] vetor)
            //{
            //    int[] iimpar = new int[5];
            //    int i, j = 0;
            //    for (i = 0; i < vetor.Length; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            iimpar[j] = vetor[i];
            //            j++;
            //        }
            //    }
            //    Console.WriteLine("Vetor com indices ímpares: ");
            //    mostraVetor(iimpar);
            //}
            //private static void mostraVetor(int[] vetor)
            //{
            //    int i;
            //    for (i = 0; i < vetor.Length; i++)
            //    {
            //        Console.WriteLine("Elemento " + i + " = " + vetor[i]);
            //    }
            //}
            //private static void decompoeIPar(int[] vetor)
            //{
            //    int[] ipar = new int[5];
            //    int i, j = 0;
            //    for (i = 0; i < vetor.Length; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            ipar[j] = vetor[i];
            //            j++;
            //        }
            //    }
            //    Console.WriteLine("Vetor com indices pares: ");
            //    mostraVetor(ipar);
            //}
            //private static void exibirInverso(int[] vetor)
            //{
            //    int i;
            //    for (i = 4; i >= 0; i--)
            //    {
            //        Console.WriteLine("Elemento " + i + " =" + vetor[i]);
            //    }


            //Escrever um programa que lê um vetor double de 15 elementos.A seguir,
            //deve mostrar cada elemento do vetor multiplicado pelo seu índice(posição),
            //em uma função chamada cálculo.
            double[] vetor = new double[3];
            double res;
            int i;
            for ( i = 0; i < 3; i++)
            {
                vetor[i] = int.Parse(Console.ReadLine());
            }
            cálculo(i);

            //Escreva um programa que leia uma matriz de inteiros com ordem 10x10
            //e por meio de funções faça o que se pede:
            //a.Exiba o menor elemento da matriz
            //b.Encontre e exiba o maior elemento de cada uma das linhas da matriz





        }

        private static void cálculo(int _i)
        {
            for (int i = 0; i < 3; i++)
            {
              var total=  vetor[i] * i;
            }
        }
    }
}


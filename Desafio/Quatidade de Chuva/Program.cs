using System;

namespace Quatidade_de_Chuva
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 30, maior = 0;
            double media = 0, acimaMedia = 0;
            int[] dias = new int[30];

            for (int i = 0; i < 30; i++)
            {

                Console.WriteLine($"Digite o volume de chuvas no Dia {i}!");
                dias[i] = int.Parse(Console.ReadLine());

                maior = (dias[i] > maior) ? maior = dias[i] : maior;
                media += (dias[i] / mes);
                acimaMedia = (dias[i] > media) ? acimaMedia = dias[i] : acimaMedia;
            }


            for (int i = 0; i < 30; i++)
            {
                if (dias[i]> media)
                {
                    Console.WriteLine($" volume de chuvas acima da Media! {i}!");
                }
            }

            Console.WriteLine($"Media de chuvas:{media}");
            Console.WriteLine($"Maior quantidade de chuva que ocorreu no mês:{maior}");
        }
    }
}

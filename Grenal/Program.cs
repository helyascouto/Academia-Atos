using System;

namespace Grenal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool op = true;
            int GolsGremio = 0;
            int VitoriaGremio = 0;
            int VitoriaInter = 0;
            int GolsInter = 0;
            int Empates = 0;
            int TotalGrenal = 0;


            do
            {
                Console.WriteLine("Didite o numero de Gols do Gremio!");
                GolsGremio = int.Parse(Console.ReadLine());
                Console.WriteLine("Didite o numero de Gols do Internacional!");
                GolsInter = int.Parse(Console.ReadLine());
                TotalGrenal++;
                Console.WriteLine("Novo Grenal(1. Sim 2. Não)?");
                int opsao = int.Parse(Console.ReadLine());
                op = (opsao == 1) ? op = true : op = false;

                if (GolsGremio > GolsInter)
                {
                    VitoriaGremio++;
                }
                else if (GolsGremio == GolsInter)
                {
                    Empates++;
                }
                else
                {
                    VitoriaInter++;
                }


            } while (op);
            Console.WriteLine($"Total de Grenal-{TotalGrenal} |vitórias do Grêmio-{VitoriaGremio}|vitórias do Inter-{VitoriaInter} |Empates-{Empates} ");

            if (VitoriaGremio > VitoriaInter)
            {
                Console.WriteLine("Maior vencedor dos Grenais “Gremio!”");

            }
            else if (VitoriaGremio < VitoriaInter)
            {
                Console.WriteLine("Maior vencedor dos Grenais “Internacional!”");

            }
            else
            {
                Console.WriteLine("Não houve vencedor nos Grenais!");
            }

        }


    }

}




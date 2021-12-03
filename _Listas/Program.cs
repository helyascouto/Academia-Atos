using System;
using System.Collections.Generic;

namespace _Listas
{
    class Program
    {
        static List<Pessoa> pessoas = new List<Pessoa>();

        static void Main(string[] args)
        {
            
            Pessoa Pessoa = new Pessoa();
            Pessoa.Nome = "LORENA";
            Pessoa.idade = 32;
            pessoas.Add(Pessoa);

            pessoas.Add(new Pessoa("Elias", 35));
            pessoas.Add(new Pessoa("Yan", 3));
            pessoas.Add(new Pessoa("Yasmin", 11));

            Console.WriteLine("Inserindo uma pessoa na posição 1 e outra na posição 3");
            pessoas.Insert(1, new Pessoa() { Nome = "Andre", idade = 55 });
            pessoas.Insert(3, new Pessoa() { Nome = "Pedro", idade = 37 });
            pessoas.Insert(5, new Pessoa("Ana", 18));

            Disciplina disciplina = new Disciplina();
            disciplina.listaOrdenadaPorNome();
            //listaNaoOrdenada();
            //listaOrdenadaPorNome();
            //listaOrdenadaPorIdade();

            Console.WriteLine("Convertendo uma lista para um array");
            Pessoa[] listaArray = pessoas.ToArray();
            foreach (var lista in listaArray)
            {
                Console.WriteLine(lista.Nome + " " + lista.idade);
            }


            Console.WriteLine("Recupera todos os elementos da lista de acordo com as condição");
            List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa P) { return P.idade < 45; });
            jovem.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.idade);
            });


            foreach (var p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.idade);
            }

            static void listaNaoOrdenada()
            {
                Console.WriteLine("Lista não Ordenada");
                pessoas.ForEach(delegate (Pessoa p)
                    {
                        Console.WriteLine("Lista não Ordenada");
                    });
            }
            static void listaOrdenadaPorNome()
            {
                Console.WriteLine("Lista Ordenada Por Nome");
                pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
                {
                    return p1.Nome.CompareTo(p2.Nome);
                });
            }

            static void listaOrdenadaPorIdade()
            {
                Console.WriteLine("Lista Ordenada Por Nome");
                pessoas.Sort(delegate (Pessoa p1, Pessoa p2)
                {
                    return p1.idade.CompareTo(p2.idade);
                });
            }
        }
    }
}

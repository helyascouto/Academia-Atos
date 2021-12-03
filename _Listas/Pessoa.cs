using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Listas
{
   public class Pessoa
    {
        static List<Pessoa> pessoas = new List<Pessoa>();
        public Pessoa()
        {

        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            this.idade = idade;
        }

        public string Nome { get; set; }
        public int idade { get; set; }

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
    }
}

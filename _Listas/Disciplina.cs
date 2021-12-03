using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Listas
{

    public class Disciplina
    {
        static List<Disciplina> listaDisciplina = new List<Disciplina>();


        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        public Disciplina()
        {

        }

        public Disciplina(string nome, int cargaHoraria)
        {
            Nome = nome;
            CargaHoraria = cargaHoraria;
        }

        public void listaOrdenadaPorNome()
        {
            Console.WriteLine("Lista Ordenada Por Nome");
            listaDisciplina.Sort(delegate (Disciplina p1, Disciplina p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
        }
        public void listaOrdenadaPorIdade()
        {
            Console.WriteLine("Lista Ordenada Por carga horaria");
            listaDisciplina.Sort(delegate (Disciplina p1, Disciplina p2)
            {
                return p1.CargaHoraria.CompareTo(p2.CargaHoraria);
            });
        }
    }


}

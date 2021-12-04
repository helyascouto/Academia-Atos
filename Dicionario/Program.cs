using System;
using System.Collections.Generic;

namespace Dicionario
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            Console.WriteLine("Hello World!");


            dic.Add(1, "Maria");
            dic.Add(2, "Pedro");
            dic.Add(3, "Paulo");
            dic.Add(4, "Yan");
            dic.Add(5, "Marcos");


            foreach (KeyValuePair<int, string> item in dic)
            {
                Console.WriteLine($"key= {item.Key} valor={item.Value}");
            }
            Console.WriteLine(dic[2]);
            Console.WriteLine(dic[1]);

            string resultado;
            if (dic.TryGetValue(1, out resultado))
            {
                Console.WriteLine(resultado + "resutado");
            }
            else
            {
                Console.WriteLine("Não foi possivel achar a chave espesificada");
            }


            //verifica se a elementos
            Console.WriteLine(dic.ContainsKey(1));
            Console.WriteLine(dic.ContainsKey(6));

            //remove pelo key
            dic.Remove(1);

            Dictionary<int, Pessoa> dic2 = new Dictionary<int, Pessoa>();
            Pessoa p1 = new Pessoa("Elias");
            Pessoa p2 = new Pessoa("Lorena");
            dic2.Add(1, p1);
            dic2.Add(2, p2);
            Console.WriteLine(p1.nome);





        }



    }
}

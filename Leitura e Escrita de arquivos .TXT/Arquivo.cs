using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leitura_e_Escrita_de_arquivos.TXT
{

    class Arquivo
    {


        string nome, mensagem;
        StreamWriter sw;
        StreamReader sr;
        public Arquivo(string nome)
        {
            this.nome = nome;
        }

        public void criaAbreArquivo()
        {
            sw = new StreamWriter("C:\\Arquivo\\" + nome + ".txt");

        }

        public void lerArquivo()
        {
            string linha;
            sr = new StreamReader("C:\\Arquivo\\" + nome + ".txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();

        }

        public void gravaMensagem(string mensagem)
        {
            sw.WriteLine(mensagem);
        }

        public void fechaArquivo()
        {
            sw.Close();
        }
    }
}

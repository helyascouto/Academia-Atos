using System;
using System.IO;

namespace LeituraEscrita
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Criar um arquivo que armazene uma quantidade de alunos(5, 10, 15).
            //    Deve ser armazenado o nome do aluno e três notas.
            //    Após fazer a gravação do arquivo, percorrer o arquivo e apresentar o nome e a média aritmética do aluno.


            Pessoa pessoa = new Pessoa();
            StreamWriter sw = new StreamWriter("C:\\Arquivo\\notas.sql");
            //string nome;
            double n1, n2, n3, qt;
            Console.WriteLine("Quantos alunos você vai cadastrar? ");
            qt = int.Parse(Console.ReadLine());
            for (int i = 0; i < qt; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                pessoa.Nome = Console.ReadLine();
                sw.WriteLine(pessoa.Nome);
                Console.WriteLine("Digite nota 1: ");
                n1 = double.Parse(Console.ReadLine());
                sw.WriteLine(n1);
                Console.WriteLine("Digite nota 2: ");
                n2 = double.Parse(Console.ReadLine());
                sw.WriteLine(n2);
                Console.WriteLine("Digite nota 1: ");
                n3 = double.Parse(Console.ReadLine());
                sw.WriteLine(n3);
            }
            sw.Close();
            string linha;
            double nl1, nl2, nl3, media;
            StreamReader sr = new StreamReader("C:\\Arquivo\\notas.sql");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine("O nome do individuo é: " + linha);
                linha = sr.ReadLine(); // pulo para a linha da primeira nota
                nl1 = double.Parse(linha);
                linha = sr.ReadLine(); // pulo para a linha da segunda nota
                nl2 = double.Parse(linha);
                linha = sr.ReadLine(); // pulo para a linha da terceira nota
                nl3 = double.Parse(linha);
                media = (nl1 + nl2 + nl3) / 3;
                Console.WriteLine("A media é igual " + media);
                linha = sr.ReadLine(); //pulo para o proximo aluno e se não tiver mais alunos, vai para fim do arquivo, ou seja, linha == null
            }
            sr.Close();










            string nome, mensagem;
            Console.WriteLine("Digite o nome do arquivo: ");
            nome = Console.ReadLine();
            Arquivo a = new Arquivo(nome);
            int op;
            while (true)
            {
                Console.WriteLine("Digite uma operação:\n1 - para escrever no arquivo\n2 - para apresentar o texto do arquivo\n3 - para finalizar a execução ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    a.criaAbreArquivo();
                    Console.WriteLine("Digite a mensagem para ser armazenada: \nPara sair, digite SAIR");
                    while (true)
                    {
                        mensagem = Console.ReadLine();
                        if (mensagem.Equals("SAIR"))
                        {
                            a.fechaArquivo();
                            break;
                        }
                        else
                        {
                            a.gravaMensagem(mensagem);
                        }
                    }
                }
                else if (op == 2)
                {
                    a.lerArquivo();
                }
            }
        }
    }
}


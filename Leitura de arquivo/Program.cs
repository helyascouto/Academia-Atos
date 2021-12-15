using System;
using System.IO;
using System.Text;

namespace Leitura_de_arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string nome, mensagem;
            Console.WriteLine("Digite o nome do arquivo para ser criado: ");
            nome = Console.ReadLine();
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(@"C:\Users\Elias Couto\Source\Repos\helyascouto\Academia - Atos\Leitura de arquivo\" + nome + ".txt", true, Encoding.UTF8);
                while (true)
                {
                    Console.WriteLine("Digite uma mensagem para o futuro: ");
                    mensagem = Console.ReadLine();
                    if (!mensagem.Equals("quit"))
                    {
                        sw.WriteLine(mensagem);
                    }
                    else
                    {
                        break;
                    }
                }
                sw.Close();
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Fim da execução");
            }
            // StreamReader sr = new StreamReader();
        }
    }
}

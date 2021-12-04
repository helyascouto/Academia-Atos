using System;

namespace ExceptionAula
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string n = null;
                int ch;
                try
                {
                    chamaFuncao(n);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                int x = 0, d = 0;
                try
                {
                    x = int.Parse(Console.ReadLine());
                    d = int.Parse(Console.ReadLine());
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Finalizamos a execução");
                }
                try
                {
                    Console.WriteLine("Divisão :" + divide(x, d));
                }
                catch (DivideByZeroException e) //catch(Exception e)
                {
                    Console.WriteLine("Aqui o erro é referente a divisão por 0");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Erro throw: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro exceção geral " + e.Message);
                }
            }
            private static int divide(int x, int d)
            {
                if (x >= 0 && d >= 0) // eu quero que a operação ocorra somente com numeros positivos
                    return x / d;
                else
                    throw new Exception("Não foi possivel fazer a operação pois algum dos operadores não era maior que zero");
            }
            private static void chamaFuncao(string n)
            {
                if (!string.IsNullOrEmpty(n))
                {
                    Console.WriteLine("Mensagem da função chamaFuncao " + n);
                }
                else
                {
                    throw new ArgumentException("n", "O valor é nulo ou vazio");
                }
            }
        
        
    }
}

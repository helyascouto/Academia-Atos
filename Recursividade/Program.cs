using System;
namespace calculadora_funcoes
{
    class Program
    {
        /*Leia dois números e leia a operação que deseja: (+, -, *, /) e efetue a operação.
        Caso não seja possível efetuar a operação, informe e solicite novos valores.
        As operações devem aceitar números quebrados.
        Faça que o programa sempre volte para a leitura da operação e dos valores (para sair, digite 'q')*/
        static double soma(double n1, double n2)
        {
            return (n1 + n2);
        }
        static double multiplicacao(double n1, double n2)
        {
            return (n1 * n2);
        }
        static double subtracao(double n1, double n2)
        {
            return (n1 - n2);
        }
        static double divisao(double n1, double n2)
        {
            return (n1 / n2);
        }
        static void selecao()
        {
            double num1, num2;
            char op;
            Console.WriteLine("\nDigite um numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("selecione uma opcao: ");
            Console.WriteLine("+ para somar: ");
            Console.WriteLine("- para subtrair: ");
            Console.WriteLine("* para multiplicar: ");
            Console.WriteLine("/ para dividir: ");
            Console.WriteLine("ou 'q' para sair da calculadora");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    Console.WriteLine(num1 + " + " + num2 + " = " + soma(num1, num2));
                    selecao();
                    break;
                case '-':
                    Console.WriteLine(num1 + " - " + num2 + " = " + subtracao(num1, num2));
                    selecao();
                    break;
                case '*':
                    Console.WriteLine(num1 + " X " + num2 + " = " + multiplicacao(num1, num2));
                    selecao();
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("operação invalida! (divisor = 0)");
                        selecao();
                    }
                    Console.WriteLine(num1 + " ÷ " + num2 + " = " + divisao(num1, num2));
                    selecao();
                    break;
                case 'q':
                    Console.WriteLine("saiu da calculadora");
                    break;
                default:
                    Console.WriteLine("opção não existe: ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("bem vindo à calculadora: ");
            selecao();
        }
    }
}



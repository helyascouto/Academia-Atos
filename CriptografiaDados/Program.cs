using CriptografiaDados.Model;
using CriptografiaSimetricaAndAssimetrica;
using System;

namespace CriptografiaDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Utilizando chaves Assimetrica");
  
            Assimetrica assimetrica = new Assimetrica();
            string dadosCriptografados;

            Console.WriteLine("Digite uma mensagem para criptografar!");
            string msg = Console.ReadLine();

            dadosCriptografados = assimetrica.encrypt(msg);
            Console.WriteLine("Mensagem criptografada : " + dadosCriptografados);

            string dadosDecriptografados = assimetrica.decrypt(dadosCriptografados);
            Console.WriteLine("Mensagem Descriptografada : " + dadosDecriptografados);

            /*AES significa Advanced Encryption Standard e foi desenvolvido para atualizar o algoritmo DES original.
            Entre alguns dos aplicativos mais comuns de algoritmo AES incluem-se aplicativos de mensagens, como o Signal ou WhatsApp, e
            o programa de compactação de arquivos WinZip.*/


            //Console.WriteLine("Utilizando chaves simetricas1");
            //Console.WriteLine("Agoritimo AES");
            //Simetrica simetrica = new Simetrica();
            //string dadosCriptografados;
            //string dadosCriptografados2;
            //Console.WriteLine("Digite uma mensagem para criptografar!");
            //string msg = Console.ReadLine();

            //dadosCriptografados = simetrica.EncryptData(msg, "Atos");
            //Console.WriteLine("Mensagem criptografada : " + dadosCriptografados);

            //Console.WriteLine("Digite uma mensagem2 para criptografar!");
            //string msg2 = Console.ReadLine();

            //dadosCriptografados2 = simetrica.EncryptData(msg2, "Ufn");
            //Console.WriteLine("Mensagem 2 criptografada : " + dadosCriptografados2);


            //string dadosDecriptografados;
            //string dadosDecriptografados2;

            //dadosDecriptografados = simetrica.DecryptData(dadosCriptografados, "Atos");
            //Console.WriteLine("Mensagem Descriptografada : " + dadosCriptografados);

            //dadosDecriptografados2 = simetrica.DecryptData(dadosCriptografados2, "Ufn");
            //Console.WriteLine("Mensagem Descriptografada : " + dadosCriptografados2);

        }
    }
}

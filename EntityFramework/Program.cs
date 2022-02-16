



using EntityFramework;
using EntityFramework.Model;

Console.WriteLine(@"1-Criar Pessoa ,
2 - Alterar o Nome,
3 - Inserir um email,
4 - Excluir a pessoa,
5 - Consultar todos,
6 - Consultar ID");

int op = int.Parse(Console.ReadLine());

Context context = new Context();

switch (op)
{ case 1:
        try
        {
            Email email = new Email();
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Adicionar o nome da pessoa!");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Adicionar o email da pessoa!");
            email.email = Console.ReadLine();

            pessoa.Emails = new List<Email>();
            pessoa.Emails.Add(email);

            context.pessoas.Add(pessoa);
            context.SaveChanges();
     


        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        break;





    default:
        break;
}


        
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WebAppMVC.Controllers
{
    public class PessoaController : Controller
    {
        public string Index()
        {
            return "Olá Pessoas";
        }
        public string admin()
        {
            return "Olá Admin";
        }
        public string MostraNome(string nome)
        {
            return HtmlEncoder.Default.Encode("Ola " + nome) ;
        }
    }
}

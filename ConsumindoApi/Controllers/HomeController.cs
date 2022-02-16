using ConsumindoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ConsumindoApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Pessoas()
        {
            string baseUrl = "http://localhost:5258/";

            List<Pessoa>? pessoa = new List<Pessoa>();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage Response = await client.GetAsync("api/pessoas");

            if (Response.IsSuccessStatusCode)
            {
                var dados = Response.Content.ReadAsStringAsync().Result;
                pessoa = JsonConvert.DeserializeObject<List<Pessoa>>(dados);
            }
            return View(pessoa);
        }
        public async Task<IActionResult> PessoasId(int id)
        {
            string baseUrl = "http://localhost:5258/";
            Pessoa? pessoa = new Pessoa();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage Response = await client.GetAsync("api/pessoas" + id);

            if (Response.IsSuccessStatusCode)
            {
                var dados = Response.Content.ReadAsStringAsync().Result;
                pessoa = JsonConvert.DeserializeObject<Pessoa>(dados);
            }
            return View(pessoa);
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(Pessoa p)
        {
            string baseUrl = "http://localhost:5258/";
            HttpClient client = new HttpClient();
            HttpResponseMessage Response = await client.PostAsJsonAsync(baseUrl+"Api/pessoa",p);

            return RedirectToAction("pessoas");
        }
    }
}

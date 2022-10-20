using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationReview.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SemTraumasController : ControllerBase
    {
        public SemTraumasController() { }

        [HttpGet]//verbo, chama a função
        public string HelloWorld() => "Hello World!";//função

        [HttpGet("{nome}",Name ="nome")]//verbo, chama a função//name define o mapemento do dado
        public string HelloWorld(string nome) => nome;//função

        [HttpPost("Hello/{n}")]
        public string HelloWorldName(string n) => $"Hello World {n}!";
    }
}

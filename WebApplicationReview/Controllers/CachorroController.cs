using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using WebApplicationReview.Models;
using WebApplicationReview.Services;

namespace WebApplicationReview.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CachorroController : ControllerBase
    {
        private readonly CachorroService _cachorroService;
       public static List<Cachorro> dogs { get; set; } = new List<Cachorro>();

        public CachorroController(CachorroService cachorroService)
        {
            _cachorroService = cachorroService;
        }

        [HttpGet]
        public ActionResult<List<Cachorro>> Get() => _cachorroService.GetAll();
       
        [HttpGet("Nome/{n}", Name = "BuscaNome")]
        public ActionResult<Cachorro> GetByName(string n)
        {
            var dog = _cachorroService.GetByName(n);
            if (dog == null) return NotFound();
            return Ok(dog);
        }
       
        [HttpPost]
        public ActionResult<Cachorro> AdicionaDog(Cachorro cachorro)
        {
            _cachorroService.Create(cachorro);
            return CreatedAtRoute("BuscaNome", cachorro.Nome);
        }
    }
}

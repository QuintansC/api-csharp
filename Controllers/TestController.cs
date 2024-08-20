using api_csharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace api_csharp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TesteController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Teste")]
        public IEnumerable<Teste> Post()
        {
            return Enumerable.Range(1, 5).Select(index => new Teste
            {
                Nome = "Gustavo",
                TemperaturaC = Random.Shared.Next(-20, 55),
                Sobrenome = "Quintans"
            })
            .ToArray();
        }
    }
}

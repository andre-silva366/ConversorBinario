using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversaoBinarioTextoController : ControllerBase
    {
        [HttpGet]
        public IActionResult BinarioParaTexto(string texto)
        {
            ConversaoTextoBinario ctb = new ConversaoTextoBinario(texto);
            var resultado = ctb.ConverterBinarioTexto(texto);
            return Ok(resultado);
        }
    }
}

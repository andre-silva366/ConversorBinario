using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorBinarioTextoController : ControllerBase
    {
        [HttpGet]
        public IActionResult BinarioParaTexto(string texto)
        {
            Conversor ctb = new Conversor(texto);
            var resultado = ctb.ConverterBinarioTexto(texto);
            return Ok(resultado);
        }
    }
}

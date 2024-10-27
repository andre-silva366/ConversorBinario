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
            try
            {
                var resultado = Conversor.ConverterBinarioTexto(texto);
                return Ok(resultado);
            }
            catch
            {
                return BadRequest("Não foi possível a conversão");
            }
            
        }
    }
}

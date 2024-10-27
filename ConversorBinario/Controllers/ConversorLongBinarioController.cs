using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorLongBinarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult LongParaBinario(long numero)
        {
            Conversor conversor = new Conversor(numero);
            string resultado = conversor.ConverterLongBinario(numero);
            return Ok(resultado);
        }
    }
}

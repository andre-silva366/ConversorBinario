using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversorTextoHexadecimalController : ControllerBase
{
    [HttpGet]
    public IActionResult TextoParaHexadecimal(string texto)
    {
        try
        {
            var resultado = Conversor.ConverterTextoHexadecimal(texto);
            return Ok(resultado);
        }
        catch
        {
            return BadRequest("Não foi possível a conversão");
        }
        
    }
}

using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversorTextoBinarioController : ControllerBase
{
    [HttpGet]
    public IActionResult TextoParaBinario(string texto)
    {
        try
        {
            var resultado = Conversor.ConverterTextoBinario(texto);
            return Ok(resultado);
        }
        catch
        {
            return BadRequest("Não foi possível a conversão");
        }
        
    }

   
}

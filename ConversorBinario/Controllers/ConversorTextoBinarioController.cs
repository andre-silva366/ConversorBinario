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
        Conversor ctb = new Conversor(texto);
        var resultado = ctb.ConverterTextoBinario(texto);
        return Ok(resultado);
    }

   
}

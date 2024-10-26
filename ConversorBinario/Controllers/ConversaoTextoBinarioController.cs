using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversaoTextoBinarioController : ControllerBase
{
    [HttpGet]
    public IActionResult TextoParaBinario(string texto)
    {
        ConversaoTextoBinario ctb = new ConversaoTextoBinario(texto);
        var resultado = ctb.ConverterTextoBinario(texto);
        return Ok(resultado);
    }

   
}

using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversorBinarioLongController : ControllerBase
{
    [HttpGet]
    public IActionResult BinarioParaLong(string numero)
    {
        try
        {
            var resultado = Conversor.ConverterBinarioLong(numero);
            return Ok(resultado);
        }
        catch(Exception)
        {
            return BadRequest($"Ocorreu em erro ao converter, numeros binários são compostos apenas de 0 e 1");
        }
    }

}

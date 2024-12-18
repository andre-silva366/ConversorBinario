﻿using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversorLongBinarioController : ControllerBase
{
    [HttpGet]
    public IActionResult LongParaBinario(long numero)
    {
        try
        {
            string resultado = Conversor.ConverterLongBinario(numero);
            return Ok(resultado);
        }
        catch
        {
            return BadRequest("Não foi possível a conversão");
        }
        
    }
}

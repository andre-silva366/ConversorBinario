﻿using ConversorBinario.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ConversorBinario.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ConversorHexadecimalTexto : ControllerBase
{
    [HttpGet]
    public IActionResult HexadecimalParaTexto(string hexadecimal)
    {
        try
        {
            var resultado = Conversor.ConverterHexadecimalTexto(hexadecimal);
            return Ok(resultado);
        }
        catch
        {
            return BadRequest("Não foi possível a conversão");
        }
        
    }    

}




using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

[ApiController]
[Route("api/articulos")]
public class ArticuloController : ControllerBase
{
    private readonly ArticuloService _articuloService;

    public ArticuloController(ArticuloService articuloService)
    {
        _articuloService = articuloService;
    }


    [HttpPost(Name = "IngresarArticulo")]
    public IActionResult IngresarCliente([FromBody] ArticuloViewModel articuloViewModel)
    {
        try
        {
            _articuloService.Ingresararticulo(articuloViewModel);
            return CreatedAtRoute("IngresarArticulo", articuloViewModel);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult ObtenerTodosArticulos()
    {
        try
        {
            var articulos = _articuloService.ObtenerTodosArticulos();
            return Ok(articulos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    // GET: api/articulo/5
    [HttpGet("{codigoArticulo}")]
    public IActionResult ObtenerArticuloPorCodigo(string codigoArticulo)
    {
        try
        {
            var articulo = _articuloService.ObtenerArticuloPorCodigo(codigoArticulo);

            if (articulo == null)
            {
                return NotFound($"No se encontró el artículo con codigo {codigoArticulo}");
            }

            return Ok(articulo);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }


    [HttpPut("{codigoArticulo}")]
    public IActionResult ModificarArticulo(string codigoArticulo, [FromBody] ArticuloViewModel articuloViewModel)
    {
        try
        {
            _articuloService.Modificararticulo(codigoArticulo, articuloViewModel);
            return Ok();
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/ordencompra")]
public class OrdenCompraController : ControllerBase
{
    private readonly OrdenCompraService _ordenCompraService;

    public OrdenCompraController(OrdenCompraService ordenCompraService)
    {
        _ordenCompraService = ordenCompraService;
    }

    // POST: api/ordencompra/crear
    [HttpPost("crear")]
    public IActionResult CrearOrdenCompra([FromBody] OrdenCompraViewModel ordenCompraViewModel)
    {
        try
        {
            var ordenCompraCreada = _ordenCompraService.CrearOrdenCompra(ordenCompraViewModel);
            return Ok(ordenCompraCreada);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }
}

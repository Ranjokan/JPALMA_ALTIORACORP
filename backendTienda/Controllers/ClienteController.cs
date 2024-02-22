using Microsoft.AspNetCore.Mvc;

[Route("api/clientes")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly ClienteService _clienteService;

    public ClienteController(ClienteService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet]
    public IActionResult ObtenerTodosClientes()
    {
        try
        {
            var clientes = _clienteService.ObtenerTodosClientes();
            return Ok(clientes);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }

    }

    [HttpGet("{dni}")]
    public IActionResult ObtenerClientePorDNI(string dni)
    {
        try
        {
             var cliente = _clienteService.ObtenerClientePorDNI(dni);

        if (cliente == null)
        {
            return NotFound($"No se encontró el cliente con DNI {dni}");
        }

        return Ok(cliente);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
       
    }

    [HttpPost(Name = "IngresarCliente")]
    public IActionResult IngresarCliente([FromBody] ClienteViewModel clienteViewModel)
    {
        try
        {
            _clienteService.IngresarCliente(clienteViewModel);
            return CreatedAtRoute("IngresarCliente", clienteViewModel);
        }
        catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{dni}")]
    public IActionResult ModificarCliente(string dni, [FromBody] ClienteViewModel clienteViewModel)
    {
        try
        {
            _clienteService.ModificarCliente(dni, clienteViewModel);
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

    [HttpDelete("{dni}")]
    public IActionResult EliminarCliente(string dni)
    {
        try
        {
            _clienteService.EliminarCliente(dni);
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

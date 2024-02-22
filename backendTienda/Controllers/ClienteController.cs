// Controllers/ClienteController.cs
using Microsoft.AspNetCore.Mvc;

[Route("api/clientes")]
[ApiController]
public class ClienteController : ControllerBase
{
    private readonly ClienteRepository _clienteRepository;

    public ClienteController(ClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    [HttpPost]
    public ActionResult<Cliente> IngresarCliente([FromBody] Cliente nuevoCliente)
    {
        try
        {
            var clienteIngresado = _clienteRepository.IngresarCliente(nuevoCliente);
            return Ok(clienteIngresado);
        }
        catch (InvalidOperationException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al ingresar el cliente: {ex.Message}");
        }
    }

    [HttpPut("{dni}")]
    public ActionResult<Cliente> ModificarCliente(string dni, [FromBody] Cliente clienteActualizado)
    {
        try
        {
            var clienteModificado = _clienteRepository.ModificarCliente(dni, clienteActualizado);
            if (clienteModificado == null)
            {
                return NotFound();
            }
            return Ok(clienteModificado);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al modificar el cliente: {ex.Message}");
        }
    }

    [HttpGet("{dni}")]
    public ActionResult<Cliente> ObtenerClientePorDNI(string dni)
    {
        try
        {
            var cliente = _clienteRepository.ObtenerClientePorDNI(dni);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al obtener el cliente por DNI: {ex.Message}");
        }
    }

    [HttpGet]
    public ActionResult<List<Cliente>> ObtenerTodosClientes()
    {
        try
        {
            var clientes = _clienteRepository.ObtenerTodosClientes();
            return Ok(clientes);
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al obtener todos los clientes: {ex.Message}");
        }
    }

    [HttpDelete("{dni}")]
    public ActionResult EliminarCliente(string dni)
    {
        try
        {
            _clienteRepository.EliminarCliente(dni);
            return NoContent();
        }
        catch (Exception ex)
        {
            return BadRequest($"Error al eliminar el cliente: {ex.Message}");
        }
    }
}

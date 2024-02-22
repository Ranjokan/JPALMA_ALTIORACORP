using Microsoft.AspNetCore.Mvc;

public interface IClienteController
{
    IActionResult IngresarCliente(ClienteViewModel clienteViewModel);
    IActionResult ModificarCliente(int clienteId, ClienteViewModel clienteViewModel);
    IActionResult EliminarCliente(int clienteId);
}
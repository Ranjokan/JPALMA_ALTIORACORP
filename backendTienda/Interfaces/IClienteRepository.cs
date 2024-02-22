// IClienteRepository.cs
public interface IClienteRepository
{
    List<Cliente> ObtenerTodosClientes();
    Cliente ObtenerClientePorDNI(string dni);
    Cliente IngresarCliente(Cliente nuevoCliente);
    Cliente ModificarCliente(string dni, Cliente clienteActualizado);
    void EliminarCliente(string dni);
}

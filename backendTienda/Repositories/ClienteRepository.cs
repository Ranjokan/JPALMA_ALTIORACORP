// Repositories/ClienteRepository.cs
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class ClienteRepository : IClienteRepository
{
    private readonly AppDbContext _context;

    public ClienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public Cliente IngresarCliente(Cliente nuevoCliente)
    {
        try
        {
            if (_context.Cliente.Any(c => c.DNI.Equals(nuevoCliente.DNI)))
            {
                throw new InvalidOperationException("Ya existe un cliente con ese DNI.");
            }

            _context.Cliente.Add(nuevoCliente);
            _context.SaveChanges();
            return nuevoCliente;
        }
        catch (Exception ex)
        {

            throw new Exception("Error al ingresar el cliente.", ex);
        }
    }

    public Cliente ModificarCliente(string dni, Cliente clienteActualizado)
    {
        try
        {
            var clienteExistente = _context.Cliente.FirstOrDefault(c => c.DNI.Equals(dni));
            if (clienteExistente != null)
            {
                _context.Cliente.Update(clienteActualizado);

                _context.SaveChanges();
            }
            return clienteActualizado;
        }
        catch (Exception ex)
        {

            throw new Exception("Error al modificar el cliente.", ex);
        }
    }

    public Cliente ObtenerClientePorDNI(string dni)
    {
        try
        {
            return _context.Cliente.FirstOrDefault(c => c.DNI == dni);
        }
        catch (Exception ex)
        {

            throw new Exception("Error al obtener el cliente por DNI.", ex);
        }
    }

    public List<Cliente> ObtenerTodosClientes()
    {
        try
        {
            return _context.Cliente.ToList();
        }
        catch (Exception ex)
        {

            throw new Exception("Error al obtener todos los clientes.", ex);
        }
    }

    public Cliente EliminarCliente(Cliente clienteEliminar)
    {
        try
        {
            _context.Cliente.Remove(clienteEliminar);
            _context.SaveChanges();
            return clienteEliminar;

        }
        catch (Exception ex)
        {

            throw new Exception("Error al eliminar el cliente.", ex);
        }
    }
}



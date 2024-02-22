// Repositories/ClienteRepository.cs
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class ClienteRepository
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
            if (_context.Clientes.Any(c => c.DNI.Equals(nuevoCliente.DNI)))
            {
                throw new InvalidOperationException("Ya existe un cliente con ese DNI.");
            }

            _context.Clientes.Add(nuevoCliente);
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
            var clienteExistente = _context.Clientes.FirstOrDefault(c => c.DNI.Equals(dni));
            if (clienteExistente != null)
            {
                clienteExistente.NOMBRE = clienteActualizado.NOMBRE;
                clienteExistente.APELLIDO = clienteActualizado.APELLIDO;
                clienteExistente.DNI = clienteActualizado.DNI;

                _context.SaveChanges();
            }
            return clienteExistente;
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
            return _context.Clientes.FirstOrDefault(c => c.DNI.Equals(dni));
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
            return _context.Clientes.ToList();
        }
        catch (Exception ex)
        {
           
            throw new Exception("Error al obtener todos los clientes.", ex);
        }
    }

    public void EliminarCliente(string dni)
    {
        try
        {
            var clienteExistente = _context.Clientes.FirstOrDefault(c => c.DNI.Equals(dni));
            if (clienteExistente != null)
            {
                _context.Clientes.Remove(clienteExistente);
                _context.SaveChanges();
            }
        }
        catch (Exception ex)
        {
           
            throw new Exception("Error al eliminar el cliente.", ex);
        }
    }
}

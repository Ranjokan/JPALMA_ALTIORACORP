using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using var context = new AppDbContext();
        // Agregar un nuevo cliente
        var nuevoCliente = new Cliente { NOMBRE = "Jacinto", APELLIDO = "Palma", DNI = "1315081685" };
        context.Cliente.Add(nuevoCliente);       
        context.SaveChanges();

        // Consultar clientes
        var clientes = context.Cliente.ToList();
        foreach (var cliente in clientes)
        {
            Console.WriteLine($"ID: {cliente.CLIENTE_ID}, Nombre: {cliente.NOMBRE}, Apellido: {cliente.APELLIDO}, DNI: {cliente.DNI}");
        }
    }
}
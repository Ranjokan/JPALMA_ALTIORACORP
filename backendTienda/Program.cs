using System;
using System.Linq;

class Program
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            // Agregar un nuevo cliente
            var nuevoCliente = new Cliente { Nombre = "Jacinto", Apellido = "Palma", DNI = "1315081685" };
            context.Clientes.Add(nuevoCliente);
            context.SaveChanges();

            // Consultar clientes
            var clientes = context.Clientes.ToList();
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"ID: {cliente.ClienteId}, Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, DNI: {cliente.DNI}");
            }
        }
    }
}
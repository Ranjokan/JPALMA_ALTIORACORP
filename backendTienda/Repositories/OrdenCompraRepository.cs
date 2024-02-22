
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class OrdenCompraRepository : IOrdenCompraRepository
{
    private readonly AppDbContext _context;

    public OrdenCompraRepository(AppDbContext context)
    {
        _context = context;
    }

    
    public OrdenCompra IngresarOrdenCompra(OrdenCompra nuevaOrden)
    {
        try
        {
            _context.OrdenesCompra.Add(nuevaOrden);
            _context.SaveChanges();
            return nuevaOrden;
        }
        catch (Exception ex)
        {
          throw new Exception("Error al ingresar la orden.", ex);
        }
        throw new NotImplementedException();
    }
}
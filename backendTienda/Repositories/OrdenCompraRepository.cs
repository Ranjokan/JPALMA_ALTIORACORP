public class OrdenCompraRepository : IOrdenCompraRepository
{
    private readonly AppDbContext _context;

    public OrdenCompraRepository(AppDbContext context)
    {
        _context = context;
    }

    public OrdenCompra IngresarOrdenCompra(){
        
    }
}
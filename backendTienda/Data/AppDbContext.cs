using Microsoft.EntityFrameworkCore;


public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Cliente> Cliente { get; set; }
    public DbSet<OrdenCompra> OrdenesCompra { get; set; }
    public DbSet<Articulo> Articulos { get; set; }
}
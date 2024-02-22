using Microsoft.EntityFrameworkCore;


public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<OrdenCompra> OrdenesCompra { get; set; }
    public DbSet<Articulo> Articulos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=TIENDA;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
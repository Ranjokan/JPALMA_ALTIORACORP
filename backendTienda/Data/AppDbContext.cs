using Microsoft.EntityFrameworkCore;


public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=JXC\\MSSQLLocalDB;Database=TIENDA;Trusted_Connection=True;");
    }
}
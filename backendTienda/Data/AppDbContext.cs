using Microsoft.EntityFrameworkCore;


public class AppDbContext : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=TIENDA;Trusted_Connection=True;TrustServerCertificate=True");
    }
}
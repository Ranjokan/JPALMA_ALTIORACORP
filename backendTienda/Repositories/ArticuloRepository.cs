using System.Collections.Generic;
using System.Linq;


public class ArticuloRepository : IArticuloRepository
{
    private readonly AppDbContext _context;

    public ArticuloRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Articulo> ObtenerTodosArticulos()
    {
        return _context.Articulos.ToList();
    }

    public Articulo ObtenerArticuloPorId(int articuloId)
    {
        return _context.Articulos.FirstOrDefault(a => a.ARTICULO_ID.Equals(articuloId));
    }

    public Articulo IngresarArticulo(Articulo articulo)
    {
        _context.Articulos.Add(articulo);
        _context.SaveChanges();
        return articulo;
    }

    public void ModificarArticulo(Articulo articulo)
    {
        _context.Articulos.Update(articulo);
        _context.SaveChanges();
    }

    List<Articulo> IArticuloRepository.ObtenerTodosArticulos()
    {
        throw new NotImplementedException();
    }
}

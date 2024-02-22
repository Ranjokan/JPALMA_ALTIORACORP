using System.Collections.Generic;
using System.Linq;


public class ArticuloRepository : IArticuloRepository
{
    private readonly AppDbContext _context;

    public ArticuloRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Articulo> ObtenerTodosArticulos()
    {
        try
        {
            return _context.Articulo.ToList();
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener todos los articulos.", ex);
        }

    }

    public Articulo ObtenerArticuloPorCodigo(string codigoArticulo)
    {
        try
        {
            return _context.Articulo.FirstOrDefault(a => a.CODIGO_ARTICULO.Equals(codigoArticulo));
        }
        catch (Exception ex)
        {
            throw new Exception("Error al obtener el articulo por ID.", ex);
        }

    }

    public Articulo IngresarArticulo(Articulo articulo)
    {
        try
        {
            if (_context.Articulo.Any(c => c.CODIGO_ARTICULO.Equals(articulo.CODIGO_ARTICULO)))
            {
                throw new InvalidOperationException("Ya existe un articulo con ese Codigo.");
            }
            _context.Articulo.Add(articulo);
            _context.SaveChanges();
            return articulo;
        }
        catch (System.Exception)
        {

            throw;
        }

    }

    public Articulo ModificarArticulo(string codigoArticulo, Articulo articulo)
    {
        try
        {
            var articuloExistente = _context.Articulo.FirstOrDefault(c => c.CODIGO_ARTICULO.Equals(codigoArticulo));
            if (articuloExistente != null)
            {
                _context.Articulo.Update(articulo);
                _context.SaveChanges();
            }

            return articulo;
        }
        catch (Exception ex)
        {

            throw new Exception("Error al modificar el articulo.", ex);
        }

    }

}

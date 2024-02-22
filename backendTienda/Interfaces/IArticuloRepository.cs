public interface IArticuloRepository
{
    List<Articulo> ObtenerTodosArticulos();
    Articulo ObtenerArticuloPorCodigo (string idArticulo);
    Articulo IngresarArticulo(Articulo articulo);
    Articulo ModificarArticulo(string idArticulo, Articulo articulo);
   
}
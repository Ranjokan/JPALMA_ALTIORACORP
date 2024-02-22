public interface IArticuloRepository
{
    List<Articulo> ObtenerTodosArticulos();
    Articulo ObtenerArticuloPorId(int articuloId);
    Articulo IngresarArticulo(Articulo articulo);
    void ModificarArticulo(Articulo articulo);
   
}
using Microsoft.AspNetCore.Mvc;

public interface IArticuloController
{
    IActionResult IngresarArticulo(ArticuloViewModel articuloViewModel);
    IActionResult ModificarCliente(string codigoArticulo, ArticuloViewModel articuloViewModel);
  
}
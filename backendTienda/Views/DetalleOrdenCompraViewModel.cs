using System.ComponentModel.DataAnnotations;

public class DetalleOrdenCompraViewModel
{
    [Required(ErrorMessage = "El campo OrdenCompraId es obligatorio")]
    public int OrdenCompraId { get; set; }

    [Required(ErrorMessage = "Al menos un artículo es obligatorio")]
    public List<int> ArticuloIds { get; set; }
}
using System.ComponentModel.DataAnnotations;

public class OrdenCompraViewModel
{
    [Required(ErrorMessage = "El campo ClienteId es obligatorio")]
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "Al menos un artículo es obligatorio en el detalle")]
    public int DetalleOrdenCompra { get; set; }
}
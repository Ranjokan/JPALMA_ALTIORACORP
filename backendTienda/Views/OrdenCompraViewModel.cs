using System.ComponentModel.DataAnnotations;

public class OrdenCompraViewModel
{
    [Required(ErrorMessage = "El campo ClienteId es obligatorio")]
    public int Cliente_Id { get; set; }

    public DateTime Fecha_Compra { get; set; }

    [Required(ErrorMessage = "Al menos un artículo es obligatorio en el detalle")]
    public int Detalle_Orden_Compra { get; set; }
}
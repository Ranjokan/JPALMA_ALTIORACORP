using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class DetalleOrdenDeCompra
{
    [Key]
    public int DETALLE_ID { get; set; }

    [ForeignKey("OrdenDeCompra")]
    public required int ORDEN_ID { get; set; }

    [ForeignKey("Articulo")]
    public required int ARTICULO_ID { get; set; }

    public required int CANTIDAD { get; set; }

    
    public virtual required OrdenCompra OrdenDeCompra { get; set; }
    public virtual required Articulo Articulo { get; set; }
}

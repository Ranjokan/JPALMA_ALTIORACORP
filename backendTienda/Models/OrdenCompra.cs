using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrdenCompra
{
    [Key]
    public int ORDEN_ID { get; set; }

    [ForeignKey("Cliente")]
    public required int CLIENTE_ID { get; set; }

    public required DateTime FECHA_COMPRA { get; set; }

    public virtual required Cliente Cliente { get; set; }
}
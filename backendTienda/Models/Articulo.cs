using System.ComponentModel.DataAnnotations;

public class Articulo
{
    [Key]
    public int ARTICULO_ID { get; set; }

    public required string CODIGO_ARTICULO { get; set; }
    public required string NOMBRE_ARTICULO { get; set; }
    public required string CATEGORIA { get; set; }
    public required decimal PRECIO_UNITARIO { get; set; }
}
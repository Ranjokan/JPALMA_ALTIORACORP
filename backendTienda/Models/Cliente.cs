using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cliente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CLIENTE_ID { get; set; }
    public required string NOMBRE { get; set; }
    public required string APELLIDO { get; set; }
    public required string DNI { get; set; }
    public ICollection<OrdenCompra> OrdenCompra { get => ordenCompra; set => ordenCompra = value; }

    private ICollection<OrdenCompra> ordenCompra;

    public virtual ICollection<OrdenCompra> GetOrdenCompra()
    {
        return OrdenCompra;
    }

    public virtual void SetOrdenCompra(ICollection<OrdenCompra> value)
    {
        OrdenCompra = value;
    }
}

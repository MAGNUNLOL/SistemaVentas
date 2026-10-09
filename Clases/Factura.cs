namespace SistemaVentas.Clases;

public class Factura
{
    public int Id { get; set; }
    public int VentaId { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string Cliente { get; set; } = "";
    public decimal Total { get; set; }
    public bool Anulada { get; set; }
}

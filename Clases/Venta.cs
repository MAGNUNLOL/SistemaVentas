namespace SistemaVentas.Clases;

public class Venta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; } = DateTime.Now;
    public int ClienteId { get; set; }          // 0 = consumidor final
    public string Cliente { get; set; } = "";
    public int VendedorId { get; set; }
    public string Vendedor { get; set; } = "";
    public decimal Descuento { get; set; }      // porcentaje (10 = 10 %)
    public decimal Total { get; set; }
    public string MetodoPago { get; set; } = "";
    public bool Cancelada { get; set; }
    public List<DetalleVenta> Detalles { get; set; } = new();
}

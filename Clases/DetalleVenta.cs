namespace SistemaVentas.Clases;

public class DetalleVenta
{
    public int ProductoId { get; set; }
    public string Producto { get; set; } = "";
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal Subtotal => Cantidad * Precio;
}

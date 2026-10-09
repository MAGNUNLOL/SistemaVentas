namespace SistemaVentas.Clases;

public class Vendedor
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";

    // Porcentaje de comisión (5 significa 5 %)
    public decimal Comision { get; set; }
}

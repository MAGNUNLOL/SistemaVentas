using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmReportes : Form
{
    public FrmReportes()
    {
        InitializeComponent();
        dtpDesde.Value = DateTime.Today.AddDays(-30);
        dtpHasta.Value = DateTime.Today;
        Generar();
    }

    void btnGenerar_Click(object sender, EventArgs e)
    {
        Generar();
    }

    void Generar()
    {
        DateTime desde = dtpDesde.Value.Date;
        DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);
        if (desde > hasta)
        {
            UiHelper.Aviso("La fecha inicial no puede ser mayor que la final.");
            return;
        }

        // Solo cuentan las ventas que no están canceladas
        var ventas = Repositorio.Ventas
            .Where(v => !v.Cancelada && v.Fecha >= desde && v.Fecha <= hasta)
            .OrderBy(v => v.Fecha)
            .ToList();

        lblResumen.Text = $"Ventas: {ventas.Count}     Ingresos: {UiHelper.Moneda(ventas.Sum(v => v.Total))}";

        dgvVentas.DataSource = ventas
            .Select(v => new { v.Id, Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"), v.Cliente, v.Vendedor, v.Total })
            .ToList();
        UiHelper.Formato(dgvVentas, UiHelper.FormatoQ, "Total");
        dgvVentas.ClearSelection();

        dgvProductos.DataSource = ventas
            .SelectMany(v => v.Detalles)
            .GroupBy(d => d.Producto)
            .Select(g => new { Producto = g.Key, Cantidad = g.Sum(d => d.Cantidad), Vendido = g.Sum(d => d.Subtotal) })
            .OrderByDescending(x => x.Cantidad)
            .ToList();
        UiHelper.Formato(dgvProductos, UiHelper.FormatoQ, "Vendido");
        UiHelper.Encabezados(dgvProductos, ("Vendido", "Total vendido"));
        dgvProductos.ClearSelection();
    }
}

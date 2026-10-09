using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmFacturas : Form
{
    public FrmFacturas()
    {
        InitializeComponent();
        Actualizar();
    }

    void Actualizar()
    {
        dgv.DataSource = Repositorio.Facturas
            .OrderByDescending(f => f.Id)
            .Select(f => new
            {
                f.Id,
                Venta = f.VentaId,
                Fecha = f.Fecha.ToString("dd/MM/yyyy HH:mm"),
                f.Cliente,
                f.Total,
                Estado = f.Anulada ? "Anulada" : "Vigente"
            })
            .ToList();
        UiHelper.Formato(dgv, UiHelper.FormatoQ, "Total");
        dgv.ClearSelection();
    }

    // Devuelve el Id de la factura seleccionada (0 si no hay)
    int FacturaSeleccionada()
    {
        if (dgv.SelectedRows.Count == 0)
        {
            UiHelper.Aviso("Haga clic en una factura de la tabla.");
            return 0;
        }
        return Convert.ToInt32(dgv.SelectedRows[0].Cells["Id"].Value);
    }

    void btnDetalle_Click(object sender, EventArgs e)
    {
        int id = FacturaSeleccionada();
        if (id == 0) return;

        var factura = Repositorio.Facturas.FirstOrDefault(f => f.Id == id);
        var venta = factura == null ? null : Repositorio.Ventas.FirstOrDefault(v => v.Id == factura.VentaId);
        if (venta == null) return;

        string lineas = string.Join("\n", venta.Detalles.Select(d => $"{d.Cantidad} x {d.Producto}   {UiHelper.Moneda(d.Subtotal)}"));
        UiHelper.Info($"Factura #{factura.Id}  (Venta #{venta.Id})\nCliente: {venta.Cliente}\nVendedor: {venta.Vendedor}\n" +
                      $"Pago: {venta.MetodoPago}\n\n{lineas}\n\nDescuento: {venta.Descuento:0.##} %\nTotal: {UiHelper.Moneda(venta.Total)}");
    }

    void btnAnular_Click(object sender, EventArgs e)
    {
        int id = FacturaSeleccionada();
        if (id == 0) return;

        var factura = Repositorio.Facturas.FirstOrDefault(f => f.Id == id);
        if (factura == null) return;

        if (factura.Anulada)
        {
            UiHelper.Aviso("Esa factura ya está anulada.");
            return;
        }
        if (!UiHelper.Confirmar($"¿Anular la factura #{factura.Id}? La venta también quedará cancelada.")) return;

        factura.Anulada = true;
        var venta = Repositorio.Ventas.FirstOrDefault(v => v.Id == factura.VentaId);
        if (venta != null) venta.Cancelada = true;

        if (!Repositorio.Guardar()) return;
        Actualizar();
    }
}

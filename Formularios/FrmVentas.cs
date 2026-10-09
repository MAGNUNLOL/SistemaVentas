using SistemaVentas.Clases;
using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmVentas : Form
{
    // Productos de la venta que se está preparando
    List<DetalleVenta> detalle = new();

    public FrmVentas()
    {
        InitializeComponent();
        CargarListas();
        cboPago.SelectedIndex = 0;
        ActualizarDetalle();
        ActualizarVentas();
    }

    // Llena las listas desplegables con los datos guardados
    void CargarListas()
    {
        var clientes = new List<ItemLista> { new ItemLista(0, "Consumidor final") };
        clientes.AddRange(Repositorio.Clientes.OrderBy(c => c.Nombre).Select(c => new ItemLista(c.Id, c.Nombre)));
        UiHelper.LlenarCombo(cboCliente, clientes);

        UiHelper.LlenarCombo(cboVendedor,
            Repositorio.Vendedores.OrderBy(v => v.Nombre).Select(v => new ItemLista(v.Id, v.Nombre)).ToList());

        UiHelper.LlenarCombo(cboProducto,
            Repositorio.Productos.Where(p => p.Disponible).OrderBy(p => p.Nombre)
                .Select(p => new ItemLista(p.Id, $"{p.Nombre}  -  {UiHelper.Moneda(p.Precio)}")).ToList());
    }

    void ActualizarDetalle()
    {
        dgvDetalle.DataSource = null;
        dgvDetalle.DataSource = detalle.ToList();
        if (dgvDetalle.Columns.Contains("ProductoId")) dgvDetalle.Columns["ProductoId"].Visible = false;
        UiHelper.Formato(dgvDetalle, UiHelper.FormatoQ, "Precio", "Subtotal");
        dgvDetalle.ClearSelection();
        CalcularTotales();
    }

    void ActualizarVentas()
    {
        dgvVentas.DataSource = Repositorio.Ventas
            .OrderByDescending(v => v.Id)
            .Select(v => new
            {
                v.Id,
                Fecha = v.Fecha.ToString("dd/MM/yyyy HH:mm"),
                v.Cliente,
                v.Vendedor,
                Pago = v.MetodoPago,
                Descuento = v.Descuento.ToString("0.##") + " %",
                v.Total,
                Estado = v.Cancelada ? "Cancelada" : "Activa"
            })
            .ToList();
        UiHelper.Formato(dgvVentas, UiHelper.FormatoQ, "Total");
        dgvVentas.ClearSelection();
    }

    // Porcentaje de descuento escrito (0 si está vacío o inválido)
    decimal LeerDescuento()
    {
        if (UiHelper.TryDecimal(txtDescuento.Text, out decimal d) && d >= 0 && d <= 100) return d;
        return 0;
    }

    void CalcularTotales()
    {
        decimal subtotal = detalle.Sum(d => d.Subtotal);
        decimal descuento = subtotal * LeerDescuento() / 100;
        lblSubtotal.Text = $"Subtotal: {UiHelper.Moneda(subtotal)}";
        lblDescuentoMonto.Text = $"Descuento: -{UiHelper.Moneda(descuento)}";
        lblTotal.Text = $"Total: {UiHelper.Moneda(subtotal - descuento)}";
    }

    void btnAgregar_Click(object sender, EventArgs e)
    {
        if (cboProducto.SelectedValue is not int idProducto)
        {
            UiHelper.Aviso("Seleccione un producto. Si no hay, regístrelo (disponible) en el módulo Productos.");
            return;
        }
        var prod = Repositorio.Productos.FirstOrDefault(p => p.Id == idProducto);
        if (prod == null) return;

        int cantidad = (int)nudCantidad.Value;
        var existente = detalle.FirstOrDefault(d => d.ProductoId == prod.Id);
        if (existente != null)
            existente.Cantidad += cantidad;
        else
            detalle.Add(new DetalleVenta { ProductoId = prod.Id, Producto = prod.Nombre, Cantidad = cantidad, Precio = prod.Precio });

        nudCantidad.Value = 1;
        ActualizarDetalle();
    }

    void btnQuitar_Click(object sender, EventArgs e)
    {
        if (dgvDetalle.SelectedRows.Count == 0)
        {
            UiHelper.Aviso("Haga clic en una fila de la lista para quitarla.");
            return;
        }
        detalle.RemoveAt(dgvDetalle.SelectedRows[0].Index);
        ActualizarDetalle();
    }

    void txtDescuento_TextChanged(object sender, EventArgs e)
    {
        CalcularTotales();
    }

    void btnRegistrar_Click(object sender, EventArgs e)
    {
        if (detalle.Count == 0)
        {
            UiHelper.Aviso("Agregue al menos un producto a la venta.");
            return;
        }
        if (cboVendedor.SelectedValue is not int vendedorId)
        {
            UiHelper.Aviso("Seleccione un vendedor. Si no hay, regístrelo en el módulo Vendedores.");
            return;
        }
        if (txtDescuento.Text.Trim() != "" && (!UiHelper.TryDecimal(txtDescuento.Text, out decimal d) || d < 0 || d > 100))
        {
            UiHelper.Aviso("El descuento debe ser un número entre 0 y 100.");
            txtDescuento.Focus();
            return;
        }

        int clienteId = cboCliente.SelectedValue is int c ? c : 0;
        decimal descuento = LeerDescuento();
        decimal subtotal = detalle.Sum(x => x.Subtotal);

        var venta = new Venta
        {
            Id = Repositorio.NuevoId(Repositorio.Ventas.Select(v => v.Id)),
            Fecha = DateTime.Now,
            ClienteId = clienteId,
            Cliente = cboCliente.Text,
            VendedorId = vendedorId,
            Vendedor = cboVendedor.Text,
            Descuento = descuento,
            Total = subtotal - subtotal * descuento / 100,
            MetodoPago = cboPago.Text,
            Detalles = detalle
        };

        // Cada venta genera su factura automáticamente
        var factura = new Factura
        {
            Id = Repositorio.NuevoId(Repositorio.Facturas.Select(f => f.Id)),
            VentaId = venta.Id,
            Fecha = venta.Fecha,
            Cliente = venta.Cliente,
            Total = venta.Total
        };

        Repositorio.Ventas.Add(venta);
        Repositorio.Facturas.Add(factura);

        if (!Repositorio.Guardar())
        {
            Repositorio.Ventas.Remove(venta);
            Repositorio.Facturas.Remove(factura);
            return;
        }

        detalle = new List<DetalleVenta>();
        txtDescuento.Text = "0";
        ActualizarDetalle();
        ActualizarVentas();
        UiHelper.Info($"Venta #{venta.Id} registrada.\nFactura #{factura.Id} generada.\nTotal: {UiHelper.Moneda(venta.Total)}");
    }

    void btnCancelarVenta_Click(object sender, EventArgs e)
    {
        if (dgvVentas.SelectedRows.Count == 0)
        {
            UiHelper.Aviso("Haga clic en una venta de la tabla para cancelarla.");
            return;
        }
        int id = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["Id"].Value);
        var venta = Repositorio.Ventas.FirstOrDefault(v => v.Id == id);
        if (venta == null) return;

        if (venta.Cancelada)
        {
            UiHelper.Aviso("Esa venta ya está cancelada.");
            return;
        }
        if (!UiHelper.Confirmar($"¿Cancelar la venta #{venta.Id}? También se anulará su factura.")) return;

        venta.Cancelada = true;
        foreach (var f in Repositorio.Facturas.Where(f => f.VentaId == venta.Id)) f.Anulada = true;

        if (!Repositorio.Guardar()) return;
        ActualizarVentas();
    }
}

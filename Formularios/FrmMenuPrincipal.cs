using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmMenuPrincipal : Form
{
    public FrmMenuPrincipal()
    {
        InitializeComponent();
        lblRuta.Text = "Datos guardados en: " + Repositorio.Carpeta;
        ActualizarResumen();

        if (Repositorio.ErroresCarga.Count > 0)
        {
            UiHelper.Aviso("Un archivo de datos está dañado. Mientras tanto no se podrá guardar, " +
                "para proteger la información.\n\n" + string.Join("\n", Repositorio.ErroresCarga));
        }
    }

    void ActualizarResumen()
    {
        lblResumen.Text = $"Productos: {Repositorio.Productos.Count}   Clientes: {Repositorio.Clientes.Count}   " +
                          $"Vendedores: {Repositorio.Vendedores.Count}   Ventas: {Repositorio.Ventas.Count}";
    }

    // Abre un formulario y, al cerrarlo, actualiza el resumen
    void Abrir(Form formulario)
    {
        using (formulario) formulario.ShowDialog();
        ActualizarResumen();
    }

    void btnProductos_Click(object sender, EventArgs e) => Abrir(new FrmProductos());
    void btnClientes_Click(object sender, EventArgs e) => Abrir(new FrmClientes());
    void btnVendedores_Click(object sender, EventArgs e) => Abrir(new FrmVendedores());
    void btnVentas_Click(object sender, EventArgs e) => Abrir(new FrmVentas());
    void btnFacturas_Click(object sender, EventArgs e) => Abrir(new FrmFacturas());
    void btnReportes_Click(object sender, EventArgs e) => Abrir(new FrmReportes());
    void btnSalir_Click(object sender, EventArgs e) => Close();
}

using SistemaVentas.Clases;
using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmVendedores : Form
{
    public FrmVendedores()
    {
        InitializeComponent();
        Actualizar();
    }

    // La tabla muestra también el desempeño: ventas, total vendido y comisión ganada
    void Actualizar()
    {
        string filtro = txtBuscar.Text.Trim().ToLower();

        dgv.DataSource = Repositorio.Vendedores
            .Where(v => filtro == "" || v.Nombre.ToLower().Contains(filtro))
            .OrderBy(v => v.Id)
            .Select(v => new
            {
                v.Id,
                v.Nombre,
                Porcentaje = v.Comision.ToString("0.##") + " %",
                Ventas = Repositorio.Ventas.Count(x => x.VendedorId == v.Id && !x.Cancelada),
                Vendido = Repositorio.Ventas.Where(x => x.VendedorId == v.Id && !x.Cancelada).Sum(x => x.Total),
                Ganada = Repositorio.Ventas.Where(x => x.VendedorId == v.Id && !x.Cancelada).Sum(x => x.Total) * v.Comision / 100
            })
            .ToList();

        UiHelper.Formato(dgv, UiHelper.FormatoQ, "Vendido", "Ganada");
        UiHelper.Encabezados(dgv, ("Porcentaje", "Comisión"), ("Vendido", "Total vendido"), ("Ganada", "Comisión ganada"));
        dgv.ClearSelection();
    }

    void Limpiar()
    {
        txtId.Clear();
        txtNombre.Clear();
        txtComision.Clear();
        txtNombre.Focus();
    }

    void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        if (nombre == "")
        {
            UiHelper.Aviso("Escriba el nombre del vendedor.");
            txtNombre.Focus();
            return;
        }
        if (!UiHelper.TryDecimal(txtComision.Text, out decimal comision) || comision < 0 || comision > 100)
        {
            UiHelper.Aviso("La comisión debe ser un número entre 0 y 100.");
            txtComision.Focus();
            return;
        }

        bool esNuevo = txtId.Text == "";
        Vendedor v;
        if (esNuevo)
        {
            v = new Vendedor { Id = Repositorio.NuevoId(Repositorio.Vendedores.Select(x => x.Id)) };
            Repositorio.Vendedores.Add(v);
        }
        else
        {
            int id = int.Parse(txtId.Text);
            v = Repositorio.Vendedores.FirstOrDefault(x => x.Id == id);
            if (v == null)
            {
                UiHelper.Aviso("Ese vendedor ya no existe.");
                Limpiar();
                Actualizar();
                return;
            }
        }

        v.Nombre = nombre;
        v.Comision = comision;

        if (!Repositorio.Guardar()) return;

        Limpiar();
        Actualizar();
        UiHelper.Info(esNuevo ? "Vendedor guardado correctamente." : "Vendedor actualizado correctamente.");
    }

    void btnNuevo_Click(object sender, EventArgs e)
    {
        Limpiar();
        dgv.ClearSelection();
    }

    void btnEliminar_Click(object sender, EventArgs e)
    {
        if (txtId.Text == "")
        {
            UiHelper.Aviso("Haga clic en un vendedor de la tabla para eliminarlo.");
            return;
        }
        int id = int.Parse(txtId.Text);
        var v = Repositorio.Vendedores.FirstOrDefault(x => x.Id == id);
        if (v == null) return;

        if (!UiHelper.Confirmar($"¿Eliminar al vendedor \"{v.Nombre}\"?")) return;

        Repositorio.Vendedores.Remove(v);
        if (!Repositorio.Guardar()) return;

        Limpiar();
        Actualizar();
    }

    void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
        var v = Repositorio.Vendedores.FirstOrDefault(x => x.Id == id);
        if (v == null) return;

        txtId.Text = v.Id.ToString();
        txtNombre.Text = v.Nombre;
        txtComision.Text = v.Comision.ToString("0.##");
    }

    void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        Actualizar();
    }
}

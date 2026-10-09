using SistemaVentas.Clases;
using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmClientes : Form
{
    public FrmClientes()
    {
        InitializeComponent();
        Actualizar();
    }

    void Actualizar()
    {
        string filtro = txtBuscar.Text.Trim().ToLower();

        dgv.DataSource = Repositorio.Clientes
            .Where(c => filtro == "" || c.Nombre.ToLower().Contains(filtro)
                     || c.Telefono.ToLower().Contains(filtro) || c.Email.ToLower().Contains(filtro))
            .OrderBy(c => c.Id)
            .Select(c => new
            {
                c.Id,
                c.Nombre,
                c.Telefono,
                c.Email,
                Compras = Repositorio.Ventas.Count(v => v.ClienteId == c.Id && !v.Cancelada),
                Total = Repositorio.Ventas.Where(v => v.ClienteId == c.Id && !v.Cancelada).Sum(v => v.Total)
            })
            .ToList();

        UiHelper.Formato(dgv, UiHelper.FormatoQ, "Total");
        UiHelper.Encabezados(dgv, ("Telefono", "Teléfono"), ("Total", "Total comprado"));
        dgv.ClearSelection();
    }

    void Limpiar()
    {
        txtId.Clear();
        txtNombre.Clear();
        txtTelefono.Clear();
        txtEmail.Clear();
        txtNombre.Focus();
    }

    void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        string email = txtEmail.Text.Trim();

        if (nombre == "")
        {
            UiHelper.Aviso("Escriba el nombre del cliente.");
            txtNombre.Focus();
            return;
        }
        if (email != "" && !email.Contains("@"))
        {
            UiHelper.Aviso("El correo electrónico no es válido.");
            txtEmail.Focus();
            return;
        }

        bool esNuevo = txtId.Text == "";
        Cliente c;
        if (esNuevo)
        {
            c = new Cliente { Id = Repositorio.NuevoId(Repositorio.Clientes.Select(x => x.Id)) };
            Repositorio.Clientes.Add(c);
        }
        else
        {
            int id = int.Parse(txtId.Text);
            c = Repositorio.Clientes.FirstOrDefault(x => x.Id == id);
            if (c == null)
            {
                UiHelper.Aviso("Ese cliente ya no existe.");
                Limpiar();
                Actualizar();
                return;
            }
        }

        c.Nombre = nombre;
        c.Telefono = txtTelefono.Text.Trim();
        c.Email = email;

        if (!Repositorio.Guardar()) return;

        Limpiar();
        Actualizar();
        UiHelper.Info(esNuevo ? "Cliente guardado correctamente." : "Cliente actualizado correctamente.");
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
            UiHelper.Aviso("Haga clic en un cliente de la tabla para eliminarlo.");
            return;
        }
        int id = int.Parse(txtId.Text);
        var c = Repositorio.Clientes.FirstOrDefault(x => x.Id == id);
        if (c == null) return;

        if (!UiHelper.Confirmar($"¿Eliminar al cliente \"{c.Nombre}\"?")) return;

        Repositorio.Clientes.Remove(c);
        if (!Repositorio.Guardar()) return;

        Limpiar();
        Actualizar();
    }

    void btnHistorial_Click(object sender, EventArgs e)
    {
        if (txtId.Text == "")
        {
            UiHelper.Aviso("Haga clic en un cliente de la tabla para ver su historial.");
            return;
        }
        int id = int.Parse(txtId.Text);
        var compras = Repositorio.Ventas.Where(v => v.ClienteId == id).OrderByDescending(v => v.Fecha).ToList();

        if (compras.Count == 0)
        {
            UiHelper.Info("Este cliente todavía no tiene compras.");
            return;
        }

        string lineas = string.Join("\n", compras.Take(15).Select(v =>
            $"Venta #{v.Id}   {v.Fecha:dd/MM/yyyy}   {UiHelper.Moneda(v.Total)}" + (v.Cancelada ? "   (cancelada)" : "")));
        UiHelper.Info($"Historial de {txtNombre.Text}:\n\n{lineas}");
    }

    void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
        var c = Repositorio.Clientes.FirstOrDefault(x => x.Id == id);
        if (c == null) return;

        txtId.Text = c.Id.ToString();
        txtNombre.Text = c.Nombre;
        txtTelefono.Text = c.Telefono;
        txtEmail.Text = c.Email;
    }

    void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        Actualizar();
    }
}

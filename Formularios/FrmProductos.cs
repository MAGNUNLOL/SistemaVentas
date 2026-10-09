using SistemaVentas.Clases;
using SistemaVentas.Datos;

namespace SistemaVentas.Formularios;

public partial class FrmProductos : Form
{
    public FrmProductos()
    {
        InitializeComponent();
        Actualizar();
    }

    // Muestra los productos en la tabla (respeta lo escrito en el buscador)
    void Actualizar()
    {
        string filtro = txtBuscar.Text.Trim().ToLower();

        dgv.DataSource = Repositorio.Productos
            .Where(p => filtro == "" || p.Nombre.ToLower().Contains(filtro) || p.Categoria.ToLower().Contains(filtro))
            .OrderBy(p => p.Id)
            .Select(p => new { p.Id, p.Nombre, p.Categoria, p.Precio, Disponible = p.Disponible ? "Sí" : "No" })
            .ToList();

        UiHelper.Formato(dgv, UiHelper.FormatoQ, "Precio");
        UiHelper.Encabezados(dgv, ("Categoria", "Categoría"));
        dgv.ClearSelection();

        // Categorías que ya existen, para elegirlas en la lista
        string actual = cboCategoria.Text;
        cboCategoria.Items.Clear();
        cboCategoria.Items.AddRange(Repositorio.Productos
            .Select(p => p.Categoria).Where(c => c != "").Distinct().OrderBy(c => c).ToArray());
        cboCategoria.Text = actual;
    }

    void Limpiar()
    {
        txtId.Clear();
        txtNombre.Clear();
        cboCategoria.Text = "";
        txtPrecio.Clear();
        chkDisponible.Checked = true;
        txtNombre.Focus();
    }

    void btnGuardar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text.Trim();
        if (nombre == "")
        {
            UiHelper.Aviso("Escriba el nombre del producto.");
            txtNombre.Focus();
            return;
        }
        if (!UiHelper.TryDecimal(txtPrecio.Text, out decimal precio) || precio <= 0)
        {
            UiHelper.Aviso("El precio debe ser un número mayor que 0.");
            txtPrecio.Focus();
            return;
        }

        bool esNuevo = txtId.Text == "";
        Producto p;
        if (esNuevo)
        {
            p = new Producto { Id = Repositorio.NuevoId(Repositorio.Productos.Select(x => x.Id)) };
            Repositorio.Productos.Add(p);
        }
        else
        {
            int id = int.Parse(txtId.Text);
            p = Repositorio.Productos.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                UiHelper.Aviso("Ese producto ya no existe.");
                Limpiar();
                Actualizar();
                return;
            }
        }

        p.Nombre = nombre;
        p.Categoria = cboCategoria.Text.Trim();
        p.Precio = precio;
        p.Disponible = chkDisponible.Checked;

        if (!Repositorio.Guardar()) return;

        Limpiar();
        Actualizar();
        UiHelper.Info(esNuevo ? "Producto guardado correctamente." : "Producto actualizado correctamente.");
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
            UiHelper.Aviso("Haga clic en un producto de la tabla para eliminarlo.");
            return;
        }
        int id = int.Parse(txtId.Text);
        var p = Repositorio.Productos.FirstOrDefault(x => x.Id == id);
        if (p == null) return;

        if (!UiHelper.Confirmar($"¿Eliminar el producto \"{p.Nombre}\"?")) return;

        Repositorio.Productos.Remove(p);
        if (!Repositorio.Guardar()) return;

        Limpiar();
        Actualizar();
    }

    // Al hacer clic en una fila, se cargan sus datos para editarlos
    void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        int id = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["Id"].Value);
        var p = Repositorio.Productos.FirstOrDefault(x => x.Id == id);
        if (p == null) return;

        txtId.Text = p.Id.ToString();
        txtNombre.Text = p.Nombre;
        cboCategoria.Text = p.Categoria;
        txtPrecio.Text = p.Precio.ToString("0.00");
        chkDisponible.Checked = p.Disponible;
    }

    void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        Actualizar();
    }
}

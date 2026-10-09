using System.Globalization;

namespace SistemaVentas.Formularios;

/// <summary>Elemento para llenar listas desplegables (Id + texto visible).</summary>
internal record ItemLista(int Id, string Texto);

/// <summary>Funciones pequeñas que usan varios formularios.</summary>
internal static class UiHelper
{
    public static void Info(string mensaje)
    {
        MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void Aviso(string mensaje)
    {
        MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    public static bool Confirmar(string mensaje)
    {
        return MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    /// <summary>Formato de quetzales para las tablas: Q1,250.00</summary>
    public const string FormatoQ = "\"Q\"#,##0.00";

    /// <summary>Texto de un monto en quetzales: Q1,250.00</summary>
    public static string Moneda(decimal valor)
    {
        return "Q" + valor.ToString("N2", CultureInfo.InvariantCulture);
    }

    /// <summary>Convierte texto a decimal aceptando punto o coma decimal.</summary>
    public static bool TryDecimal(string texto, out decimal valor)
    {
        texto = (texto ?? "").Trim().Replace(',', '.');
        return decimal.TryParse(texto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out valor);
    }

    /// <summary>Llena un ComboBox con una lista de ItemLista.</summary>
    public static void LlenarCombo(ComboBox combo, List<ItemLista> items)
    {
        combo.DisplayMember = "Texto";
        combo.ValueMember = "Id";
        combo.DataSource = items;
        if (items.Count > 0) combo.SelectedIndex = 0;
    }

    /// <summary>Cambia el título de columnas: ("Telefono", "Teléfono"), ...</summary>
    public static void Encabezados(DataGridView grid, params (string columna, string texto)[] pares)
    {
        foreach (var par in pares)
            if (grid.Columns.Contains(par.columna)) grid.Columns[par.columna].HeaderText = par.texto;
    }

    /// <summary>Da formato de quetzales (FormatoQ) a las columnas indicadas.</summary>
    public static void Formato(DataGridView grid, string formato, params string[] columnas)
    {
        foreach (string c in columnas)
            if (grid.Columns.Contains(c)) grid.Columns[c].DefaultCellStyle.Format = formato;
    }
}

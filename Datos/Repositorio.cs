using System.Text.Json;
using SistemaVentas.Clases;

namespace SistemaVentas.Datos;

/// <summary>
/// Guarda y carga todos los datos en archivos JSON.
/// Carpeta: Documentos\SistemaVentas_Grupo3
/// </summary>
public static class Repositorio
{
    public static readonly string Carpeta = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SistemaVentas_Grupo3");

    static readonly JsonSerializerOptions Opciones = new() { WriteIndented = true };

    // Archivos que no se pudieron leer. Si hay alguno, no se guarda nada
    // para no sobrescribir los datos originales.
    public static List<string> ErroresCarga { get; } = new();

    public static List<Producto> Productos { get; private set; } = new();
    public static List<Cliente> Clientes { get; private set; } = new();
    public static List<Vendedor> Vendedores { get; private set; } = new();
    public static List<Venta> Ventas { get; private set; } = new();
    public static List<Factura> Facturas { get; private set; } = new();

    // Se ejecuta una sola vez: carga los datos guardados
    static Repositorio()
    {
        try { Directory.CreateDirectory(Carpeta); } catch { }

        Productos = Leer<Producto>("productos.json");
        Clientes = Leer<Cliente>("clientes.json");
        Vendedores = Leer<Vendedor>("vendedores.json");
        Ventas = Leer<Venta>("ventas.json");
        Facturas = Leer<Factura>("facturas.json");
    }

    /// <summary>Escribe todo en disco. Devuelve false (y avisa) si algo falla.</summary>
    public static bool Guardar()
    {
        if (ErroresCarga.Count > 0)
        {
            MessageBox.Show("No se guardó nada para proteger sus datos.\n\n" +
                "Hay archivos dañados:\n" + string.Join("\n", ErroresCarga) +
                "\n\nRestaure los archivos desde la copia .bak de la carpeta SistemaVentas_Grupo3 " +
                "o avise al administrador.",
                "Datos dañados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        try
        {
            Directory.CreateDirectory(Carpeta);
            Escribir("productos.json", Productos);
            Escribir("clientes.json", Clientes);
            Escribir("vendedores.json", Vendedores);
            Escribir("ventas.json", Ventas);
            Escribir("facturas.json", Facturas);
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se pudieron guardar los datos:\n" + ex.Message,
                "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    /// <summary>Devuelve el siguiente Id disponible (máximo + 1).</summary>
    public static int NuevoId(IEnumerable<int> ids)
    {
        return ids.Any() ? ids.Max() + 1 : 1;
    }

    static void Escribir<T>(string archivo, List<T> lista)
    {
        string ruta = Path.Combine(Carpeta, archivo);
        string temporal = ruta + ".tmp";

        // Primero se escribe a un archivo temporal; así un corte de luz no deja el archivo a medias
        File.WriteAllText(temporal, JsonSerializer.Serialize(lista, Opciones));

        // Copia de respaldo de la versión anterior
        if (File.Exists(ruta)) File.Copy(ruta, ruta + ".bak", true);

        File.Move(temporal, ruta, true);
    }

    static List<T> Leer<T>(string archivo)
    {
        string ruta = Path.Combine(Carpeta, archivo);
        if (!File.Exists(ruta)) return new List<T>();
        try
        {
            return JsonSerializer.Deserialize<List<T>>(File.ReadAllText(ruta)) ?? new List<T>();
        }
        catch (Exception ex)
        {
            ErroresCarga.Add($"{archivo}: {ex.Message}");
            return new List<T>();
        }
    }
}

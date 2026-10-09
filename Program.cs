using SistemaVentas.Formularios;

namespace SistemaVentas;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new FrmMenuPrincipal());
    }
}

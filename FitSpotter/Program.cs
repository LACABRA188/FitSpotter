namespace FitSpotter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AppData.CargarDatosIniciales();
            Application.Run(new V1LoginForm());
        }
    }
}


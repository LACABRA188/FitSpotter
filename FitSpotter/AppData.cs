using FitSpotter.Modelos.Clases;
using FitSpotter.Modelos.Comercial;
using FitSpotter.Modelos.Evaluaciones;
using FitSpotter.Modelos.Membresias;
using FitSpotter.Modelos.Personas;
using FitSpotter.Modelos.Rutinas;
using FitSpotter.Modelos.Sucursales;
namespace FitSpotter;

/// <summary>Repositorio temporal en memoria para la demostración de FitSpotter.</summary>
public static class AppData
{
    public static List<Socio> Socios { get; } = [];
    public static List<Entrenador> Entrenadores { get; } = [];
    public static List<Administrador> Administradores { get; } = [];
    public static List<Membresia> Membresias { get; } = [];
    public static List<Sucursal> Sucursales { get; } = [];
    public static List<ClaseGrupal> Clases { get; } = [];
    public static List<Suplemento> Suplementos { get; } = [];
    public static List<Pago> Pagos { get; } = [];
    public static List<Venta> Ventas { get; } = [];
    public static List<EvaluacionFisica> Evaluaciones { get; } = [];
    public static Persona? UsuarioActual { get; set; }
    public static long ProximoNroFactura { get; private set; } = 1001;
    public static long SiguienteFactura() => ProximoNroFactura++;

    public static void CargarDatosIniciales()
    {
        if (Socios.Count > 0) return;
        var mensual = new Membresia("Mensual", "Acceso libre a sala de musculación", 25000m, 30);
        var premium = new Membresia("Premium", "Sala, clases grupales y seguimiento", 42000m, 30);
        Membresias.AddRange([mensual, premium]);
        var sede = new Sucursal("FitSpotter Centro", "Av. Corrientes 1250", "11-5555-0100");
        sede.AgregarEquipo(new Equipamiento("Cinta profesional", EstadoEquipamiento.Operativo, DateTime.Today.AddDays(-20)));
        sede.AgregarEquipo(new Equipamiento("Bicicleta de spinning 04", EstadoEquipamiento.EnMantenimiento, DateTime.Today));
        Sucursales.Add(sede);
        var entrenador = new Entrenador("Lucía", "Martínez", "lucia@fitspotter.com", "11-5555-0101", "lmartinez", "entrena123", "E-101", "Musculación y funcional");
        var administrador = new Administrador("Martín", "Pérez", "martin@fitspotter.com", "11-5555-0102", "admin", "admin123", "Recepción", 10);
        Entrenadores.Add(entrenador); Administradores.Add(administrador);
        var cuentaSocio = new Usuario("Sofía", "Gómez", "sofia@email.com", "11-5555-0103", "sofia", "socio123", RolUsuario.Socio);
        var socio = new Socio(1, "Sofía", "Gómez", "sofia@email.com", "11-5555-0103", premium, cuentaSocio);
        Socios.Add(socio);
        var rutina = entrenador.AsignarRutina(socio, "Mejorar fuerza general", DateTime.Today, DateTime.Today.AddDays(30));
        rutina.AgregarEjercicio(new Ejercicio("Sentadilla", "Piernas", 4, 10, 35));
        rutina.AgregarEjercicio(new Ejercicio("Press de banca", "Pecho", 3, 12, 20));
        var clase = new ClaseGrupal("Spinning", DateTime.Today.AddDays(1).AddHours(18), 15, entrenador, sede);
        Clases.Add(clase); sede.Actividades.Add(clase); entrenador.ClasesAsignadas.Add(clase);
        Suplementos.AddRange([new Suplemento("Whey Protein", "NutriPro", "Proteína", 35000m, 20), new Suplemento("Creatina", "PowerLab", "Rendimiento", 22000m, 15)]);
        Evaluaciones.Add(new EvaluacionFisica(DateTime.Today.AddDays(-7), 62m, 1.65m, 24m, socio, entrenador));
    }
}

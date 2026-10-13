using FitSpotter.Modelos.Personas;
using FitSpotter.Modelos.Sucursales;
namespace FitSpotter.Modelos.Clases;
public class ClaseGrupal
{
    public string Nombre { get; set; }
    public DateTime HorarioInicio { get; set; }
    public int CupoMaximo { get; }
    public int CupoDisponible => CupoMaximo - SociosInscriptos.Count;
    public Entrenador Instructor { get; set; }
    public Sucursal Sede { get; set; }
    public List<Socio> SociosInscriptos { get; } = [];
    public Dictionary<Socio, bool> Asistencia { get; } = [];
    public ClaseGrupal(string nombre, DateTime horarioInicio, int cupoMaximo, Entrenador instructor, Sucursal sede) { Nombre = nombre; HorarioInicio = horarioInicio; CupoMaximo = cupoMaximo; Instructor = instructor; Sede = sede; }
    public bool VerificarCupo() => CupoDisponible > 0;
    public void ReservarCupo(Socio socio) { if (!VerificarCupo()) throw new InvalidOperationException("No hay cupos disponibles."); SociosInscriptos.Add(socio); }
    public void RegistrarAsistencia(Socio socio, bool presente) { if (!SociosInscriptos.Contains(socio)) throw new InvalidOperationException("El socio no está inscripto."); Asistencia[socio] = presente; }
    public override string ToString() => $"{Nombre} - {HorarioInicio:g}";
}

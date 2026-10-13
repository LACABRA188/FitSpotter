using FitSpotter.Modelos.Clases;
using FitSpotter.Modelos.Rutinas;
namespace FitSpotter.Modelos.Personas;
public class Entrenador : Usuario
{
    public string Especialidad { get; set; }
    public string Legajo { get; }
    public List<ClaseGrupal> ClasesAsignadas { get; } = [];
    public Entrenador(string nombre, string apellido, string email, string telefono, string usuario, string password, string legajo, string especialidad) : base(nombre, apellido, email, telefono, usuario, password, RolUsuario.Entrenador) => (Legajo, Especialidad) = (legajo, especialidad);
    public Rutina AsignarRutina(Socio socio, string objetivo, DateTime inicio, DateTime fin) { var rutina = new Rutina(inicio, fin, objetivo, this, socio); socio.Rutinas.Add(rutina); return rutina; }
    public void TomarAsistencia(ClaseGrupal clase, Socio socio, bool presente) => clase.RegistrarAsistencia(socio, presente);
}

using FitSpotter.Modelos.Clases;
using FitSpotter.Modelos.Membresias;
using FitSpotter.Modelos.Rutinas;
namespace FitSpotter.Modelos.Personas;
public enum EstadoCuota { AlDia, Pendiente, Vencida }
public class Socio : Persona
{
    public int NroSocio { get; }
    public EstadoCuota EstadoCuota { get; private set; }
    public Membresia MembresiaActual { get; private set; }
    public DateTime FechaVencimiento { get; private set; }
    public List<Rutina> Rutinas { get; } = [];
    public List<ClaseGrupal> ClasesReservadas { get; } = [];
    public Usuario CuentaUsuario { get; }
    public Socio(int nroSocio, string nombre, string apellido, string email, string telefono, Membresia membresia, Usuario cuentaUsuario) : base(nombre, apellido, email, telefono)
    { NroSocio = nroSocio; MembresiaActual = membresia; CuentaUsuario = cuentaUsuario; FechaVencimiento = DateTime.Today.AddDays(membresia.DuracionDias); EstadoCuota = EstadoCuota.Pendiente; }
    public void ReservarClase(ClaseGrupal clase) { if (ClasesReservadas.Contains(clase)) throw new InvalidOperationException("El socio ya está inscripto."); clase.ReservarCupo(this); ClasesReservadas.Add(clase); }
    public Rutina? VerRutinaActual() => Rutinas.OrderByDescending(r => r.FechaInicio).FirstOrDefault();
    public void PagarCuota() { EstadoCuota = EstadoCuota.AlDia; FechaVencimiento = DateTime.Today.AddDays(MembresiaActual.DuracionDias); }
    public void ActualizarMembresia(Membresia membresia) => MembresiaActual = membresia;
    public void ActualizarEstadoCuota() => EstadoCuota = DateTime.Today > FechaVencimiento ? EstadoCuota.Vencida : EstadoCuota;
    public override string ToString() => $"{NroSocio} - {NombreCompleto}";
}

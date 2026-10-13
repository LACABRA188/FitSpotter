using FitSpotter.Modelos.Personas;
namespace FitSpotter.Modelos.Rutinas;
public class Ejercicio
{
    public string Nombre { get; set; }
    public string GrupoMuscular { get; set; }
    public int Series { get; private set; }
    public int Repeticiones { get; private set; }
    public decimal PesoSugerido { get; private set; }
    public Ejercicio(string nombre, string grupoMuscular, int series, int repeticiones, decimal pesoSugerido) { Nombre = nombre; GrupoMuscular = grupoMuscular; ModificarParametros(series, repeticiones, pesoSugerido); }
    public void ModificarParametros(int series, int repeticiones, decimal pesoSugerido) { if (series <= 0 || repeticiones <= 0 || pesoSugerido < 0) throw new ArgumentOutOfRangeException(); (Series, Repeticiones, PesoSugerido) = (series, repeticiones, pesoSugerido); }
}
public class Rutina
{
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public string Objetivo { get; set; }
    public List<Ejercicio> Ejercicios { get; } = [];
    public Entrenador Profesor { get; }
    public Socio Socio { get; }
    public Rutina(DateTime fechaInicio, DateTime fechaFin, string objetivo, Entrenador profesor, Socio socio) => (FechaInicio, FechaFin, Objetivo, Profesor, Socio) = (fechaInicio, fechaFin, objetivo, profesor, socio);
    public void AgregarEjercicio(Ejercicio ejercicio) => Ejercicios.Add(ejercicio);
    public void QuitarEjercicio(Ejercicio ejercicio) => Ejercicios.Remove(ejercicio);
    public override string ToString() => $"{Objetivo} ({FechaInicio:d})";
}

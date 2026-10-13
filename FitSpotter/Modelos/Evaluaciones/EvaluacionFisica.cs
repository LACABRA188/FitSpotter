using FitSpotter.Modelos.Personas;
namespace FitSpotter.Modelos.Evaluaciones;
public class EvaluacionFisica
{
    public DateTime Fecha { get; }
    public decimal PesoKg { get; set; }
    public decimal AlturaMts { get; set; }
    public decimal PorcentajeGrasa { get; set; }
    public Socio Cliente { get; }
    public Entrenador Evaluador { get; }
    public EvaluacionFisica(DateTime fecha, decimal pesoKg, decimal alturaMts, decimal porcentajeGrasa, Socio cliente, Entrenador evaluador) => (Fecha, PesoKg, AlturaMts, PorcentajeGrasa, Cliente, Evaluador) = (fecha, pesoKg, alturaMts, porcentajeGrasa, cliente, evaluador);
    public decimal CalcularIMC() { if (AlturaMts <= 0) throw new InvalidOperationException("La altura debe ser mayor que cero."); return Math.Round(PesoKg / (AlturaMts * AlturaMts), 2); }
}

namespace FitSpotter.Modelos.Membresias;
public class Membresia
{
    public string NombrePlan { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; private set; }
    public int DuracionDias { get; set; }
    public Membresia(string nombrePlan, string descripcion, decimal precio, int duracionDias) => (NombrePlan, Descripcion, Precio, DuracionDias) = (nombrePlan, descripcion, precio, duracionDias);
    public void ActualizarPrecio(decimal nuevoPrecio) { if (nuevoPrecio < 0) throw new ArgumentOutOfRangeException(nameof(nuevoPrecio)); Precio = nuevoPrecio; }
    public override string ToString() => $"{NombrePlan} - ${Precio:N2}";
}

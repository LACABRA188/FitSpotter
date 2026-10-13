namespace FitSpotter.Modelos.Personas;

/// <summary>Datos de contacto comunes a todas las personas del centro deportivo.</summary>
public abstract class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Email { get; set; }
    public string Telefono { get; set; }
    protected Persona(string nombre, string apellido, string email, string telefono) => (Nombre, Apellido, Email, Telefono) = (nombre, apellido, email, telefono);
    public string NombreCompleto => $"{Nombre} {Apellido}";
    public override string ToString() => NombreCompleto;
}

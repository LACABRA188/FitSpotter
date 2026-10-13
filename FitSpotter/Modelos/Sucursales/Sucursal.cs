using FitSpotter.Modelos.Clases;
namespace FitSpotter.Modelos.Sucursales;
public enum EstadoEquipamiento { Operativo, EnMantenimiento, Defectuoso }
public class Equipamiento
{
    public string Nombre { get; set; }
    public EstadoEquipamiento Estado { get; private set; }
    public DateTime FechaMantenimiento { get; set; }
    public Equipamiento(string nombre, EstadoEquipamiento estado, DateTime fechaMantenimiento) => (Nombre, Estado, FechaMantenimiento) = (nombre, estado, fechaMantenimiento);
    public void MarcarDefectuoso() => Estado = EstadoEquipamiento.Defectuoso;
    public void MarcarOperativo() => Estado = EstadoEquipamiento.Operativo;
}
public class Sucursal
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public List<Equipamiento> Inventario { get; } = [];
    public List<ClaseGrupal> Actividades { get; } = [];
    public Sucursal(string nombre, string direccion, string telefono) => (Nombre, Direccion, Telefono) = (nombre, direccion, telefono);
    public void AgregarEquipo(Equipamiento equipo) => Inventario.Add(equipo);
    public override string ToString() => Nombre;
}

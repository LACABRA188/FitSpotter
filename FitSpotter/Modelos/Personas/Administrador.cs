using FitSpotter.Modelos.Comercial;
using FitSpotter.Modelos.Membresias;
namespace FitSpotter.Modelos.Personas;
public class Administrador : Usuario
{
    public string Sector { get; set; }
    public int NivelPermiso { get; set; }
    public Administrador(string nombre, string apellido, string email, string telefono, string usuario, string password, string sector, int nivelPermiso) : base(nombre, apellido, email, telefono, usuario, password, RolUsuario.Administrador) => (Sector, NivelPermiso) = (sector, nivelPermiso);
    public Pago RegistrarPago(Socio socio, decimal monto, MetodoPago metodo) => new(DateTime.Now, monto, metodo, socio);
    public Venta RegistrarVenta(Socio socio, MetodoPago metodo, IEnumerable<DetalleVenta> articulos) => new(DateTime.Now, metodo, socio, articulos);
    public Membresia CrearMembresia(string nombre, string descripcion, decimal precio, int duracionDias) => new(nombre, descripcion, precio, duracionDias);
}

namespace FitSpotter.Modelos.Personas;
public enum RolUsuario { Socio, Entrenador, Administrador }
public class Usuario : Persona
{
    public string NombreUsuario { get; set; }
    public string Password { get; private set; }
    public RolUsuario Rol { get; set; }
    public bool Activo { get; private set; } = true;
    public bool SesionIniciada { get; private set; }
    public Usuario(string nombre, string apellido, string email, string telefono, string nombreUsuario, string password, RolUsuario rol) : base(nombre, apellido, email, telefono) => (NombreUsuario, Password, Rol) = (nombreUsuario, password, rol);
    public bool IniciarSesion(string password) => SesionIniciada = Activo && Password == password;
    public void CerrarSesion() => SesionIniciada = false;
    public void CambiarPassword(string nuevaPassword) => Password = nuevaPassword;
    public void Desactivar() { Activo = false; CerrarSesion(); }
}

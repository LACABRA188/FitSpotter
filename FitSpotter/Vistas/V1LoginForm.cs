using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V1LoginForm : VistaFormBase
{
    // Diseñador: txtUsuario, txtPassword, btnIngresar, btnRegistrarSocio.
    public void btnIngresar_Click(object? sender, EventArgs e)
    {
        var usuario = Control<TextBox>("txtUsuario"); var password = Control<TextBox>("txtPassword");
        if (!Requerido(usuario, "Usuario") || !Requerido(password, "Contraseña")) return;
        var cuenta = AppData.Administradores.Cast<Usuario>().Concat(AppData.Entrenadores).Concat(AppData.Socios.Select(s => s.CuentaUsuario)).FirstOrDefault(u => u.NombreUsuario.Equals(usuario!.Text, StringComparison.OrdinalIgnoreCase));
        if (cuenta is null || !cuenta.IniciarSesion(password!.Text)) { MessageBox.Show("Credenciales inválidas."); return; }
        AppData.UsuarioActual = cuenta.Rol == RolUsuario.Socio ? AppData.Socios.First(s => s.CuentaUsuario == cuenta) : cuenta;
        Form destino = cuenta.Rol switch { RolUsuario.Socio => new V3DashboardSocioForm(), RolUsuario.Entrenador => new V6DashboardEntrenadorForm(), _ => new V8DashboardAdministradorForm() };
        Hide(); destino.FormClosed += (_, _) => Show(); destino.Show();
    }
    public void btnRegistrarSocio_Click(object? sender, EventArgs e) => Abrir(new V2RegistroSocioForm());
}



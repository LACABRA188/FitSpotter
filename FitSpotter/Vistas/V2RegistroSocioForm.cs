using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V2RegistroSocioForm : VistaFormBase
{
    // Diseñador: txtNombre, txtApellido, txtEmail, txtTelefono, txtUsuario, txtPassword, cboMembresia, btnGuardar.
    public void V2RegistroSocioForm_Load(object? sender, EventArgs e) => CargarCombo("cboMembresia", AppData.Membresias);
    public void btnGuardar_Click(object? sender, EventArgs e)
    {
        var nombre = Control<TextBox>("txtNombre"); var apellido = Control<TextBox>("txtApellido"); var email = Control<TextBox>("txtEmail"); var telefono = Control<TextBox>("txtTelefono"); var usuario = Control<TextBox>("txtUsuario"); var password = Control<TextBox>("txtPassword");
        if (!Requerido(nombre, "Nombre") || !Requerido(apellido, "Apellido") || !Requerido(email, "Email") || !Requerido(usuario, "Usuario") || !Requerido(password, "Contraseña")) return;
        if (!email!.Text.Contains('@')) { MessageBox.Show("Ingrese un email válido."); return; }
        var plan = Control<ComboBox>("cboMembresia")?.SelectedItem as Modelos.Membresias.Membresia; if (plan is null) { MessageBox.Show("Seleccione una membresía."); return; }
        var cuenta = new Usuario(nombre!.Text, apellido!.Text, email.Text, telefono?.Text ?? "", usuario!.Text, password!.Text, RolUsuario.Socio);
        AppData.Socios.Add(new Socio(AppData.Socios.Count + 1, nombre.Text, apellido.Text, email.Text, telefono?.Text ?? "", plan, cuenta));
        MessageBox.Show("Socio registrado correctamente."); Close();
    }
}

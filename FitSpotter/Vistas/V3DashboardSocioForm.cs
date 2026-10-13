using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V3DashboardSocioForm : VistaFormBase
{
    // Diseñador: lblBienvenida, lblEstadoCuota, btnMisRutinas, btnReservarClase, btnTienda, btnCerrarSesion.
    public void V3DashboardSocioForm_Load(object? sender, EventArgs e) { var socio = AppData.UsuarioActual as Socio; socio?.ActualizarEstadoCuota(); var bienvenida = Control<Label>("lblBienvenida"); if (bienvenida is not null && socio is not null) bienvenida.Text = $"Bienvenida/o, {socio.NombreCompleto}"; var estado = Control<Label>("lblEstadoCuota"); if (estado is not null && socio is not null) estado.Text = $"Cuota: {socio.EstadoCuota} - vence {socio.FechaVencimiento:d}"; }
    public void btnMisRutinas_Click(object? sender, EventArgs e) => Abrir(new V4MisRutinasForm());
    public void btnReservarClase_Click(object? sender, EventArgs e) => Abrir(new V5ReservaClasesForm());
    public void btnCerrarSesion_Click(object? sender, EventArgs e) => Close();
}

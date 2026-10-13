using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V6DashboardEntrenadorForm : VistaFormBase
{
    // Diseñador: lblEntrenador, dgvSocios, dgvAgenda, btnCrearRutina, btnEvaluacion.
    public void V6DashboardEntrenadorForm_Load(object? sender, EventArgs e) { var entrenador = AppData.UsuarioActual as Entrenador; var etiqueta = Control<Label>("lblEntrenador"); if (etiqueta is not null && entrenador is not null) etiqueta.Text = $"{entrenador.NombreCompleto} - {entrenador.Especialidad}"; CargarGrilla("dgvSocios", AppData.Socios.Where(s => s.Rutinas.Any(r => r.Profesor == entrenador))); CargarGrilla("dgvAgenda", entrenador?.ClasesAsignadas ?? []); }
    public void btnCrearRutina_Click(object? sender, EventArgs e) => Abrir(new V7CreadorRutinasForm());
}

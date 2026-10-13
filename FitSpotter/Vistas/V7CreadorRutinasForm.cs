using FitSpotter.Modelos.Personas;
using FitSpotter.Modelos.Rutinas;
namespace FitSpotter.Vistas;
public class V7CreadorRutinasForm : VistaFormBase
{
    private readonly List<Ejercicio> ejerciciosPendientes = [];
    // Diseñador: cboSocio, txtObjetivo, dtpInicio, dtpFin, txtEjercicio, txtGrupoMuscular, nudSeries, nudRepeticiones, nudPeso, dgvEjercicios, btnAgregarEjercicio, btnGuardarRutina.
    public void V7CreadorRutinasForm_Load(object? sender, EventArgs e) { CargarCombo("cboSocio", AppData.Socios); CargarGrilla("dgvEjercicios", ejerciciosPendientes); }
    public void btnAgregarEjercicio_Click(object? sender, EventArgs e) { var nombre = Control<TextBox>("txtEjercicio"); var grupo = Control<TextBox>("txtGrupoMuscular"); var series = Control<NumericUpDown>("nudSeries"); var reps = Control<NumericUpDown>("nudRepeticiones"); var peso = Control<NumericUpDown>("nudPeso"); if (!Requerido(nombre, "Ejercicio") || !Requerido(grupo, "Grupo muscular") || series is null || reps is null || peso is null) return; ejerciciosPendientes.Add(new Ejercicio(nombre!.Text, grupo!.Text, (int)series.Value, (int)reps.Value, peso.Value)); CargarGrilla("dgvEjercicios", ejerciciosPendientes); }
    public void btnGuardarRutina_Click(object? sender, EventArgs e) { var socio = Control<ComboBox>("cboSocio")?.SelectedItem as Socio; var objetivo = Control<TextBox>("txtObjetivo"); var inicio = Control<DateTimePicker>("dtpInicio"); var fin = Control<DateTimePicker>("dtpFin"); var entrenador = AppData.UsuarioActual as Entrenador; if (socio is null || entrenador is null || !Requerido(objetivo, "Objetivo") || inicio is null || fin is null || ejerciciosPendientes.Count == 0) { MessageBox.Show("Seleccione socio y agregue al menos un ejercicio."); return; } var rutina = entrenador.AsignarRutina(socio, objetivo!.Text, inicio.Value, fin.Value); ejerciciosPendientes.ForEach(rutina.AgregarEjercicio); MessageBox.Show("Rutina asignada."); Close(); }
}

using FitSpotter.Modelos.Clases;
using FitSpotter.Modelos.Sucursales;
namespace FitSpotter.Vistas;
public class V10GestionClasesInventarioForm : VistaFormBase
{
    // Diseñador: cboSucursal, cboEntrenador, txtNombreClase, dtpHorario, nudCupo, dgvClases, dgvEquipamiento, btnCrearClase, btnMarcarDefectuoso.
    public void V10GestionClasesInventarioForm_Load(object? sender, EventArgs e) { CargarCombo("cboSucursal", AppData.Sucursales); CargarCombo("cboEntrenador", AppData.Entrenadores); ActualizarGrillas(); }
    public void btnCrearClase_Click(object? sender, EventArgs e) { var sede = Control<ComboBox>("cboSucursal")?.SelectedItem as Sucursal; var instructor = Control<ComboBox>("cboEntrenador")?.SelectedItem as Modelos.Personas.Entrenador; var nombre = Control<TextBox>("txtNombreClase"); var horario = Control<DateTimePicker>("dtpHorario"); var cupo = Control<NumericUpDown>("nudCupo"); if (sede is null || instructor is null || !Requerido(nombre, "Nombre de clase") || horario is null || cupo is null || cupo.Value <= 0) return; var clase = new ClaseGrupal(nombre!.Text, horario.Value, (int)cupo.Value, instructor, sede); AppData.Clases.Add(clase); sede.Actividades.Add(clase); instructor.ClasesAsignadas.Add(clase); ActualizarGrillas(); }
    public void btnMarcarDefectuoso_Click(object? sender, EventArgs e) { var equipo = Control<DataGridView>("dgvEquipamiento")?.CurrentRow?.DataBoundItem as Equipamiento; if (equipo is null) { MessageBox.Show("Seleccione un equipo."); return; } equipo.MarcarDefectuoso(); ActualizarGrillas(); }
    private void ActualizarGrillas() { var sede = Control<ComboBox>("cboSucursal")?.SelectedItem as Sucursal; CargarGrilla("dgvClases", sede?.Actividades ?? []); CargarGrilla("dgvEquipamiento", sede?.Inventario ?? []); }
}

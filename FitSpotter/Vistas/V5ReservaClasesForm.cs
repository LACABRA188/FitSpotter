using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V5ReservaClasesForm : VistaFormBase
{
    // Diseñador: cboSucursal, dgvClases, btnReservar, btnActualizar.
    public void V5ReservaClasesForm_Load(object? sender, EventArgs e) { CargarCombo("cboSucursal", AppData.Sucursales); CargarClases(); }
    public void btnActualizar_Click(object? sender, EventArgs e) => CargarClases();
    private void CargarClases() { var sede = Control<ComboBox>("cboSucursal")?.SelectedItem as Modelos.Sucursales.Sucursal; CargarGrilla("dgvClases", sede is null ? AppData.Clases : AppData.Clases.Where(c => c.Sede == sede)); }
    public void btnReservar_Click(object? sender, EventArgs e) { var clase = Control<DataGridView>("dgvClases")?.CurrentRow?.DataBoundItem as Modelos.Clases.ClaseGrupal; var socio = AppData.UsuarioActual as Socio; if (clase is null || socio is null) { MessageBox.Show("Seleccione una clase."); return; } try { socio.ReservarClase(clase); MessageBox.Show("Reserva confirmada."); CargarClases(); } catch (InvalidOperationException ex) { MessageBox.Show(ex.Message); } }
}

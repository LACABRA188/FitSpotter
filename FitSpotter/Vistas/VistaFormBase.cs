using System.Windows.Forms;
namespace FitSpotter.Vistas;
/// <summary>Utilidades para los code-behind. Los controles se crean exclusivamente con el Diseñador de Visual Studio.</summary>
public abstract class VistaFormBase : Form
{
    protected T? Control<T>(string nombre) where T : Control => Controls.Find(nombre, true).OfType<T>().FirstOrDefault();
    protected void CargarCombo<T>(string nombre, IEnumerable<T> datos) { var combo = Control<ComboBox>(nombre); if (combo is null) return; combo.DataSource = datos.ToList(); }
    protected void CargarGrilla<T>(string nombre, IEnumerable<T> datos) { var grilla = Control<DataGridView>(nombre); if (grilla is null) return; grilla.AutoGenerateColumns = true; grilla.DataSource = datos.ToList(); }
    protected bool Requerido(TextBox? caja, string etiqueta) { if (caja is not null && !string.IsNullOrWhiteSpace(caja.Text)) return true; MessageBox.Show($"{etiqueta} es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
    protected void Abrir(Form formulario) => formulario.ShowDialog(this);
}

using FitSpotter.Modelos.Clases;
using FitSpotter.Modelos.Comercial;
using FitSpotter.Modelos.Membresias;
using FitSpotter.Modelos.Personas;
using FitSpotter.Modelos.Rutinas;
using FitSpotter.Modelos.Sucursales;

namespace FitSpotter;

public partial class V2RegistroSocioForm
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        cboMembresia.DataSource = AppData.Membresias.ToList();
        btnGuardar.Click += (_, _) => Registrar();
    }
    private void Registrar()
    {
        if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) || !txtEmail.Text.Contains('@') || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cboMembresia.SelectedItem is not Membresia plan) { MessageBox.Show("Complete los datos obligatorios y un email válido."); return; }
        var cuenta = new Usuario(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text, txtUsuario.Text, txtPassword.Text, RolUsuario.Socio);
        AppData.Socios.Add(new Socio(AppData.Socios.Count + 1, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text, plan, cuenta));
        MessageBox.Show("Socio registrado correctamente."); Close();
    }
}

public partial class v4MisRutinasFormcs
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        var rutina = (AppData.UsuarioActual as Socio)?.VerRutinaActual();
        if (rutina is null) { lblObjetivo.Text = "No hay rutina asignada."; return; }
        lblObjetivo.Text = rutina.Objetivo; lblPeriodo.Text = $"{rutina.FechaInicio:d} al {rutina.FechaFin:d}";
        dgvEjercicios.DataSource = rutina.Ejercicios.ToList();
    }
}

public partial class V5ReservaClaseForm
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e); cboSucursal1.DataSource = AppData.Sucursales.ToList(); CargarClases();
        btnActualizar.Click += (_, _) => CargarClases(); btnReservar.Click += (_, _) => Reservar();
    }
    private void CargarClases() { var sede = cboSucursal1.SelectedItem as Sucursal; dgvClases.DataSource = AppData.Clases.Where(c => sede is null || c.Sede == sede).ToList(); }
    private void Reservar() { var clase = dgvClases.CurrentRow?.DataBoundItem as ClaseGrupal; var socio = AppData.UsuarioActual as Socio; if (clase is null || socio is null) { MessageBox.Show("Seleccione una clase."); return; } try { socio.ReservarClase(clase); MessageBox.Show("Reserva confirmada."); CargarClases(); } catch (Exception ex) { MessageBox.Show(ex.Message); } }
}

public partial class V6DashboardEntrenadorForm
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e); var entrenador = AppData.UsuarioActual as Entrenador;
        if (entrenador is not null) { lblEntrenador.Text = $"{entrenador.NombreCompleto} - {entrenador.Especialidad}"; dgvSocios.DataSource = AppData.Socios.Where(s => s.Rutinas.Any(r => r.Profesor == entrenador)).ToList(); dgvAgenda.DataSource = entrenador.ClasesAsignadas.ToList(); }
        btnCrearRutina.Click += (_, _) => new V7CreadorRuutinasForm().ShowDialog(this);
    }
}

public partial class V7CreadorRuutinasForm
{
    private readonly List<Ejercicio> ejerciciosPendientes = [];
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e); cboSocio.DataSource = AppData.Socios.ToList(); dgvEjercicios.DataSource = ejerciciosPendientes;
        btnAgregarEjercicio.Click += (_, _) => { if (string.IsNullOrWhiteSpace(txtEjercicio.Text) || string.IsNullOrWhiteSpace(txtGrupoMuscular.Text)) return; ejerciciosPendientes.Add(new Ejercicio(txtEjercicio.Text, txtGrupoMuscular.Text, (int)nudSeries.Value, (int)nudRepeticiones.Value, nudPeso.Value)); dgvEjercicios.DataSource = ejerciciosPendientes.ToList(); };
        btnGuardarRutina.Click += (_, _) => GuardarRutina();
    }
    private void GuardarRutina() { var socio = cboSocio.SelectedItem as Socio; var entrenador = AppData.UsuarioActual as Entrenador; if (socio is null || entrenador is null || string.IsNullOrWhiteSpace(txtObjetivo.Text) || ejerciciosPendientes.Count == 0) { MessageBox.Show("Complete el objetivo y agregue ejercicios."); return; } var rutina = entrenador.AsignarRutina(socio, txtObjetivo.Text, dtpInicio.Value, dtpFin.Value); ejerciciosPendientes.ForEach(rutina.AgregarEjercicio); MessageBox.Show("Rutina asignada."); Close(); }
}

public partial class V8DashboardAdministradorForm
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e); lblTotalSocios.Text = AppData.Socios.Count.ToString(); lblCaja.Text = $"${AppData.Pagos.Sum(p => p.Monto) + AppData.Ventas.Sum(v => v.MontoTotal):N2}"; lblStockBajo.Text = AppData.Suplementos.Count(s => s.Stock < 5).ToString();
        btnCobrosVentas.Click += (_, _) => new V9CobroFacturacionTiendaForm().ShowDialog(this); btnGestionClasesInventario.Click += (_, _) => new V10GestionClasesInventario().ShowDialog(this);
    }
}

public partial class V9CobroFacturacionTiendaForm
{
    private readonly List<DetalleVenta> carrito = [];
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e); cboSocio.DataSource = AppData.Socios.ToList(); cboSuplemento.DataSource = AppData.Suplementos.ToList(); cboMetodoPago.DataSource = Enum.GetValues<MetodoPago>(); ActualizarCarrito();
        btnCobrarCuota.Click += (_, _) => Cobrar(); btnAgregarProducto.Click += (_, _) => Agregar(); btnConfirmarVenta.Click += (_, _) => Vender();
    }
    private void Cobrar() { if (cboSocio.SelectedItem is not Socio socio || cboMetodoPago.SelectedItem is not MetodoPago metodo) return; var pago = new Pago(DateTime.Now, socio.MembresiaActual.Precio, metodo, socio); pago.ProcesarPago(AppData.SiguienteFactura()); AppData.Pagos.Add(pago); MessageBox.Show(pago.Comprobante!.GenerarComprobante()); }
    private void Agregar() { if (cboSuplemento.SelectedItem is not Suplemento suplemento || nudCantidad.Value < 1 || nudCantidad.Value > suplemento.Stock) return; carrito.Add(new DetalleVenta(suplemento, (int)nudCantidad.Value)); ActualizarCarrito(); }
    private void Vender() { if (cboSocio.SelectedItem is not Socio socio || cboMetodoPago.SelectedItem is not MetodoPago metodo || carrito.Count == 0) return; var venta = new Venta(DateTime.Now, metodo, socio, carrito); venta.ProcesarVenta(AppData.SiguienteFactura()); AppData.Ventas.Add(venta); carrito.Clear(); ActualizarCarrito(); MessageBox.Show(venta.Comprobante!.GenerarComprobante()); }
    private void ActualizarCarrito() { dgvCarrito.DataSource = carrito.ToList(); lblTotal.Text = $"${carrito.Sum(x => x.Subtotal):N2}"; }
}

public partial class V10GestionClasesInventario
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e); cboSucursal.DataSource = AppData.Sucursales.ToList(); cboEntrenador.DataSource = AppData.Entrenadores.ToList(); Actualizar();
        btnCrearClase.Click += (_, _) => Crear(); btnMarcarDefectuoso.Click += (_, _) => Marcar();
    }
    private void Crear() { if (cboSucursal.SelectedItem is not Sucursal sede || cboEntrenador.SelectedItem is not Entrenador entrenador || string.IsNullOrWhiteSpace(txtNombreClase.Text) || nudCupo.Value < 1) return; var clase = new ClaseGrupal(txtNombreClase.Text, dtpHorario.Value, (int)nudCupo.Value, entrenador, sede); AppData.Clases.Add(clase); sede.Actividades.Add(clase); entrenador.ClasesAsignadas.Add(clase); Actualizar(); }
    private void Marcar() { if (dgvEquipamiento.CurrentRow?.DataBoundItem is not Equipamiento equipo) return; equipo.MarcarDefectuoso(); Actualizar(); }
    private void Actualizar() { var sede = cboSucursal.SelectedItem as Sucursal; dgvClases.DataSource = sede?.Actividades.ToList(); dgvEquipamiento.DataSource = sede?.Inventario.ToList(); }
}

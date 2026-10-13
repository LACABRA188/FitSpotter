using FitSpotter.Modelos.Comercial;
using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V9CobroFacturacionTiendaForm : VistaFormBase
{
    private readonly List<DetalleVenta> carrito = [];
    // Diseñador: cboSocio, cboMetodoPago, cboSuplemento, nudCantidad, dgvCarrito, lblTotal, btnCobrarCuota, btnAgregarProducto, btnConfirmarVenta.
    public void V9CobroFacturacionTiendaForm_Load(object? sender, EventArgs e) { CargarCombo("cboSocio", AppData.Socios); CargarCombo("cboMetodoPago", Enum.GetValues<MetodoPago>()); CargarCombo("cboSuplemento", AppData.Suplementos); ActualizarCarrito(); }
    public void btnCobrarCuota_Click(object? sender, EventArgs e) { var socio = Control<ComboBox>("cboSocio")?.SelectedItem as Socio; var metodo = Control<ComboBox>("cboMetodoPago")?.SelectedItem as MetodoPago?; if (socio is null || metodo is null) { MessageBox.Show("Seleccione socio y método de pago."); return; } var pago = new Pago(DateTime.Now, socio.MembresiaActual.Precio, metodo.Value, socio); pago.ProcesarPago(AppData.SiguienteFactura()); AppData.Pagos.Add(pago); MessageBox.Show(pago.Comprobante!.GenerarComprobante()); }
    public void btnAgregarProducto_Click(object? sender, EventArgs e) { var suplemento = Control<ComboBox>("cboSuplemento")?.SelectedItem as Suplemento; var cantidad = Control<NumericUpDown>("nudCantidad")?.Value ?? 0; if (suplemento is null || cantidad <= 0 || cantidad > suplemento.Stock) { MessageBox.Show("Seleccione una cantidad disponible."); return; } carrito.Add(new DetalleVenta(suplemento, (int)cantidad)); ActualizarCarrito(); }
    public void btnConfirmarVenta_Click(object? sender, EventArgs e) { var socio = Control<ComboBox>("cboSocio")?.SelectedItem as Socio; var metodo = Control<ComboBox>("cboMetodoPago")?.SelectedItem as MetodoPago?; if (socio is null || metodo is null || carrito.Count == 0) { MessageBox.Show("Complete socio, pago y productos."); return; } var venta = new Venta(DateTime.Now, metodo.Value, socio, carrito); venta.ProcesarVenta(AppData.SiguienteFactura()); AppData.Ventas.Add(venta); MessageBox.Show(venta.Comprobante!.GenerarComprobante()); carrito.Clear(); ActualizarCarrito(); }
    private void ActualizarCarrito() { CargarGrilla("dgvCarrito", carrito); var total = Control<Label>("lblTotal"); if (total is not null) total.Text = $"${carrito.Sum(i => i.Subtotal):N2}"; }
}

namespace FitSpotter.Vistas;
public class V8DashboardAdministradorForm : VistaFormBase
{
    // Diseñador: lblTotalSocios, lblCaja, lblStockBajo, btnCobrosVentas, btnGestionClasesInventario.
    public void V8DashboardAdministradorForm_Load(object? sender, EventArgs e) { var socios = Control<Label>("lblTotalSocios"); if (socios is not null) socios.Text = AppData.Socios.Count.ToString(); var caja = Control<Label>("lblCaja"); if (caja is not null) caja.Text = $"${AppData.Pagos.Sum(p => p.Monto) + AppData.Ventas.Sum(v => v.MontoTotal):N2}"; var stock = Control<Label>("lblStockBajo"); if (stock is not null) stock.Text = AppData.Suplementos.Count(s => s.Stock < 5).ToString(); }
    public void btnCobrosVentas_Click(object? sender, EventArgs e) => Abrir(new V9CobroFacturacionTiendaForm());
    public void btnGestionClasesInventario_Click(object? sender, EventArgs e) => Abrir(new V10GestionClasesInventarioForm());
}

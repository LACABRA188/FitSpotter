using FitSpotter.Modelos.Personas;
namespace FitSpotter.Modelos.Comercial;
public enum MetodoPago { Efectivo, Debito, Credito, Transferencia, BilleteraVirtual }
public class Factura
{
    public long NroFactura { get; }
    public string Cae { get; }
    public DateTime FechaEmision { get; } = DateTime.Now;
    public decimal MontoTotal { get; }
    public Factura(long nroFactura, decimal montoTotal) { NroFactura = nroFactura; MontoTotal = montoTotal; Cae = Guid.NewGuid().ToString("N")[..14].ToUpperInvariant(); }
    public string GenerarComprobante() => $"Factura {NroFactura} | CAE {Cae} | Total: ${MontoTotal:N2}";
}
public class Pago
{
    public DateTime Fecha { get; }
    public decimal Monto { get; }
    public MetodoPago MetodoPago { get; }
    public Socio Cliente { get; }
    public Factura? Comprobante { get; private set; }
    public Pago(DateTime fecha, decimal monto, MetodoPago metodoPago, Socio cliente) => (Fecha, Monto, MetodoPago, Cliente) = (fecha, monto, metodoPago, cliente);
    public Factura ProcesarPago(long nroFactura) { Cliente.PagarCuota(); return Comprobante = new Factura(nroFactura, Monto); }
}
public class Suplemento
{
    public string Nombre { get; set; }
    public string Marca { get; set; }
    public string Categoria { get; set; }
    public decimal Precio { get; private set; }
    public int Stock { get; private set; }
    public Suplemento(string nombre, string marca, string categoria, decimal precio, int stock) => (Nombre, Marca, Categoria, Precio, Stock) = (nombre, marca, categoria, precio, stock);
    public void ActualizarStock(int cantidad) { if (Stock + cantidad < 0) throw new InvalidOperationException("Stock insuficiente."); Stock += cantidad; }
    public void ModificarPrecio(decimal precio) { if (precio < 0) throw new ArgumentOutOfRangeException(nameof(precio)); Precio = precio; }
    public override string ToString() => $"{Nombre} ({Marca})";
}
public record DetalleVenta(Suplemento Suplemento, int Cantidad) { public decimal Subtotal => Suplemento.Precio * Cantidad; }
public class Venta
{
    public DateTime Fecha { get; }
    public decimal MontoTotal { get; private set; }
    public MetodoPago MetodoPago { get; }
    public Socio Cliente { get; }
    public List<DetalleVenta> Articulos { get; }
    public Factura? Comprobante { get; private set; }
    public Venta(DateTime fecha, MetodoPago metodoPago, Socio cliente, IEnumerable<DetalleVenta> articulos) { Fecha = fecha; MetodoPago = metodoPago; Cliente = cliente; Articulos = articulos.ToList(); MontoTotal = CalcularTotal(); }
    public decimal CalcularTotal() => Articulos.Sum(a => a.Subtotal);
    public Factura ProcesarVenta(long nroFactura) { foreach (var item in Articulos) item.Suplemento.ActualizarStock(-item.Cantidad); return Comprobante = new Factura(nroFactura, MontoTotal); }
}

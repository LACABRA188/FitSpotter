using FitSpotter.Modelos.Personas;
namespace FitSpotter.Vistas;
public class V4MisRutinasForm : VistaFormBase
{
    // Diseñador: lblObjetivo, lblPeriodo, dgvEjercicios, btnCerrar.
    public void V4MisRutinasForm_Load(object? sender, EventArgs e) { var rutina = (AppData.UsuarioActual as Socio)?.VerRutinaActual(); if (rutina is null) { MessageBox.Show("No hay una rutina asignada."); return; } var objetivo = Control<Label>("lblObjetivo"); if (objetivo is not null) objetivo.Text = rutina.Objetivo; var periodo = Control<Label>("lblPeriodo"); if (periodo is not null) periodo.Text = $"{rutina.FechaInicio:d} al {rutina.FechaFin:d}"; CargarGrilla("dgvEjercicios", rutina.Ejercicios); }
}

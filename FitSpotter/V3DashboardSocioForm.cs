using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FitSpotter.Modelos.Personas;
using FitSpotter.Vistas;

namespace FitSpotter
{
    public partial class V3DashboardSocioForm : Form
    {
        public V3DashboardSocioForm()
        {
            InitializeComponent();
        }

        private void V3DashboardSocioForm_Load(object sender, EventArgs e)
        {
            if (AppData.UsuarioActual is not Socio socio) return;
            socio.ActualizarEstadoCuota();
            lblBienvenida.Text = $"Bienvenida/o, {socio.NombreCompleto}";
            lblEstadoCuota.Text = $"Cuota: {socio.EstadoCuota} - vence {socio.FechaVencimiento:d}";
        }
        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void btnMisRutinas_Click(object sender, EventArgs e)
        {
            new v4MisRutinasFormcs().ShowDialog(this);
        }

        private void btnReservarClase_Click(object sender, EventArgs e)
        {
            new V5ReservaClaseForm().ShowDialog(this);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}



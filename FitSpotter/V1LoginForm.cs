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
    public partial class V1LoginForm : Form
    {
        public V1LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Ingrese usuario y contraseña.");
                return;
            }
            var cuenta = AppData.Administradores.Cast<Usuario>().Concat(AppData.Entrenadores).Concat(AppData.Socios.Select(s => s.CuentaUsuario)).FirstOrDefault(u => u.NombreUsuario.Equals(txtUsuario.Text, StringComparison.OrdinalIgnoreCase));
            if (cuenta is null || !cuenta.IniciarSesion(txtPassword.Text))
            {
                MessageBox.Show("Credenciales inválidas.");
                return;
            }
            AppData.UsuarioActual = cuenta.Rol == RolUsuario.Socio ? AppData.Socios.First(s => s.CuentaUsuario == cuenta) : cuenta;
            Form destino = cuenta.Rol switch
            {
                RolUsuario.Socio => new V3DashboardSocioForm(),
                RolUsuario.Entrenador => new V6DashboardEntrenadorForm(),
                _ => new V8DashboardAdministradorForm()
            };
            Hide();
            destino.FormClosed += (_, _) => Show();
            destino.Show();
        }

        private void btn_RegistrarSocio_Click(object sender, EventArgs e)
        {
            new V2RegistroSocioForm().ShowDialog(this);
        }
        private void V1LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}






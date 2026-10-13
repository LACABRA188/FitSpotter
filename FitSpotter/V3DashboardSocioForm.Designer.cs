namespace FitSpotter
{
    partial class V3DashboardSocioForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            lblEstadoCuota = new Label();
            btnMisRutinas = new Button();
            btnReservasClase = new Button();
            btnTienda = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Location = new Point(354, 27);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(66, 15);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            lblBienvenida.Click += lblBienvenida_Click;
            // 
            // lblEstadoCuota
            // 
            lblEstadoCuota.AutoSize = true;
            lblEstadoCuota.Location = new Point(340, 72);
            lblEstadoCuota.Name = "lblEstadoCuota";
            lblEstadoCuota.Size = new Size(91, 15);
            lblEstadoCuota.TabIndex = 1;
            lblEstadoCuota.Text = "Estado de cuota";
            // 
            // btnMisRutinas
            // 
            btnMisRutinas.Location = new Point(194, 198);
            btnMisRutinas.Name = "btnMisRutinas";
            btnMisRutinas.Size = new Size(75, 23);
            btnMisRutinas.TabIndex = 2;
            btnMisRutinas.Text = "Mis rutinas";
            btnMisRutinas.UseVisualStyleBackColor = true;
            btnMisRutinas.Click += btnMisRutinas_Click;
            // 
            // btnReservasClase
            // 
            btnReservasClase.Location = new Point(301, 181);
            btnReservasClase.Name = "btnReservasClase";
            btnReservasClase.Size = new Size(75, 40);
            btnReservasClase.TabIndex = 3;
            btnReservasClase.Text = "Reservar clase";
            btnReservasClase.UseVisualStyleBackColor = true;
            btnReservasClase.Click += btnReservarClase_Click;
            // 
            // btnTienda
            // 
            btnTienda.Location = new Point(405, 178);
            btnTienda.Name = "btnTienda";
            btnTienda.Size = new Size(88, 43);
            btnTienda.TabIndex = 4;
            btnTienda.Text = "Tienda de suplementos";
            btnTienda.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(533, 159);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(88, 62);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // V3DashboardSocioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnTienda);
            Controls.Add(btnReservasClase);
            Controls.Add(btnMisRutinas);
            Controls.Add(lblEstadoCuota);
            Controls.Add(lblBienvenida);
            Name = "V3DashboardSocioForm";
            Text = "FitSpotter - Área del socio";
            Load += V3DashboardSocioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblEstadoCuota;
        private Button btnMisRutinas;
        private Button btnReservasClase;
        private Button btnTienda;
        private Button btnCerrarSesion;
    }
}

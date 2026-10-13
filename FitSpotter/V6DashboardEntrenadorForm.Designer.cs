namespace FitSpotter
{
    partial class V6DashboardEntrenadorForm
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
            lblEntrenador = new Label();
            dgvSocios = new DataGridView();
            dgvAgenda = new DataGridView();
            btnCrearRutina = new Button();
            btnEvaluacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).BeginInit();
            SuspendLayout();
            // 
            // lblEntrenador
            // 
            lblEntrenador.AutoSize = true;
            lblEntrenador.Location = new Point(186, 44);
            lblEntrenador.Name = "lblEntrenador";
            lblEntrenador.Size = new Size(65, 15);
            lblEntrenador.TabIndex = 0;
            lblEntrenador.Text = "Entrenador";
            // 
            // dgvSocios
            // 
            dgvSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSocios.Location = new Point(147, 124);
            dgvSocios.Name = "dgvSocios";
            dgvSocios.Size = new Size(240, 150);
            dgvSocios.TabIndex = 1;
            // 
            // dgvAgenda
            // 
            dgvAgenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgenda.Location = new Point(149, 289);
            dgvAgenda.Name = "dgvAgenda";
            dgvAgenda.Size = new Size(240, 150);
            dgvAgenda.TabIndex = 2;
            // 
            // btnCrearRutina
            // 
            btnCrearRutina.Location = new Point(48, 142);
            btnCrearRutina.Name = "btnCrearRutina";
            btnCrearRutina.Size = new Size(75, 56);
            btnCrearRutina.TabIndex = 3;
            btnCrearRutina.Text = "Crear rutina";
            btnCrearRutina.UseVisualStyleBackColor = true;
            btnCrearRutina.Click += btnCrearRutina_Click;
            // 
            // btnEvaluacion
            // 
            btnEvaluacion.Location = new Point(48, 251);
            btnEvaluacion.Name = "btnEvaluacion";
            btnEvaluacion.Size = new Size(75, 63);
            btnEvaluacion.TabIndex = 4;
            btnEvaluacion.Text = "Nueva evaluacion";
            btnEvaluacion.UseVisualStyleBackColor = true;
            // 
            // V6DashboardEntrenadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 450);
            Controls.Add(btnEvaluacion);
            Controls.Add(btnCrearRutina);
            Controls.Add(dgvAgenda);
            Controls.Add(dgvSocios);
            Controls.Add(lblEntrenador);
            Name = "V6DashboardEntrenadorForm";
            Text = "V6DashboardEntrenadorForm";
            Load += V6DashboardEntrenadorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAgenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEntrenador;
        private DataGridView dgvSocios;
        private DataGridView dgvAgenda;
        private Button btnCrearRutina;
        private Button btnEvaluacion;
    }
}
namespace FitSpotter
{
    partial class v4MisRutinasFormcs
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
            lblObjetivo = new Label();
            lblPeriodo = new Label();
            dgvEjercicios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            SuspendLayout();
            // 
            // lblObjetivo
            // 
            lblObjetivo.AutoSize = true;
            lblObjetivo.Location = new Point(314, 26);
            lblObjetivo.Name = "lblObjetivo";
            lblObjetivo.Size = new Size(149, 15);
            lblObjetivo.TabIndex = 0;
            lblObjetivo.Text = "Objetivo de entrenamiento";
            // 
            // lblPeriodo
            // 
            lblPeriodo.AutoSize = true;
            lblPeriodo.Location = new Point(331, 149);
            lblPeriodo.Name = "lblPeriodo";
            lblPeriodo.Size = new Size(113, 15);
            lblPeriodo.TabIndex = 1;
            lblPeriodo.Text = "Periodo de la Rutina";
            // 
            // dgvEjercicios
            // 
            dgvEjercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjercicios.Location = new Point(134, 180);
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.Size = new Size(516, 243);
            dgvEjercicios.TabIndex = 2;
            // 
            // v4MisRutinasFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEjercicios);
            Controls.Add(lblPeriodo);
            Controls.Add(lblObjetivo);
            Name = "v4MisRutinasFormcs";
            Text = "v4MisRutinasFormcs";
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblObjetivo;
        private Label lblPeriodo;
        private DataGridView dgvEjercicios;
    }
}
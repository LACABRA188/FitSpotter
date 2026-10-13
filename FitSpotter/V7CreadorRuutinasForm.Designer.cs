namespace FitSpotter
{
    partial class V7CreadorRuutinasForm
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
            cboSocio = new ComboBox();
            txtObjetivo = new TextBox();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            txtEjercicio = new TextBox();
            txtGrupoMuscular = new TextBox();
            nudSeries = new NumericUpDown();
            nudRepeticiones = new NumericUpDown();
            nudPeso = new NumericUpDown();
            dgvEjercicios = new DataGridView();
            btnAgregarEjercicio = new Button();
            btnGuardarRutina = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudSeries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeticiones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).BeginInit();
            SuspendLayout();
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(388, 22);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(121, 23);
            cboSocio.TabIndex = 0;
            // 
            // txtObjetivo
            // 
            txtObjetivo.Location = new Point(67, 42);
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.Size = new Size(100, 23);
            txtObjetivo.TabIndex = 1;
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(55, 114);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(200, 23);
            dtpInicio.TabIndex = 2;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(55, 152);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(200, 23);
            dtpFin.TabIndex = 3;
            // 
            // txtEjercicio
            // 
            txtEjercicio.Location = new Point(67, 204);
            txtEjercicio.Name = "txtEjercicio";
            txtEjercicio.Size = new Size(100, 23);
            txtEjercicio.TabIndex = 4;
            // 
            // txtGrupoMuscular
            // 
            txtGrupoMuscular.Location = new Point(67, 246);
            txtGrupoMuscular.Name = "txtGrupoMuscular";
            txtGrupoMuscular.Size = new Size(100, 23);
            txtGrupoMuscular.TabIndex = 5;
            // 
            // nudSeries
            // 
            nudSeries.Location = new Point(67, 309);
            nudSeries.Name = "nudSeries";
            nudSeries.Size = new Size(120, 23);
            nudSeries.TabIndex = 6;
            // 
            // nudRepeticiones
            // 
            nudRepeticiones.Location = new Point(67, 362);
            nudRepeticiones.Name = "nudRepeticiones";
            nudRepeticiones.Size = new Size(120, 23);
            nudRepeticiones.TabIndex = 7;
            // 
            // nudPeso
            // 
            nudPeso.Location = new Point(67, 406);
            nudPeso.Name = "nudPeso";
            nudPeso.Size = new Size(120, 23);
            nudPeso.TabIndex = 8;
            // 
            // dgvEjercicios
            // 
            dgvEjercicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEjercicios.Location = new Point(299, 221);
            dgvEjercicios.Name = "dgvEjercicios";
            dgvEjercicios.Size = new Size(240, 150);
            dgvEjercicios.TabIndex = 9;
            // 
            // btnAgregarEjercicio
            // 
            btnAgregarEjercicio.Location = new Point(225, 29);
            btnAgregarEjercicio.Name = "btnAgregarEjercicio";
            btnAgregarEjercicio.Size = new Size(72, 46);
            btnAgregarEjercicio.TabIndex = 10;
            btnAgregarEjercicio.Text = "Agregar ejercicio";
            btnAgregarEjercicio.UseVisualStyleBackColor = true;
            btnAgregarEjercicio.Click += btnAgregarEjercicio_Click;
            // 
            // btnGuardarRutina
            // 
            btnGuardarRutina.Location = new Point(597, 230);
            btnGuardarRutina.Name = "btnGuardarRutina";
            btnGuardarRutina.Size = new Size(75, 52);
            btnGuardarRutina.TabIndex = 11;
            btnGuardarRutina.Text = "Guardar rutina";
            btnGuardarRutina.UseVisualStyleBackColor = true;
            btnGuardarRutina.Click += btnGuardarRutina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 207);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 12;
            label1.Text = "Ejercicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 246);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 13;
            label2.Text = "Grupo Muscular";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 311);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 14;
            label3.Text = "Series";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 364);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 15;
            label4.Text = "Repeticiones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 408);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 16;
            label5.Text = "Peso";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(90, 22);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 17;
            label6.Text = "Objetivo";
            // 
            // V7CreadorRuutinasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGuardarRutina);
            Controls.Add(btnAgregarEjercicio);
            Controls.Add(dgvEjercicios);
            Controls.Add(nudPeso);
            Controls.Add(nudRepeticiones);
            Controls.Add(nudSeries);
            Controls.Add(txtGrupoMuscular);
            Controls.Add(txtEjercicio);
            Controls.Add(dtpFin);
            Controls.Add(dtpInicio);
            Controls.Add(txtObjetivo);
            Controls.Add(cboSocio);
            Name = "V7CreadorRuutinasForm";
            Text = "V7CreadorRuutinasForm";
            Load += V7CreadorRutinasForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudSeries).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRepeticiones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEjercicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSocio;
        private TextBox txtObjetivo;
        private DateTimePicker dtpInicio;
        private DateTimePicker dtpFin;
        private TextBox txtEjercicio;
        private TextBox txtGrupoMuscular;
        private NumericUpDown nudSeries;
        private NumericUpDown nudRepeticiones;
        private NumericUpDown nudPeso;
        private DataGridView dgvEjercicios;
        private Button btnAgregarEjercicio;
        private Button btnGuardarRutina;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
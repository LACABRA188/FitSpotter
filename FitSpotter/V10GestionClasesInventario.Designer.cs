namespace FitSpotter
{
    partial class V10GestionClasesInventario
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
            cboEntrenador = new ComboBox();
            cboSucursal = new ComboBox();
            dtpHorario = new DateTimePicker();
            btnCrearClase = new Button();
            btnMarcarDefectuoso = new Button();
            nudCupo = new NumericUpDown();
            dgvClases = new DataGridView();
            txtNombreClase = new TextBox();
            dgvEquipamiento = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCupo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamiento).BeginInit();
            SuspendLayout();
            // 
            // cboEntrenador
            // 
            cboEntrenador.FormattingEnabled = true;
            cboEntrenador.Location = new Point(23, 60);
            cboEntrenador.Name = "cboEntrenador";
            cboEntrenador.Size = new Size(121, 23);
            cboEntrenador.TabIndex = 0;
            cboEntrenador.Text = "Entrenador";
            // 
            // cboSucursal
            // 
            cboSucursal.FormattingEnabled = true;
            cboSucursal.Location = new Point(23, 12);
            cboSucursal.Name = "cboSucursal";
            cboSucursal.Size = new Size(121, 23);
            cboSucursal.TabIndex = 1;
            cboSucursal.Text = "Sucursal";
            // 
            // dtpHorario
            // 
            dtpHorario.Location = new Point(42, 140);
            dtpHorario.Name = "dtpHorario";
            dtpHorario.Size = new Size(200, 23);
            dtpHorario.TabIndex = 2;
            // 
            // btnCrearClase
            // 
            btnCrearClase.Location = new Point(385, 67);
            btnCrearClase.Name = "btnCrearClase";
            btnCrearClase.Size = new Size(75, 23);
            btnCrearClase.TabIndex = 3;
            btnCrearClase.Text = "Crear clase";
            btnCrearClase.UseVisualStyleBackColor = true;
            btnCrearClase.Click += btnCrearClase_Click;
            // 
            // btnMarcarDefectuoso
            // 
            btnMarcarDefectuoso.Location = new Point(385, 96);
            btnMarcarDefectuoso.Name = "btnMarcarDefectuoso";
            btnMarcarDefectuoso.Size = new Size(75, 23);
            btnMarcarDefectuoso.TabIndex = 4;
            btnMarcarDefectuoso.Text = "Marcar defectuoso";
            btnMarcarDefectuoso.UseVisualStyleBackColor = true;
            btnMarcarDefectuoso.Click += btnMarcarDefectuoso_Click;
            // 
            // nudCupo
            // 
            nudCupo.Location = new Point(120, 273);
            nudCupo.Name = "nudCupo";
            nudCupo.Size = new Size(91, 23);
            nudCupo.TabIndex = 5;
            // 
            // dgvClases
            // 
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClases.Location = new Point(240, 203);
            dgvClases.Name = "dgvClases";
            dgvClases.Size = new Size(267, 235);
            dgvClases.TabIndex = 6;
            // 
            // txtNombreClase
            // 
            txtNombreClase.Location = new Point(42, 203);
            txtNombreClase.Name = "txtNombreClase";
            txtNombreClase.Size = new Size(189, 23);
            txtNombreClase.TabIndex = 7;
            // 
            // dgvEquipamiento
            // 
            dgvEquipamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipamiento.Location = new Point(528, 203);
            dgvEquipamiento.Name = "dgvEquipamiento";
            dgvEquipamiento.Size = new Size(249, 235);
            dgvEquipamiento.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 247);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 9;
            label1.Text = "cupo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 185);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre clase";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(647, 176);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 11;
            label3.Click += label3_Click;
            // 
            // V10GestionClasesInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEquipamiento);
            Controls.Add(txtNombreClase);
            Controls.Add(dgvClases);
            Controls.Add(nudCupo);
            Controls.Add(btnMarcarDefectuoso);
            Controls.Add(btnCrearClase);
            Controls.Add(dtpHorario);
            Controls.Add(cboSucursal);
            Controls.Add(cboEntrenador);
            Name = "V10GestionClasesInventario";
            Text = "V10GestionClasesInventario";
            Load += V10GestionClasesInventarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudCupo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipamiento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboEntrenador;
        private ComboBox cboSucursal;
        private DateTimePicker dtpHorario;
        private Button btnCrearClase;
        private Button btnMarcarDefectuoso;
        private NumericUpDown nudCupo;
        private DataGridView dgvClases;
        private TextBox txtNombreClase;
        private DataGridView dgvEquipamiento;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
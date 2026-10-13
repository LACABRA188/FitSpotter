namespace FitSpotter
{
    partial class V5ReservaClaseForm
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
            cboSucursal1 = new ComboBox();
            dgvClases = new DataGridView();
            btnReservar = new Button();
            btnActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClases).BeginInit();
            SuspendLayout();
            // 
            // cboSucursal1
            // 
            cboSucursal1.FormattingEnabled = true;
            cboSucursal1.Location = new Point(357, 29);
            cboSucursal1.Name = "cboSucursal1";
            cboSucursal1.Size = new Size(121, 23);
            cboSucursal1.TabIndex = 0;
            // 
            // dgvClases
            // 
            dgvClases.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClases.Location = new Point(201, 81);
            dgvClases.Name = "dgvClases";
            dgvClases.Size = new Size(417, 241);
            dgvClases.TabIndex = 1;
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(270, 349);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(75, 23);
            btnReservar.TabIndex = 2;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(490, 349);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // V5ReservaClaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnActualizar);
            Controls.Add(btnReservar);
            Controls.Add(dgvClases);
            Controls.Add(cboSucursal1);
            Name = "V5ReservaClaseForm";
            Text = "V5ReservaClaseForm";
            Load += V5ReservaClasesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClases).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboSucursal1;
        private DataGridView dgvClases;
        private Button btnReservar;
        private Button btnActualizar;
    }
}
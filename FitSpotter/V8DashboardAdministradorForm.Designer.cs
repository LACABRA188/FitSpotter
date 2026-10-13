namespace FitSpotter
{
    partial class V8DashboardAdministradorForm
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
            lblTotalSocios = new Label();
            lblCaja = new Label();
            btnCobrosVentas = new Button();
            lblStockBajo = new Label();
            btnGestionClasesInventario = new Button();
            SuspendLayout();
            // 
            // lblTotalSocios
            // 
            lblTotalSocios.AutoSize = true;
            lblTotalSocios.Location = new Point(134, 33);
            lblTotalSocios.Name = "lblTotalSocios";
            lblTotalSocios.Size = new Size(86, 15);
            lblTotalSocios.TabIndex = 0;
            lblTotalSocios.Text = "Total De Socios";
            lblTotalSocios.Click += label1_Click;
            // 
            // lblCaja
            // 
            lblCaja.AutoSize = true;
            lblCaja.Location = new Point(153, 68);
            lblCaja.Name = "lblCaja";
            lblCaja.Size = new Size(28, 15);
            lblCaja.TabIndex = 1;
            lblCaja.Text = "caja";
            // 
            // btnCobrosVentas
            // 
            btnCobrosVentas.Location = new Point(113, 159);
            btnCobrosVentas.Name = "btnCobrosVentas";
            btnCobrosVentas.Size = new Size(114, 54);
            btnCobrosVentas.TabIndex = 2;
            btnCobrosVentas.Text = "Cobros y ventas";
            btnCobrosVentas.UseVisualStyleBackColor = true;
            btnCobrosVentas.Click += btnCobrosVentas_Click;
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Location = new Point(134, 114);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(62, 15);
            lblStockBajo.TabIndex = 3;
            lblStockBajo.Text = "Stock bajo";
            // 
            // btnGestionClasesInventario
            // 
            btnGestionClasesInventario.Location = new Point(113, 231);
            btnGestionClasesInventario.Name = "btnGestionClasesInventario";
            btnGestionClasesInventario.Size = new Size(131, 43);
            btnGestionClasesInventario.TabIndex = 4;
            btnGestionClasesInventario.Text = "Gestionar clases e inventario";
            btnGestionClasesInventario.UseVisualStyleBackColor = true;
            btnGestionClasesInventario.Click += btnGestionClasesInventario_Click;
            // 
            // V8DashboardAdministradorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 450);
            Controls.Add(btnGestionClasesInventario);
            Controls.Add(lblStockBajo);
            Controls.Add(btnCobrosVentas);
            Controls.Add(lblCaja);
            Controls.Add(lblTotalSocios);
            Name = "V8DashboardAdministradorForm";
            Text = "V8DashboardAdministradorForm";
            Load += V8DashboardAdministradorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotalSocios;
        private Label lblCaja;
        private Button btnCobrosVentas;
        private Label lblStockBajo;
        private Button btnGestionClasesInventario;
    }
}
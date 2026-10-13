namespace FitSpotter
{
    partial class V9CobroFacturacionTiendaForm
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
            cboSuplemento = new ComboBox();
            cboMetodoPago = new ComboBox();
            btnCobrarCuota = new Button();
            btnConfirmarVenta = new Button();
            lblTotal = new Label();
            dgvCarrito = new DataGridView();
            btnAgregarProducto = new Button();
            nudCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // cboSocio
            // 
            cboSocio.FormattingEnabled = true;
            cboSocio.Location = new Point(219, 12);
            cboSocio.Name = "cboSocio";
            cboSocio.Size = new Size(121, 23);
            cboSocio.TabIndex = 0;
            cboSocio.Text = "Socio";
            // 
            // cboSuplemento
            // 
            cboSuplemento.FormattingEnabled = true;
            cboSuplemento.Location = new Point(219, 139);
            cboSuplemento.Name = "cboSuplemento";
            cboSuplemento.Size = new Size(121, 23);
            cboSuplemento.TabIndex = 1;
            cboSuplemento.Text = "Suplemento";
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(219, 75);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(121, 23);
            cboMetodoPago.TabIndex = 2;
            cboMetodoPago.Text = "Metodo de Pago";
            // 
            // btnCobrarCuota
            // 
            btnCobrarCuota.Location = new Point(210, 197);
            btnCobrarCuota.Name = "btnCobrarCuota";
            btnCobrarCuota.Size = new Size(177, 23);
            btnCobrarCuota.TabIndex = 3;
            btnCobrarCuota.Text = "Cobrar cuota";
            btnCobrarCuota.UseVisualStyleBackColor = true;
            btnCobrarCuota.Click += btnCobrarCuota_Click;
            // 
            // btnConfirmarVenta
            // 
            btnConfirmarVenta.Location = new Point(210, 226);
            btnConfirmarVenta.Name = "btnConfirmarVenta";
            btnConfirmarVenta.Size = new Size(353, 23);
            btnConfirmarVenta.TabIndex = 4;
            btnConfirmarVenta.Text = "Confirmar venta";
            btnConfirmarVenta.UseVisualStyleBackColor = true;
            btnConfirmarVenta.Click += btnConfirmarVenta_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(542, 176);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(393, 12);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.Size = new Size(240, 150);
            dgvCarrito.TabIndex = 6;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(420, 197);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(143, 23);
            btnAgregarProducto.TabIndex = 7;
            btnAgregarProducto.Text = "Agregar producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(393, 168);
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(129, 23);
            nudCantidad.TabIndex = 8;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // V9CobroFacturacionTiendaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nudCantidad);
            Controls.Add(btnAgregarProducto);
            Controls.Add(dgvCarrito);
            Controls.Add(lblTotal);
            Controls.Add(btnConfirmarVenta);
            Controls.Add(btnCobrarCuota);
            Controls.Add(cboMetodoPago);
            Controls.Add(cboSuplemento);
            Controls.Add(cboSocio);
            Name = "V9CobroFacturacionTiendaForm";
            Text = "V9CobroFacturacionTiendaForm";
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSocio;
        private ComboBox cboSuplemento;
        private ComboBox cboMetodoPago;
        private Button btnCobrarCuota;
        private Button btnConfirmarVenta;
        private Label lblTotal;
        private DataGridView dgvCarrito;
        private Button btnAgregarProducto;
        private NumericUpDown nudCantidad;
    }
}
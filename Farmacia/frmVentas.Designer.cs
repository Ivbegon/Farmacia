namespace Farmacia
{
    partial class frmVentas
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
        private System.Windows.Forms.ComboBox cmbMedicamento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalleVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtRecibido;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnVerFactura;
        private System.Windows.Forms.Label lblRecibido;

        private void InitializeComponent()
        {
            this.cmbMedicamento = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtRecibido = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnVerFactura = new System.Windows.Forms.Button();
            this.lblRecibido = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();

            this.SuspendLayout();

            // cmbMedicamento
            this.cmbMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbMedicamento.Location = new System.Drawing.Point(20, 20);
            this.cmbMedicamento.Size = new System.Drawing.Size(200, 25);

            // nudCantidad
            this.nudCantidad.Location = new System.Drawing.Point(230, 20);
            this.nudCantidad.Minimum = 1;
            this.nudCantidad.Value = 1;
            this.nudCantidad.Size = new System.Drawing.Size(60, 25);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(300, 20);
            this.btnAgregar.Size = new System.Drawing.Size(100, 25);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // dgvDetalleVenta
            this.dgvDetalleVenta.Location = new System.Drawing.Point(20, 60);
            this.dgvDetalleVenta.Size = new System.Drawing.Size(380, 120);
            this.dgvDetalleVenta.ReadOnly = true;
            this.dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // lblTotal
            this.lblTotal.Location = new System.Drawing.Point(20, 190);
            this.lblTotal.Size = new System.Drawing.Size(200, 25);
            this.lblTotal.Text = "Total: $0.00";

            // lblRecibido
            this.lblRecibido.Location = new System.Drawing.Point(20, 220);
            this.lblRecibido.Text = "Monto recibido:";
            this.lblRecibido.Size = new System.Drawing.Size(120, 25);

            // txtRecibido
            this.txtRecibido.Location = new System.Drawing.Point(140, 220);
            this.txtRecibido.Size = new System.Drawing.Size(100, 25);

            // btnRegistrarVenta
            this.btnRegistrarVenta.Location = new System.Drawing.Point(260, 220);
            this.btnRegistrarVenta.Size = new System.Drawing.Size(140, 25);
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);

            // dgvVentas
            this.dgvVentas.Location = new System.Drawing.Point(20, 260);
            this.dgvVentas.Size = new System.Drawing.Size(500, 150);
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // btnVerFactura
            this.btnVerFactura.Location = new System.Drawing.Point(20, 420);
            this.btnVerFactura.Size = new System.Drawing.Size(150, 25);
            this.btnVerFactura.Text = "Ver Factura";
            this.btnVerFactura.Click += new System.EventHandler(this.btnVerFactura_Click);

            // frmVentas
            this.ClientSize = new System.Drawing.Size(550, 460);
            this.Controls.Add(this.cmbMedicamento);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalleVenta);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRecibido);
            this.Controls.Add(this.txtRecibido);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnVerFactura);
            this.Text = "Gestión de Ventas";

            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private Label lbl_titulo;
        private GroupBox grpBoxBusqueda;
        private Label lbl_medicamento;
        private TextBox txtBusqueda;
        private Button btn_Buscar;
    }
}
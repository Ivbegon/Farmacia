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
            cmbMedicamento = new ComboBox();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            dgvDetalleVenta = new DataGridView();
            lblTotal = new Label();
            txtRecibido = new TextBox();
            btnRegistrarVenta = new Button();
            dgvVentas = new DataGridView();
            btnVerFactura = new Button();
            lblRecibido = new Label();
            groupBox1 = new GroupBox();
            dgvBusqueda = new DataGridView();
            btn_Buscar = new Button();
            txtBox_Busqueda = new TextBox();
            lbl_medicamento = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            SuspendLayout();
            // 
            // cmbMedicamento
            // 
            cmbMedicamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicamento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbMedicamento.Location = new Point(1349, 720);
            cmbMedicamento.Name = "cmbMedicamento";
            cmbMedicamento.Size = new Size(239, 40);
            cmbMedicamento.TabIndex = 0;
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(1071, 51);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(81, 39);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1231, 52);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 38);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleVenta.ColumnHeadersHeight = 34;
            dgvDetalleVenta.Location = new Point(995, 404);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersWidth = 62;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(307, 244);
            dgvDetalleVenta.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(189, 374);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(200, 25);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: $0.00";
            // 
            // txtRecibido
            // 
            txtRecibido.Location = new Point(309, 404);
            txtRecibido.Name = "txtRecibido";
            txtRecibido.Size = new Size(100, 31);
            txtRecibido.TabIndex = 6;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Location = new Point(429, 404);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(140, 34);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.ColumnHeadersHeight = 34;
            dgvVentas.Location = new Point(189, 444);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersWidth = 62;
            dgvVentas.Size = new Size(500, 150);
            dgvVentas.TabIndex = 8;
            // 
            // btnVerFactura
            // 
            btnVerFactura.Location = new Point(189, 604);
            btnVerFactura.Name = "btnVerFactura";
            btnVerFactura.Size = new Size(150, 49);
            btnVerFactura.TabIndex = 9;
            btnVerFactura.Text = "Ver Factura";
            btnVerFactura.Click += btnVerFactura_Click;
            // 
            // lblRecibido
            // 
            lblRecibido.Location = new Point(189, 404);
            lblRecibido.Name = "lblRecibido";
            lblRecibido.Size = new Size(120, 25);
            lblRecibido.TabIndex = 5;
            lblRecibido.Text = "Monto recibido:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBusqueda);
            groupBox1.Controls.Add(btn_Buscar);
            groupBox1.Controls.Add(txtBox_Busqueda);
            groupBox1.Controls.Add(lbl_medicamento);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 359);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscador de medicamentos";
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBusqueda.ColumnHeadersHeight = 34;
            dgvBusqueda.Location = new Point(13, 81);
            dgvBusqueda.Margin = new Padding(10);
            dgvBusqueda.MultiSelect = false;
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.ReadOnly = true;
            dgvBusqueda.RowHeadersWidth = 62;
            dgvBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBusqueda.Size = new Size(855, 255);
            dgvBusqueda.TabIndex = 11;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(652, 34);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(112, 34);
            btn_Buscar.TabIndex = 2;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txtBox_Busqueda
            // 
            txtBox_Busqueda.Location = new Point(156, 36);
            txtBox_Busqueda.Name = "txtBox_Busqueda";
            txtBox_Busqueda.PlaceholderText = "Busca medicamentos ...";
            txtBox_Busqueda.Size = new Size(469, 31);
            txtBox_Busqueda.TabIndex = 1;
            // 
            // lbl_medicamento
            // 
            lbl_medicamento.AutoSize = true;
            lbl_medicamento.Location = new Point(6, 39);
            lbl_medicamento.Name = "lbl_medicamento";
            lbl_medicamento.Size = new Size(130, 25);
            lbl_medicamento.TabIndex = 0;
            lbl_medicamento.Text = "Medicamento :";
            // 
            // frmVentas
            // 
            ClientSize = new Size(1647, 835);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(groupBox1);
            Controls.Add(btnAgregar);
            Controls.Add(cmbMedicamento);
            Controls.Add(nudCantidad);
            Controls.Add(lblTotal);
            Controls.Add(lblRecibido);
            Controls.Add(txtRecibido);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(dgvVentas);
            Controls.Add(btnVerFactura);
            Name = "frmVentas";
            Text = "Gestión de Ventas";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lbl_titulo;
        private GroupBox grpBoxBusqueda;
        private Label lbl_medicamento;
        private TextBox txtBusqueda;
        private Button btn_Buscar;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvBusqueda;
        private TextBox txtBox_Busqueda;
    }
}
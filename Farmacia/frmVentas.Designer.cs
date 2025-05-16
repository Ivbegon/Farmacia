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
        private System.Windows.Forms.DataGridView dgvDetalleVenta;

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            dgvDetalleVenta = new DataGridView();
            groupBox1 = new GroupBox();
            dgvBusqueda = new DataGridView();
            label1 = new Label();
            nudCantidad = new NumericUpDown();
            btnAgregar = new Button();
            btn_Buscar = new Button();
            txtBox_Busqueda = new TextBox();
            lbl_medicamento = new Label();
            lblTotal = new Label();
            btnRegistrarVenta = new Button();
            lblRecibido = new Label();
            groupBox_Ventas = new GroupBox();
            groupBoxCobro = new GroupBox();
            lblCambio = new Label();
            numBox_Cambio = new NumericUpDown();
            butt_Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            groupBox_Ventas.SuspendLayout();
            groupBoxCobro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBox_Cambio).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvDetalleVenta.ColumnHeadersHeight = 34;
            dgvDetalleVenta.Location = new Point(23, 47);
            dgvDetalleVenta.Margin = new Padding(20);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersWidth = 62;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(1211, 270);
            dgvDetalleVenta.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvBusqueda);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nudCantidad);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btn_Buscar);
            groupBox1.Controls.Add(txtBox_Busqueda);
            groupBox1.Controls.Add(lbl_medicamento);
            groupBox1.Location = new Point(30, 30);
            groupBox1.Margin = new Padding(15);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(20);
            groupBox1.Size = new Size(1438, 359);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscador de medicamentos";
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBusqueda.ColumnHeadersHeight = 34;
            dgvBusqueda.Location = new Point(29, 100);
            dgvBusqueda.Margin = new Padding(10);
            dgvBusqueda.MultiSelect = false;
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.ReadOnly = true;
            dgvBusqueda.RowHeadersWidth = 62;
            dgvBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBusqueda.Size = new Size(1379, 229);
            dgvBusqueda.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(827, 49);
            label1.Name = "label1";
            label1.Size = new Size(315, 32);
            label1.TabIndex = 11;
            label1.Text = "Cantidad del medicamento :";
            // 
            // nudCantidad
            // 
            nudCantidad.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(1158, 49);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(99, 37);
            nudCantidad.TabIndex = 1;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(1293, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 38);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(686, 45);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(112, 36);
            btn_Buscar.TabIndex = 2;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txtBox_Busqueda
            // 
            txtBox_Busqueda.Location = new Point(193, 44);
            txtBox_Busqueda.Name = "txtBox_Busqueda";
            txtBox_Busqueda.PlaceholderText = "Busca medicamentos ...";
            txtBox_Busqueda.Size = new Size(469, 37);
            txtBox_Busqueda.TabIndex = 1;
            // 
            // lbl_medicamento
            // 
            lbl_medicamento.AutoSize = true;
            lbl_medicamento.Location = new Point(29, 49);
            lbl_medicamento.Name = "lbl_medicamento";
            lbl_medicamento.Size = new Size(158, 30);
            lbl_medicamento.TabIndex = 0;
            lbl_medicamento.Text = "Medicamento :";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(18, 44);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(348, 52);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total: $0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarVenta.Location = new Point(1651, 454);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(183, 61);
            btnRegistrarVenta.TabIndex = 7;
            btnRegistrarVenta.Text = "Registrar Venta";
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
            // 
            // lblRecibido
            // 
            lblRecibido.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecibido.Location = new Point(18, 100);
            lblRecibido.Name = "lblRecibido";
            lblRecibido.Size = new Size(120, 40);
            lblRecibido.TabIndex = 5;
            lblRecibido.Text = "Recibido :";
            lblRecibido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox_Ventas
            // 
            groupBox_Ventas.Controls.Add(dgvDetalleVenta);
            groupBox_Ventas.Location = new Point(30, 407);
            groupBox_Ventas.Name = "groupBox_Ventas";
            groupBox_Ventas.Size = new Size(1257, 340);
            groupBox_Ventas.TabIndex = 12;
            groupBox_Ventas.TabStop = false;
            groupBox_Ventas.Text = "Medicamentos Ingresados";
            // 
            // groupBoxCobro
            // 
            groupBoxCobro.Controls.Add(lblCambio);
            groupBoxCobro.Controls.Add(numBox_Cambio);
            groupBoxCobro.Controls.Add(lblTotal);
            groupBoxCobro.Controls.Add(lblRecibido);
            groupBoxCobro.Location = new Point(1537, 30);
            groupBoxCobro.Name = "groupBoxCobro";
            groupBoxCobro.Padding = new Padding(15);
            groupBoxCobro.Size = new Size(406, 359);
            groupBoxCobro.TabIndex = 13;
            groupBoxCobro.TabStop = false;
            groupBoxCobro.Text = "Cobro";
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCambio.Location = new Point(18, 152);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(148, 45);
            lblCambio.TabIndex = 7;
            lblCambio.Text = "Cambio :";
            // 
            // numBox_Cambio
            // 
            numBox_Cambio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numBox_Cambio.Location = new Point(144, 102);
            numBox_Cambio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numBox_Cambio.Name = "numBox_Cambio";
            numBox_Cambio.Size = new Size(222, 39);
            numBox_Cambio.TabIndex = 6;
            numBox_Cambio.ValueChanged += numBox_Cambio_ValueChanged;
            // 
            // butt_Cancelar
            // 
            butt_Cancelar.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            butt_Cancelar.Location = new Point(1651, 569);
            butt_Cancelar.Name = "butt_Cancelar";
            butt_Cancelar.Size = new Size(183, 64);
            butt_Cancelar.TabIndex = 14;
            butt_Cancelar.Text = "Cancelar";
            butt_Cancelar.UseVisualStyleBackColor = true;
            butt_Cancelar.Click += butt_Cancelar_Click;
            // 
            // frmVentas
            // 
            ClientSize = new Size(1986, 835);
            Controls.Add(butt_Cancelar);
            Controls.Add(groupBoxCobro);
            Controls.Add(btnRegistrarVenta);
            Controls.Add(groupBox_Ventas);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "frmVentas";
            Padding = new Padding(15);
            Text = "Gestión de Ventas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            groupBox_Ventas.ResumeLayout(false);
            groupBoxCobro.ResumeLayout(false);
            groupBoxCobro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBox_Cambio).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Label lbl_titulo;
        private GroupBox grpBoxBusqueda;
        private Label lbl_medicamento;
        private TextBox txtBusqueda;
        private Button btn_Buscar;
        private GroupBox groupBox1;
        private DataGridView dgvBusqueda;
        private TextBox txtBox_Busqueda;
        private Label label1;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private Label lblTotal;
        private Button btnRegistrarVenta;
        private Label lblRecibido;
        private GroupBox groupBox_Ventas;
        private GroupBox groupBoxCobro;
        private NumericUpDown numBox_Cambio;
        private Label lblCambio;
        private Button butt_Cancelar;
    }
}
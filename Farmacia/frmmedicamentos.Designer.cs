namespace Farmacia
{
    partial class frmMedicamentos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox chkReceta;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.Label lblProveedor;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvMedicamentos = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            chkReceta = new CheckBox();
            dtpVencimiento = new DateTimePicker();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            lblVencimiento = new Label();
            lblReceta = new Label();
            lblProveedor = new Label();
            cmbProveedores = new ComboBox();
            numBox_Cantidad = new NumericUpDown();
            numBox_Precio = new NumericUpDown();
            groupDatos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Precio).BeginInit();
            groupDatos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 255, 250);
            dgvMedicamentos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMedicamentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMedicamentos.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMedicamentos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMedicamentos.EnableHeadersVisualStyles = false;
            dgvMedicamentos.Location = new Point(542, 12);
            dgvMedicamentos.MultiSelect = false;
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.RowTemplate.Height = 35;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.Size = new Size(1109, 410);
            dgvMedicamentos.TabIndex = 19;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 34);
            txtNombre.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(150, 68);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 34);
            txtDescripcion.TabIndex = 3;
            // 
            // chkReceta
            // 
            chkReceta.Location = new Point(150, 228);
            chkReceta.Name = "chkReceta";
            chkReceta.Size = new Size(104, 24);
            chkReceta.TabIndex = 11;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(150, 188);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(320, 34);
            dtpVencimiento.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(20, 340);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(46, 204, 113);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(140, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(260, 340);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(20, 70);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 23);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(20, 110);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 23);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(20, 150);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 23);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblVencimiento
            // 
            lblVencimiento.Location = new Point(20, 190);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(100, 23);
            lblVencimiento.TabIndex = 8;
            lblVencimiento.Text = "Fecha Venc:";
            // 
            // lblReceta
            // 
            lblReceta.Location = new Point(20, 230);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(100, 23);
            lblReceta.TabIndex = 10;
            lblReceta.Text = "Requiere receta:";
            // 
            // lblProveedor
            // 
            lblProveedor.Location = new Point(20, 270);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(100, 23);
            lblProveedor.TabIndex = 12;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedores
            // 
            cmbProveedores.Location = new Point(150, 268);
            cmbProveedores.Name = "cmbProveedores";
            cmbProveedores.Size = new Size(200, 36);
            cmbProveedores.TabIndex = 13;
            // 
            // numBox_Cantidad
            // 
            numBox_Cantidad.Location = new Point(150, 148);
            numBox_Cantidad.Name = "numBox_Cantidad";
            numBox_Cantidad.Size = new Size(320, 34);
            numBox_Cantidad.TabIndex = 7;
            // 
            // numBox_Precio
            // 
            numBox_Precio.DecimalPlaces = 2;
            numBox_Precio.Location = new Point(150, 108);
            numBox_Precio.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numBox_Precio.Name = "numBox_Precio";
            numBox_Precio.Size = new Size(320, 34);
            numBox_Precio.TabIndex = 5;
            // 
            // groupDatos
            // 
            groupDatos.BackColor = Color.FromArgb(240, 255, 240);
            groupDatos.Controls.Add(lblNombre);
            groupDatos.Controls.Add(txtNombre);
            groupDatos.Controls.Add(lblDescripcion);
            groupDatos.Controls.Add(txtDescripcion);
            groupDatos.Controls.Add(lblPrecio);
            groupDatos.Controls.Add(numBox_Precio);
            groupDatos.Controls.Add(lblCantidad);
            groupDatos.Controls.Add(numBox_Cantidad);
            groupDatos.Controls.Add(lblVencimiento);
            groupDatos.Controls.Add(dtpVencimiento);
            groupDatos.Controls.Add(lblReceta);
            groupDatos.Controls.Add(chkReceta);
            groupDatos.Controls.Add(lblProveedor);
            groupDatos.Controls.Add(cmbProveedores);
            groupDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupDatos.Location = new Point(20, 12);
            groupDatos.Name = "groupDatos";
            groupDatos.Size = new Size(500, 310);
            groupDatos.TabIndex = 0;
            groupDatos.TabStop = false;
            groupDatos.Text = "Datos del Medicamento";
            // 
            // frmMedicamentos
            // 
            BackColor = Color.White;
            ClientSize = new Size(1687, 513);
            Controls.Add(groupDatos);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMedicamentos);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMedicamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Medicamentos";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Precio).EndInit();
            groupDatos.ResumeLayout(false);
            groupDatos.PerformLayout();
            ResumeLayout(false);
        }


        private ComboBox cmbProveedores;
        private NumericUpDown numBox_Cantidad;
        private NumericUpDown numBox_Precio;
        private GroupBox groupDatos;
    }
}

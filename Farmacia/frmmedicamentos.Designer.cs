namespace Farmacia
{
    partial class frmMedicamentos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
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
            dgvMedicamentos = new DataGridView();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
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
            cmb_Proveedores = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.ColumnHeadersHeight = 29;
            dgvMedicamentos.Location = new Point(542, 12);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.Size = new Size(686, 410);
            dgvMedicamentos.TabIndex = 19;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 31);
            txtNombre.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(151, 63);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(320, 31);
            txtDescripcion.TabIndex = 5;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(151, 103);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(320, 31);
            txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(151, 143);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(320, 31);
            txtCantidad.TabIndex = 9;
            // 
            // chkReceta
            // 
            chkReceta.Location = new Point(151, 223);
            chkReceta.Name = "chkReceta";
            chkReceta.Size = new Size(104, 24);
            chkReceta.TabIndex = 13;
            // 
            // dtpVencimiento
            // 
            dtpVencimiento.Location = new Point(151, 183);
            dtpVencimiento.Name = "dtpVencimiento";
            dtpVencimiento.Size = new Size(320, 31);
            dtpVencimiento.TabIndex = 11;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(20, 340);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(197, 340);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 35);
            btnEditar.TabIndex = 17;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(365, 340);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(95, 35);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 26);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(20, 66);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 23);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(20, 106);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 23);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(20, 146);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(100, 23);
            lblCantidad.TabIndex = 8;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblVencimiento
            // 
            lblVencimiento.Location = new Point(20, 186);
            lblVencimiento.Name = "lblVencimiento";
            lblVencimiento.Size = new Size(100, 23);
            lblVencimiento.TabIndex = 10;
            lblVencimiento.Text = "Fecha Venc:";
            // 
            // lblReceta
            // 
            lblReceta.Location = new Point(20, 226);
            lblReceta.Name = "lblReceta";
            lblReceta.Size = new Size(100, 23);
            lblReceta.TabIndex = 12;
            lblReceta.Text = "Requiere receta:";
            // 
            // lblProveedor
            // 
            lblProveedor.Location = new Point(20, 266);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(127, 31);
            lblProveedor.TabIndex = 14;
            lblProveedor.Text = "ID Proveedor:";
            // 
            // cmb_Proveedores
            // 
            cmb_Proveedores.FormattingEnabled = true;
            cmb_Proveedores.Location = new Point(153, 263);
            cmb_Proveedores.Name = "cmb_Proveedores";
            cmb_Proveedores.Size = new Size(318, 33);
            cmb_Proveedores.TabIndex = 20;
            // 
            // frmMedicamentos
            // 
            ClientSize = new Size(1257, 492);
            Controls.Add(cmb_Proveedores);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtCantidad);
            Controls.Add(lblVencimiento);
            Controls.Add(dtpVencimiento);
            Controls.Add(lblReceta);
            Controls.Add(chkReceta);
            Controls.Add(lblProveedor);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMedicamentos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMedicamentos";
            Text = "Gestión de Medicamentos";
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private ComboBox cmb_Proveedores;
    }
}

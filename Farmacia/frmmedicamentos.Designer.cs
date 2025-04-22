namespace Farmacia
{
    partial class frmMedicamentos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProveedorId;
        private System.Windows.Forms.CheckBox chkReceta;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblId;
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
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProveedorId = new System.Windows.Forms.TextBox();
            this.chkReceta = new System.Windows.Forms.CheckBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblReceta = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.SuspendLayout();

            this.lblId.Text = "ID:";
            this.lblId.Location = new System.Drawing.Point(20, 20);
            this.txtId.Location = new System.Drawing.Point(120, 20);
            this.txtId.ReadOnly = true;

            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(20, 60);
            this.txtNombre.Location = new System.Drawing.Point(120, 60);

            this.lblDescripcion.Text = "Descripción:";
            this.lblDescripcion.Location = new System.Drawing.Point(20, 100);
            this.txtDescripcion.Location = new System.Drawing.Point(120, 100);

            this.lblPrecio.Text = "Precio:";
            this.lblPrecio.Location = new System.Drawing.Point(20, 140);
            this.txtPrecio.Location = new System.Drawing.Point(120, 140);

            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.Location = new System.Drawing.Point(20, 180);
            this.txtCantidad.Location = new System.Drawing.Point(120, 180);

            this.lblVencimiento.Text = "Fecha Venc:";
            this.lblVencimiento.Location = new System.Drawing.Point(20, 220);
            this.dtpVencimiento.Location = new System.Drawing.Point(120, 220);

            this.lblReceta.Text = "Requiere receta:";
            this.lblReceta.Location = new System.Drawing.Point(20, 260);
            this.chkReceta.Location = new System.Drawing.Point(120, 260);

            this.lblProveedor.Text = "ID Proveedor:";
            this.lblProveedor.Location = new System.Drawing.Point(20, 300);
            this.txtProveedorId.Location = new System.Drawing.Point(120, 300);

            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Location = new System.Drawing.Point(20, 340);
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            this.btnEditar.Text = "Editar";
            this.btnEditar.Location = new System.Drawing.Point(120, 340);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Location = new System.Drawing.Point(220, 340);
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.dgvMedicamentos.Location = new System.Drawing.Point(350, 20);
            this.dgvMedicamentos.Size = new System.Drawing.Size(600, 320);
            this.dgvMedicamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellClick);

            this.ClientSize = new System.Drawing.Size(980, 400);
            this.Controls.AddRange(new Control[] {
                lblId, txtId,
                lblNombre, txtNombre,
                lblDescripcion, txtDescripcion,
                lblPrecio, txtPrecio,
                lblCantidad, txtCantidad,
                lblVencimiento, dtpVencimiento,
                lblReceta, chkReceta,
                lblProveedor, txtProveedorId,
                btnAgregar, btnEditar, btnEliminar,
                dgvMedicamentos
            });

            this.Text = "Gestión de Medicamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

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
            GroupBox groupDatos = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Cantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Precio).BeginInit();
            SuspendLayout();

            // FORM
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1687, 513);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmMedicamentos";
            Text = "Gestión de Medicamentos";

            // GROUPBOX
            groupDatos.Text = "Datos del Medicamento";
            groupDatos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupDatos.Size = new Size(500, 310);
            groupDatos.Location = new Point(20, 12);

            // LABELS & CONTROLS
            lblNombre.Text = "Nombre:";
            lblNombre.Location = new Point(20, 30);
            txtNombre.Location = new Point(150, 28);
            txtNombre.Size = new Size(320, 31);

            lblDescripcion.Text = "Descripción:";
            lblDescripcion.Location = new Point(20, 70);
            txtDescripcion.Location = new Point(150, 68);
            txtDescripcion.Size = new Size(320, 31);

            lblPrecio.Text = "Precio:";
            lblPrecio.Location = new Point(20, 110);
            numBox_Precio.Location = new Point(150, 108);
            numBox_Precio.DecimalPlaces = 2;
            numBox_Precio.Maximum = 1000;
            numBox_Precio.Size = new Size(320, 31);

            lblCantidad.Text = "Cantidad:";
            lblCantidad.Location = new Point(20, 150);
            numBox_Cantidad.Location = new Point(150, 148);
            numBox_Cantidad.Size = new Size(320, 31);

            lblVencimiento.Text = "Fecha Venc:";
            lblVencimiento.Location = new Point(20, 190);
            dtpVencimiento.Location = new Point(150, 188);
            dtpVencimiento.Size = new Size(320, 31);

            lblReceta.Text = "Requiere receta:";
            lblReceta.Location = new Point(20, 230);
            chkReceta.Location = new Point(150, 228);

            lblProveedor.Text = "ID Proveedor:";
            lblProveedor.Location = new Point(20, 270);
            cmbProveedores.Location = new Point(150, 268);
            cmbProveedores.Size = new Size(200, 33);

            // BOTONES
            btnAgregar.Text = "Agregar";
            btnAgregar.Location = new Point(20, 340);
            btnAgregar.Size = new Size(100, 35);
            btnAgregar.Click += btnAgregar_Click;

            btnEditar.Text = "Editar";
            btnEditar.Location = new Point(140, 340);
            btnEditar.Size = new Size(100, 35);
            btnEditar.Click += btnEditar_Click;

            btnEliminar.Text = "Eliminar";
            btnEliminar.Location = new Point(260, 340);
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.Click += btnEliminar_Click;

            // DATAGRIDVIEW
            dgvMedicamentos.Location = new Point(542, 12);
            dgvMedicamentos.Size = new Size(1109, 410);
            dgvMedicamentos.ReadOnly = true;
            dgvMedicamentos.MultiSelect = false;
            dgvMedicamentos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMedicamentos.ColumnHeadersHeight = 29;
            dgvMedicamentos.RowHeadersWidth = 51;
            dgvMedicamentos.TabIndex = 19;
            dgvMedicamentos.CellClick += dgvMedicamentos_CellClick;

            dgvMedicamentos.EnableHeadersVisualStyles = false;
            dgvMedicamentos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 149, 237);
            dgvMedicamentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvMedicamentos.DefaultCellStyle.BackColor = Color.White;
            dgvMedicamentos.DefaultCellStyle.ForeColor = Color.Black;
            dgvMedicamentos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvMedicamentos.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dgvMedicamentos.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvMedicamentos.RowTemplate.Height = 35;

            // ADD CONTROLS TO GROUPBOX
            groupDatos.Controls.AddRange(new Control[]
            {
                lblNombre, txtNombre,
                lblDescripcion, txtDescripcion,
                lblPrecio, numBox_Precio,
                lblCantidad, numBox_Cantidad,
                lblVencimiento, dtpVencimiento,
                lblReceta, chkReceta,
                lblProveedor, cmbProveedores
            });

            // ADD TO FORM
            Controls.Add(groupDatos);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvMedicamentos);

            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Cantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBox_Precio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cmbProveedores;
        private NumericUpDown numBox_Cantidad;
        private NumericUpDown numBox_Precio;
    }
}

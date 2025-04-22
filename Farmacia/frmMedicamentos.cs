using Negocio.Medicamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;

namespace Farmacia
{
    public partial class frmMedicamentos : Form
    {
        private MedicamentosNegocio _medicamentosNegocio;

        public frmMedicamentos()
        {
            InitializeComponent();
            _medicamentosNegocio = new MedicamentosNegocio();
            CargarMedicamentos();
        }

        private void CargarMedicamentos()
        {
            dgvMedicamentos.DataSource = _medicamentosNegocio.ListarMedicamentos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Medicamento med = new Medicamento
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                FechaVencimiento = dtpVencimiento.Value,
                RequiereReceta = chkReceta.Checked,
                IdProveedor = int.Parse(txtProveedorId.Text)
            };

            _medicamentosNegocio.CrearMedicamento(med);
            CargarMedicamentos();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Medicamento med = new Medicamento
            {
                IdMedicamento = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                FechaVencimiento = dtpVencimiento.Value,
                RequiereReceta = chkReceta.Checked,
                IdProveedor = int.Parse(txtProveedorId.Text)
            };

            _medicamentosNegocio.ActualizarMedicamento(med);
            CargarMedicamentos();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _medicamentosNegocio.EliminarMedicamento(id);  
            CargarMedicamentos();
            Limpiar();
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];

                txtId.Text = row.Cells["IdMedicamento"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                dtpVencimiento.Value = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value);
                chkReceta.Checked = Convert.ToBoolean(row.Cells["RequiereReceta"].Value);
                txtProveedorId.Text = row.Cells["IdProveedor"].Value.ToString();
            }
        }

        private void Limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtProveedorId.Clear();
            chkReceta.Checked = false;
        }
    }
}

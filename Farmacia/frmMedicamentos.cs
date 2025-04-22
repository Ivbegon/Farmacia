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
            CargarProveedores();
        }

        private void CargarMedicamentos()
        {
            dgvMedicamentos.DataSource = _medicamentosNegocio.ListarMedicamentos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            int idProveedor = (int)cmbProveedores.SelectedValue;

            Medicamento med = new Medicamento
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Cantidad = int.Parse(txtCantidad.Text),
                FechaVencimiento = dtpVencimiento.Value,
                RequiereReceta = chkReceta.Checked,
                IdProveedor = idProveedor
            };

            _medicamentosNegocio.CrearMedicamento(med);
            CargarMedicamentos();
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedicamentos.SelectedRows[0].Cells["Id"].Value);
                int idProveedor = (int)cmbProveedores.SelectedValue;

                Medicamento med = new Medicamento
                {
                    IdMedicamento = id,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = decimal.Parse(txtPrecio.Text),
                    Cantidad = int.Parse(txtCantidad.Text),
                    FechaVencimiento = dtpVencimiento.Value,
                    RequiereReceta = chkReceta.Checked,
                    IdProveedor = idProveedor
                };

                _medicamentosNegocio.ActualizarMedicamento(med);
                CargarMedicamentos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un medicamento para editar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedicamentos.SelectedRows[0].Cells["Id"].Value);


                _medicamentosNegocio.EliminarMedicamento(id);

                CargarMedicamentos();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un medicamento para eliminar.");
            }
        }

        private void dgvMedicamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvMedicamentos.Rows[e.RowIndex];

                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value.ToString();
                txtCantidad.Text = row.Cells["Cantidad"].Value.ToString();
                dtpVencimiento.Value = Convert.ToDateTime(row.Cells["FechaVencimiento"].Value);
                chkReceta.Checked = Convert.ToBoolean(row.Cells["RequiereReceta"].Value);
                cmbProveedores.SelectedValue = Convert.ToInt32(row.Cells["IdProveedor"].Value);
            }
        }

        private void CargarProveedores()
        {
            List<Proveedor> proveedores = _medicamentosNegocio.ListarProveedores();
            cmbProveedores.DataSource = proveedores;
            cmbProveedores.DisplayMember = "Nombre";
            cmbProveedores.ValueMember = "IdProveedor";
        }


        private void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cmbProveedores.SelectedIndex = -1;
            chkReceta.Checked = false;
        }
    }
}

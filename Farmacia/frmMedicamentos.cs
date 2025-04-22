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
using System.Windows.Forms.VisualStyles;
using System.Globalization;

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
                Precio = numBox_Precio.Value,
                Cantidad = (int)numBox_Cantidad.Value,
                FechaVencimiento = dtpVencimiento.Value,
                RequiereReceta = chkReceta.Checked,
                IdProveedor = idProveedor
            };

            try
            {
                _medicamentosNegocio.CrearMedicamento(med);
                CargarMedicamentos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al agregar medicamento");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMedicamentos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMedicamentos.SelectedRows[0]
                    .Cells["idMedicamento"].Value);

                int idProveedor = (int)cmbProveedores.SelectedValue;

                Medicamento med = new Medicamento
                {
                    IdMedicamento = id,
                    Nombre = txtNombre.Text,
                    Descripcion = txtDescripcion.Text,
                    Precio = numBox_Precio.Value,
                    Cantidad = (int)numBox_Cantidad.Value,
                    FechaVencimiento = dtpVencimiento.Value,
                    RequiereReceta = chkReceta.Checked,
                    IdProveedor = idProveedor
                };

                try
                {
                    _medicamentosNegocio.ActualizarMedicamento(med);
                    CargarMedicamentos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al agregar medicamento");
                }

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
                int id = Convert.ToInt32(dgvMedicamentos.SelectedRows[0]
                     .Cells["idMedicamento"].Value);

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
                numBox_Precio.Value = decimal.Parse(row.Cells["Precio"].Value.ToString());
                numBox_Cantidad.Value = int.Parse(row.Cells["Cantidad"].Value.ToString());
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
            if (proveedores.Count > 0)
                cmbProveedores.SelectedIndex = 0;
        }


        private void Limpiar()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            numBox_Precio.Value = 0;
            numBox_Cantidad.Value = 0;

            if (cmbProveedores.Items.Count > 0)
                cmbProveedores.SelectedIndex = 0;
            else
                cmbProveedores.SelectedIndex = -1;
            
            chkReceta.Checked = false;
        }
    }
}

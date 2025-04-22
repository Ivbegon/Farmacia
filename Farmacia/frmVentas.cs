using entidades;
using Negocio.Medicamentos;
using Negocio.Ventas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia
{
    public partial class frmVentas : Form
    {
        private List<DetalleVenta> detalles = new List<DetalleVenta>();
        private VentasNegocio ventasNegocio = new VentasNegocio();
        private MedicamentosNegocio medicamentosNegocio = new MedicamentosNegocio();

        public frmVentas()
        {
            InitializeComponent();
            CargarMedicamentos();
            ListarVentas();
        }

        private void CargarMedicamentos()
        {
            var medicamentos = medicamentosNegocio.ListarMedicamentos();
            cmbMedicamento.DataSource = medicamentos;
            cmbMedicamento.DisplayMember = "Nombre";
            cmbMedicamento.ValueMember = "IdMedicamento";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var seleccionado = (Medicamento)cmbMedicamento.SelectedItem;
            int cantidad = (int)nudCantidad.Value;

            if (cantidad > seleccionado.Cantidad)
            {
                MessageBox.Show("No hay suficiente stock.");
                return;
            }

            detalles.Add(new DetalleVenta
            {
                IdMedicamento = seleccionado.IdMedicamento,
                Cantidad = cantidad
            });

            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = detalles;
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (var det in detalles)
            {
                var med = medicamentosNegocio.ObtenerMedicamento(det.IdMedicamento);
                total += med.Precio * det.Cantidad;
            }
            lblTotal.Text = $"Total: {total:C}";
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            decimal montoRecibido = decimal.Parse(txtRecibido.Text);
            decimal total = detalles.Sum(d =>
            {
                var med = medicamentosNegocio.ObtenerMedicamento(d.IdMedicamento);
                return med.Precio * d.Cantidad;
            });

            Venta venta = new Venta
            {
                IdEmpleado = 1,
                Vuelto = montoRecibido,
                Total = total
            };

            int idVenta = ventasNegocio.RegistrarVenta(venta, detalles);
            MessageBox.Show($"Venta registrada con ID {idVenta}");
            detalles.Clear();
            dgvDetalleVenta.DataSource = null;
            ListarVentas();
        }

        private void ListarVentas()
        {
            dgvVentas.DataSource = ventasNegocio.ListarVentas();
        }

        private void btnVerFactura_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow != null)
            {
                int idVenta = (int)dgvVentas.CurrentRow.Cells["IdVenta"].Value;
                var venta = ventasNegocio.ObtenerVenta(idVenta);
                MessageBox.Show($"Factura de Venta {idVenta}:\nTotal: {venta.Total:C}\nVuelto: {venta.Vuelto:C}");
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBox_Busqueda.Text;

            if (busqueda.Equals(""))
                dgvBusqueda.DataSource = medicamentosNegocio.ListarMedicamentos();
            else
                dgvBusqueda.DataSource = medicamentosNegocio.BuscarMedicamentos(busqueda);
        }
    }

}

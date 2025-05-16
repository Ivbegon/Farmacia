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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int cantidad = (int)nudCantidad.Value;

            if (dgvBusqueda.SelectedRows.Count > 0)
            {
                Medicamento seleccionado = (Medicamento)dgvBusqueda.SelectedRows[0].DataBoundItem;
                int id_medicamento = seleccionado.IdMedicamento;

                if (cantidad > seleccionado.Cantidad)
                {
                    MessageBox.Show("No hay suficiente stock.");
                    return;
                }

                DetalleVenta detalleFind =
                    detalles.Find(m => m.id_medicamento == seleccionado.IdMedicamento);

                if (detalleFind == null)
                {
                    detalles.Add(new DetalleVenta
                    {
                        id_medicamento = seleccionado.IdMedicamento,
                        cantidad = cantidad
                    });
                }
                else
                {
                    if (detalleFind.cantidad + cantidad > seleccionado.Cantidad)
                    {
                        MessageBox.Show("No hay suficiente stock.");
                        return;
                    }
                    detalles[detalles.IndexOf(detalleFind)].cantidad += cantidad;
                }

                dgvDetalleVenta.DataSource = null;
                FormatearTabla();

                CalcularTotal();
            }
            else
            {
                MessageBox.Show("Seleccione un medicamento.");
            }
        }

        private void FormatearTabla()
        {
            dgvDetalleVenta.Columns.Clear();

            dgvDetalleVenta.Columns.Add("NombreProducto", "Nombre Producto");
            dgvDetalleVenta.Columns.Add("Descripcion", "Descripción");
            dgvDetalleVenta.Columns.Add("cantidad", "cantidad");
            dgvDetalleVenta.Columns.Add("Costo", "Costo");

            detalles.ForEach(d =>
            {
                Medicamento med =
                    medicamentosNegocio.ObtenerMedicamento(d.id_medicamento);
                decimal costo = med.Precio * d.cantidad;
                dgvDetalleVenta.Rows
                    .Add(med.Nombre, med.Descripcion, med.Cantidad, costo);
            });
        }

        private void CalcularTotal()
        {
            decimal total = 0;
            foreach (var det in detalles)
            {
                var med = medicamentosNegocio.ObtenerMedicamento(det.id_medicamento);
                total += med.Precio * det.cantidad;
            }
            lblTotal.Text = $"Total: {total:C}";
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                decimal montoRecibido = numBox_Cambio.Value;
                decimal total = detalles.Sum(d =>
                {
                    var med = medicamentosNegocio.ObtenerMedicamento(d.id_medicamento);
                    return med.Precio * d.cantidad;
                });

                Venta venta = new Venta
                {
                    IdEmpleado = 1,
                    Vuelto = montoRecibido,
                    Total = total
                };

                detalles.ForEach(d =>
                {
                    MessageBox.Show(d.id_medicamento.ToString(), "Id");
                });


                int idVenta = ventasNegocio.RegistrarVenta(venta, detalles);
                MessageBox.Show($"Venta registrada con ID {idVenta}");
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al reguistrar la venta");
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

        private void numBox_Cambio_ValueChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (var det in detalles)
            {
                var med = medicamentosNegocio.ObtenerMedicamento(det.id_medicamento);
                total += med.Precio * det.cantidad;
            }
            decimal cambio = numBox_Cambio.Value - total;

            if (cambio >= 0)
            {
                lblCambio.Text = $"Cambio: {cambio:C2}";
            }
            else
            {
                cambio = cambio * -1;
                MessageBox.Show($"Todavía falta {cambio:C2}", "Faltan");
            }
        }

        private void butt_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            detalles.Clear();

            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.Rows.Clear();
            dgvDetalleVenta.Columns.Clear();

            txtBox_Busqueda.Text = string.Empty;
            dgvBusqueda.DataSource = null;

            nudCantidad.Value = nudCantidad.Minimum;
            numBox_Cambio.Value = 0;

            lblTotal.Text = "Total: $0.00";
            lblCambio.Text = "Cambio: $0.00";

            dgvBusqueda.DataSource = medicamentosNegocio.ListarMedicamentos();
        }

    }
}
using datos;
using entidades;
using Negocio.Medicamentos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio.Ventas
{
    public class VentasNegocio : NegocioBase
    {
        private datosVentas _datosVentas;
        private MedicamentosNegocio _medicamentosNegocio;

        public VentasNegocio()
        {
            _datosVentas = new datosVentas();
            _medicamentosNegocio = new MedicamentosNegocio();
        }

        public int RegistrarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            try
            {
                ValidarVenta(venta, detalles);

                decimal total = 0;
                foreach (var detalle in detalles)
                {
                    var medicamento = _medicamentosNegocio.ObtenerMedicamento(detalle.IdMedicamento);
                    if (medicamento == null)
                        throw new Exception($"Medicamento con ID {detalle.IdMedicamento} no encontrado");

                    if (medicamento.Cantidad < detalle.Cantidad)
                        throw new Exception($"Stock insuficiente para {medicamento.Nombre}");

                    decimal subtotal = medicamento.Precio * detalle.Cantidad;
                    total += subtotal;
                }

                if (venta.Vuelto < total)
                    throw new Exception($"El monto recibido ({venta.Vuelto:C}) es menor al total ({total:C})");

                venta.Total = total;
                venta.Vuelto = venta.Vuelto - total;
                venta.Fecha = DateTime.Now;

                int idVenta = _datosVentas.RegistrarVenta(venta, detalles);

                foreach (var detalle in detalles)
                {
                    _medicamentosNegocio.ActualizarStock(detalle.IdMedicamento, -detalle.Cantidad);
                }

                return idVenta;
            }
            catch (Exception ex)
            {
                ManejarError(ex, ex.Message);
                return -1;
            }
        }

        public Venta ObtenerVenta(int idVenta)
        {
            try
            {
                if (idVenta <= 0)
                    throw new Exception("ID de venta inválido");

                var venta = _datosVentas.ObtenerVentaPorId(idVenta);
                if (venta != null)
                {
                    venta.Detalles = _datosVentas.ObtenerDetallesVenta(idVenta);

                    if (venta.Total == 0 && venta.Detalles != null && venta.Detalles.Count > 0)
                    {
                        venta.Total = CalcularTotalVenta(venta.Detalles);
                    }
                }
                return venta;
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al obtener venta");
                return null;
            }
        }

        public List<Venta> ListarVentas(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            try
            {
                var ventas = _datosVentas.ListarVentas(fechaInicio, fechaFin);

                foreach (var venta in ventas)
                {
                    if (venta.Total == 0 && venta.Detalles != null && venta.Detalles.Count > 0)
                    {
                        venta.Total = CalcularTotalVenta(venta.Detalles);
                    }
                }

                return ventas;
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al listar ventas");
                return new List<Venta>();
            }
        }

        private decimal CalcularTotalVenta(List<DetalleVenta> detalles)
        {
            decimal total = 0;
            foreach (var detalle in detalles)
            {
                var medicamento = _medicamentosNegocio.ObtenerMedicamento(detalle.IdMedicamento);
                if (medicamento != null)
                {
                    total += medicamento.Precio * detalle.Cantidad;
                }
            }
            return total;
        }

        private void ValidarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            if (venta == null)
                throw new Exception("La venta no puede ser nula");

            if (venta.IdEmpleado <= 0)
                throw new Exception("ID de empleado inválido");

            if (detalles == null || detalles.Count == 0)
                throw new Exception("La venta debe tener al menos un detalle");

            foreach (var detalle in detalles)
            {
                if (detalle.IdMedicamento <= 0)
                    throw new Exception("ID de medicamento inválido en detalle");

                if (detalle.Cantidad <= 0)
                    throw new Exception("La cantidad debe ser mayor a cero");
            }
        }
    }
}
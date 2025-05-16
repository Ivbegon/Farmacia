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

                // Calcular total y verificar stock
                decimal total = 0;
                foreach (var detalle in detalles)
                {
                    var medicamento = _medicamentosNegocio.ObtenerMedicamento(detalle.IdMedicamento);
                    if (medicamento == null)
                        throw new Exception($"Medicamento con ID {detalle.IdMedicamento} no encontrado");

                    if (medicamento.Cantidad < detalle.Cantidad)
                        throw new Exception($"Stock insuficiente para {medicamento.Nombre}");

                    //Arreglar el total de los reguistros de ventas


                    //detalle.PrecioUnitario = medicamento.Precio;
                    //detalle.Subtotal = detalle.Cantidad * detalle.PrecioUnitario;
                    //total += detalle.Subtotal;
                }

                venta.Total = total;
                venta.Vuelto = venta.Vuelto - total; // Asumiendo que venta.Vuelto contiene el monto recibido

                if (venta.Vuelto < 0)
                    throw new Exception("El monto recibido es menor al total");

                return _datosVentas.RegistrarVenta(venta, detalles);
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
                return _datosVentas.ListarVentas(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al listar ventas");
                return new List<Venta>();
            }
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
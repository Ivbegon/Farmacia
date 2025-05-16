using System.Data;
using Npgsql;
using entidades;
using System.Collections.Generic;
using System;
using datos;

namespace datos
{
    public class datosVentas : datosPostgreSQL
    {
        public int RegistrarVenta(Venta venta, List<DetalleVenta> detalles)
        {
            try
            {
                IniciarTransaccion();


                if (detalles.Any(d => d.id_medicamento == 0)) // Ajusta según tu modelo
                {
                    throw new Exception("Uno o más medicamentos no tienen ID especificado");
                }

                // Convertir detalles a formato JSON para pasarlo a la función
                string detallesJson = Newtonsoft.Json.JsonConvert.SerializeObject(detalles);

                using (NpgsqlCommand comando = CrearComando("SELECT crear_venta(@p_id_empleado," +
                    " @p_total, @p_vuelto, @p_detalles)", CommandType.Text))
                {
                    AgregarParametro(comando, "p_id_empleado", venta.IdEmpleado, NpgsqlTypes.NpgsqlDbType.Integer);
                    AgregarParametro(comando, "p_total", venta.Total, NpgsqlTypes.NpgsqlDbType.Numeric);
                    AgregarParametro(comando, "p_vuelto", venta.Vuelto, NpgsqlTypes.NpgsqlDbType.Numeric);
                    AgregarParametro(comando, "p_detalles", detallesJson, NpgsqlTypes.NpgsqlDbType.Jsonb);

                    int idVenta = Convert.ToInt32(EjecutarEscalar(comando));
                    ConfirmarTransaccion();
                    return idVenta;
                }
            }
            catch
            {
                CancelarTransaccion();
                throw;
            }
        }

        public Venta ObtenerVentaPorId(int idVenta)
        {
            using (NpgsqlCommand comando = CrearComando(
                "SELECT v.*, e.nombre as empleado_nombre, e.apellido as empleado_apellido " +
                "FROM ventas v JOIN empleados e ON v.id_empleado = e.id_empleado " +
                "WHERE v.id_venta = @id", CommandType.Text))
            {
                AgregarParametro(comando, "@id", idVenta, NpgsqlTypes.NpgsqlDbType.Integer);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    if (lector.Read())
                    {
                        return new Venta
                        {
                            IdVenta = Convert.ToInt32(lector["id_venta"]),
                            IdEmpleado = Convert.ToInt32(lector["id_empleado"]),
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Total = Convert.ToDecimal(lector["total"]),
                            Vuelto = Convert.ToDecimal(lector["vuelto"])
                        };
                    }
                    return null;
                }
            }
        }

        public List<Venta> ListarVentas(DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            List<Venta> lista = new List<Venta>();
            string consulta = "SELECT v.*, e.nombre as empleado_nombre, e.apellido as empleado_apellido " +
                              "FROM ventas v JOIN empleados e ON v.id_empleado = e.id_empleado";

            if (fechaInicio.HasValue || fechaFin.HasValue)
            {
                consulta += " WHERE 1=1";
                if (fechaInicio.HasValue)
                    consulta += " AND v.fecha >= @fechaInicio";
                if (fechaFin.HasValue)
                    consulta += " AND v.fecha <= @fechaFin";
            }

            consulta += " ORDER BY v.fecha DESC";

            using (NpgsqlCommand comando = CrearComando(consulta, CommandType.Text))
            {
                if (fechaInicio.HasValue)
                    AgregarParametro(comando, "@fechaInicio", fechaInicio.Value, NpgsqlTypes.NpgsqlDbType.Timestamp);
                if (fechaFin.HasValue)
                    AgregarParametro(comando, "@fechaFin", fechaFin.Value, NpgsqlTypes.NpgsqlDbType.Timestamp);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    while (lector.Read())
                    {
                        lista.Add(new Venta
                        {
                            IdVenta = Convert.ToInt32(lector["id_venta"]),
                            IdEmpleado = Convert.ToInt32(lector["id_empleado"]),
                            Fecha = Convert.ToDateTime(lector["fecha"]),
                            Total = Convert.ToDecimal(lector["total"]),
                            Vuelto = Convert.ToDecimal(lector["vuelto"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<DetalleVenta> ObtenerDetallesVenta(int idVenta)
        {
            List<DetalleVenta> detalles = new List<DetalleVenta>();
            using (NpgsqlCommand comando = CrearComando(
                "SELECT dv.*, m.nombre as medicamento_nombre, m.precio as precio_unitario " +
                "FROM detalle_ventas dv JOIN medicamentos m ON dv.id_medicamento = m.id_medicamento " +
                "WHERE dv.id_venta = @idVenta", CommandType.Text))
            {
                AgregarParametro(comando, "@idVenta", idVenta, NpgsqlTypes.NpgsqlDbType.Integer);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    while (lector.Read())
                    {
                        detalles.Add(new DetalleVenta
                        {
                            id_venta = Convert.ToInt32(lector["id_venta"]),
                            id_medicamento = Convert.ToInt32(lector["id_medicamento"]),
                            cantidad = Convert.ToInt32(lector["cantidad"]),
                        });
                    }
                }
            }
            return detalles;
        }

        public DataTable ObtenerMedicamentosMasVendidos(int mes, int anio)
        {
            using (NpgsqlCommand comando = CrearComando("obtener_medicamentos_mas_vendidos", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_mes", mes, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "p_anio", anio, NpgsqlTypes.NpgsqlDbType.Integer);

                DataTable tabla = new DataTable();
                using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
                return tabla;
            }
        }
    }
}
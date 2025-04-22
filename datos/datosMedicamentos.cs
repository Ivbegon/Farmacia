using System.Data;
using Npgsql;
using entidades;
using System.Collections.Generic;
using datos;

namespace datos
{
    public class datosMedicamentos : datosPostgreSQL
    {
        public int InsertarMedicamento(Medicamento medicamento)
        {
            using (NpgsqlCommand comando = CrearComando("crear_medicamento", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_nombre", medicamento.Nombre, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_descripcion", medicamento.Descripcion, NpgsqlTypes.NpgsqlDbType.Text);
                AgregarParametro(comando, "p_precio", medicamento.Precio, NpgsqlTypes.NpgsqlDbType.Numeric);
                AgregarParametro(comando, "p_cantidad", medicamento.Cantidad, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "p_fecha_vencimiento", medicamento.FechaVencimiento, NpgsqlTypes.NpgsqlDbType.Date);
                AgregarParametro(comando, "p_requiere_receta", medicamento.RequiereReceta, NpgsqlTypes.NpgsqlDbType.Boolean);
                AgregarParametro(comando, "p_id_proveedor", medicamento.IdProveedor, NpgsqlTypes.NpgsqlDbType.Integer);

                return Convert.ToInt32(EjecutarEscalar(comando));
            }
        }

        public void ActualizarMedicamento(Medicamento medicamento)
        {
            using (NpgsqlCommand comando = CrearComando("actualizar_medicamento", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_id", medicamento.IdMedicamento, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "p_nombre", medicamento.Nombre, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_descripcion", medicamento.Descripcion, NpgsqlTypes.NpgsqlDbType.Text);
                AgregarParametro(comando, "p_precio", medicamento.Precio, NpgsqlTypes.NpgsqlDbType.Numeric);
                AgregarParametro(comando, "p_cantidad", medicamento.Cantidad, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "p_fecha_vencimiento", medicamento.FechaVencimiento, NpgsqlTypes.NpgsqlDbType.Date);
                AgregarParametro(comando, "p_requiere_receta", medicamento.RequiereReceta, NpgsqlTypes.NpgsqlDbType.Boolean);
                AgregarParametro(comando, "p_id_proveedor", medicamento.IdProveedor, NpgsqlTypes.NpgsqlDbType.Integer);

                EjecutarComando(comando);
            }
        }

        public void EliminarMedicamento(int idMedicamento)
        {
            using (NpgsqlCommand comando = CrearComando("eliminar_medicamento", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_id", idMedicamento, NpgsqlTypes.NpgsqlDbType.Integer);
                EjecutarComando(comando);
            }
        }

        public Medicamento ObtenerMedicamentoPorId(int idMedicamento)
        {
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM medicamentos WHERE id_medicamento = @id", CommandType.Text))
            {
                AgregarParametro(comando, "@id", idMedicamento, NpgsqlTypes.NpgsqlDbType.Integer);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    if (lector.Read())
                    {
                        return new Medicamento
                        {
                            IdMedicamento = Convert.ToInt32(lector["id_medicamento"]),
                            Nombre = lector["nombre"].ToString(),
                            Descripcion = lector["descripcion"].ToString(),
                            Precio = Convert.ToDecimal(lector["precio"]),
                            Cantidad = Convert.ToInt32(lector["cantidad"]),
                            FechaVencimiento = Convert.ToDateTime(lector["fecha_vencimiento"]),
                            RequiereReceta = Convert.ToBoolean(lector["requiere_receta"]),
                            IdProveedor = Convert.ToInt32(lector["id_proveedor"])
                        };
                    }
                    return null;
                }
            }
        }

        public List<Medicamento> ListarMedicamentos()
        {
            List<Medicamento> lista = new List<Medicamento>();
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM medicamentos", CommandType.Text))
            {
                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    while (lector.Read())
                    {
                        lista.Add(new Medicamento
                        {
                            IdMedicamento = Convert.ToInt32(lector["id_medicamento"]),
                            Nombre = lector["nombre"].ToString(),
                            Descripcion = lector["descripcion"].ToString(),
                            Precio = Convert.ToDecimal(lector["precio"]),
                            Cantidad = Convert.ToInt32(lector["cantidad"]),
                            FechaVencimiento = Convert.ToDateTime(lector["fecha_vencimiento"]),
                            RequiereReceta = Convert.ToBoolean(lector["requiere_receta"]),
                            IdProveedor = Convert.ToInt32(lector["id_proveedor"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Medicamento> BuscarMedicamentosPorNombre(string nombre)
        {
            List<Medicamento> lista = new List<Medicamento>();
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM medicamentos WHERE nombre LIKE @nombre", CommandType.Text))
            {
                AgregarParametro(comando, "@nombre", $"%{nombre}%", NpgsqlTypes.NpgsqlDbType.Varchar);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    while (lector.Read())
                    {
                        lista.Add(new Medicamento
                        {
                            IdMedicamento = Convert.ToInt32(lector["id_medicamento"]),
                            Nombre = lector["nombre"].ToString(),
                            Descripcion = lector["descripcion"].ToString(),
                            Precio = Convert.ToDecimal(lector["precio"]),
                            Cantidad = Convert.ToInt32(lector["cantidad"]),
                            FechaVencimiento = Convert.ToDateTime(lector["fecha_vencimiento"]),
                            RequiereReceta = Convert.ToBoolean(lector["requiere_receta"]),
                            IdProveedor = Convert.ToInt32(lector["id_proveedor"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (NpgsqlCommand comando = CrearComando("SELECT * FROM proveedores", CommandType.Text))
            {
                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    while (lector.Read())
                    {
                        lista.Add(new Proveedor
                        {
                            IdProveedor = Convert.ToInt32(lector["id_proveedor"]),
                            Nombre = lector["nombre"].ToString(),
                            Telefono = lector["telefono"].ToString(),
                            Direccion = lector["direccion"].ToString(),
                            Email = lector["email"].ToString(),
                            Cif = lector["cif"].ToString()
                        });
                    }
                }
            }

            return lista;
        }


        public void ActualizarStock(int idMedicamento, int cantidad)
        {
            using (NpgsqlCommand comando = CrearComando(
                "UPDATE medicamentos SET cantidad = cantidad + @cantidad WHERE id_medicamento = @id", CommandType.Text))
            {
                AgregarParametro(comando, "@id", idMedicamento, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "@cantidad", cantidad, NpgsqlTypes.NpgsqlDbType.Integer);
                EjecutarComando(comando);
            }
        }
    }
}
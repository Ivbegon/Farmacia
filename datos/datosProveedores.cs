using System.Data;
using Npgsql;
using entidadesFarmacia;
using System.Collections.Generic;
using datos;

namespace datos
{
    public class datosProveedores : datosPostgreSQL
    {
        public int InsertarProveedor(Proveedor proveedor)
        {
            using (NpgsqlCommand comando = CrearComando("crear_proveedor", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_nombre", proveedor.Nombre, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_telefono", proveedor.Telefono, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_direccion", proveedor.Direccion, NpgsqlTypes.NpgsqlDbType.Text);
                AgregarParametro(comando, "p_email", proveedor.Email, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_cif", proveedor.Cif, NpgsqlTypes.NpgsqlDbType.Varchar);

                return Convert.ToInt32(EjecutarEscalar(comando));
            }
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            using (NpgsqlCommand comando = CrearComando("actualizar_proveedor", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_id", proveedor.IdProveedor, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "p_nombre", proveedor.Nombre, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_telefono", proveedor.Telefono, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_direccion", proveedor.Direccion, NpgsqlTypes.NpgsqlDbType.Text);
                AgregarParametro(comando, "p_email", proveedor.Email, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_cif", proveedor.Cif, NpgsqlTypes.NpgsqlDbType.Varchar);

                EjecutarComando(comando);
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            using (NpgsqlCommand comando = CrearComando("eliminar_proveedor", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_id", idProveedor, NpgsqlTypes.NpgsqlDbType.Integer);
                EjecutarComando(comando);
            }
        }

        public Proveedor ObtenerProveedorPorId(int idProveedor)
        {
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM proveedores WHERE id_proveedor = @id", CommandType.Text))
            {
                AgregarParametro(comando, "@id", idProveedor, NpgsqlTypes.NpgsqlDbType.Integer);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    if (lector.Read())
                    {
                        return new Proveedor
                        {
                            IdProveedor = Convert.ToInt32(lector["id_proveedor"]),
                            Nombre = lector["nombre"].ToString(),
                            Telefono = lector["telefono"].ToString(),
                            Direccion = lector["direccion"].ToString(),
                            Email = lector["email"].ToString(),
                            Cif = lector["cif"].ToString()
                        };
                    }
                    return null;
                }
            }
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
    }
}
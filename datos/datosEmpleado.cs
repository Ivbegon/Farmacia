using System.Data;
using Npgsql;
using entidades;
using System.Collections.Generic;
using datos;

namespace datos
{
    public class datosEmpleados : datosPostgreSQL
    {
        public int InsertarEmpleado(Empleado empleado)
        {
            using (NpgsqlCommand comando = CrearComando("crear_empleado", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_nombre", empleado.Nombre, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_apellido", empleado.Apellido, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_dni", empleado.Dni, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_telefono", empleado.Telefono, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_email", empleado.Email, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_nick", empleado.Nick, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_password", empleado.Password, NpgsqlTypes.NpgsqlDbType.Varchar);

                return Convert.ToInt32(EjecutarEscalar(comando));
            }
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            using (NpgsqlCommand comando = CrearComando("actualizar_empleado", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_id", empleado.IdEmpleado, NpgsqlTypes.NpgsqlDbType.Integer);
                AgregarParametro(comando, "p_nombre", empleado.Nombre, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_apellido", empleado.Apellido, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_dni", empleado.Dni, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_telefono", empleado.Telefono, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_email", empleado.Email, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_nick", empleado.Nick, NpgsqlTypes.NpgsqlDbType.Varchar);

                EjecutarComando(comando);
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            using (NpgsqlCommand comando = CrearComando("eliminar_empleado", CommandType.StoredProcedure))
            {
                AgregarParametro(comando, "p_id", idEmpleado, NpgsqlTypes.NpgsqlDbType.Integer);
                EjecutarComando(comando);
            }
        }

        public Empleado ObtenerEmpleadoPorId(int idEmpleado)
        {
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM empleados WHERE id_empleado = @id", CommandType.Text))
            {
                AgregarParametro(comando, "@id", idEmpleado, NpgsqlTypes.NpgsqlDbType.Integer);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    if (lector.Read())
                    {
                        return new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(lector["id_empleado"]),
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Dni = lector["dni"].ToString(),
                            Telefono = lector["telefono"].ToString(),
                            Email = lector["email"].ToString(),
                            Nick = lector["nick"].ToString(),
                            Password = lector["password"].ToString()
                        };
                    }
                    return null;
                }
            }
        }

        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> lista = new List<Empleado>();
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM empleados", CommandType.Text))
            {
                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    while (lector.Read())
                    {
                        lista.Add(new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(lector["id_empleado"]),
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Dni = lector["dni"].ToString(),
                            Telefono = lector["telefono"].ToString(),
                            Email = lector["email"].ToString(),
                            Nick = lector["nick"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public Empleado ValidarLogin(string nick, string password)
        {
            using (NpgsqlCommand comando = CrearComando("SELECT * FROM login_empleado(@p_nick, @p_password)", CommandType.Text))
            {
                AgregarParametro(comando, "p_nick", nick, NpgsqlTypes.NpgsqlDbType.Varchar);
                AgregarParametro(comando, "p_password", password, NpgsqlTypes.NpgsqlDbType.Varchar);

                using (NpgsqlDataReader lector = EjecutarLector(comando))
                {
                    if (lector.Read())
                    {
                        return new Empleado
                        {
                            IdEmpleado = Convert.ToInt32(lector["id_empleado"]),
                            Nombre = lector["nombre"].ToString(),
                            Apellido = lector["apellido"].ToString(),
                            Nick = lector["nick"].ToString()
                        };
                    }
                    return null;
                }
            }
        }
    }
}
using Npgsql;
using System.Data;
using System;

namespace datos
{
    public class datosPostgreSQL
    {
        protected NpgsqlConnection MConexion;
        protected string MCadenaConexion;
        protected NpgsqlTransaction MTransaccion;
        protected bool EnTransaccion;

        public datosPostgreSQL()
        {
            MCadenaConexion = "Port=5433;Server=localhost;Database=farmacia;Username=postgres;Password=postgres;";
        }

        protected NpgsqlConnection Conexion
        {
            get
            {
                if (MConexion == null)
                    MConexion = new NpgsqlConnection(MCadenaConexion);

                if (MConexion.State != ConnectionState.Open)
                    MConexion.Open();

                return MConexion;
            }
        }

        protected NpgsqlCommand CrearComando(string consulta, CommandType tipo = CommandType.Text)
        {
            return new NpgsqlCommand(consulta, Conexion)
            {
                CommandType = tipo,
                Transaction = EnTransaccion ? MTransaccion : null
            };
        }

        protected void AgregarParametro(NpgsqlCommand comando, string nombre, object valor, NpgsqlTypes.NpgsqlDbType tipo)
        {
            comando.Parameters.Add(new NpgsqlParameter(nombre, tipo) { Value = valor ?? DBNull.Value });
        }

        public void IniciarTransaccion()
        {
            MTransaccion = Conexion.BeginTransaction();
            EnTransaccion = true;
        }

        public void ConfirmarTransaccion()
        {
            MTransaccion.Commit();
            EnTransaccion = false;
        }

        public void CancelarTransaccion()
        {
            MTransaccion.Rollback();
            EnTransaccion = false;
        }

        public int EjecutarComando(NpgsqlCommand comando)
        {
            return comando.ExecuteNonQuery();
        }

        public object EjecutarEscalar(NpgsqlCommand comando)
        {
            return comando.ExecuteScalar();
        }

        public NpgsqlDataReader EjecutarLector(NpgsqlCommand comando)
        {
            return comando.ExecuteReader();
        }

        public DataTable EjecutarConsulta(string consulta)
        {
            DataTable tabla = new DataTable();
            using (NpgsqlCommand comando = CrearComando(consulta))
            {
                using (NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(comando))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}
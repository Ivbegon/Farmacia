using Npgsql;
using System.Data;
using System.Collections.Generic;

namespace datos
{
    public class datosPostgreSQL
    {
        #region Variables y Propiedades
        protected NpgsqlConnection MConexion;
        protected string MCadenaConexion;
        protected NpgsqlTransaction MTransaccion;
        protected bool EnTransaccion;

        protected NpgsqlConnection Conexion
        {
            get
            {
                if (MConexion == null)
                    MConexion = CrearConexion();

                if (MConexion.State != ConnectionState.Open)
                    MConexion.Open();

                return MConexion;
            }
        }
        #endregion

        #region Constructor
        public datosPostgreSQL()
        {
            MCadenaConexion = "Server=localhost;Database=farmacia;User ID=postgres;Password=postgres;";
        }
        #endregion

        #region Métodos Básicos
        protected NpgsqlConnection CrearConexion()
        {
            return new NpgsqlConnection(MCadenaConexion);
        }

        protected NpgsqlCommand CrearComando(string consulta, CommandType tipo = CommandType.Text)
        {
            NpgsqlCommand comando = new NpgsqlCommand(consulta, Conexion);
            comando.CommandType = tipo;
            if (EnTransaccion)
                comando.Transaction = MTransaccion;
            return comando;
        }

        protected void AgregarParametro(NpgsqlCommand comando, string nombre, object valor, NpgsqlTypes.NpgsqlDbType tipo)
        {
            NpgsqlParameter parametro = new NpgsqlParameter(nombre, tipo);
            parametro.Value = valor ?? DBNull.Value;
            comando.Parameters.Add(parametro);
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
        #endregion

        #region Métodos de Ejecución
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
        #endregion
    }
}
using datos;
using System;

namespace Negocio
{
    public abstract class NegocioBase
    {
        protected datosPostgreSQL _datos;

        public NegocioBase()
        {
            _datos = new datosPostgreSQL();
        }

        protected void ManejarError(Exception ex, string mensajeUsuario)
        {
            // Loggear errores :3
            throw new Exception(mensajeUsuario, ex);
        }
    }
}
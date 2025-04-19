using datos;
using entidades;
using System;
using System.Collections.Generic;

namespace Negocio.Empleados
{
    public class EmpleadosNegocio : NegocioBase
    {
        private datosEmpleados _datosEmpleados;

        public EmpleadosNegocio()
        {
            _datosEmpleados = new datosEmpleados();
        }

        public Empleado Login(string nick, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nick) || string.IsNullOrWhiteSpace(password))
                    throw new Exception("Nick y password son requeridos");

                return _datosEmpleados.ValidarLogin(nick, password);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al intentar iniciar sesión");
                return null;
            }
        }

        public int CrearEmpleado(Empleado empleado)
        {
            try
            {
                ValidarEmpleado(empleado);
                return _datosEmpleados.InsertarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al crear empleado");
                return -1;
            }
        }

        public void ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                ValidarEmpleado(empleado);
                _datosEmpleados.ActualizarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al actualizar empleado");
            }
        }

        public void EliminarEmpleado(int idEmpleado)
        {
            try
            {
                if (idEmpleado <= 0)
                    throw new Exception("ID de empleado inválido");

                _datosEmpleados.EliminarEmpleado(idEmpleado);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al eliminar empleado");
            }
        }

        public Empleado ObtenerEmpleado(int idEmpleado)
        {
            try
            {
                if (idEmpleado <= 0)
                    throw new Exception("ID de empleado inválido");

                return _datosEmpleados.ObtenerEmpleadoPorId(idEmpleado);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al obtener empleado");
                return null;
            }
        }

        public List<Empleado> ListarEmpleados()
        {
            try
            {
                return _datosEmpleados.ListarEmpleados();
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al listar empleados");
                return new List<Empleado>();
            }
        }

        private void ValidarEmpleado(Empleado empleado)
        {
            if (empleado == null)
                throw new Exception("El empleado no puede ser nulo");

            if (string.IsNullOrWhiteSpace(empleado.Nombre))
                throw new Exception("El nombre es requerido");

            if (string.IsNullOrWhiteSpace(empleado.Apellido))
                throw new Exception("El apellido es requerido");

            if (string.IsNullOrWhiteSpace(empleado.Dni))
                throw new Exception("El DNI es requerido");

            if (string.IsNullOrWhiteSpace(empleado.Nick))
                throw new Exception("El nick es requerido");

            if (string.IsNullOrWhiteSpace(empleado.Password))
                throw new Exception("La contraseña es requerida");
        }
    }
}
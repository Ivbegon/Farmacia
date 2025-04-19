using datos;
using entidades;
using System;
using System.Collections.Generic;

namespace Negocio.Proveedores
{
    public class ProveedoresNegocio : NegocioBase
    {
        private datosProveedores _datosProveedores;

        public ProveedoresNegocio()
        {
            _datosProveedores = new datosProveedores();
        }

        public int CrearProveedor(Proveedor proveedor)
        {
            try
            {
                ValidarProveedor(proveedor);
                return _datosProveedores.InsertarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al crear proveedor");
                return -1;
            }
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            try
            {
                ValidarProveedor(proveedor);
                _datosProveedores.ActualizarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al actualizar proveedor");
            }
        }

        public void EliminarProveedor(int idProveedor)
        {
            try
            {
                if (idProveedor <= 0)
                    throw new Exception("ID de proveedor inválido");

                _datosProveedores.EliminarProveedor(idProveedor);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al eliminar proveedor");
            }
        }

        public Proveedor ObtenerProveedor(int idProveedor)
        {
            try
            {
                if (idProveedor <= 0)
                    throw new Exception("ID de proveedor inválido");

                return _datosProveedores.ObtenerProveedorPorId(idProveedor);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al obtener proveedor");
                return null;
            }
        }

        public List<Proveedor> ListarProveedores()
        {
            try
            {
                return _datosProveedores.ListarProveedores();
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al listar proveedores");
                return new List<Proveedor>();
            }
        }

        private void ValidarProveedor(Proveedor proveedor)
        {
            if (proveedor == null)
                throw new Exception("El proveedor no puede ser nulo");

            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
                throw new Exception("El nombre es requerido");

            if (string.IsNullOrWhiteSpace(proveedor.Cif))
                throw new Exception("El CIF es requerido");
        }
    }
}
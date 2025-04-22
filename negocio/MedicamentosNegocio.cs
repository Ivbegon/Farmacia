using datos;
using entidades;
using System;
using System.Collections.Generic;

namespace Negocio.Medicamentos
{
    public class MedicamentosNegocio : NegocioBase
    {
        private datosMedicamentos _datosMedicamentos;

        public MedicamentosNegocio()
        {
            _datosMedicamentos = new datosMedicamentos();
        }

        public int CrearMedicamento(Medicamento medicamento)
        {
            ValidarMedicamento(medicamento);

            try
            { 
                return _datosMedicamentos.InsertarMedicamento(medicamento);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al crear medicamento");
                return -1;
            }
        }

        public void ActualizarMedicamento(Medicamento medicamento)
        { 
            try
            {
                ValidarMedicamento(medicamento);
                _datosMedicamentos.ActualizarMedicamento(medicamento);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al actualizar medicamento");
            }
        }

        public void EliminarMedicamento(int idMedicamento)
        {
            try
            {
                if (idMedicamento <= 0)
                    throw new Exception("ID de medicamento inválido");

                _datosMedicamentos.EliminarMedicamento(idMedicamento);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al eliminar medicamento");
            }
        }

        public Medicamento ObtenerMedicamento(int idMedicamento)
        {
            try
            {
                if (idMedicamento <= 0)
                    throw new Exception("ID de medicamento inválido");

                return _datosMedicamentos.ObtenerMedicamentoPorId(idMedicamento);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al obtener medicamento");
                return null;
            }
        }

        public List<Medicamento> ListarMedicamentos()
        {
            try
            {
                return _datosMedicamentos.ListarMedicamentos();
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al listar medicamentos");
                return new List<Medicamento>();
            }
        }

        public List<Medicamento> BuscarMedicamentos(string nombre)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                    return ListarMedicamentos();

                return _datosMedicamentos.BuscarMedicamentosPorNombre(nombre);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al buscar medicamentos");
                return new List<Medicamento>();
            }
        }

        public void ActualizarStock(int idMedicamento, int cantidad)
        {
            try
            {
                if (idMedicamento <= 0)
                    throw new Exception("ID de medicamento inválido");

                _datosMedicamentos.ActualizarStock(idMedicamento, cantidad);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al actualizar stock");
            }
        }

        public List<Proveedor> ListarProveedores()
        {
            try
            {
                return _datosMedicamentos.ListarProveedores();
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al listar proveedores");
                return new List<Proveedor>();
            }
        }


        private void ValidarMedicamento(Medicamento medicamento)
        {
                if (medicamento == null)
                    throw new Exception("El medicamento no puede ser nulo");

                if (string.IsNullOrWhiteSpace(medicamento.Nombre))
                    throw new Exception("El nombre es requerido");

                if (medicamento.Precio <= 0)
                    throw new Exception("El precio debe ser mayor a cero");

                if (medicamento.Cantidad < 0)
                    throw new Exception("La cantidad no puede ser negativa");

                if (medicamento.FechaVencimiento < DateTime.Today)
                    throw new Exception("La fecha de vencimiento no puede ser anterior a hoy");
        }
    }
}
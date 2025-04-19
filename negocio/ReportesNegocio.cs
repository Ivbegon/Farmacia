using datos;
using System;
using System.Data;

namespace Negocio.Reportes
{
    public class ReportesNegocio : NegocioBase
    {
        private datosVentas _datosVentas;

        public ReportesNegocio()
        {
            _datosVentas = new datosVentas();
        }

        public DataTable ObtenerMedicamentosMasVendidos(int mes, int anio)
        {
            try
            {
                if (mes < 1 || mes > 12)
                    throw new Exception("Mes inválido");

                if (anio < 2000 || anio > DateTime.Now.Year + 1)
                    throw new Exception("Año inválido");

                return _datosVentas.ObtenerMedicamentosMasVendidos(mes, anio);
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al generar reporte");
                return new DataTable();
            }
        }

        public DataTable ObtenerVentasPorPeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                if (fechaInicio > fechaFin)
                    throw new Exception("La fecha de inicio no puede ser mayor a la fecha fin");

                // Implementar lógica para obtener ventas por período
                // nuevo método en datosVentas????
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                ManejarError(ex, "Error al generar reporte");
                return new DataTable();
            }
        }
    }
}
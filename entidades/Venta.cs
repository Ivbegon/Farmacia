using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Venta
    {
        private int IdVenta { get; set; }
        private int IdEmpleado { get; set; }
        private DateTime Fecha { get; set; }
        private decimal Total { get; set; }
        private decimal Vuelto { get; set; }
        private List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

    }
}

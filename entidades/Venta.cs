using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public decimal Vuelto { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

    }
}

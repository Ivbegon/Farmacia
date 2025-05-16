using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class DetalleVenta
    {
        public int id_venta { get; set; }
        public int id_medicamento { get; set; }
        public int cantidad { get; set; }
    }
}

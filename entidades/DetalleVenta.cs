using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class DetalleVenta
    {
        public int IdVenta { get; set; }
        public int IdMedicamento { get; set; }
        public int Cantidad { get; set; }
    }
}

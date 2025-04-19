using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Medicamento
    {
        private int IdMedicamento { get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private decimal Precio { get; set; }
        private int Cantidad { get; set; }
        private DateTime FechaVencimiento { get; set; }
        private bool RequiereReceta { get; set; }
        private int IdProveedor { get; set; }

    }
}

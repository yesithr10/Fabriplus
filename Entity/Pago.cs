using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pago
    {
        public string TipoPago { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaPago { get; set; }
        public double ValorPagar { get; set; }
    }
}

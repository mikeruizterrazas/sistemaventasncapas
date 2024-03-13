using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Ingreso
    {
        public int idingreso { get; set; }
        public int idproveedor { get; set; }
        public DateTime fechaingreso { get; set; }
        public Decimal total { get; set; }
        public string estado { get; set; }
    }
}

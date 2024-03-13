using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Venta
    {
        public int idventa { get; set; }
        public int idcliente { get; set; }
        public int idvendedor { get; set; }
        public DateTime fecha{ get; set; }
        public Decimal total { get; set; }
        public string estado { get; set; }
    }
}

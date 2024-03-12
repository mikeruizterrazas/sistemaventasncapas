using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Venta
    {
        public int idventa { get; set; }
        public int idcliente { get; set; }
        public int idvendedor { get; set; }
        public string fecha{ get; set; }
        public string total { get; set; }
        public string estado { get; set; }
    }
}

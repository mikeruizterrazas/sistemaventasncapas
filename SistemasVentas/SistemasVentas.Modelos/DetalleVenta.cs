using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class DetalleVenta
    {
        public int iddetalleventa { get; set; }
        public int idventa { get; set; }
        public int idproducto { get; set; }
        public string cantidad { get; set; }
        public Decimal precioventa { get; set; }
        public Decimal subtotal { get; set; }
        public string estado { get; set; }

    }
}

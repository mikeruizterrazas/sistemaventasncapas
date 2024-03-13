using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class DetalleIng
    {
        public int iddetalleing { get; set; }
        public int idingreso { get; set; }
        public int idproducto { get; set; }
        public DateTime fechavenc { get; set; }
        public int cantidad { get; set; }
        public Decimal preciocosto { get; set; }
        public Decimal precioventa { get; set; }
        public Decimal subtotal { get; set; }
        public string estado { get; set; }

    }
}

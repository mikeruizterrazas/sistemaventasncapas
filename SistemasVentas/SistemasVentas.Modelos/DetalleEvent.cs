using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class DetalleEvent
    {
        public int iddetallevent { get; set; }
        public int idventa { get; set; }
        public int idproducto { get; set; }
        public string cantidad { get; set; }
        public string precioventa { get; set; }
        public string subtotal { get; set; }
        public string estado { get; set; }

    }
}

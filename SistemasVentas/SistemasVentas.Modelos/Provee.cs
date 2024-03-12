using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Provee
    {
        public int idprovee { get; set; }
        public int idproducto { get; set; }
        public int idproveedor { get; set; }
        public string fecha { get; set; }
        public string precio { get; set; }
    }
}

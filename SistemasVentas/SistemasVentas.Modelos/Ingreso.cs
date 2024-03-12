using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Ingreso
    {
        public int idingreso { get; set; }
        public int idproveedor { get; set; }
        public string fechaingreso { get; set; }
        public string total { get; set; }
        public string estado { get; set; }
    }
}

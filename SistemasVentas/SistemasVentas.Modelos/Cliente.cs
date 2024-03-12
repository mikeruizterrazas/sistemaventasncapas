using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Cliente
    {
        public int idcliente { get; set; }
        public int idpersona { get; set; }
        public string tipocliente { get; set; }
        public string codigoclie { get; set; }
        public string estado { get; set; }
    }
}

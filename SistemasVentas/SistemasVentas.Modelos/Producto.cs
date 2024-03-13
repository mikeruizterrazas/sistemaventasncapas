﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Producto
    {
        public int idproducto { get; set; }
        public int idtipoproducto { get; set; }
        public string nombre { get; set; }
        public string codigobarra { get; set; }
        public int idmarca { get; set; }
        public int unidad { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    }
}

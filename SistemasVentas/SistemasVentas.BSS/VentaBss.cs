﻿using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class VentaBss
    {
        VentaDAL dal = new VentaDAL();
        public DataTable ListaVentaBss()
        {
            return dal.ListarVentaDal();
        }
        public void InsertarVentadBss(Venta venta)
        {
            dal.InsertarVentaDal(venta);
        }
    }
}

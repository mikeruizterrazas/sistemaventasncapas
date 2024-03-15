using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProveeBss
    {
        ProveeDAL dal = new ProveeDAL();
        public DataTable ListaProveeBss()
        {
            return dal.ListarProveeDal();
        }
        public void InsertarProveeBss(Provee provee)
        {
            dal.InsertarProveeDal(provee);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public  class ProveeDAL
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "select * from provee";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into cliente values('" +provee.idprovee+ "','"+provee.idproducto+ "','"+provee.idproveedor+ "','"+provee.fecha+ "','"+provee.precio+"'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

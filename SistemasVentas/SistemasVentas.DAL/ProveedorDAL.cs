using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class ProveedorDAL
    {
        public DataTable ListarProveedorDal()
        {
            string consulta = "select * from proveedor";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveedorDal(Proveedor proveedor)
        {
            string consulta = "insert into cliente values('" +proveedor.idproveedor+ "','"+proveedor.nombre+ "','"+proveedor.telefono+ "','"+proveedor.direccion + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class ProductoDAL
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into cliente values('" +producto.idproducto+ "','"+producto.idtipoproducto + "','"+producto.nombre + "','"+producto.codigobarra + "','"+producto.idmarca + "','"+producto.unidad + "','"+producto.descripcion+ "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

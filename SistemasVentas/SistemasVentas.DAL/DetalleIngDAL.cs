using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class DetalleIngDAL
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from detalleing";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleIngDal(DetalleIng detalleIng)
        {
            string consulta = "insert into cliente values('"+detalleIng.iddetalleing+"','"+detalleIng.idproducto+ "','"+detalleIng.idingreso+"','"+detalleIng.fechavenc+ "','"+detalleIng.cantidad+ "','"+detalleIng.preciocosto+ "','"+detalleIng.precioventa+ "','"+detalleIng.subtotal + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

    }
}

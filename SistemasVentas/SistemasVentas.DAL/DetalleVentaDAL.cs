using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class DetalleVentaDAL
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarDetalleVentaDal(DetalleVenta detalleventa)
        {
            string consulta = "insert into cliente values('"+detalleventa.iddetalleventa+ "','"+detalleventa.idventa+ "','"+detalleventa.idproducto+ "','"+detalleventa.cantidad+ "','"+detalleventa.precioventa+ "','"+detalleventa.subtotal + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

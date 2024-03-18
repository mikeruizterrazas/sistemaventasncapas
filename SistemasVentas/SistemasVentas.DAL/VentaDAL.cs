using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarVentaDal(Venta venta)
        {
            string consulta = "insert into cliente values('" +venta.idventa+ "','"+venta.idcliente + "','"+venta.idvendedor + "','"+venta.fecha + "','"+venta.total+ "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}


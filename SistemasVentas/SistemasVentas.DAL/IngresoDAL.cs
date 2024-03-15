using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class IngresoDAL
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarIngresoDal(Ingreso ingreso)
        {
            string consulta = "insert into cliente values('"+ingreso.idingreso+ "','"+ingreso.idproveedor+ "','"+ingreso.fechaingreso+ "','"+ingreso.total + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

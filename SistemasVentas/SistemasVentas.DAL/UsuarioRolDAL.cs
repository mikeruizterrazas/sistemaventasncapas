using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
   public class UsuarioRolDAL
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            string consulta = "insert into cliente values('" +usuariorol.idusuariorol+ "','"+usuariorol.idusuario+ "','"+usuariorol.idrol+"','"+usuariorol.fechaasignada+ "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}

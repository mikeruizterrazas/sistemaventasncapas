using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class UsuarioDAL
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into cliente values('" + usuario.idusuario+ "','"+usuario.idpersona+ "','"+usuario.nombreuser+ "','"+usuario.contraseña+ "','"+usuario.fechareg + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public void InsertarUsuarioRolDal(UsuarioRol usuariorol)
        {
            throw new NotImplementedException();
        }
    }
}

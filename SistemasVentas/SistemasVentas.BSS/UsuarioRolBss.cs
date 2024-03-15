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
    public class UsuarioRolBss
    {
       UsuarioDAL dal = new UsuarioDAL();
        public DataTable ListaUsuarioRolBss()
        {
            return dal.ListarUsuarioDal();
        }
        public void InsertarUsuarioRoldBss(UsuarioRol usuariorol)
        {
            dal.InsertarUsuarioRolDal(usuariorol);
        }
    }
}

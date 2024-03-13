using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class UsuarioRol
    {
        public int idusuariorol { get; set; }
        public int idusuario{ get; set; }
        public int idrol { get; set; }
        public DateTime fechaasignada { get; set; }
        public string estado { get; set; }
        
    }
}

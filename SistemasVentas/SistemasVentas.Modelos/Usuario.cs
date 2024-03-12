using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    internal class Usuario
    {
        public int idusuario { get; set; }
        public int idpersona { get; set; }
        public string nombreuser  { get; set; }
        public string contraseña{ get; set; }
        public string fechareg { get; set; }
    
    }
}

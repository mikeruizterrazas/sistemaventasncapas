using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.Modelos
{
    public class Usuario
    {
        public int idusuario { get; set; }
        public int idpersona { get; set; }
        public string nombreuser  { get; set; }
        public string contraseña{ get; set; }
        public DateTime fechareg { get; set; }
    
    }
}

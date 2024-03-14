using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.Modelos;
namespace SistemasVentas.DAL
{
    public class PersonaDAL
    {
        public DataTable ListarPersonasDal()
        {
            string consulta = "select * from persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.nombre + "'," +
                                                         "'" + persona.apellido + "'," +
                                                         "'" + persona.telefono + "'," +
                                                         "'" + persona.ci + "'," +
                                                         "'" + persona.correo + "'," +
                                                         "'Activo'";
            conexion.Ejecutar(consulta);

      }
    }
}

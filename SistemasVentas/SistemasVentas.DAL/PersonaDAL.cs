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

        public Persona obtenerpersonaid(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.idpersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                p.nombre = tabla.Rows[0]["nombre"].ToString();
                p.apellido = tabla.Rows[0]["apellido"].ToString();
                p.telefono = tabla.Rows[0]["telefono"].ToString();
                p.ci = tabla.Rows[0]["ci"].ToString();
                p.correo = tabla.Rows[0]["correo"].ToString();
                p.estado = tabla.Rows[0]["estado"].ToString();

            }
            return p;
        }
        public void EditarPersonaDal(Persona p)
        {
            string consulta = "update persona set nombre='" + p.nombre + "'," +
                                                 "apellido='" + p.apellido + "'," +
                                                 "telefono='" + p.telefono + "'," +
                                                 "ci='" + p.ci + "'," +
                                                 "correo='" + p.correo + "' " +
                               "where idpersona=" + p.idpersona;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal (int id)
        {
            string consulta = "delete from persona where idpersona"+id;
            conexion.Ejecutar(consulta);
        }
    }
}
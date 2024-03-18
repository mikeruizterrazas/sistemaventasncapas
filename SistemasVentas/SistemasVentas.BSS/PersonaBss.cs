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
    public class PersonaBss
    {
        PersonaDAL dal = new PersonaDAL();
        public DataTable ListaPersonaBss()
        {
            return dal.ListarPersonasDal();
        }

        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public Persona Obtenerid(int id)
        {
            return dal.obtenerpersonaid(id);
        }

        public Persona ObteneridBss(int idpersonaseleccionada)
        {
            throw new NotImplementedException();
        }

        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonaBss (int id)
        {
            dal.EliminarPersonaDal (id);
        }
    }
}

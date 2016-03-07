using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidades;
using CapaEntidades.Contratos;
using CapaEntidades.Auditoria;

namespace CapaDatos
{
    public class PersonaDAO : IPersona
    {
        public bool Save(Persona obPersona)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Persona objPersona)
        {
            throw new NotImplementedException();
        }

        public bool Update(Persona objPersona)
        {
            throw new NotImplementedException();
        }

        public IList<Persona> GetAll()
        {
            throw new NotImplementedException();
        }

        public CapaEntidades.Persona GetPersona(CapaEntidades.Persona objPersona)
        {
            throw new NotImplementedException();
        }
    }
}

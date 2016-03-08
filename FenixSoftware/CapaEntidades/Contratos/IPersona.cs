using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaEntidades.Contratos
{
    public interface IPersona
    {
        bool Save(Persona obPersona);
        bool Delete(Persona objPersona);
        bool Update(Persona objPersona);
        IList<Persona> GetAll();
        Persona GetPersona(Persona objPersona);
    }
}

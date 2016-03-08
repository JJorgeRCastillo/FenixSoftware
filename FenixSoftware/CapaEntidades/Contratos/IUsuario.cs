using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Contratos
{
    public interface IUsuario
    {
        bool Save(Usuario objUsuario);
        bool Delete(Usuario objUsuario);
        bool Update(Usuario objUsuario);
        IList<Usuario> GetAll();
        Persona GetPersona(Usuario objUsuario);
    }
}

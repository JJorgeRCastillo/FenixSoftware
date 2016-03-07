using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Auditoria;

namespace CapaEntidades
{
    public class Usuario : Persona
    {
        public int IdUsuario { get; set; }
        public String User { get; set; }
        public String Clave { get; set; }

        public Usuario() { }

        public Usuario(String User, String Clave) 
        {
            this.User = User;
            this.Clave = Clave;
        }

        public Usuario(int IdUsuario, String User, String Clave, int IdPersona, String Nombres, String ApPaterno, String ApMaterno, int Edad,
            String Sexo, DateTime FechaNacimiento, Boolean Estado, DateTime FechaCreacion, DateTime FechaActualizacion)
            : base(IdPersona, Nombres, ApMaterno, ApMaterno, Edad, Sexo, FechaNacimiento, Estado, FechaNacimiento, FechaActualizacion)
        {
            this.IdUsuario = IdUsuario;
            this.User = User;
            this.Clave = Clave;
        }
    }
}

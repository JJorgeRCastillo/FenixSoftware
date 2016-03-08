using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades.Auditoria;

namespace CapaEntidades
{
    public class Persona : BaseInfo
    {
        #region ATRIBUTOS
        public int IdPersona { get; set; }
        public String Nombres { get; set; }
        public String ApPaterno { get; set; }
        public String ApMaterno { get; set; }
        public int Edad { get; set; }
        public String Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Boolean Estado { get; set; }
        #endregion

        public Persona() { }

        public Persona(int IdPersona, String Nombres, String ApPaterno, String ApMaterno, int Edad,
            String Sexo, DateTime FechaNacimiento, Boolean Estado, DateTime FechaCreacion, DateTime FechaActualizacion)
            : base(FechaCreacion, FechaActualizacion)
        {
            this.IdPersona = IdPersona;
            this.Nombres = Nombres;
            this.ApPaterno = ApPaterno;
            this.ApMaterno = ApMaterno;
            this.Edad = Edad;
            this.Sexo = Sexo;
            this.FechaNacimiento = FechaNacimiento;
            this.Estado = Estado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades.Auditoria
{
    public class BaseInfo
    {
        #region "ATRIBUTOS"
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        #endregion

        public BaseInfo() { }

        public BaseInfo(DateTime FechaCreacion, DateTime FechaActualizacion)
        {
            this.FechaCreacion = FechaCreacion;
            this.FechaActualizacion = FechaActualizacion;
        }
    }
}

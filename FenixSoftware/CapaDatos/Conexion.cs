using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null;
        private Conexion() { CadenaConexion = GetStringConnection(); }
        public static Conexion GetInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        private String CadenaConexion { get; set; }

        public String GetStringConnection()
        {
            return ConfigurationManager.ConnectionStrings["conexionfenixdb"].ConnectionString;
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}

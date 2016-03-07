using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaEntidades.Contratos;
using CapaEntidades.Auditoria;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class UsuarioDAO : IUsuario
    {
        #region SINGLETON
        private static UsuarioDAO Instancia = null;
        private UsuarioDAO() { }
        public static UsuarioDAO GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new UsuarioDAO();
            }
            return Instancia;
        }
        #endregion


        #region METODOS GENERICOS
        public bool Save(Usuario objUsuario)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Usuario objUsuario)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario objUsuario)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Persona GetPersona(Usuario objUsuario)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region METODOS PROPIOS
        public Usuario ValidarCredenciales(String usuario, String clave)
        {
            SqlConnection objConexion = Conexion.GetInstance().GetConnection();
            Usuario objUsuario = null;
            try
            {
                SqlCommand objCmd = new SqlCommand("SP_VERIFICARACCESO", objConexion);
                objCmd.CommandType = CommandType.StoredProcedure;
                objCmd.Parameters.AddWithValue("@prmUsuario", usuario);
                objCmd.Parameters.AddWithValue("@prmClave", clave);
                objConexion.Open();
                using(SqlDataReader dr = objCmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        if (dr.Read())
                        {
                            objUsuario = new Usuario();
                            objUsuario.IdUsuario = Convert.ToInt32(dr["idUsuario"].ToString());
                            objUsuario.IdPersona = Convert.ToInt32(dr["idPersona"].ToString());
                            objUsuario.Nombres = dr["nombres"].ToString();
                            objUsuario.ApPaterno = dr["apPaterno"].ToString();
                            objUsuario.ApMaterno = dr["apMaterno"].ToString();
                            objUsuario.Edad = Convert.ToInt32(dr["edad"].ToString());
                            objUsuario.FechaNacimiento = Convert.ToDateTime(dr["fechaNacimiento"].ToString());
                            objUsuario.Sexo = dr["sexo"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objUsuario = null;
                throw ex;
            }
            finally
            {
                objConexion.Close();
            }
            return objUsuario;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class UsuarioLN
    {
        #region SINGLETON
        private static UsuarioLN Instancia = null;
        private UsuarioLN() { }
        public static UsuarioLN GetInstance()
        {
            if (Instancia == null)
            {
                Instancia = new UsuarioLN();
            }
            return Instancia;
        }
        #endregion

        public Usuario ValidarCredenciales(String usuario, String clave)
        {
            try
            {
                return UsuarioDAO.GetInstance().ValidarCredenciales(usuario, clave);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

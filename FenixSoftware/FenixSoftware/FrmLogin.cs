using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using FenixSoftware.Alertas;

namespace FenixSoftware
{
    public partial class FrmLogin : Form
    {
        // VARIABLE DE MENSAJES (GLOBAL)
        public FrmLogin()
        {
            InitializeComponent();
            //chkRecordar.Visible = false;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtPassword.Text;

            if (!usuario.Equals("") && !clave.Equals(""))
            {
                try
                {
                    Usuario objUsuario = UsuarioLN.GetInstance().ValidarCredenciales(usuario, clave);

                    if (objUsuario != null)
                    {
                        FrmPrincipal ventana = new FrmPrincipal(objUsuario);
                        ventana.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        AlertsHelper.GetInstance().InformationMessage("No exite usuario con credenciales ingresadas.", "ALERTA");
                    }
                }
                catch (Exception ex)
                {
                    AlertsHelper.GetInstance().ErrorMessage("Usuario y/o Clave incorrecta.", "ERROR");
                }
            }
            else
            {
                AlertsHelper.GetInstance().InformationMessage("Llenar campos vacíos.", "ALERTA");
            }
        }
    }
}

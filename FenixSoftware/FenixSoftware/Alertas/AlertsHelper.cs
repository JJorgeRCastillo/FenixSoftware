using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenixSoftware.Alertas
{
    public class AlertsHelper
    {
        #region SINGLETON
        private static AlertsHelper helper = null;
        private AlertsHelper() { }
        public static AlertsHelper GetInstance()
        {
            if (helper == null)
            {
                helper = new AlertsHelper();
            }
            return helper;
        }
        #endregion

        public void ErrorMessage(String mensaje, String titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SuccessMessage(String mensaje, String titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        public void InformationMessage(String mensaje, String titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

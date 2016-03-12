using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FenixSoftware
{
    public partial class FrmAsignaciones : Form
    {
        private FrmVerAsignaciones frmVerAsignaciones;

        public FrmAsignaciones()
        {
            InitializeComponent();
        }

        private void btnVerAsignaciones_Click(object sender, EventArgs e)
        {
            frmVerAsignaciones = new FrmVerAsignaciones();
            frmVerAsignaciones.Show();
        }
    }
}

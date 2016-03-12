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
    public partial class FrmIngresos : Form
    {
        private FrmVerIngresos frmVerIngresos;

        public FrmIngresos()
        {
            InitializeComponent();
        }

        private void btnVerIngresos_Click(object sender, EventArgs e)
        {
            frmVerIngresos = new FrmVerIngresos();
            frmVerIngresos.Show();
        }
    }
}

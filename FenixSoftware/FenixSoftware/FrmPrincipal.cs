using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades.Auditoria;
using CapaEntidades;

namespace FenixSoftware
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(Usuario objUsuario)
        {
            InitializeComponent();
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = jpnPrincipal.Width;
            pictureBox1.Height = jpnPrincipal.Height;

            lblUsuarioLogin2.Text = objUsuario.Nombres + objUsuario.ApPaterno;
        }

        private void jpnPrincipal_Resize(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = jpnPrincipal.Width;
            pictureBox1.Height = jpnPrincipal.Height;

        }

        private void abrirCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbrirCaja ventana = new FrmAbrirCaja();
            ventana.MdiParent = this;
            ventana.Show();


        }
    }
}

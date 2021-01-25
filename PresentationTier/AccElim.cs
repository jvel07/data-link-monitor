using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PresentationTier
{
    
    public partial class AccElim : Form
    {
        ServiceReference1.Service1Client elim = new ServiceReference1.Service1Client();
        public AccElim()
        {
            InitializeComponent();
        }

        private void btnAceptarEl_Click(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Equals("monitoreo"))
            {
                elim.eliminarEstadoEnlace();
                Form.ActiveForm.Visible = false;
                Form monit = new Monitoreo();
                monit.Show();

            }
            else MessageBox.Show("Contraseña incorrecta!");

        }

        private void btnCancelarEl_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form monit = new Monitoreo();
            monit.Show();
        }
    }
}

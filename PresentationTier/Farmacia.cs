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
    public partial class Farmacia : Form
    {

        ServiceReference1.Service1Client clientFarm = new ServiceReference1.Service1Client();

        OpenFileDialog dialog = new OpenFileDialog();      
        public Farmacia()
        {
            InitializeComponent();
        }

        public void loadFarmacia()
        {
            dgvFarm.DataSource = clientFarm.obtenerFarmacias();
        }
        private void Farmacia_Load(object sender, EventArgs e)
        {
            loadFarmacia();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            clientFarm.insertarFarmacia(Convert.ToInt32(txtIdFarm.Text), txtNombFarm.Text, txtIpFarm.Text, txtPath.Text);
            loadFarmacia();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clientFarm.modificarFarmacia(Convert.ToInt32(txtIdFarm.Text), txtNombFarm.Text, txtIpFarm.Text, txtPath.Text);
            loadFarmacia();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form farmac = new Farmacia();
            Form monitoreo = new Monitoreo();
            farmac.Close();
            monitoreo.Show();
            
        }

        private void btnAbrirPathRec_Click(object sender, EventArgs e)
        {
            dialog.Filter = "Audio Files (.wav)|*.wav";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = dialog.FileName;
                
            }
        }

        private void dgvFarm_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvFarm.CurrentRow.Cells != null)
            {
                txtIdFarm.Text = dgvFarm.CurrentRow.Cells[0].Value.ToString();
                txtNombFarm.Text = dgvFarm.CurrentRow.Cells[1].Value.ToString();
                txtIpFarm.Text = dgvFarm.CurrentRow.Cells[2].Value.ToString();
                txtPath.Text = dgvFarm.CurrentRow.Cells[3].Value.ToString();                    
            }
        }
    }
}

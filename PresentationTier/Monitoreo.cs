using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Media;
using System.Runtime.CompilerServices;
using System.Net;
using System.IO;
//using System.Security.Permissions;

namespace PresentationTier
{
    public partial class Monitoreo : Form
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        
        EstadoEnlace correccion = new EstadoEnlace();
        int codErroCount = 0;



        public List<EstadoEnlace> monitoreos = new List<EstadoEnlace>();


        float rateError = 0;
        int pingCount = 0;
        int timeCount = 0;
        int errorCount = 0;
        string who = "";
        //Thread errorMessage;
        // Thread ipEnlace;
        public int pingTime;
        Ping pingSender;
        String idFarm = "";
        String nombreFarm;
        Int32 farm;

       public String cadena1;
       public String cadena2;
       public String cadena3;
       public String cadena4;

       bool insertarUnaVez;

        //errores y pings
        //Int32 i;
       public DataTable tablaEstados = new DataTable();
       System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        public Monitoreo()
        {
            InitializeComponent();
            //cargarDatosFarmacia();            
            //errorMessage = new Thread(new ThreadStart(SendErrorMessage)); 
            tablaEstados.Columns.Add("column1");
            tablaEstados.Columns.Add("column2");
            tablaEstados.Columns.Add("column3");
            tablaEstados.Columns.Add("column4");
            tablaEstados.Columns.Add("column5");
            tablaEstados.Columns.Add("column6");
            insertarUnaVez = false;
        }

        private void Monitoreo_Load(object sender, EventArgs e)
        {
            dgvFarmacias.DataSource = client.obtenerFarmacias();

            //  MessageBox.Show("Pins a analizar: " + monitoreos.Count.ToString());
            //loadEstado();
        }

        public void loadEstado()
        {
            //dgvEstados2.DataSource = client.obtenerEstados();
        }

        //botón ping
        private void btnPing_Click(object sender, EventArgs e)
        {
            if (!txtTasaErrorRef.Text.Equals(""))
            {
                cargarDatosFarmacia();
                timer1.Start();
            }
            else
            {
                //timer1.Stop(); 
                MessageBox.Show("Ingresa tasa de error de referencia!");
            }
        }


        private void cargarDatosFarmacia()
        {

            for (int x = 0; x < dgvFarmacias.Rows.Count; x++)
            {
                //ip[x] = dgvFarmacias.Rows[x].Cells["ipfarmaciaDataGridViewTextBoxColumn"].Value.ToString();
                //nombreFarm = dgvFarmacias.Rows[x].Cells["nombrefarmaciaDataGridViewTextBoxColumn"].Value.ToString();
                //idFarm = dgvFarmacias.Rows[x].Cells[0].Value.ToString();
                //who = dgvFarmacias.Rows[x].Cells["ipfarmaciaDataGridViewTextBoxColumn"].Value.ToString();
                EstadoEnlace nuevoEstado = new EstadoEnlace();
                nuevoEstado.id_estado_enlace = Convert.ToInt32(dgvFarmacias.Rows[x].Cells["idfarmaciaDataGridViewTextBoxColumn"].Value.ToString());
                nuevoEstado.ip_farm = dgvFarmacias.Rows[x].Cells["ipfarmaciaDataGridViewTextBoxColumn"].Value.ToString();
                nuevoEstado.nombre_farm = dgvFarmacias.Rows[x].Cells["nombrefarmaciaDataGridViewTextBoxColumn"].Value.ToString();
                nuevoEstado.fkid_farm = Convert.ToInt32(dgvFarmacias.Rows[x].Cells["idfarmaciaDataGridViewTextBoxColumn"].Value.ToString());
                nuevoEstado.pathAlerta = dgvFarmacias.Rows[x].Cells["alerta_Rec"].Value.ToString();
                // nuevoEstado.tiempo_monitoreo = this.timeCount;
                monitoreos.Add(nuevoEstado);
            }

        }




        public int buscarFarmacia(String ip/*, DataTable tablaTemporal*/)
        {
            int cont = 0;
            foreach (DataRow item in tablaEstados.Rows)
            {
                // item.ItemArray.;
                if (item[4].ToString().Equals(ip))
                {
                    //Console.WriteLine(item.ToString());
                    return cont;
                }
                cont++;
            }
            return -1;
        }

        private void realizarPing()
        {
            AutoResetEvent waiter = new AutoResetEvent(false);
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            string[] ip = new string[dgvFarmacias.Rows.Count - 1];
            int timeout = 2000;
            pingSender = new Ping();
            //pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
            PingOptions options = new PingOptions(64, true);
            Ping Pings = new Ping();

            try
            {
                //this.pingTime = (Convert.ToInt32(txtTime.Text));
                for (int i = 0; i < monitoreos.Count-1; i++)
                {
                    //  pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);
                    //pingSender.SendAsync(/*txtIP.Text,*/monitoreos[i].ip_farm, timeout, waiter);
                    PingReply pingRep;
                    pingRep = Pings.Send(monitoreos[i].ip_farm, timeout);
                    // Console.WriteLine(monitoreos[i].ip_farm.ToString());
                    monitoreos[i].pingCount++;
                  //  client.modificarEstadoEnlace(monitoreos[i].fkid_farm, monitoreos[i].porcentaje_pings_perdidos, monitoreos[i].tiempo_monitoreo, 2, monitoreos[i].ip_farm, monitoreos[i].nombre_farm);
                    //client.insertarEstadoEnlace(monitoreos[i].fkid_farm, monitoreos[i].porcentaje_pings_perdidos, monitoreos[i].tiempo_monitoreo, 2, monitoreos[i].ip_farm, monitoreos[i].nombre_farm);

                    if (pingRep.Status != IPStatus.Success)
                    {
                        monitoreos[i].pingErrorCount++;

                    }
                    monitoreos[i].calcularTasaError();
                    if (monitoreos[i].porcentaje_pings_perdidos > Convert.ToInt32(txtTasaErrorRef.Text))
                    {
                        //if ((monitoreos[i].pingErrorCount * 100) / monitoreos[i].pingCount > Convert.ToInt32(txtTasaErrorRef.Text))
                        //{
                            
                            playSound(monitoreos[i].pathAlerta);
                            monitoreos[i].pingErrorCount = 0;
                            //monitoreos[i].porcentaje_pings_perdidos = 0;
                            //monitoreos[i].pingCount = 0;
                       // }
                    }
                    
                    cadena1 = monitoreos[i].porcentaje_pings_perdidos.ToString() + "%";
                    cadena2 = monitoreos[i].pingErrorCount.ToString();
                    cadena3 = monitoreos[i].pingCount.ToString();
                    cadena4 = monitoreos[i].nombre_farm.ToString();

                    int posicion = buscarFarmacia(monitoreos[i].ip_farm/*, tablaEstados*/);
                    if (posicion == -1)
                    {
                        DataRow fila = tablaEstados.NewRow();
                        fila[0] = monitoreos[i].id_estado_enlace.ToString();
                        fila[1] = monitoreos[i].porcentaje_pings_perdidos.ToString();
                        //fila[2] = this.timeCount.ToString();
                        fila[2] = monitoreos[i].tiempo_monitoreo.ToString();
                        fila[3] = monitoreos[i].fkid_farm.ToString();
                        fila[4] = monitoreos[i].ip_farm.ToString();
                        fila[5] = monitoreos[i].nombre_farm.ToString();
                        tablaEstados.Rows.Add(fila);
                    }
                    else
                    {
                        // tablaEstados.Rows[posicion][0] = monitoreos[i].id_estado_enlace.ToString();
                        //correccion = monitoreos[i];
                        // codErroCount = correccion.pingErrorCount;
                        //  Console.WriteLine(tablaEstados.Rows.Count.ToString());
                        //  tablaEstados.Rows[posicion][1] = codErroCount.ToString();
                        tablaEstados.Rows[posicion][1] = monitoreos[i].porcentaje_pings_perdidos.ToString();
                        // tablaEstados.Rows[posicion][2] = this.timeCount.ToString();
                        tablaEstados.Rows[posicion][2] = monitoreos[i].tiempo_monitoreo.ToString();
                        //fila[3] = monitoreos[i].fkid_farm.ToString();
                        // fila[4] = monitoreos[i].ip_farm.ToString();
                        //fila[5] = monitoreos[i].nombre_farm.ToString();
                    }
                }
            }

            catch 
            {
               // MessageBox.Show("Continuar");
                timer1.Stop();
                timer1.Enabled = false;
                this.Close();
            }
        }

        //insertar primera vez
        private void button2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvFarmacias.Rows.Count; i++)
            {
                
                client.insertarEstadoEnlace(monitoreos[i].fkid_farm, monitoreos[i].porcentaje_pings_perdidos, monitoreos[i].tiempo_monitoreo, 2, monitoreos[i].ip_farm, monitoreos[i].nombre_farm);
            }
        }
               

        public void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {

            
            if (e.Cancelled)
            {
                Console.WriteLine("Ping cancelado.");
                Console.Read();
                ((AutoResetEvent)e.UserState).Set();
            }


            if (e.Error != null)
            {
                // errorCount++;
                Console.WriteLine("Ping fallido");
                Console.WriteLine(e.Error.ToString());

                ((AutoResetEvent)e.UserState).Set();
            }
            PingReply reply = e.Reply;
            ((AutoResetEvent)e.UserState).Set();
        }


     

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            EstadoEnlace es = new EstadoEnlace();
            ThreadStart proceso = new ThreadStart(realizarPing);
            Thread obj = new Thread(proceso);
            obj.Start();          
            Thread.Sleep(1000);
                      
          
            for (int i = 0; i < monitoreos.Count; i++)
            {          
                monitoreos[i].tiempo_monitoreo++;
            }
            timeCount++;
            lblCurrentTime.Text = timeCount + " seg";
            dgvEstado.DataSource = tablaEstados.Copy();
            lblRate.Text = cadena1;
            lblPingErrors.Text = cadena2;
            lblTotalPings.Text = cadena3;
            lblNombreFarmacia.Text = cadena4;

            if (timer1.Equals(1300000))
            {
                timer1.Stop();
                Thread.Sleep(2000);
                timer1.Start();
            }
        }


        public void playSound(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    player.SoundLocation = path;
                    player.Load();
                    player.Play();
                    
                }
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("Verifica que todas las farmacias tengan su alarma!", "Error");
            }
        }


        private void SendErrorMessage()
        {
            //MessageBox.Show("ADVERTENCIA, INTERMITENCIA EN EL ENLACE!!!");
            //reproducirAlarma();
        }



        //botón insertar farmacia
        private void button1_Click_2(object sender, EventArgs e)
        {
            timer1.Stop();
            Form.ActiveForm.Visible = false;
            Form farmacia = new Farmacia();
            farmacia.Show();
            if (txtTasaErrorRef.Text != "")
            {
                timer1.Stop();
                MessageBox.Show("El ping masivo se ha detenido", "Ingresar nueva Farmacia");
            }
        }

        //BTN ACTUALIZAR BASE
        private void btnActualizarBase_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= dgvEstado.Rows.Count-1; i++)
            {
                client.modificarEstadoEnlace(monitoreos[i].fkid_farm, monitoreos[i].porcentaje_pings_perdidos, monitoreos[i].tiempo_monitoreo, 2, monitoreos[i].ip_farm, monitoreos[i].nombre_farm);
            }
        }


        //BORRAR ESTADOS ENLACE
        private void button3_Click(object sender, EventArgs e)
        {
            btnStop.PerformClick();
            Form.ActiveForm.Visible = false;
            Form elimi = new AccElim();
            elimi.Show();
        }

        //botón parar
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                
                timer1.Stop();
                timer1.Enabled = false;
                monitoreos.Clear();
                pingCount = 0;
                timeCount = 0;
                errorCount = 0;
            }
            catch 
            {
                MessageBox.Show("Continuar");
            }

        }

        //botón limpiar
        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            lblCurrentTime.Text = " ";
            lblTotalPings.Text = " ";
            lblPingErrors.Text = " ";
            lblRate.Text = " ";
            //  txtIP.Text = " ";
            txtTime.Text = " ";
        }

        //botón salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Salir = MessageBox.Show("El monitoreo se detendrá, ¿Salir?", "Salir", MessageBoxButtons.YesNo);

            if (Salir == DialogResult.Yes)
            {
                timer1.Stop();
                this.Close();
            }

        }

       

      
       








    }
}
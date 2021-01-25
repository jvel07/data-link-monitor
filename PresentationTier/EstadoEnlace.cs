using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading;
using System.Data;


namespace PresentationTier 
{
    public class EstadoEnlace
    {       

        public EstadoEnlace()
        {
            pingCount = 0;
            pingErrorCount = 0;
            porcentaje_pings_perdidos = 0;
        }

        
        
        public int id_estado_enlace;
        public float porcentaje_pings_perdidos;
        public int tiempo_monitoreo;
        public int fkid_farm;
        public string ip_farm;
        public string nombre_farm;
        public int pingCount;
        public int pingErrorCount;
        public string pathAlerta;

      
        

        public void calcularTasaError()
        {
            porcentaje_pings_perdidos = ((pingErrorCount * 100) / (120));
            //porcentaje_pings_perdidos = (pingErrorCount * 100) / pingCount ;
            
            //Monitoreo mon = new Monitoreo();
            //pingTime=(Convert.ToInt32(mon.txtTime.Text));                                                
        }

        
       

    }
}

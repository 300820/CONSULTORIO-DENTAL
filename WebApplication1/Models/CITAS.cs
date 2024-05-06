using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CITAS
    {
        public int Citas_ID { get; set; }

        public DateTime Citas_Fechas {  get; set; }

        public string Citas_Hora { get; set; }

        public int ID_Paciente { get; set; }

        public string Citas_Descripcion { get; set; }   

        public string Citas_Estado { get; set; }

        public string Citas_Usuario { get; set; }


    }
}
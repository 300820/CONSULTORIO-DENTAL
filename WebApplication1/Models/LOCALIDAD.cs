using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LOCALIDAD
    {
        public int Localidad_ID { get; set; }
        public int Localidad_Clave { get; set; }
        public string Localidad_Nombre { get; set; }

        public int Municipio_ID { get; set; }   
    }
}
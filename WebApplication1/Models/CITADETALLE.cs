using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CITADETALLE
    {
        public int CITADETALLE_ID { get; set; }
        
        public int CITAS_ID_TRATAMIENTO { get; set; }

        public decimal CITAS_CANTIDAD { get; set; }

        public decimal PRECIO_UNITARIO { get; set; }

        public int Citas_Total { get; set; }

        public int Citas_Precio { get; set; }
         public int Citas_Cita { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PAGOSDETALLE
    {
        
        public int PagoDetalle_ID {  get; set; }

        public int PagoDetalle_IDPAGO { get; set; }

        public decimal PagoDetalle_Cantidad { get; set; }
        public decimal PagoDetalle_PrecioUnit {  get; set; }

        public decimal PagoDetalle_Total { get; set; }  
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PAGOS
    {
        public int PAGOS_ID { get; set; }
        public int PAGOS_PACIENTE_ID { get; set; }
        public string PAGOS_TIPO_DE_PAGO { get; set; }
        public int CITA_ID { get; set; }
        public decimal PAGO_MONTO { get; set; }
    }
}
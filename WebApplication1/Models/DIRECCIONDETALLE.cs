using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DIRECCIONDETALLE
    {
        public int ID_DIRECCIONDETALLE { get; set; }

        public string CalleLateral { get; set; }

        public int CodigoPostal { get; set; }

        public int NumeroExterior { get; set; }

        public int PACIENTELocalidad { get; set; }

    }
}
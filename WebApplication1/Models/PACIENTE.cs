using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PACIENTE
    {
        public int Paciente_ID { get; set; }

        public string Paciente_Nombre { get; set; }

        public string Paciente_ApellidoPaterno { get; set;}
        public string Paciente_ApellidoMaterno { get; set;}
        public string Paciente_Telefono { get; set;}
        public string Paciente_Correo { get; set; }
        public string Paciente_Edad { get; set; }

        public string Paciente_EstadoCivil { get; set; }
        public int Direccion_ID { get; set; }
    }
}
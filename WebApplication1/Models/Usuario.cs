using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }

        public string correo { get; set; }

        public string Clave {  get; set; }

        public string ConfirmarClave { get; set; }

        public string Mensaje { get; set; }
        public int idRol {  get; set; }


    }
}
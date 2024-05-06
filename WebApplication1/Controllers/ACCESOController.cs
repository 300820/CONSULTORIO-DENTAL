using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services.Description;

namespace WebApplication1.Controllers
{
    public class ACCESOController : Controller
    {


        static string conexion = @"Data Source = DESKTOP-OMLQDK2\SQL2019; Initial Catalog = ClinicaDental;User = sa; Password = 21030800; Persist security Info = true";
        public ActionResult LOGIN()
        {
            return View();
        }

        public ActionResult REGISTRO()
        {
            return View();
        }


        [HttpPost]
        public ActionResult REGISTRO(Usuario oUsuario)
        {
            bool registrado;
            string mensaje;

            if (oUsuario.Clave == oUsuario.ConfirmarClave)
            {
                oUsuario.Clave = ConvertirSha256(oUsuario.Clave);

            }
            else
            {
                ViewData["Mensaje"] = "contraenas no coinciden ";
                return View();
            }
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", con);
                cmd.Parameters.AddWithValue("CORREO",oUsuario.correo);
                cmd.Parameters.AddWithValue("CLAVE",oUsuario.Clave);
                cmd.Parameters.AddWithValue("ID_ROL", oUsuario.idRol);
                cmd.Parameters.AddWithValue("MENSAJE", oUsuario.Mensaje);

                cmd.Parameters.Add("REGISTRADO",SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("MENSAJE", SqlDbType.VarChar,100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open(); 

                cmd.ExecuteNonQuery();
                registrado = Convert.ToBoolean(cmd.Parameters["REGISTRADO"].Value);
                mensaje = cmd.Parameters["MENSAJE"].Value.ToString();






            }
            ViewData["Mensaje"] = mensaje;
            if (registrado)
            {
                return RedirectToAction("LOGIN", "REGISTRO");
            }
            else
            {
                return View();
            }

            
        }
        [HttpPost]
        public ActionResult LOGIN(Usuario oUsuario)
        {
            oUsuario.Clave = ConvertirSha256(oUsuario.Clave);
            using (SqlConnection con = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SP_VALIDARUSUARIO", con);
                cmd.Parameters.AddWithValue("CORREO", oUsuario.correo);
                cmd.Parameters.AddWithValue("CLAVE", oUsuario.Clave);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                oUsuario.idUsuario = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                cmd.ExecuteScalar();
            }
            if (oUsuario.idUsuario != 0)
            {
                Session["usuario"] = oUsuario;
                return RedirectToAction("index", "Home");

            }
            else
            {
                ViewData["Mensaje"] = "usuario no encontrado";
                return View();
            }
   

            
        }
        public static string ConvertirSha256(string texto)
        {
            //using System.Text;
            //USAR LA REFERENCIA DE "System.Security.Cryptography"

            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(texto));
                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }




    }
}
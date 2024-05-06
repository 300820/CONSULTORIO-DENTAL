using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Permisos;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [ValidarSesion]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult CerrarSesion()
        {
            Session["CORREO"] = null;
            return RedirectToAction("LOGIN", "ACCESO");
        }
    }
}
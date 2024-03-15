using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrototipoNoSQL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult IniciarSesion()
        { 
            return View();
        }
        public ActionResult Clientes()
        {
            

            return View();
        }
        public ActionResult Rol()
        {


            return View();
        }
        public ActionResult Empleados()
        {


            return View();
        }
        public ActionResult Membresia()
        {


            return View();
        }

        public ActionResult Inventario()
        {


            return View();
        }
        public ActionResult Maquinas()
        {


            return View();
        }
        public ActionResult Proveedores()
        {


            return View();
        }
        public ActionResult Nuevo()
        {


            return View();
        }
        public ActionResult Clases()
        {


            return View();
        }
    }
}
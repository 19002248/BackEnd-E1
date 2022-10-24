using BackEnd_E1.Models;
using BackEnd_E1.Services;
using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace BackEnd_ejemplo1.Controllers
{
    public class CalculosBasController : Controller
    {
        // GET: CalculosBas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma(string Num1, string Num2)
        {
            int res = Convert.ToInt16(Num1) + Convert.ToInt16(Num2);

            ViewBag.Res = Convert.ToString(res);

            return View(res);
        }

        public ActionResult Operas()
        {
            OperasBas op = new OperasBas();
            //lo mandamos así para que se vinculen las propiedades de la clase
            return View(op);
        }
        [HttpPost]
        public ActionResult Operas(OperasBas op)
        {
            op.Suma();
          // ViewBag.Res = op.Res;
            return View(op);
        }

        public ActionResult MuestraPeliculas()
        {
            var pservice = new PeliculasService();
            var model = pservice.ObtenerPeli();
            return View(model);
        }
        public ActionResult MuestraPeliculas2()
        {
            var pservice = new PeliculasService();
            var model = pservice.ObtenerPeli();
            return View(model);
        }
        //Action Result es genérico
        //ContentReult es para contenido
        //ViewResult nos regresa una vista 
        //FileResult es para visualizar archivos
        //JsonResult
        //RedirectResult
        public ActionResult temporal()
        {
            //var alumno1 = new Alumno { Nombre = "juan", Edad = 23 };
            //return Json(alumno1,JsonRequestBehavior.AllowGet);
            return Redirect("https://Google.com.mx");
        }
    }
}
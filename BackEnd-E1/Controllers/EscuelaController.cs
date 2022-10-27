using BackEnd_E1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BackEnd_E1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ActionResult Index()
        {
            ViewBag.nombre = "Eduardo Tomás";
            ViewBag.correo = "eduardo@gmail.com";
            ViewBag.fecha = new DateTime(2001, 12, 10);
            return View();
        }
        public ActionResult Index2()
        {
            ViewData["Nombre"] = "Giselle Cano";
            ViewData["correo"] = "19002248@alumnos.utleon.edu.mx";
            ViewData["fecha"] = new DateTime(2000, 07, 22);
            return View();
        }
        public ActionResult Agregar(Trabajador emp)
        {
            return View(emp);
        }
        public ActionResult Agregar2(Trabajador emp)
        {
            var trab = new Trabajador()
            {
                Nombre="Pedro",
                Apellidos="Lopez",
                FechaN = new DateTime(2000,1,1),
                Sueldo=250,
                EsFijo = true
                };

            ViewBag.Trabajador = trab;
            return View(trab);
        }
    }
}
﻿using BackEnd_ejemplo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}
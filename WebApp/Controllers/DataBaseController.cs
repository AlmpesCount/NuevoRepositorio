using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;

namespace WebApp.Controllers
{
    public class DataBaseController : Controller
    {
        static List<beReporte8> FirstPhone = new List<beReporte8>();
        static List<beReporte8> SecondPhone = new List<beReporte8>();
        static List<beReporte27> ThirdPhone = new List<beReporte27>();
        static List<beReporte9> FirstCET = new List<beReporte9>();
        List<beReporte1> FirstDay = new List<beReporte1>();
        List<beReporte2> SecondDay = new List<beReporte2>();
        List<beReporte25> ThirdDay = new List<beReporte25>();

        public ActionResult Reporte1()
        {
            return View();
        }

        public ActionResult CargarReporte1()
        {
            return Json(new { data = FirstDay }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte2()
        {
            return View();
        }

        public ActionResult CargarReporte2()
        {
            return Json(new { data = SecondDay }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte8()
        {
            return View();
        }

        public ActionResult FirstReport8()
        {
            return Json(new { data = FirstPhone }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SecondReport8()
        {
            return Json(new { data = SecondPhone }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ThirdReport8()
        {
            return Json(new { data = ThirdPhone }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte9()
        {
            return View();
        }

        public ActionResult CargarReporte9()
        {
            return Json(new { data = FirstCET }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte25()
        {
            return View();
        }

        public ActionResult CargarReporte25()
        {
            return Json(new { data = ThirdDay }, JsonRequestBehavior.AllowGet);
        }

	}
}
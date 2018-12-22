using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;
using WebApp.Models;
using System.Data;

namespace WebApp.Controllers
{
    public class ConsultaReporteController : Controller
    {
        brConsultaReporte consulta = new brConsultaReporte();
        static List<Object> lstReporte = new List<Object>();

        public ActionResult ConsultaReportePrincipal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MostrarTablaConsulta(beConsultaReportePrincipal Reporte)
        {
            lstReporte = consulta.TotalTabla(Reporte);

            if (Reporte.TablaID == 1)
            {
                return RedirectToAction("Reporte1", "ConsultaReporte");
            }
            if (Reporte.TablaID == 2)
            {
                return RedirectToAction("Reporte2", "ConsultaReporte");
            }
            if (Reporte.TablaID == 5)
            {
                return RedirectToAction("Reporte5", "ConsultaReporte");
            }
            if (Reporte.TablaID == 7)
            {
                return RedirectToAction("Reporte7", "ConsultaReporte");
            }
            if (Reporte.TablaID == 8)
            {
                return RedirectToAction("Reporte8", "ConsultaReporte");
            }
            if (Reporte.TablaID == 9)
            {
                return RedirectToAction("Reporte9", "ConsultaReporte");
            }
            if (Reporte.TablaID == 10)
            {
                return RedirectToAction("Reporte10", "ConsultaReporte");
            }  
            if (Reporte.TablaID == 11)
            {
                return RedirectToAction("Reporte11", "ConsultaReporte");
            }
            if (Reporte.TablaID == 12)
            {
                return RedirectToAction("Reporte12", "ConsultaReporte");
            }
            if (Reporte.TablaID == 13)
            {
                return RedirectToAction("Reporte13", "ConsultaReporte");
            }
            if (Reporte.TablaID == 15)
            {
                return RedirectToAction("Reporte15", "ConsultaReporte");
            }
            if (Reporte.TablaID == 16)
            {
                return RedirectToAction("Reporte16", "ConsultaReporte");
            }
            if (Reporte.TablaID == 19)
            {
                return RedirectToAction("Reporte19", "ConsultaReporte");
            }
            if (Reporte.TablaID == 20)
            {
                return RedirectToAction("Reporte20", "ConsultaReporte");
            }
            if (Reporte.TablaID == 21)
            {
                return RedirectToAction("Reporte21", "ConsultaReporte");
            }
            if (Reporte.TablaID == 22)
            {
                return RedirectToAction("Reporte22", "ConsultaReporte");
            }
            if (Reporte.TablaID == 25)
            {
                return RedirectToAction("Reporte25", "ConsultaReporte");
            }
            if (Reporte.TablaID == 28)
            {
                return RedirectToAction("Reporte28", "ConsultaReporte");
            }
            return View(Reporte);
        }
        public ActionResult Reporte1()
        {
            return View();
        }

        public ActionResult CargarReporte1()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte2()
        {
            return View();
        }

        public ActionResult CargarReporte2()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte5()
        {
            return View();
        }

        public ActionResult CargarReporte5()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte7()
        {
            return View();
        }

        public ActionResult CargarReporte7()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte8()
        {
            return View();
        }

        public ActionResult CargarReporte8()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte9()
        {
            return View();
        }

        public ActionResult CargarReporte9()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte10()
        {
            return View();
        }

        public ActionResult CargarReporte10()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte11()
        {
            return View();
        }
        public ActionResult CargarReporte11()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte12()
        {
            return View();
        }
        public ActionResult CargarReporte12()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte13()
        {
            return View();
        }
        public ActionResult CargarReporte13()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte15()
        {
            return View();
        }
        public ActionResult CargarReporte15()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte16()
        {
            return View();
        }
        public ActionResult CargarReporte16()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte19()
        {
            return View();
        }
        public ActionResult CargarReporte19()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte20()
        {
            return View();
        }
        public ActionResult CargarReporte20()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte21()
        {
            return View();
        }
        public ActionResult CargarReporte21()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte22()
        {
            return View();
        }
        public ActionResult CargarReporte22()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte25()
        {
            return View();
        }
        public ActionResult CargarReporte25()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte28()
        {
            return View();
        }
        public ActionResult CargarReporte28()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }

    }
}
        

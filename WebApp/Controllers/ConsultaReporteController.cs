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
        brModelReport model = new brModelReport();
        brModelSummary summary = new brModelSummary();

        static List<Object> lstReporte = new List<Object>();

        #region Listas Reporte Base de Datos

        static List<beReporte8> FirstPhone = new List<beReporte8>();
        static List<beReporte8> SecondPhone = new List<beReporte8>();
        static List<beReporte27> ThirdPhone = new List<beReporte27>();
        static List<beReporte9> FirstCET = new List<beReporte9>();
        static List<beReporte1> FirstDay = new List<beReporte1>();
        static List<beReporte2> SecondDay = new List<beReporte2>();
        static List<beReporte25> ThirdDay = new List<beReporte25>();

        #endregion

        #region Listas Reporte Resumen

        static List<beReporte11> FirstSummaryMonth = new List<beReporte11>();
        static List<beReporte11> SecondSummaryMonth = new List<beReporte11>();

        #endregion

        public ActionResult ConsultaReportePrincipal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MostrarTablaConsulta(beConsultaReportePrincipal Reporte)
        {
            #region Consulta Reporte Base de Datos

            //Aqui inician Consulta Reporte Base de Datos
            if (Reporte.TablaID == 1)
            {
                //Esta lista sirve para llenar Vista Reporte1, y los
                //Reportes 2 y 25 contenidos en el.
                FirstDay = model.First_ModelDBDay(Reporte);
                SecondDay = model.Second_ModelDBDay(Reporte);
                ThirdDay = model.Third_ModelDBDay(Reporte);

                return RedirectToAction("Reporte1", "ConsultaReporte");
            }

            if (Reporte.TablaID == 8)
            {
                //Este llenado de listas sirve para las distintas tablas del Reporte8
                FirstPhone = model.First_ModelDBPhone(Reporte);
                SecondPhone = model.Second_ModelDBPhone(Reporte);
                ThirdPhone = model.Third_ModelDBPhone(Reporte);

                return RedirectToAction("Reporte8", "ConsultaReporte");
            }

            if (Reporte.TablaID == 9)
            {
                //Esta lista sirve para llenar Vista Reporte9
                FirstCET = model.ModelDBCET(Reporte);

                return RedirectToAction("Reporte9", "ConsultaReporte");
            }

            //Aqui terminan Consulta Reporte Base de Datos
            #endregion

            #region Consulta Reporte Resumen

            //Aqui inician Consulta Reporte Resumen
            if (Reporte.TablaID == 10)
            {
                lstReporte = consulta.TotalTabla(Reporte);

                return RedirectToAction("Reporte10", "ConsultaReporte");
            }

            if (Reporte.TablaID == 11)
            {
                FirstSummaryMonth = summary.First_SummaryMonth(Reporte);
                SecondSummaryMonth= summary.Second_SummaryMonth(Reporte);

                return RedirectToAction("Reporte11", "ConsultaReporte");
            }

            //Aqui terminan Consulta Reporte Resumen
            #endregion

            if (Reporte.TablaID == 5)
            {
                return RedirectToAction("Reporte5", "ConsultaReporte");
            }
            if (Reporte.TablaID == 7)
            {
                return RedirectToAction("Reporte7", "ConsultaReporte");
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
            if (Reporte.TablaID == 28)
            {
                return RedirectToAction("Reporte28", "ConsultaReporte");
            }
            if (Reporte.TablaID == 29)
            {
                return RedirectToAction("Reporte29", "ConsultaReporte");
            }
            return View(Reporte);
        }

        #region Vistas Base de Datos

        //Aqui se Inician las Vistas Base de Datos
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

        //Aqui se Terminan las Vistas Base de Datos
        #endregion

        #region Vistas Resumen

        //Aqui se Inician las Vistas Resumen
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

        public ActionResult FirstMonth()
        {
            return Json(new { data = FirstSummaryMonth }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SecondMonth()
        {
            return Json(new { data = SecondSummaryMonth }, JsonRequestBehavior.AllowGet);
        }

        //Aqui terminan Vistas Resumen
        #endregion

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
        public ActionResult Reporte28()
        {
            return View();
        }
        public ActionResult CargarReporte28()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Reporte29()
        {
            return View();
        }
        public ActionResult CargarReporte29()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }
    }
}
        

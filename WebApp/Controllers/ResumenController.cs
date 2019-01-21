using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logica;
using Entidades;

namespace WebApp.Controllers
{
    public class ResumenController : Controller
    {
        List<beResumenMes> FirstSummaryMonth = new List<beResumenMes>();
        List<beResumenMes> SecondSummaryMonth = new List<beResumenMes>();
        List<beResumenEvolutivo> lstReporte = new List<beResumenEvolutivo>();

        brModelResumen summary = new brModelResumen();

        #region Resumen Evolutivo

        public ActionResult ResumenEvolutivo(beConsultaReportePrincipal Data)
        {
            if (Data.FechaInicio != Convert.ToDateTime("01/01/0001"))
            {
                lstReporte = summary.EvolutionarySummary(Data);
            }
            return View("ResumenEvolutivo", Data);
        }

        public ActionResult ResumenEvolutivoPartial(beConsultaReportePrincipal Data)
        {
            if (ModelState.IsValid)
            {
                lstReporte = summary.EvolutionarySummary(Data); 
            }
            return PartialView("ResumenEvolutivoPartial", lstReporte);
        }

        public ActionResult CargarReporte10()
        {            
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Reporte Resumen Mes

        public ActionResult ResumenMes()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FirstMonth(beConsultaReportePrincipal Data)
        {
            FirstSummaryMonth = summary.First_SummaryMonth(Data);
            return Json(new { data = FirstSummaryMonth }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SecondMonth(beConsultaReportePrincipal Data)
        {
            SecondSummaryMonth = summary.Second_SummaryMonth(Data);
            return Json(new { data = SecondSummaryMonth }, JsonRequestBehavior.AllowGet);
        }

        #endregion

    }
}
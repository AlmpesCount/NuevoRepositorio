using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;

namespace WebApp.Controllers
{
    public class ChartsController : Controller
    {
        //
        // GET: /Charts/
        public ActionResult ChartsView()
        {
            return View();
        }

        public JsonResult CargarChartArea()
        {
            List<beConsultaReporte> lstReporte = new List<beConsultaReporte>();
            brConsultaReporte reporte = new brConsultaReporte();
            lstReporte = reporte.MostrarConsulta().ToList();

            return Json(lstReporte, JsonRequestBehavior.AllowGet);
        }
	}
}
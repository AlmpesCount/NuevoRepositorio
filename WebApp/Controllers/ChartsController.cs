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

        public ActionResult CargarChartArea()
        {
            List<beConsultaReporte> lstReporte = new List<beConsultaReporte>();
            brConsultaReporte reporte = new brConsultaReporte();
            beConsultaReporte lista = reporte.MostrarConsulta();

            beConsultaReporte entReporte = new beConsultaReporte();
            entReporte.Mes = lista.Mes;
            entReporte.Cantidad = lista.Cantidad;

            lstReporte.Add(entReporte);

            return View();
        }
	}
}
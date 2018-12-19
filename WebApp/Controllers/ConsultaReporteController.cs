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
            if (Reporte.TablaID == 10)
            {
                return RedirectToAction("Reporte10", "ConsultaReporte");
            }  
            if (Reporte.TablaID == 29)
            {
                return RedirectToAction("Reporte29", "ConsultaReporte");
            }
            if (Reporte.TablaID == 28)
            {
                return RedirectToAction("Reporte28", "ConsultaReporte");
            }
            if (Reporte.TablaID == 27)
            {
                return RedirectToAction("Reporte27", "ConsultaReporte");
            }
            if (Reporte.TablaID == 1)
            {
                /*lstReporte = consulta.TotalTabla(Reporte);*/
                return RedirectToAction("Reporte1", "ConsultaReporte");
            }
            if (Reporte.TablaID == 2)
            {
                /*tabla = consulta.MostrarTablaConsulta(Reporte);*/
                return RedirectToAction("Reporte2", "ConsultaReporte");
            }
            if (Reporte.TablaID == 9)
            {
                /*tabla = consulta.MostrarTablaConsulta(Reporte);*/
                return RedirectToAction("Reporte9", "ConsultaReporte");
            }
            if (Reporte.TablaID == 11)
            {
                /*lstReporte = consulta.TotalTabla(Reporte);*/
                return RedirectToAction("Reporte11", "ConsultaReporte");
            }
            if (Reporte.TablaID == 12)
            {
                /*lstReporte = consulta.TotalTabla(Reporte);*/
                return RedirectToAction("Reporte12", "ConsultaReporte");
            }
            if (Reporte.TablaID == 13)
            {
                /*lstReporte = consulta.TotalTabla(Reporte);*/
                return RedirectToAction("Reporte13", "ConsultaReporte");
            }
            return View(Reporte);
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
        public ActionResult Reporte28()
        {
            return View();
        }
        public ActionResult CargarReporte28()
        {
            return Json(new { data = lstReporte }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Reporte10Lists(string sidx, string sord, int page, int rows, string anio, string mes)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beConsultaReporte> todoListsResults = new List<beConsultaReporte>();
            

            if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            {
                /*todoListsResults = lstReporte;*/
            }
            //else
            //{
            //    beConsultaReporte data = new beConsultaReporte();
            //    data.MesID = Convert.ToInt32(mes);
            //    data.AnioID = Convert.ToInt32(anio);
            //    todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = todoListsResults.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = lstReporte
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte29()
        { 
            return View();
        }

        public JsonResult Reporte29Lists(string sidx, string sord, int page, int rows)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beReporte29> todoListsResults = new List<beReporte29>();


            //if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            //{
                /*todoListsResults = ucTablaLista.DataTableToList<beReporte29>(tabla);*/
            //}
            //else
            //{
                //beReporte29 data = new beReporte29();
                //data.MesID = Convert.ToInt32(mes);
                //data.AnioID = Convert.ToInt32(anio);
                //todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = todoListsResults.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = todoListsResults
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult Reporte28()
        //{
        //    return View();
        //}

        public JsonResult Reporte28Lists(string sidx, string sord, int page, int rows)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beReporte28> todoListsResults = new List<beReporte28>();


            //if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            //{
            /*todoListsResults = ucTablaLista.DataTableToList<beReporte28>(tabla);*/
            //}
            //else
            //{
            //beReporte29 data = new beReporte29();
            //data.MesID = Convert.ToInt32(mes);
            //data.AnioID = Convert.ToInt32(anio);
            //todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = todoListsResults.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = todoListsResults
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte27()
        {
            return View();
        }

        public JsonResult Reporte27Lists(string sidx, string sord, int page, int rows)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beReporte27> todoListsResults = new List<beReporte27>();


            //if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            //{
            /*todoListsResults = ucTablaLista.DataTableToList<beReporte27>(tabla);*/
            //}
            //else
            //{
            //beReporte29 data = new beReporte29();
            //data.MesID = Convert.ToInt32(mes);
            //data.AnioID = Convert.ToInt32(anio);
            //todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = todoListsResults.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = todoListsResults
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte1()
        {
            return View();
        }

        public JsonResult Reporte1Lists(string sidx, string sord, int page, int rows)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beReporte1> todoListsResults = new List<beReporte1>();


            //if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            //{
            /*todoListsResults = ucTablaLista.DataTableToList<beReporte1>(tabla);*/
            //}
            //else
            //{
            //beReporte29 data = new beReporte29();
            //data.MesID = Convert.ToInt32(mes);
            //data.AnioID = Convert.ToInt32(anio);
            //todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = lstReporte.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = lstReporte
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reporte2()
        {
            return View();
        }

        public JsonResult Reporte2Lists(string sidx, string sord, int page, int rows)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beReporte2> todoListsResults = new List<beReporte2>();


            //if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            //{
            /*todoListsResults = ucTablaLista.DataTableToList<beReporte2>(tabla);*/
            //}
            //else
            //{
            //beReporte29 data = new beReporte29();
            //data.MesID = Convert.ToInt32(mes);
            //data.AnioID = Convert.ToInt32(anio);
            //todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = todoListsResults.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = todoListsResults
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Reporte9()
        {
            return View();
        }

        public JsonResult Reporte9Lists(string sidx, string sord, int page, int rows)  //Gets the todo Lists.
        {
            int pageIndex = Convert.ToInt32(page) - 1;
            int pageSize = rows;
            List<beReporte9> todoListsResults = new List<beReporte9>();


            //if (string.IsNullOrEmpty(mes) || string.IsNullOrEmpty(anio))
            //{
            /*todoListsResults = ucTablaLista.DataTableToList<beReporte9>(tabla);*/
            //}
            //else
            //{
            //beReporte29 data = new beReporte29();
            //data.MesID = Convert.ToInt32(mes);
            //data.AnioID = Convert.ToInt32(anio);
            //todoListsResults = consulta.MostrarConsulta(data).ToList();
            //}

            int totalRecords = todoListsResults.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)rows);

            var jsonData = new
            {
                total = totalPages,
                page,
                records = totalRecords,
                rows = todoListsResults
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

    }
}
        

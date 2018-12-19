using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;
using System.Data;

namespace WebApp.Controllers
{
    public class HeadPhoneController : Controller
    {
        //
        // GET: /HeadPhone/
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public JsonResult MostrarHeadPhone()
        {
            brHeadPhone head = new brHeadPhone();
            var dtHead = head.CargarHead();
            return Json(dtHead, JsonRequestBehavior.AllowGet);
        }
	}
}
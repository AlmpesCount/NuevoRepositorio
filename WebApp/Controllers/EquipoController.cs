using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;

namespace WebApp.Controllers
{
    public class EquipoController : Controller
    {
        // GET: Equipo
        brEquipo equipo = new brEquipo();
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public JsonResult MostrarEquipo()
        {
            List<beEquipo> lstEquipo = new List<beEquipo>();
            lstEquipo = equipo.MostrarEquipo().ToList();
            return Json(lstEquipo, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public string Create([Bind(Exclude = "Id")] beEquipo equipo)
        {
            brEquipo db = new brEquipo();
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    equipo.COD_UNI_CAB = Guid.NewGuid().ToString();
                    db.InsertarPC(equipo);
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }

        public string Edit(beEquipo equipo)
        {   
            //ApplicationDbContext db = new ApplicationDbContext();
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    brEquipo objInv = new brEquipo();
                    objInv.ActualizarPC(equipo);
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Validation data not successfully";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }

        public string Delete(string Id)
        {
            beEquipo equipo = new beEquipo();
            equipo.COD_UNI_CAB = Id;
            brEquipo tec = new brEquipo();
            tec.EliminarPC(equipo.COD_UNI_CAB);
            return "Deleted successfully";
        }  
    }
}
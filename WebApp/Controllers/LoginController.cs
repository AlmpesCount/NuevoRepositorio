using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;
using System.Web.Script.Serialization;
using System.Web.Helpers;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Logeo
        public ActionResult Login()
        {
            return View();
        }
        public static string ValidUser(beUserCRM model)
        {
            brLogin Login = new brLogin();
            var user = Login.LoginUserCRM(model);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(user);
        }

        [HttpPost]
        public ActionResult Authorize(beUserCRM userModel)
        {
            if(ModelState.IsValid)
            {
                string sJson = ValidUser(userModel);
                if (sJson != "" && sJson != "[]")
                {
                    Session["USUARIO"] = userModel.USUARIO;
                    return RedirectToAction("ConsultaReportePrincipal", "ConsultaReporte");
                }
                else
                {
                    ModelState.AddModelError("General", "El usuario o password no son correctos.");
                    return View("~/Views/Login/Login.cshtml");
                }
            }
            return View(userModel); 
        }

        public ActionResult LogOut()
        {
            int userID = (int)Session["USUARIO"];
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }
    }
}
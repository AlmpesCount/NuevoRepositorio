using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Logica;

namespace WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        brUsuario usuario = new brUsuario();
        //
        // GET: /Usuario/
        public JsonResult MostrarUsuario()
        {
            List<beUsuario> lstUsuario = new List<beUsuario>();
            lstUsuario = usuario.MostrarUsuarios().ToList();
            return Json(lstUsuario, JsonRequestBehavior.AllowGet);
        }
	}
}
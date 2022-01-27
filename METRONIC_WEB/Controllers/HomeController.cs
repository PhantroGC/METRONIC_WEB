using CL_NE;
using ClassLibrary1;
using METRONIC_WEB.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Diagnostics;

namespace METRONIC_WEB.Controllers
{
    
    public class HomeController : Controller
    {

        List<CL_UsuarioEN> ListaUsuario;
        CL_UsuarioNE CL_Negocio = new CL_UsuarioNE();

       
        public ActionResult Index()
        {
            
            
            return View();
        }
        [Authorize]
        public ActionResult About() 
        {
            return View();
        }
        [Authorize]
        public ActionResult faq() 
        {
            return View();
        }
        [Authorize]
        public ActionResult Usuario() 
        {
            return View();
        }
        public JsonResult ObtenerDatosDelUsuario() 
        {
            ListaUsuario = Session["usuario"] as List<CL_UsuarioEN>;
            //var listaMenu = CL_Negocio.ListaMenu();
            CL_UsuarioEN UsuarioEN = new CL_UsuarioEN();
            return Json(new { success = ListaUsuario }, JsonRequestBehavior.AllowGet);


        }


        [HttpPost]
        public JsonResult Autenticar(Usuario CLUsuario)
        {
            
            ListaUsuario = new CL_UsuarioNE().Login(CLUsuario);
            if (ListaUsuario.Count > 0)
            {
                FormsAuthentication.SetAuthCookie("usuario", false);
                Session["usuario"] = ListaUsuario;
                return Json(new { success = true }, JsonRequestBehavior.AllowGet);

            }
            else
            {
                return Json(new { success = false }, JsonRequestBehavior.AllowGet);
            }
            #region CerrarSesion
        }
        public ActionResult CerrarSesion()
        {
            FormsAuthentication.SignOut();
            Session["usuario"] = null;
            return RedirectToAction("Index", "Home");
        }
        #endregion

        [Authorize]
        public ActionResult _User() 
        {
            return View("_User");
        }
        #region SinPermisoEstatico
        public ActionResult SinPermiso() 
        {
            ViewBag.Message = " No cuenta con permiso para ver esta pagina";
            return View();
        }
        #endregion
        //[PermisosRol(CL_Tipo.Administrador)]
        [Authorize]
        public ActionResult Components() 
        {
            return View();
        }
        

    }
}
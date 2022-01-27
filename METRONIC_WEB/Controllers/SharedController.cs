using CL_NE;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace METRONIC_WEB.Controllers
{
    public class SharedController : Controller
    {
        
        CL_UsuarioEN Entidad = new CL_UsuarioEN();
        // GET: Shared

        public ActionResult Index()
        {

            return View();
        }
        
        public ActionResult _Layout(/*Usuario CLUsuario*/)
        {
            //Entidad = new CL_UsuarioNE().Login(CLUsuario);
            //if (Entidad.id_Tipo != 0)
            //{
            //    return RedirectToAction("_Layout", "Shared");
            //}
            return View();
          
        }
        public ActionResult _User()
        {
            return View();
        }
       




    }
}
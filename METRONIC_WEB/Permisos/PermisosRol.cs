using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace METRONIC_WEB.Permisos
{
    public class PermisosRol : ActionFilterAttribute
    {
        private CL_Tipo IdTipo;

        public PermisosRol(CL_Tipo id_Tipo) 
        {
            IdTipo = id_Tipo;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext) 
        {
            if (HttpContext.Current.Session["usuario"] !=null) 
            {
                CL_UsuarioEN usuario = (CL_UsuarioEN)HttpContext.Current.Session["usuario"];

                if (usuario.id_Tipo != 1) 
                {
                    filterContext.Result = new RedirectResult("~/Home/SinPermiso");
                }
            }
            base.OnActionExecuting(filterContext);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppMedico.Filtros
{
    public class MedicoAutorizacaoFilterAttribute: ActionFilterAttribute
    {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                object MedicoLogado = filterContext.HttpContext.Session["MedicoLogado"];
                if (MedicoLogado == null)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary(
                            new { Action = "Index", Controller = "Usuario" }));
                }
            }
    } 
}
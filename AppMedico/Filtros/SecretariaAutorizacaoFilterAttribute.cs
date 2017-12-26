using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AppMedico.Filtros
{
    public class SecretariaAutorizacaoFilterAttribute: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            object SecretariaLogado = filterContext.HttpContext.Session["SecretariaLogado"];
            if (SecretariaLogado == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new { Action = "Index", Controller = "Usuario" }));
            }
        }
    }
}
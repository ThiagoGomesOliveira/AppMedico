using AppMedico.DAO;
using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AppMedico.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            Session["SecretariaLogado"] = null;
            Session["MedicoLogado"] = null;
            Session["Logado"] = null;
            return View();
        }

        public ActionResult Autentica(string login, string senha)
        {
                UsuarioDAO dao = new UsuarioDAO();
                var usuario = dao.Buscar(login, senha);

            if (usuario != null)
            {
                if (usuario.IDUsuario == 2)
                {
                    Session["MedicoLogado"] = usuario;
                    return RedirectToAction("Index", "Home");
                }
                else if (usuario.IDUsuario == 3)
                {
                    Session["SecretariaLogado"] = usuario;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Session["Logado"] = usuario;
                    return RedirectToAction("Index", "Home");
                }
              
            }
            return RedirectToAction("Index");
        }
    }
}


    
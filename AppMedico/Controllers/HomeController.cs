using AppMedico.DAO;
using AppMedico.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMedico.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {
            MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
            var listaDia = consultaDao.ListarConsultasDia();
            PacienteDAO pacienteDao = new PacienteDAO();

           
            ViewBag.Paciente = pacienteDao.QuantidadePacientes();
            ViewBag.Consulta = consultaDao.QtdConsultaMes();
            ViewBag.MediaConsulta = consultaDao.MediaConsultaMes();
            ViewBag.Opos = consultaDao.QuantidadeConsultaDia();
            ViewBag.Data = DateTime.Today.ToString("dd/MM/yyyy");

            return View(listaDia);
        }
    }
}
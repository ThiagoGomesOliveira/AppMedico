using AppMedico.DAO;
using AppMedico.Filtros;
using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMedico.Controllers
{
   
    public class MarcarConsultaController : Controller
    {
        // GET: MarcarConsulta
       
        public ActionResult Index()
        {
            MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
            var consulta = consultaDao.Listar();
            ViewBag.Consulta = consulta;
            return View(consulta);
        }
        public ActionResult Adiciona()
        {
            MedicoDAO medicoDao = new MedicoDAO();
            var medico = medicoDao.Listar();
            ViewBag.Medico = medico;

            PacienteDAO pacienteDao = new PacienteDAO();
            var paciente = pacienteDao.Listar();
           

            ViewBag.Paciente = paciente;
          
            ViewBag.Consulta = new MarcarConsulta();
            return View();
        }
        [HttpPost]
        public ActionResult Adicionar(MarcarConsulta consulta)
        {
            if (ModelState.IsValid)
            {
                MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
                consultaDao.Adcionar(consulta);
                return RedirectToAction("Index","MarcarConsulta");
            }
            else
            {
                MedicoDAO medicoDao = new MedicoDAO();
                var medico = medicoDao.Listar();
                ViewBag.Medico = medico;

                PacienteDAO pacienteDao = new PacienteDAO();
                var paciente = pacienteDao.Listar();
                ViewBag.Paciente = paciente;

                ViewBag.Consulta = consulta;
                return View("Adicionar");
            }
        }
        public ActionResult Editar(int id = 0)
        {
            if (id == 0) { return RedirectToAction("Index"); }
            
            MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
            var consulta = consultaDao.BuscarPorId(id);

            PacienteDAO pacienteDao = new PacienteDAO();
            var paciente = pacienteDao.Listar();
            ViewBag.IDPaciente = new SelectList ( paciente , "IDPaciente", "Nome", consulta.IDPaciente );

            MedicoDAO medicoDao = new MedicoDAO();
            var medico = medicoDao.Listar();
            ViewBag.IDMedico = new SelectList(medico, "IDMedico", "Nome", consulta.IDMedico);
            return View(consulta);
        }
        [HttpPost]
        public ActionResult Editar(MarcarConsulta consulta)
        {
            if (ModelState.IsValid)
            {
                MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
                consultaDao.Atualizar(consulta);
                return RedirectToAction("Index", "MarcarConsulta");
            }
            else
            {
                PacienteDAO pacienteDao = new PacienteDAO();
                var paciente = pacienteDao.Listar();
                ViewBag.IDPaciente = new SelectList(paciente, "IDPaciente", "Nome", consulta.IDPaciente);

                MedicoDAO medicoDao = new MedicoDAO();
                var medico = medicoDao.Listar();
                ViewBag.IDMedico = new SelectList(medico, "IDMedico", "Nome", consulta.IDMedico);
                return View(consulta);
            }
        }
        public ActionResult Visualizar(int id=0)
        {
            if (id == 0) { return RedirectToAction("Index"); }
            MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
            var consulta = consultaDao.BuscarPorId(id);
            ViewBag.Consulta = consulta;
            return View(consulta);
        }
        [SecretariaAutorizacaoFilter]
        public ActionResult Excluir(int id)
        {
            MarcarConsultaDAO consultaDao = new MarcarConsultaDAO();
            consultaDao.Excluir(id);
            var resposta = consultaDao.Listar();
            if (Request.IsAjaxRequest())
            {
                return PartialView("_Index",resposta);
            }
            return RedirectToAction("Index",resposta);
        }
    }
}
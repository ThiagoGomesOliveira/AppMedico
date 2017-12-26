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
   [MedicoAutorizacaoFilter]
    public class ProntuarioController : Controller
    {
        // GET: Prontuario
        public ActionResult Index()
        {
            ProntuarioDAO prontuarioDao = new ProntuarioDAO();
            var prontuario = prontuarioDao.Listar();
            ViewBag.Prontuario = prontuario;
            return View(prontuario);
        }
        public ActionResult Adicionar()
        {
                    PacienteDAO pacienteDao = new PacienteDAO();
                    var paciente = pacienteDao.Listar();
                    ViewBag.Paciente = paciente;
                    ViewBag.Prontuario = new x();
                    return View();
        }
        [HttpPost]
       public ActionResult Adiciona(x prontuario)
        {
            if (ModelState.IsValid)
            {
                ProntuarioDAO prontuarioDao = new ProntuarioDAO();
                prontuarioDao.Adicionar(prontuario);
                return RedirectToAction("Index", "Prontuario");
            }
            else
            {
                PacienteDAO pacienteDao = new PacienteDAO();
                var paciente = pacienteDao.Listar();
                ViewBag.Paciente = paciente;
                ViewBag.Prontuario = prontuario;
                return View("Adicionar");
            }
        }
        public ActionResult Editar(int id= 0)
        {
            if (id == 0){return RedirectToAction("Index");}
            ProntuarioDAO prontuarioDao = new ProntuarioDAO();
            var prontuario = prontuarioDao.BuscarPorId(id);

            PacienteDAO pacienteDao = new PacienteDAO();
            var paciente = pacienteDao.Listar();
            ViewBag.IDPaciente = new SelectList(paciente, "IDPaciente", "Nome", prontuario.IDPaciente);
            return View(prontuario);
        }
        [HttpPost]
        public ActionResult Editar(x prontuario)
        {
            if (ModelState.IsValid)
            {
                ProntuarioDAO prontuarioDao = new ProntuarioDAO();
                prontuarioDao.Atualizar(prontuario);
               return RedirectToAction("Index","Prontuario");
            }
            else
            {
                PacienteDAO pacienteDao = new PacienteDAO();
                var paciente = pacienteDao.Listar();
                ViewBag.IDPaciente = new SelectList(paciente, "IDPaciente","Nome", prontuario.IDPaciente);
                return View(prontuario);
            }
        }
        public ActionResult Visualizar(int id = 0)
        {
            if (id == 0) { return RedirectToAction("Index"); }
            ProntuarioDAO prontuarioDao = new ProntuarioDAO();
            var prontuario = prontuarioDao.BuscarPorId(id);
            ViewBag.Prontuario = prontuario;
            return View(prontuario);
        }

        public ActionResult ProntuarioMedico(int id = 0 )
        {
            if (id == 0) { return RedirectToAction("Index"); }
            PacienteDAO pacienteDao = new PacienteDAO();
            var paciente = pacienteDao.BuscarPorId(id);
            ViewBag.Paciente = paciente;
            ViewBag.Prontuario = new x();
            return View();
        }

        [HttpPost]
        public ActionResult ProntuarioMedicoAdiciona(x prontuario)
        {
            if (ModelState.IsValid)
            {
                ProntuarioDAO prontuarioDao = new ProntuarioDAO();
                prontuarioDao.Adicionar(prontuario);
                return RedirectToAction("Index", "Prontuario");
            }
            else
            {
                PacienteDAO pacienteDao = new PacienteDAO();
                var paciente = pacienteDao.Listar();
                ViewBag.Paciente = paciente;
                ViewBag.Prontuario = prontuario;
                return View("Adicionar");
            }
        }
    }
    }

    



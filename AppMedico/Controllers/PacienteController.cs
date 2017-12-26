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
   
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            PacienteDAO pacienteDao = new PacienteDAO();
            var paciente = pacienteDao.Listar();
            return View(paciente);
        }
        [SecretariaAutorizacaoFilter]
        public ActionResult Adicionar()
        {
            CidadeDAO cidadeDao = new CidadeDAO();
            var cidade = cidadeDao.Listar();
            ViewBag.Cidade = cidade;

            EstadoDAO estadoDao = new EstadoDAO();
            var estado = estadoDao.Lista();
            ViewBag.Estado = estado;

            ViewBag.Paciente = new Paciente();
            return View();
        }
        [HttpPost]
        public ActionResult Adiciona(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                PacienteDAO pacienteDao = new PacienteDAO();
                pacienteDao.Adicionar(paciente);
                return RedirectToAction("Index", "Paciente");
            }
            else
            {
                CidadeDAO cidadeDao = new CidadeDAO();
                var cidade = cidadeDao.Listar();
                ViewBag.Cidade = cidade;

                EstadoDAO estadoDao = new EstadoDAO();
                var estado = estadoDao.Lista();
                ViewBag.Estado = estado;

                ViewBag.Paciente = paciente;
                return View("Adicionar");
            }
        }
        [SecretariaAutorizacaoFilter]
        public ActionResult Editar(int id = 0)
        {
            if (id == 0) { return RedirectToAction("Index", "Paciente");}

                PacienteDAO pacienteDao = new PacienteDAO();

                ViewBag.Paciente = new Paciente();
                var paciente = pacienteDao.BuscarPorId(id);

                CidadeDAO cidadeDao = new CidadeDAO();
                var cidade = cidadeDao.Listar();
                ViewBag.IDCidade = new SelectList(cidade, "IDCidade", "Nome", paciente.IDCidade);

                EstadoDAO estadoDao = new EstadoDAO();
                var estado = estadoDao.Lista();
                ViewBag.IDEstado = new SelectList(estado, "IDEstado", "Nome", paciente.IDEstado);

                return View(paciente);
        }
        [HttpPost]
        public ActionResult Editar(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                PacienteDAO pacienteDao = new PacienteDAO();
                pacienteDao.Atualizar(paciente);
                return RedirectToAction("Index", "Paciente");
            }
            else
            {
                CidadeDAO cidadeDao = new CidadeDAO();
                var cidade = cidadeDao.Listar();
                ViewBag.IDCidade = new SelectList(cidade, "IDCidade", "Nome", paciente.IDCidade);

                EstadoDAO estadoDao = new EstadoDAO();
                var estado = estadoDao.Lista();
                ViewBag.IDEstado = new SelectList(estado, "IDEstado", "Nome", paciente.IDEstado);
                return View(paciente);
            }
        }
        public ActionResult Visualizar (int id=0)
        {
            if (id == 0){return RedirectToAction("Index");}

                PacienteDAO pacienteDao = new PacienteDAO();
                var paciente = pacienteDao.BuscarPorId(id);
                ViewBag.Paciente = paciente;
                 return View(paciente);
        }
    }
}
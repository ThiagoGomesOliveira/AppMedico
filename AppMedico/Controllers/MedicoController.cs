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
    public class MedicoController : Controller
    {
        // GET: Medico
        public ActionResult Index()
        {
            MedicoDAO dao = new MedicoDAO();
            var medicos = dao.Listar();
            ViewBag.Medico = medicos;
            return View(medicos);
        }
        [AutorizacaoFilter]
        public ActionResult Adiciona()
        {
            CidadeDAO cidadeDao = new CidadeDAO();
            var cidade = cidadeDao.Listar();
            ViewBag.Cidade = cidade;

            EstadoDAO estadoDao = new EstadoDAO();
            var estado = estadoDao.Lista();
            ViewBag.Estado = estado;

            EspecialidadeDAO especDao = new EspecialidadeDAO();
            var especialidade = especDao.Listar();
            ViewBag.Especialidade = especialidade;

           ViewBag.Medico = new Medicos();
            return View();
        }
        [HttpPost]
        public ActionResult Adicionar(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                MedicoDAO dao = new MedicoDAO();
                dao.Adicionar(medico);
                return RedirectToAction("Index","Medico");
            }
            else
            {
                CidadeDAO cidadeDao = new CidadeDAO();
                var cidade = cidadeDao.Listar();
                ViewBag.Cidade = cidade;

                EstadoDAO estadoDao = new EstadoDAO();
                var estado = estadoDao.Lista();
                ViewBag.Estado = estado;

                EspecialidadeDAO especDao = new EspecialidadeDAO();
                var especialidade = especDao.Listar();
                ViewBag.Especialidade = especialidade;

                ViewBag.Medico = medico;
                return View("Adiciona");
            }
        }
        [AutorizacaoFilter]
        public ActionResult Editar(int id)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }

            MedicoDAO medicoDao = new MedicoDAO();

            ViewBag.Medico = new Medicos();
            Medicos medico = medicoDao.BuscarPorId(id);

            CidadeDAO cidadeDao = new CidadeDAO();
            var cidade = cidadeDao.Listar();
            ViewBag.IDCidade = new SelectList(cidade,"IDCidade","Nome",medico.IDCidade);

            EstadoDAO estadoDao = new EstadoDAO();
            var estado = estadoDao.Lista();
            ViewBag.IDEstado = new SelectList(estado, "IDEstado", "Nome", medico.IDEstado);

            EspecialidadeDAO especDao = new EspecialidadeDAO();
            var especialidade = especDao.Listar();
            ViewBag.IDEspecialidade = new SelectList(especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);
           
            return View(medico);
        }
        [HttpPost]
        public ActionResult Editar(Medicos medico)
        {
            if (ModelState.IsValid)
            {
                MedicoDAO medicoDao = new MedicoDAO();
                medicoDao.Atualizar(medico);
                return RedirectToAction("Index", "Medico");
            }
            else
            {
                CidadeDAO cidadeDao = new CidadeDAO();
                var cidade = cidadeDao.Listar();
                ViewBag.IDCidade = new SelectList(cidade, "IDCidade", "Nome", medico.IDCidade);

                EstadoDAO estadoDao = new EstadoDAO();
                var estado = estadoDao.Lista();
                ViewBag.IDEstado = new SelectList(estado, "IDEstado", "Nome", medico.IDEstado);

                EspecialidadeDAO especDao = new EspecialidadeDAO();
                var especialidade = especDao.Listar();
                ViewBag.IDEspecialidade = new SelectList(especialidade, "IDEspecialidade", "Nome", medico.IDEspecialidade);

                return View (medico);
            }
        }
        public ActionResult Visualizar(int id =0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            MedicoDAO medicoDao = new MedicoDAO();
            var medico = medicoDao.BuscarPorId(id);
            ViewBag.Medico = medico;

            return View(medico);
        }
        public ActionResult Excluir(int id =0)
        {
            if (id == 0)
            {
                return RedirectToAction("Index");
            }
            MedicoDAO medico = new MedicoDAO();
            medico.Excluir(id);

            return RedirectToAction("Index", "Medico");
        }
    }
}

    

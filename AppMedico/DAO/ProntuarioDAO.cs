using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AppMedico.Models;

namespace AppMedico.DAO
{
    public class ProntuarioDAO
    {
        public IList<x> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Prontuario.Include(p=> p.Paciente).ToList();
            }
        }
        public void Adicionar(x prontuario)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Prontuario.Add(prontuario);
                context.SaveChanges();
                ExcluirConsulta(prontuario.IDProntuario);
            }
        }
        public void Atualizar(x prontuario)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Entry(prontuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public x BuscarPorId(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
              return context.Prontuario
                    .Include("Paciente")
                    .Where(p => p.IDProntuario == id)
                    .FirstOrDefault();
            }
        }
        public void ExcluirConsulta(int id)
        {
            PostoMedicoEntities context = new PostoMedicoEntities();
             var prontuario = context.Prontuario
                .Include("Paciente")
                .Where(p=> p.IDProntuario == id)
                .FirstOrDefault();

            var consulta = context.MarcarConsulta
                .Where(m => m.Paciente.IDPaciente == prontuario.Paciente.IDPaciente)
                .First();

            var numero = consulta.IDConsulta;
            MarcarConsultaDAO dao = new MarcarConsultaDAO();
            dao.Excluir(numero);
        }
    }
}
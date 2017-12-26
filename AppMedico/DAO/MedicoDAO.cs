using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace AppMedico.DAO
{
    public class MedicoDAO
    {
        public IList<Medicos> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Medicos
                    .Include(m=> m.Cidade)
                    .Include(m=>m.Estado)
                    .Include(m=>m.Especialidades)
                    .ToList();
            }
        }
        public void Adicionar(Medicos medico)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Medicos.Add(medico);
                context.SaveChanges();
            }
        }
        public void Atualizar(Medicos medico)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Entry(medico).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Medicos BuscarPorId(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
              return  context.Medicos
                    .Include("Cidade")
                    .Include("Especialidades")
                    .Include("Estado")
                    .Where(m => m.IDMedico == id)
                    .FirstOrDefault();
            }
        }
        public void Excluir(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
                var medico = context.Medicos.Find(id);
                context.Medicos.Remove(medico);
                context.SaveChanges();
            }
        }
    }
}
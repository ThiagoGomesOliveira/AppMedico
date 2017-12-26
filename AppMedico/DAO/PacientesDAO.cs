using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppMedico.DAO
{
    public class PacientesDAO
    {
        public IList<Paciente> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Paciente
                       .Include(p => p.Cidade)
                       .Include(p => p.Bairro)
                       .ToList();
            }
        }

        public void Adcionar(Paciente paciente)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Paciente.Add(paciente);
                context.SaveChanges();

            }
        }

        public void Atualizar(Paciente paciente)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Entry(paciente).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Paciente BuscaPorId(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Paciente
                    .Include("Cidade")
                    .Include("Estado")
                    .Where(p =>  p.IDPaciente == id)
                    .FirstOrDefault();
            }
        }
    }
}
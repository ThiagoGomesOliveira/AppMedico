using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppMedico.DAO
{
    public class PacienteDAO
    {
        public IList<Paciente> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Paciente
                    .Include(p => p.Cidade)
                    .Include(p => p.Estado)
                    .ToList();
            }
        }
        public void Adicionar(Paciente paciente)
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
        public Paciente BuscarPorId(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Paciente
                    .Include("Cidade")
                    .Include("Estado")
                    .Where(p => p.IDPaciente == id)
                    .FirstOrDefault();
            }
        }
        public int QuantidadePacientes()
        {
            using (var context = new PostoMedicoEntities())
            {
                var paciente = context.Paciente.ToList();
                int quantidade = paciente.Count();
                return quantidade;
            }
        }
        public int QtdTipoSangueOpositivo()
        {
            using (var context = new PostoMedicoEntities())
            {
                var Opositivo = context.Paciente.Where(p => p.TipoSangue.Equals("o+")).ToList().Count();
                return Opositivo;
            }
        }

        public string BuscarCpf(int id)
        {
            using (var context  = new PostoMedicoEntities())
            {
                var paciente = BuscarPorId(id);
                var cpf = paciente.CPF;
                return cpf;
            }
        }
    }
}
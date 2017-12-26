using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace AppMedico.DAO
{
    public class MarcarConsultaDAO
    {
        public IList<MarcarConsulta> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.MarcarConsulta.Include(m=> m.Medicos).Include(m=> m.Paciente).ToList();
            }
        }
        public void Atualizar(MarcarConsulta consulta)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Entry(consulta).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public MarcarConsulta BuscarPorId(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.MarcarConsulta
                     .Include("Medicos")
                     .Include("Paciente")
                     .Where(m => m.IDConsulta == id)
                     .FirstOrDefault();
            }
        }
        public void Adcionar(MarcarConsulta consulta)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.MarcarConsulta.Add(consulta);
                context.SaveChanges();
            }
        }
        public void Excluir(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
                var consulta = context.MarcarConsulta.Find(id);
                context.MarcarConsulta.Remove(consulta);
                context.SaveChanges();
            }
        }
        public IList<MarcarConsulta> ListarConsultasDia()
        {
            using (var context = new PostoMedicoEntities())
            {
                var consultaDia = DateTime.Today;

                var lista = context.MarcarConsulta
                    .Include(m=> m.Paciente)
                    .Where(m => m.Data == consultaDia)
                    .ToList();
                    lista.OrderBy(l => l.Hora);
                return lista;
            }
        }
        public int QuantidadeConsultaDia()
        {
            using (var context = new PostoMedicoEntities())
            {
                var consultaDia = DateTime.Today;

                var lista = context.MarcarConsulta
                    .Include(m => m.Paciente)
                    .Where(m => m.Data == consultaDia)
                    .ToList().Count();
                  
                return lista;
            }
        }

        public int QtdConsultaMes()
        {
            var mes = DateTime.Now.Month;
            using (var context = new PostoMedicoEntities())
            {
                var consultaMes = context.MarcarConsulta.Where(m => m.Data.Month == mes).ToList();

                return consultaMes.Count();
            }
        }  
        public int MediaConsultaMes()
        {
            using (var context = new PostoMedicoEntities())
            {
                var mesConsultas = context.MarcarConsulta.ToList().Count();
                var media = mesConsultas /12;
                return media;
            }
        }
    }
}
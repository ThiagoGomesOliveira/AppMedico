using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMedico.DAO
{
    public class EspecialidadeDAO
    {
        public IList<Especialidades> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Especialidades.ToList();
            }
        }
        public void Adicionar(Especialidades especialidade)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Especialidades.Add(especialidade);
                context.SaveChanges();
            }
        }
    }
}
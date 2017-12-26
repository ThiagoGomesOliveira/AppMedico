using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppMedico.DAO
{
    public class EstadoDAO
    {
        public IList<Estado> Lista()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Estado.ToList();
            }
        }
    }
}
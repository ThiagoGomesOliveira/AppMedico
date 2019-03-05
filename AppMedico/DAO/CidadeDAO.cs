using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;

namespace AppMedico.DAO
{
    public class CidadeDAO
    {
        public IList<Cidade> Listar()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Cidade.SqlQuery("Select * from Cidade").ToList();
            }
        }

        
    }
}
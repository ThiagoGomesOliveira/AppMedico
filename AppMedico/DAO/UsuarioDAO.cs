using AppMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppMedico.DAO
{
    public class UsuarioDAO
    {
        public void Adcionar(Usuarios usuario)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }
        public IList<Usuarios> Lista()
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Usuarios.ToList();
            }
        }
        public Usuarios BuscarPorId(int id)
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Usuarios.Find(id);
            }
        }
        public void Atualizar(Usuarios usuario)
        {
            using (var context = new PostoMedicoEntities())
            {
                context.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public Usuarios Buscar(string login, string senha)
        {
            using (var context = new PostoMedicoEntities())
            {
                return context.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha );
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppMedico.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PostoMedicoEntities : DbContext
    {
        public PostoMedicoEntities()
            : base("name=PostoMedicoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cidade> Cidade { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<MarcarConsulta> MarcarConsulta { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<x> Prontuario { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    }
}
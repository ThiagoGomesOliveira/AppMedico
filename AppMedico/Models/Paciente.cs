//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Prontuario = new HashSet<x>();
            this.MarcarConsulta = new HashSet<MarcarConsulta>();
        }
    
        public int IDPaciente { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string TipoSangue { get; set; }
        public string Enfermidade { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int IDCidade { get; set; }
        public int IDEstado { get; set; }
    
        public virtual Cidade Cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<x> Prontuario { get; set; }
        public virtual Estado Estado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarcarConsulta> MarcarConsulta { get; set; }
    }
}
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
    
    public partial class Medicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicos()
        {
            this.MarcarConsulta = new HashSet<MarcarConsulta>();
        }
    
        public int IDMedico { get; set; }
        public string CRM { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Nullable<bool> AtendePorConvenio { get; set; }
        public Nullable<bool> TemClinica { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int IDCidade { get; set; }
        public int IDEstado { get; set; }
        public int IDEspecialidade { get; set; }
    
        public virtual Cidade Cidade { get; set; }
        public virtual Especialidades Especialidades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MarcarConsulta> MarcarConsulta { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
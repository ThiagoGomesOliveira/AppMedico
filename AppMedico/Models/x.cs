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
    
    public partial class x
    {
        public int IDProntuario { get; set; }
        public int IDPaciente { get; set; }
        public string Diagnostico { get; set; }
        public string Observacao { get; set; }
        public string TratamentoPaciente { get; set; }
        public string EvolucaoPaciente { get; set; }
    
        public virtual Paciente Paciente { get; set; }
    }
}
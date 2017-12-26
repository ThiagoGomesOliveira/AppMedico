using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{
    [MetadataType(typeof(MarcarConsulta))]
    public partial class MarcarConsulta
    {
    }
    public class MarcarConsultaMetadado
    {
        [Required]
        public System.DateTime Data { get; set; }
        [Required]
        public System.TimeSpan Hora { get; set; }
        [Required]
        public string Observacoes { get; set; }
    }
}
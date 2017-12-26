using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{
    [MetadataType(typeof(EstadoMetadado))]
    public partial class Estado
    {

    }
    public class EstadoMetadado
    {
        [Required(ErrorMessage ="Obrigatorio informar o nome do Estado")]
        public string Nome { get; set; }

      
        public string UF { get; set; }
    }
}
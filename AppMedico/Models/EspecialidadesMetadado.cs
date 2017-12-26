using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{
    [MetadataType(typeof(EspecialidadesMetadado))]
    public partial class Especialidades
    {

    }

    public class EspecialidadesMetadado
    {
        [Required(ErrorMessage = "Obrigatorio informar o nome")]
        public string Nome { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{
 
    [MetadataType(typeof(CidadeMetadado))]
    public partial class Cidade
    {

    }
    public class CidadeMetadado
    {

        [Required(ErrorMessage = "Obrigatorio informar o Nome")]
        public string Nome { get; set; }


    }
}
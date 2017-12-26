using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{
    [MetadataType(typeof(MedicosMetadado))]
    public partial class Medicos
    {

    }
    public class MedicosMetadado
    {
        [Required]
        [StringLength(15)]
        public string CRM { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        public bool AtendePorConvenio { get; set; }


        public bool TemClinica { get; set; }

        [Required(ErrorMessage ="Obrigatorio infomar o nome da Rua")]
        public string Rua { get; set; }
        [Required(ErrorMessage = "Obrigatorio infomar o nome do Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar o nome da Rua")]
        [StringLength(12,ErrorMessage ="CEP deve possuir no máximo 12 caracteres")]
        public string Cep { get; set; }


    }
}
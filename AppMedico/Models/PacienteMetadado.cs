using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{
    [MetadataType(typeof(PacienteMetadado))]
    public partial class Paciente
    {

    }
    public class PacienteMetadado
    {
        [Required]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar o RG")]
        [StringLength(9, ErrorMessage = "RG deve possuir no máximo 9 caracteres")]
        public string RG { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar o CPF")]
        [StringLength(12, ErrorMessage = "CPF deve possuir no máximo 12 caracteres")]
        public string CPF { get; set; }


        [Required(ErrorMessage = "Obrigatorio infomar o Telefone")]
        [StringLength(13, ErrorMessage = "Telefone deve possuir no máximo 13 caracteres")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Obrigatorio infomar o SEXO")]
        [StringLength(1, ErrorMessage = "Sexo deve possuir no máximo F ou M")]
        public string Sexo { get; set; }

        public string Email { get; set; }

        
        [StringLength(3, ErrorMessage = "O Tipo Sanguinio deve possuir no máximo 3 caracteres")]
        public string TipoSangue { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar a Doença")]
        public string Enfermidade { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar o nome da Rua")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar o nome do Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Obrigatorio infomar o nome da Rua")]
        [StringLength(12, ErrorMessage = "CEP deve possuir no máximo 12 caracteres")]
        public string Cep { get; set; }

    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{

    [MetadataType(typeof(ProntuarioMetadado))]
    public partial class x
    {

    }
    public class ProntuarioMetadado
    {
      
           [Required(ErrorMessage = "Obrigatorio informar O Diagnostico   ")]
            public string Diagnostico { get; set; }

            [Required(ErrorMessage = "Obrigatorio informar observações  ")]
            public string Observacao { get; set; }

            [Required(ErrorMessage = "Obrigatorio informar o Tratamento  ")]
            public string TratamentoPaciente { get; set; }

            [Required(ErrorMessage = "Obrigatorio informar a Evolução do Paciente  ")]
            public string EvolucaoPaciente { get; set; }

        }
    }

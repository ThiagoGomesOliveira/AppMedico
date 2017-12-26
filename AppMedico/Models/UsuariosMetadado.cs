using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppMedico.Models
{


    [MetadataType(typeof(UsuariosMetadado))]
    public partial class Usuarios
    {

    }


    public class UsuariosMetadado
    {
       
            [Key]
            [Required(ErrorMessage = "Obrigatório Informar o Nome")]
            [StringLength(50, ErrorMessage = "O Nome deve possuir no máximo 50 caracteres")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "O Campo de login deve estar preenchido")]
            public string Login { get; set; }

            [Required(ErrorMessage = "O Campo de Senha deve estar preenchido")]
            public string Senha { get; set; }

            [Required(ErrorMessage = "Obrigatório Informar o E-mail")]
            [StringLength(100, ErrorMessage = "O e - mail deve possuir no máximo 100 caracteres")]
            public string Email { get; set; }
        }
    }


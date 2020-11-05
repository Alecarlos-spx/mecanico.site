using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMecanica.Models
{
    public class EsqueciSenhaViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[EmailAddress(ErrorMessage = "O campo {0} está em formato inválido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}

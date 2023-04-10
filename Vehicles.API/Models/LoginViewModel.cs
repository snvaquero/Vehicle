using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Email")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage ="Debe introducir un Email Valido")]

        public string Username { get; set; }

        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MinLength(6,ErrorMessage ="El campo {0} debe tener una longitud minima de  {1} caracteres")]
        public string Password { get; set; }

        [Display(Name ="Recordarme")]
        public bool RememberMe { get; set; }
    }
}

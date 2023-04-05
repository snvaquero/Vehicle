using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class Procedure
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        [Display(Name = "Procedimiento")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }
        [Display(Name = "Precio")]
        [DisplayFormat(DataFormatString ="{0:C2}")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public decimal Price  { get; set; }
    }
}

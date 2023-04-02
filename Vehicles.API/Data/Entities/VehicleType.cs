using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType
    {
        public int Id { get; set; }

        [MaxLength(50,ErrorMessage ="El cmapo {0} debe tener {1} caracteres")]
        [Display(Name ="Tipo de Vehiculo")]
        [Required(ErrorMessage ="El campo {0} debe es obligatorio")]
        public string Description { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vehicles.API.Data.Entities;
using Vehicles.Common.Enums;

namespace Vehicles.API.Data
{
    public class User:IdentityUser
    {
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Display(Name ="Nombres")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe tener al menos {1} caracteres")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener al menos {1} caracteres")]
        public string LastName { get; set; }

        [Display(Name ="Tipo de Documento")]
        [Required(ErrorMessage ="El campo {0} es obligatorio ")]
        public DocumentType DocumentType { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [Display(Name ="Documento")]
        [MaxLength(20,ErrorMessage ="El campo {0} debe tener {1} caracteres")]
        public string Document { get; set; }


        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Direccion")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener {1} caracteres")]
        public string Address { get; set; }

        [Display(Name ="Foto")]
        public Guid ImageId { get; set; }


        //TODO: Fix the images path
        [Display(Name = "Foto")]
        public string ImageFullPath => ImageId == Guid.Empty
                ? $"https://localhost:44336/images/noimage.png"
            : $"https://vehiclessalazar.blob.core.windows.net/users/{ImageId}";

        [Display(Name ="Tipo de Usuario")]
        public UserType UserType { get; set; }

        [Display(Name ="Usuario")]
        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Vehicle>Vehicles { get; set; }
        

    }
}

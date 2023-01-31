using Microsoft.AspNetCore.Identity;
using parkingvip.Enums;
using System.ComponentModel.DataAnnotations;

namespace parkingvip.Data.Entities
{
    public class User : IdentityUser
    {
        [MaxLength(11, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Documento { get; set; } = "";

        [Display(Name = "Nombres: ")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; } = "";

        [Display(Name = "Apellidos: ")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Apellido { get; set; } = "";

        [Display(Name = "Direccíon: ")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]

        public string Direccion { get; set; } = "";

        [Display(Name = "Tipo de Usuario")]
        public Rol Rol { get; set; }

        [Display(Name = "Usuario")]
        public string NombreCompleto => $"{Nombre} {Apellido}  - {Documento}";
    }
}
//la herencia de user entrega a la clase : email-password-telefono
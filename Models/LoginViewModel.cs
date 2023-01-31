﻿using System.ComponentModel.DataAnnotations;

namespace parkingvip.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Email")]
        [Required(ErrorMessage ="El campo {0} es obligatorio. ")]
        [EmailAddress(ErrorMessage ="Debes ingresar un correo válido.")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Display(Name ="Contraseña")]
        [Required(ErrorMessage ="El campo {0} es obligatorio. ")]
        [MinLength(6, ErrorMessage = "El campo {0} debe tener al menos {1} carácteres.")]
        public string Password { get; set; }

        [Display(Name ="Recordarme en este navegador")]
        public bool RememberMe { get; set; }
    }
}

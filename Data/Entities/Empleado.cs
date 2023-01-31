using Parking_VIP.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace parkingvip.Data.Entities
{
    public class Empleado 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Codigo  ")]
        [MinLength(5)]
        [MaxLength(20)]
        public string Codigo { get; set; } = ""; 
        
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Nombre  ")]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Direccion  ")]
        [MinLength(5)]
        [MaxLength(100)]
        public string Direccion { get; set; } 

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Telefono ")]
        public long Telefono { get; set; }

        //public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}

using parkingvip.Data.Entities;
using System.ComponentModel.DataAnnotations;

namespace Parking_VIP.Data.Entities
{
    public class Vehiculo
    {
      
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Ingrese Placa: ")]
        [MinLength(5)]
        [MaxLength(7)]
        public string Placa { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Hora de ingreso: ")]
        public DateTime H_entrada { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Hora de salida ")]
        public DateTime H_salida { get; set; }
        [Required]
        [Display(Name = "1 si ingresa o 0 si sale ")]
        public float Estado { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [Display(Name = "Lugar: ")]

        public string N_parqueadero { get; set; }

        //public Empleado Empleado { get; set; }
        
        //public ICollection<TipoVehiculo> TipoVehiculos { get; set; }

        //[Display(Name = "Tipo ")]
        //public int Tipo_VehNumber => TipoVehiculos == null ? 0 : TipoVehiculos.Count;

    }
}

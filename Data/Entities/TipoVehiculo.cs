using System.ComponentModel.DataAnnotations;

namespace Parking_VIP.Data.Entities
{
    public class TipoVehiculo
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Categoria de Vehiculo ")]
        public string Name { get; set; }
     //   public Vehiculo Vehiculo { get; set; } 
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parking_VIP.Data.Entities;
using parkingvip.Data.Entities;

namespace Parking_VIP.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<TipoVehiculo> Tipo_Vehiculos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vehiculo>().HasIndex(v => v.Id).IsUnique();
            modelBuilder.Entity<TipoVehiculo>().HasIndex(t => t.Id).IsUnique();
            modelBuilder.Entity<Empleado>().HasIndex(t => t.Id).IsUnique();

        } 
    }
}

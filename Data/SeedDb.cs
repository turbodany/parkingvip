using Parking_VIP.Data;
using Parking_VIP.Data.Entities;
using parkingvip.Data.Entities;
using parkingvip.Enums;
using parkingvip.Helper;

namespace parkingvip.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;
        private readonly IUserHelper _userHelper;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            _context = context;
            _userHelper = userHelper;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckVehiculosAsync();
            await CheckRolesAsync();
            await CheckEmpleadosAsync();
            await CheckUserAsync("1090469624", "Daniel Andres", "Lobo Moncada", "daniwolf1293@gmail.com", "3132422876", "Ventura Plaza of-4-123", Rol.Administrador);
            await CheckUserAsync("1090469645", "Cristian Felipe", "Ruiz Moreno", "ruiz93@gmail.com", "3132422576", "Ventura Plaza of-4-123", Rol.Usuario);
        }

        private async Task<User> CheckUserAsync(
            string documento,
            string nombre,
            string apellido,
            string email,
            string phone,
            string direccion,
            Rol rol)
        {
            User user = await _userHelper.GetUserAsync(email);
            if (user == null)
            {
                user = new User
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Direccion = direccion,
                    Documento = documento,
                    Rol = rol

                };
                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, rol.ToString());
            }

            return user;
        }
        private async Task CheckEmpleadosAsync()
        {
            if (!_context.Empleados.Any())
            {
                _context.Empleados.Add(new Empleado
                {
                    Codigo = "park01",
                    Name = "Sergiño",
                    Direccion = "Cll 13 #4-98 Belén",
                    Telefono = 3228721931
                });

                _context.Empleados.Add(new Empleado
                {
                    Codigo = "park02",
                    Name = "Pabliño",
                    Direccion = "Cll 15 #4-98 Comuneros",
                    Telefono = 3228721954
                });

                _context.Empleados.Add(new Empleado
                {
                    Codigo = "Tes01",
                    Name = "Andreina",
                    Direccion = "Cll 9 #4-98 La libertad",
                    Telefono = 3228722954
                });
                await _context.SaveChangesAsync();
            }
        }

        private async Task CheckRolesAsync()
        {
            await _userHelper.CheckRolesAsync(Rol.Administrador.ToString());
            await _userHelper.CheckRolesAsync(Rol.Usuario.ToString());

        }

        private async Task CheckVehiculosAsync()
        {
            if (!_context.Vehiculos.Any())
            {
                _context.Vehiculos.Add(new Vehiculo
                {
                    Placa = "URM699",
                    H_entrada = DateTime.Now,
                    H_salida = DateTime.Now,
                    Estado = 1,
                    N_parqueadero = "A11"
                });

                _context.Vehiculos.Add(new Vehiculo
                {
                    Placa = "TJP377",
                    H_entrada = DateTime.Now,
                    H_salida = DateTime.Now,
                    Estado = 0,
                    N_parqueadero = "A14"
                });
            }
            await _context.SaveChangesAsync();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using parkingvip.Data.Entities;
using parkingvip.Models;

namespace parkingvip.Helper
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);
        Task<IdentityResult> AddUserAsync(User user,string password);
        Task CheckRolesAsync(string roleName);
        Task AddUserToRoleAsync(User user, string roleName);
        Task<bool> IsUserInRoleAsync(User user, string roleName);
        Task<SignInResult> LoginAsync(LoginViewModel model);
        Task LogoutAsync();

    }
}

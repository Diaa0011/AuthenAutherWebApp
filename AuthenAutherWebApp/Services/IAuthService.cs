using AuthenAutherWebApp.Models;

namespace AuthenAutherWebApp.Services
{
    public interface IAuthService
    {
        string GenerateTokenString(LoginUser user);
        Task<bool> Login(LoginUser user);
        Task<bool> RegisgterUser(LoginUser user);
    }
}
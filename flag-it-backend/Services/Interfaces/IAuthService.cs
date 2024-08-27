using flag_it_backend.DTOs;
using Microsoft.AspNetCore.Identity;

namespace flag_it_backend.Services.Interfaces
{
    public interface IAuthService
    {
        public Task<IdentityResult> RegisterAsync(RegisterDto registerDto);
        public Task<bool> LoginAsync(LoginDto loginDto);
        public Task SignOutAsync();
    }
}

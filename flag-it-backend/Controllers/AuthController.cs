using flag_it_backend.DTOs;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flag_it_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _authService.RegisterAsync(registerModel);

            if (!response.Succeeded)
            {
                return BadRequest("The registration was not successfull!");
            }

            return Ok("User has been created");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var isSuccess = await _authService.LoginAsync(loginDto);

            if (isSuccess)
            {
                return Ok("Login successful");
            }

            return Unauthorized("Invalid username or password");
        }

        [HttpPost("signout")]
        public async Task<IActionResult> Signout()
        {
            await _authService.SignOutAsync();

            return Ok("Signed out successfully");
        }
    }
}

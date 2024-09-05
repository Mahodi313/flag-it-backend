using flag_it_backend.DTOs;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using flag_it_backend.Models;

namespace flag_it_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly UserManager<ApplicationUser> _userManager;

        public AuthController(IAuthService authService, UserManager<ApplicationUser> userManager)
        {
            _authService = authService;
            _userManager = userManager;
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

                var user = await _userManager.FindByNameAsync(loginDto.Username);
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginDto.Username),
                    new Claim(ClaimTypes.NameIdentifier, user.Id)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return Ok(new
                {
                    Username = user.UserName,
                    UserId = user.Id,
                    Email = user.Email
                });
            }

            return Unauthorized("Invalid username or password");
        }

        [HttpPost("signout")]
        public async Task<IActionResult> Signout()
        {
            await _authService.SignOutAsync();

            return Ok("Signed out successfully");
        }

        [Authorize]
        [HttpGet("me")]
        public async Task<IActionResult> Me()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (user == null)
            {
                return Unauthorized();
            }

            return Ok(new
            {
                Username = user.UserName,
                UserId = user.Id,        
                Email = user.Email      
            });
        }
    }
}

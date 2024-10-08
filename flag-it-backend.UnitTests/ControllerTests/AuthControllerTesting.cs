﻿using flag_it_backend.Controllers;
using flag_it_backend.DTOs;
using flag_it_backend.Models;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace flag_it_backend.UnitTests.ControllerTests
{
    public class AuthControllerTesting
    {
        private readonly Mock<IAuthService> _authServiceMock;
        private readonly AuthController _authController;
        private readonly Mock<UserManager<ApplicationUser>> _userManagerMock;

        public AuthControllerTesting()
        {
            _authServiceMock = new Mock<IAuthService>();

            _userManagerMock = new Mock<UserManager<ApplicationUser>>(
                new Mock<IUserStore<ApplicationUser>>().Object,
                null, null, null, null, null, null, null, null);

            _authController = new AuthController(_authServiceMock.Object, _userManagerMock.Object)
            {
                ControllerContext = new ControllerContext()
                {
                    HttpContext = new DefaultHttpContext()
                }
            };
        }

        [Fact]
        public async Task Register_ShouldReturnOk_WhenRegistrationIsSuccessful()
        {

            var registerDto = new RegisterDto { Username = "testuser", Email = "testuser@example.com", Password = "Password123!" };
            _authServiceMock.Setup(service => service.RegisterAsync(registerDto)).ReturnsAsync(IdentityResult.Success);

            var result = await _authController.Register(registerDto);

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("User has been created", okResult.Value);
        }

        [Fact]
        public async Task Register_ShouldReturnBadRequest_WhenRegistrationFails()
        {

            var registerDto = new RegisterDto { Username = "testuser", Email = "testuser@example.com", Password = "Password123!" };
            _authServiceMock.Setup(service => service.RegisterAsync(registerDto)).ReturnsAsync(IdentityResult.Failed());

            var result = await _authController.Register(registerDto);

            var badRequestResult = Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("The registration was not successfull!", badRequestResult.Value);
        }

        [Fact]
        public async Task Login_ShouldReturnOk_WithUserId_WhenLoginIsSuccessful()
        {
            var loginDto = new LoginDto { Username = "testuser", Password = "Password123!" };
            _authServiceMock.Setup(service => service.LoginAsync(loginDto)).ReturnsAsync(true);

            _userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(new ApplicationUser
                {
                    UserName = "testuser",
                    Id = "12345" 
                });

            var services = new ServiceCollection();
            services.AddLogging();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                    .AddCookie(options =>
                    {
                        options.Cookie.HttpOnly = true;
                        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                        options.SlidingExpiration = true;
                    });
            var serviceProvider = services.BuildServiceProvider();
            var httpContext = new DefaultHttpContext
            {
                RequestServices = serviceProvider
            };
            _authController.ControllerContext.HttpContext = httpContext;

            var result = await _authController.Login(loginDto);

            var okResult = Assert.IsType<OkObjectResult>(result);
            var responseValue = okResult.Value;

            Assert.Equal("12345", responseValue.GetType().GetProperty("UserId").GetValue(responseValue)); // Check for UserId
            Assert.Equal("testuser", responseValue.GetType().GetProperty("Username").GetValue(responseValue)); // Check for Username
        }




        [Fact]
        public async Task Login_ShouldReturnUnauthorized_WhenLoginFails()
        {

            var loginDto = new LoginDto { Username = "testuser", Password = "WrongPassword!" };
            _authServiceMock.Setup(service => service.LoginAsync(loginDto)).ReturnsAsync(false);

            var result = await _authController.Login(loginDto);

            var unauthorizedResult = Assert.IsType<UnauthorizedObjectResult>(result);
            Assert.Equal("Invalid username or password", unauthorizedResult.Value);
        }

        [Fact]
        public async Task Signout_ShouldReturnOk_WhenSignoutIsSuccessful()
        {
            var result = await _authController.Signout();

            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal("Signed out successfully", okResult.Value);
        }

        [Fact]
        public async Task Me_ShouldReturnOk_WithUserIdAndUsername_WhenUserIsAuthenticated()
        {
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, "testuser") };
            var identity = new ClaimsIdentity(claims, "TestAuthType");
            var principal = new ClaimsPrincipal(identity);

            _authController.ControllerContext.HttpContext.User = principal;

            _userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(new ApplicationUser
                {
                    UserName = "testuser",
                    Id = "12345"
                });


            var result = await _authController.Me(); 

            var okResult = Assert.IsType<OkObjectResult>(result);
            var responseValue = okResult.Value;

            Assert.Equal("12345", responseValue.GetType().GetProperty("UserId").GetValue(responseValue)); 
            Assert.Equal("testuser", responseValue.GetType().GetProperty("Username").GetValue(responseValue)); 
        }

    }
}

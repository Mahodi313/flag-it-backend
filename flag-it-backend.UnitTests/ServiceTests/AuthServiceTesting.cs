using flag_it_backend.DTOs;
using flag_it_backend.Models;
using flag_it_backend.Services;
using flag_it_backend.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flag_it_backend.UnitTests.ServiceTests
{
    public class AuthServiceTesting
    {
        private readonly Mock<UserManager<ApplicationUser>> _userManagerMock;
        private readonly Mock<SignInManager<ApplicationUser>> _signInManagerMock;
        private readonly IAuthService _authService;

        public AuthServiceTesting()
        {
            _userManagerMock = MockUserManager();
            _signInManagerMock = MockSignInManager();

            _authService = new AuthService(_userManagerMock.Object, _signInManagerMock.Object);
        }

        private Mock<UserManager<ApplicationUser>> MockUserManager()
        {
            var store = new Mock<IUserStore<ApplicationUser>>();
            return new Mock<UserManager<ApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        }

        private Mock<SignInManager<ApplicationUser>> MockSignInManager()
        {
            var contextAccessor = new Mock<Microsoft.AspNetCore.Http.IHttpContextAccessor>();
            var claimsFactory = new Mock<IUserClaimsPrincipalFactory<ApplicationUser>>();

            return new Mock<SignInManager<ApplicationUser>>(
                _userManagerMock.Object,
                contextAccessor.Object,
                claimsFactory.Object,
                null,
                null,
                null,
                null);
        }

        [Fact]
        public async Task LoginAsync_ShouldReturnTrue_WhenLoginSuccessful()
        {
            var loginDto = new LoginDto { Username = "testuser", Password = "Password123!" };

            _signInManagerMock
                .Setup(sm => sm.PasswordSignInAsync(loginDto.Username, loginDto.Password, It.IsAny<bool>(), It.IsAny<bool>()))
                .ReturnsAsync(SignInResult.Success);

            var result = await _authService.LoginAsync(loginDto);

            Assert.True(result);
        }

        [Fact]
        public async Task LoginAsync_ShouldReturnFalse_WhenLoginFails()
        {
            var loginDto = new LoginDto { Username = "testuser", Password = "Password123!" };

            _signInManagerMock
                .Setup(sm => sm.PasswordSignInAsync(loginDto.Username, loginDto.Password, It.IsAny<bool>(), It.IsAny<bool>()))
                .ReturnsAsync(SignInResult.Failed);

            var result = await _authService.LoginAsync(loginDto);

            Assert.False(result);
        }

        [Fact]
        public async Task RegisterAsync_ShouldReturnFailedResult_WhenUsernameIsTaken()
        {
            var registerDto = new RegisterDto { Username = "testuser", Email = "testuser@example.com", Password = "Password123!" };

            _userManagerMock
               .Setup(um => um.FindByNameAsync(registerDto.Username))
               .ReturnsAsync(new ApplicationUser());

            var result = await _authService.RegisterAsync(registerDto);

            Assert.False(result.Succeeded);
            Assert.Contains(result.Errors, e => e.Description == "Username is already taken.");
        }

        [Fact]
        public async Task RegisterAsync_ShouldReturnFailedResult_WhenEmailIsTaken()
        {
            var registerDto = new RegisterDto { Username = "testuser", Email = "testuser@example.com", Password = "Password123!" };
            _userManagerMock
                .Setup(um => um.FindByEmailAsync(registerDto.Email))
                .ReturnsAsync(new ApplicationUser());

            var result = await _authService.RegisterAsync(registerDto);

            Assert.False(result.Succeeded);
            Assert.Contains(result.Errors, e => e.Description == "Email is already taken.");
        }

        [Fact]
        public async Task RegisterAsync_ShouldReturnSuccess_WhenRegistrationIsSuccessfull()
        {
            var registerDto = new RegisterDto { Username = "newuser", Email = "newuser@example.com", Password = "Password123!" };

            _userManagerMock
                .Setup(um => um.FindByNameAsync(registerDto.Username))
                .ReturnsAsync((ApplicationUser)null);

            _userManagerMock
                .Setup(um => um.FindByEmailAsync(registerDto.Email))
                .ReturnsAsync((ApplicationUser)null);

            _userManagerMock
                .Setup(um => um.CreateAsync(It.IsAny<ApplicationUser>(), registerDto.Password))
                .ReturnsAsync(IdentityResult.Success);

            var result = await _authService.RegisterAsync(registerDto);

            Assert.True(result.Succeeded);
        }

        [Fact]
        public async Task SignOutAsync_ShouldCallSignOut()
        {

            await _authService.SignOutAsync();

            _signInManagerMock.Verify(sm => sm.SignOutAsync(), Times.Once);
        }
    }
}


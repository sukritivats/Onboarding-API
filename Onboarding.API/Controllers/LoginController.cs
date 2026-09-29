using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Onboarding.API.Models.DTO;
using Onboarding.API.Repositories;

namespace Onboarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public LoginController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        // POST: api/Login
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDto.Username);

            if (user != null && await userManager.CheckPasswordAsync(user, loginRequestDto.Password))
            {
                var jwtToken = tokenRepository.CreateJwtToken(user);

                return Ok(new LoginResponseDto { JwtToken = jwtToken });
            }

            return Unauthorized("Username or password is incorrect");
        }
    }
}

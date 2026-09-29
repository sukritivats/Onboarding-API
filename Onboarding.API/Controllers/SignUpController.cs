
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Onboarding.API.Models.DTO;

namespace Onboarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SignUpController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;

        public SignUpController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        // POST: api/SignUp
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] SignUpRequestDto signUpRequestDto)
        {
            var identityUser = new IdentityUser
            {
                UserName = signUpRequestDto.Username,
                Email = signUpRequestDto.Username
            };

            var result = await userManager.CreateAsync(identityUser, signUpRequestDto.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors.Select(e => e.Description));
            }

            return Ok("User registered successfully. Please login.");
        }
    }
}

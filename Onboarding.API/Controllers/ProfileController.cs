using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Onboarding.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProfileController : ControllerBase
    {
        // GET: api/Profile
        [HttpGet]
        public IActionResult Get()
        {
            var email = User.FindFirst(ClaimTypes.Email)?.Value;
            return Ok(new { Email = email });
        }
    }
}

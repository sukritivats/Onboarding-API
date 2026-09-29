using Microsoft.AspNetCore.Identity;

namespace Onboarding.API.Repositories
{
    public interface ITokenRepository
    {
        //string CreateJwtToken(IdentityUser user, List<string> roles);
        string CreateJwtToken(IdentityUser user);
    }
}

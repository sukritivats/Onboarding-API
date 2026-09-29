using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Onboarding.API.Data
{
    public class OnboardingAuthDbContext:IdentityDbContext
    {
        public OnboardingAuthDbContext(DbContextOptions<OnboardingAuthDbContext> options) : base(options)
        {
        }        

    }
}

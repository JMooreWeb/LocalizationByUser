using System.Security.Claims;
using System.Threading.Tasks;
using LocalizationByUser.Models;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Microsoft.Framework.Logging;
using Microsoft.Framework.OptionsModel;

namespace LocalizationByUser.Infrastructure.Identity
{
    public class CustomSignInManager : SignInManager<ApplicationUser>
    {
        public CustomSignInManager(UserManager<ApplicationUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,
            IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<ApplicationUser>> logger)
            : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger)
        {
        }

        public override async Task<ClaimsPrincipal> CreateUserPrincipalAsync(ApplicationUser user)
        {
            var principal = await base.CreateUserPrincipalAsync(user);

            var identity = principal.Identity as ClaimsIdentity;
            if (identity != null)
            {
                if (!string.IsNullOrEmpty(user.Culture))
                    identity.AddClaim(new Claim("localizationapp:culture", user.Culture));

                if (!string.IsNullOrEmpty(user.UICulture))
                    identity.AddClaim(new Claim("localizationapp:uiculture", user.UICulture));
            }

            return principal;
        }
    }
}
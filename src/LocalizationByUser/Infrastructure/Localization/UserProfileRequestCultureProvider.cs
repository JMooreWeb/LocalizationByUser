using System;
using System.Globalization;
using System.Threading.Tasks;
using LocalizationByUser.Infrastructure.Identity;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Localization;

namespace LocalizationByUser.Infrastructure.Localization
{
    public class UserProfileRequestCultureProvider : RequestCultureProvider
    {
        public override Task<RequestCulture> DetermineRequestCulture(HttpContext httpContext)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            if (!httpContext.User.Identity.IsAuthenticated)
                return Task.FromResult((RequestCulture)null);

            string userCulture = null;
            string userUICulture = null;

            string cultureClaim = httpContext.User.GetCulture();
            if (!string.IsNullOrWhiteSpace(cultureClaim))
            {
                userCulture = cultureClaim;
            }

            string uicultureClaim = httpContext.User.GetUICulture();
            if (!string.IsNullOrWhiteSpace(uicultureClaim))
            {
                userUICulture = uicultureClaim;
            }

            if (userCulture == null && userUICulture == null)
            {
                // No values specified for either so no match
                return Task.FromResult((RequestCulture)null);
            }

            if (userCulture != null && userUICulture == null)
            {
                // Value for culture but not for UI culture so default to culture value for both
                userUICulture = userCulture;
            }

            if (userCulture == null && userUICulture != null)
            {
                // Value for UI culture but not for culture so default to UI culture value for both
                userCulture = userUICulture;
            }

            var requestCulture = new RequestCulture(new CultureInfo(userCulture), new CultureInfo(userUICulture));

            return Task.FromResult(requestCulture);
        }
    }
}
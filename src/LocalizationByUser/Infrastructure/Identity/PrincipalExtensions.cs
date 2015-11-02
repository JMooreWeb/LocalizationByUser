using System;
using System.Security.Claims;
using LocalizationByUser.Infrastructure.Localization;
using Newtonsoft.Json;

namespace LocalizationByUser.Infrastructure.Identity
{
    public static class PrincipalExtensions
    {
        public static UserCulturePreferences GetCulture(this ClaimsPrincipal principal)
        {
            if (principal == null)
                throw new ArgumentNullException(nameof(principal));

            var userPreferences = principal.FindFirstValue("localizationapp:cultureprefs");

            if (userPreferences == null)
                return null;

            return JsonConvert.DeserializeObject<UserCulturePreferences>(userPreferences);
        }
    }
}
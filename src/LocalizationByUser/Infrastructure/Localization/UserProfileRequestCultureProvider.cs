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

            var culturePreferences = httpContext.User.GetCulture();
            if (culturePreferences == null)
                return Task.FromResult((RequestCulture)null);


            var uiCulture = new CultureInfo(culturePreferences.Language);
            var culture = new CultureInfo(culturePreferences.Language);

            if (!string.IsNullOrEmpty(culturePreferences.ShortDateFormat))
                culture.DateTimeFormat.ShortDatePattern = culturePreferences.ShortDateFormat;
            if (!string.IsNullOrEmpty(culturePreferences.LongDateFormat))
                culture.DateTimeFormat.LongDatePattern = culturePreferences.LongDateFormat;
            if (!string.IsNullOrEmpty(culturePreferences.CurrencySymbol))
                culture.NumberFormat.CurrencySymbol = culturePreferences.CurrencySymbol;

            var requestCulture = new RequestCulture(culture, uiCulture);
            return Task.FromResult(requestCulture);
        }
    }
}
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LocalizationByUser.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Culture { get; set; }
        public string UICulture { get; set; }

        public string CurrencySymbol { get; set; }
        [Required]
        public string Language { get; set; }
        public string LongDateFormat { get; set; }
        public string ShortDateFormat { get; set; }
    }
}
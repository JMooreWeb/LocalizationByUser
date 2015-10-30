using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNet.Mvc.Rendering;

namespace LocalizationByUser.ViewModels.Manage
{
    public class ConfigureCultureInfoViewModel
    {
        public string Culture { get; set; }

        public string UICulture { get; set; } 

        public List<SelectListItem> AvailableCultures { get; }

        public ConfigureCultureInfoViewModel()
        {
            AvailableCultures = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "",
                    Text = "-- Not specified --"
                },
                new SelectListItem
                {
                    Value = "af",
                    Text = "Afrikaans"
                },
                new SelectListItem
                {
                    Value = "ca",
                    Text = "Catalan"
                },
                new SelectListItem
                {
                    Value = "en",
                    Text = "English"
                },
                new SelectListItem
                {
                    Value = "es",
                    Text = "Spanish"
                }
            };
        }
    }
}
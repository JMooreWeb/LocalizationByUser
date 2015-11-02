using System;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace LocalizationByUser.ViewModels.Manage
{
    public class ConfigureCultureInfoViewModel
    {
        public List<SelectListItem> AvailableCurrencySymbols { get; }

        public List<SelectListItem> AvailableLanguages { get; }

        public List<SelectListItem> AvailableLongDateFormats { get; }

        public List<SelectListItem> AvailableShortDateFormats { get; }
        public string CurrencySymbol { get; set; }
        public string Language { get; set; }
        public string LongDateFormat { get; set; }
        public string ShortDateFormat { get; set; }

        public ConfigureCultureInfoViewModel()
        {
            AvailableCurrencySymbols = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "",
                    Text = "-- Select Currency --"
                },
                new SelectListItem
                {
                    Value = "£",
                    Text = "British Pound (£)"
                },
                new SelectListItem
                {
                    Value = "€",
                    Text = "Euro (€)"
                },
                new SelectListItem
                {
                    Value = "R",
                    Text = "South African Rand (R)"
                },
                new SelectListItem
                {
                    Value = "$",
                    Text = "US Dollar ($)"
                }
            };

            AvailableLanguages = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "af",
                    Text = "Afrikaans"
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

            AvailableLongDateFormats = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "",
                    Text = "-- Select Long Date Format --"
                },
                new SelectListItem
                {
                    Value = "dddd, d MMMM yyyy",
                    Text = $"dddd, d MMMM yyyy (e.g. {DateTime.Now.ToString("dddd, d MMMM yyyy")})"
                },
                new SelectListItem
                {
                    Value = "dddd, MMMM d yyyy",
                    Text = $"dddd, MMMM d yyyy (e.g. {DateTime.Now.ToString("dddd, MMMM d yyyy")})"
                },
                new SelectListItem
                {
                    Value = "d MMMM yyyy",
                    Text = $"d MMMM yyyy (e.g. {DateTime.Now.ToString("d MMMM yyyy")})"
                },
                new SelectListItem
                {
                    Value = "MMMM d yyyy",
                    Text = $"MMMM d yyyy (e.g. {DateTime.Now.ToString("MMMM d yyyy")})"
                }
            };

            AvailableShortDateFormats = new List<SelectListItem>
            {
                new SelectListItem
                {
                    Value = "",
                    Text = "-- Select Short Date Format --"
                },
                new SelectListItem
                {
                    Value = "dd/MM/yyyy",
                    Text = $"dd/MM/yyyy (e.g. {DateTime.Now.ToString("dd/MM/yyyy")})"
                },
                new SelectListItem
                {
                    Value = "MM/dd/yyyy",
                    Text = $"MM/dd/yyyy (e.g. {DateTime.Now.ToString("MM/dd/yyyy")})"
                },
                new SelectListItem
                {
                    Value = "dd-MM-yyyy",
                    Text = $"dd-MM-yyyy (e.g. {DateTime.Now.ToString("dd-MM-yyyy")})"
                }
            };
        }
    }
}
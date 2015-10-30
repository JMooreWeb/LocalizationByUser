using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LocalizationByUser.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Culture { get; set; }

        public string UICulture { get; set; }
    }
}

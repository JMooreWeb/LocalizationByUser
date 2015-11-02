using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;

namespace LocalizationByUser.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(typeBuilder =>
                {
                    typeBuilder.Property<string>(u => u.Language)
                        .HasDefaultValue("en")
                        .IsRequired();
                });
        }
    }
}

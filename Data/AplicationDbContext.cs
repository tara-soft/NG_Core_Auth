using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NG_Core_Auth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NG_Core_Auth.Data
{
    public class AplicationDbContext: IdentityDbContext<IdentityUser>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options) :base(options)
        {
        }

        //CreatigRolesfororApplicatio
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                    new { Id = "1", Name = "Admin", NormalizedName = "Admin"},
                    new { Id = "2", Name = "Customer", NormalizedName = "CUSTOMER" },
                    new { Id = "3", Name = "Moderator", NormalizedName = "MODERATOR" }

                );
        }

        public DbSet<Product> Products { get; set; }
       // public DbSet<LoginViewModel> LoginViewModels { get; set; }
       // public DbSet<RegisterViewModel> RegisterViewModels { get; set; }


    }
}

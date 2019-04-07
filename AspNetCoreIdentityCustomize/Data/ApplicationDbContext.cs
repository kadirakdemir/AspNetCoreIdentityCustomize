using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentityCustomize.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser,ApplicationRole,string,ApplicationUserClaim,
        ApplicationUserRole,ApplicationUserLogin,ApplicationRoleClaim,ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("User", "identity").Property(p=>p.Id).HasColumnName("UserId");
            builder.Entity<ApplicationRole>().ToTable("Role", "identity").Property(p=>p.Id).HasColumnName("RolId");
            builder.Entity<ApplicationUserRole>().ToTable("UserRole", "identity");
            builder.Entity<ApplicationUserClaim>().ToTable("UserClaims", "identity");
            builder.Entity<ApplicationRoleClaim>().ToTable("RoleClaims", "identity");
            builder.Entity<ApplicationUserLogin>().ToTable("LoginData", "identity");
            builder.Entity<ApplicationUserToken>().ToTable("UserToken", "identity");
            
        }
    }
}

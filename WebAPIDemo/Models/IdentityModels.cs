using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity;

namespace WebAPIDemo.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Tehsil> Tehsil { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<PersonalProfile> PersonalProfile { get; set; }
        public DbSet<UserActivity> UserActivity { get; set; }
        public DbSet<UserCrop> UserCrop { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection1", throwIfV1Schema: false)
        {
        }
       

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TrashPickup.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

<<<<<<< HEAD
=======

>>>>>>> 3f37c3f50f7f294c7c8eec2c35a7f96cc596e212
      
        public DbSet<Member> Member { get; set; }
        public DbSet<Worker> Worker { get; set; }
        public DbSet<Route> Routes { get; set; }
<<<<<<< HEAD
=======
        public DbSet<Address> Address { get; set; }
        public DbSet<Zip> Zip { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Payment> Payment { get; set; }


















       

>>>>>>> 3f37c3f50f7f294c7c8eec2c35a7f96cc596e212
    }
}
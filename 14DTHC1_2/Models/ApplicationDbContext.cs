using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace _14DTHC1_2.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }

        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext()
            : base("LTW14DTHC12Connection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BeeBuzz.Data.Entities;


namespace BeeBuzz.Data
{
    public class ApplicationDbContext : 
        IdentityDbContext<ApplicationUser, IdentityRole<int>, int>
    {        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Orgnanization> Orgnanization { get; set; }

        public DbSet<Beehive> Beehive { get; set; }

        public DbSet<User> User { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Beehive>();


            //modelBuilder.Entity<User>()
            //    .HasMany(u => u.beehives);


            //modelBuilder.Entity<Orgnanization>()
            //.HasMany(e => e.Users);
            

        }
    }
}

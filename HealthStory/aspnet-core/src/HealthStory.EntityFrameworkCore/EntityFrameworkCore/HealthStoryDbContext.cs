using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HealthStory.Authorization.Roles;
using HealthStory.Authorization.Users;
using HealthStory.MultiTenancy;

namespace HealthStory.EntityFrameworkCore
{
    public class HealthStoryDbContext : AbpZeroDbContext<Tenant, Role, User, HealthStoryDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Patient> Patient { get; set; }

        public HealthStoryDbContext(DbContextOptions<HealthStoryDbContext> options)
            : base(options)
        {
        }
    }
}

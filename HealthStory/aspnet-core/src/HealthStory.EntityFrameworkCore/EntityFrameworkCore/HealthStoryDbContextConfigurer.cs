using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HealthStory.EntityFrameworkCore
{
    public static class HealthStoryDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HealthStoryDbContext> builder, string connectionString)
        {
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HealthStoryDbContext> builder, DbConnection connection)
        {
            builder.UseMySql(connection);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using HealthStory.Configuration;
using HealthStory.Web;

namespace HealthStory.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class HealthStoryDbContextFactory : IDesignTimeDbContextFactory<HealthStoryDbContext>
    {
        public HealthStoryDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<HealthStoryDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            HealthStoryDbContextConfigurer.Configure(builder, configuration.GetConnectionString(HealthStoryConsts.ConnectionStringName));

            return new HealthStoryDbContext(builder.Options);
        }
    }
}

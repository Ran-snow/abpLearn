using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HealthStory.Configuration;

namespace HealthStory.Web.Host.Startup
{
    [DependsOn(
       typeof(HealthStoryWebCoreModule))]
    public class HealthStoryWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HealthStoryWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HealthStoryWebHostModule).GetAssembly());
        }
    }
}

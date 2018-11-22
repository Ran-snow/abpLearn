using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HealthStory.Authorization;

namespace HealthStory
{
    [DependsOn(
        typeof(HealthStoryCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HealthStoryApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HealthStoryAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HealthStoryApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

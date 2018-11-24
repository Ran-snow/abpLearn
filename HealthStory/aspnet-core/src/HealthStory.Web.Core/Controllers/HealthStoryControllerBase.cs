using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HealthStory.Controllers
{
    public abstract class HealthStoryControllerBase: AbpController
    {
        protected HealthStoryControllerBase()
        {
            LocalizationSourceName = HealthStoryConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

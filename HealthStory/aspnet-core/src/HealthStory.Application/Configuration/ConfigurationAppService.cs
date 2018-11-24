using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HealthStory.Configuration.Dto;

namespace HealthStory.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HealthStoryAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

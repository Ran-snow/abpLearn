using System.Threading.Tasks;
using HealthStory.Configuration.Dto;

namespace HealthStory.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

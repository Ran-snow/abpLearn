using System.Threading.Tasks;
using Abp.Application.Services;
using HealthStory.Sessions.Dto;

namespace HealthStory.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

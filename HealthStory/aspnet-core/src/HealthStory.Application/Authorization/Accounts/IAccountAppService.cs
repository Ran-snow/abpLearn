using System.Threading.Tasks;
using Abp.Application.Services;
using HealthStory.Authorization.Accounts.Dto;

namespace HealthStory.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

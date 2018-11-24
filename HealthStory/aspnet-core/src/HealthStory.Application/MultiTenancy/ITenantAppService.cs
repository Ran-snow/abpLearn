using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HealthStory.MultiTenancy.Dto;

namespace HealthStory.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

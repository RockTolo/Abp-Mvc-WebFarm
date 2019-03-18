using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Tolo.MyAbp.MultiTenancy.Dto;

namespace Tolo.MyAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


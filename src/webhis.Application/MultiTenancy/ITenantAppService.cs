using Abp.Application.Services;
using Abp.Application.Services.Dto;
using webhis.MultiTenancy.Dto;

namespace webhis.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


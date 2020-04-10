using Abp.Application.Services;
using webhis.MultiTenancy.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace webhis.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<TenantDto> RegisterTenant(CreateTenantDto input);
    }
}

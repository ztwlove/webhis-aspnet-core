using System.Threading.Tasks;
using Abp.Application.Services;
using webhis.Sessions.Dto;

namespace webhis.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

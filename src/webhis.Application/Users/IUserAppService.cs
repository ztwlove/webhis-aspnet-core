using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using webhis.Roles.Dto;
using webhis.Users.Dto;

namespace webhis.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

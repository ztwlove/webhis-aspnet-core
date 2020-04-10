using System.Collections.Generic;
using webhis.Roles.Dto;
using webhis.Users.Dto;

namespace webhis.Web.ViewModels.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

using System.Collections.Generic;
using webhis.Roles.Dto;

namespace webhis.Web.ViewModels.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}

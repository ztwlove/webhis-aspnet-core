using System.Collections.Generic;
using webhis.Roles.Dto;

namespace webhis.Web.ViewModels.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
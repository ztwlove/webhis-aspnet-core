using Abp.Authorization;
using webhis.Authorization.Roles;
using webhis.Authorization.Users;

namespace webhis.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

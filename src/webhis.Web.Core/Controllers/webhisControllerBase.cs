using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace webhis.Controllers
{
    public abstract class webhisControllerBase: AbpController
    {
        protected webhisControllerBase()
        {
            LocalizationSourceName = webhisConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

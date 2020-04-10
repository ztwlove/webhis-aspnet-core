using Abp.AspNetCore.Mvc.ViewComponents;

namespace webhis.Web.Views
{
    public abstract class webhisViewComponent : AbpViewComponent
    {
        protected webhisViewComponent()
        {
            LocalizationSourceName = webhisConsts.LocalizationSourceName;
        }
    }
}

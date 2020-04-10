using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace webhis.Web.Views
{
    public abstract class webhisRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected webhisRazorPage()
        {
            LocalizationSourceName = webhisConsts.LocalizationSourceName;
        }
    }
}

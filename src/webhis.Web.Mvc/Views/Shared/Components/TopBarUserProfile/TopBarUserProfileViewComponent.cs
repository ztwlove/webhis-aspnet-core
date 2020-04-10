using System.Threading.Tasks;
using Abp.Configuration.Startup;
using webhis.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace webhis.Web.Views.Shared.Components.TopBarUserProfile
{
    public class TopBarUserProfileViewComponent : webhisViewComponent
    {
        private readonly ISessionAppService _sessionAppService;
        private readonly IMultiTenancyConfig _multiTenancyConfig;

        public TopBarUserProfileViewComponent(ISessionAppService sessionAppService,
            IMultiTenancyConfig multiTenancyConfig)
        {
            _sessionAppService = sessionAppService;
            _multiTenancyConfig = multiTenancyConfig;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new TopBarUserProfileViewModel
            {
                LoginInformations = await _sessionAppService.GetCurrentLoginInformations(),
                IsMultiTenancyEnabled = _multiTenancyConfig.IsEnabled,
            };

            return View(model);
 
        }
    }
}

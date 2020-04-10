using Microsoft.AspNetCore.Mvc;

namespace webhis.Web.Views.Shared.Components.TopBarNotifications
{
    public class TopBarNotificationsViewComponent : webhisViewComponent
    {
 
        public TopBarNotificationsViewComponent()
        {
        
        }

        public IViewComponentResult Invoke()
        {
         

            return View();
        }
    }
}

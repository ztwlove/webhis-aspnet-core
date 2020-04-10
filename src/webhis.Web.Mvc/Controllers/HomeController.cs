using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using webhis.Controllers;

namespace webhis.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : webhisControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

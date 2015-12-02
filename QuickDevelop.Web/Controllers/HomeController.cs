using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace QuickDevelop.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : QuickDevelopControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}
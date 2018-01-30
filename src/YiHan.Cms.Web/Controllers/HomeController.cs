using System.Web.Mvc;

namespace YiHan.Cms.Web.Controllers
{
    public class HomeController : CmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
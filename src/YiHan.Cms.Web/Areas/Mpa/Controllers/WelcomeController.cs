using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YiHan.Cms.Web.Controllers;

namespace YiHan.Cms.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class WelcomeController : CmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
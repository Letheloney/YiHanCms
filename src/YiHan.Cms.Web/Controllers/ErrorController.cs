using System.Web.Mvc;
using Abp.Auditing;

namespace YiHan.Cms.Web.Controllers
{
    public class ErrorController : CmsControllerBase
    {
        [DisableAuditing]
        public ActionResult E404()
        {
            return View();
        }
    }
}
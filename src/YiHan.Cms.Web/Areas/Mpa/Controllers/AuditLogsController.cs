using System.Web.Mvc;
using Abp.Auditing;
using Abp.Web.Mvc.Authorization;
using YiHan.Cms.Authorization;
using YiHan.Cms.Web.Controllers;

namespace YiHan.Cms.Web.Areas.Mpa.Controllers
{
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : CmsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
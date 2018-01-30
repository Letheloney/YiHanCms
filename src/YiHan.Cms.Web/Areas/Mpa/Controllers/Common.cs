using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using YiHan.Cms.Web.Areas.Mpa.Models.Common.Modals;
using YiHan.Cms.Web.Controllers;

namespace YiHan.Cms.Web.Areas.Mpa.Controllers
{
    [AbpMvcAuthorize]
    public class CommonController : CmsControllerBase
    {
        public PartialViewResult LookupModal(LookupModalViewModel model)
        {
            return PartialView("Modals/_LookupModal", model);
        }
    }
}
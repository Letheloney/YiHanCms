using Abp.WebApi.Controllers;

namespace YiHan.Cms.WebApi
{
    public abstract class CmsApiControllerBase : AbpApiController
    {
        protected CmsApiControllerBase()
        {
            LocalizationSourceName = CmsConsts.LocalizationSourceName;
        }
    }
}
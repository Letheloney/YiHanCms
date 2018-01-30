using Abp.Domain.Services;

namespace YiHan.Cms
{
    public abstract class CmsDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected CmsDomainServiceBase()
        {
            LocalizationSourceName = CmsConsts.LocalizationSourceName;
        }
    }
}

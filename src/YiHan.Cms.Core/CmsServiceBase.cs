using Abp;

namespace YiHan.Cms
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="CmsDomainServiceBase"/>.
    /// For application services inherit CmsAppServiceBase.
    /// </summary>
    public abstract class CmsServiceBase : AbpServiceBase
    {
        protected CmsServiceBase()
        {
            LocalizationSourceName = CmsConsts.LocalizationSourceName;
        }
    }
}
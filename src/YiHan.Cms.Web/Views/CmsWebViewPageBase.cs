using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace YiHan.Cms.Web.Views
{
    public abstract class CmsWebViewPageBase : CmsWebViewPageBase<dynamic>
    {
       
    }

    public abstract class CmsWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected CmsWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = CmsConsts.LocalizationSourceName;
        }
    }
}
using Abp.AutoMapper;
using YiHan.Cms.MultiTenancy;
using YiHan.Cms.MultiTenancy.Dto;
using YiHan.Cms.Web.Areas.Mpa.Models.Common;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}
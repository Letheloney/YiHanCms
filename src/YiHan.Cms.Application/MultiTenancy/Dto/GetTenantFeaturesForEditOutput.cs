using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YiHan.Cms.Editions.Dto;

namespace YiHan.Cms.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}
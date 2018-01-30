using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YiHan.Cms.Editions.Dto;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}
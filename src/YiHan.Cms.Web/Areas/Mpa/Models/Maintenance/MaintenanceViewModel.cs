using System.Collections.Generic;
using YiHan.Cms.Caching.Dto;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}
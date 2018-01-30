using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YiHan.Cms.Caching.Dto;

namespace YiHan.Cms.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}

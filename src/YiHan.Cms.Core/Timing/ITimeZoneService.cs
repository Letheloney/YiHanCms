using System.Threading.Tasks;
using Abp.Configuration;

namespace YiHan.Cms.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}

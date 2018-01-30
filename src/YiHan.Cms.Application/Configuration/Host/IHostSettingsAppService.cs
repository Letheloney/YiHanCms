using System.Threading.Tasks;
using Abp.Application.Services;
using YiHan.Cms.Configuration.Host.Dto;

namespace YiHan.Cms.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}

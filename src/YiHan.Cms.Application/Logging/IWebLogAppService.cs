using Abp.Application.Services;
using  YiHan.Cms.Dto;
using YiHan.Cms.Logging.Dto;

namespace YiHan.Cms.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}

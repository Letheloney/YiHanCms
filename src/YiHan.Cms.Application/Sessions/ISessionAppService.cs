using System.Threading.Tasks;
using Abp.Application.Services;
using YiHan.Cms.Sessions.Dto;

namespace YiHan.Cms.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

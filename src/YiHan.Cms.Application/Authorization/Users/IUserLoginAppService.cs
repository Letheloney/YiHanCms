using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YiHan.Cms.Authorization.Users.Dto;

namespace YiHan.Cms.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}

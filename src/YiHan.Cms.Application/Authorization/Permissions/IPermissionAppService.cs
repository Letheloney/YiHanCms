using Abp.Application.Services;
using Abp.Application.Services.Dto;
using YiHan.Cms.Authorization.Permissions.Dto;

namespace YiHan.Cms.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}

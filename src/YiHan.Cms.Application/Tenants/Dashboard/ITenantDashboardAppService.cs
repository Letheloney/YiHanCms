using Abp.Application.Services;
using YiHan.Cms.Tenants.Dashboard.Dto;

namespace YiHan.Cms.Tenants.Dashboard
{
    public interface ITenantDashboardAppService : IApplicationService
    {
        GetMemberActivityOutput GetMemberActivity();
    }
}

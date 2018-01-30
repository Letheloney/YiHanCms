﻿using System.Threading.Tasks;
using Abp.Application.Services;
using YiHan.Cms.Configuration.Tenants.Dto;

namespace YiHan.Cms.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}

﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YiHan.Cms.Configuration.Tenants.Dto;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}
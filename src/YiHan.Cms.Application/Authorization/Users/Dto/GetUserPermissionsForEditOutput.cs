using System.Collections.Generic;
using Abp.Application.Services.Dto;
using YiHan.Cms.Authorization.Permissions.Dto;

namespace YiHan.Cms.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}
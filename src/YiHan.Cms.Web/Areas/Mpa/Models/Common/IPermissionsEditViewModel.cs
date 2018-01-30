using System.Collections.Generic;
using YiHan.Cms.Authorization.Permissions.Dto;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}
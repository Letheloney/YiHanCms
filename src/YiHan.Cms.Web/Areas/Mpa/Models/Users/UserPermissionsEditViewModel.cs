using Abp.AutoMapper;
using YiHan.Cms.Authorization.Users;
using YiHan.Cms.Authorization.Users.Dto;
using YiHan.Cms.Web.Areas.Mpa.Models.Common;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}
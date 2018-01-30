using System.Collections.Generic;
using YiHan.Cms.Authorization.Users.Dto;

namespace YiHan.Cms.Web.Areas.Mpa.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}
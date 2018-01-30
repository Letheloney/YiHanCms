using Abp.Authorization;
using YiHan.Cms.Authorization.Roles;
using YiHan.Cms.Authorization.Users;
using YiHan.Cms.MultiTenancy;

namespace YiHan.Cms.Authorization
{
    /// <summary>
    /// Implements <see cref="PermissionChecker"/>.
    /// </summary>
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

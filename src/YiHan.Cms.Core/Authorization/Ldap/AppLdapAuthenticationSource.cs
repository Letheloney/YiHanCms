using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using YiHan.Cms.Authorization.Users;
using YiHan.Cms.MultiTenancy;

namespace YiHan.Cms.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}

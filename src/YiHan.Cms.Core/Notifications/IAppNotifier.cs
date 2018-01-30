using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using YiHan.Cms.Authorization.Users;
using YiHan.Cms.MultiTenancy;

namespace YiHan.Cms.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}

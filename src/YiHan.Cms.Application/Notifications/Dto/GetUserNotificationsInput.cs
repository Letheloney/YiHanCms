using Abp.Notifications;
using  YiHan.Cms.Dto;

namespace YiHan.Cms.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}
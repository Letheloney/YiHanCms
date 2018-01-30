using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using YiHan.Cms.Authorization.Users;

namespace YiHan.Cms.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}
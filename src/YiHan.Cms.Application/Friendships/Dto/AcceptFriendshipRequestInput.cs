using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace YiHan.Cms.Friendships.Dto
{
    public class AcceptFriendshipRequestInput
    {
        [Range(1, long.MaxValue)]
        public long UserId { get; set; }

        public int? TenantId { get; set; }
    }
}
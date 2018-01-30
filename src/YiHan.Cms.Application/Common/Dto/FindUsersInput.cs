using  YiHan.Cms.Dto;

namespace YiHan.Cms.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}
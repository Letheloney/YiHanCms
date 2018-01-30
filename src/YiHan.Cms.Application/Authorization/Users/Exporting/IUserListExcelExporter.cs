using System.Collections.Generic;
using YiHan.Cms.Authorization.Users.Dto;
using  YiHan.Cms.Dto;

namespace YiHan.Cms.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}
using System.Collections.Generic;
using YiHan.Cms.Auditing.Dto;
using  YiHan.Cms.Dto;

namespace YiHan.Cms.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}

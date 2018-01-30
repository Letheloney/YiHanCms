using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiHan.Cms.CmsApp
{
    [Table("Templates", Schema = "CMS")]
    /// <summary>
    /// 系统模板
    /// </summary>
    public class Templates : Entity, ICreationAudited, IModificationAudited
    {
        /// <summary>
        /// 模板名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 模板的值
        /// </summary>
        public String content { get; set; }
        /// <summary>
        /// 文件名称
        /// </summary>
        public String FileName { get; set; }
        /// <summary>
        /// 文件夹名称
        /// </summary>
        public String FloderName { get; set; }
        /// <summary>
        /// 编码格式
        /// </summary>
        public String WebCode { get; set; }
        /// <summary>
        /// 模板分类
        /// </summary>
        public int TempCatelogy { get; set; }
        /// <summary>
        /// 最后修改的用户Id
        /// </summary>
        public long? LastModifierUserId { get; set; }
        /// <summary>
        /// 修改的时间
        /// </summary>
        public DateTime CreationTime { get; set; }
        /// <summary>
        /// 最后修改的时间
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
        /// <summary>
        /// 创建者的ID
        /// </summary>
        public long? CreatorUserId { get; set; }
    }
}

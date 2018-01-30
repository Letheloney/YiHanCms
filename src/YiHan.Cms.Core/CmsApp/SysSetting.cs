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
    [Table("SysSetting", Schema = "CMS")]
    /// <summary>
    /// 系统配置
    /// </summary>
    public class SysSetting : Entity, ICreationAudited, IModificationAudited
    {
        /// <summary>
        /// 配置名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 配置的值
        /// </summary>
        public String Value { get; set; }
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

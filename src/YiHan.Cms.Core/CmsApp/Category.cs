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
    [Table("Category", Schema = "CMS")]
    /// <summary>
    /// 分类管理
    /// </summary>
    public class Category: Entity, ICreationAudited, IModificationAudited
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Category_Name { get; set; }
        /// <summary>
        /// 分类描述
        /// </summary>
        public string Category_Desc { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// 分类状态
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 父类Id
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// seo标题
        /// </summary>
        public string WebTitle { get; set; }
        /// <summary>
        ///  seo关键词
        /// </summary>
        public string WebKeyWord { get; set; }
        /// <summary>
        ///  seo关键词
        /// </summary>
        public string WebDescription { get; set; }
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

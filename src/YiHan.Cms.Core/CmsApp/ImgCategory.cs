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
    [Table("ImgCategory", Schema = "CMS")]
    /// <summary>
    /// 图片分类
    /// </summary>
    public class ImgCategory:Entity, ICreationAudited, IModificationAudited
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        public string ImgCategory_Name { get; set; }
        /// <summary>
        /// 分类描述
        /// </summary>
        public string ImgCategory_Desc { get; set; }
        /// <summary>
        /// 分类状态
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 父类Id
        /// </summary>
        public string ParentId { get; set; }
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

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
    [Table("ImGallery", Schema = "CMS")]
    /// <summary>
    /// 图库管理
    /// </summary>
    public class ImGallery : Entity, ICreationAudited, IModificationAudited
    {
        /// <summary>
        /// 图库名称
        /// </summary>
        public string Gallery_Name { get; set; }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string PicUrl { get; set; }
        /// <summary>
        /// 图库描述
        /// </summary>
        public string ImgCategory_Id { get; set; }
        /// <summary>
        /// 图库状态
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

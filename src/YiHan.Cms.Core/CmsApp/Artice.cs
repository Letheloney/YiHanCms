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
    [Table("Artice", Schema = "CMS")]
    /// <summary>
    /// 文章管理
    /// </summary>
    public class Artice : Entity, ICreationAudited, IModificationAudited
    {
        /// <summary>
        /// 归属分类的ID
        /// </summary>
        public int Category_ID { get; set; }
        /// <summary>
        /// 文章名称
        /// </summary>
        public string Art_Name { get; set; }
        /// <summary>
        /// 文章状态
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// 点击率
        /// </summary>
        public int? Hits { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Rank { get; set; }
        /// <summary>
        /// 文章副标题
        /// </summary>
        public string Art_SubName { get; set; }
        /// <summary>
        /// 文章封面图
        /// </summary>
        public string Art_CoverUrl { get; set; }
        /// <summary>
        /// 文章标签
        /// </summary>
        public string Art_Tag { get; set; }
        /// <summary>
        /// 文章图库Id
        /// </summary>
        public string Art_GalleryId { get; set; }
        /// <summary>
        /// 文章内容
        /// </summary>
        public string Art_Content { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }
        /// <summary>
        /// 是否热门
        /// </summary>
        public bool IsHot { get; set; }
        /// <summary>
        /// 是否首页显示
        /// </summary>
        public bool IsIndex{ get; set; }
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

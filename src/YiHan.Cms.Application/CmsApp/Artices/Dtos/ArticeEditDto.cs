                          
  
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using  YiHan.Cms;
   #region 代码生成器相关信息_ABP Code Generator Info
   //你好，我是ABP代码生成器的作者,欢迎您使用该工具，目前接受付费定制该工具，有需要的可以联系我
   //我的邮箱:werltm@hotmail.com
   // 官方网站:"http://www.yoyocms.com"
 // 交流QQ群：104390185  
 //微信公众号：角落的白板报
// 演示地址:"vue版本：http://vue.yoyocms.com angularJs版本:ng1.yoyocms.com"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>梁桐铭 ,微软MVP</Author-作者>
// Copyright © YoYoCms@China.2018-01-22T16:02:45. All Rights Reserved.
//<生成时间>2018-01-22T16:02:45</生成时间>
	#endregion
namespace  YiHan.Cms.CmsApp.Dtos
{
    /// <summary>
    /// 文章管理编辑用Dto
    /// </summary>
    [AutoMap(typeof(Artice))]
    public class ArticeEditDto 
    {

	/// <summary>
    ///   主键Id
    /// </summary>
    [DisplayName("主键Id")]
	public int? Id{get;set;}

        /// <summary>
        /// 归属分类的ID
        /// </summary>
        [DisplayName("归属分类的ID")]
        public   int  Category_ID { get; set; }

        /// <summary>
        /// 文章名称
        /// </summary>
        [DisplayName("文章名称")]
        public   string  Art_Name { get; set; }

        /// <summary>
        /// 文章状态
        /// </summary>
        [DisplayName("文章状态")]
        public   bool  Status { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [DisplayName("排序")]
        public   int  Rank { get; set; }

        /// <summary>
        /// 文章副标题
        /// </summary>
        [DisplayName("文章副标题")]
        public   string  Art_SubName { get; set; }

        /// <summary>
        /// 文章封面图
        /// </summary>
        [DisplayName("文章封面图")]
        public   string  Art_CoverUrl { get; set; }

        /// <summary>
        /// 文章标签
        /// </summary>
        [DisplayName("文章标签")]
        public   string  Art_Tag { get; set; }

        /// <summary>
        /// 文章图库Id
        /// </summary>
        [DisplayName("文章图库Id")]
        public   string  Art_GalleryId { get; set; }

        /// <summary>
        /// 文章内容
        /// </summary>
        [DisplayName("文章内容")]
        public   string  Art_Content { get; set; }
        /// <summary>
        /// 点击率
        /// </summary>
        [DisplayName("点击率")]
        public int? Hits { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
        [DisplayName("是否置顶")]
        public   bool  IsTop { get; set; }

        /// <summary>
        /// 是否热门
        /// </summary>
        [DisplayName("是否热门")]
        public   bool  IsHot { get; set; }

        /// <summary>
        /// 是否首页显示
        /// </summary>
        [DisplayName("是否首页显示")]
        public   bool  IsIndex { get; set; }

        /// <summary>
        /// seo标题
        /// </summary>
        [DisplayName("seo标题")]
        public   string  WebTitle { get; set; }

        /// <summary>
        /// seo关键词
        /// </summary>
        [DisplayName("seo关键词")]
        public   string  WebKeyWord { get; set; }

        /// <summary>
        /// seo关键词
        /// </summary>
        [DisplayName("seo关键词")]
        public   string  WebDescription { get; set; }

    }
}

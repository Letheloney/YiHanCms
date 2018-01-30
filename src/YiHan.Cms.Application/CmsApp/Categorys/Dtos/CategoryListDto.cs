                            
using System;
using System.ComponentModel;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using  YiHan.Cms.CmsApp;
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
// Copyright © YoYoCms@China.2018-01-22T16:07:48. All Rights Reserved.
//<生成时间>2018-01-22T16:07:48</生成时间>
	#endregion
namespace   YiHan.Cms.CmsApp.Dtos
{
	/// <summary>
    /// 分类管理列表Dto
    /// </summary>
    [AutoMapFrom(typeof(Category))]
    public class CategoryListDto : EntityDto<int>
    {
        /// <summary>
        /// 分类名称
        /// </summary>
        [DisplayName("分类名称")]
        public      string Category_Name { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [DisplayName("排序")]
        public      int Rank { get; set; }
        /// <summary>
        /// 分类状态
        /// </summary>
        [DisplayName("分类状态")]
        public      bool Status { get; set; }
        /// <summary>
        /// 父类Id
        /// </summary>
        [DisplayName("父类Id")]
        public int? ParentId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public      DateTime CreationTime { get; set; }
    }
}

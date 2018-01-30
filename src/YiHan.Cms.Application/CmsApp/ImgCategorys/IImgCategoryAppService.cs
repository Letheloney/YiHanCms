                           
 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using  YiHan.Cms.CmsApp.Dtos;
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
// Copyright © YoYoCms@China.2018-01-22T16:19:08. All Rights Reserved.
//<生成时间>2018-01-22T16:19:08</生成时间>
	#endregion
namespace  YiHan.Cms.CmsApp
{
	/// <summary>
    /// 图片分类服务接口
    /// </summary>
    public interface IImgCategoryAppService : IApplicationService
    {
        #region 图片分类管理

        /// <summary>
        /// 根据查询条件获取图片分类分页列表
        /// </summary>
        Task<PagedResultDto<ImgCategoryListDto>> GetPagedImgCategorysAsync(GetImgCategoryInput input);

        /// <summary>
        /// 通过Id获取图片分类信息进行编辑或修改 
        /// </summary>
        Task<GetImgCategoryForEditOutput> GetImgCategoryForEditAsync(NullableIdDto<int> input);

		  /// <summary>
        /// 通过指定id获取图片分类ListDto信息
        /// </summary>
		Task<ImgCategoryListDto> GetImgCategoryByIdAsync(EntityDto<int> input);



        /// <summary>
        /// 新增或更改图片分类
        /// </summary>
        Task CreateOrUpdateImgCategoryAsync(CreateOrUpdateImgCategoryInput input);





        /// <summary>
        /// 新增图片分类
        /// </summary>
        Task<ImgCategoryEditDto> CreateImgCategoryAsync(ImgCategoryEditDto input);

        /// <summary>
        /// 更新图片分类
        /// </summary>
        Task UpdateImgCategoryAsync(ImgCategoryEditDto input);

        /// <summary>
        /// 删除图片分类
        /// </summary>
        Task DeleteImgCategoryAsync(EntityDto<int> input);

        /// <summary>
        /// 批量删除图片分类
        /// </summary>
        Task BatchDeleteImgCategoryAsync(List<int> input);

        #endregion




    }
}

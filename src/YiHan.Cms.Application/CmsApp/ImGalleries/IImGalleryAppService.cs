                           
 
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using   YiHan.Cms.CmsApp.Dtos;
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
// Copyright © YoYoCms@China.2018-01-22T16:09:14. All Rights Reserved.
//<生成时间>2018-01-22T16:09:14</生成时间>
	#endregion
namespace  YiHan.Cms.CmsApp
{
	/// <summary>
    /// 图库管理服务接口
    /// </summary>
    public interface IImGalleryAppService : IApplicationService
    {
        #region 图库管理管理

        /// <summary>
        /// 根据查询条件获取图库管理分页列表
        /// </summary>
        Task<PagedResultDto<ImGalleryListDto>> GetPagedImGallerysAsync(GetImGalleryInput input);

        /// <summary>
        /// 通过Id获取图库管理信息进行编辑或修改 
        /// </summary>
        Task<GetImGalleryForEditOutput> GetImGalleryForEditAsync(NullableIdDto<int> input);

		  /// <summary>
        /// 通过指定id获取图库管理ListDto信息
        /// </summary>
		Task<ImGalleryListDto> GetImGalleryByIdAsync(EntityDto<int> input);



        /// <summary>
        /// 新增或更改图库管理
        /// </summary>
        Task CreateOrUpdateImGalleryAsync(CreateOrUpdateImGalleryInput input);





        /// <summary>
        /// 新增图库管理
        /// </summary>
        Task<ImGalleryEditDto> CreateImGalleryAsync(ImGalleryEditDto input);

        /// <summary>
        /// 更新图库管理
        /// </summary>
        Task UpdateImGalleryAsync(ImGalleryEditDto input);

        /// <summary>
        /// 删除图库管理
        /// </summary>
        Task DeleteImGalleryAsync(EntityDto<int> input);

        /// <summary>
        /// 批量删除图库管理
        /// </summary>
        Task BatchDeleteImGalleryAsync(List<int> input);

        #endregion




    }
}

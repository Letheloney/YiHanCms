                           
 
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
// Copyright © YoYoCms@China.2018-01-22T16:16:02. All Rights Reserved.
//<生成时间>2018-01-22T16:16:02</生成时间>
	#endregion
namespace  YiHan.Cms.CmsApp
{
	/// <summary>
    /// 系统配置服务接口
    /// </summary>
    public interface ISysSettingAppService : IApplicationService
    {
        #region 系统配置管理

        /// <summary>
        /// 根据查询条件获取系统配置分页列表
        /// </summary>
        Task<PagedResultDto<SysSettingListDto>> GetPagedSysSettingsAsync(GetSysSettingInput input);

        /// <summary>
        /// 通过Id获取系统配置信息进行编辑或修改 
        /// </summary>
        Task<GetSysSettingForEditOutput> GetSysSettingForEditAsync(NullableIdDto<int> input);

		  /// <summary>
        /// 通过指定id获取系统配置ListDto信息
        /// </summary>
		Task<SysSettingListDto> GetSysSettingByIdAsync(EntityDto<int> input);



        /// <summary>
        /// 新增或更改系统配置
        /// </summary>
        Task CreateOrUpdateSysSettingAsync(CreateOrUpdateSysSettingInput input);





        /// <summary>
        /// 新增系统配置
        /// </summary>
        Task<SysSettingEditDto> CreateSysSettingAsync(SysSettingEditDto input);

        /// <summary>
        /// 更新系统配置
        /// </summary>
        Task UpdateSysSettingAsync(SysSettingEditDto input);

        /// <summary>
        /// 删除系统配置
        /// </summary>
        Task DeleteSysSettingAsync(EntityDto<int> input);

        /// <summary>
        /// 批量删除系统配置
        /// </summary>
        Task BatchDeleteSysSettingAsync(List<int> input);

        #endregion




    }
}

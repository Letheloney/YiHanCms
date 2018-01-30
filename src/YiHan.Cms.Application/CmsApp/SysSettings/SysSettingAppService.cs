using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using YiHan.Cms.Authorization;
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
    /// 系统配置服务实现
    /// </summary>
    [AbpAuthorize(AppPermissions.SysSetting)]
		 
       
    public class SysSettingAppService : CmsAppServiceBase, ISysSettingAppService
    {
        private readonly IRepository<SysSetting,int> _sysSettingRepository;
		

	
        /// <summary>
        /// 构造方法
        /// </summary>
        public SysSettingAppService( IRepository<SysSetting,int> sysSettingRepository
	
  )
        {
            _sysSettingRepository = sysSettingRepository;
			
			 
        }


		  #region 实体的自定义扩展方法
        private IQueryable<SysSetting> _sysSettingRepositoryAsNoTrack => _sysSettingRepository.GetAll().AsNoTracking();


        #endregion


    #region 系统配置管理

    /// <summary>
    /// 根据查询条件获取系统配置分页列表
    /// </summary>
    public async Task<PagedResultDto<SysSettingListDto>> GetPagedSysSettingsAsync(GetSysSettingInput input)
{
			
    var query = _sysSettingRepositoryAsNoTrack;
    //TODO:根据传入的参数添加过滤条件

    var sysSettingCount = await query.CountAsync();

    var sysSettings = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var sysSettingListDtos = sysSettings.MapTo<List<SysSettingListDto>>();
    return new PagedResultDto<SysSettingListDto>(
    sysSettingCount,
    sysSettingListDtos
    );
    }

        /// <summary>
    /// 通过Id获取系统配置信息进行编辑或修改 
    /// </summary>
    public async Task<GetSysSettingForEditOutput> GetSysSettingForEditAsync(NullableIdDto<int> input)
{
    var output=new GetSysSettingForEditOutput();

    SysSettingEditDto sysSettingEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _sysSettingRepository.GetAsync(input.Id.Value);
    sysSettingEditDto=entity.MapTo<SysSettingEditDto>();
    }
	else 
	{
	sysSettingEditDto=new SysSettingEditDto();	
	}

	output.SysSetting=sysSettingEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取系统配置ListDto信息
    /// </summary>
    public async Task<SysSettingListDto> GetSysSettingByIdAsync(EntityDto<int> input)
{
    var entity = await _sysSettingRepository.GetAsync(input.Id);

    return entity.MapTo<SysSettingListDto>();
    }







    /// <summary>
    /// 新增或更改系统配置
    /// </summary>
    public async Task CreateOrUpdateSysSettingAsync(CreateOrUpdateSysSettingInput input)
{
    if (input.SysSettingEditDto.Id.HasValue)
{
    await UpdateSysSettingAsync(input.SysSettingEditDto);
    }
    else
{
    await CreateSysSettingAsync(input.SysSettingEditDto);
    }
    }

    /// <summary>
    /// 新增系统配置
    /// </summary>
	        [AbpAuthorize(AppPermissions.SysSetting_CreateSysSetting)]	 
         public virtual async Task<SysSettingEditDto> CreateSysSettingAsync(SysSettingEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

	var entity = input.MapTo<SysSetting>();
	
    entity = await _sysSettingRepository.InsertAsync(entity);
    return entity.MapTo<SysSettingEditDto>();
    }

    /// <summary>
    /// 编辑系统配置
    /// </summary>
	      [AbpAuthorize(AppPermissions.SysSetting_EditSysSetting)]
         public virtual async Task UpdateSysSettingAsync(SysSettingEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _sysSettingRepository.GetAsync(input.Id.Value);
	input.MapTo(entity);

    await _sysSettingRepository.UpdateAsync(entity);
    }

    /// <summary>
    /// 删除系统配置
    /// </summary>
	    [AbpAuthorize(AppPermissions.SysSetting_DeleteSysSetting)]
         public async Task DeleteSysSettingAsync(EntityDto<int> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _sysSettingRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除系统配置
    /// </summary>
	    [AbpAuthorize(AppPermissions.SysSetting_DeleteSysSetting)]
         public async Task BatchDeleteSysSettingAsync(List<int> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _sysSettingRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

            #endregion
  









    }
    }

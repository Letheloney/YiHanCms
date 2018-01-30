                                
                            
                                 
     
        

	using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Dynamic;
    using System.Text;
    using System.Threading.Tasks;
    using Abp;
    using Abp.Application.Services.Dto;
    using Abp.Authorization;
    using Abp.AutoMapper;
    using Abp.Configuration;
    using Abp.Domain.Repositories;
    using Abp.Extensions;
    using Abp.Linq.Extensions;
    using YiHan.Cms.CmsApp.Dtos;
using YiHan.Cms.Authorization;

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
// Copyright © YoYoCms@China.2018-01-22T16:09:15. All Rights Reserved.
//<生成时间>2018-01-22T16:09:15</生成时间>
#endregion


namespace  YiHan.Cms.CmsApp
{
    /// <summary>
    /// 图库管理服务实现
    /// </summary>
          [AbpAuthorize(AppPermissions.ImGallery)]
		 
       
    public class ImGalleryAppService : CmsAppServiceBase, IImGalleryAppService
    {
        private readonly IRepository<ImGallery,int> _imGalleryRepository;
		

		
        /// <summary>
        /// 构造方法
        /// </summary>
        public ImGalleryAppService( IRepository<ImGallery,int> imGalleryRepository

	
  )
        {
            _imGalleryRepository = imGalleryRepository;
			 
        }


		  #region 实体的自定义扩展方法
        private IQueryable<ImGallery> _imGalleryRepositoryAsNoTrack => _imGalleryRepository.GetAll().AsNoTracking();


        #endregion


    #region 图库管理管理

    /// <summary>
    /// 根据查询条件获取图库管理分页列表
    /// </summary>
    public async Task<PagedResultDto<ImGalleryListDto>> GetPagedImGallerysAsync(GetImGalleryInput input)
{
			
    var query = _imGalleryRepositoryAsNoTrack;
    //TODO:根据传入的参数添加过滤条件

    var imGalleryCount = await query.CountAsync();

    var imGallerys = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var imGalleryListDtos = imGallerys.MapTo<List<ImGalleryListDto>>();
    return new PagedResultDto<ImGalleryListDto>(
    imGalleryCount,
    imGalleryListDtos
    );
    }

        /// <summary>
    /// 通过Id获取图库管理信息进行编辑或修改 
    /// </summary>
    public async Task<GetImGalleryForEditOutput> GetImGalleryForEditAsync(NullableIdDto<int> input)
{
    var output=new GetImGalleryForEditOutput();

    ImGalleryEditDto imGalleryEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _imGalleryRepository.GetAsync(input.Id.Value);
    imGalleryEditDto=entity.MapTo<ImGalleryEditDto>();
    }
	else 
	{
	imGalleryEditDto=new ImGalleryEditDto();	
	}

	output.ImGallery=imGalleryEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取图库管理ListDto信息
    /// </summary>
    public async Task<ImGalleryListDto> GetImGalleryByIdAsync(EntityDto<int> input)
{
    var entity = await _imGalleryRepository.GetAsync(input.Id);

    return entity.MapTo<ImGalleryListDto>();
    }







    /// <summary>
    /// 新增或更改图库管理
    /// </summary>
    public async Task CreateOrUpdateImGalleryAsync(CreateOrUpdateImGalleryInput input)
{
    if (input.ImGalleryEditDto.Id.HasValue)
{
    await UpdateImGalleryAsync(input.ImGalleryEditDto);
    }
    else
{
    await CreateImGalleryAsync(input.ImGalleryEditDto);
    }
    }

    /// <summary>
    /// 新增图库管理
    /// </summary>
	        [AbpAuthorize(AppPermissions.ImGallery_CreateImGallery)]	 
         public virtual async Task<ImGalleryEditDto> CreateImGalleryAsync(ImGalleryEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

	var entity = input.MapTo<ImGallery>();
	
    entity = await _imGalleryRepository.InsertAsync(entity);
    return entity.MapTo<ImGalleryEditDto>();
    }

    /// <summary>
    /// 编辑图库管理
    /// </summary>
	      [AbpAuthorize(AppPermissions.ImGallery_EditImGallery)]
         public virtual async Task UpdateImGalleryAsync(ImGalleryEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _imGalleryRepository.GetAsync(input.Id.Value);
	input.MapTo(entity);

    await _imGalleryRepository.UpdateAsync(entity);
    }

    /// <summary>
    /// 删除图库管理
    /// </summary>
	    [AbpAuthorize(AppPermissions.ImGallery_DeleteImGallery)]
         public async Task DeleteImGalleryAsync(EntityDto<int> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _imGalleryRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除图库管理
    /// </summary>
	    [AbpAuthorize(AppPermissions.ImGallery_DeleteImGallery)]
         public async Task BatchDeleteImGalleryAsync(List<int> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _imGalleryRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

            #endregion
  









    }
    }

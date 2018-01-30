                                
                            
                                 
     
        

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
// Copyright © YoYoCms@China.2018-01-22T16:02:49. All Rights Reserved.
//<生成时间>2018-01-22T16:02:49</生成时间>
#endregion


namespace YiHan.Cms.CmsApp
{
    /// <summary>
    /// 文章管理服务实现
    /// </summary>
          [AbpAuthorize(AppPermissions.Artice)]
		 
       
    public class ArticeAppService : CmsAppServiceBase, IArticeAppService
    {
        private readonly IRepository<Artice,int> _articeRepository;
		

	
        /// <summary>
        /// 构造方法
        /// </summary>
        public ArticeAppService( IRepository<Artice,int> articeRepository
	
  )
        {
            _articeRepository = articeRepository;
			
			 
        }


		  #region 实体的自定义扩展方法
        private IQueryable<Artice> _articeRepositoryAsNoTrack => _articeRepository.GetAll().AsNoTracking();


        #endregion


    #region 文章管理管理

    /// <summary>
    /// 根据查询条件获取文章管理分页列表
    /// </summary>
    public async Task<PagedResultDto<ArticeEditDto>> GetPagedArticesAsync(GetArticeInput input)
{
			
    var query = _articeRepositoryAsNoTrack;
            //TODO:根据传入的参数添加过滤条件
            query = query.WhereIf(input.ParentId > 0, c => c.Category_ID == input.ParentId)
                        .WhereIf(!string.IsNullOrEmpty(input.Name), c => c.Art_Name == input.Name)
                        .Where(c => c.Status == input.Status);
    var articeCount = await query.CountAsync();

    var artices = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var articeListDtos = artices.MapTo<List<ArticeEditDto>>();
    return new PagedResultDto<ArticeEditDto>(
    articeCount,
    articeListDtos
    );
    }

        /// <summary>
    /// 通过Id获取文章管理信息进行编辑或修改 
    /// </summary>
    public async Task<GetArticeForEditOutput> GetArticeForEditAsync(NullableIdDto<int> input)
{
    var output=new GetArticeForEditOutput();

    ArticeEditDto articeEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _articeRepository.GetAsync(input.Id.Value);
    articeEditDto=entity.MapTo<ArticeEditDto>();
    }
	else 
	{
	articeEditDto=new ArticeEditDto();	
	}

	output.Artice=articeEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取文章管理ListDto信息
    /// </summary>
    public async Task<ArticeListDto> GetArticeByIdAsync(EntityDto<int> input)
{
    var entity = await _articeRepository.GetAsync(input.Id);

    return entity.MapTo<ArticeListDto>();
    }







    /// <summary>
    /// 新增或更改文章管理
    /// </summary>
    public async Task CreateOrUpdateArticeAsync(CreateOrUpdateArticeInput input)
{
    if (input.ArticeEditDto.Id.HasValue)
{
    await UpdateArticeAsync(input.ArticeEditDto);
    }
    else
{
    await CreateArticeAsync(input.ArticeEditDto);
    }
    }

    /// <summary>
    /// 新增文章管理
    /// </summary>
	        [AbpAuthorize(AppPermissions.Artice_CreateArtice)]	 
         public virtual async Task<ArticeEditDto> CreateArticeAsync(ArticeEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

	var entity = input.MapTo<Artice>();
	
    entity = await _articeRepository.InsertAsync(entity);
    return entity.MapTo<ArticeEditDto>();
    }

    /// <summary>
    /// 编辑文章管理
    /// </summary>
	      [AbpAuthorize(AppPermissions.Artice_EditArtice)]
         public virtual async Task UpdateArticeAsync(ArticeEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _articeRepository.GetAsync(input.Id.Value);
	input.MapTo(entity);

    await _articeRepository.UpdateAsync(entity);
    }

    /// <summary>
    /// 删除文章管理
    /// </summary>
	    [AbpAuthorize(AppPermissions.Artice_DeleteArtice)]
         public async Task DeleteArticeAsync(EntityDto<int> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _articeRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除文章管理
    /// </summary>
	    [AbpAuthorize(AppPermissions.Artice_DeleteArtice)]
         public async Task BatchDeleteArticeAsync(List<int> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _articeRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

            #endregion
  









    }
    }

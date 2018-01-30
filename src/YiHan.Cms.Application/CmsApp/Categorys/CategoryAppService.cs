                                
                            
                                 
     
        

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
	using YiHan.Cms.Authorization;  
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
// Copyright © YoYoCms@China.2018-01-22T16:07:51. All Rights Reserved.
//<生成时间>2018-01-22T16:07:51</生成时间>
	#endregion


    namespace  YiHan.Cms.CmsApp
{
    /// <summary>
    /// 分类管理服务实现
    /// </summary>
          [AbpAuthorize(AppPermissions.Category)]
		 
       
    public class CategoryAppService : CmsAppServiceBase, ICategoryAppService
    {
        private readonly IRepository<Category,int> _categoryRepository;
		

		
        /// <summary>
        /// 构造方法
        /// </summary>
        public CategoryAppService( IRepository<Category,int> categoryRepository

	
  )
        {
            _categoryRepository = categoryRepository;
			
			 
        }


		  #region 实体的自定义扩展方法
        private IQueryable<Category> _categoryRepositoryAsNoTrack => _categoryRepository.GetAll().AsNoTracking();


        #endregion


    #region 分类管理管理

    /// <summary>
    /// 根据查询条件获取分类管理分页列表
    /// </summary>
    public async Task<PagedResultDto<CategoryListDto>> GetPagedCategorysAsync(GetCategoryInput input)
{
			
    var query = _categoryRepositoryAsNoTrack;
            //TODO:根据传入的参数添加过滤条件
    query=query.WhereIf(string.IsNullOrEmpty(input.Name), c => c.Category_Name == input.Name)
                 .WhereIf(input.status.HasValue, c => c.Status == input.status);
    var categoryCount = await query.CountAsync();

    var categorys = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var categoryListDtos = categorys.MapTo<List<CategoryListDto>>();
    return new PagedResultDto<CategoryListDto>(
    categoryCount,
    categoryListDtos
    );
    }
           /// <summary>
    /// 根据查询条件获取分类管理分页列表
    /// </summary>
    public  List<CategoryEditDto> GetCategorysList(GetCategoryInput input)
{
    var entity =  _categoryRepository.GetAll();
    var categoryEditDto = entity.MapTo<List<CategoryEditDto>>();
    return categoryEditDto;
    }
        /// <summary>
    /// 通过Id获取分类管理信息进行编辑或修改 
    /// </summary>
    public async Task<GetCategoryForEditOutput> GetCategoryForEditAsync(NullableIdDto<int> input)
{
    var output=new GetCategoryForEditOutput();

    CategoryEditDto categoryEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _categoryRepository.GetAsync(input.Id.Value);
    categoryEditDto=entity.MapTo<CategoryEditDto>();
    }
	else 
	{
	categoryEditDto=new CategoryEditDto();	
	}

	output.Category=categoryEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取分类管理ListDto信息
    /// </summary>
    public async Task<CategoryListDto> GetCategoryByIdAsync(EntityDto<int> input)
{
    var entity = await _categoryRepository.GetAsync(input.Id);

    return entity.MapTo<CategoryListDto>();
    }







    /// <summary>
    /// 新增或更改分类管理
    /// </summary>
    public async Task CreateOrUpdateCategoryAsync(CreateOrUpdateCategoryInput input)
{
    if (input.CategoryEditDto.Id.HasValue)
{
    await UpdateCategoryAsync(input.CategoryEditDto);
    }
    else
{
    await CreateCategoryAsync(input.CategoryEditDto);
    }
    }

    /// <summary>
    /// 新增分类管理
    /// </summary>
	        [AbpAuthorize(AppPermissions.Category_CreateCategory)]	 
         public virtual async Task<CategoryEditDto> CreateCategoryAsync(CategoryEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

	var entity = input.MapTo<Category>();
	
    entity = await _categoryRepository.InsertAsync(entity);
    return entity.MapTo<CategoryEditDto>();
    }

    /// <summary>
    /// 编辑分类管理
    /// </summary>
	      [AbpAuthorize(AppPermissions.Category_EditCategory)]
         public virtual async Task UpdateCategoryAsync(CategoryEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _categoryRepository.GetAsync(input.Id.Value);
	input.MapTo(entity);

    await _categoryRepository.UpdateAsync(entity);
    }

    /// <summary>
    /// 删除分类管理
    /// </summary>
	    [AbpAuthorize(AppPermissions.Category_DeleteCategory)]
         public async Task DeleteCategoryAsync(EntityDto<int> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _categoryRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除分类管理
    /// </summary>
	    [AbpAuthorize(AppPermissions.Category_DeleteCategory)]
         public async Task BatchDeleteCategoryAsync(List<int> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _categoryRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

            #endregion
  









    }
    }

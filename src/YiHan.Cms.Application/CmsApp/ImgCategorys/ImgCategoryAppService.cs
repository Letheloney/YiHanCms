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
using YiHan.Cms.CmsApp.Dtos;

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
// Copyright © YoYoCms@China.2018-01-22T16:19:09. All Rights Reserved.
//<生成时间>2018-01-22T16:19:09</生成时间>
#endregion


namespace  YiHan.Cms.CmsApp
{
    /// <summary>
    /// 图片分类服务实现
    /// </summary>
    [AbpAuthorize(AppPermissions.ImgCategory)]
		 
       
    public class ImgCategoryAppService : CmsAppServiceBase, IImgCategoryAppService
    {
        private readonly IRepository<ImgCategory,int> _imgCategoryRepository;
		

		
        /// <summary>
        /// 构造方法
        /// </summary>
        public ImgCategoryAppService( IRepository<ImgCategory,int> imgCategoryRepository
	
  )
        {
            _imgCategoryRepository = imgCategoryRepository;
		
        }


		  #region 实体的自定义扩展方法
        private IQueryable<ImgCategory> _imgCategoryRepositoryAsNoTrack => _imgCategoryRepository.GetAll().AsNoTracking();


        #endregion


    #region 图片分类管理

    /// <summary>
    /// 根据查询条件获取图片分类分页列表
    /// </summary>
    public async Task<PagedResultDto<ImgCategoryListDto>> GetPagedImgCategorysAsync(GetImgCategoryInput input)
{
			
    var query = _imgCategoryRepositoryAsNoTrack;
    //TODO:根据传入的参数添加过滤条件

    var imgCategoryCount = await query.CountAsync();

    var imgCategorys = await query
    .OrderBy(input.Sorting)
    .PageBy(input)
    .ToListAsync();

    var imgCategoryListDtos = imgCategorys.MapTo<List<ImgCategoryListDto>>();
    return new PagedResultDto<ImgCategoryListDto>(
    imgCategoryCount,
    imgCategoryListDtos
    );
    }

        /// <summary>
    /// 通过Id获取图片分类信息进行编辑或修改 
    /// </summary>
    public async Task<GetImgCategoryForEditOutput> GetImgCategoryForEditAsync(NullableIdDto<int> input)
{
    var output=new GetImgCategoryForEditOutput();

    ImgCategoryEditDto imgCategoryEditDto;

    if(input.Id.HasValue)
	{
    var entity=await _imgCategoryRepository.GetAsync(input.Id.Value);
    imgCategoryEditDto=entity.MapTo<ImgCategoryEditDto>();
    }
	else 
	{
	imgCategoryEditDto=new ImgCategoryEditDto();	
	}

	output.ImgCategory=imgCategoryEditDto;
	return output;
    }


    /// <summary>
    /// 通过指定id获取图片分类ListDto信息
    /// </summary>
    public async Task<ImgCategoryListDto> GetImgCategoryByIdAsync(EntityDto<int> input)
{
    var entity = await _imgCategoryRepository.GetAsync(input.Id);

    return entity.MapTo<ImgCategoryListDto>();
    }







    /// <summary>
    /// 新增或更改图片分类
    /// </summary>
    public async Task CreateOrUpdateImgCategoryAsync(CreateOrUpdateImgCategoryInput input)
{
    if (input.ImgCategoryEditDto.Id.HasValue)
{
    await UpdateImgCategoryAsync(input.ImgCategoryEditDto);
    }
    else
{
    await CreateImgCategoryAsync(input.ImgCategoryEditDto);
    }
    }

    /// <summary>
    /// 新增图片分类
    /// </summary>
	        [AbpAuthorize(AppPermissions.ImgCategory_CreateImgCategory)]	 
         public virtual async Task<ImgCategoryEditDto> CreateImgCategoryAsync(ImgCategoryEditDto input)
{
    //TODO:新增前的逻辑判断，是否允许新增

	var entity = input.MapTo<ImgCategory>();
	
    entity = await _imgCategoryRepository.InsertAsync(entity);
    return entity.MapTo<ImgCategoryEditDto>();
    }

    /// <summary>
    /// 编辑图片分类
    /// </summary>
	      [AbpAuthorize(AppPermissions.ImgCategory_EditImgCategory)]
         public virtual async Task UpdateImgCategoryAsync(ImgCategoryEditDto input)
{
    //TODO:更新前的逻辑判断，是否允许更新

    var entity = await _imgCategoryRepository.GetAsync(input.Id.Value);
	input.MapTo(entity);

    await _imgCategoryRepository.UpdateAsync(entity);
    }

    /// <summary>
    /// 删除图片分类
    /// </summary>
	    [AbpAuthorize(AppPermissions.ImgCategory_DeleteImgCategory)]
         public async Task DeleteImgCategoryAsync(EntityDto<int> input)
{
    //TODO:删除前的逻辑判断，是否允许删除
    await _imgCategoryRepository.DeleteAsync(input.Id);
    }

        /// <summary>
    /// 批量删除图片分类
    /// </summary>
	    [AbpAuthorize(AppPermissions.ImgCategory_DeleteImgCategory)]
         public async Task BatchDeleteImgCategoryAsync(List<int> input)
{
    //TODO:批量删除前的逻辑判断，是否允许删除
    await _imgCategoryRepository.DeleteAsync(s=>input.Contains(s.Id));
    }

            #endregion
  









    }
    }

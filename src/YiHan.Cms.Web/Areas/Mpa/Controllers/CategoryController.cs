using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiHan.Cms.CmsApp.Dtos;
using YiHan.Cms.CmsApp;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using YiHan.Cms.Web.Controllers;

namespace YiHan.Cms.Web.Areas.Mpa.Controllers
{
    public class CategoryController : CmsControllerBase
    {
        #region 全局变量、构造函数、依赖注入
        public ICategoryAppService _iCategoryAppService;
        public CategoryController(ICategoryAppService categoryAppService)
        {
            _iCategoryAppService = categoryAppService;
        }
        #endregion
        // GET: Mpa/Category
        #region 基础增删改查函数、控制器方法
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult CategorysList(GetCategoryInput input)
        {
            var cateGoryList = _iCategoryAppService.GetCategorysList(input);
            JsonResult result = new JsonResult();
            result.Data = cateGoryList;
            return result;
        }
        [HttpPost]
        public async Task<JsonResult>  UdateCol(CategoryEditDto categoryEditDto)
        {
            //更新实体
            try
            {
                await _iCategoryAppService.UpdateCategoryAsync(categoryEditDto);
                return Json(new { }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json("false");
            }
        }
        public async Task<ActionResult> CreateOrEditModal(int? Id)
        {
          
            var cateGoryAllList = _iCategoryAppService.GetCategorysList(new GetCategoryInput { FilterText = "" });
            ViewBag.cateGoryList = cateGoryAllList;
          
           
            if (Id.HasValue)
            {
                var cateGoryList = await _iCategoryAppService.GetCategoryForEditAsync(new NullableIdDto<int> { Id = Id });
                return PartialView("_CreateOrEditModal", cateGoryList.Category);

            }
            else
            {
                CategoryEditDto categoryEdit = new CategoryEditDto();
                return PartialView("_CreateOrEditModal", categoryEdit);
            }

        } 
        #endregion
    }
}
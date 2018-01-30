using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiHan.Cms.CmsApp.Dtos;
using YiHan.Cms.CmsApp;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using YiHan.Cms.Web.Controllers;

namespace YiHan.Cms.Web.Areas.Mpa.Controllers
{
    public class ArticeController : CmsControllerBase
    {
        #region 全局变量、构造函数、依赖注入
        public IArticeAppService _iArticeAppService;
        public ICategoryAppService _iCategoryAppService;
        public ArticeController(IArticeAppService articeAppService,ICategoryAppService categoryAppService)
        {
            _iArticeAppService = articeAppService;
            _iCategoryAppService = categoryAppService;
        } 
        #endregion
        // GET: Mpa/Artice
        public ActionResult Index()
        {
            var cateGoryAllList = _iCategoryAppService.GetCategorysList(new GetCategoryInput { FilterText = "" });
            ViewBag.cateGoryList = cateGoryAllList;
            return View();
        }
        public async Task<ActionResult>  CreateOrEdit(int? id)
        {
            var cateGoryAllList = _iCategoryAppService.GetCategorysList(new GetCategoryInput { FilterText = "" });
            ViewBag.cateGoryList = cateGoryAllList;
            ArticeEditDto articeEditDto = new ArticeEditDto();
            if (id.HasValue)
            {
                var ArticeForEdit = await _iArticeAppService.GetArticeForEditAsync(new NullableIdDto<int> { Id = id });
                return View(ArticeForEdit.Artice);
            }
            return View(articeEditDto);
        }
        [HttpPost]
        public async Task<JsonResult> UdateCol(ArticeEditDto articeEditDto)
        {
            //更新实体
            try
            {
                await _iArticeAppService.UpdateArticeAsync(articeEditDto);
                return Json(new { }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception)
            {

                return Json("false");
            }
        }
    }
}
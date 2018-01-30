using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YiHan.Cms.CmsApp.Dtos;
using YiHan.Cms.CmsApp;
using System.Threading.Tasks;
using YiHan.Cms.Web.Controllers;

namespace YiHan.Cms.Web.Areas.Mpa.Controllers
{
    public class TempSystemController : CmsControllerBase
    {
        public ITemplateAppService _iTemplateAppServiceCate;
        public ICategoryAppService _iCategoryAppService;
        public TempSystemController(ITemplateAppService templateAppServiceCate, ICategoryAppService CategoryAppService)
        {
            _iTemplateAppServiceCate = templateAppServiceCate;
            _iCategoryAppService = CategoryAppService;
        }
        // GET: Mpa/TempSystem
        public ActionResult CreateOrUpdate()
        {
            return View();
        }
        [ValidateInput(false)]
        [HttpPost]
        public async Task<bool>  IndexTemp(string htmlTemp,string Path)
        {
            var cate = await _iCategoryAppService.GetCategoryForEditAsync(new Abp.Application.Services.Dto.NullableIdDto<int> { Id=2});
            
            _iTemplateAppServiceCate.CreateStaticPage(htmlTemp, Path,new TempModel { CategoryEdit=cate.Category});
            return true;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiHan.Cms.CmsApp
{
   public interface ITemplateAppService : IApplicationService
    {
        /// <summary>
        /// 解析模板生成静态页
        /// </summary>
        /// <param name="temp">模板</param>
        /// <param name="path">静态页地址</param>
        /// <param name="t">数据模型</param>
        /// <returns></returns>
        bool CreateStaticPage(string temp, string path, TempModel t);
        /// <summary>
        /// 获取页面的Html代码
        /// </summary>
        /// <param name="url">模板页面路径</param>
        /// <param name="encoding">页面编码</param>
        /// <returns></returns>
        string GetHtml(string url, System.Text.Encoding encoding);
        /// <summary>
        /// 获取页面的编码
        /// </summary>
        /// <param name="html">Html源码</param>
        /// <returns></returns>
        System.Text.Encoding GetEncoding(string html);
        /// <summary>
        /// 创建静态文件
        /// </summary>
        /// <param name="result">Html代码</param>
        /// <param name="createpath">生成路径</param>
        /// <returns></returns>
        bool CreateFileHtmlByTemp(string result, string createpath);
    }
}

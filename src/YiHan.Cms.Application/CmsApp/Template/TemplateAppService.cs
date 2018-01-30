using RazorEngine;
using RazorEngine.Configuration;
using RazorEngine.Templating;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YiHan.Cms.CmsApp
{
   public class TemplateAppService: CmsAppServiceBase,ITemplateAppService
    {
        // <summary>
        /// 解析模板生成静态页
        /// </summary>
        /// <param name="temp">模板地址</param>
        /// <param name="path">静态页地址</param>
        /// <param name="t">数据模型</param>
        /// <returns></returns>
        public bool CreateStaticPage(string temp, string path, TempModel t)
        {
            try
            {
                //实例化模型


                var config = new TemplateServiceConfiguration();
                using (var service = RazorEngineService.Create(config))
                {
                    var model = t;
                    string result = service.RunCompile(temp, string.Empty, null, model);
                    return CreateFileHtmlByTemp(result, path);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// 获取页面的Html代码
        /// </summary>
        /// <param name="url">模板页面路径</param>
        /// <param name="encoding">页面编码</param>
        /// <returns></returns>
        public string GetHtml(string url, System.Text.Encoding encoding)
        {
            byte[] buf = new WebClient().DownloadData(url);
            if (encoding != null) return encoding.GetString(buf);
            string html = System.Text.Encoding.UTF8.GetString(buf);
            encoding = GetEncoding(html);
            if (encoding == null || encoding == System.Text.Encoding.UTF8) return html;
            return encoding.GetString(buf);
        }
        /// <summary>
        /// 获取页面的编码
        /// </summary>
        /// <param name="html">Html源码</param>
        /// <returns></returns>
        public System.Text.Encoding GetEncoding(string html)
        {
            string pattern = @"(?i)\bcharset=(?<charset>[-a-zA-Z_0-9]+)";
            string charset = Regex.Match(html, pattern).Groups["charset"].Value;
            try { return System.Text.Encoding.GetEncoding(charset); }
            catch (ArgumentException) { return null; }
        }
        /// <summary>
        /// 创建静态文件
        /// </summary>
        /// <param name="result">Html代码</param>
        /// <param name="createpath">生成路径</param>
        /// <returns></returns>
        public bool CreateFileHtmlByTemp(string result, string createpath)
        {
            if (!string.IsNullOrEmpty(result))
            {
                if (string.IsNullOrEmpty(createpath))
                {
                    createpath = "\\default.html";
                }
                string filepath = AppDomain.CurrentDomain.BaseDirectory+"test\\"; 
                
                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }
                createpath = filepath+ createpath;
                try
                {
                    FileStream fs2 = new FileStream(createpath, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs2, new System.Text.UTF8Encoding(true));//去除UTF-8 BOM
                    sw.Write(result);
                    sw.Close();
                    fs2.Close();
                    fs2.Dispose();
                    return true;
                }
                catch { return false; }
            }
            return false;
        }
    }

}

                            

using AutoMapper;
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
// Copyright © YoYoCms@China.2018-01-22T16:16:03. All Rights Reserved.
//<生成时间>2018-01-22T16:16:03</生成时间>
	#endregion
namespace  YiHan.Cms.CmsApp.Mappers
{
	/// <summary>
    /// SysSettingDto映射配置
    /// </summary>
    public class SysSettingDtoMapper 
    {

    private static volatile bool _mappedBefore;
        private static readonly object SyncObj = new object();



        /// <summary>
        /// 初始化映射
        /// </summary>
        public void CreateMappings(IMapperConfigurationExpression configuration)
        {
        
		  lock (SyncObj)
            {
                if (_mappedBefore)
                {
                    return;
                }

                CreateMappingsInternal(configuration);

                _mappedBefore = true;
            }

        }
    




	    /// <summary>
       ///    Configuration.Modules.AbpAutoMapper().Configurators.Add(SysSettingDtoMapper.CreateMappings);
      ///注入位置    < see cref = "CmsApplicationModule" /> 
     /// <param name="configuration"></param>
    /// </summary>       
	  private static void CreateMappingsInternal(IMapperConfigurationExpression configuration)
	  {
	           
			      //默认ABP功能已经实现了，如果你要单独对DTO进行拓展，可以在此处放开注释文件。

	  // Configuration.Modules.AbpAutoMapper().Configurators.Add(SysSettingDtoMapper.CreateMappings);

	    //    Mapper.CreateMap<SysSetting,SysSettingEditDto>();
       //     Mapper.CreateMap<SysSetting, SysSettingListDto>();

     //       Mapper.CreateMap<SysSettingEditDto, SysSetting>();
    //        Mapper.CreateMap<SysSettingListDto,SysSetting>();
  






 	  }


}}
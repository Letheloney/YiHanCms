using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using YiHan.Cms.EntityFramework;

namespace YiHan.Cms.Migrator
{
    [DependsOn(typeof(CmsDataModule))]
    public class CmsMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<CmsDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
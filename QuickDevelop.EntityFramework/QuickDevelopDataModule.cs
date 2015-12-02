using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using QuickDevelop.EntityFramework;

namespace QuickDevelop
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(QuickDevelopCoreModule))]
    public class QuickDevelopDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

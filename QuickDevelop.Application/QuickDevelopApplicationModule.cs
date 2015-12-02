using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace QuickDevelop
{
    [DependsOn(typeof(QuickDevelopCoreModule), typeof(AbpAutoMapperModule))]
    public class QuickDevelopApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

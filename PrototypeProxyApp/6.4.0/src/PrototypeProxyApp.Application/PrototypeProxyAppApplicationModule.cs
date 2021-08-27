using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PrototypeProxyApp
{
    [DependsOn(
        typeof(PrototypeProxyAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PrototypeProxyAppApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototypeProxyAppApplicationModule).GetAssembly());
        }
    }
}
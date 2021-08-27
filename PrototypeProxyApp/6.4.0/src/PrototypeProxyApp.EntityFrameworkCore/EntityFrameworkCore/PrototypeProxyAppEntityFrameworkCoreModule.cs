using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace PrototypeProxyApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(PrototypeProxyAppCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class PrototypeProxyAppEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototypeProxyAppEntityFrameworkCoreModule).GetAssembly());
        }
    }
}
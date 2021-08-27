using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototypeProxyApp.Web.Startup;
namespace PrototypeProxyApp.Web.Tests
{
    [DependsOn(
        typeof(PrototypeProxyAppWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class PrototypeProxyAppWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototypeProxyAppWebTestModule).GetAssembly());
        }
    }
}
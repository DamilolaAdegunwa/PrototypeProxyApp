using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototypeProxyApp.Configuration;
using PrototypeProxyApp.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace PrototypeProxyApp.Web.Startup
{
    [DependsOn(
        typeof(PrototypeProxyAppApplicationModule), 
        typeof(PrototypeProxyAppEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class PrototypeProxyAppWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PrototypeProxyAppWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(PrototypeProxyAppConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<PrototypeProxyAppNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(PrototypeProxyAppApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototypeProxyAppWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(PrototypeProxyAppWebModule).Assembly);
        }
    }
}

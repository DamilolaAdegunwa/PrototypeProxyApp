using Abp.Modules;
using Abp.Reflection.Extensions;
using PrototypeProxyApp.Localization;

namespace PrototypeProxyApp
{
    public class PrototypeProxyAppCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            PrototypeProxyAppLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = PrototypeProxyAppConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PrototypeProxyAppCoreModule).GetAssembly());
        }
    }
}
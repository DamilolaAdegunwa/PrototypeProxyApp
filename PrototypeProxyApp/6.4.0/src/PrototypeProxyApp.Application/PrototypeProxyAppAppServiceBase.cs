using Abp.Application.Services;

namespace PrototypeProxyApp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class PrototypeProxyAppAppServiceBase : ApplicationService
    {
        protected PrototypeProxyAppAppServiceBase()
        {
            LocalizationSourceName = PrototypeProxyAppConsts.LocalizationSourceName;
        }
    }
}
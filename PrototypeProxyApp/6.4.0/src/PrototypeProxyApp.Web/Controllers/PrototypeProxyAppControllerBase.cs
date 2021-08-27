using Abp.AspNetCore.Mvc.Controllers;

namespace PrototypeProxyApp.Web.Controllers
{
    public abstract class PrototypeProxyAppControllerBase: AbpController
    {
        protected PrototypeProxyAppControllerBase()
        {
            LocalizationSourceName = PrototypeProxyAppConsts.LocalizationSourceName;
        }
    }
}
using Abp.AspNetCore.Mvc.Views;

namespace PrototypeProxyApp.Web.Views
{
    public abstract class PrototypeProxyAppRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected PrototypeProxyAppRazorPage()
        {
            LocalizationSourceName = PrototypeProxyAppConsts.LocalizationSourceName;
        }
    }
}

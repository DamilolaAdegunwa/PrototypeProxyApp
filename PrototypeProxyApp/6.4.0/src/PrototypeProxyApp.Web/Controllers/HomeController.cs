using Microsoft.AspNetCore.Mvc;

namespace PrototypeProxyApp.Web.Controllers
{
    public class HomeController : PrototypeProxyAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
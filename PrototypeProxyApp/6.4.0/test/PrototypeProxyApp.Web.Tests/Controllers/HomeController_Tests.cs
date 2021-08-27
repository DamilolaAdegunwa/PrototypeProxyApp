using System.Threading.Tasks;
using PrototypeProxyApp.Web.Controllers;
using Shouldly;
using Xunit;

namespace PrototypeProxyApp.Web.Tests.Controllers
{
    public class HomeController_Tests: PrototypeProxyAppWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}

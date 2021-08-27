using PrototypeProxyApp.Configuration;
using PrototypeProxyApp.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PrototypeProxyApp.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class PrototypeProxyAppDbContextFactory : IDesignTimeDbContextFactory<PrototypeProxyAppDbContext>
    {
        public PrototypeProxyAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PrototypeProxyAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(PrototypeProxyAppConsts.ConnectionStringName)
            );

            return new PrototypeProxyAppDbContext(builder.Options);
        }
    }
}
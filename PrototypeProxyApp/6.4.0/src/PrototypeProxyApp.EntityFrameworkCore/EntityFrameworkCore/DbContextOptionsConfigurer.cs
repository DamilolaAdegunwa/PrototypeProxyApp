using Microsoft.EntityFrameworkCore;

namespace PrototypeProxyApp.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<PrototypeProxyAppDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for PrototypeProxyAppDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}

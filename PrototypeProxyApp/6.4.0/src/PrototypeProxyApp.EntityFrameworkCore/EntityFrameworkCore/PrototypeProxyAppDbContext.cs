using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PrototypeProxyApp.EntityFrameworkCore
{
    public class PrototypeProxyAppDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public PrototypeProxyAppDbContext(DbContextOptions<PrototypeProxyAppDbContext> options) 
            : base(options)
        {

        }
    }
}

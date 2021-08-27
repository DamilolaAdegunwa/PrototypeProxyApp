using System;
using System.Threading.Tasks;
using Abp.TestBase;
using PrototypeProxyApp.EntityFrameworkCore;
using PrototypeProxyApp.Tests.TestDatas;

namespace PrototypeProxyApp.Tests
{
    public class PrototypeProxyAppTestBase : AbpIntegratedTestBase<PrototypeProxyAppTestModule>
    {
        public PrototypeProxyAppTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<PrototypeProxyAppDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<PrototypeProxyAppDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<PrototypeProxyAppDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<PrototypeProxyAppDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<PrototypeProxyAppDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<PrototypeProxyAppDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<PrototypeProxyAppDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<PrototypeProxyAppDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}

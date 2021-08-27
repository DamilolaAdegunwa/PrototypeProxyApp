using PrototypeProxyApp.EntityFrameworkCore;

namespace PrototypeProxyApp.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly PrototypeProxyAppDbContext _context;

        public TestDataBuilder(PrototypeProxyAppDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}
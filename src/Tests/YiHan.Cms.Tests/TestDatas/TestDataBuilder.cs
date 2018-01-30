using EntityFramework.DynamicFilters;
using YiHan.Cms.EntityFramework;

namespace YiHan.Cms.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly CmsDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(CmsDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}

﻿using System.Linq;
using Abp.Organizations;
using YiHan.Cms.EntityFramework;
using YiHan.Cms.MultiTenancy;

namespace YiHan.Cms.Tests.TestDatas
{
    /* Creates OU tree for default tenant as shown below:
     * 
     * - OU1
     *   - OU11
     *     - OU111
     *     - OU112
     *   - OU12
     * - OU2
     *   - OU21
     */
    public class TestOrganizationUnitsBuilder
    {
        private readonly CmsDbContext _context;
        private readonly int _tenantId;

        public TestOrganizationUnitsBuilder(CmsDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreateOUs();
        }

        private void CreateOUs()
        {
            var ou1 = CreateOU("OU1", OrganizationUnit.CreateCode(1));
            var ou11 = CreateOU("OU11", OrganizationUnit.CreateCode(1, 1), ou1.Id);
            var ou111 = CreateOU("OU111", OrganizationUnit.CreateCode(1, 1, 1), ou11.Id);
            var ou112 = CreateOU("OU112", OrganizationUnit.CreateCode(1, 1, 2), ou11.Id);
            var ou12 = CreateOU("OU12", OrganizationUnit.CreateCode(1, 2), ou1.Id);
            var ou2 = CreateOU("OU2", OrganizationUnit.CreateCode(2));
            var ou21 = CreateOU("OU21", OrganizationUnit.CreateCode(2, 1), ou2.Id);
        }

        private OrganizationUnit CreateOU(string displayName, string code, long? parentId = null)
        {
            var ou = _context.OrganizationUnits.Add(new OrganizationUnit(_tenantId, displayName, parentId) { Code = code });
            _context.SaveChanges();
            return ou;
        }
    }
}

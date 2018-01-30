using YiHan.Cms.EntityFramework;

namespace YiHan.Cms.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly CmsDbContext _context;

        public InitialHostDbBuilder(CmsDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}

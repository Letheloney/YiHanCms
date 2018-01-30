using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using YiHan.Cms.Authorization.Roles;
using YiHan.Cms.Authorization.Users;
using YiHan.Cms.Chat;
using YiHan.Cms.Friendships;
using YiHan.Cms.MultiTenancy;
using YiHan.Cms.Storage;
using YiHan.Cms.CmsApp;

namespace YiHan.Cms.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class CmsDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }
        public virtual IDbSet<Artice> Artice { get; set; }
        public virtual IDbSet<SysSetting> SysSetting { get; set; }
        public virtual IDbSet<Category> Category { get; set; }
        public virtual IDbSet<ImGallery> ImGallery { get; set; }
        public virtual IDbSet<ImgCategory> ImgCategory { get; set; }
        public CmsDbContext()
            : base("Default")
        {
            
        }

        public CmsDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public CmsDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public CmsDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

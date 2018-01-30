namespace YiHan.Cms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTemplate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "CMS.Templates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        content = c.String(),
                        FileName = c.String(),
                        FloderName = c.String(),
                        WebCode = c.String(),
                        TempCatelogy = c.Int(nullable: false),
                        LastModifierUserId = c.Long(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        CreatorUserId = c.Long(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("CMS.Templates");
        }
    }
}

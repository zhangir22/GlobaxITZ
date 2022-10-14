namespace GlobaxIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Global : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        phone = c.String(),
                        email = c.String(),
                        dateReceipt = c.DateTime(nullable: false),
                        jobTitle = c.String(),
                        subdivision = c.String(),
                        additionalInformation = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}

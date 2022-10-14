namespace GlobaxIT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewGlobal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "address", c => c.String());
            AddColumn("dbo.Users", "position_name", c => c.String());
            AddColumn("dbo.Users", "department", c => c.String());
            AddColumn("dbo.Users", "hire_date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "dateReceipt");
            DropColumn("dbo.Users", "jobTitle");
            DropColumn("dbo.Users", "subdivision");
            DropColumn("dbo.Users", "additionalInformation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "additionalInformation", c => c.String());
            AddColumn("dbo.Users", "subdivision", c => c.String());
            AddColumn("dbo.Users", "jobTitle", c => c.String());
            AddColumn("dbo.Users", "dateReceipt", c => c.DateTime(nullable: false));
            DropColumn("dbo.Users", "hire_date");
            DropColumn("dbo.Users", "department");
            DropColumn("dbo.Users", "position_name");
            DropColumn("dbo.Users", "address");
        }
    }
}

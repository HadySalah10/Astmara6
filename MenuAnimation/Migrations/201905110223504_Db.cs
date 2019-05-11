namespace Astmara6.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Db : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Branches", "TypeOfBranch", c => c.String());
            DropColumn("dbo.Branches", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Branches", "Name", c => c.String(maxLength: 100));
            DropColumn("dbo.Branches", "TypeOfBranch");
        }
    }
}
